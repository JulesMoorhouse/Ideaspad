Class DynamicMatrix

    Private rCount As Integer
    Private cCount As Integer

    Private matrix(-1, -1) As Node

    Public ReadOnly Property RowCount()
        Get
            Return rCount
        End Get
    End Property

    Public ReadOnly Property ColumnCount()
        Get
            Return cCount
        End Get
    End Property

    Public Property Item(ByVal row As Integer, ByVal column As Integer) As Node
        Get
            If row >= 0 And row < rCount And column >= 0 And column < cCount Then
                Return matrix(row, column)
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal Value As Node)
            If row >= 0 And row < rCount And column >= 0 And column < cCount Then
                matrix(row, column) = Value
            Else
                rCount = Math.Max(row + 1, rCount)
                cCount = Math.Max(column + 1, cCount)

                Dim aux(rCount - 1, cCount - 1) As Node
                Dim i As Integer 
                Dim j As Integer 
                For i = 0 To UBound(matrix, 1)
                    For j = 0 To UBound(matrix, 2)
                        aux(i, j) = matrix(i, j)
                    Next
                Next

                matrix = aux
                matrix(row, column) = Value
            End If
        End Set
    End Property
End Class
