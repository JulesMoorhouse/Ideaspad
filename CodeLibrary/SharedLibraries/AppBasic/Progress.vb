Public Class ProgressStatusBar
    Inherits StatusBar
    'Public Sub New()
    '    MyBase.New()
    '    Me.SizingGrip = False
    '    Me.ShowPanels = True
    'End Sub
    
    Public Sub New()
        MyBase.New()
        Me.SizingGrip = False
        Me.ShowPanels = True

        Me.SetStyle(ControlStyles.UserPaint, True) 'this line stops Ondrawitem :(
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
    End Sub
    Dim DrawCounter As Integer = 0 
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintToolbarBackground(pevent, Me)

        Dim pnl As StatusBarPanel
        Dim lintCurLeft As Integer = 1
        Dim gap As Integer = 0

        For Each pnl In Me.Panels

            DrawCounter += 1 

            Dim x As Integer = lintCurLeft + 1
            Dim y As Integer = 0
            Dim wid As Integer = pnl.Width - 3
            Dim hei As Integer = 21

            pevent.Graphics.DrawLine(New Pen(SystemColors.ControlDark), x, y, x + wid, y) ' top of box
            pevent.Graphics.DrawLine(New Pen(SystemColors.ControlDark), x, y, x, y + hei) ' left of box

            pevent.Graphics.DrawLine(New Pen(SystemColors.ControlLightLight), x, y + hei, x + wid, y + hei) ' bottom of box
            pevent.Graphics.DrawLine(New Pen(SystemColors.ControlLightLight), x + wid, y, x + wid, y + hei) ' right of box

            If pnl.Text <> "" Then
                pevent.Graphics.DrawString(pnl.Text, Me.Font, New SolidBrush(SystemColors.WindowText), x, 3)
            End If

            '-----
            If TypeOf pnl Is ProgressPanel Then
                Dim ProgressPanel As ProgressPanel = CType(pnl, ProgressPanel)
                If ProgressPanel.Value > ProgressPanel.Maximum Then
                    ProgressPanel.Value = ProgressPanel.Maximum
                End If
                If ProgressPanel.Value > ProgressPanel.Minimum Then
                    'Dim NewWidth As Integer = CType(((ProgressPanel.Value / ProgressPanel.Maximum) * ProgressPanel.Width), Integer)
                    Dim NewWidth As Integer = CType(((ProgressPanel.Value / ProgressPanel.Maximum) * wid), Integer)
                    Dim NewBounds As Rectangle = New Rectangle(x, y, wid, hei)
                    Dim PaintBrush As New SolidBrush(ProgressPanel.ForeColor)

                    NewBounds.Width = NewWidth
                    pevent.Graphics.FillRegion(PaintBrush, New [Region](NewBounds))
                    PaintBrush.Dispose()
                End If
            End If
            '-----

            lintCurLeft += pnl.Width + gap
        Next pnl

        If Me.SizingGrip = True Then
            'Console.WriteLine(DrawCounter & "painted sizing grip")
            'ControlPaint.DrawSizeGrip(pevent.Graphics, Me.BackColor, pevent.ClipRectangle)
            
            ControlPaint.DrawSizeGrip(pevent.Graphics, Me.BackColor, pevent.Graphics.VisibleClipBounds.Left, pevent.Graphics.VisibleClipBounds.Top, pevent.Graphics.VisibleClipBounds.Width, pevent.Graphics.VisibleClipBounds.Height)
        End If

    End Sub
    'Protected Overrides Sub OnDrawItem(ByVal e As StatusBarDrawItemEventArgs)

        '    Console.WriteLine("ondrawitem")
        '    If TypeOf e.Panel Is ProgressPanel Then
        '        Dim ProgressPanel As ProgressPanel = CType(e.Panel, ProgressPanel)

        '        If ProgressPanel.Value > ProgressPanel.Minimum Then
        '            Dim NewWidth As Integer = CType(((ProgressPanel.Value / ProgressPanel.Maximum) * ProgressPanel.Width), Integer)

        '            Dim NewBounds As Rectangle = e.Bounds
        '            Dim PaintBrush As New SolidBrush(ProgressPanel.ForeColor)

        '            NewBounds.Width = NewWidth
        '            e.Graphics.FillRegion(PaintBrush, New [Region](NewBounds))
        '            PaintBrush.Dispose()
        '            Console.WriteLine("inc")
        '        Else
        '            MyBase.OnDrawItem(e)
        '        End If
        '    Else
        '        MyBase.OnDrawItem(e)
        '    End If
    'End Sub
    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        ' test if the size is near maximuized, disable the sizing grip
        If SystemInformation.VirtualScreen.Width <= Width Then
            Me.SizingGrip = False
        Else
            Me.SizingGrip = True
        End If
        MyBase.OnResize(e)
    End Sub 'OnResize
    

End Class
Public Class ProgressPanel
    Inherits StatusBarPanel
    Private m_Minimum As Integer = 1
    Private m_Maximum As Integer = 100
    Private m_Value As Integer = 0
    Public Sub New()
        MyBase.New()
        Me.Style = StatusBarPanelStyle.OwnerDraw
    End Sub
    Public Sub Increment(ByVal Amount As Integer)
        Me.Value += Amount
    End Sub
    Public Property Minimum() As Integer
        Get
            Return m_Minimum
        End Get
        Set(ByVal Value As Integer)
            m_Minimum = Value
        End Set
    End Property
    Public Property Maximum() As Integer
        Get
            Return m_Maximum
        End Get
        Set(ByVal Value As Integer)
            m_Maximum = Value
        End Set
    End Property
    Public Property Value() As Integer
        Get
            Return m_Value
        End Get
        Set(ByVal Value As Integer)
            m_Value = Value
            Me.Parent.Refresh()
        End Set
    End Property
    Private m_Color As Color = Color.Black
    Public Property ForeColor() As Color
        Get
            Return m_Color
        End Get
        Set(ByVal Value As Color)
            m_Color = Value
        End Set
    End Property

End Class