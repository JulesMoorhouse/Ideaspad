
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Reflection

Public Class BevelButton
    Inherits System.Windows.Forms.Button

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Public Enum FlatStyleEx As Integer
        [Flat]
        [Popup]
        [Standard]
        [System]
        [Bevel]
    End Enum

#Region " Overridden Properties "

    'FlatStyle
    <DefaultValue(GetType(FlatStyleEx), "Standard"), _
    Category("Appearance"), _
    Description("Determines the display of the control " & _
    "when users move the mouse over the control and click.")> _
    Public Shadows Property FlatStyle() As FlatStyleEx
        Get
            Return m_FlatStyle
        End Get
        Set(ByVal Value As FlatStyleEx)
            If [Enum].IsDefined(GetType(FlatStyleEx), Value) Then
                If m_FlatStyle.Equals(Value) Then Return
                If Value = FlatStyleEx.Bevel Then
                    MyBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                Else
                    MyBase.FlatStyle = CType(Value, FlatStyle)
                End If
                m_FlatStyle = Value
                Invalidate()
            End If
        End Set
    End Property

#End Region

#Region " Properties "

    Private Enum e_ButtonState As Integer
        [Normal] = 1
        [Hot]
        [Pressed]
        [Disabled]
        [Focused]
    End Enum

    Private Property ButtonDrawState() As e_ButtonState
        Get
            Return m_ButtonDrawState
        End Get
        Set(ByVal Value As e_ButtonState)
            If [Enum].IsDefined(GetType(e_ButtonState), Value) Then
                If m_ButtonDrawState.Equals(Value) Then Return
                m_ButtonDrawState = Value
                Invalidate()
            End If
        End Set
    End Property

    Private ReadOnly Property ControlRegion() As Region
        Get
            Dim b As Rectangle = Bounds
            b.Offset(-Left, -Top)
            Return New Region(b)
        End Get
    End Property

    Private m_AllowVisualStyles As Boolean = True
    <DefaultValue(True), _
    Category("Appearance"), _
    Description("Allows Windows XP Visual Styles when Flatstyle is set to Standard.")> _
    Public Property AllowVisualStyles() As Boolean
        Get
            Return m_AllowVisualStyles
        End Get
        Set(ByVal Value As Boolean)
            m_AllowVisualStyles = Value
        End Set
    End Property

    
    Private m_TurnOffRoundedRect As Boolean = False
    <DefaultValue(False), _
    Category("Appearance"), _
    Description("Allows rounded rectangle to be turned off")> _
    Public Property TurnOffRoundedRect() As Boolean
        Get
            Return m_TurnOffRoundedRect
        End Get
        Set(ByVal Value As Boolean)
            m_TurnOffRoundedRect = Value
        End Set
    End Property
    

    '
    'Private m_AdjustTextVert As Integer
    '<DefaultValue(0), _
    'Category("Appearance"), _
    'Description("Adjust vertical position of text")> _
    'Public Property AdjustTextVert() As Integer
    '    Get
    '        Return m_AdjustTextVert
    '    End Get
    '    Set(ByVal Value As Integer)
    '        m_AdjustTextVert = Value
    '    End Set
    'End Property
    '
    'CornerRadius
    <DefaultValue(GetType(Int16), "8"), _
    Category("Appearance"), _
    Description("Returns/sets the radius of button corners. " & _
    "If setting is greater than height or width of button then the " & _
    "radius is overridden. This setting is only valid for Buttons " & _
    "with FlatStyle set to Bevel.")> _
    Public Property CornerRadius() As Int16
        Get
            Return m_CornerRadius
        End Get
        Set(ByVal Value As Int16)
            If m_CornerRadius.Equals(Value) Then Return
            m_CornerRadius = Value
            Invalidate()
        End Set
    End Property

#End Region

#Region " Private Instance Variables "

    Private m_ButtonDrawState As e_ButtonState = e_ButtonState.Normal
    Private m_HotKey As Boolean = AcceleratorVisible()
    Private m_KeyDown As Boolean = False
    Private WithEvents MyParent As Control = Me.parent
    Private m_CornerRadius As Int16 = 8
    Private m_FlatStyle As FlatStyleEx = FlatStyleEx.Standard

#End Region

