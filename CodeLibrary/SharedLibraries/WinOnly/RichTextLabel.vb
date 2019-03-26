Imports System.Windows.Forms
Imports System.ComponentModel

Public Class RichTextBoxLabel 'added
    Inherits RichTextBox

    Private Declare Auto Function HideCaret Lib "user32.dll" (ByVal hwnd As IntPtr) As Int32

    Protected Overrides Sub OnGotFocus(ByVal e As EventArgs)
        ' no call of  base.OnGotFocus(e);
        HideCaret(Me.Handle)
        'Me.Parent.Focus()
    End Sub
    Protected Overrides Sub OnEnter(ByVal e As EventArgs)

        HideCaret(Me.Handle)
        ' Me.FindForm().SelectNextControl(Me, True, True, True, False)
    End Sub
    <DefaultValue(True)> Public Shadows Property [ReadOnly]() As Boolean
        Get
            Return True
        End Get
        Set(ByVal Value As Boolean)

        End Set
    End Property
    <DefaultValue(False)> Public Shadows Property TabStop() As Boolean
        Get
            Return False
        End Get
        Set(ByVal Value As Boolean)

        End Set
    End Property
    Public Sub New()

        MyBase.ReadOnly = True
        MyBase.TabStop = False
        Me.SetStyle(ControlStyles.Selectable, False)
        HideCaret(Me.Handle)

    End Sub

    'Private Sub ReadOnlyRichTextBox_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SelectionChanged

    '    Me.SelectionLength = 0

    '    HideCaret(Me.Handle)
    'End Sub
    'Private Sub ReadOnlyRichTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

    '    HideCaret(Me.Handle)

    'End Sub
    'Private Sub ReadOnlyRichTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

    '    HideCaret(Me.Handle)

    'End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

    
            ' WM_NCLBUTTONDOWN WM_LBUTTONDOWN
        If Me.ReadOnly AndAlso (m.Msg = &HA1 OrElse m.Msg = &H201) Then
            'Console.WriteLine("ignored")
            Return 'ignore it
        End If

        MyBase.WndProc(m)
    End Sub 'WndProc
End Class