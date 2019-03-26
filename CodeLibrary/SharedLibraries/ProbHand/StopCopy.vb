Friend Class StopCopyTextBox


    Inherits TextBox

    Private Const WM_COPY = &H301
    Private Const WM_PASTE = &H302
    Private Const WM_CUT = &H300
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        'Stop the control from excepting paste commands
        'If m.Msg = WM_PASTE Then
        'Dim txt As String = Clipboard.GetDataObject().GetData(GetType(String))
        If m.Msg = WM_COPY Then
            'Dim txt As String = Clipboard.GetDataObject().GetData(GetType(String))
            Clipboard.SetDataObject(GetType(String))
            Return
        End If

        MyBase.WndProc(m)

    End Sub



End Class
