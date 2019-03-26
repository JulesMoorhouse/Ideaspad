Public Class TabPagePaintEv
    Inherits TabPage
    'added 
    Public Event TabPagePaint(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal Tab As TabPage)

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        RaiseEvent TabPagePaint(pevent, Me)

    End Sub
End Class
