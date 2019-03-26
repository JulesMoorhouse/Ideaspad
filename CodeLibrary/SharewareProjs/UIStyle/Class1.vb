Imports System.Drawing
Imports System.Drawing.Drawing2D


Public Module PaintingDefs
    Public gPaintClr1 As Color = Color.Empty
    Public gPaintClr2 As Color = Color.Empty
End Module

Public Class Painting
    Private clr1 As Color
    Private clr2 As Color
    
    Private Sub SetColours()

        If gPaintClr1.Equals(Color.Empty) = True Then
            clr1 = SystemColors.Control
        Else
            clr1 = gPaintClr1
        End If

        If gPaintClr2.Equals(Color.Empty) = True Then
            clr2 = SystemColors.Window
        Else
            clr2 = gPaintClr2
        End If

    End Sub
    

    'added 
    Sub PaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal pme As Object)

        If pme.Width = 0 Or pme.Height = 0 Then 
            Exit Sub
        End If

        SetColours() 

        Dim rectangle As Rectangle = New Rectangle(0, 0, pme.Width, pme.Height)
        'Dim gradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, SystemColors.ActiveCaption, SystemColors.Window, LinearGradientMode.Horizontal)
        ''Dim clr1 As Color = Color.FromArgb(185, 208, 255) '150, 178, 250) '151, 153, 171) '130, 136, 153) ' SystemColors.ActiveCaption
        ''Dim clr2 As Color = Color.FromArgb(241, 250, 255) '228, 228, 228) ' SystemColors.Window 
        Dim gradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, clr1, clr2, LinearGradientMode.Horizontal)
        pevent.Graphics.FillRectangle(gradientBrush, 0, 0, pme.Width, pme.Height)
    End Sub
    Sub PaintToolbarBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal pme As Object)

        If pme.Width = 0 Or pme.Height = 0 Then 
            Exit Sub
        End If

        SetColours() 

        Dim rectangle As Rectangle = New Rectangle(0, 0, pme.Width, pme.Height)
        'Dim gradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, SystemColors.ActiveCaption, SystemColors.Window, LinearGradientMode.Horizontal)
        ''Dim clr1 As Color = Color.FromArgb(185, 208, 255) '150, 178, 250) '151, 153, 171) '130, 136, 153) ' SystemColors.ActiveCaption
        ''Dim clr2 As Color = Color.FromArgb(241, 250, 255) '228, 228, 228) ' SystemColors.Window 
        Dim gradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, clr1, clr2, LinearGradientMode.Horizontal)


        pevent.Graphics.FillRectangle(gradientBrush, 0, 0, pme.Width, pme.Height)
    End Sub
    'Function ChopBackToFit(ByVal OrigHeight As Integer, ByVal OrigWidth As Integer, ByVal DestTop As Integer, ByVal DestLeft As Integer, ByVal DestWidth As Integer, ByVal DestHeight As Integer) As Image


    '    Dim p As System.Windows.Forms.PaintEventArgs

    '    Dim rectangle As Rectangle = New Rectangle(0, 0, OrigWidth, OrigHeight)
    '    Dim clr1 As Color = Color.FromArgb(185, 208, 255)
    '    Dim clr2 As Color = Color.FromArgb(241, 250, 255)
    '    Dim gradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, clr1, clr2, LinearGradientMode.Horizontal)

    '    'Source
    '    Dim tempBitmap As Bitmap = New Bitmap(OrigWidth, OrigHeight)
    '    Dim tempG As Graphics = Graphics.FromImage(DirectCast(tempBitmap, Image))
    '    tempG.FillRectangle(gradientBrush, 0, 0, OrigWidth, OrigHeight)

    '    'Dest
    '    Dim bm As Bitmap = New Bitmap(DestWidth, DestHeight)
    '    Dim g As Graphics = Graphics.FromImage(bm)

    '    'copy part of your original image
    '    g.DrawImage(tempBitmap, New Rectangle(0, 0, DestWidth, DestHeight), New Rectangle(DestLeft, DestTop, DestWidth, DestHeight), GraphicsUnit.Pixel)

    '    'g.DrawRectangle(New Pen(Color.Black), New Rectangle(0, 0, DestWidth - 1, DestHeight - 1))

    '    Return bm

    'End Function
    Function PaintBackgroundToFit(ByVal pevent As System.Windows.Forms.PaintEventArgs, ByVal OrigHeight As Integer, ByVal OrigWidth As Integer, ByVal DestTop As Integer, ByVal DestLeft As Integer, ByVal DestWidth As Integer, ByVal DestHeight As Integer)

        If OrigWidth = 0 Or OrigHeight = 0 Then 
            Exit Function
        End If
        'Dim p As System.Windows.Forms.PaintEventArgs

        SetColours() 

        Dim rectangle As Rectangle = New Rectangle(0, 0, OrigWidth, OrigHeight)
        ''Dim clr1 As Color = Color.FromArgb(185, 208, 255)
        ''Dim clr2 As Color = Color.FromArgb(241, 250, 255)
        Dim gradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, clr1, clr2, LinearGradientMode.Horizontal)

        'Source
        Dim tempBitmap As Bitmap = New Bitmap(DestWidth, DestHeight)
        Dim tempG As Graphics = Graphics.FromImage(DirectCast(tempBitmap, Image))
        tempG.FillRectangle(gradientBrush, 0, 0, OrigWidth, OrigHeight)

        'copy part of your original image
        pevent.Graphics.DrawImage(tempBitmap, New Rectangle(0, 0, DestWidth, DestHeight), New Rectangle(DestLeft, DestTop, DestWidth, DestHeight), GraphicsUnit.Pixel)

    End Function
    Sub PaintBackground(ByVal pevent As System.Drawing.Graphics, ByVal ClipLeft As Integer, ByVal ClipTop As Integer, ByVal ClipWidth As Integer, ByVal ClipHeight As Integer)

        If ClipWidth = 0 Or ClipHeight = 0 Then 
            Exit Sub
        End If

        SetColours() 

        'Dim p As System.Windows.Forms.PaintEventArgs

        Dim rectangle As Rectangle = New Rectangle(0, 0, ClipWidth, ClipHeight)
        ''Dim clr1 As Color = Color.FromArgb(185, 208, 255)
        ''Dim clr2 As Color = Color.FromArgb(241, 250, 255)
        Dim gradientBrush As LinearGradientBrush = New LinearGradientBrush(rectangle, clr1, clr2, LinearGradientMode.Horizontal)
        '- Clipleft required to paint menu panel!!
        pevent.FillRectangle(gradientBrush, ClipLeft, ClipTop, ClipWidth - ClipLeft, ClipHeight)
    End Sub
    Sub PaintBackgroundSection(ByVal pevent As System.Drawing.Graphics, ByVal ClipLeft As Integer, ByVal ClipTop As Integer, _
        ByVal ClipWidth As Integer, ByVal ClipHeight As Integer, ByVal Destleft As Integer, ByVal DestTop As Integer, _
        ByVal DestWidth As Integer, ByVal DestHeight As Integer)

        If ClipWidth = 0 Or ClipHeight = 0 Then 
            Exit Sub
        End If

        SetColours() 

        'Source
        Dim tempBitmap As Bitmap = New Bitmap(ClipWidth, ClipHeight)
        Dim tempG As Graphics = Graphics.FromImage(DirectCast(tempBitmap, Image))

        PaintBackground(tempG, 0, 0, ClipWidth, ClipHeight) 'Use Same function used above to paint whole panel

        'Now chop the section out that you need.
        pevent.DrawImage(tempBitmap, New Rectangle(Destleft, DestTop, DestWidth, DestHeight), New Rectangle(Destleft, 0, DestWidth, DestHeight), GraphicsUnit.Pixel)


    End Sub
    'Private Function MakeLighter(ByVal Source As Color, ByVal Amount As Integer) As Color

    '    Dim Red As Integer = Source.R : Dim Green As Integer = Source.G : Dim Blue As Integer = Source.B

    '    If Red + Amount < 255 Then Red = Source.R + Amount
    '    If Green + Amount < 255 Then Green = Source.G + Amount
    '    If Blue + Amount < 255 Then Blue = Source.B + Amount

    '    Return Color.FromArgb(Red, Green, Blue)

    'End Function
    'Public Sub New()

    '    'Dim clr1 As Color = MakeLighter(SystemColors.ActiveCaption, 110)
    '    'Dim clr2 As Color = MakeLighter(SystemColors.InactiveCaption, 110)


    '    'Dim ColorString As String = SystemColors.ActiveCaption.R & "," & _
    '    '    SystemColors.ActiveCaption.G & "," & _
    '    '    SystemColors.ActiveCaption.B & " " & _
    '    '    SystemColors.InactiveCaption.R & "," & _
    '    '    SystemColors.InactiveCaption.G & "," & _
    '    '    SystemColors.InactiveCaption.B
    '    Dim r1 As Integer : Dim b1 As Integer : Dim g1 As Integer
    '    Dim r2 As Integer : Dim b2 As Integer : Dim g2 As Integer

    '    'Dim Style As String = ""
    '    'Select Case ColorString
    '    '    'Case "128,128,0 188,188,65" : Style = "wheat"
    '    '    'Case "0,128,128 128,128,128" : Style = "teal"
    '    '    'Case "128,0,128 128,128,128" : Style = "storm"
    '    '    'Case "0,0,128 128,128,128" : Style = "standard"
    '    '    'Case "89,151,100 128,128,128" : Style = "spruse"
    '    '    'Case "85,128,151 128,128,128" : Style = "slate"
    '    '    'Case "159,96,112 160,160,164" : Style = "rose"
    '    '    'Case "128,0,0 128,128,128" : Style = "redwhiteblue"
    '    '    'Case "80,100,128 128,128,128" : Style = "rainyday"
    '    '    'Case "215,165,47 160,160,164" : Style = "pumpkin"
    '    '    'Case "72,64,96 120,96,88" : Style = "plum"
    '    '    'Case "0,0,128 75,141,132" : Style = "marine"
    '    '    'Case "128,0,0 160,160,164" : Style = "maple"
    '    '    'Case "90,78,177 128,128,128" : Style = "lilac"
    '    '    'Case "0,0,0 255,255,255" : Style = "highcontrastwhite"
    '    '    'Case "128,0,128 0,128,0" : Style = "highcontrastblack"
    '    '    'Case "0,0,255 0,255,255" : Style = "highcontrast"
    '    '    'Case "88,128,120 144,176,168" : Style = "eggplant"
    '    '    'Case "0,128,128 162,141,104" : Style = "desert"
    '    '    'Case "128,0,0 141,137,97" : Style = "brick"
    '    '    Case "192,192,192 255,255,255" : Style = "XP-Silver"
    '    '        r1 = 214 : g1 = 217 : b1 = 226
    '    '        r2 = 240 : g2 = 241 : b2 = 243
    '    '    Case "139,161,105 212,214,186" : Style = "XP-Olive"
    '    '    Case "0,84,227 122,150,223" : Style = "XP-Standard"
    '    '        r1 = 161 : g1 = 185 : b1 = 245
    '    '        r2 = 193 : g2 = 225 : b2 = 250
    '    '    Case Else
    '    r1 = SystemColors.Control.R : g1 = SystemColors.Control.G : b1 = SystemColors.Control.B
    '    r2 = SystemColors.Window.R : g2 = SystemColors.Window.G : b2 = SystemColors.Window.B
    '    'End Select

    '    clr1 = Color.FromArgb(r1, g1, b1)
    '    clr2 = Color.FromArgb(r2, g2, b2)
    '    'MessageBox.Show(Style, ColorString)

    'End Sub
End Class