'Imports System
Imports System.ComponentModel
'Imports System.Drawing
'Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
'Imports System.Reflection
'Imports System.Resources
'Imports System.Windows.Forms
Public Class IconMenuItem : Inherits MenuItem
    Private m_Icon As Icon
    Public Sub New()
        MyClass.New("", Nothing, Nothing, System.Windows.Forms.Shortcut.None)
    End Sub
    Public Sub New(ByVal text As String, ByVal icon As Icon, ByVal onClick As EventHandler, ByVal shortcut As Shortcut)
        MyBase.New(text, onClick, shortcut)
        ' allows you to modify the menu item by handling  OnMeasureItem and OnDrawItem
        OwnerDraw = True
        m_Icon = icon
    End Sub
    Private Function GetRealText() As String
        Dim s As String = Text

        ' Append shortcut if one is set and it should be visible
        If ShowShortcut And Shortcut <> Shortcut.None Then
            ' To get a string representation of a Shortcut value, cast
            ' it into a Keys value and use the KeysConverter class (via TypeDescriptor).
            Dim k As Keys = CType(Shortcut, Keys)
            s = s & Convert.ToChar(9) & TypeDescriptor.GetConverter(GetType(Keys)).ConvertToString(k)
        End If

        Return s
    End Function
    Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
        MyBase.OnDrawItem(e)
        Dim br As Brush
        Dim rcBk As Rectangle = e.Bounds


        If CBool(e.State And DrawItemState.Selected) Then
            'rcBk.Height -= 1
            rcBk.Height -= 4
            rcBk.Width = e.Bounds.Width - 1
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ActiveCaption), rcBk)
        Else
            'e.Graphics.FillRectangle(New SolidBrush(SystemColors.Control), rcBk)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.Menu), rcBk)   
        End If

        If Not m_Icon Is Nothing Then
            'e.Graphics.DrawIcon(m_Icon, e.Bounds.Left + 2, e.Bounds.Top + 2)
            e.Graphics.DrawIcon(m_Icon, e.Bounds.Left + 2, e.Bounds.Top + 1)
        End If

        ' Leave room for accelerator key
        Dim sf As StringFormat = New StringFormat()
        sf.HotkeyPrefix = HotkeyPrefix.Show

        sf.SetTabStops(60, New Single() {0})
        br = New SolidBrush(e.ForeColor)
        'e.Graphics.DrawString(GetRealText(), e.Font, br, e.Bounds.Left + 25, e.Bounds.Top + 2, sf)
        e.Graphics.DrawString(GetRealText(), e.Font, br, e.Bounds.Left + 25, e.Bounds.Top + 2, sf)
    End Sub
    Protected Overrides Sub OnMeasureItem(ByVal e As MeasureItemEventArgs)
        Dim sf As StringFormat = New StringFormat()

        sf.HotkeyPrefix = HotkeyPrefix.Show
        sf.SetTabStops(60, New Single() {0})

        MyBase.OnMeasureItem(e)
        e.ItemHeight = 22
        Dim fnt As Font = SystemInformation.MenuFont

        e.ItemWidth = CInt(e.Graphics.MeasureString(GetRealText(), fnt, 10000, sf).Width) + 10
        sf.Dispose()
        sf = Nothing
    End Sub
End Class

