Imports System.Runtime.InteropServices

Public Class RichTextLabel

    Inherits System.Windows.Forms.Panel

    Private Shared dragFrom As RichTextBox
    Private Shared dragAction As DragDropEffects
    Friend Shared selected As New ArrayList
    Friend Shared selectionSize As Size

    Private mDown As Boolean


    Public Shadows Event MouseDown As MouseEventHandler
    Public Event SelectionLengthChanged As EventHandler
    Public Event ResizeNeeded As EventHandler

    Friend Delegate Sub TableEventHandler(ByRef table As Table)
    Friend Event TableNeeded As TableEventHandler


    Dim rtf As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        rtb.AllowDrop = True
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
    Private WithEvents cmTxt As System.Windows.Forms.ContextMenu
    Private WithEvents MenuItem4 As GradientMenu
    Friend WithEvents mmCut As GradientMenu
    Friend WithEvents mmCopy As GradientMenu
    Friend WithEvents mmPaste As GradientMenu
    Friend WithEvents mmFont As GradientMenu
    Friend WithEvents mmColor As GradientMenu
    Private WithEvents rtb As RichTextBoxEx 'System.Windows.Forms.RichTextBox
    Friend WithEvents mmInsertImage As GradientMenu
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rtb = New TableEditor.RichTextBoxEx()
        Me.cmTxt = New System.Windows.Forms.ContextMenu()
        Me.mmCut = New TableEditor.GradientMenu()
        Me.mmCopy = New TableEditor.GradientMenu()
        Me.mmPaste = New TableEditor.GradientMenu()
        Me.MenuItem4 = New TableEditor.GradientMenu()
        Me.mmFont = New TableEditor.GradientMenu()
        Me.mmColor = New TableEditor.GradientMenu()
        Me.mmInsertImage = New TableEditor.GradientMenu()
        Me.SuspendLayout()
        '
        'rtb
        '
        Me.rtb.BackColor = System.Drawing.SystemColors.Control
        Me.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb.CausesValidation = False
        Me.rtb.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.rtb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rtb.Location = New System.Drawing.Point(17, 17)
        Me.rtb.Name = "rtb"
        Me.rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtb.Size = New System.Drawing.Size(150, 90)
        Me.rtb.TabIndex = 0
        Me.rtb.TabStop = False
        Me.rtb.Text = ""
        '
        'cmTxt
        '
        Me.cmTxt.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mmCut, Me.mmCopy, Me.mmPaste, Me.MenuItem4, Me.mmFont, Me.mmColor, Me.mmInsertImage})
        '
        'mmCut
        '
        Me.mmCut.Index = 0
        Me.mmCut.Text = "&Cut"
        '
        'mmCopy
        '
        Me.mmCopy.Index = 1
        Me.mmCopy.Text = "&Copy"
        '
        'mmPaste
        '
        Me.mmPaste.Index = 2
        Me.mmPaste.Text = "&Paste"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "-"
        '
        'mmFont
        '
        Me.mmFont.Index = 4
        Me.mmFont.Text = "Font..."
        '
        'mmColor
        '
        Me.mmColor.Index = 5
        Me.mmColor.Text = "Color..."
        '
        'mmInsertImage
        '
        Me.mmInsertImage.Index = 6
        Me.mmInsertImage.Text = "Insert image..."
        '
        'RichTextLabel
        '
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.rtb})
        Me.Size = New System.Drawing.Size(150, 90)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Public Sub SetFocus()
        rtb.Focus()
        rtb.Cursor = Cursors.IBeam
    End Sub

    Public Overrides Property BackColor() As Color
        Get
            Return rtb.BackColor
        End Get
        Set(ByVal Value As Color)
            rtb.BackColor = Value
        End Set
    End Property

    Public Overrides Property ForeColor() As Color
        Get
            Return rtb.ForeColor
        End Get
        Set(ByVal Value As Color)
            rtb.ForeColor = Value
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return rtb.Text
        End Get
        Set(ByVal Value As String)
            rtb.Text = Value
        End Set
    End Property

    Public Overrides Property BackgroundImage() As Image
        Get
            Return rtb.BackgroundImage
        End Get
        Set(ByVal Value As Image)
            rtb.BackgroundImage = Value
        End Set
    End Property

    Public Property RtfText() As String
        Get
            Return rtb.Rtf
        End Get
        Set(ByVal Value As String)
            rtb.Rtf = Value
        End Set
    End Property

    Public ReadOnly Property SelectionLength()
        Get
            Return rtb.SelectionLength
        End Get
    End Property

    Public ReadOnly Property HeightNeeded()
        Get
            Dim first As Point = rtb.GetPositionFromCharIndex(0)
            Dim last As Point = rtb.GetPositionFromCharIndex(rtb.TextLength - 1)

            Return last.Y - first.Y + rtb.SelectionFont.GetHeight() * 2
        End Get
    End Property

    Public Sub ScrollToStart()
        Dim temp As Integer = rtb.SelectionStart
        rtb.SelectionStart = 0
        rtb.SelectionStart = temp
    End Sub

    Public Sub ClearSelection()
        rtb.SelectionLength = 0
    End Sub

    Private Sub rtf_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rtb.MouseDown
        If e.Button = MouseButtons.Left Then
            rtb.Cursor = Cursors.IBeam

            If rtb.SelectionLength > 0 Then
                mDown = True
            Else
                ' Multiselect
                If Control.ModifierKeys And Keys.Shift And selected.Count > 0 Then
                    Dim table As Table
                    RaiseEvent TableNeeded(table)

                    Dim startRow, startCol, endRow, endCol As Integer

                    Dim startRtl As RichTextLabel = selected(0)
                    startRow = CType(startRtl.Tag, Cell).AssociatedNode.row
                    startCol = CType(startRtl.Tag, Cell).AssociatedNode.cell
                    endRow = CType(Me.Tag, Cell).AssociatedNode.row
                    endCol = CType(Me.Tag, Cell).AssociatedNode.cell
                    selectionSize = New Size(endCol - startCol, endRow - startRow)

                    Dim rtl As RichTextLabel 
                    For Each rtl In selected
                        rtl.BorderStyle = BorderStyle.None
                    Next
                    selected.Clear()

                    Dim i As Integer 
                    For i = startRow To endRow
                        Dim row As Row = table.Rows(i)
                        Dim j As Integer 
                        For j = startCol To Math.Min(endCol, row.Cells.Count - 1)
                            Dim cell As Cell = row.Cells(j)
                            cell.AssociatedControl.BorderStyle = BorderStyle.FixedSingle
                            selected.Add(cell.AssociatedControl)
                            cell.AssociatedControl.ClearSelection()
                        Next
                    Next
                Else
                    Dim rtl As RichTextLabel 
                    For Each rtl In selected
                        rtl.BorderStyle = BorderStyle.None
                    Next
                    selected.Clear()
                    selected.Add(Me)
                    Me.BorderStyle = BorderStyle.FixedSingle
                End If

                RaiseEvent MouseDown(Me, e)
            End If

        ElseIf selected.Count = 1 AndAlso rtb.Cursor Is Cursors.IBeam Then
            cmTxt.Show(rtb, New Point(e.X, e.Y))
        Else
            RaiseEvent MouseDown(Me, e)
        End If
    End Sub

    Private Sub rtb_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rtb.MouseMove
        If mDown Then
            dragFrom = rtb
            rtb.DoDragDrop(rtb.SelectedText, DragDropEffects.Copy Or DragDropEffects.Move)
        End If
    End Sub

    Private Sub rtf_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtb.LostFocus
        rtb.Cursor = Cursors.Default
        'rtb.SelectionLength = 0
    End Sub


    Private Sub mmCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmCut.Click
        rtb.Cut()
    End Sub

    Private Sub mmCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmCopy.Click
        rtb.Copy()
    End Sub

    Private Sub mmPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmPaste.Click
        rtb.Paste()
    End Sub

    Private Sub mmFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmFont.Click
        Dim fd As New FontDialog
        fd.Font = rtb.Font

        If fd.ShowDialog(Me) = DialogResult.OK Then
            If rtb.SelectionLength = 0 Then
                rtb.Font = fd.Font
            Else
                rtb.SelectionFont = fd.Font
            End If
        End If
    End Sub

    Private Sub mmColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmColor.Click
        Dim cd As New ColorDialog
        cd.Color = rtb.ForeColor

        If cd.ShowDialog(Me) = DialogResult.OK Then
            If rtb.SelectionLength = 0 Then
                rtb.ForeColor = cd.Color
            Else
                rtb.SelectionColor = cd.Color
            End If
        End If
    End Sub

    Private Sub rtb_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles rtb.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            If (e.KeyState And 8) = 8 Then ' Ctrl mask
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub rtb_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles rtb.DragOver
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            If (e.KeyState And 8) = 8 Then ' Ctrl mask
                e.Effect = DragDropEffects.Copy
                dragAction = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
                dragAction = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub rtb_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles rtb.DragDrop
        If dragAction = DragDropEffects.Move And Not dragFrom Is Nothing Then
            dragFrom.SelectedText = ""
        End If

        rtb.SelectedText = e.Data.GetData(DataFormats.Text)

        If Not dragFrom Is Nothing Then
            dragFrom = Nothing
        End If
        mDown = False
    End Sub


    Private Sub rtb_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rtb.MouseUp
        mDown = False
    End Sub

    Private Sub mmInsertImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmInsertImage.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Images|*.jpg;*.bmp;*.tiff;*.png;*.gif|All files|*.*"
        ofd.FilterIndex = 0
        If ofd.ShowDialog = DialogResult.OK Then
            Try
                Dim bmp As New Bitmap(ofd.FileName)
                Clipboard.SetDataObject(bmp)
                rtb.Paste(DataFormats.GetFormat(DataFormats.Bitmap))
                bmp.Dispose()
            Catch
                MessageBox.Show("Error inserting the image", "")
            End Try
        End If
    End Sub


    Private Sub rtb_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb.MouseEnter
        Me.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub rtb_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb.MouseLeave
        If (selected.Count > 1 AndAlso Not selected.Contains(Me)) Or selected.Count <= 1 Then
            Me.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub rtb_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb.SelectionChanged
        RaiseEvent SelectionLengthChanged(sender, e)
    End Sub

    Private Sub rtb_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb.TextChanged
        CheckSize()
        Dim pcs As New ControlChangeState(rtb)
        UndoRedo.NewState(pcs)
        rtf = rtb.Rtf
    End Sub

    Private Sub rtb_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb.FontChanged
        CheckSize()
    End Sub

    Private Sub rtb_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtb.ForeColorChanged
        CheckSize()
    End Sub

    Private Sub CheckSize()
        ' Check if the text fits within the richtextbox
        If HeightNeeded > rtb.Height Then
            RaiseEvent ResizeNeeded(Me, EventArgs.Empty)
        End If
    End Sub

    Public Function GetImage() As Bitmap
        Dim bmp As New Bitmap(rtb.Width, rtb.Height)
        Dim dest As Graphics = Graphics.FromImage(bmp)
        rtb.Rtf = rtf
        rtb.FormatRange(False, dest, 0, rtb.TextLength)
        rtb.FormatRangeDone()
        Return bmp
    End Function

    Public Sub Undo()
        rtb.Undo()
    End Sub

    Public Sub Redo()
        rtb.Redo()
    End Sub

End Class
