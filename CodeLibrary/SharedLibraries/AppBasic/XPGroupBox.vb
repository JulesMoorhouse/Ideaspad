Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data
Imports System.Windows.Forms

'Public Delegate Sub SizeChangingHandler(ByVal sender As [Object], ByVal e As EventArgs)
'/ <summary>
'/ Summary description for XPGroupBox.
'/ </summary>
<Designer("System.Windows.Forms.Design.ParentControlDesigner,System.Design", GetType(System.ComponentModel.Design.IDesigner))> _
Public Class XPGroupBox
    Inherits System.Windows.Forms.UserControl
#Region "Members"
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing

    Private captionHeight As Integer = 25
    Private controlHeight As Integer = 10
    Private transitionSizeDelta As Integer = 0
    Private transitionAlphaChannel As Integer = 0
    Private captionHighlighted As Boolean = False
    Private expanded As Boolean = True ' actually used to determine is control expanded
    Private mcontrolExpanded As Boolean = True ' used to determin if control expanded at runtime
    Private mcaptionCurveRadius As Integer = 7
    Private mcaptionLeftColor As Color = Color.White
    Private mcaptionRightColor As Color = Color.FromArgb(198, 210, 248)
    Private mpaneTopLeftColor As Color = Color.White
    Private mpaneBottomRightColor As Color = Color.FromArgb(214, 223, 247)
    Private mpaneOutlineColor As Color = Color.White
    Private mcaptionFont As New Font("Microsoft Verdana", 8, FontStyle.Bold)
    Private mcaptionFontColor As Color = Color.Black
    Private mcaptionFontHighLightColor As Color = Color.Red
    Private WithEvents timer1 As System.Timers.Timer
    Private mcaptionText As String = "My Caption"


    Private Enum enGroupState
        [Static]
        Expanding
        Collapsing '
    End Enum 'GroupState

    Private groupState As enGroupState = enGroupState.Static

#End Region

#Region "Events"
    Public Event SizeChanging(ByVal sender As [Object], ByVal e As EventArgs) ' As SizeChangingHandler


    Protected Overridable Sub OnSizeChanging(ByVal e As EventArgs)
        ' Only fires event if something is handling the event
        If Not (e Is Nothing) Then 'If Not (SizeChanging Is Nothing) Then
            RaiseEvent SizeChanging(Me, e)
        End If
    End Sub 'OnSizeChanging
#End Region

#Region "Properties"


    <System.ComponentModel.Browsable(False)> _
    Public Property ControlExpanded() As Boolean
        Get
            Return mcontrolExpanded
        End Get
        Set(ByVal Value As Boolean)
            mcontrolExpanded = Value
        End Set
    End Property

    <Description("Determines the radius of the curves at the top-left and top-right of the control caption."), DefaultValue(7), Category("Appearance")> _
    Public Property CaptionCurveRadius() As Integer
        Get
            Return mcaptionCurveRadius
        End Get
        Set(ByVal Value As Integer)
            mcaptionCurveRadius = Value
            Invalidate()
        End Set
    End Property

    <Description("Determines the starting (light) color of the caption gradient fill."), Category("Appearance")> _
    Public Property CaptionLeftColor() As Color
        Get
            Return mcaptionLeftColor
        End Get
        Set(ByVal Value As Color)
            mcaptionLeftColor = Value
            Invalidate()
        End Set
    End Property

    <Description("Determines the ending (dark) color of the caption gradient fill."), Category("Appearance")> _
    Public Property CaptionRightColor() As Color
        Get
            Return mcaptionRightColor
        End Get
        Set(ByVal Value As Color)
            mcaptionRightColor = Value
            Invalidate()
        End Set
    End Property

    <Description("Determines the starting (light) color of the pane gradient fill."), Category("Appearance")> _
    Public Property PaneTopLeftColor() As Color
        Get
            Return mpaneTopLeftColor
        End Get
        Set(ByVal Value As Color)
            mpaneTopLeftColor = Value
            Invalidate()
        End Set
    End Property

    <Description("Determines the ending (dark) color of the pane gradient fill."), Category("Appearance")> _
    Public Property PaneBottomRightColor() As Color
        Get
            Return mpaneBottomRightColor
        End Get
        Set(ByVal Value As Color)
            mpaneBottomRightColor = Value
            Invalidate()
        End Set
    End Property

    <Description("Determines the color of the pane outline."), Category("Appearance")> _
    Public Property PaneOutlineColor() As Color
        Get
            Return mpaneOutlineColor
        End Get
        Set(ByVal Value As Color)
            mpaneOutlineColor = Value
            Invalidate()
        End Set
    End Property

    <Description("Determines the font and style of the caption text."), Category("Appearance")> _
    Public Property CaptionFont() As Font
        Get
            Return mcaptionFont
        End Get
        Set(ByVal Value As Font)
            mcaptionFont = Value
            Invalidate()
        End Set
    End Property

    <Description("Determines the color of the caption font."), Category("Appearance")> _
    Public Property CaptionFontColor() As Color
        Get
            Return mcaptionFontColor
        End Get
        Set(ByVal Value As Color)
            mcaptionFontColor = Value
            Invalidate()
        End Set
    End Property

    <Description("Determines the highlight color of the caption font."), Category("Appearance")> _
    Public Property CaptionFontHighLightColor() As Color
        Get
            Return mcaptionFontHighLightColor
        End Get
        Set(ByVal Value As Color)
            mcaptionFontHighLightColor = Value
            Invalidate()
        End Set
    End Property

    <Description("The text containd in the caption."), Category("Appearance")> _
    Public Property CaptionText() As String
        Get
            Return mcaptionText
        End Get
        Set(ByVal Value As String)
            mcaptionText = Value
            Invalidate()
        End Set
    End Property
