Public Class GradientMenu
    Inherits MenuItem

    Sub New()
    End Sub

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        If Not Me.OwnerDraw Then
            MyBase.OnDrawItem(e)
            Exit Sub
        End If
        Me.Text = Me.Text.Replace("&", "")
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(e.Graphics, e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height)

        ' Create the font we will use to draw the text.
        Dim menu_font As Font = SystemInformation.MenuFont

        ' See if the mouse is over the menu item.
        If e.State And DrawItemState.Selected Then
            ' The mouse is over the item.
            ' Draw a shaded background.
            Dim clr As Double
            Dim dclr As Double
            Dim Y As Long

            e.DrawBackground()

            ' Draw the text.
            If Me.Text <> "-" Then
                e.Graphics.DrawString(Me.Text, menu_font, System.Drawing.Brushes.AliceBlue, e.Bounds.X + SystemInformation.MenuCheckSize.Width, e.Bounds.Y)
            Else
                e.Graphics.DrawLine(Pens.Gray, e.Bounds.X, e.Bounds.Y + e.Bounds.Height \ 2, e.Bounds.X + e.Bounds.Width, e.Bounds.Y + e.Bounds.Height \ 2)
            End If
        Else
            ' The mouse is not over the item.
            ' Draw the text.
            If Me.Text <> "-" Then
                e.Graphics.DrawString(Me.Text, menu_font, System.Drawing.Brushes.Black, e.Bounds.X + SystemInformation.MenuCheckSize.Width, e.Bounds.Y)
            Else
                e.Graphics.DrawLine(Pens.Gray, e.Bounds.X, e.Bounds.Y + e.Bounds.Height \ 2, e.Bounds.X + e.Bounds.Width, e.Bounds.Y + e.Bounds.Height \ 2)
            End If
        End If

    End Sub

    Protected Overrides Sub OnMeasureItem(ByVal e As System.Windows.Forms.MeasureItemEventArgs)
        If Not Me.OwnerDraw Then
            MyBase.OnMeasureItem(e)
            Exit Sub
        End If
        Dim menu_font As Font = SystemInformation.MenuFont

        ' See how big the text will be.
        Dim text_size As SizeF = e.Graphics.MeasureString(Me.Text, menu_font)

        ' Set the necessary size.
        e.ItemHeight = text_size.Height + 1
        e.ItemWidth = text_size.Width + SystemInformation.MenuCheckSize.Width
    End Sub
End Class
