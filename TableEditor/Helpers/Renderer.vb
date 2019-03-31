Imports System.Windows.Forms
Imports System.Collections
Imports System.Drawing.Drawing2D

Class Renderer

    Private WithEvents table As table
    Private matrix As DynamicMatrix
    Private widths As ArrayList
    Private heights As ArrayList

    Public Event SelectedCellChanged As EventHandler
    Public Event ContextMenuNeeded As MouseEventHandler
    Public Event RepaintNeeded As EventHandler
    Public Event CreateResizeHandles As EventHandler
    Public Event SelectionLengthChanged As EventHandler

    Public Sub New(ByVal table As table)
        Me.table = table
        widths = table.Widths
        heights = table.Heights
    End Sub

    Public ReadOnly Property RenderedTable() As table
        Get
            Return table
        End Get
    End Property

    Private Sub PrintMatrix(ByVal mat As DynamicMatrix)
        ' Print the matrix
        Dim s As String = ""
        Dim i As Integer 
        Dim j As Integer 
        For i = 0 To mat.RowCount - 1
            For j = 0 To mat.ColumnCount - 1
                If mat.Item(i, j) Is Nothing Then
                    s += "! "
                Else
                    If mat.Item(i, j).element Is Nothing Then
                        s += "? "
                    Else
                        s += mat.Item(i, j).id.ToString + " "
                    End If

                End If
            Next
            s += vbCrLf
        Next

        MessageBox.Show(s)
    End Sub

    Private Sub AddHandlers(ByVal cell As Cell)
        AddHandler cell.RebuildNeeded, AddressOf CellRebuild
        AddHandler cell.SpanningChanged, AddressOf CellSpanningChanged
        AddHandler cell.RepaintNeeded, AddressOf CellRepaint
        AddHandler cell.AssociatedControl.MouseDown, AddressOf LabelClicked
        AddHandler cell.AssociatedControl.SelectionLengthChanged, AddressOf SelLengthChanged
        AddHandler cell.AssociatedControl.ResizeNeeded, AddressOf ResizeNeeded
        AddHandler cell.AssociatedControl.TableNeeded, AddressOf TableNeeded
    End Sub

    Private Sub RemoveHandlers(ByVal cell As Cell)
        RemoveHandler cell.RebuildNeeded, AddressOf CellRebuild
        RemoveHandler cell.SpanningChanged, AddressOf CellSpanningChanged
        RemoveHandler cell.RepaintNeeded, AddressOf CellRepaint
        RemoveHandler cell.AssociatedControl.MouseDown, AddressOf LabelClicked
        RemoveHandler cell.AssociatedControl.SelectionLengthChanged, AddressOf SelLengthChanged
        RemoveHandler cell.AssociatedControl.ResizeNeeded, AddressOf ResizeNeeded
        RemoveHandler cell.AssociatedControl.TableNeeded, AddressOf TableNeeded
    End Sub

    Public Sub Rebuild()

        Dim rowIndex As Integer 
        Dim ColIndex As Integer 
        Dim CellIndex As Integer 

        If Not matrix Is Nothing Then
            ' If an old matrix exists, remove all event handlers

            For rowIndex = 0 To matrix.RowCount - 1
                For ColIndex = 0 To matrix.ColumnCount - 1
                    If Not matrix.Item(rowIndex, ColIndex) Is Nothing AndAlso Not matrix.Item(rowIndex, ColIndex).element Is Nothing Then
                        RemoveHandlers(matrix.Item(rowIndex, ColIndex).element)
                    End If
                Next
            Next
        End If

        matrix = New DynamicMatrix

        Dim nodeNumber As Integer = 0

        For rowIndex = 0 To table.Rows.Count - 1
            ' Fill the row

            Dim currCol As Integer = 0

            For CellIndex = 0 To CType(table.Rows.Item(rowIndex), Row).Cells.Count - 1
                ' New cell
                nodeNumber += 1

                ' Move to the first empty cell
                While Not matrix.Item(rowIndex, currCol) Is Nothing
                    currCol += 1
                End While

                Dim cell As Cell = CType(CType(table.Rows.Item(rowIndex), Row).Cells.Item(CellIndex), Cell)
                Dim r As Integer 
                Dim c As Integer 
                ' Expand the cell according to the row and col span
                For r = 0 To cell.RowSpan - 1
                    For c = 0 To cell.ColSpan - 1
                        Dim node As New Node(rowIndex, CellIndex, nodeNumber)
                        node.element = cell
                        cell.AssociatedNode = node
                        matrix.Item(rowIndex + r, currCol + c) = node

                        ' Add the event handlers
                        AddHandlers(cell)
                    Next
                Next
            Next
        Next

        Dim i As Integer 
        ' Add new sizes if necesary
        For i = widths.Count To matrix.ColumnCount - 1
            widths.Add(50)
        Next
        For i = heights.Count To matrix.RowCount - 1
            heights.Add(50)
        Next

        RaiseEvent CreateResizeHandles(Me, EventArgs.Empty)
        RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
    End Sub

    Public Sub RemoveHeight(ByVal index As Integer)
        heights.RemoveAt(index)
    End Sub

    Public Sub SplitCell(ByVal cell As Cell, ByVal rowCount As Integer, ByVal colCount As Integer)
        ' Find the position of the cell
        Dim row As Integer = -1
        Dim col As Integer = -1
        Dim i As Integer 
        Dim j As Integer 
        For i = 0 To matrix.RowCount - 1
            For j = 0 To matrix.ColumnCount - 1
                If Not matrix.Item(i, j) Is Nothing AndAlso cell Is matrix.Item(i, j).element Then
                    row = i
                    col = j
                    i = matrix.RowCount
                    j = matrix.ColumnCount
                End If
            Next
        Next
        Dim temp As New DynamicMatrix

        ' From first to split row
        For i = 0 To row - 1

            For j = 0 To col - 1
                temp.Item(i, j) = matrix.Item(i, j)
            Next

            For j = 0 To colCount - 1
                temp.Item(i, col + j) = matrix.Item(i, col)
            Next

            For j = col + colCount To matrix.ColumnCount + colCount - 2
                temp.Item(i, j) = matrix.Item(i, j - colCount + 1)
            Next
        Next

        ' Split row
        For i = row To row + rowCount - 1

            For j = 0 To col - 1
                temp.Item(i, j) = matrix.Item(row, j)
            Next

            For j = 0 To colCount - 1
                If i = row And j = 0 Then
                    temp.Item(i, col + j) = matrix.Item(row, col)
                Else
                    temp.Item(i, col + j) = New Node(-1, -1, -1)
                    temp.Item(i, col + j).element = New Cell
                    temp.Item(i, col + j).element.BackgroundColor = matrix.Item(row, col).element.BackgroundColor
                    temp.Item(i, col + j).element.BorderColor = matrix.Item(row, col).element.BorderColor
                    temp.Item(i, col + j).element.CellPaddingColor = matrix.Item(row, col).element.CellPaddingColor
                    temp.Item(i, col + j).element.ColSpan = matrix.Item(row, col).element.ColSpan
                    temp.Item(i, col + j).element.RowSpan = matrix.Item(row, col).element.RowSpan
                End If
            Next

            For j = col + colCount To matrix.ColumnCount + colCount - 2
                temp.Item(i, j) = matrix.Item(row, j - colCount + 1)
            Next
        Next

        ' From split row to last
        For i = row + rowCount To matrix.RowCount + rowCount - 2

            For j = 0 To col - 1
                temp.Item(i, j) = matrix.Item(i - rowCount + 1, j)
            Next

            For j = 0 To colCount - 1
                temp.Item(i, col + j) = matrix.Item(i - rowCount + 1, col)
            Next

            For j = col + colCount To matrix.ColumnCount + colCount - 2
                temp.Item(i, j) = matrix.Item(i - rowCount + 1, j - colCount + 1)
            Next
        Next

        If Not matrix Is Nothing Then
            ' If an old matrix exists, remove all event handlers
            Dim rowIndex As Integer 
            Dim colIndex As Integer 
            For rowIndex = 0 To matrix.RowCount - 1
                For colIndex = 0 To matrix.ColumnCount - 1
                    If Not matrix.Item(rowIndex, colIndex) Is Nothing AndAlso Not matrix.Item(rowIndex, colIndex).element Is Nothing Then
                        RemoveHandlers(matrix.Item(rowIndex, colIndex).element)
                    End If
                Next
            Next
        End If

        matrix = temp
        BuildTableFromMatrix()
        Rebuild()
    End Sub

    Public Sub MergeCell(ByVal row As Integer, ByVal col As Integer, ByVal rowCount As Integer, ByVal colCount As Integer)
        Dim r As Integer 
        Dim c As Integer 
        For r = 0 To rowCount
            For c = 0 To colCount
                If r <> 0 Or c <> 0 Then
                    matrix.Item(row + r, col + c).element.AssociatedControl.Dispose()
                    matrix.Item(row + r, col + c) = matrix.Item(row, col)
                End If

            Next
        Next

        Dim rowIndex As Integer 
        Dim colIndex As Integer 
        If Not matrix Is Nothing Then
            ' If an old matrix exists, remove all event handlers
            For rowIndex = 0 To matrix.RowCount - 1
                For colIndex = 0 To matrix.ColumnCount - 1
                    If Not matrix.Item(rowIndex, colIndex) Is Nothing AndAlso Not matrix.Item(rowIndex, colIndex).element Is Nothing Then
                        RemoveHandlers(matrix.Item(rowIndex, colIndex).element)
                    End If
                Next
            Next
        End If

        BuildTableFromMatrix()
        Rebuild()
    End Sub

    Public Sub BuildTableFromMatrix()
        Dim temp As New Table
        temp.BorderSize = table.BorderSize
        temp.BorderColor = table.BorderColor
        temp.CellPadding = table.CellPadding
        temp.CellSpacing = table.CellSpacing
        Dim marks(matrix.RowCount, matrix.ColumnCount) As Boolean

        Dim i As Integer 
        For i = 0 To matrix.RowCount - 1
            Dim row As New Row
            Dim j As Integer 
            For j = 0 To matrix.ColumnCount - 1
                If Not marks(i, j) And Not matrix.Item(i, j) Is Nothing Then
                    Dim cell As Cell

                    If matrix.Item(i, j).id = -1 Then
                        cell = New Cell
                        cell.BackgroundColor = matrix.Item(i, j).element.BackgroundColor
                        cell.BorderColor = matrix.Item(i, j).element.BorderColor
                        cell.AssociatedNode = matrix.Item(i, j)
                        matrix.Item(i, j).element = cell

                    Else
                        cell = matrix.Item(i, j).element

                        Dim rl As Integer = 0
                        Dim p As Integer
                        For p = 0 To matrix.ColumnCount - 1
                            If Not matrix.Item(p, j) Is Nothing Then
                                rl += 1
                            End If
                        Next

                        Dim cl As Integer = 0
                        For p = 0 To matrix.RowCount - 1
                            If Not matrix.Item(i, p) Is Nothing Then
                                cl += 1
                            End If
                        Next

                        Dim rs As Integer = 0
                        While i + rs < rl AndAlso matrix.Item(i, j).id = matrix.Item(i + rs, j).id
                            rs += 1
                        End While

                        Dim cs As Integer = 0
                        While j + cs < cl AndAlso matrix.Item(i, j).id = matrix.Item(i, j + cs).id
                            cs += 1
                        End While
                        Dim r As Integer 
                        For r = 0 To rs - 1
                            Dim c As Integer 
                            For c = 0 To cs - 1
                                marks(i + r, j + c) = True
                            Next
                        Next
                        cell.RowSpan = rs
                        cell.ColSpan = cs
                    End If
                    row.Cells.Add(cell)
                End If
            Next
            temp.Rows.Add(row)
        Next
        Dim size As Integer 
        For Each size In widths
            temp.Widths.Add(size)
        Next
        For Each size In heights
            temp.Heights.Add(size)
        Next
        table = temp
        heights = temp.Heights
        widths = temp.Widths
    End Sub

    Private Sub CellRebuild(ByVal sender As Object, ByVal e As EventArgs)
        Rebuild()
    End Sub

    Private Sub SelLengthChanged(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent SelectionLengthChanged(sender, e)
    End Sub

    Private Sub ResizeNeeded(ByVal sender As Object, ByVal e As EventArgs)
        Dim lab As RichTextLabel = CType(sender, RichTextLabel)
        Dim cell As Cell = CType(lab.Tag, Cell)
        table.Heights().Item(cell.AssociatedNode.row) = lab.HeightNeeded
        lab.ScrollToStart()
        RaiseEvent CreateResizeHandles(Me, EventArgs.Empty)
        RaiseEvent RepaintNeeded(Me, EventArgs.Empty)
    End Sub

    Private Sub CellSpanningChanged(ByVal sender As Object, ByVal e As EventArgs)

        ' Find the position of the cell
        Dim cell As Cell = CType(sender, Cell)
        Dim row As Integer = -1
        Dim col As Integer = -1
        Dim i As Integer 
        Dim j As Integer 
        For i = 0 To matrix.RowCount - 1
            For j = 0 To matrix.ColumnCount - 1
                If Not matrix.Item(i, j) Is Nothing AndAlso cell Is matrix.Item(i, j).element Then
                    row = i
                    col = j
                    i = matrix.RowCount
                    j = matrix.ColumnCount
                End If
            Next
        Next

        Dim rs As Integer = 0
        While row + rs < matrix.RowCount AndAlso Not matrix.Item(row + rs, col) Is Nothing AndAlso matrix.Item(row, col).id = matrix.Item(row + rs, col).id
            rs += 1
        End While

        Dim cs As Integer = 0
        While col + cs < matrix.ColumnCount AndAlso Not matrix.Item(row, col + cs) Is Nothing AndAlso matrix.Item(row, col).id = matrix.Item(row, col + cs).id
            cs += 1
        End While

        rs = cell.RowSpan - rs
        cs = cell.ColSpan - cs

        Dim rl As Integer = 0
        For j = 0 To matrix.ColumnCount - 1
            If Not matrix.Item(j, col) Is Nothing Then
                rl += 1
            End If
        Next

        Dim cl As Integer = 0
        For j = 0 To matrix.RowCount - 1
            If Not matrix.Item(row, j) Is Nothing Then
                cl += 1
            End If
        Next

        If (rs > 0 AndAlso row + rs < rl) Or (cs > 0 AndAlso col + cs < cl) Then
            If MessageBox.Show("Do you want to merge the cells?", "Table Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If rs < 0 Then
                    rs = 0
                End If
                If cs < 0 Then
                    cs = 0
                End If

                MergeCell(row, col, rs, cs)
            End If
        End If
        Rebuild()
    End Sub

    Private Sub CellRepaint(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent RepaintNeeded(sender, e)
    End Sub

    Private Sub LabelClicked(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            CType(sender, RichTextLabel).ClearSelection()
            RaiseEvent SelectedCellChanged(sender, e)
        ElseIf e.Button = MouseButtons.Right Then
            RaiseEvent ContextMenuNeeded(sender, e)
        End If

    End Sub

    'Sub DrawShadow(ByVal g As Graphics, ByVal left As Integer, ByVal top As Integer, ByVal width As Integer, ByVal height As Integer)
    '    left += table.ShadowDistance
    '    top += table.ShadowDistance
    '    Dim brush As New PathGradientBrush(New Point() {New Point(left, top), New Point(left + width, top), New Point(left + width, top + height), New Point(left, top + height), New Point(left, top)})
    '    brush.CenterColor = table.ShadowColor
    '    brush.CenterPoint = New PointF(left + width / 2, top + height / 2)
    '    brush.SurroundColors = New Color() {table.BackgroundColor}
    '    g.FillRectangle(brush, left, top, width, height)
    '    'g.FillRectangle(Brushes.Red, left, top, width, height)
    'End Sub

    Public Sub RenderTo(ByVal control As Control, ByVal g As Graphics, Optional ByVal isEditor As Boolean = True)
        ' Calculate the control dimensions
        Dim width As Integer = 0
        Dim height As Integer = 0
        Dim i As Integer 
        For i = 0 To widths.Count - 1
            width += widths(i)
        Next
        For i = 0 To heights.Count - 1
            height += heights(i)
        Next

        Dim xSize As Integer = width \ matrix.ColumnCount
        Dim ySize As Integer = height \ matrix.RowCount

        If control.Width <> width + table.BorderSize + table.ShadowDistance + table.ExteriorBorderSize * 2 Then
            control.Width = width + table.BorderSize + table.ShadowDistance + table.ExteriorBorderSize * 2
        End If
        If control.Height <> height + table.BorderSize + table.ShadowDistance + table.ExteriorBorderSize * 2 Then
            control.Height = height + table.BorderSize + table.ShadowDistance + table.ExteriorBorderSize * 2
        End If

        ' Draw the background
        g.FillRectangle(New SolidBrush(table.BackgroundColor), 0, 0, control.Width, control.Height)

        ' Translate all drawing according to the exterior border
        g.TranslateTransform(table.ExteriorBorderSize, table.ExteriorBorderSize)

        ' Draw the shadow
        If table.ShadowDistance > 0 Then
            Dim steps As Integer = table.ShadowDistance
            For i = 0 To steps
                Dim color As Color = color.FromArgb(table.BackgroundColor.R + (CInt(table.ShadowColor.R) - table.BackgroundColor.R) * CSng(i) / steps, table.BackgroundColor.G + (CInt(table.ShadowColor.G) - table.BackgroundColor.G) * CSng(i) / steps, table.BackgroundColor.B + (CInt(table.ShadowColor.B) - table.BackgroundColor.B) * CSng(i) / steps)
                g.FillRectangle(New SolidBrush(color), table.ShadowDistance + i, table.ShadowDistance + i, width - i * 2, height - i * 2)
            Next
        End If

        ' Draw the border
        g.DrawRectangle(New Pen(table.BorderColor, table.BorderSize), table.BorderSize \ 2, table.BorderSize \ 2, width, height)

        ' Draw each cell
        Dim marks(matrix.RowCount - 1, matrix.ColumnCount - 1) As Boolean

        Dim rowPos As Integer = 0
        Dim rowIndex As Integer 
        Dim colIndex As Integer 

        For rowIndex = 0 To matrix.RowCount - 1
            Dim colPos As Integer = 0
            For colIndex = 0 To matrix.ColumnCount - 1
                If Not matrix.Item(rowIndex, colIndex) Is Nothing And Not marks(rowIndex, colIndex) Then
                    Dim node As Node = matrix.Item(rowIndex, colIndex)

                    Dim rowSize As Integer = 0
                    Dim colSize As Integer = 0

                    ' Expand the marks according to the row and col span
                    Dim r As Integer 
                    Dim c As Integer 
                    For r = 0 To node.element.RowSpan - 1
                        rowSize += heights(rowIndex + r)
                        colSize = 0
                        For c = 0 To node.element.ColSpan - 1
                            marks(rowIndex + r, colIndex + c) = True
                            colSize += widths(colIndex + c)
                        Next
                    Next

                    ' Draw the cell

                    If isEditor Then
                        'DrawShadow(g, table.BorderSize \ 2 + colPos + table.CellSpacing, table.BorderSize \ 2 + rowPos + table.CellSpacing, colSize - table.CellSpacing * 2, rowSize - table.CellSpacing * 2)
                        g.FillRectangle(New SolidBrush(node.element.CellPaddingColor), table.BorderSize \ 2 + colPos + table.CellSpacing, table.BorderSize \ 2 + rowPos + table.CellSpacing, colSize - table.CellSpacing * 2, rowSize - table.CellSpacing * 2)
                        g.DrawRectangle(New Pen(node.element.BorderColor, table.BorderSize), table.BorderSize \ 2 + colPos + table.CellSpacing, table.BorderSize \ 2 + rowPos + table.CellSpacing, colSize - table.CellSpacing * 2, rowSize - table.CellSpacing * 2)

                        ' Set the associated control properties
                        node.element.AssociatedControl.Left = colPos + table.CellSpacing + table.BorderSize + table.CellPadding + table.ExteriorBorderSize + 1
                        node.element.AssociatedControl.Top = rowPos + table.CellSpacing + table.BorderSize + table.CellPadding + table.ExteriorBorderSize + 1
                        node.element.AssociatedControl.Width = colSize - table.CellSpacing * 2 - table.BorderSize - table.CellPadding * 2 - 2
                        node.element.AssociatedControl.Height = rowSize - table.CellSpacing * 2 - table.BorderSize - table.CellPadding * 2 - 2

                        If Not control.Controls.Contains(node.element.AssociatedControl) Then
                            control.Controls.Add(node.element.AssociatedControl)
                        End If
                    Else
                        ' This is for image generation
                        ' The image of the cell is obtained from the richtextbox

                        'DrawShadow(g, table.BorderSize \ 2 + colPos + table.CellSpacing, table.BorderSize \ 2 + rowPos + table.CellSpacing, colSize - table.CellSpacing * 2, rowSize - table.CellSpacing * 2)
                        'g.FillRectangle(New SolidBrush(node.element.CellPaddingColor), table.BorderSize \ 2 + colPos + table.CellSpacing, table.BorderSize \ 2 + rowPos + table.CellSpacing, colSize - table.CellSpacing * 2, rowSize - table.CellSpacing * 2)
                        g.FillRectangle(New SolidBrush(node.element.BackgroundColor), table.BorderSize \ 2 + colPos + table.CellSpacing + table.CellPadding, table.BorderSize \ 2 + rowPos + table.CellSpacing + table.CellPadding, colSize - table.CellSpacing * 2 - table.CellPadding * 2, rowSize - table.CellSpacing * 2 - table.CellPadding * 2)

                        g.DrawRectangle(New Pen(node.element.BorderColor, table.BorderSize), table.BorderSize \ 2 + colPos + table.CellSpacing, table.BorderSize \ 2 + rowPos + table.CellSpacing, colSize - table.CellSpacing * 2, rowSize - table.CellSpacing * 2)

                        Dim sf As New StringFormat
                        Dim rtl As RichTextLabel = node.element.AssociatedControl

                        g.DrawImage(rtl.GetImage(), node.element.AssociatedControl.Left - table.ExteriorBorderSize, node.element.AssociatedControl.Top - table.ExteriorBorderSize)
                    End If

                End If
                colPos += widths(colIndex)
            Next
            rowPos += heights(rowIndex)
        Next


    End Sub

    Private Sub table_RepaintNeeded(ByVal sender As Object, ByVal e As System.EventArgs) Handles table.RepaintNeeded
        RaiseEvent RepaintNeeded(sender, e)
    End Sub

    Sub TableNeeded(ByRef table As table)
        table = Me.table
    End Sub
End Class
