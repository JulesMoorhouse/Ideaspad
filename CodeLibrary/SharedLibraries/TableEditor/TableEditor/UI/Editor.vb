Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

Class Editor
    Inherits UIStyleControl

    Private WithEvents rend As Renderer
    Private selCell As Cell
    Private cmCell As Cell

    Private vertPos As Integer
    Private vertMove As Boolean = False

    Private horizPos As Integer
    Private horizMove As Boolean = False

    Private initialSize As Integer

    Private rh As ResizeHandle


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
    Friend WithEvents cellContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents panelTable As TableEditor.DoubleBufferedPanel
    Friend WithEvents MenuItem1 As TableEditor.GradientMenu
    Friend WithEvents MenuItem4 As TableEditor.GradientMenu
    Friend WithEvents cmRemoveRow As TableEditor.GradientMenu
    Friend WithEvents cmRemoveCell As TableEditor.GradientMenu
    Friend WithEvents panelHoriz As System.Windows.Forms.Panel
    Friend WithEvents panelVert As System.Windows.Forms.Panel
    Friend WithEvents cmAddCellAfter As TableEditor.GradientMenu
    Friend WithEvents cmSplit As TableEditor.GradientMenu
    Friend WithEvents cmMerge As TableEditor.GradientMenu
    Friend WithEvents cmAddRow As TableEditor.GradientMenu
    Friend WithEvents cmAddCell As TableEditor.GradientMenu
    Friend WithEvents cmEdit As TableEditor.GradientMenu
    Friend WithEvents MenuItem2 As TableEditor.GradientMenu
    Friend WithEvents cmProperties As TableEditor.GradientMenu
    Friend WithEvents cmAddRowBefore As TableEditor.GradientMenu
    Friend WithEvents cmAddRowAfter As TableEditor.GradientMenu
    Friend WithEvents cmAddCellBefore As TableEditor.GradientMenu
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.panelTable = New TableEditor.DoubleBufferedPanel()
        Me.cellContextMenu = New System.Windows.Forms.ContextMenu()
        Me.cmAddRow = New TableEditor.GradientMenu()
        Me.cmAddRowBefore = New TableEditor.GradientMenu()
        Me.cmAddRowAfter = New TableEditor.GradientMenu()
        Me.cmAddCell = New TableEditor.GradientMenu()
        Me.cmAddCellBefore = New TableEditor.GradientMenu()
        Me.cmAddCellAfter = New TableEditor.GradientMenu()
        Me.MenuItem1 = New TableEditor.GradientMenu()
        Me.cmRemoveRow = New TableEditor.GradientMenu()
        Me.cmRemoveCell = New TableEditor.GradientMenu()
        Me.MenuItem4 = New TableEditor.GradientMenu()
        Me.cmEdit = New TableEditor.GradientMenu()
        Me.cmSplit = New TableEditor.GradientMenu()
        Me.cmMerge = New TableEditor.GradientMenu()
        Me.MenuItem2 = New TableEditor.GradientMenu()
        Me.cmProperties = New TableEditor.GradientMenu()
        Me.panelHoriz = New System.Windows.Forms.Panel()
        Me.panelVert = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'panelTable
        '
        Me.panelTable.Location = New System.Drawing.Point(8, 8)
        Me.panelTable.Name = "panelTable"
        Me.panelTable.Renderer = Nothing
        Me.panelTable.Size = New System.Drawing.Size(376, 344)
        Me.panelTable.TabIndex = 0
        '
        'cellContextMenu
        '
        Me.cellContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmAddRow, Me.cmAddCell, Me.MenuItem1, Me.cmRemoveRow, Me.cmRemoveCell, Me.MenuItem4, Me.cmEdit, Me.cmSplit, Me.cmMerge, Me.MenuItem2, Me.cmProperties})
        '
        'cmAddRow
        '
        Me.cmAddRow.Index = 0
        Me.cmAddRow.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmAddRowBefore, Me.cmAddRowAfter})
        Me.cmAddRow.Text = "Add &row"
        '
        'cmAddRowBefore
        '
        Me.cmAddRowBefore.Index = 0
        Me.cmAddRowBefore.Text = "Before"
        '
        'cmAddRowAfter
        '
        Me.cmAddRowAfter.Index = 1
        Me.cmAddRowAfter.Text = "After"
        '
        'cmAddCell
        '
        Me.cmAddCell.Index = 1
        Me.cmAddCell.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmAddCellBefore, Me.cmAddCellAfter})
        Me.cmAddCell.Text = "Add &cell"
        '
        'cmAddCellBefore
        '
        Me.cmAddCellBefore.Index = 0
        Me.cmAddCellBefore.Text = "Before"
        '
        'cmAddCellAfter
        '
        Me.cmAddCellAfter.Index = 1
        Me.cmAddCellAfter.Text = "After"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Text = "-"
        '
        'cmRemoveRow
        '
        Me.cmRemoveRow.Index = 3
        Me.cmRemoveRow.Text = "Remove r&ow"
        '
        'cmRemoveCell
        '
        Me.cmRemoveCell.Index = 4
        Me.cmRemoveCell.Text = "Remove c&ell"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        Me.MenuItem4.Text = "-"
        '
        'cmEdit
        '
        Me.cmEdit.Index = 6
        Me.cmEdit.Text = "&Edit"
        '
        'cmSplit
        '
        Me.cmSplit.Index = 7
        Me.cmSplit.Text = "&Split"
        '
        'cmMerge
        '
        Me.cmMerge.Index = 8
        Me.cmMerge.Text = "&Merge"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 9
        Me.MenuItem2.Text = "-"
        '
        'cmProperties
        '
        Me.cmProperties.Index = 10
        Me.cmProperties.Text = "&Properties"
        '
        'panelHoriz
        '
        Me.panelHoriz.BackColor = System.Drawing.Color.Transparent
        Me.panelHoriz.Location = New System.Drawing.Point(12, 0)
        Me.panelHoriz.Name = "panelHoriz"
        Me.panelHoriz.Size = New System.Drawing.Size(376, 8)
        Me.panelHoriz.TabIndex = 2
        Me.panelHoriz.Visible = False
        '
        'panelVert
        '
        Me.panelVert.BackColor = System.Drawing.Color.Transparent
        Me.panelVert.Location = New System.Drawing.Point(0, 12)
        Me.panelVert.Name = "panelVert"
        Me.panelVert.Size = New System.Drawing.Size(8, 344)
        Me.panelVert.TabIndex = 3
        Me.panelVert.Visible = False
        '
        'Editor
        '
        Me.AutoScroll = True
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panelVert, Me.panelHoriz, Me.panelTable})
        Me.Name = "Editor"
        Me.Size = New System.Drawing.Size(432, 416)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Event SelectedObjectChanged As EventHandler
    Public Event SelectionLengthChanged As EventHandler

    Public ReadOnly Property SelectedCell() As Cell
        Get
            Return selCell
        End Get
    End Property

    Public Property Renderer() As Renderer
        Get
            Return rend
        End Get
        Set(ByVal Value As Renderer)
            rend = Value
            CType(panelTable, DoubleBufferedPanel).Renderer = rend
        End Set
    End Property

    Private Sub rend_SelectedCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rend.SelectedCellChanged
        Dim lab As RichTextLabel = CType(sender, RichTextLabel)
        selCell = CType(lab.Tag, Cell)
        RaiseEvent SelectedObjectChanged(selCell, New EventArgs)
    End Sub

    Private Sub rend_RepaintNeeded(ByVal sender As Object, ByVal e As System.EventArgs) Handles rend.RepaintNeeded
        panelTable.Refresh()
    End Sub

    Private Sub Editor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        If Not selCell Is Nothing Then
            CType(selCell.AssociatedControl, RichTextLabel).ClearSelection()
            RaiseEvent SelectedObjectChanged(rend.RenderedTable, New EventArgs())
        End If
    End Sub

    Public Sub SetSelectedAsContext()
        cmCell = selCell
    End Sub

    Private Sub cmSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmSplit.Click
        Dim split As New SplitCell()
        If split.ShowDialog(Me.ParentForm) = DialogResult.OK Then
            Dim rows As Integer = split.Rows
            Dim cols As Integer = split.Columns
            rend.SplitCell(cmCell, rows, cols)
        End If
    End Sub

    Private Sub rend_ContextMenuNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rend.ContextMenuNeeded
        cmCell = CType(CType(sender, Control).Tag, Cell)
        cellContextMenu.Show(cmCell.AssociatedControl, New Point(e.X, e.Y))
    End Sub

    Private Sub cmMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmMerge.Click
        Dim startRow, startCol, endRow, endCol As Integer

        If RichTextLabel.selected.Count = 0 Or (RichTextLabel.selectionSize.Height = 0 And RichTextLabel.selectionSize.Width = 0) Then
            MessageBox.Show(TranslationTable.GetTranslation("mergeinfo"), "Table Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim startRtl As RichTextLabel = RichTextLabel.selected(0)
        startRow = CType(startRtl.Tag, Cell).AssociatedNode.row
        startCol = CType(startRtl.Tag, Cell).AssociatedNode.cell

        rend.MergeCell(startRow, startCol, RichTextLabel.selectionSize.Height, RichTextLabel.selectionSize.Width)
    End Sub

    'Private Sub cmAddRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmAddRow.Click
    '    ' Insert a new row with the same quantity of cells
    '    Dim newRow As Row = New Row
    '    Dim i As Integer 

    '    For i = 1 To CType(rend.RenderedTable.Rows.Item(cmCell.AssociatedNode.row), Row).Cells.Count
    '        Dim newCell As Cell = New Cell
    '        ' Set properties
    '        newCell.BorderColor = cmCell.BorderColor
    '        newCell.BackgroundColor = rend.RenderedTable.DefaultCellColor
    '        newCell.AssociatedControl.Font = rend.RenderedTable.DefaultCellFont
    '        newCell.AssociatedControl.ForeColor = rend.RenderedTable.DefaultTextColor

    '        newRow.Cells.Add(newCell)
    '    Next

    '    rend.RenderedTable.Rows.Insert(cmCell.AssociatedNode.row, newRow)

    '    rend.Rebuild()

    '    RaiseEvent SelectedObjectChanged(rend.RenderedTable, New EventArgs)
    'End Sub

    'Private Sub cmAddCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmAddCell.Click
    '    Dim row As Row
    '    For Each row In rend.RenderedTable.Rows

    '        ' Insert a new cell
    '        Dim newCell As Cell = New Cell

    '        ' Set properties
    '        newCell.BorderColor = cmCell.BorderColor
    '        newCell.BackgroundColor = rend.RenderedTable.DefaultCellColor
    '        newCell.AssociatedControl.Font = rend.RenderedTable.DefaultCellFont
    '        newCell.AssociatedControl.ForeColor = rend.RenderedTable.DefaultTextColor

    '        row.Cells.Insert(cmCell.AssociatedNode.cell, newCell)
    '    Next

    '    rend.Rebuild()

    '    RaiseEvent SelectedObjectChanged(rend.RenderedTable, New EventArgs)
    'End Sub

    Private Sub cmRemoveRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmRemoveRow.Click
        If rend.RenderedTable.Rows.Count > 1 Then
            ' Remove the label associated to the all the cells of the row
            Dim cell As Cell 
            For Each cell In CType(rend.RenderedTable.Rows.Item(cmCell.AssociatedNode.row), Row).Cells
                cell.AssociatedControl.Parent = Nothing
                cell.AssociatedControl.Dispose()
            Next

            rend.RenderedTable.Rows.RemoveAt(cmCell.AssociatedNode.row)
            rend.Rebuild()
            rend.RemoveHeight(cmCell.AssociatedNode.row)
            RaiseEvent SelectedObjectChanged(rend.RenderedTable, New EventArgs())
        End If
    End Sub

    Private Sub cmRemoveCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmRemoveCell.Click
        ' Remove the label associated to the cell
        cmCell.AssociatedControl.Parent = Nothing
        CType(rend.RenderedTable.Rows.Item(cmCell.AssociatedNode.row), Row).Cells.RemoveAt(cmCell.AssociatedNode.cell)

        rend.Rebuild()

        RaiseEvent SelectedObjectChanged(rend.RenderedTable, New EventArgs())
    End Sub

    Private Sub panelTable_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles panelTable.SizeChanged
        If Not rend Is Nothing Then
            panelHoriz.Left = 12 + rend.RenderedTable.BorderSize \ 2
            panelVert.Top = 12 + rend.RenderedTable.BorderSize \ 2
        Else
            panelHoriz.Left = 12
            panelVert.Top = 12
        End If
        panelHoriz.Width = panelTable.Width + 8
        panelVert.Height = panelTable.Height + 8

        If Not Me.ParentForm Is Nothing AndAlso Me.Dock = DockStyle.None Then
            Dim scr As Rectangle = Screen.PrimaryScreen.WorkingArea
            Dim w As Integer = Math.Min(Math.Max(panelTable.Width + 50, 20), scr.Width)
            Dim h As Integer = Math.Min(Math.Max(panelTable.Height + 40, 100) + 110, scr.Height)
            Me.ParentForm.Width = w
            Me.ParentForm.Height = h

            Me.Dock = DockStyle.Fill
        End If


    End Sub

    Private Sub rend_CreateResizeHandles(ByVal sender As Object, ByVal e As System.EventArgs) Handles rend.CreateResizeHandles
        ' Remove existing handles
        panelHoriz.Controls.Clear()
        panelVert.Controls.Clear()

        Dim i As Integer 
        ' Add new handles
        Dim sum As Integer = 0
        For i = 0 To rend.RenderedTable.Widths.Count - 1
            Dim handle As New ResizeHandle(False)
            handle.TabIndex = i
            handle.Top = 0
            sum += rend.RenderedTable.Widths(i)
            handle.Left = sum
            handle.Cursor = Cursors.SizeWE
            panelHoriz.Controls.Add(handle)
            AddHandler handle.MouseDown, AddressOf HorizResizeHandle_MouseDown
            AddHandler handle.MouseMove, AddressOf HorizResizeHandle_MouseMove
            AddHandler handle.MouseUp, AddressOf HorizResizeHandle_MouseUp
        Next
        sum = 0
        For i = 0 To rend.RenderedTable.Heights.Count - 1
            Dim handle As New ResizeHandle(True)
            handle.TabIndex = i
            handle.Left = 0
            sum += rend.RenderedTable.Heights(i)
            handle.Top = sum
            handle.Cursor = Cursors.SizeNS
            panelVert.Controls.Add(handle)
            AddHandler handle.MouseDown, AddressOf VertResizeHandle_MouseDown
            AddHandler handle.MouseMove, AddressOf VertResizeHandle_MouseMove
            AddHandler handle.MouseUp, AddressOf VertResizeHandle_MouseUp
        Next

    End Sub

    Private Sub HorizResizeHandle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        horizPos = e.X
        horizMove = True
        RaiseEvent SelectedObjectChanged(rend.RenderedTable, EventArgs.Empty)
    End Sub
    Private Sub HorizResizeHandle_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If horizMove Then
            Dim handle As ResizeHandle = CType(sender, ResizeHandle)

            Dim disp As Integer = e.X - horizPos
            If CType(rend.RenderedTable.Widths.Item(handle.TabIndex), Integer) + disp < 10 Then
                disp = 10 - CType(rend.RenderedTable.Widths.Item(handle.TabIndex), Integer)
            End If

            rend.RenderedTable.Widths.Item(handle.TabIndex) = CType(rend.RenderedTable.Widths.Item(handle.TabIndex), Integer) + disp
            Dim hand As ResizeHandle 
            For Each hand In panelHoriz.Controls
                If hand.TabIndex >= handle.TabIndex Then
                    hand.Left += disp
                End If
            Next

            Refresh()
        End If
    End Sub
    Private Sub HorizResizeHandle_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        horizMove = False
    End Sub

    Private Sub VertResizeHandle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        vertPos = e.Y
        vertMove = True
        RaiseEvent SelectedObjectChanged(rend.RenderedTable, EventArgs.Empty)
    End Sub
    Private Sub VertResizeHandle_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If vertMove Then
            Dim handle As ResizeHandle = CType(sender, ResizeHandle)

            Dim disp As Integer = e.Y - vertPos
            If CType(rend.RenderedTable.Heights.Item(handle.TabIndex), Integer) + disp < 10 Then
                disp = 10 - CType(rend.RenderedTable.Heights.Item(handle.TabIndex), Integer)
            End If

            rend.RenderedTable.Heights.Item(handle.TabIndex) = CType(rend.RenderedTable.Heights.Item(handle.TabIndex), Integer) + disp
            Dim hand As ResizeHandle 
            For Each hand In panelVert.Controls
                If hand.TabIndex >= handle.TabIndex Then
                    hand.Top += disp
                End If
            Next

            Refresh()
        End If
    End Sub
    Private Sub VertResizeHandle_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        vertMove = False
    End Sub

    Private Sub panelTable_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelTable.MouseMove
        If horizMove Then

            Dim disp As Integer = e.X - horizPos
            If CType(rend.RenderedTable.Widths.Item(rh.TabIndex), Integer) + disp < 10 Then
                disp = 10 - CType(rend.RenderedTable.Widths.Item(rh.TabIndex), Integer)
            End If

            rend.RenderedTable.Widths.Item(rh.TabIndex) = CType(rend.RenderedTable.Widths.Item(rh.TabIndex), Integer) + disp
            Dim hand As ResizeHandle 
            For Each hand In panelHoriz.Controls
                If hand.TabIndex >= rh.TabIndex Then
                    hand.Left += disp
                End If
            Next

            horizPos = e.X
            Refresh()
        ElseIf vertMove Then
            Dim disp As Integer = e.Y - vertPos
            If CType(rend.RenderedTable.Heights.Item(rh.TabIndex), Integer) + disp < 10 Then
                disp = 10 - CType(rend.RenderedTable.Heights.Item(rh.TabIndex), Integer)
            End If

            rend.RenderedTable.Heights.Item(rh.TabIndex) = CType(rend.RenderedTable.Heights.Item(rh.TabIndex), Integer) + disp
            Dim hand As ResizeHandle 
            For Each hand In panelVert.Controls
                If hand.TabIndex >= rh.TabIndex Then
                    hand.Top += disp
                End If
            Next
            vertPos = e.Y
            Refresh()
        Else
            panelTable.Cursor = Cursors.Default
            Dim i As Integer 
            For i = 0 To panelHoriz.Controls.Count - 1
                rh = CType(panelHoriz.Controls(i), ResizeHandle)
                If Math.Abs(e.X - rh.Left) <= rend.RenderedTable.BorderSize Then
                    panelTable.Cursor = Cursors.SizeWE
                    Exit Sub
                End If
            Next

            For i = 0 To panelVert.Controls.Count - 1
                rh = CType(panelVert.Controls(i), ResizeHandle)
                If Math.Abs(e.Y - rh.Top) <= rend.RenderedTable.BorderSize Then
                    panelTable.Cursor = Cursors.SizeNS
                    Exit Sub
                End If
            Next
        End If

    End Sub

    Private Sub panelTable_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelTable.MouseDown
        If panelTable.Cursor Is Cursors.SizeWE Then
            initialSize = rend.RenderedTable.Widths.Item(rh.TabIndex)
            horizPos = e.X
            horizMove = True
            RaiseEvent SelectedObjectChanged(rend.RenderedTable, EventArgs.Empty)
        End If

        If panelTable.Cursor Is Cursors.SizeNS Then
            initialSize = rend.RenderedTable.Heights.Item(rh.TabIndex)
            vertPos = e.Y
            vertMove = True
            RaiseEvent SelectedObjectChanged(rend.RenderedTable, EventArgs.Empty)
        End If

    End Sub

    Private Sub panelTable_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelTable.MouseUp
        If horizMove Then
            horizMove = False
            Dim scs As New SizeChangeState(rend.RenderedTable.Widths, rh.TabIndex, initialSize, rend.RenderedTable.Widths(rh.TabIndex))
            UndoRedo.NewState(scs)
        ElseIf vertMove Then
            vertMove = False
            Dim scs As New SizeChangeState(rend.RenderedTable.Heights, rh.TabIndex, initialSize, rend.RenderedTable.Heights(rh.TabIndex))
            UndoRedo.NewState(scs)
        End If
        rh = Nothing
    End Sub

    Private Sub panelTable_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles panelTable.MouseLeave
        panelTable.Cursor = Cursors.Default
    End Sub

    Private Sub cmEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmEdit.Click
        selCell = cmCell
        cmCell.AssociatedControl.SetFocus()
        RaiseEvent SelectedObjectChanged(cmCell, e)
    End Sub

    Private Sub cmProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmProperties.Click
        'Dim img As New Bitmap(100, 100)
        'Dim g As Graphics = Graphics.FromImage(img)
        'rend.RenderTo(panelTable, g, False)
        Dim mte As MainTableEditor = CType(Me.Parent.Parent, MainTableEditor)
        mte.mmViewProp.PerformClick()
    End Sub

    Private Sub Editor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the translations
        cmAddRow.Text = TranslationTable.GetTranslation("menuaddrow")
        cmAddCell.Text = TranslationTable.GetTranslation("menuaddcolumn")
        cmRemoveRow.Text = TranslationTable.GetTranslation("menuremoverow")
        cmRemoveCell.Text = TranslationTable.GetTranslation("menuremovecolumn")
        cmEdit.Text = TranslationTable.GetTranslation("menuedit")
        cmSplit.Text = TranslationTable.GetTranslation("menusplit")
        cmProperties.Text = TranslationTable.GetTranslation("menuproperties")
    End Sub

    Private Sub rend_SelectionLengthChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rend.SelectionLengthChanged
        RaiseEvent SelectionLengthChanged(sender, e)
    End Sub

    Private Sub cmAddRowBefore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmAddRowBefore.Click
        AddRow(cmCell.AssociatedNode.row)
    End Sub

    Private Sub cmAddRowAfter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmAddRowAfter.Click
        AddRow(cmCell.AssociatedNode.row + 1)
    End Sub

    Private Sub cmAddCellBefore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmAddCellBefore.Click
        AddCell(cmCell.AssociatedNode.cell)
    End Sub

    Private Sub cmAddCellAfter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmAddCellAfter.Click
        AddCell(cmCell.AssociatedNode.cell + 1)
    End Sub

    Private Sub AddRow(ByVal pos As Integer)
        ' Insert a new row with the same quantity of cells
        Dim newRow As Row = New Row()
        Dim i As Integer 

        For i = 1 To CType(rend.RenderedTable.Rows.Item(Math.Min(pos, rend.RenderedTable.Rows.Count - 1)), Row).Cells.Count
            Dim newCell As Cell = New Cell()
            ' Set properties
            newCell.BorderColor = cmCell.BorderColor
            newCell.BackgroundColor = rend.RenderedTable.DefaultCellColor
            newCell.AssociatedControl.Font = rend.RenderedTable.DefaultCellFont
            newCell.AssociatedControl.ForeColor = rend.RenderedTable.DefaultTextColor

            newRow.Cells.Add(newCell)
        Next

        rend.RenderedTable.Rows.Insert(pos, newRow)
        rend.Rebuild()

        RaiseEvent SelectedObjectChanged(rend.RenderedTable, New EventArgs())
    End Sub

    Private Sub AddCell(ByVal pos As Integer)
        Dim row As Row
        For Each row In rend.RenderedTable.Rows

            ' Insert a new cell
            Dim newCell As Cell = New Cell()

            ' Set properties
            newCell.BorderColor = cmCell.BorderColor
            newCell.BackgroundColor = rend.RenderedTable.DefaultCellColor
            newCell.AssociatedControl.Font = rend.RenderedTable.DefaultCellFont
            newCell.AssociatedControl.ForeColor = rend.RenderedTable.DefaultTextColor

            row.Cells.Insert(pos, newCell)
        Next

        rend.Rebuild()

        RaiseEvent SelectedObjectChanged(rend.RenderedTable, New EventArgs())
    End Sub
End Class
