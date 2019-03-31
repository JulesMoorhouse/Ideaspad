Imports System.Drawing.Drawing2D
Imports System.Collections

<ProvideProperty("ImageIndex", GetType(MenuItem)), _
 ProvideProperty("ImageList", GetType(MenuItem)), _
 DefaultProperty("ImageList")> _
Public Class EnhancedMenu

    Inherits Component

    Implements IExtenderProvider

#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()
        'Required for Windows.Forms Class Composition Designer support        
        Container.Add(Me)
    End Sub

    Public Sub New()
        MyBase.New()
        'This call is required by the Component Designer.
        InitializeComponent()
        mcolProps = New Hashtable()
        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
            If Not mcolProps Is Nothing Then
                Dim mnu As MenuItem 
                For Each mnu In mcolProps.Keys 'For Each mnu As MenuItem In mcolProps.Keys
                    With mnu
                        RemoveHandler .Select, AddressOf OnSelectItem
                        RemoveHandler .MeasureItem, AddressOf OnMeasureItem
                        RemoveHandler .DrawItem, AddressOf OnDrawItem

                        If Not sarrSubClass Is Nothing AndAlso TypeOf .Parent Is MainMenu Then sarrSubClass(cintMnuRec).Remove(mnu)
                    End With
                Next
                mcolProps = Nothing
                smnuLastSelected = Nothing
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    Private WithEvents mimgListChecked As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(EnhancedMenu))
        Me.mimgListChecked = New System.Windows.Forms.ImageList(Me.components)
        '
        'mimgListChecked
        '
        Me.mimgListChecked.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.mimgListChecked.ImageSize = New System.Drawing.Size(16, 16)
        Me.mimgListChecked.ImageStream = CType(resources.GetObject("mimgListChecked.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.mimgListChecked.TransparentColor = System.Drawing.Color.Transparent

    End Sub

#End Region

    Private Const cintShadow As Integer = 3
    Private Const cintWndProc As Integer = 0
    Private Const cintMnuRec As Integer = 1
    Private Const cintHwndRec As Integer = 2
    Private Const cintMnuHwnd As Integer = 3
    Private Const cintHwndMnu As Integer = 4

    Private Shared sdelHookProc As Win32API.HookProc
    Private Shared sdelWndProc As Win32API.WndProc
    Private Shared spintHookHandle As IntPtr
    Private Shared sarrSubClass() As Hashtable
    Private Shared smnuLastSelected As MenuItem
    Private Shared sblnDrawShadow As Boolean

    Private Shared SystemPensControlDark As Pen = SystemPens.ControlDark
    Private Shared SystemPensHighlight As Pen = SystemPens.Highlight
    Private Shared SystemPensControl As Pen = SystemPens.Control

    Private Shared SystemColorsControl As Color = SystemColors.Control
    Private Shared SystemColorsWindow As Color = SystemColors.Window
    Private Shared SystemColorsHighlight As Color = SystemColors.Highlight

    Dim FirstText As String = ""

    Private Shared Function GetShadowPens() As Pen()
        Dim arrPens(cintShadow - 1) As Pen
        Dim intAlphaOffset As Integer = 35
        Dim intMaxAlpha As Integer = cintShadow * intAlphaOffset
        Dim intIndex As Integer 
        For intIndex = 0 To arrPens.GetUpperBound(0) 'For intIndex As Integer = 0 To arrPens.GetUpperBound(0)
            arrPens(intIndex) = New Pen(Color.FromArgb(intMaxAlpha - (intIndex * intAlphaOffset), Color.Black))
        Next
        Return arrPens
    End Function
    Private Shared Sub Unsubclass(ByVal hwnd As IntPtr, ByVal wndproc As IntPtr)
        sarrSubClass(cintWndProc).Remove(hwnd)
        sarrSubClass(cintHwndRec).Remove(hwnd)
        If Not sarrSubClass(cintHwndMnu)(hwnd) Is Nothing Then
            Dim mnu As MenuItem = DirectCast(sarrSubClass(cintHwndMnu)(hwnd), MenuItem)
            sarrSubClass(cintMnuHwnd).Remove(mnu)
            With mnu
                .Enabled = Not .Enabled
                .Enabled = Not .Enabled
            End With
            sarrSubClass(cintHwndMnu).Remove(hwnd)
        End If
        Win32API.SetWindowLong(hwnd, Win32API.GWL_WNDPROC, wndproc)
    End Sub
    Private Shared Function WndProc(ByVal hwnd As IntPtr, ByVal msg As Integer, ByVal wparam As IntPtr, ByVal lparam As IntPtr) As Integer
        Dim pintWndProc As IntPtr = DirectCast(sarrSubClass(cintWndProc)(hwnd), IntPtr)
        Select Case msg
            Case Win32API.WM_NCCALCSIZE
                If sblnDrawShadow Then
                    Dim intResult As Integer = Win32API.CallWindowProc(pintWndProc, hwnd, msg, wparam, lparam)
                    Dim ncp As Win32API.NCCALCSIZE_PARAMS = DirectCast(Runtime.InteropServices.Marshal.PtrToStructure(lparam, GetType(Win32API.NCCALCSIZE_PARAMS)), Win32API.NCCALCSIZE_PARAMS)
                    ncp.rgrc0.Right -= cintShadow
                    ncp.rgrc0.Bottom -= cintShadow
                    Runtime.InteropServices.Marshal.StructureToPtr(ncp, lparam, True)
                    Return intResult
                End If
            Case Win32API.WM_WINDOWPOSCHANGING
                If sblnDrawShadow OrElse sarrSubClass(cintHwndRec)(hwnd) Is Nothing Then
                    Dim wpos As Win32API.WINDOWPOS = DirectCast(Runtime.InteropServices.Marshal.PtrToStructure(lparam, GetType(Win32API.WINDOWPOS)), Win32API.WINDOWPOS)
                    If sarrSubClass(cintHwndRec)(hwnd) Is Nothing Then
                        wpos.x += cintShadow + 2
                        wpos.y += cintShadow
                    End If
                    If sblnDrawShadow Then
                        wpos.cx += cintShadow
                        wpos.cy += cintShadow
                    End If
                    Runtime.InteropServices.Marshal.StructureToPtr(wpos, lparam, True)
                    Return 0
                End If
            Case Win32API.WM_NCPAINT
                DrawBorder(hwnd, IntPtr.Zero)
                Return 0
            Case Win32API.WM_PRINT
                Dim intResult As Integer = Win32API.CallWindowProc(pintWndProc, hwnd, msg, wparam, lparam)
                DrawBorder(hwnd, wparam)
                Return intResult
            Case Win32API.WM_DESTROY
                Unsubclass(hwnd, pintWndProc)
            Case Win32API.WM_SHOWWINDOW
                If wparam.Equals(IntPtr.Zero) Then Unsubclass(hwnd, pintWndProc)
        End Select
        Return Win32API.CallWindowProc(pintWndProc, hwnd, msg, wparam, lparam)
    End Function
    Private Shared Function HookProc(ByVal code As Integer, ByVal wparam As IntPtr, ByRef cwp As Win32API.CWPSTRUCT) As Integer
        If code = Win32API.HC_ACTION AndAlso (cwp.message = Win32API.WM_CREATE OrElse (cwp.message = Win32API.WM_SHARED_MENU AndAlso sarrSubClass(cintWndProc)(cwp.hwnd) Is Nothing)) Then
            Dim sbClassName As New System.Text.StringBuilder(10)
            Win32API.GetClassName(cwp.hwnd, sbClassName, sbClassName.Capacity)
            If sbClassName.ToString = Win32API.MENU_CLASS Then
                sarrSubClass(cintWndProc)(cwp.hwnd) = Win32API.SetWindowLong(cwp.hwnd, Win32API.GWL_WNDPROC, sdelWndProc)
                If Not (smnuLastSelected Is Nothing OrElse sarrSubClass(cintMnuRec)(smnuLastSelected) Is Nothing) Then
                    sarrSubClass(cintHwndRec)(cwp.hwnd) = sarrSubClass(cintMnuRec)(smnuLastSelected)
                    sarrSubClass(cintMnuHwnd)(smnuLastSelected) = cwp.hwnd
                    sarrSubClass(cintHwndMnu)(cwp.hwnd) = smnuLastSelected
                    With smnuLastSelected
                        .Enabled = Not .Enabled
                        .Enabled = Not .Enabled
                    End With
                End If
            End If
        End If
        Return Win32API.CallNextHookEx(spintHookHandle, code, wparam, cwp)
    End Function
    Private Shared Sub DrawBorder(ByVal hwnd As IntPtr, ByVal hDc As IntPtr)
        Dim blnRelease As Boolean
        If hDc.Equals(IntPtr.Zero) Then
            hDc = Win32API.GetWindowDC(hwnd)
            blnRelease = True
        End If
        With Graphics.FromHdc(hDc)
            Dim rec As New Rectangle(0, 0, Convert.ToInt32(.VisibleClipBounds.Width), Convert.ToInt32(.VisibleClipBounds.Height))
            Dim pen As Pen
            If sblnDrawShadow Then
                rec.Width -= cintShadow
                rec.Height -= cintShadow
                Dim recShadowRight As New Rectangle(rec.Right, rec.Top + (cintShadow * 2), cintShadow, rec.Height - cintShadow)
                .FillRectangle(SystemBrushes.Control, recShadowRight)
                Dim recShadowBottom As New Rectangle(rec.X + (cintShadow * 2), rec.Bottom, rec.Width - cintShadow, cintShadow)
                .FillRectangle(SystemBrushes.Control, recShadowBottom)
                Dim arrPens As Pen() = GetShadowPens()
                Dim intIndex As Integer 
                For intIndex = 0 To arrPens.GetUpperBound(0) 'For intIndex As Integer = 0 To arrPens.GetUpperBound(0)
                    pen = arrPens(intIndex)
                    .DrawLine(pen, recShadowRight.X + intIndex, recShadowRight.Y, recShadowRight.X + intIndex, recShadowRight.Bottom - cintShadow + intIndex)
                    .DrawLine(pen, recShadowBottom.X, recShadowBottom.Y + intIndex, recShadowBottom.Right - cintShadow + intIndex, recShadowBottom.Y + intIndex)
                    pen.Dispose()
                Next
            End If
            rec.Width -= 1
            rec.Height -= 1
            .DrawRectangle(SystemPensControlDark, rec)
            pen = SystemPensControl
            rec.X += 1
            rec.Y += 1
            rec.Width -= 2
            rec.Height -= 2
            .DrawRectangle(pen, rec)
            rec.X += 1
            rec.Y += 1
            rec.Width -= 2
            rec.Height -= 2
            .DrawRectangle(pen, rec)
            If Not sarrSubClass(cintHwndRec)(hwnd) Is Nothing Then
                rec = DirectCast(sarrSubClass(cintHwndRec)(hwnd), Rectangle)
                Dim intWidth As Integer = rec.Width + rec.X + Form.ActiveForm.Location.X
                If intWidth > rec.Width Then intWidth = rec.Width
                intWidth -= 1
                If intWidth > 0 Then .DrawLine(pen, 1, 0, intWidth, 0)
            End If
            .Dispose()
        End With
        If blnRelease Then Win32API.ReleaseDC(hwnd, hDc)
    End Sub
    Public Shared Sub Hook(ByVal Form As Form)
        Unhook()
        With Environment.OSVersion
            sblnDrawShadow = Not (.Platform = PlatformID.Win32NT AndAlso (.Version.Major > 5 OrElse (.Version.Major = 5 AndAlso .Version.Minor > 0)))
        End With
        sarrSubClass = New Hashtable() {New Hashtable(), New Hashtable(), New Hashtable(), New Hashtable(), New Hashtable()}
        sdelHookProc = New Win32API.HookProc(AddressOf HookProc)
        sdelWndProc = New Win32API.WndProc(AddressOf WndProc)
        spintHookHandle = Win32API.SetWindowsHookEx(Win32API.WH_CALLWNDPROC, sdelHookProc, IntPtr.Zero, Win32API.GetWindowThreadProcessId(Form.Handle, 0))
    End Sub
    Public Overloads Shared Sub Unhook()
        If spintHookHandle.Equals(IntPtr.Zero) Then Return
        Win32API.UnhookWindowsHookEx(spintHookHandle)
        spintHookHandle = IntPtr.Zero
        sarrSubClass = Nothing
        sdelHookProc = Nothing
        sdelWndProc = Nothing
    End Sub
    Private Class ImageIndexEditor
        Inherits System.Drawing.Design.UITypeEditor
        Public Overloads Overrides Function GetPaintValueSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
            Return True
        End Function
        Public Overloads Overrides Sub PaintValue(ByVal e As System.Drawing.Design.PaintValueEventArgs)
            With e
                If .Context Is Nothing OrElse .Context.Instance Is Nothing OrElse Not TypeOf .Value Is Integer Then Return
                Dim intIndex As Integer = DirectCast(.Value, Integer)
                If intIndex < 0 Then Return
                Dim imgList As ImageList = DirectCast(TypeDescriptor.GetProperties(.Context.Instance).Find("ImageList", False).GetValue(.Context.Instance), ImageList)
                If imgList Is Nothing OrElse intIndex >= imgList.Images.Count Then Return
                .Graphics.DrawImage(imgList.Images(intIndex), .Bounds)
            End With
        End Sub
    End Class

    Private mimgList As ImageList
    Private mimgListMarks As ImageList
    Private mcolProps As Hashtable

    Private Sub OnSelectItem(ByVal sender As Object, ByVal e As System.EventArgs)
        smnuLastSelected = DirectCast(sender, MenuItem)
    End Sub
    Private Sub OnMeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs)
        With DirectCast(sender, MenuItem)
            If .Text = "-" Then
                e.ItemHeight = 3
            Else
                Dim blnTopLevel As Boolean = TypeOf .Parent Is MainMenu
                Dim sizeImage As Size
                If Not (mimgList Is Nothing OrElse blnTopLevel) Then sizeImage = mimgList.ImageSize
                Dim font As Font = SystemInformation.MenuFont
                If font.Height > sizeImage.Height Then e.ItemHeight = font.Height + 6 Else e.ItemHeight = sizeImage.Height + 6
                Dim intWidth As Integer
                Dim strText As String
                If .Shortcut <> Shortcut.None AndAlso .ShowShortcut AndAlso Not .IsParent Then
                    strText = .Text & TypeDescriptor.GetConverter(GetType(Keys)).ConvertToString(CType(.Shortcut, Keys))
                    intWidth = 25
                Else
                    strText = .Text
                End If
                'Dim sf As New StringFormat()
                Dim sf As New StringFormat(StringFormatFlags.NoWrap) 
                sf.HotkeyPrefix = Drawing.Text.HotkeyPrefix.Show
                intWidth += Convert.ToInt32(e.Graphics.MeasureString(strText, font, 10000, sf).Width)
                'Console.WriteLine(strText)
                sf.Dispose()
                If blnTopLevel Then
                    intWidth += 4
                Else
                    If mimgList Is Nothing Then intWidth += 25 Else intWidth += sizeImage.Width + 9
                    If .IsParent Then intWidth += 15
                End If
                e.ItemWidth = intWidth
            End If
        End With
    End Sub
    Dim FarestLeft(10) As Integer
    Dim FarestLeftInc(10) As Integer
    Dim FarestWidth(10) As Integer
    Dim RowCalc(10) As Integer
    Dim LastRow As Integer
    Dim AbsoluteTop As Integer
    'Private Event PaintMainPanel(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)

    Function CalcWhatMainItemsAreOnEachRow(ByVal CtlWidth As Integer, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        'added 
        Dim lintArrInc As Integer
        Dim CurrentRow As Integer
        Dim TempAccumRowWidth As Integer

        CtlWidth -= 28
        Dim t As String = Tab()
        Dim PaintBack As New UIStyle.Painting()

        For lintArrInc = 0 To MainMenuWidths.GetUpperBound(0)
            If MainMenuTexts(lintArrInc) <> "" Then
                TempAccumRowWidth += MainMenuWidths(lintArrInc) + 4
                'Console.WriteLine(TempAccumRowWidth & t & CtlWidth & t & MainMenuTexts(lintArrInc))
                If (TempAccumRowWidth + MainMenuWidths(lintArrInc + 1)) >= CtlWidth Then
                    CurrentRow += 1
                    'Console.WriteLine("Last MainMenu Item on Row " & CurrentRow & " is " & MainMenuTexts(lintArrInc))

                    Dim ExtraWidth As Integer = 0
                    If CurrentRow = 1 Then
                        ExtraWidth = 13
                    End If
                    Dim RequiredWidth As Integer = (CtlWidth - (TempAccumRowWidth + ExtraWidth)) + 24
                    'Dim ThisTop As Integer = AbsoluteTop + ((e.Bounds.Height + 1) * (LastRow - 1))
                    Dim ThisTop As Integer = (AbsoluteTop + ((e.Bounds.Height) * (LastRow - 1)))
                    'e.Graphics.DrawRectangle(New Pen(Color.Black), TempAccumRowWidth + 13, ThisTop, RequiredWidth, e.Bounds.Height + 1)
                    'e.Graphics.DrawRectangle(New Pen(Color.Black), TempAccumRowWidth + 13, ThisTop, RequiredWidth, e.Bounds.Height + 1)


                    'PaintBack.PaintBackgroundSection(e.Graphics, 4, e.Bounds.Top, e.Graphics.VisibleClipBounds.Width - 4, e.Bounds.Height + 1, _
                    '    TempAccumRowWidth + ExtraWidth, ThisTop, RequiredWidth, e.Bounds.Height + 1)

                    PaintBack.PaintBackgroundSection(e.Graphics, 4, e.Bounds.Top, e.Graphics.VisibleClipBounds.Width - 4, e.Bounds.Height + 1, _
                        TempAccumRowWidth + ExtraWidth, ThisTop, RequiredWidth, e.Bounds.Height)
                    'e.Graphics.DrawRectangle(New Pen(Color.Black), TempAccumRowWidth + ExtraWidth, ThisTop, RequiredWidth, e.Bounds.Height + 1)
                    TempAccumRowWidth = 0
                End If
            End If
        Next lintArrInc

        'Console.WriteLine("------")

    End Function

    Dim MainMenuWidths(10) As Integer
    Dim MainMenuTexts(10) As String
    Dim MainMenuLeft(10) As String
    Function AddToMainMenuWidths(ByVal ThisWidth As Integer, ByVal ThisText As String, ByVal ThisLeft As Integer)
        'added 
        Dim lintArrInc As Integer

        Dim LastRow As Integer = 0



        For lintArrInc = 0 To MainMenuTexts.GetUpperBound(0)
            If MainMenuTexts(lintArrInc) <> "" Then
                LastRow += 1
            End If
            If ThisText = MainMenuTexts(lintArrInc) Then
                Exit Function
            End If
        Next lintArrInc

        MainMenuWidths(LastRow) = ThisWidth
        MainMenuTexts(LastRow) = ThisText
        MainMenuLeft(LastRow) = ThisLeft


        'Console.WriteLine("------")
        'For lintArrInc = 0 To MainMenuWidths.GetUpperBound(0)
        '    Console.WriteLine(lintArrInc & " " & MainMenuWidths(lintArrInc) & " " & MainMenuTexts(lintArrInc))
        'Next lintArrInc

        'Console.WriteLine("------")
    End Function
    Function FindCurrentRow(ByVal CurrentRow As Integer, ByRef LastRow As Integer) As Boolean
        'added 
        Dim lintArrInc As Integer

        FindCurrentRow = False
        LastRow = 0

        For lintArrInc = 0 To RowCalc.GetUpperBound(0)
            If RowCalc(lintArrInc) <> 0 Then
                LastRow += 1
            End If
            If CurrentRow = RowCalc(lintArrInc) Then
                FindCurrentRow = True
                Exit Function
            End If
        Next lintArrInc

    End Function
    Dim LastItem As Integer = -1
    Private Sub OnDrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)


        Dim g As Graphics = e.Graphics
        Dim recBounds As Rectangle = e.Bounds
        Dim recImage As Rectangle
        Dim sizeImage As Size
        If mimgList Is Nothing Then
            recImage = New Rectangle(recBounds.X, recBounds.Y, 22, recBounds.Height)
        Else
            sizeImage = mimgList.ImageSize
            recImage = New Rectangle(recBounds.X, recBounds.Y, sizeImage.Width + 6, recBounds.Height)
        End If
        Dim recRight As New Rectangle(recImage.Right, recImage.Y, recBounds.Width - recImage.Width, recImage.Height)
        Dim blend As New Blend()
        blend.Positions = New Single() {0.0F, 1.0F}
        ReDim blend.Factors(1)
        Dim lgbrush As LinearGradientBrush
        With DirectCast(sender, MenuItem)
            If .Text = "-" Then
                blend.Factors(0) = 0.8F
                blend.Factors(1) = 0.8F
                lgbrush = New LinearGradientBrush(recRight, SystemColorsControl, SystemColorsWindow, LinearGradientMode.Horizontal)
                lgbrush.Blend = blend
                g.FillRectangle(lgbrush, recRight)
                lgbrush.Dispose()
                blend.Factors(0) = 0.2F
                blend.Factors(1) = 0.2F
                lgbrush = New LinearGradientBrush(recImage, SystemColorsControl, SystemColorsWindow, LinearGradientMode.Horizontal)
                lgbrush.Blend = blend
                g.FillRectangle(lgbrush, recImage)
                lgbrush.Dispose()
                Dim recLine As New Rectangle(recRight.X + 3, recRight.Y + 1, recRight.Width - 3, 1)
                lgbrush = New LinearGradientBrush(recLine, SystemColorsControl, SystemColorsWindow, LinearGradientMode.Horizontal)
                lgbrush.Blend = blend
                g.FillRectangle(lgbrush, recLine)
                lgbrush.Dispose()
            Else
                Dim blnTopLevel As Boolean = TypeOf .Parent Is MainMenu
                If blnTopLevel Then
                    recBounds.Width -= (cintShadow * 2)
                    recBounds.Height -= 1
                    If Not sarrSubClass Is Nothing Then sarrSubClass(cintMnuRec)(sender) = recBounds

                End If
                Dim blnSelected As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected AndAlso (e.State And DrawItemState.Disabled) <> DrawItemState.Disabled
                If blnSelected Then
                    If blnTopLevel AndAlso (sarrSubClass Is Nothing OrElse Not sarrSubClass(cintMnuHwnd)(sender) Is Nothing) Then
                        blend.Factors(0) = 0.2F
                        blend.Factors(1) = 0.2F
                        lgbrush = New LinearGradientBrush(recBounds, SystemColorsControl, SystemColorsWindow, LinearGradientMode.Horizontal)
                        lgbrush.Blend = blend
                        g.FillRectangle(lgbrush, recBounds)
                        lgbrush.Dispose()
                        g.DrawRectangle(SystemPensControlDark, recBounds)
                        g.DrawLine(SystemPensControl, recBounds.X + 1, recBounds.Bottom, recBounds.Right - 1, recBounds.Bottom)
                        Dim recShadow As New Rectangle(recBounds.Right + 1, recBounds.Y + (cintShadow * 2), cintShadow, recBounds.Height - (cintShadow * 2))
                        Dim arrPens As Pen() = GetShadowPens()
                        Dim intIndex As Integer 
                        For intIndex = 0 To arrPens.GetUpperBound(0) 'For intIndex As Integer = 0 To arrPens.GetUpperBound(0)
                            g.DrawLine(arrPens(intIndex), recShadow.X + intIndex, recShadow.Y, recShadow.X + intIndex, recShadow.Bottom)
                            arrPens(intIndex).Dispose()
                        Next
                    Else
                        blend.Factors(0) = 0.7F
                        blend.Factors(1) = 0.7F
                        lgbrush = New LinearGradientBrush(recBounds, SystemColorsHighlight, SystemColorsWindow, LinearGradientMode.Horizontal)
                        lgbrush.Blend = blend
                        g.FillRectangle(lgbrush, recBounds)
                        lgbrush.Dispose()
                        If Not blnTopLevel Then
                            g.DrawRectangle(SystemPensHighlight, recBounds.X, recBounds.Y, recBounds.Width - 1, recBounds.Height - 1)
                        Else
                            g.DrawRectangle(SystemPensHighlight, recBounds)
                        End If
                    End If
                ElseIf (e.State And DrawItemState.HotLight) = DrawItemState.HotLight Then
                    blend.Factors(0) = 0.7F
                    blend.Factors(1) = 0.7F
                    lgbrush = New LinearGradientBrush(recBounds, SystemColorsHighlight, SystemColorsWindow, LinearGradientMode.Horizontal)
                    lgbrush.Blend = blend
                    g.FillRectangle(lgbrush, recBounds)
                    lgbrush.Dispose()
                    g.DrawRectangle(SystemPensHighlight, recBounds)
                ElseIf Not blnTopLevel Then
                    blend.Factors(0) = 0.8F
                    blend.Factors(1) = 0.8F
                    lgbrush = New LinearGradientBrush(recRight, SystemColorsControl, SystemColorsWindow, LinearGradientMode.Horizontal)
                    lgbrush.Blend = blend
                    g.FillRectangle(lgbrush, recRight)
                    lgbrush.Dispose()
                    blend.Factors(0) = 0.2F
                    blend.Factors(1) = 0.2F
                    lgbrush = New LinearGradientBrush(recImage, SystemColorsControl, SystemColorsWindow, LinearGradientMode.Horizontal)
                    lgbrush.Blend = blend
                    g.FillRectangle(lgbrush, recImage)
                    lgbrush.Dispose()
                Else

                    'Console.WriteLine("Else")
                    'g.FillRectangle(SystemBrushes.Control, recBounds.X, recBounds.Y, recBounds.Width + (cintShadow * 2), recBounds.Height + 1)
                    

                    If FindCurrentRow(recBounds.Top, LastRow) = False Then
                        RowCalc(LastRow) = recBounds.Top
                    End If
                    ''Console.WriteLine(LastRow)

                    If AbsoluteTop = 0 Then
                        AbsoluteTop = recBounds.Y
                    End If

                    Dim rf As New RectangleF()
                    rf = RectangleF.op_Implicit(recBounds)

                    Dim PaintBack As New UIStyle.Painting()
                    'If FarestLeftInc(LastRow) <= recBounds.X Then
                    '    FarestLeftInc(LastRow) = recBounds.X
                    '    FarestLeft(LastRow) = recBounds.X + recBounds.Width + (cintShadow * 2)
                    '    FarestWidth(LastRow) = (e.Graphics.VisibleClipBounds.Width - 4) - FarestLeft(LastRow)
                    'End If

                    If FarestLeftInc(LastRow) <= rf.X Then
                        FarestLeftInc(LastRow) = rf.X
                        FarestLeft(LastRow) = rf.X + rf.Width + (cintShadow * 2)
                        FarestWidth(LastRow) = (e.Graphics.VisibleClipBounds.Width - 4) - FarestLeft(LastRow)
                    End If

                    If blnTopLevel Then
                        'Convert rectangle to rectangleF for compliance with other code

                        AddToMainMenuWidths(rf.Width, .Text, rf.X)
                        CalcWhatMainItemsAreOnEachRow(e.Graphics.VisibleClipBounds.Width, e)
                        'e.Graphics.DrawRectangle(New Pen(Color.Black), e.Graphics.VisibleClipBounds.Left, e.Graphics.VisibleClipBounds.Top, e.Graphics.VisibleClipBounds.Width - 10, e.Graphics.VisibleClipBounds.Height)
                        If LastItem < e.Index Then
                            LastItem = e.Index
                        End If
                    End If

                    ''Paint far right shading
                    ''Put back in !!!!
                    ''PaintBack.PaintBackgroundSection(g, 4, recBounds.Top, e.Graphics.VisibleClipBounds.Width - 4, recBounds.Height + 1, _
                    ''    FarestLeft(LastRow), recBounds.Y, FarestWidth(LastRow), recBounds.Height + 1)
                    If LastItem = e.Index Then
                        Dim RequiredWidth As Integer = (e.Graphics.VisibleClipBounds.Width - 4) - (e.Bounds.X + e.Bounds.Width)

                        PaintBack.PaintBackgroundSection(g, 4, recBounds.Top, e.Graphics.VisibleClipBounds.Width - 4, recBounds.Height + 1, _
                            e.Bounds.X + e.Bounds.Width, recBounds.Y, RequiredWidth, recBounds.Height + 1)
                    End If

                    'Paint Main menu shading
                    PaintBack.PaintBackgroundSection(g, 4, recBounds.Top, e.Graphics.VisibleClipBounds.Width - 4, recBounds.Height + 1, _
                     recBounds.X, recBounds.Y, recBounds.Width + (cintShadow * 2), recBounds.Height + 1)
                    
                End If
                Dim sf As New StringFormat()
                sf.HotkeyPrefix = Drawing.Text.HotkeyPrefix.Show
                sf.LineAlignment = StringAlignment.Center
                Dim recText As RectangleF
                If blnTopLevel Then
                    recText = New RectangleF(recBounds.X, recBounds.Y, recBounds.Width, recBounds.Height)
                    sf.Alignment = StringAlignment.Center
                    ''Console.WriteLine(.Text)
                Else
                    recText = New RectangleF(recRight.X + 3.0F, recRight.Y, recRight.Width - 3.0F, recRight.Height)
                End If
                Dim brush As Brush
                If .Enabled Then brush = SystemBrushes.ControlText Else brush = SystemBrushes.ControlDark
                g.DrawString(.Text, SystemInformation.MenuFont, brush, recText, sf)

                If Not blnTopLevel Then
                    If .Shortcut <> Shortcut.None AndAlso .ShowShortcut AndAlso Not .IsParent Then
                        sf.HotkeyPrefix = Drawing.Text.HotkeyPrefix.None
                        sf.Alignment = StringAlignment.Near
                        Dim strShortcut As String = TypeDescriptor.GetConverter(GetType(Keys)).ConvertToString(CType(.Shortcut, Keys))
                        Dim sngWidth As Single = g.MeasureString(strShortcut, SystemInformation.MenuFont, recText.Size, sf).Width + 15.0F
                        g.DrawString(strShortcut, SystemInformation.MenuFont, brush, New RectangleF(recText.Right - sngWidth, recText.Y, sngWidth, recText.Height), sf)
                    End If
                    Dim img As Image
                    If Not mimgList Is Nothing Then
                        Dim intImgIndex As Integer = DirectCast(mcolProps(sender), Integer)

                        If intImgIndex < 1000 Then

                            If intImgIndex > -1 AndAlso intImgIndex < mimgList.Images.Count Then
                                img = mimgList.Images(intImgIndex)
                            End If
                        Else
                            intImgIndex -= 1000
                            If intImgIndex > -1 AndAlso intImgIndex < mimgListMarks.Images.Count Then
                                img = mimgListMarks.Images(intImgIndex)
                            End If
                        End If

                    End If

                    Dim intX, intY As Integer
                    If .Checked Then
                        Dim recCheck As New Rectangle(recImage.X + 1, recImage.Y + 1, recImage.Width - 4, recImage.Height - 3)
                        Dim pen As Pen
                        If .Enabled Then
                            If blnSelected Then
                                blend.Factors(0) = 0.5F
                                blend.Factors(1) = 0.5F
                            Else
                                blend.Factors(0) = 0.7F
                                blend.Factors(1) = 0.7F
                            End If
                            lgbrush = New LinearGradientBrush(recCheck, SystemColorsHighlight, SystemColorsWindow, LinearGradientMode.Horizontal)
                            lgbrush.Blend = blend
                            g.FillRectangle(lgbrush, recCheck)
                            lgbrush.Dispose()
                            pen = SystemPensHighlight
                        Else
                            pen = SystemPensControlDark
                        End If
                        g.DrawRectangle(pen, recCheck)
                        If img Is Nothing Then
                            If .RadioCheck Then
                                img = mimgListChecked.Images(1)
                            Else
                                img = mimgListChecked.Images(0)
                            End If
                        End If
                        intX = recCheck.X + ((recCheck.Width - img.Size.Width) \ 2) + 1
                        intY = recCheck.Y + ((recCheck.Height - img.Size.Height) \ 2) + 1
                        If .Enabled Then
                            g.DrawImage(img, intX, intY)
                        Else
                            ControlPaint.DrawImageDisabled(g, img, intX, intY, Color.Transparent)
                        End If
                    ElseIf Not img Is Nothing Then
                        intX = recImage.X + ((recImage.Width - sizeImage.Width) \ 2)
                        intY = recImage.Y + ((recImage.Height - sizeImage.Height) \ 2)
                        If Not .Enabled Then
                            ControlPaint.DrawImageDisabled(g, img, intX, intY, Color.Transparent)
                        Else
                            If blnSelected Then
                                ControlPaint.DrawImageDisabled(g, img, intX, intY, Color.Transparent)
                                intX -= 1
                                intY -= 1
                            End If
                            g.DrawImage(img, intX, intY)
                        End If
                    End If
                End If
                sf.Dispose()
            End If
        End With
    End Sub
    Public Function CanExtend(ByVal extendee As Object) As Boolean Implements System.ComponentModel.IExtenderProvider.CanExtend
        Return TypeOf extendee Is MenuItem OrElse TypeOf extendee Is ContextMenu
    End Function

    <Browsable(False)> _
    Public Function GetImageList(ByVal MenuItem As MenuItem) As ImageList
        Return mimgList
    End Function

    <Category("Appearance"), _
     TypeConverter(GetType(ImageIndexConverter)), _
     Editor(GetType(ImageIndexEditor), GetType(System.Drawing.Design.UITypeEditor)), _
     Description("The index of the image that will be painted on the menu's left hand side.")> _
    Public Function GetImageIndex(ByVal MenuItem As MenuItem) As Integer
        If Not mcolProps(MenuItem) Is Nothing Then Return DirectCast(mcolProps(MenuItem), Integer)
        Return -1
    End Function

    Public Sub SetImageIndex(ByVal MenuItem As MenuItem, ByVal Value As Integer)


        If mcolProps(MenuItem) Is Nothing Then
            With MenuItem
                .OwnerDraw = True
                AddHandler .Select, AddressOf OnSelectItem
                AddHandler .MeasureItem, AddressOf OnMeasureItem
                AddHandler .DrawItem, AddressOf OnDrawItem

            End With
            mcolProps.Add(MenuItem, Value)
        Else
            mcolProps(MenuItem) = Value
        End If
    End Sub

    <Description("The image list that contains the images that will be used to paint menus.")> _
    Public Property ImageList() As ImageList
        Get
            Return mimgList
        End Get
        Set(ByVal Value As ImageList)
            mimgList = Value
        End Set
    End Property

    Public Property ImageListMarks() As ImageList
        Get
            Return mimgListMarks
        End Get
        Set(ByVal Value As ImageList)
            mimgListMarks = Value
        End Set
    End Property

    <EditorBrowsable(EditorBrowsableState.Never)> _
    Public Function ShouldSerializeImageList() As Boolean
        Return Not mimgList Is Nothing
    End Function
    Public Property PensControlDark() As Pen
        Get
            Return SystemPensControlDark
        End Get
        Set(ByVal Value As Pen)
            SystemPensControlDark = Value
        End Set
    End Property
    Public Property PensHighlight() As Pen
        Get
            Return SystemPensHighlight
        End Get
        Set(ByVal Value As Pen)
            SystemPensHighlight = Value
        End Set
    End Property
    Public Property PensControl() As Pen
        Get
            Return SystemPensControl
        End Get
        Set(ByVal Value As Pen)
            SystemPensControl = Value
        End Set
    End Property
    Public Property ColorsControl() As Color
        Get
            Return SystemColorsControl
        End Get
        Set(ByVal Value As Color)
            SystemColorsControl = Value
        End Set
    End Property
    Public Property ColorsWindow() As Color
        Get
            Return SystemColorsWindow
        End Get
        Set(ByVal Value As Color)
            SystemColorsWindow = Value
        End Set
    End Property
    Public Property ColorsHighlight() As Color
        Get
            Return SystemColorsHighlight
        End Get
        Set(ByVal Value As Color)
            SystemColorsHighlight = Value
        End Set
    End Property

End Class
