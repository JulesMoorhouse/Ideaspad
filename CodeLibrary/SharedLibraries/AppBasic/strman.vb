Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Globalization
Public Module strman
    Enum DateInterval
        Day = 4
        Hour = 7
        Month = 2
        Second = 9
        Minute = 8
    End Enum
    Enum DateFormat
        GeneralDate = 0
        LongDate = 1
        ShortDate = 2
        LongTime = 3
        ShortTime = 4
    End Enum
    Function RightGet(ByVal pstrString As String, ByVal plngPos As Long) As String

        'RightGet = pstrString.Substring(plngPos)
        'MxessageBox.Show(MyString.Substring(MyString.Length - n, n), Microsoft.VisuxalBasic.Right(MyString, 5))
        RightGet = pstrString.Substring(pstrString.Length - plngPos, plngPos)

        If RightGet <> Microsoft.VisualBasic.Right(pstrString, plngPos) Then
            MessageBox.Show("RIGHTGET - Inaccurate!")
        End If
    End Function
    Function LeftGet(ByVal pstrString As String, ByVal plngPos As Long) As String

        LeftGet = pstrString.Substring(0, plngPos)

        If LeftGet <> Microsoft.VisualBasic.Left(pstrString, plngPos) Then
            MessageBox.Show("LeftGet - Inaccurate!")
        End If
    End Function
    Function MidGet(ByVal Target As String, ByVal Start As Integer, Optional ByVal Length As Integer = 0) As String

        If Length = 0 Then Length = Target.Length - (Start - 1)

        If Start - 1 + Length > Target.Length Then
            Length = Target.Length - (Start - 1)
        End If

        MidGet = Target.Substring(Start - 1, Length)

        If MidGet <> Microsoft.VisualBasic.Mid(Target, Start, Length) Then
            MessageBox.Show("MidGet - Inaccurate!")
        End If
    End Function
    Function InStrGet(ByVal String1 As String, ByVal String2 As String) As Long

        InStrGet = String1.IndexOf(String2) + 1

        If InStrGet <> Microsoft.VisualBasic.InStr(String1, String2) Then
            MessageBox.Show("InStrGet1 - Inaccurate!")
        End If
    End Function
    Function InStrGet(ByVal Start As Integer, ByVal String1 As String, ByVal String2 As String) As Long

        InStrGet = String1.IndexOf(String2, Start - 1) + 1


        If InStrGet <> Microsoft.VisualBasic.InStr(Start, String1, String2) Then
            MessageBox.Show("InStrGet2 - Inaccurate! ='" & InStrGet & "' org='" & Microsoft.VisualBasic.InStr(Start, String1, String2) & "'")
        End If
    End Function
    Function InStrAfGet(ByVal Start As Integer, ByVal String1 As String, ByVal String2 As String) As Long

        InStrAfGet = String1.IndexOf(String2, Start - 1) + 1

        If InStrAfGet > 0 Then
            InStrAfGet = InStrAfGet + String2.Length
        End If

    End Function
    Function Tab() As String
        Tab = Convert.ToChar(9)
    End Function
    Function CR() As String
        CR = Convert.ToChar(13)
    End Function
    Function DateDiffGet(ByVal Interval As DateInterval, ByVal Date1 As Date, ByVal Date2 As Date) As Long

        Select Case Interval
            Case DateInterval.Day
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Day, Date1, Date2)
            Case DateInterval.Hour
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Hour, Date1, Date2)
            Case DateInterval.Minute
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Minute, Date1, Date2)
            Case DateInterval.Second
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Second, Date1, Date2)
            Case Else
                MessageBox.Show("DateDiffGet 1 Invalid Date Param")
        End Select
        Exit Function

        Dim ts As TimeSpan

        ts = Date2.Subtract(Date1)
        Select Case Interval
            Case DateInterval.Day
                DateDiffGet = ts.Days
            Case DateInterval.Hour
                DateDiffGet = ts.Hours
            Case DateInterval.Minute 
                DateDiffGet = ts.Minutes
            Case DateInterval.Second
                DateDiffGet = ts.Seconds
            Case Else
                MessageBox.Show("DateDiffGet 1 Invalid Date Param")
        End Select

    End Function
    Function DateDiffGet(ByVal Interval As String, ByVal Date1 As Object, ByVal Date2 As Object) As Long


        Select Case Interval.ToUpper
            Case "D"
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Day, Date1, Date2)
            Case "H"
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Hour, Date1, Date2)
            Case "N"
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Minute, Date1, Date2)
            Case "S"
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Second, Date1, Date2)
            Case Else
                MessageBox.Show("DateDiffGet 1 Invalid Date Param")
        End Select
        Exit Function

        Dim ts As TimeSpan

        ts = Date2.Subtract(Date1)
        Select Case Interval.ToUpper
            Case "D"
                DateDiffGet = ts.Days
            Case "H"
                DateDiffGet = ts.Hours
            Case "M"
                DateDiffGet = ts.Minutes
            Case "S"
                DateDiffGet = ts.Seconds
            Case Else
                MessageBox.Show("DateDiffGet 2 Invalid Date Param")
        End Select

    End Function
    Function AscGet(ByVal pstrChar As Char) As Integer
        Dim b As Byte() = System.Text.Encoding.Default.GetBytes(New [Char]() {pstrChar})
        AscGet = b(0).ToString()

        If AscGet <> Microsoft.VisualBasic.Asc(pstrChar) Then
            MessageBox.Show("AscGet - Inaccurate! AscGet='" & AscGet & "' and VB.Asc='" & Microsoft.VisualBasic.Asc(pstrChar) & "'")
        End If
    End Function
    Function FormatDateTime(ByVal Expression As Date, ByVal NamedFormat As DateFormat) As String

        Select Case NamedFormat
            Case DateFormat.GeneralDate
                FormatDateTime = Expression.ToString("G")
            Case DateFormat.LongDate
                FormatDateTime = Expression.ToString("D")
            Case DateFormat.LongTime
                FormatDateTime = Expression.ToString("T")
            Case DateFormat.ShortDate
                FormatDateTime = Expression.ToString("d")
            Case DateFormat.ShortTime
                FormatDateTime = Expression.ToString("t")
            Case Else
                MessageBox.Show("FormatDateTime Error")
        End Select

        'd Short Date 
        'D Long Date 
        'f Full (long date + short time) 
        'F Full (long date + long time) 
        'g General (short date + short time) 
        'G General (short date + long time) 
        'm, M Month/Day Date 
        'r, R RFC Standard 
        's Sortable without TimeZone info 
        't Short Time 
        'T Long Time 
        'u Universal with sort able format 
        'U Universal with Full (long date + long time) format 
        'y, Y Year/Month Date 

    End Function
    Function MonthName(ByVal Month As Integer, ByVal Abbreviated As Boolean) As String

        Dim dtfi As System.Globalization.DateTimeFormatInfo
        dtfi = CType(System.Globalization.DateTimeFormatInfo.CurrentInfo.Clone, System.Globalization.DateTimeFormatInfo)
        MonthName = dtfi.GetMonthName(Month).ToString()
        If Abbreviated = True Then
            MonthName = LeftGet(MonthName, 3)
        End If
    End Function
    Function HexGet(ByVal Number As Int32) As String
        Dim RetVal As String
        Dim RetInt As Int32

        RetInt = Number
        RetVal = RetInt.ToString("X4")
        Do Until LeftGet(RetVal, 1) <> "0"
            If LeftGet(RetVal, 1) = "0" Then
                RetVal = RightGet(RetVal, RetVal.Length - 1)
            End If
        Loop

        HexGet = RetVal
        If HexGet <> Microsoft.VisualBasic.Hex(Number) Then
            MessageBox.Show("HexGet - Inaccurate!")
        End If
    End Function
    Function IsNumericGet(ByVal pstrNumber As String) As Boolean
        Dim d As Double

        IsNumericGet = System.Double.TryParse(pstrNumber, Globalization.NumberStyles.Number, Nothing, d)
        If IsNumericGet <> Microsoft.VisualBasic.IsNumeric(pstrNumber) Then
            MessageBox.Show("IsNumericGet - Inaccurate!")
        End If
    End Function
    Function IsDateGet(ByVal Expression As Object) As Boolean

        Try
            Dim dt As Date = Date.Parse(Expression)
            IsDateGet = True
        Catch ex As Exception
            IsDateGet = False
        End Try
        If IsDateGet <> Microsoft.VisualBasic.IsDate(Expression) Then
            MessageBox.Show("IsDate - Inaccurate!")
        End If
    End Function
    Function DateSerialGet(ByVal Year As Integer, ByVal Month As Integer, ByVal Day As Integer) As Date

        DateSerialGet = CDate(Day & "/" & Month & "/" & Year).ToString("dd/MM/yyyy")
        If DateSerialGet <> Microsoft.VisualBasic.DateSerial(Year, Month, Day) Then
            MessageBox.Show("DateSerialGet - Inaccurate!")
        End If
    End Function
    Function ChrGet(ByVal CharCode As Integer) As Char
        Dim chDEC(0) As Char
        Dim bControlChars As Byte() = {CharCode}   '**char number in ASCII table for CARRIAGE RETURN
        Dim dec As System.Text.Decoder = System.Text.Encoding.Default.GetDecoder()
        dec.GetChars(bControlChars, 0, bControlChars.Length, chDEC, 0)
        ChrGet = chDEC(0)
    End Function
    Function FormatNumberGet(ByVal pintNumber As Long, ByVal pstrFormat As String) As String

        FormatNumberGet = pintNumber.ToString.Format("{0:" & pstrFormat & "}", pintNumber)
    End Function
    Function ReturnNthStr(ByVal pstrString As String, ByVal pintPosition As Integer, ByVal pstrChar As String) As String
        Dim lintArrInc As Integer
        Dim llngPos As Long
        Dim llngLastPos As Long
        Dim lintErrPos As Integer

        lintErrPos = 0
        'On Error GoTo EndFunc
        Try
            lintErrPos = 1
            Do Until lintArrInc = pintPosition
                lintErrPos = 2
                lintArrInc = lintArrInc + 1
                lintErrPos = 3
                'llngPos = InxStr(llngLastPos + 1, pstrString, pstrChar)
                llngPos = InStrGet(llngLastPos + 1, pstrString, pstrChar) ', CompareMethod.Text)
                lintErrPos = 4
                ReturnNthStr = MidGet(pstrString, llngLastPos + 1, (llngPos - llngLastPos) - 1)
                lintErrPos = 5
                llngLastPos = llngPos
                lintErrPos = 6
            Loop
            lintErrPos = 7
        Catch ex As Exception

            ReturnNthStr = ""
        End Try

        'EndFunc:
        'Select Case Err.Number
        '    Case 5
        '        If lintErrPos = 4 Then
        'ReturnNthStr = ""
        'Exit Function
        '        End If
        '        'Case Else
        '        '    MsgxBox Err.Number & " " & Err.Description
        'End Select
        'Exit Function
    End Function
    Function Occurences(ByVal strSearchString As String, ByVal strSearchFor As String) As Integer
        Dim r As New Regex(strSearchFor)
        Dim m As MatchCollection = r.Matches(strSearchString)

        Occurences = m.Count.ToString
    End Function
    Sub Sleep(ByVal Seconds As Long)
        Dim Start As DateTime = Date.Now

        While Not DateDiffGet(DateInterval.Second, Start, Date.Now) >= Seconds
            ' do nothing 
        End While

    End Sub
    Function ColorToString(ByVal c As Color) As String

        Dim s As String
        s = c.ToString
        Dim strings() As String
        strings = s.Split(New Char() {"[", "]"})
        s = strings(1)
        strings = s.Split(New Char() {Microsoft.VisualBasic.ChrW(61), Microsoft.VisualBasic.ChrW(44)})
        If (strings.GetLength(0) > 7) Then
            s = ((((((strings(1) + ",") _
                       + strings(3)) _
                       + ",") _
                       + strings(5)) _
                       + ",") _
                       + strings(7))
        End If
        Return s

    End Function
    Public Function StringToColor(ByVal s As String) As Color

        Return CType(System.ComponentModel.TypeDescriptor.GetConverter(GetType(Color)).ConvertFromString(s), Color)

    End Function

    Function ReplaceStr(ByVal TextIn As String, ByVal SearchStr As String, ByVal Replacement As String)
        Dim WorkText As String, Pointer As Integer

        If TextIn Is Nothing Or TextIn = "" Then
            ReplaceStr = ""
        Else
            WorkText = TextIn
            Pointer = InStrGet(1, WorkText, SearchStr)
            Do While Pointer > 0
                WorkText = LeftGet(WorkText, Pointer - 1) & Replacement & _
                    MidGet(WorkText, Pointer + SearchStr.Length)
                Pointer = InStrGet(Pointer + Replacement.Length, WorkText, _
                    SearchStr)
            Loop
            ReplaceStr = WorkText
        End If

    End Function
    Sub CreateURLShortCut(ByVal pstrFolderName As String, ByVal pstrShortCutName As String, ByVal pstrType As String, ByVal pstrCommLine As String)
        Dim lstrShortCutStr As String
        Dim lstrShortCutFile As String

        Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) & _
            "\Programs\" & pstrFolderName)

        lstrShortCutFile = System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) & _
            "\Programs\" & pstrFolderName & "\" & pstrShortCutName

        Select Case pstrType
            Case "URLSMenu"
                lstrShortCutStr = "[InternetShortcut]" & Environment.NewLine
                lstrShortCutStr += "URL=" & pstrCommLine & Environment.NewLine
                lstrShortCutStr += "Modified=6078FF339AE5C2014C"
            Case "QUICKLAUNCH"
        End Select

        Dim SaveFile As FileStream = New FileStream(lstrShortCutFile, FileMode.Create)
        Dim StreamWriter As StreamWriter = New StreamWriter(SaveFile)
        StreamWriter.Write(lstrShortCutStr)
        StreamWriter.Close()
    End Sub
    Sub CopyStartMenuLnkToQuickLaunch(ByVal pstrStartMenuFolder As String, ByVal pstrShortCutName As String)

        Dim lbooQuickLaunchCreated As Boolean = False

        Try
            Dim lstrFrom As String = System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) & _
                "\Programs\" & pstrStartMenuFolder & "\" & pstrShortCutName
            Dim lstrTo As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & _
                "\Microsoft\Internet Explorer\Quick Launch\" & pstrShortCutName
            File.Copy(lstrFrom, lstrTo, True)
            If File.Exists(lstrTo) Then
                lbooQuickLaunchCreated = True
            End If
            'MxessageBox.Show("Try 1 = " & lbooQuickLaunchCreated & Environment.NewLine & lstrFrom & Environment.NewLine & lstrTo)

        Catch ex As System.IO.FileNotFoundException
            If lbooQuickLaunchCreated = False Then
                Try
                    Dim lstrFrom As String = System.Environment.GetEnvironmentVariable("ALLUSERSPROFILE") & _
                        "\Start Menu\Programs\" & pstrStartMenuFolder & "\" & pstrShortCutName
                    Dim lstrTo As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & _
                        "\Microsoft\Internet Explorer\Quick Launch\" & pstrShortCutName
                    File.Copy(lstrfrom, lstrTo, True)
                    If File.Exists(lstrTo) Then
                        lbooQuickLaunchCreated = True
                    End If
                    'MxessageBox.Show("Try 2 = " & lbooQuickLaunchCreated & Environment.NewLine & lstrFrom & Environment.NewLine & lstrTo)

                Catch exc As Exception
                    '
                End Try
            End If
        End Try
        If System.Environment.OSVersion.Platform = PlatformID.Win32Windows And lbooQuickLaunchCreated = False Then
            Dim lstrW98QuickLaunchDir As String
            lstrW98QuickLaunchDir = "C:\Windows\Application Data\Microsoft\Internet Explorer\Quick Launch"
            Try
                If Directory.Exists(lstrW98QuickLaunchDir) Then
                    File.Copy(System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) & _
                        "\Programs\" & pstrStartMenuFolder & "\" & pstrShortCutName, _
                        lstrW98QuickLaunchDir & "\" & pstrShortCutName, True)
                    lbooQuickLaunchCreated = True
                End If
            Catch exce As Exception
                '
            End Try
        End If
    End Sub
    Function Space(ByVal pintAmount As Integer) As String
        Space = New String(" "c, pintAmount)
    End Function
    Function TrimGet(ByVal pstrString As String) As String
        TrimGet = Microsoft.VisualBasic.Trim(pstrString)
    End Function
    Function HoursFromMins(ByVal pintMins As Integer) As String
        Dim lintRemainder As Integer
        Dim lintFullHours As Integer
        Dim zero As String

        lintRemainder = pintMins Mod 60
        If CStr(lintRemainder).Length = 1 Then zero = "0"

        HoursFromMins = (pintMins - lintRemainder) / 60 & ":" & zero & lintRemainder

    End Function
    Function SQLFixup(ByVal pstrTextIn As String) As String

        SQLFixup = ReplaceStr(pstrTextIn, "'", "''")

    End Function
    Function JetSQLFixup(ByVal pstrTextIn As String) As String
        Dim lstrTemp As String

        lstrTemp = ReplaceStr(pstrTextIn, "'", "''")
        'JetSQLFixup = ReplaceStr(lstrTemp, "|", "' & chr(124) & '")
        
        JetSQLFixup = ReplaceStr(lstrTemp, "|", ChrGet(124))

    End Function
    Function UnJetSQLFixup(ByVal pstrTextIn As String) As String
        'created
        Dim lstrTemp As String

        lstrTemp = ReplaceStr(pstrTextIn, "''", "'")
        UnJetSQLFixup = ReplaceStr(lstrTemp, ChrGet(124), "|")

    End Function
    Function ContainsDigits(ByVal pstrWord As String) As Boolean

        Dim regEx As System.Text.RegularExpressions.Regex = New _
            System.Text.RegularExpressions.Regex("[^0123456789\.]", System.Text.RegularExpressions.RegexOptions.IgnoreCase)

        If regEx.Replace(pstrWord, "") = "" Then
            ContainsDigits = False
        Else
            ContainsDigits = True
        End If

    End Function
    Function Reverse(ByVal pstrString As String) As String
        Dim lintArrInc As Integer

        For lintArrInc = 0 To pstrString.Length - 1
            Reverse = Reverse & RightGet(pstrString, 1)
            pstrString = LeftGet(pstrString, pstrString.Length - 1)
        Next lintArrInc

    End Function
    Function ReturnFileHistoryItem(ByVal pstrFilePath As String, ByVal pintLength As Integer) As String

        Dim RevPath = Reverse(pstrFilePath)
        Dim FileName As String = Reverse(Microsoft.VisualBasic.Left(RevPath, InStrGet(RevPath, "\") - 1))
        Dim DriveStr As String = Microsoft.VisualBasic.Left(pstrFilePath, InStrGet(pstrFilePath, "\")) & "..."
        Dim DriveNDirStr As String = Microsoft.VisualBasic.Left(pstrFilePath, InStrGet(InStrGet(pstrFilePath, "\") + 1, pstrFilePath, "\")) & "..."
        Dim DriveN2DirStr As String = Microsoft.VisualBasic.Left(pstrFilePath, InStrGet(InStrGet(InStrGet(pstrFilePath, "\") + 1, pstrFilePath, "\") + 1, pstrFilePath, "\")) & "..."

        If (DriveN2DirStr & "\" & FileName).Length < pintLength Then
            ReturnFileHistoryItem = DriveN2DirStr & "\" & FileName
        ElseIf (DriveNDirStr & "\" & FileName).Length < pintLength Then
            ReturnFileHistoryItem = DriveNDirStr & "\" & FileName
        ElseIf (DriveStr & "\" & FileName).Length < pintLength Then
            ReturnFileHistoryItem = DriveStr & "\" & FileName
        Else
            ReturnFileHistoryItem = Microsoft.VisualBasic.Left(DriveStr & "\" & FileName, pintLength) & "..."
        End If

    End Function
    Public Function Val(ByVal PossibleNumber As String) As Double
        'Private Shared valMatcher As New Regex("(^\d+\.?\d*)", RegexOptions.Compiled)
        Dim valMatcher As New Regex("(^\d+\.?\d*)", RegexOptions.Compiled)
        SyncLock valMatcher
            Dim m As Match = valMatcher.Match(PossibleNumber)
            If m.Success Then
                Return [Double].Parse(m.Groups(0).ToString(), NumberFormatInfo.InvariantInfo)
            Else
                Return 0
            End If
        End SyncLock
    End Function 'Val
    Function MonthNameUK(ByVal Month As Integer, Optional ByVal Abbreviate As Boolean = False) As String
        Dim lstrMonth As String
        Select Case Month
            Case 1
                lstrMonth = "January"
            Case 2
                lstrMonth = "February"
            Case 3
                lstrMonth = "March"
            Case 4
                lstrMonth = "April"
            Case 5
                lstrMonth = "May"
            Case 6
                lstrMonth = "June"
            Case 7
                lstrMonth = "July"
            Case 8
                lstrMonth = "August"
            Case 9
                lstrMonth = "September"
            Case 10
                lstrMonth = "October"
            Case 11
                lstrMonth = "November"
            Case 12
                lstrMonth = "December"
        End Select

        If Abbreviate = True Then
            Return LeftGet(lstrMonth, 3)
        Else
            Return lstrMonth
        End If
    End Function
    Function ProperCase(ByVal pstrText As String) As String

        Return Microsoft.VisualBasic.StrConv(pstrText, Microsoft.VisualBasic.VbStrConv.ProperCase) 
        Exit Function 

        Dim lintIndex As Integer
        Dim lstrPrevious As String '* 1
        Dim lstrCurrent As String '* 1
        Dim lblnUpshift As Boolean
        Dim lstrOriginal As String

        'J'
        'pstrText = CA(pstrText)
        'if in uppercase should just leave, so initials and acronyms ok
        lstrOriginal = pstrText.ToLower.Trim
        'lstrOriginal = Trim$(pstrText)

        lstrPrevious = " "
        For lintIndex = 1 To lstrOriginal.Length
            lblnUpshift = False
            '    If Right$(lstrPrevious, 1) = " " Or _
            '       Right$(lstrPrevious, 1) = "." Or _
            '       Right$(lstrPrevious, 1) = "-" Then
            '        lblnUpshift = True
            '    End If
            'changed so upshifts any letter after a non-letter
            'caters for ()/&, etc.
            Dim ThisCharU As String = Microsoft.VisualBasic.Right$(lstrPrevious.ToUpper, 1)
            If ThisCharU < "A" Or ThisCharU > "Z" Then
                lblnUpshift = True

                
                If ThisCharU = ChrGet(196) Or ThisCharU = ChrGet(214) Or ThisCharU = ChrGet(220) Then
                    lblnUpshift = False
                End If
                

            End If
            If Microsoft.VisualBasic.Right$(lstrPrevious, 1) = "'" Then
                If lintIndex + 1 < lstrOriginal.Length Then
                    If (MidGet(lstrOriginal, lintIndex + 1, 1)).ToUpper >= "A" And _
                       (MidGet(lstrOriginal, lintIndex + 1, 1)).ToUpper <= "Z" Then
                        lblnUpshift = True
                    Else
                        lblnUpshift = False
                    End If
                End If
            End If
            If lintIndex > 2 And lblnUpshift = False Then
                If (MidGet(lstrOriginal, lintIndex - 2, 2)).ToUpper = "MC" Then
                    If lintIndex > 3 Then
                        If (MidGet(lstrOriginal, lintIndex - 3, 1)).ToUpper = " " Then
                            lblnUpshift = True
                        End If
                    Else
                        lblnUpshift = True
                    End If
                End If
            End If
            lstrCurrent = MidGet(lstrOriginal, lintIndex, 1)
            If lblnUpshift Then
                Mid$(lstrOriginal, lintIndex, 1) = lstrCurrent.ToUpper
            End If
            lstrPrevious = lstrCurrent
        Next

        ProperCase = lstrOriginal

    End Function
    Function RoundUP(ByVal pintNumber As Double) As Integer
        Dim Remainder As Double

        Remainder = pintNumber Mod 1

        RoundUP = pintNumber
        If Remainder > 0 Then
            RoundUP += 1
        End If

    End Function
    Function StrToHex(ByVal strString As String) As String
        'added 

        'Dim char1() As Char = strString.ToCharArray
        'Dim sresult As String

        'Dim lintArrInc As Integer
        'For lintArrInc = 0 To strString.Length - 1
        '    sresult &= Convert.ToInt32(char1(lintArrInc)).ToString("x")
        'Next lintArrInc

        'Return sresult


        
        Dim charArray() As Char = strString.ToCharArray()

        Dim output As String = ""

        Dim builder As System.Text.StringBuilder = New System.Text.StringBuilder()

        Dim i As Integer
        For i = 0 To charArray.Length - 1 Step i + 1
            Dim num As Integer = Convert.ToInt32(charArray(i))
            Dim hex As String = num.ToString("x")
            builder.Append(hex)
        Next

        Return builder.ToString()


    End Function
    Function HexToStr(ByVal strHex As String) As String
        'added 

        Dim i As Integer
        Dim sb As New System.Text.StringBuilder(strHex.Length \ 2)
        For i = 0 To strHex.Length - 2 Step 2
            sb.Append(Microsoft.VisualBasic.Chr(Convert.ToByte(strHex.Substring(i, 2), 16)))
        Next

        Return sb.ToString

    End Function
    Function threedigs(ByVal str As String) As String
        'added 
        If str.Length = 1 Then
            Return "00" & str
        ElseIf str.Length = 2 Then
            Return "0" & str
        Else
            Return str
        End If

    End Function
    Function ReplaceFirst(ByVal whole As String, ByVal replacement As String) As String
        'added 
        Dim index As Integer = whole.IndexOf(replacement)

        If (index = -1) Then
            Return whole
        Else
            Return whole.Substring(0, index) & RightGet(whole, whole.Length - (index + replacement.Length))
        End If

    End Function
    Sub ObjPositing(ByRef pPosArr() As Point, ByVal pDownInc As Integer, _
    ByVal pLeftInc As Integer, ByVal pMaxRows As Integer, ByRef pGreatHigh As Integer)
        'this sub will produce a postion array for objects (e.g. buttons) so that they can be placed easily
        pMaxRows -= 1

        Dim lintArrInc As Integer
        Dim lintArrInc2 As Integer
        Dim TempTop As Integer = 0
        Dim TempLeft As Integer = 0
        TempTop -= pDownInc

        pPosArr(0).X = TempLeft
        pPosArr(0).Y = TempTop
        Dim lintPosInc As Integer = 0

        For lintArrInc = 0 To pPosArr.GetUpperBound(0)
            For lintArrInc2 = 0 To pMaxRows
                TempTop += pDownInc
                pPosArr(lintPosInc).X = TempLeft
                pPosArr(lintPosInc).Y = TempTop
                If pGreatHigh <= TempTop Then
                    pGreatHigh = TempTop
                End If
                lintPosInc += 1
                If lintPosInc = pPosArr.GetUpperBound(0) + 1 Then
                    pGreatHigh += pDownInc
                    Exit Sub
                End If
            Next lintArrInc2
            TempLeft += pLeftInc
            TempTop = 0
            TempTop -= pDownInc
        Next lintArrInc
    End Sub
    Function MakeFileNameNice(ByVal pstrRoughFileName As String, ByVal pExt As String) As String
        'added 
        Dim lintArrInc As Integer
        Dim RetVal As String = ""
        Dim LastChar As String = ""

        pExt = pExt.Replace(".", "")

        pstrRoughFileName = pstrRoughFileName.ToLower


        For lintArrInc = 1 To pstrRoughFileName.Length
            Dim lstrChar As String = MidGet(pstrRoughFileName, lintArrInc, 1)
            If (AscGet(lstrChar) >= 97 And AscGet(lstrChar) <= 122) Or (AscGet(lstrChar) >= 48 And AscGet(lstrChar) <= 57) Then
                RetVal &= lstrChar
                LastChar = lstrChar
            Else
                If LastChar <> "-" Then
                    RetVal &= "-"
                    LastChar = "-"
                End If
            End If
        Next lintArrInc


        If RightGet(RetVal, 1) = "-" Then
            RetVal = LeftGet(RetVal, RetVal.Length - 1)
        End If

        If pExt <> "" Then
            Return RetVal & "." & pExt
        Else
            Return RetVal
        End If

    End Function
    Function ReplaceAll(ByVal pString As String, ByVal pWhat As String, ByVal pWith As String) As String

        'added 
        Dim lbooDone As Boolean = False

        Do Until lbooDone = True
            If InStrGet(pString, pWhat) > 0 Then
                pString = pString.Replace(pWhat, pWith)
            Else
                lbooDone = True
            End If
        Loop

        Return pString

    End Function
    Function CentreMe(ByVal pMe As Form) As Point

        'added 
        Dim X As Short = (Screen.PrimaryScreen.Bounds.Width - pMe.Width) / 2
        Dim Y As Short = (Screen.PrimaryScreen.Bounds.Height - pMe.Height) / 2

        Return New Point(X, Y)

    End Function
    Function StripTrailingTimeZone(ByVal pstrDate As String) As String

        'added 
        ''Dim pstrNewDate As String = pstrDate.ToString("dd/MM/yyyy ") & _
        ''pstrDate.ToString("T", System.Globalization.DateTimeFormatInfo.InvariantInfo)

        ''Return pstrNewDate 
        If MidGet(pstrDate, pstrDate.Length - 3, 1) = " " And _
            Char.IsLetter(MidGet(pstrDate, pstrDate.Length - 2, 1)) = True And _
            Char.IsLetter(MidGet(pstrDate, pstrDate.Length - 1, 1)) = True And _
            Char.IsLetter(MidGet(pstrDate, pstrDate.Length, 1)) = True Then
            Return LeftGet(pstrDate, pstrDate.Length - 4)
        Else
            Return pstrDate
        End If

    End Function
End Module



