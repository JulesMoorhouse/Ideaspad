Public Class CoolbarBand
    Inherits ToolBar
    Dim hold As Boolean = False ' used to determine if the form is held
    Dim p As Point ' Initial point, When mouse is first held down
    Dim p2 As Point ' New Point, On mouse move
    Dim p3 As Point ' Distance moved, p2 - p1

    Public Event MoveComplete(ByVal ToolbarName As String)
    Public Event MoveStarted(ByVal ToolbarName As String, ByVal Initial As Point)
    'Public Event MovePaint()

    'Public Event MyMouseMove(ByVal sender As Object, ByVal e As EventArgs)

    Private bLockedToolbar As Boolean = False

    'Public Sub New()
    '    Me.ButtonSize = Nothing
    'End Sub
    Dim mintInitialLocation As Point 
    Public Property InitialLocation() As Point 
        Get
            Return mintInitialLocation
        End Get
        Set(ByVal Value As Point)
            mintInitialLocation = Value
        End Set
    End Property

    Public Property LockToolbar() As Boolean
        Get
            LockToolbar = bLockedToolbar
        End Get
        Set(ByVal value As Boolean)
            bLockedToolbar = value
        End Set
    End Property


    Private Sub CoolbarBand_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        If bLockedToolbar = False Then

        Dim lbooHold As Boolean = hold

        If Me.Buttons.Count = 0 Then Exit Sub

        Dim lintArrInc As Integer
        If e.Button = MouseButtons.Left Then ' Check that the left mouse button was clicked
            Me.BringToFront()
            For lintArrInc = 0 To Me.Buttons.Count - 1
                If lintArrInc = 0 And Me.Buttons(lintArrInc).Style = ToolBarButtonStyle.Separator Then
                    'do nothing, allow drag
                Else

                    Dim ThisWidth As Integer = Me.Buttons(lintArrInc).Rectangle.Width 'put here to cater for different button sizes, separators and pushed
                    Dim ThisHeight As Integer = Me.Buttons(lintArrInc).Rectangle.Height 'put here to cater for different button sizes, separators and pushed
                    Dim ThisTop As Integer = Me.Buttons(lintArrInc).Rectangle.Y
                    Dim ThisLeft As Integer = Me.Buttons(lintArrInc).Rectangle.X

                    'If click on button exit sub
                    If (e.Y > ThisTop And e.Y < ThisTop + ThisHeight) And _
                    (e.X > ThisLeft And e.X < ThisLeft + ThisWidth) Then
                        Exit Sub
                    End If
                End If
            Next lintArrInc
            hold = True ' Set hold to true
            p = New Point(e.X, e.Y) ' Set the value of P to the initial point
        End If

        If lbooHold = False And hold = True Then
            lbooHold = True
            'RaiseEvent MoveStarted(Me.Name, p)
            RaiseEvent MoveStarted(Me.Name, New Point(Me.Location.X, Me.Location.Y))
        End If

        End If


    End Sub
    Private Sub CoolbarBand_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

        If bLockedToolbar = False Then

        hold = False ' form is dropped
        RaiseEvent MoveComplete(Me.Name)

        End If

    End Sub
    Private Sub CoolbarBand_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles MyBase.ButtonClick

        hold = False

    End Sub
    Private Sub CoolbarBand_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If hold = True Then ' Check if the form is held

            p2 = New Point(e.X, e.Y) ' Set new point
            p3 = New Point(p2.X - p.X, p2.Y - p.Y) ' Calculate difference, (P2 - P)
            Me.Left += p3.X ' Add distance to the form's position...
            Me.Top += p3.Y ' This will also work if the distance is negative (form moved upwards or to the left)


            'Console.WriteLine("CoolbarBand_MouseMove")
            ''RaiseEvent MovePaint()
            'Application.DoEvents()
            'RaiseEvent MovePaint()
        End If

    End Sub
    'Const WM_MOUSEMOVE = &H200

    'Protected Overrides Sub WndProc(ByRef m As Message)

    '    If hold = True Then
    '        ' Listen for operating system messages
    '        If m.Msg = WM_MOUSEMOVE Then
    '            'RaiseEvent MovePaint()
    '            RaiseEvent MyMouseMove(Me, New EventArgs())

    '            Console.WriteLine("CoolbarBand_MouseMove")
    '        End If
    '    End If

    '    MyBase.WndProc(m)

    'End Sub

End Class
Public Module CoolbarFuncs
    Public Function CreateButton(ByVal ToolTip As String, ByVal ImgIdx As Integer, ByVal Tag As String, _
        Optional ByVal Style As ToolBarButtonStyle = ToolBarButtonStyle.PushButton, _
        Optional ByVal DropDownMenu As ContextMenu = Nothing) As ToolBarButton

        Dim Button As New ToolBarButton()
        With Button
            .ImageIndex = ImgIdx
            .Tag = Tag
            .ToolTipText = ToolTip
            .Style = Style
            .DropDownMenu = DropDownMenu
        End With

        Return Button

    End Function
End Module