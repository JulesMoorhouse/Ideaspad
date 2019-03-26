Imports System.Drawing.Drawing2D
Public Class Coolbar
    Inherits System.Windows.Forms.UserControl

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
    Public WithEvents cntVisibility As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuResetPositions As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cntVisibility = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.mnuResetPositions = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        '
        'cntVisibility
        '
        Me.cntVisibility.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem8, Me.mnuResetPositions})
        '
        'MenuItem1
        '
        Me.MenuItem1.Checked = True
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "One"
        Me.MenuItem1.Visible = False
        '
        'MenuItem2
        '
        Me.MenuItem2.Checked = True
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Two"
        Me.MenuItem2.Visible = False
        '
        'MenuItem3
        '
        Me.MenuItem3.Checked = True
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Three"
        Me.MenuItem3.Visible = False
        '
        'MenuItem4
        '
        Me.MenuItem4.Checked = True
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Four"
        Me.MenuItem4.Visible = False
        '
        'MenuItem5
        '
        Me.MenuItem5.Checked = True
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Five"
        Me.MenuItem5.Visible = False
        '
        'mnuResetPositions
        '
        Me.mnuResetPositions.Index = 6
        Me.mnuResetPositions.Text = "&Reset Positions"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 5
        Me.MenuItem8.Text = "-"
        '
        'Coolbar
        '
        Me.ContextMenu = Me.cntVisibility
        Me.Name = "Coolbar"
        Me.Size = New System.Drawing.Size(584, 112)

    End Sub

