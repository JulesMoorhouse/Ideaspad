'Option Strict On
Imports System.Windows.Forms
Imports System.Drawing
Imports Microsoft.VisualBasic.ControlChars

Public Module GeneralRTFUI
    Public Structure OtherFontSettings 
        Dim StrikeOut As Boolean
        Dim Underlined As Boolean
        Dim Bold As Boolean
        Dim Italic As Boolean
    End Structure

    Public Function CreateGraphic(ByVal CurrentColor As Color, ByVal WidthHeight As Integer) As Image
        'added 
        'Dim bmp As System.Drawing.Image
        Dim bmp As System.Drawing.Bitmap
        'bmp = New Bitmap(16, 16, Drawing.Imaging.PixelFormat.Format32bppArgb)
        
        bmp = New Bitmap(WidthHeight, WidthHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim TransparentColor As Color 
        bmp.MakeTransparent(TransparentColor) 

        Dim tempG As Graphics
        tempG = Graphics.FromImage(DirectCast(bmp, Image))

        tempG.SmoothingMode = Drawing.Drawing2D.SmoothingMode.HighQuality

        'tempG.FillRectangle(New SolidBrush(SystemColors.Control), New Rectangle(-1, -1, 17, 17))
        
        'tempG.FillRectangle(New SolidBrush(TransparentColor), New Rectangle(-1, -1, 17, 17))

        Dim xOff As Integer
        Dim OutlineColour As Color
        Dim FillColor As Color
        

        Dim Fac As Integer = 1
        Select Case WidthHeight
            Case 16
                OutlineColour = Color.Gray
                FillColor = Color.White
                xOff = 4
                Fac = 1
                tempG.FillRectangle(New SolidBrush(TransparentColor), New Rectangle(-1, -1, 17, 17))
                tempG.SmoothingMode = Drawing.Drawing2D.SmoothingMode.HighSpeed
            Case 24
                OutlineColour = Color.FromArgb(12, 103, 114) '88, 150, 252)
                FillColor = Color.FromArgb(176, 207, 255)
                xOff = 6
                Fac = 1.5
                tempG.FillRectangle(New SolidBrush(TransparentColor), New Rectangle(0, 0, WidthHeight, WidthHeight))
        End Select
        

        If IsAboveOrEqualWinXp() = False Then 
            OutlineColour = Color.Gray
            FillColor = Color.White
            tempG.SmoothingMode = Drawing.Drawing2D.SmoothingMode.HighSpeed
        End If

        'Dim BlackPen As New Pen(Color.Black, 1)
        'x'Dim BlackPen As New Pen(Color.DarkGray, 1) 
        'Dim BlackPen As New Pen(Color.Gray, 1) 
        Dim BlackPen As New Pen(OutlineColour, 1) 

        Dim HiPen() As Point
        ReDim HiPen(6)
        'Const xOff = 4
        HiPen(0) = New Point(xOff + (3 * Fac), (9 * Fac))
        HiPen(1) = New Point(xOff + (1 * Fac), (7 * Fac))
        'HiPen(2) = New Point(xOff + (6 * Fac), (1 * Fac))
        HiPen(2) = New Point(xOff + (5 * Fac), (2 * Fac))
        'HiPen(3) = New Point(xOff + (8 * Fac), (3 * Fac))
        HiPen(3) = New Point(xOff + (7 * Fac), (4 * Fac))
        HiPen(4) = New Point(xOff + (3 * Fac), (9 * Fac))
        HiPen(5) = New Point(xOff + (0 * Fac), (9 * Fac))
        HiPen(6) = New Point(xOff + (1 * Fac), (7 * Fac))

        'tempG.SmoothingMode = Drawing.Drawing2D.SmoothingMode.HighSpeed 
        'x'tempG.FillPolygon(New SolidBrush(Color.LightGray), HiPen, Drawing.Drawing2D.FillMode.Winding) 
        'tempG.FillPolygon(New SolidBrush(Color.White), HiPen, Drawing.Drawing2D.FillMode.Winding) 

        tempG.FillPolygon(New SolidBrush(FillColor), HiPen, Drawing.Drawing2D.FillMode.Winding) 

        tempG.DrawLines(BlackPen, HiPen)

        tempG.SmoothingMode = Drawing.Drawing2D.SmoothingMode.HighSpeed
        Select Case WidthHeight
            Case 16
                tempG.FillRectangle(New SolidBrush(CurrentColor), New Rectangle(-1, 11, 15, 15))
                tempG.DrawRectangle(New Pen(Color.LightGray), New Rectangle(-1, 11, 15, 15))
            Case 24
                tempG.FillRectangle(New SolidBrush(CurrentColor), New Rectangle(0, 20, 24, 24))
                tempG.DrawRectangle(New Pen(Color.LightGray), New Rectangle(0, 20, 24, 24))
        End Select

        Return bmp

    End Function
    Public Function IncreaseIndent(ByRef rtb As RichTextBox)
        'added 
        Dim SelText As String = rtb.SelectedRtf

        If SelText.Length > 0 Then

            Dim lintSelStart As Integer = rtb.SelectionStart
            Dim lintSelLength As Integer = rtb.SelectionLength

            Dim myDelim As String = "\par"

            SelText = SelText.Replace("\pard\tab", "#9#*#+#")

            Dim lines() As String = Microsoft.VisualBasic.Strings.Split(SelText, myDelim)

            Dim lintArrInc As Integer
            Dim newText As String

            For lintArrInc = 0 To lines.GetUpperBound(0)
                lines(lintArrInc) = lines(lintArrInc).Replace(CrLf, "")

                If lintArrInc = 0 Then
                    newText &= lines(lintArrInc) & "\tab " & "\par"
                ElseIf lintArrInc = 1 Then
                    newText &= lines(lintArrInc) & myDelim & CrLf
                Else
                    newText &= "\tab " & lines(lintArrInc) & myDelim & CrLf
                End If
            Next

            newText = newText.Replace("#9#*#+#", "\pard\tab")

            rtb.SelectedRtf = newText

            rtb.SelectionStart = lintSelStart
            rtb.SelectionLength = lintSelLength + lines.GetUpperBound(0)
        End If


    End Function
    Public Function DecreaseIndent(ByRef rtb As RichTextBox)
        'added 
        Dim SelText As String = rtb.SelectedRtf

        If SelText.Length > 0 Then

            Dim lintSelStart As Integer = rtb.SelectionStart
            Dim lintSelLength As Integer = rtb.SelectionLength

            Dim myDelim As String = CrLf

            Dim lines() As String = Microsoft.VisualBasic.Strings.Split(SelText, myDelim)

            Dim lintArrInc As Integer
            Dim newText As String

            For lintArrInc = 0 To lines.GetUpperBound(0)

                Dim FirstTabPos As Integer = InStrGet(lines(lintArrInc), "\tab")
                Dim ThisLine As String
                If FirstTabPos > 0 Then
                    ThisLine = ReplaceFirst(lines(lintArrInc), "\tab")
                    newText &= ThisLine & myDelim
                Else
                    newText &= lines(lintArrInc) & myDelim
                End If

            Next lintArrInc

            rtb.SelectedRtf = newText

            rtb.SelectionStart = lintSelStart
            rtb.SelectionLength = lintSelLength + lines.GetUpperBound(0)

        End If

    End Function
    Public Enum CaseType 'added 
        Upper
        Lower
        Proper
        Toggle
    End Enum
    Public Sub CaseChange(ByVal rtb As RichTextBox, ByVal ct As CaseType, ByVal WorkingRtb As RichTextBox)
        'added 
        Dim lintSelStart As Integer = rtb.SelectionStart
        Dim lintSelLength As Integer = rtb.SelectionLength
        Dim lintArrInc As Integer

        If lintSelLength = 0 Then Exit Sub 

        WorkingRtb.Rtf = rtb.SelectedRtf
        WorkingRtb.SelectAll()

        If ct = CaseType.Proper Then
            Dim Propered As String = ProperCase(WorkingRtb.SelectedText)
            For lintArrInc = 0 To Propered.Length
                'WorkingRtb.Select(lintSelStart + lintArrInc, 1)
                'Your working only on a copy of the selected text not the whole rtf string
                WorkingRtb.Select(lintArrInc, 1)
                WorkingRtb.SelectedText = MidGet(Propered, lintArrInc + 1, 1)
            Next lintArrInc
        Else

            For lintArrInc = 0 To lintSelLength
                'WorkingRtb.Select(lintSelStart + lintArrInc, 1)
                'Your working only on a copy of the selected text not the whole rtf string
                WorkingRtb.Select(lintArrInc, 1)
                Select Case ct
                    Case CaseType.Upper
                        WorkingRtb.SelectedText = WorkingRtb.SelectedText.ToUpper
                    Case CaseType.Lower
                        WorkingRtb.SelectedText = WorkingRtb.SelectedText.ToLower
                    Case CaseType.Toggle
                        'If Char.IsUpper(rtb.SelectedText) Then
                        If Char.IsUpper(WorkingRtb.SelectedText) Then 
                            WorkingRtb.SelectedText = WorkingRtb.SelectedText.ToLower
                        Else
                            WorkingRtb.SelectedText = WorkingRtb.SelectedText.ToUpper
                        End If
                End Select

            Next lintArrInc
        End If

        WorkingRtb.Select(0, lintSelLength) 

        'rtb.SelectedRtf = WorkingRtb.Rtf
        rtb.SelectedRtf = WorkingRtb.SelectedRtf 

        rtb.SelectionStart = lintSelStart
        rtb.SelectionLength = lintSelLength

    End Sub
    Public Sub LoadFileToRtb(ByVal FileType As RichTextBoxStreamType, ByVal Rtb As RichTextBox, _
        ByVal Caption As String, ByVal Status As StatusBar, ByVal TreeViewPath As String, ByVal pbooTopMost As Boolean, ByVal pme As Form)

        Dim StandLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))

        Dim LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("RTFStand.RTFStand", _
            System.Reflection.Assembly.GetExecutingAssembly())

        Dim lResult As DialogResult

        Dim OpenFile As New OpenFileDialog()
        With OpenFile
            '.Title = LangText.GetString("LoadFileToRtb_ImpRTFCaption")'commented out 
            .CheckPathExists = True
            '.DefaultExt = "rtf"
            Select Case FileType
                Case RichTextBoxStreamType.RichText
                    .DefaultExt = "rtf"
                    .Filter = StandLangText.GetString("StandText_RTFFilter")
                Case RichTextBoxStreamType.PlainText
                    .DefaultExt = "txt"
                    .Filter = StandLangText.GetString("StandText_TXTFilter")
            End Select

            .RestoreDirectory = True 

            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If


            Dim FileStr As New System.IO.FileInfo(.FileName)
            Dim lintFileLengthKB = (FileStr.Length / 1000)
            If lintFileLengthKB > 1024 Then

                lResult = MessageBox.Show(LangText.GetString("LoadFileToRtb_ImpRTFLarge"), Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If lResult <> DialogResult.Yes Then
                    Exit Sub
                End If
            End If

            lResult = DialogResult.Yes 

            If Microsoft.VisualBasic.Len(Rtb.Text) <> 0 Then 
                If pbooTopMost = True Then pme.Activate() 
                lResult = MessageBox.Show(LangText.GetString("LoadFileToRtb_ImpRTFOverwrite"), Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If 

            If lResult = DialogResult.Yes Then
                Status.Panels(0).Text = LangText.GetString("LoadFileToRtb_ImpRTFPleaseWait")

                Try
                    'BusyPad(pme, True)
                    Rtb.LoadFile(.FileName, FileType)
                    'BusyPad(pme, False)
                    Status.Panels(0).Text = LangText.GetString("LoadFileToRtb_Viewing") & " - " & TreeViewPath 'pme.TreeView1.SelectedNode.FullPath

                Catch ex As Exception
                    'BusyPad(pme, False)
                    If pbooTopMost = True Then pme.Activate() 
                    MessageBox.Show(ex.Message, Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Status.Panels(0).Text = ""
                End Try
            End If
        End With
    End Sub
End Module
