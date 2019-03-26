Imports System.Windows.Forms
Imports System.Drawing
Public Class EditDataGrid
    Inherits System.Windows.Forms.DataGrid

    Protected Overloads Overrides Sub ColumnStartedEditing(ByVal bounds As Rectangle)
        Console.WriteLine("edit began(bounds)!")
        MyBase.ColumnStartedEditing(bounds)
    End Sub

    Protected Overloads Overrides Sub ColumnStartedEditing(ByVal editingControl As Control)
        Console.WriteLine("edit began(control)!")
        MyBase.ColumnStartedEditing(editingControl)
    End Sub

End Class