#End Region
    'Public Event ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs)
    
    Public Event ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByVal BandIdx As Integer)

    Dim lbooPaintNow As Boolean = True
    Dim lbooClear As Boolean = False
    Dim TopColour As Color = SystemColors.ControlLightLight
    Dim BottomColour As Color = SystemColors.ControlDark
    Private _parentForm As Form
    Public Bands() As CoolbarBand
    Dim lbooEventsAdded As Boolean = False
    Dim BandPlaceHeight As Integer
    Dim mMaxVerticalBands As Integer = 1
    Dim mstrCurrentToolbarIdentity As String = "" 
    Private StopMovingToolbar As Boolean = False

    Public Property MaxVerticalBands() As Integer
        Get
            Return mMaxVerticalBands
        End Get
        Set(ByVal Value As Integer)
            mMaxVerticalBands = Value
        End Set
    End Property
    Public Property BandHeight() As Integer
        Get
            Return BandPlaceHeight
        End Get
        Set(ByVal Value As Integer)
            BandPlaceHeight = Value
        End Set
    End Property
    Dim mBand1Image As Image
    Public Property Band1Image() As Image
        Get
            Return mBand1Image
        End Get
        Set(ByVal Value As Image)
            mBand1Image = Value
        End Set
    End Property
    Dim mBand2Image As Image
    Public Property Band2Image() As Image
        Get
            Return mBand2Image
        End Get
        Set(ByVal Value As Image)
            mBand2Image = Value
        End Set
    End Property
    Dim mBand3Image As Image
    Public Property Band3Image() As Image
        Get
            Return mBand3Image
        End Get
        Set(ByVal Value As Image)
            mBand3Image = Value
        End Set
    End Property
    Dim mbooDontDrawShadow As Boolean = False
    Public Property DontDrawShadow() As Boolean
        Get
            Return mbooDontDrawShadow
        End Get
        Set(ByVal Value As Boolean)
            mbooDontDrawShadow = Value
        End Set
    End Property
    
    Dim mbooDrawBottomLine As Boolean = False
    Public Property DrawBottomLine() As Boolean
        Get
            Return mbooDrawBottomLine
        End Get
        Set(ByVal Value As Boolean)
            mbooDrawBottomLine = Value
        End Set
    End Property
    
    Dim CurrentMovingToolbar As String = "xxx"
    Dim InitialPoint As Point
    Public Sub AddBandEvents(ByVal NumofBands As Integer)

        ReDim Bands(NumofBands)

        Dim lintArrInc As Integer
        For lintArrInc = 0 To NumofBands
            Bands(lintArrInc) = New CoolbarBand()
            AddHandler Bands(lintArrInc).MoveComplete, AddressOf Bands_MoveComplete
            AddHandler Bands(lintArrInc).MoveStarted, AddressOf Bands_MoveStarted
            Me.Controls.Add(Bands(lintArrInc))
            Bands(lintArrInc).Dock = DockStyle.None
            Bands(lintArrInc).Visible = True
            Bands(lintArrInc).Divider = False
            Bands(lintArrInc).Appearance = ToolBarAppearance.Flat

            Bands(lintArrInc).Wrappable = False
            ''Bands(lintArrInc).AutoSize = True
            ''Bands(lintArrInc).ButtonSize = New Size(31, 30)
            'Bands(lintArrInc).AutoSize = False            
            AddHandler Bands(lintArrInc).ButtonClick, AddressOf Bands_ButtonClick
        Next lintArrInc
        lbooEventsAdded = True

    End Sub
    Public Sub SetImageListForBand(ByVal BandNum As Integer, ByVal ImgList As ImageList)

        Bands(BandNum).ImageList = ImgList

    End Sub
    Private Sub Coolbar_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        Dim DebugFlag As Boolean = False 'True 

        Me.SuspendLayout()

        e.Graphics.SmoothingMode = Drawing.Drawing2D.SmoothingMode.HighSpeed

        '--- Draw Top Line ---
        e.Graphics.DrawLine(New Pen(BottomColour), 0, 0, Me.Width, 0)
        e.Graphics.DrawLine(New Pen(TopColour), 0, 1, Me.Width, 1)
        '--- Draw Top Line ---

        If lbooEventsAdded = False Then
            Exit Sub
        End If

        Dim lintArrInc As Integer
        Dim ThisToolbar As ToolBar
        If lbooPaintNow = True Then
            '--- Adjust height of usercontrol is necessary ---
            Dim NewUCHeight As Integer
            For lintArrInc = 0 To Bands.GetUpperBound(0)
                'If lbooPaintNow = True Then
                ThisToolbar = Bands(lintArrInc)

                If ThisToolbar.Visible <> False Then  

                    If mMaxVerticalBands = 3 And ThisToolbar.Top > ThisToolbar.Height + (ThisToolbar.Height / 2) Then
                        NewUCHeight = (BandPlaceHeight * 3)
                        Exit For
                    ElseIf mMaxVerticalBands <= 3 And ThisToolbar.Top > (ThisToolbar.Height / 2) Then
                        NewUCHeight = (BandPlaceHeight * 2)
                        Exit For
                    Else
                        NewUCHeight = BandPlaceHeight
                    End If

                End If 

                'End If
            Next lintArrInc
            Me.Height = NewUCHeight
            '--- Adjust height of usercontrol is necessary ---

            Dim MovedRectangle As Rectangle
            For lintArrInc = 0 To Bands.GetUpperBound(0)
                ThisToolbar = Bands(lintArrInc)
                '--- Get Moved Toolbar rectangle ---
                If ThisToolbar.Name = CurrentMovingToolbar Then
                    MovedRectangle.X = ThisToolbar.Location.X
                    MovedRectangle.Y = ThisToolbar.Location.Y
                    MovedRectangle.Height = ThisToolbar.Height
                    MovedRectangle.Width = ThisToolbar.Width
                End If
                '--- Get Moved Toolbar rectangle ---    
            Next lintArrInc

            Dim MovedNewTop As Integer
            Dim lbooOverlapTopLeft As Boolean = False
            Dim lbooOverlapTopRight As Boolean = False
            Dim lbooOverlapBottomLeft As Boolean = False
            Dim lbooOverlapBottomRight As Boolean = False
            Dim lbooOverLapBiggerAndFurtherDown As Boolean = False
            Dim lbooOverLapBiggerAndFurtherUp As Boolean = False

            '--- Reposition Toolbar if moved out of user control ---
            For lintArrInc = 0 To Bands.GetUpperBound(0)

                ThisToolbar = Bands(lintArrInc)

                If ThisToolbar.Visible <> False Then  

                    Dim NewTop As Integer = ThisToolbar.Top : Dim NewLeft As Integer = ThisToolbar.Left
                    If NewTop + ThisToolbar.Height > Me.Height Then
                        NewTop = (Me.Height - ThisToolbar.Height) - 3
                    End If
                    If NewTop < 2 Then
                        NewTop = 2
                    End If
                    'Not wordpad compliant
                    ''If NewLeft + ThisToolbar.Width > Me.Width Then
                    ''    NewLeft = (Me.Width - ThisToolbar.Width) - 3
                    ''End If
                    If NewLeft < 2 Then
                        NewLeft = 2
                    End If

                    ''If NewTop = ThisToolbar.Top Then
                    Dim CurrentNumOfBands As Integer = NewUCHeight Mod BandPlaceHeight
                    '--- Align to nearest band top ---
                    '70% to cater for innacurate mouse drop
                    If NewTop <= (BandPlaceHeight * 0.7) Then
                        NewTop = 2
                    ElseIf NewTop <= ((BandPlaceHeight * 2) * 0.7) Then
                        NewTop = 2 + BandPlaceHeight
                    ElseIf NewTop <= ((BandPlaceHeight * 3) * 0.7) Then
                        'NewTop = 2 + (BandPlaceHeight * 2)
                        'might be a crutial change!!!
                        NewTop = 2 + (BandPlaceHeight * 2)
                    End If
                    '--- Align to nearest band top ---

                    
                    'Display a diffent background image depending on the number of bands
                    If Me.mBand1Image Is Nothing Then 
                        Select Case (NewUCHeight / BandPlaceHeight)
                            Case 1
                                If DebugFlag = True Then : Console.WriteLine("Me.BackgroundImage = mBand1Image") : End If
                                Me.BackgroundImage = mBand1Image
                            Case 2
                                If DebugFlag = True Then : Console.WriteLine("Me.BackgroundImage = mBand2Image") : End If
                                Me.BackgroundImage = mBand2Image
                            Case 3
                                If DebugFlag = True Then : Console.WriteLine("Me.BackgroundImage = mBand3Image") : End If
                                Me.BackgroundImage = mBand3Image
                        End Select

                    End If 
                    

                    ''End If

                    '--- Get Moved Toolbar rectangle ---
                    If ThisToolbar.Name <> CurrentMovingToolbar Then
                        Dim MTop As Integer = MovedRectangle.Y
                        Dim MBottom As Integer = MovedRectangle.Y + MovedRectangle.Height
                        Dim MLeft As Integer = MovedRectangle.X
                        Dim MRight As Integer = MovedRectangle.X + MovedRectangle.Width

                        Dim DTop As Integer = ThisToolbar.Location.Y
                        Dim DBottom As Integer = ThisToolbar.Location.Y + ThisToolbar.Height
                        Dim DLeft As Integer = ThisToolbar.Location.X
                        Dim DRight As Integer = ThisToolbar.Location.X + ThisToolbar.Width

                        'if top left corner of moved toolbar is ontop of another toolbar
                        If (MTop >= DTop And MTop <= DBottom) And (MLeft >= DLeft And MLeft <= DRight) Then
                            If DebugFlag = True Then : Console.WriteLine("Top Left Corner of Toolbar " & CurrentMovingToolbar & " is on top of toolbar " & ThisToolbar.Name) : End If
                            lbooOverlapTopLeft = True
                        End If

                        'if top right corner of moved toolbar is ontop of another toolbar
                        If (MTop >= DTop And MTop <= DBottom) And (MRight <= DRight And DLeft <= MRight) Then
                            If DebugFlag = True Then : Console.WriteLine("Top Righ Corner of Toolbar " & CurrentMovingToolbar & " is on top of toolbar " & ThisToolbar.Name) : End If
                            lbooOverlapTopRight = True
                        End If

                        'if bottom right corner of moved toolbar is ontop of another toolbar
                        If (MBottom <= DBottom And DTop <= MBottom) And (MRight <= DRight And DLeft <= MRight) Then
                            If DebugFlag = True Then : Console.WriteLine("Bottom Right Corner of Toolbar " & CurrentMovingToolbar & " is on top of toolbar " & ThisToolbar.Name) : End If
                            lbooOverlapBottomRight = True
                        End If

                        'if bottom left corner of moved toolbar is ontop of another toolbar
                        'If (MBottom <= DBottom And DTop <= MBottom) And (DLeft <= DRight And MLeft >= DLeft) Then
                        If (MBottom <= DBottom And DTop <= MBottom) And (MLeft <= DRight And MLeft >= DLeft) Then 
                            If DebugFlag = True Then : Console.WriteLine("Bottom Left Corner of Toolbar " & CurrentMovingToolbar & " is on top of toolbar " & ThisToolbar.Name) : End If
                            lbooOverlapBottomLeft = True
                        End If

                        'If Moved toolbar moved on top (and further down) of a smaller toolbar completely, set a flag to dissallow it.
                        If (MLeft < DLeft And MRight > DRight) And ((MTop < DBottom) And (MBottom > DBottom)) Then
                            lbooOverLapBiggerAndFurtherDown = True
                        End If

                        'If Moved toolbar moved on top (and further up) of a smaller toolbar completely, set a flag to dissallow it.
                        If (MLeft < DLeft And MRight > DRight) And ((MBottom > DTop) And (MTop < DTop)) Then
                            lbooOverLapBiggerAndFurtherUp = True
                        End If

                    Else
                        MovedNewTop = NewTop
                    End If
                    '--- Get Moved Toolbar rectangle ---                

                    If NewLeft <> ThisToolbar.Left Then ThisToolbar.Left = NewLeft
                    If NewTop <> ThisToolbar.Top Then ThisToolbar.Top = NewTop

                End If 
            Next lintArrInc

            '--- Reposition Toolbar if moved out of user control ---

            '--- Move other toolbars to make room if required ---
            If DebugFlag = True Then : Console.WriteLine("Overlap") : End If
            Dim OtherToolbars As New SortedList()
            If lbooOverlapTopLeft = True Or lbooOverlapTopRight = True Or lbooOverlapBottomLeft = True Or lbooOverlapBottomRight = True Then
                Dim TotalRowWidth As Integer
                Dim MovedToolbarWidth As Integer
                Dim MovedToolbarLeft As Integer
                For lintArrInc = 0 To Bands.GetUpperBound(0)
                    ThisToolbar = Bands(lintArrInc)

                    If ThisToolbar.Name <> CurrentMovingToolbar Then
                        If DebugFlag = True Then : Console.WriteLine("overlap 1") : End If
                        If ThisToolbar.Top = MovedNewTop Then
                            TotalRowWidth += ThisToolbar.Width
                            OtherToolbars.Add(ThisToolbar.Width, ThisToolbar.Name)
                        End If
                    Else
                        If DebugFlag = True Then : Console.WriteLine("overlap 2") : End If
                        MovedToolbarWidth = ThisToolbar.Width
                        MovedToolbarLeft = ThisToolbar.Left
                    End If
                Next lintArrInc

                If lbooOverlapTopRight = True Or lbooOverlapBottomRight = True Then
                    If MovedToolbarLeft + TotalRowWidth + MovedToolbarWidth < Me.Width Then
                        'move other toolbars behind
                        If DebugFlag = True Then : Console.WriteLine("overlap 3") : End If
                        Dim CurrentLeft As Integer = MovedToolbarLeft + MovedToolbarWidth + 3
                        For lintArrInc = 0 To OtherToolbars.Count - 1


                            MoveToolBarToPos(OtherToolbars.GetByIndex(lintArrInc), CurrentLeft)

                        Next lintArrInc
                    Else
                        'do nothing it won't fit
                        'reposition moved toolbar to where it was before move
                        If DebugFlag = True Then : Console.WriteLine("Left  = reposition moved toolbar to where it was before move") : End If
                        MoveToolBarToPos(CurrentMovingToolbar, InitialPoint.X, InitialPoint.Y)
                    End If
                ElseIf lbooOverlapTopLeft = True Or lbooOverlapBottomLeft = True Then
                    If DebugFlag = True Then : Console.WriteLine("overlap 4") : End If
                    'Dim FirstToolbarOnRowLeft As Integer = GetToolBarLeftPos(OtherToolbars.GetByIndex(0))
                    
                    Dim FirstToolbarOnRowLeft As Integer
                    Try
                        FirstToolbarOnRowLeft = GetToolBarLeftPos(OtherToolbars.GetByIndex(0))
                    Catch

                    End Try
                    
                    If DebugFlag = True Then : Console.WriteLine("overlap 4 a") : End If
                    If FirstToolbarOnRowLeft + TotalRowWidth + MovedToolbarWidth + 3 < Me.Width Then
                        'move to right
                        If DebugFlag = True Then : Console.WriteLine("overlap 4 b") : End If
                        MoveToolBarToPos(CurrentMovingToolbar, FirstToolbarOnRowLeft + TotalRowWidth + 3)
                    Else
                        'do nothing it won't fit
                        'reposition moved toolbar to where it was before move
                        If DebugFlag = True Then : Console.WriteLine("Right = reposition moved toolbar to where it was before move") : End If
                        MoveToolBarToPos(CurrentMovingToolbar, InitialPoint.X, InitialPoint.Y)
                    End If
                Else
                    'MessageBox.Show("this shouldn't happen!")
                End If

            ElseIf lbooOverLapBiggerAndFurtherDown = True Or lbooOverLapBiggerAndFurtherUp = True Then 
                If DebugFlag = True Then : Console.WriteLine("Bigger toolbar dropped on top of smaller one!") : End If
                MoveToolBarToPos(CurrentMovingToolbar, InitialPoint.X, InitialPoint.Y)
            End If
            '--- Move other toolbars to make room if required ---

        End If

        If StopMovingToolbar = True Then
            CurrentMovingToolbar = "" ' clears out the toolbar we just u
            StopMovingToolbar = False
        End If

        '  If DebugFlag = True Then : Console.WriteLine("Shadow") : End If
        For lintArrInc = 0 To Bands.GetUpperBound(0)
            ThisToolbar = Bands(lintArrInc)
            If ThisToolbar.Visible <> False Then 

                If ThisToolbar.Name <> CurrentMovingToolbar Then '  If the name is the same as the one we are moving then ignore it!

                    ' If mbooDontDrawShadow = False Then 
                    '--- Draw Shadow ---
                    Dim lTop As Integer = ThisToolbar.Location.Y - 1 : Dim lLeft As Integer = ThisToolbar.Location.X - 1
                    Dim lWidth As Integer = ThisToolbar.Width + 2 : Dim lheight As Integer = ThisToolbar.Height + 2
                    e.Graphics.DrawRectangle(New Pen(BottomColour), New Rectangle(lLeft - 1, lTop - 1, lWidth + 1, lheight + 1))
                    e.Graphics.DrawRectangle(New Pen(TopColour), New Rectangle(lLeft, lTop, lWidth + 1, lheight + 1))
                    '--- Draw Shadow ---
                    If DebugFlag = True Then : Console.WriteLine("Shadow done") : End If
                End If 
                'End If 

            End If

        Next lintArrInc

        If mbooDrawBottomLine = True Then
            '  e.Graphics.DrawLine(New Pen(BottomColour), 0, Me.Height - 1, Me.Width, Me.Height - 1)
            e.Graphics.DrawLine(New Pen(TopColour), 0, Me.Height, Me.Width, Me.Height)
            ' e.Graphics.DrawLine(New Pen(BottomColour), 0, Me.Height - 1, Me.Width, Me.Height - 1)
            ' e.Graphics.DrawLine(New Pen(BottomColour), 0, Me.Height - 4, Me.Width, Me.Height - 4)
            e.Graphics.DrawLine(New Pen(BottomColour), 0, Me.Height - 5, Me.Width, Me.Height - 5)
            ''e.Graphics.DrawLine(New Pen(BottomColour), 0, Me.Height - 6, Me.Width, Me.Height - 6)
        End If

        If lbooClear = True Then
            'Console.WriteLine("Cleared")
            lbooClear = False
            Me.BackgroundImage = Nothing 
            '  e.Graphics.Clear(Me.BackColor)
        End If


        Me.ResumeLayout()

        If DebugFlag = True Then : Console.WriteLine("Paint done") : End If

    End Sub


    Sub MoveToolBarToPos(ByVal ToolbarName As String, ByRef left As Integer, Optional ByVal Top As Integer = -1)

        Dim lintArrInc As Integer
        Dim ThisToolbar As ToolBar
        For lintArrInc = 0 To Bands.GetUpperBound(0)
            ThisToolbar = Bands(lintArrInc)
            If ToolbarName = ThisToolbar.Name Then
                ThisToolbar.Left = left
                If Top <> -1 Then
                    ThisToolbar.Top = Top
                End If
                left += ThisToolbar.Width + 3
                Exit For
            End If
        Next lintArrInc

    End Sub
    Function GetToolBarLeftPos(ByVal ToolbarName As String) As Integer

        Dim lintArrInc As Integer
        Dim ThisToolbar As ToolBar
        For lintArrInc = 0 To Bands.GetUpperBound(0)
            ThisToolbar = Bands(lintArrInc)
            If ToolbarName = ThisToolbar.Name Then
                GetToolBarLeftPos = ThisToolbar.Left

                Exit For
            End If
        Next lintArrInc

    End Function
    Private Sub Bands_MoveComplete(ByVal ToolbarName As String)

        'Console.WriteLine("Bands_MoveComplete")

        StopMovingToolbar = True

        DontDrawShadow = False

        Me.Invalidate()
        lbooPaintNow = True

    End Sub
    Private Sub Bands_MoveStarted(ByVal ToolbarName As String, ByVal Initial As Point)

        'Console.WriteLine("Bands_MoveStarted")
        InitialPoint = Initial

        StopMovingToolbar = False

        CurrentMovingToolbar = ToolbarName

        DontDrawShadow = True

        lbooPaintNow = False
        lbooClear = True
        Me.Invalidate()

    End Sub
    Private Sub Bands_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs)

        Dim tbBand As CoolbarBand = CType(sender, CoolbarBand)
        Dim lintArrInc As Integer
        For lintArrInc = 0 To Bands.GetUpperBound(0)
            If Bands(lintArrInc).Name = tbBand.Name Then
                Exit For
            End If
        Next lintArrInc

        RaiseEvent ButtonClick(sender, e, lintArrInc)

    End Sub
    Private Sub Coolbar_ParentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ParentChanged

        ' We assume that this control's parent will be a form;
        '    if this might not always be true, loop up the control
        '    chain looking for a form

        ' First, unhook any current event handlers
        If Not _parentForm Is Nothing Then
            RemoveHandler _parentForm.Closing, AddressOf Me.FormClosing
        End If

        ' Now, hold on to a reference of the current parent
        _parentForm = Me.Parent

        ' And add a handler to the closing event
        AddHandler _parentForm.Closing, AddressOf Me.FormClosing
    End Sub
    Private Sub FormClosing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

        'save positions of toolbars
        Dim xDoc As New Xml.XmlDocument()
        Dim ConfigFile As String = System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat"
        xDoc.Load(ConfigFile)

        Dim lintArrInc As Integer
        Dim ThisToolbar As ToolBar

        For lintArrInc = 0 To Bands.GetUpperBound(0)
            ThisToolbar = Bands(lintArrInc)
            
            BatchXMLItemWrite(xDoc, "appSettings", "Toolbar" & lintArrInc & "Top", ThisToolbar.Top)
            BatchXMLItemWrite(xDoc, "appSettings", "Toolbar" & lintArrInc & "Left", ThisToolbar.Left)
            BatchXMLItemWrite(xDoc, "appSettings", "Toolbar" & lintArrInc & "Visible", ThisToolbar.Visible) 
            BatchXMLItemWrite(xDoc, "appSettings", "Toolbar" & lintArrInc & "Identity", mstrCurrentToolbarIdentity) 
            
        Next lintArrInc

        xDoc.Save(ConfigFile)
        xDoc = Nothing

        ' Unhook the event handler
        RemoveHandler _parentForm.Closing, AddressOf Me.FormClosing

    End Sub
    Public Sub LoadToolbarPositions(ByVal pAppSettings As AppBasic.InitalXMLConfig, ByVal CurrentToolbarIdentity As String)

        mstrCurrentToolbarIdentity = CurrentToolbarIdentity 

        Dim lintArrInc As Integer
        Dim ThisToolbar As ToolBar

        For lintArrInc = 0 To Bands.GetUpperBound(0)
            ThisToolbar = Bands(lintArrInc)
            Dim LastIdentity As String = pAppSettings.GetValue("Toolbar" & lintArrInc & "Identity", "") 
            If LastIdentity = mstrCurrentToolbarIdentity Then 
                ThisToolbar.Top = CInt(pAppSettings.GetValue("Toolbar" & lintArrInc & "Top", Bands(lintArrInc).InitialLocation.Y))
                ThisToolbar.Left = CInt(pAppSettings.GetValue("Toolbar" & lintArrInc & "Left", Bands(lintArrInc).InitialLocation.X))
                ThisToolbar.Visible = CBool(pAppSettings.GetValue("Toolbar" & lintArrInc & "Visible", Bands(lintArrInc).Visible))
            Else 
                ThisToolbar.Top = Bands(lintArrInc).InitialLocation.Y 
                ThisToolbar.Left = Bands(lintArrInc).InitialLocation.X 
                ThisToolbar.Visible = CBool(pAppSettings.GetValue("Toolbar" & lintArrInc & "Visible", Bands(lintArrInc).Visible))
            End If
        Next lintArrInc

    End Sub
    Public Sub PopulateContextMenu()

        Dim lintArrInc As Integer
        For lintArrInc = 0 To Bands.GetUpperBound(0)

            'Dim NewMenuItem As New MenuItem()
            'NewMenuItem.Visible = True
            'NewMenuItem.Checked = True
            'NewMenuItem.Text = Bands(lintArrInc).Tag
            'cntVisibility.MenuItems.Add(NewMenuItem)
            If Bands(lintArrInc).Tag <> "" Then 
                cntVisibility.MenuItems(lintArrInc).Text = Bands(lintArrInc).Tag
                cntVisibility.MenuItems(lintArrInc).Visible = True
                cntVisibility.MenuItems(lintArrInc).Checked = Bands(lintArrInc).Visible 'True 
            End If 
        Next lintArrInc


    End Sub
    Private Sub MenuItems_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem1.Click, MenuItem2.Click, MenuItem3.Click, MenuItem4.Click, MenuItem5.Click

        Dim s As MenuItem = sender

        Dim lintArrInc As Integer
        Dim ThisToolbar As ToolBar

        For lintArrInc = 0 To Bands.GetUpperBound(0)
            ThisToolbar = Bands(lintArrInc)
            If ThisToolbar.Tag = s.Text Then
                If Bands(lintArrInc).Visible = False Then
                    Bands(lintArrInc).Visible = True
                    s.Checked = True
                Else
                    Bands(lintArrInc).Visible = False
                    s.Checked = False
                End If
                Exit For
            End If
        Next lintArrInc
        StandardReset()
        Me.Invalidate()

    End Sub
    Private Sub mnuResetPositions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuResetPositions.Click
        'Added 

        Try 
            ResetBandPositions()
            ResetBands()
            StandardReset()
        Catch 

        End Try 

    End Sub
    Private Sub ResetBands()
        'StandardReset checks whether Standard toolbar is visible if it is then adds its height to tbTop else tbTop is set to 0 and passed as argument to FontReset()
        'added 
        Dim i As Integer

        For i = 0 To Bands.GetUpperBound(0)
            Bands(i).Visible = True
        Next
        MenuItem1.Checked = True
        MenuItem2.Checked = True
        MenuItem3.Checked = True
        MenuItem4.Checked = True
    End Sub

    Public Sub ResetBandPositions()

        Try 
            'added 
            Dim lintArrInc As Integer
            Dim ThisToolbar As ToolBar

            For lintArrInc = 0 To Bands.GetUpperBound(0)
                ThisToolbar = Bands(lintArrInc)
                ThisToolbar.Visible = True 
                ThisToolbar.Top = Bands(lintArrInc).InitialLocation.Y
                ThisToolbar.Left = Bands(lintArrInc).InitialLocation.X
            Next lintArrInc
        Catch 

        End Try 

        Me.Invalidate() 

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintToolbarBackground(pevent, Me)

    End Sub

    Private Sub cntVisibility_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles cntVisibility.Popup
        

        Dim lintArrInc As Integer
        For lintArrInc = 0 To Bands.GetUpperBound(0)
            cntVisibility.MenuItems(lintArrInc).Checked = Bands(lintArrInc).Visible
        Next lintArrInc

    End Sub

    Public Sub StandardReset()

        Dim tbTop As Integer = 0
        If Bands(0).Visible = True Then
            'assigns left and top properties to toolbar band
            Bands(0).Left = 0
            Bands(0).Top = tbTop
            tbTop = Bands(0).Height + 4
        End If
        FontReset(tbTop)

    End Sub

    Private Sub FontReset(ByVal tbTop As Integer)
        'added 'FontReset checks whether Font toolbar is visible if it is then adds its height to tbTop else tbTop's value and tbTop's value is passed as argument to BranchReset()

        If Bands(2).Visible = True Then
            'assigns left and top properties to toolbar band
            Bands(2).Left = 0
            Bands(2).Top = tbTop
            tbTop += Bands(2).Height + 4
        End If
        BranchReset(tbTop)

    End Sub

    Private Sub BranchReset(ByVal tbTop As Integer)
        'added 'BranchReset checks whether Branch toolbar is visible if it is then adds its height to tbTop, width to tbLeft else tbLeft=0 and tbTop's value and tbTop's value is passed as argument to SearchReset()

        Dim tbLeft As Integer = 0

        If Bands(1).Visible = True Then
            'assigns left and top properties to toolbar band
            Bands(1).Left = 0
            Bands(1).Top = tbTop
            tbLeft = Bands(1).Width + 4
        End If
        SearchReset(tbLeft, tbTop)

    End Sub

    Private Sub SearchReset(ByVal tbLeft As Integer, ByVal tbTop As Integer)
        'added 'SearchReset checks whether Search toolbar is visible than tbTop and tbLeft are aasigned to it.

        If Bands(3).Visible = True Then
            'assigns left and top properties to toolbar band
            If tbLeft = 0 Then
                If Bands(0).Visible = True Then
                    tbLeft = Bands(0).Width + 5
                    tbTop = Bands(0).Top
                ElseIf Bands(2).Visible = True Then
                    tbLeft = Bands(2).Width + 5
                    tbTop = Bands(2).Top
                End If
            End If
            Bands(3).Left = tbLeft
            Bands(3).Top = tbTop
        End If
    End Sub

End Class
