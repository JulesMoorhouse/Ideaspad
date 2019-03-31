Class Node

    Public id As Integer
    Public row As Integer
    Public cell As Integer

    Public element As cell

    Public Sub New(Optional ByVal rowIndex As Integer = 0, Optional ByVal cellIndex As Integer = 0, Optional ByVal nodeNumber As Integer = 0)
        row = rowIndex
        cell = cellIndex
        id = nodeNumber
    End Sub


End Class
