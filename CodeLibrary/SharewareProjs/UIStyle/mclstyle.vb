Imports System.Drawing

Public Module MCLStyle
    Sub Paper(ByVal e As System.Windows.Forms.PaintEventArgs, Optional ByVal pLeftAdj As Long = 0, Optional ByVal pTopAdj As Long = 0)
        Dim leftAdj As Integer = 20 - pLeftAdj

        e.Graphics.SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias

        e.Graphics.FillRectangle(Brushes.Blue, New Rectangle(5 + pLeftAdj, 5 + pTopAdj, 110, 125))
        e.Graphics.DrawRectangle(New Pen(Color.DarkBlue, 5), New Rectangle(5 + pLeftAdj, 5 + pTopAdj, 110, 125))

        Dim Files1() As Point
        ReDim Files1(4)

        Files1(0) = New Point(121.1765 - leftAdj, 38.82353 + pTopAdj) 'A
        Files1(1) = New Point(85.88235 - leftAdj, 17.64706 + pTopAdj) 'B
        Files1(2) = New Point(36.47059 - leftAdj, 60 + pTopAdj) 'C
        Files1(3) = New Point(71.76471 - leftAdj, 81.17647 + pTopAdj) 'D
        Files1(4) = New Point(121.1765 - leftAdj, 38.82353 + pTopAdj) 'E

        Dim Files2() As Point
        ReDim Files2(4)

        Files2(0) = New Point(121.1765 - leftAdj, 38.82353 + 18 + pTopAdj) 'A
        Files2(1) = New Point(85.88235 - leftAdj, 17.64706 + 18 + pTopAdj) 'B
        Files2(2) = New Point(36.47059 - leftAdj, 60 + 18 + pTopAdj) 'C
        Files2(3) = New Point(71.76471 - leftAdj, 81.17647 + 18 + pTopAdj) 'D
        Files2(4) = New Point(121.1765 - leftAdj, 38.82353 + 18 + pTopAdj) 'E

        Dim Files3() As Point
        ReDim Files3(4)

        Files3(0) = New Point(121.1765 - leftAdj, 38.82353 + 36 + pTopAdj) 'A
        Files3(1) = New Point(85.88235 - leftAdj, 17.64706 + 36 + pTopAdj) 'B
        Files3(2) = New Point(36.47059 - leftAdj, 60 + 36 + pTopAdj) 'C
        Files3(3) = New Point(71.76471 - leftAdj, 81.17647 + 36 + pTopAdj) 'D
        Files3(4) = New Point(121.1765 - leftAdj, 38.82353 + 36 + pTopAdj) 'E

        'Dim lpen As New Pen(Color.Blue, 5)
        'Dim lpen2 As New Pen(Color.Black, 1)

        Dim lpen As New Pen(Color.Black, 7)
        Dim lpen2 As New Pen(Color.LightBlue, 5)
        Dim lbrush As New SolidBrush(Color.Blue)

        e.Graphics.FillPolygon(lbrush, Files3)
        e.Graphics.DrawPolygon(lpen, Files3)
        e.Graphics.DrawPolygon(lpen2, Files3)

        e.Graphics.FillPolygon(lbrush, Files2)
        e.Graphics.DrawPolygon(lpen, Files2)
        e.Graphics.DrawPolygon(lpen2, Files2)

        e.Graphics.FillPolygon(lbrush, Files1)
        e.Graphics.DrawPolygon(lpen, Files1)
        e.Graphics.DrawPolygon(lpen2, Files1)
    End Sub
    Sub Spanner(ByVal e As System.Windows.Forms.PaintEventArgs, Optional ByVal pLeftAdj As Long = 0, Optional ByVal pTopAdj As Long = 0)
        Dim lpen As New Pen(Color.Black, 7)
        Dim lpen2 As New Pen(Color.LightBlue, 5)

        e.Graphics.SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias

        Dim Spanner() As Point
        ReDim Spanner(21)

        Spanner(0) = New Point(14 + pLeftAdj, 37 + pTopAdj)
        Spanner(1) = New Point(30 + pLeftAdj, 21 + pTopAdj)
        Spanner(2) = New Point(38 + pLeftAdj, 45 + pTopAdj)
        Spanner(3) = New Point(54 + pLeftAdj, 45 + pTopAdj)
        Spanner(4) = New Point(62 + pLeftAdj, 21 + pTopAdj)
        Spanner(5) = New Point(78 + pLeftAdj, 37 + pTopAdj)
        Spanner(6) = New Point(78 + pLeftAdj, 53 + pTopAdj)
        Spanner(7) = New Point(62 + pLeftAdj, 69 + pTopAdj)
        Spanner(8) = New Point(62 + pLeftAdj, 133 + pTopAdj)
        Spanner(9) = New Point(78 + pLeftAdj, 149 + pTopAdj)
        Spanner(10) = New Point(78 + pLeftAdj, 165 + pTopAdj)
        Spanner(11) = New Point(62 + pLeftAdj, 181 + pTopAdj)
        Spanner(12) = New Point(62 + pLeftAdj, 181 + pTopAdj)
        Spanner(13) = New Point(54 + pLeftAdj, 157 + pTopAdj)
        Spanner(14) = New Point(38 + pLeftAdj, 157 + pTopAdj)
        Spanner(15) = New Point(30 + pLeftAdj, 181 + pTopAdj)
        Spanner(16) = New Point(14 + pLeftAdj, 165 + pTopAdj)
        Spanner(17) = New Point(14 + pLeftAdj, 149 + pTopAdj)
        Spanner(18) = New Point(30 + pLeftAdj, 133 + pTopAdj)
        Spanner(19) = New Point(30 + pLeftAdj, 69 + pTopAdj)
        Spanner(20) = New Point(14 + pLeftAdj, 53 + pTopAdj)
        Spanner(21) = New Point(14 + pLeftAdj, 37 + pTopAdj)

        e.Graphics.FillRectangle(Brushes.Blue, New Rectangle(5 + pLeftAdj, 5 + pTopAdj, 83, 195))
        e.Graphics.DrawRectangle(New Pen(Color.DarkBlue, 5), New Rectangle(5 + pLeftAdj, 5 + pTopAdj, 83, 195))

        e.Graphics.FillPolygon(Brushes.Blue, Spanner)
        e.Graphics.DrawPolygon(lpen, Spanner)
        e.Graphics.DrawPolygon(lpen2, Spanner)
    End Sub
    Sub Cross(ByVal e As System.Windows.Forms.PaintEventArgs, Optional ByVal pLeftAdj As Long = 0, Optional ByVal pTopAdj As Long = 0)

        Dim lpen As New Pen(Color.Black, 7)
        Dim lpen2 As New Pen(Color.LightBlue, 5)

        e.Graphics.SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias

        Dim Points() As Point
        ReDim Points(11)

        Points(0) = New Point(80, 20)
        Points(1) = New Point(80, 50)
        Points(2) = New Point(110, 50)
        Points(3) = New Point(110, 80)
        Points(4) = New Point(80, 80)
        Points(5) = New Point(80, 110)
        Points(6) = New Point(50, 110)
        Points(7) = New Point(50, 80)
        Points(8) = New Point(20, 80)
        Points(9) = New Point(20, 50)
        Points(10) = New Point(50, 50)
        Points(11) = New Point(50, 20)

        e.Graphics.FillRectangle(Brushes.Blue, New Rectangle(5 + pLeftAdj, 5 + pTopAdj, 120, 120))
        e.Graphics.DrawRectangle(New Pen(Color.DarkBlue, 5), New Rectangle(5 + pLeftAdj, 5 + pTopAdj, 120, 120))

        e.Graphics.FillPolygon(Brushes.Blue, Points)
        e.Graphics.DrawPolygon(lpen, Points)
        e.Graphics.DrawPolygon(lpen2, Points)
    End Sub
End Module