#Region " Overridden Events "
    Protected Overrides Sub OnPaint(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim R As New Rectangle(0, 0, Width, Height)


        Select Case m_FlatStyle

            Case FlatStyleEx.Bevel
                R.Inflate(-4, -4)
                DrawParentBackground(pevent.Graphics)
                DrawBevelButton(pevent.Graphics)
                DrawButtonText(pevent.Graphics, R)
                DrawButtonImage(pevent.Graphics)
                Return

            Case FlatStyleEx.Standard
                If m_AllowVisualStyles Then
                    If DrawBackground(Me, pevent.Graphics, 1, m_ButtonDrawState, "Button") Then
                        MyBase.Region = Nothing
                        DrawButtonText(pevent.Graphics, R)
                        DrawButtonImage(pevent.Graphics)
                        'If we got this far then we have successfully painted an
                        'XPStyle Button, so don't call default OnPaint() event.
                        Return
                    End If
                End If

            Case Else

        End Select

        MyBase.Region = Nothing
        MyBase.OnPaint(pevent)

    End Sub
    Protected Overrides Sub OnParentBackColorChanged(ByVal e As System.EventArgs)
        MyBase.OnParentBackColorChanged(e)
        Invalidate()
    End Sub
#Region " Control Actions "
    Protected Overrides Sub OnKeyDown(ByVal kevent As System.Windows.Forms.KeyEventArgs)
        MyBase.OnKeyDown(kevent)
        If Not Me.Enabled Then Return
        If kevent.KeyValue = Keys.Space Then
            m_KeyDown = True
            ButtonDrawState = e_ButtonState.Pressed
        End If
    End Sub
    Protected Overrides Sub OnKeyUp(ByVal kevent As System.Windows.Forms.KeyEventArgs)
        MyBase.OnKeyUp(kevent)
        If Not Me.Enabled Then Return
        If kevent.KeyValue = Keys.Space Then
            m_KeyDown = False
            ButtonDrawState = e_ButtonState.Focused
        End If
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal eventargs As System.EventArgs)
        MyBase.OnMouseEnter(eventargs)
        If Me.Enabled And Not m_KeyDown Then
            ButtonDrawState = e_ButtonState.Hot
        End If
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal eventargs As System.EventArgs)
        MyBase.OnMouseLeave(eventargs)
        If Me.Enabled And Not m_KeyDown Then
            If Me.IsDefault Then
                ButtonDrawState = e_ButtonState.Focused
            Else
                ButtonDrawState = e_ButtonState.Normal
            End If
        End If
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal mevent As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(mevent)
        If Not Me.Enabled Then Return
        If mevent.Button = MouseButtons.Left Then
            ButtonDrawState = e_ButtonState.Pressed
        End If
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal mevent As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(mevent)
        If Me.Enabled Then
            ButtonDrawState = e_ButtonState.Focused
        End If
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal mevent As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(mevent)
        If Not Me.Enabled Then Return
        If ControlRegion.IsVisible(mevent.X, mevent.Y) AndAlso mevent.Button = MouseButtons.Left Then
            ButtonDrawState = e_ButtonState.Pressed
        Else
            If m_KeyDown Then Return
            ButtonDrawState = e_ButtonState.Hot
        End If
    End Sub
    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        MyBase.OnGotFocus(e)
        If Me.Enabled Then
            ButtonDrawState = e_ButtonState.Focused
        End If
    End Sub
    Protected Overrides Sub OnLostFocus(ByVal e As System.EventArgs)
        MyBase.OnLostFocus(e)
        If Me.Enabled Then
            ButtonDrawState = e_ButtonState.Normal
        End If
    End Sub
    Protected Overrides Sub OnEnabledChanged(ByVal e As System.EventArgs)
        MyBase.OnEnabledChanged(e)
        If Me.Enabled Then
            ButtonDrawState = e_ButtonState.Normal
        Else
            ButtonDrawState = e_ButtonState.Disabled
        End If
    End Sub
    Protected Overrides Sub OnChangeUICues(ByVal e As System.Windows.Forms.UICuesEventArgs)
        MyBase.OnChangeUICues(e)
        If e.ShowKeyboard Then
            m_HotKey = True
        End If
    End Sub
    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)
        MyBase.OnClick(e)
        MyBase.OnLostFocus(EventArgs.Empty)
    End Sub
    Protected Overrides Sub OnDoubleClick(ByVal e As System.EventArgs)
        MyBase.OnClick(e)
        MyBase.OnLostFocus(EventArgs.Empty)
    End Sub
    Protected Overrides Sub OnParentChanged(ByVal e As System.EventArgs)
        MyBase.OnParentChanged(e)
        MyParent = Me.Parent
    End Sub