#End Region

#Region "Constructors"

    Public Sub New()
        ' This call is required by the Windows.Forms Form Designer.
        InitializeComponent()

        ' TODO: Add any initialization after the InitComponent call
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.ContainerControl, True)

        Me.BackColor = Color.Transparent
    End Sub 'New
#End Region


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Component Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.timer1 = New System.Timers.Timer()
        CType(Me.timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        ' timer1
        '
        Me.timer1.SynchronizingObject = Me
        '
        ' XPGroupBox
        '
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.Name = "XPGroupBox"
        CType(Me.timer1, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub 'InitializeComponent 
#End Region


    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim rc As New Rectangle(0, 0, Me.Width, captionHeight)
        Dim b As New LinearGradientBrush(rc, mcaptionLeftColor, mcaptionRightColor, LinearGradientMode.Horizontal)
        Dim size As Size = e.Graphics.MeasureString(mcaptionText, mcaptionFont).ToSize()

        ' Now draw the caption areas with the rounded corners at the top
        Dim path As New GraphicsPath()
        path.AddLine(mcaptionCurveRadius, 0, Me.Width - mcaptionCurveRadius * 2, 0)
        path.AddArc(Me.Width - mcaptionCurveRadius * 2 - 1, 0, mcaptionCurveRadius * 2, mcaptionCurveRadius * 2, 270, 90)
        path.AddLine(Me.Width, mcaptionCurveRadius, Me.Width - 1, captionHeight)
        path.AddLine(Me.Width, captionHeight, 0, captionHeight)
        path.AddLine(0, captionHeight, 0, mcaptionCurveRadius)
        path.AddArc(0, 0, mcaptionCurveRadius * 2, mcaptionCurveRadius * 2, 180, 90)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.FillPath(b, path)

        ' Draw the outline around the work area
        If Me.Height > captionHeight Then
            e.Graphics.DrawLine(New Pen(mpaneOutlineColor), 0, Me.captionHeight, 0, Me.Height)
            e.Graphics.DrawLine(New Pen(mpaneOutlineColor), Me.Width - 1, Me.captionHeight, Me.Width - 1, Me.Height)
            e.Graphics.DrawLine(New Pen(mpaneOutlineColor), 0, Me.Height - 1, Me.Width - 1, Me.Height - 1)
        End If

        ' Draw tha caption text
        If captionHighlighted Then
            e.Graphics.DrawString(mcaptionText, mcaptionFont, New SolidBrush(mcaptionFontHighLightColor), 10, (captionHeight - 2 - size.Height) / 2)
        Else
            e.Graphics.DrawString(mcaptionText, mcaptionFont, New SolidBrush(mcaptionFontColor), 10, (captionHeight - 2 - size.Height) / 2)
        End If
    End Sub 'OnPaint


    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        MyBase.OnPaintBackground(pevent)
        If Me.Height > captionHeight Then
            Dim rect As New Rectangle(0, captionHeight, Me.Width, Me.Height - captionHeight)

            Dim b As New LinearGradientBrush(rect, mpaneTopLeftColor, mpaneBottomRightColor, LinearGradientMode.ForwardDiagonal)

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            pevent.Graphics.FillRectangle(b, rect)

        End If
    End Sub 'OnPaintBackground
    Private Sub XPGroupBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Y < captionHeight Then
            ' Mouse click on caption
            captionHighlighted = True
            Cursor.Current = Cursors.Hand
        Else
            ' Mouse click elsewhere on control
            captionHighlighted = False
            Cursor.Current = Cursors.Default
        End If
        Me.Invalidate()
    End Sub 'XPGroupBox_MouseMove
    Private Sub XPGroupBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave
        ' Ensure caption returned to non-highlighted condition
        captionHighlighted = False
        Cursor.Current = Cursors.Default
        Me.Invalidate()
    End Sub 'XPGroupBox_MouseLeave
    Private Sub XPGroupBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If e.Y > captionHeight OrElse groupState <> groupState.Static Then
            ' do nothing if we click anywhere other than in the caption
            ' or if the Group is in transition
            Return
        End If

        ' If we get here - the caption was clicked
        If expanded Then
            controlHeight = Me.Height
            groupState = groupState.Collapsing
        Else
            groupState = groupState.Expanding
        End If

        timer1.Interval = 100
        timer1.Enabled = True
    End Sub 'XPGroupBox_MouseDown
    Private Sub timer1_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles timer1.Elapsed
        ' Initializes the transition delta
        If transitionSizeDelta = 0 Then
            transitionSizeDelta = 1
        End If

        ' Reduces the interval between timer events - this gives the visual effect of the
        ' control slowly starting to collapse/expand then accelertaing
        If timer1.Interval > 20 Then
            timer1.Interval -= 20
        Else
            transitionSizeDelta += 2
        End If

        ' Initialises the control transaprency
        If transitionAlphaChannel = 0 Then
            transitionAlphaChannel = 10
        Else
            If transitionAlphaChannel + 10 < 255 Then
                ' Increase control transparency as it collapses
                transitionAlphaChannel += 10
            End If
        End If

        Select Case groupState
            Case groupState.Expanding
                If Me.Height + transitionSizeDelta < controlHeight Then
                    SetControlsOpacity(transitionAlphaChannel)
                    mpaneBottomRightColor = Color.FromArgb(transitionAlphaChannel, mpaneBottomRightColor)
                    mpaneTopLeftColor = Color.FromArgb(transitionAlphaChannel, mpaneTopLeftColor)
                    mpaneOutlineColor = Color.FromArgb(transitionAlphaChannel, mpaneOutlineColor)
                    Me.Height += transitionSizeDelta
                    SetControlsVisible()
                Else
                    SetControlsOpacity(255)
                    mpaneBottomRightColor = Color.FromArgb(255, mpaneBottomRightColor)
                    mpaneTopLeftColor = Color.FromArgb(255, mpaneTopLeftColor)
                    mpaneOutlineColor = Color.FromArgb(255, mpaneOutlineColor)
                    transitionAlphaChannel = 0
                    Me.Height = controlHeight
                    expanded = True
                    groupState = groupState.Static
                    SetControlsVisible()
                End If

            Case groupState.Collapsing
                If Me.Height - transitionSizeDelta > captionHeight Then
                    SetControlsOpacity(transitionAlphaChannel)
                    Me.Height -= transitionSizeDelta
                    mpaneBottomRightColor = Color.FromArgb(255 - transitionAlphaChannel, mpaneBottomRightColor)
                    mpaneTopLeftColor = Color.FromArgb(255 - transitionAlphaChannel, mpaneTopLeftColor)
                    mpaneOutlineColor = Color.FromArgb(255 - transitionAlphaChannel, mpaneOutlineColor)
                    SetControlsVisible()
                Else
                    transitionAlphaChannel = 0
                    SetControlsOpacity(0)
                    mpaneBottomRightColor = Color.FromArgb(0, mpaneBottomRightColor)
                    mpaneTopLeftColor = Color.FromArgb(0, mpaneTopLeftColor)
                    mpaneOutlineColor = Color.FromArgb(0, mpaneOutlineColor)
                    Me.Height = captionHeight
                    expanded = False
                    groupState = groupState.Static
                    SetControlsVisible()
                End If

            Case groupState.Static
                timer1.Enabled = False
                transitionSizeDelta = 0

            Case Else
                Throw New InvalidExpressionException("groupState variable set to incorrect value")
        End Select

        Invalidate()
        OnSizeChanging(New EventArgs())
    End Sub 'timer1_Elapsed
    Private Sub SetControlsVisible()
        Dim c As Control
        For Each c In Me.Controls
            If c.Top < captionHeight Then
                c.Visible = False
            Else
                c.Visible = True
            End If
        Next c
    End Sub 'SetControlsVisible
    Private Sub SetControlsOpacity(ByVal opacity As Integer)
        Dim c As Control
        For Each c In Me.Controls
            If Not TypeOf c Is TextBox Then
                Select Case groupState
                    Case groupState.Expanding

                        If Color.op_Inequality(c.BackColor, Color.Transparent) Then 'If c.BackColor <> Color.Transparent Then
                            c.BackColor = Color.FromArgb(opacity, c.BackColor)
                        End If
                        c.ForeColor = Color.FromArgb(opacity, c.ForeColor)

                    Case groupState.Collapsing
                        If Color.op_Inequality(c.BackColor, Color.Transparent) Then  'If c.BackColor <> Color.Transparent Then
                            c.BackColor = Color.FromArgb(255 - opacity, c.BackColor)
                        End If
                        c.ForeColor = Color.FromArgb(255 - opacity, c.ForeColor)

                    Case groupState.Static

                    Case Else
                        Throw New InvalidExpressionException("groupState variable set to incorrect value")
                End Select
            End If
        Next c
    End Sub 'SetControlsOpacity
End Class 'XPGroupBox