#End Region

#End Region

#Region " Accelerator Key Initialisation "
    <DllImport("user32.dll", _
    CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function SystemParametersInfo( _
            ByVal uAction As Int32, _
            ByVal uParam As Int32, _
            ByRef lpvParam As Boolean, _
            ByVal fuWinIni As Int32) As Int32
    End Function
    Private Const SPI_GETKEYBOARDCUES As Integer = &H100A
    Private Function AcceleratorVisible() As Boolean
        Dim HotKey As Boolean = True
        SystemParametersInfo(SPI_GETKEYBOARDCUES, Nothing, HotKey, Nothing)
        Return HotKey
    End Function
#End Region

    Private Function RoundedRect(ByVal r As Rectangle, ByVal radius As Int32) As GraphicsPath

        Dim gp As GraphicsPath = New GraphicsPath()

        gp.AddLine(r.Left, r.Bottom - (radius \ 2), r.Left, r.Top + (radius \ 2))
        gp.AddArc(r.Left, r.Top, radius, radius, 180, 90)
        gp.AddLine(r.Left + (radius \ 2), r.Top, r.Right - (radius \ 2), r.Top)
        gp.AddArc(r.Right - radius, r.Top, radius, radius, 270, 90)
        gp.AddLine(r.Right, r.Top + (radius \ 2), r.Right, r.Bottom - (radius \ 2))
        gp.AddArc(r.Right - radius, r.Bottom - radius, radius, radius, 0, 90)
        gp.AddLine(r.Right - (radius \ 2), r.Bottom, r.Left + (radius \ 2), r.Bottom)
        gp.AddArc(r.Left, r.Bottom - radius, radius, radius, 90, 90)

        Return gp

    End Function
    Private Sub DrawBevelButton(ByVal g As Graphics)

        Dim r As Rectangle = New Rectangle(0, 0, Width, Height)
        Dim rad As Integer = m_CornerRadius
        If rad >= Height Then rad = Height - 2
        If rad >= Width Then rad = Width - 2

        Dim gp As GraphicsPath = RoundedRect(r, rad)

        MyBase.Region = New Region(gp)

        'These two colours are the rounded rectangle colours
        Dim LightColor As Color = ControlPaint.LightLight(Parent.BackColor)
        Dim DarkColor As Color = ControlPaint.DarkDark(Parent.BackColor)

        Dim GradBrush As New LinearGradientBrush(r, LightColor, DarkColor, Drawing2D.LinearGradientMode.ForwardDiagonal)

        g.SmoothingMode = SmoothingMode.HighQuality

        r.Inflate(-1, -1)
        gp = RoundedRect(r, rad)

        If m_TurnOffRoundedRect = False Then 
            g.FillPath(GradBrush, gp)
        End If 
        LightColor = ControlPaint.Light(Parent.BackColor)
        DarkColor = ControlPaint.Dark(Parent.BackColor)
        GradBrush.LinearColors = New Color() {DarkColor, LightColor}

        r.Inflate(-3, -3)
        gp = RoundedRect(r, rad)

        If m_TurnOffRoundedRect = False Then 
            g.FillPath(GradBrush, gp)
        End If

        LightColor = ControlPaint.Light(BackColor)
        DarkColor = ControlPaint.Dark(BackColor)
        GradBrush.GammaCorrection = True

        GradBrush.LinearColors = New Color() {LightColor, DarkColor}
        r.Inflate(-1, -1)
        If m_ButtonDrawState = e_ButtonState.Pressed Then
            GradBrush.LinearColors = New Color() {DarkColor, LightColor}
        Else
            GradBrush.LinearColors = New Color() {LightColor, DarkColor}
        End If

        gp = RoundedRect(r, rad)

        g.FillPath(GradBrush, gp)


        GradBrush.Dispose()
        gp.Dispose()

    End Sub
    Private Sub DrawButtonText(ByVal g As Graphics, ByVal r As Rectangle)

        Dim TextBrush As New SolidBrush(Me.ForeColor)
        If Not Me.Enabled Then TextBrush.Color = SystemColors.GrayText

        Dim sf As New StringFormat()
        If m_HotKey Then
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
        Else
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Hide
        End If

        Dim rad As Int16 = m_CornerRadius
        If rad >= (Height \ 2) Then rad = CShort((Height \ 2) - 2)
        If rad >= (Width \ 2) Then rad = CShort((Width \ 2) - 2)
        Dim RectFix As Int16 = CShort(rad / 2)
        Dim b_FixRect As Boolean = (m_FlatStyle = FlatStyleEx.Bevel)

        Select Case Me.TextAlign
            Case ContentAlignment.TopLeft
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Near
                If b_FixRect Then r.Inflate(-RectFix, 0)
            Case ContentAlignment.TopCenter
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Near
            Case ContentAlignment.TopRight
                sf.Alignment = StringAlignment.Far
                sf.LineAlignment = StringAlignment.Near
                If b_FixRect Then r.Inflate(-RectFix, 0)
            Case ContentAlignment.MiddleLeft
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Center
            Case ContentAlignment.MiddleCenter
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Center
            Case ContentAlignment.MiddleRight
                sf.Alignment = StringAlignment.Far
                sf.LineAlignment = StringAlignment.Center
            Case ContentAlignment.BottomLeft
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Far
                If b_FixRect Then r.Inflate(-RectFix, 0)
            Case ContentAlignment.BottomCenter
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Far
            Case Else
                sf.Alignment = StringAlignment.Far
                sf.LineAlignment = StringAlignment.Far
                If b_FixRect Then r.Inflate(-RectFix, 0)
        End Select

        r.Inflate(-2, -2)

        If Me.Enabled Then
            g.DrawString(Me.Text, Me.Font, TextBrush, RectangleF.op_Implicit(r), sf)
        Else
            If m_FlatStyle = FlatStyleEx.Standard Then
                g.DrawString(Me.Text, Me.Font, TextBrush, RectangleF.op_Implicit(r), sf)
            Else
                ControlPaint.DrawStringDisabled(g, Me.Text, Me.Font, Me.BackColor, RectangleF.op_Implicit(r), sf)
            End If
        End If

    End Sub
    Private Sub DrawButtonImage(ByVal g As Graphics)

        If Me.Image Is Nothing Then Return


        Dim rad As Int16 = m_CornerRadius
        If rad >= (Height \ 2) Then rad = CShort((Height \ 2) - 2)
        If rad >= (Width \ 2) Then rad = CShort((Width \ 2) - 2)
        Dim PtFix As Int16 = CShort(rad / 2)
        Dim b_FixPt As Boolean = (m_FlatStyle = FlatStyleEx.Bevel)

        Dim pt As Point
        Select Case Me.ImageAlign
            Case ContentAlignment.TopLeft
                pt.X = 7
                pt.Y = 7
                If b_FixPt Then pt.Offset(PtFix, 0)
            Case ContentAlignment.TopCenter
                pt.X = CInt(Width \ 2 - Me.Image.Width \ 2)
                pt.Y = 7
            Case ContentAlignment.TopRight
                pt.X = CInt(Width - Me.Image.Width - 7)
                pt.Y = 7
                If b_FixPt Then pt.Offset(-PtFix, 0)
            Case ContentAlignment.MiddleLeft
                pt.X = 7
                pt.Y = CInt(Height / 2 - Me.Image.Height / 2)
            Case ContentAlignment.MiddleCenter
                pt.X = CInt(Width / 2 - Me.Image.Width / 2)
                pt.Y = CInt(Height / 2 - Me.Image.Height / 2)
            Case ContentAlignment.MiddleRight
                pt.X = CInt(Width - Me.Image.Width - 7)
                pt.Y = CInt(Height / 2 - Me.Image.Height / 2)
            Case ContentAlignment.BottomLeft
                pt.X = 7
                pt.Y = CInt(Height - Me.Image.Height - 7)
                If b_FixPt Then pt.Offset(PtFix, 0)
            Case ContentAlignment.BottomCenter
                pt.X = CInt(Width / 2 - Me.Image.Width / 2)
                pt.Y = CInt(Height - Me.Image.Height - 7)
            Case Else
                pt.X = CInt(Width - Me.Image.Width - 7)
                pt.Y = CInt(Height - Me.Image.Height - 7)
                If b_FixPt Then pt.Offset(-PtFix, 0)
        End Select

        If Me.Enabled Then
            g.DrawImage(Me.Image, pt.X, pt.Y)
        Else
            ControlPaint.DrawImageDisabled(g, Me.Image, pt.X, pt.Y, Me.BackColor)
        End If

    End Sub
    Private Sub DrawParentBackground(ByVal g As Graphics)
        'Simply applying SetStyle(ControlStyles.SupportsTransparentBackground, True) at Sub New() would do 
        'away with the need for this method, if we set the background to Transparent.
        'However, we want to paint the border in the Parents backcolor and choose a 
        'backcolor for the actual button so we can't do that.

        'create Bitmap for Control's BackGround
        Dim bmp As New Bitmap(Parent.Width, Parent.Height)
        Dim gr As Graphics = Graphics.FromImage(bmp)

        'fill the Bitmap with parent's backcolor
        gr.Clear(Parent.BackColor)

        '---- Paint parent's BackGroundImage to the Bitmap ------------
        If Not Parent.BackgroundImage Is Nothing Then
            Dim tb As New TextureBrush(Parent.BackgroundImage)
            gr.FillRectangle(tb, 0, 0, bmp.Width, bmp.Height)
            tb.Dispose()
        End If
        '--------------------------------------------------------------

        '---- Paint parent's Image to the Bitmap ----------------------
        'Get Parents properties
        Dim props() As PropertyInfo = Parent.GetType.GetProperties()

        Dim b_Sizemode As Boolean = False
        Dim b_Image As Boolean = False
        Dim bm As Bitmap = Nothing
        Dim PicSM As PictureBoxSizeMode = PictureBoxSizeMode.Normal

        'Check properties for Image and SizeMode and set flags if they exist.
        Dim p As PropertyInfo

        For Each p In props
            If p.PropertyType Is GetType(PictureBoxSizeMode) Then
                b_Sizemode = True
            ElseIf p.Name = "Image" Then
                b_Image = True
            End If
        Next

        'Try to get Image properties Value
        If b_Image Then
            Try
                bm = New Bitmap( _
                        CType(Parent.GetType.InvokeMember("Image", _
                            BindingFlags.GetProperty Or BindingFlags.Public Or BindingFlags.Instance, _
                            Nothing, Parent, Nothing), Bitmap))
            Catch ex As Exception
            End Try
            'Try to get SizeMode properties Value.
            If b_Sizemode Then
                Try
                    PicSM = _
                        CType(Parent.GetType.InvokeMember("SizeMode", _
                        BindingFlags.GetProperty Or BindingFlags.Instance Or BindingFlags.Public, _
                        Nothing, Parent, Nothing), PictureBoxSizeMode)
                    If PicSM = PictureBoxSizeMode.CenterImage Then
                        g.DrawImage(bm, CInt((bmp.Width / 2) - (bm.Width / 2)), CInt((bmp.Height / 2) - (bm.Height / 2)))
                    ElseIf PicSM = PictureBoxSizeMode.StretchImage Then
                        bm = New Bitmap(bm, Parent.Size)
                    End If
                Catch ex As Exception
                End Try
            End If

            If Not bm Is Nothing AndAlso PicSM <> PictureBoxSizeMode.CenterImage Then
                gr.DrawImage(bm, 0, 0)
            End If

        End If
        '--------------------------------------------------------------

        'Paint Bitmap to controls Background
        g.DrawImage(bmp, 0, 0, Bounds, GraphicsUnit.Pixel)

        '---- Clean Up ------------------------------------------------
        bmp.Dispose()
        gr.Dispose()
        '--------------------------------------------------------------

    End Sub
    Private Sub MyParent_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyParent.Resize
        Invalidate()
    End Sub
End Class

Module XPVisualStyles
#Region " API Declares "

    <DllImport("Comctl32.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Function DllGetVersion( _
            ByRef pdvi As DLLVERSIONINFO) As Integer
    End Function

    Structure DLLVERSIONINFO
        Dim cbSize As Integer
        Dim dwMajorVersion As Integer
        Dim dwMinorVersion As Integer
        Dim dwBuildNumber As Integer
        Dim dwPlatformID As Integer
        Public Sub New(ByVal Owner As Object)
            cbSize = Marshal.SizeOf(GetType(DLLVERSIONINFO))
        End Sub
    End Structure

    <DllImport("UxTheme.dll", _
    CallingConvention:=CallingConvention.Cdecl)> _
    Function IsAppThemed() As Boolean
    End Function

    <DllImport("UxTheme.dll", _
    CallingConvention:=CallingConvention.Cdecl, _
    CharSet:=CharSet.Unicode)> _
    Function OpenThemeData( _
            ByVal hwnd As IntPtr, _
            ByVal pszClassList As String) As IntPtr
    End Function

    <DllImport("UxTheme.dll", _
    CallingConvention:=CallingConvention.Cdecl)> _
    Function CloseThemeData( _
            ByVal hTheme As IntPtr) As Integer
    End Function

    <DllImport("UxTheme.dll", _
    CallingConvention:=CallingConvention.Cdecl)> _
    Function DrawThemeParentBackground _
        (ByVal hwnd As IntPtr, _
        ByVal hdc As IntPtr, _
        ByRef prc As RECT) As Integer
    End Function

    <DllImport("UxTheme.dll", _
    CallingConvention:=CallingConvention.Cdecl)> _
    Function DrawThemeBackground( _
            ByVal hTheme As IntPtr, _
            ByVal hdc As IntPtr, _
            ByVal iPartId As Integer, _
            ByVal iStateId As Integer, _
            ByRef pRect As RECT, _
            ByRef pClipRect As RECT) As Integer
    End Function

    <DllImport("uxtheme.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Function GetThemePartSize _
            (ByVal hTheme As IntPtr, _
            ByVal hdc As IntPtr, _
            ByVal iPartId As Integer, _
            ByVal iStateId As Integer, _
            ByRef prc As Rectangle, _
            ByVal eSize As THEMESIZE, _
            ByRef psz As Size) As Integer
    End Function

    Enum THEMESIZE As Integer
        TS_MIN
        TS_TRUE
        TS_DRAW
    End Enum

    Structure RECT
        Public Left, Top, Right, Bottom As Integer
    End Structure

    Const S_OK As Integer = 0

#End Region

    Function XPStyled(ByVal o As Object) As Boolean
        Dim dllver As New DLLVERSIONINFO(o)
        DllGetVersion(dllver)
        If (dllver.dwMajorVersion >= 6) Then
            Return IsAppThemed()
        End If
    End Function
    Function DrawParentBackground(ByRef c As Control, ByRef hdc As IntPtr, ByVal R As RECT) As Integer
        If XPStyled(c) Then
            Return DrawThemeParentBackground(c.Handle, hdc, R)
        End If
    End Function
    Function DrawBackground(ByRef c As Control, ByRef g As Graphics, ByVal Part As Integer, ByVal PartState As Integer, ByVal ClassName As String, ByVal R As Rectangle) As Boolean

        Dim hTheme As IntPtr = OpenThemeData(c.Handle, ClassName)
        Dim iReturn As Integer = 1
        Dim m_Rect As RECT

        m_Rect.Left = R.X
        m_Rect.Top = R.Y
        m_Rect.Right = R.X + R.Width
        m_Rect.Bottom = R.Y + R.Height

        If XPStyled(c) Then
            If Not hTheme.Equals(IntPtr.Zero) Then

                '---- Draw Background -------------------------------------
                Dim hdc As IntPtr = g.GetHdc
                iReturn = DrawParentBackground(c, hdc, m_Rect)
                '----------------------------------------------------------

                '---- Draw Control ----------------------------------------
                If iReturn.Equals(S_OK) Then
                    iReturn = DrawThemeBackground(hTheme, hdc, Part, PartState, m_Rect, m_Rect)
                End If

                g.ReleaseHdc(hdc)
                CloseThemeData(hTheme)
                '----------------------------------------------------------

            End If

        End If

        Return CBool(iReturn = S_OK)

    End Function
    Function DrawBackground(ByRef c As Control, ByRef g As Graphics, ByVal Part As Integer, ByVal PartState As Integer, ByVal ClassName As String) As Boolean
        Dim Rect As New Rectangle(0, 0, c.Width, c.Height)
        Return DrawBackground(c, g, Part, PartState, ClassName, Rect)
    End Function
End Module
