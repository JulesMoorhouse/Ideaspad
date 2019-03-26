Imports System
Imports System.IO
Friend Module flame
    Friend gbooSevenDayWarning As Boolean = False
    Friend Enum Encops
        EncryptDataFile
        EncryptString
        EncryptStringNFile
    End Enum
    Friend Structure flamer
        Friend strSD As String
        Friend strLD As String
        Friend strED As String
        Friend strHS As String
        Friend strLTD As String
    End Structure

    Friend gstrDBFlamer As flamer
    Friend gstrVBXFlamer As flamer

    Friend Structure FieldValues
        Dim pstrField As String
        Dim pstrValue As String
    End Structure

    Private LangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("Ideaspad.Ideaspad", _
        System.Reflection.Assembly.GetExecutingAssembly())

    Friend Function AppExe() As String
        On Error Resume Next
        Dim AP As String
        AP = Application.ExecutablePath
        If RightGet(AP, 1) <> "\" Then AP = AP & "\"
        AppExe = System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()

    End Function

    Friend Sub Encrypt(ByVal pstrOutputFile As String, ByVal pstrInput As String, ByVal pstrOption As Encops, _
        ByVal pstrView As String, ByRef pstrInp() As String, ByRef pstrProbComtStack As String)

        Dim strHead As String
        Dim strT As String
        Dim strA As String
        Dim cphX As New Fix
        Dim lngN As Long

        Dim lintRetyCount As Integer = 0
        pstrProbComtStack &= " #E1"

        Select Case pstrOption

            Case Encops.EncryptString, Encops.EncryptStringNFile
                strA = pstrInput & CR()
                pstrProbComtStack &= " #E1a"
            Case Encops.EncryptDataFile
                pstrProbComtStack &= " #E2"
Encrypt1:
                Dim OpenFile As FileStream
                Dim sr As StreamReader
                Try
                    OpenFile = New FileStream(pstrInput, FileMode.Open, FileAccess.Read, FileShare.Read)
                    sr = New StreamReader(OpenFile)
                    strA = sr.ReadToEnd()
                    sr.Close()
                    OpenFile.Close()

                Catch

                    Try : sr.Close() : Catch : End Try
                    Try : OpenFile.Close() : Catch : End Try

                    Dim lWaitTime As Date = Date.Now
                    Do While lWaitTime.AddSeconds(2) > Date.Now
                        System.Windows.Forms.Application.DoEvents()
                        lintRetyCount += 1
                    Loop
                    If lintRetyCount >= 4 Then
                        Throw New Exception("An unexpected  error has occured. Code EN1")
                    Else
                        GoTo Encrypt1
                    End If

                End Try

                pstrProbComtStack &= " #E3"
        End Select

        strT = Hash(Date.Today & CStr(Microsoft.VisualBasic.Timer))

        pstrProbComtStack &= " #E4"

        strHead = "33" & strT & Hash(strT & pstrView)
        cphX.KeyString = strHead
        cphX.Text = strA
        pstrProbComtStack &= " #E5"
        cphX.DoXor()
        cphX.Stretch()
        strA = cphX.Text

        pstrProbComtStack &= " #E6"
        Dim lintArrInc As Integer
        If pstrOption = Encops.EncryptString Then
            ReDim pstrInp(0)
            pstrInp(0) = strHead
            lngN = 1
            Do
                lintArrInc = lintArrInc + 1
                ReDim Preserve pstrInp(lintArrInc)
                pstrInp(lintArrInc) = MidGet(strA, lngN, 70)
                lngN = lngN + 70
            Loop Until lngN > (strA).Length
        Else
            pstrProbComtStack &= " #E7"
Encrypt2:
            Dim OpenFile2 As FileStream
            Dim StreamWriter2 As StreamWriter
            Try
                If File.Exists(pstrOutputFile) = True Then
                    OpenFile2 = New FileStream(pstrOutputFile, FileMode.Append, FileAccess.Write, FileShare.Write)
                Else
                    OpenFile2 = New FileStream(pstrOutputFile, FileMode.CreateNew, FileAccess.Write, FileShare.Write)
                End If
                StreamWriter2 = New StreamWriter(OpenFile2)
                StreamWriter2.WriteLine(strHead)

                'THERE SHOULD BE NO CLOSE STATEMENTS HERE!!!! 
            Catch

                Try : StreamWriter2.Close() : Catch : End Try
                Try : OpenFile2.Close() : Catch : End Try

                Dim lWaitTime As Date = Date.Now
                Do While lWaitTime.AddSeconds(2) > Date.Now
                    System.Windows.Forms.Application.DoEvents()
                    lintRetyCount += 1
                Loop
                If lintRetyCount >= 4 Then
                    Throw New Exception("An unexpected  error has occured. Code EN2")
                Else
                    GoTo Encrypt2
                End If

            End Try

            pstrProbComtStack &= " #E8"
            'Write encrypted data
            lngN = 1
            Do
                StreamWriter2.WriteLine(MidGet(strA, lngN, 70))
                lngN = lngN + 70
            Loop Until lngN > (strA).Length

            pstrProbComtStack &= " #E9"
            StreamWriter2.Close()
            OpenFile2.Close()

            pstrProbComtStack &= " #E-Done"
        End If
    End Sub
    Friend Function Decrypt(ByVal pstrInputFile As String, ByVal pstrOutputFile As String, _
        ByVal pstrOption As Encops, Optional ByRef pstrInp() As String = Nothing, Optional ByVal BugWork As Integer = 0) As String
        Dim strHead As String
        Dim strA As String
        Dim strT As String
        Dim cphX As New Fix
        Dim lintRetyCount As Integer = 0

        gstrDecryptProbTrace = " #Dc1"

        If pstrOption = Encops.EncryptString Then
            strHead = pstrInp(0)
        Else
            gstrDecryptProbTrace &= " #Dc2"

Decrypt1:
            Dim OpenFile As FileStream
            Dim StreamReader As StreamReader

            Try
                OpenFile = New FileStream(pstrInputFile, FileMode.Open, FileAccess.Read, FileShare.Read)
                StreamReader = New StreamReader(OpenFile)
                strHead = StreamReader.ReadLine()
                StreamReader.Close()
                OpenFile.Close()
            Catch

                Try : StreamReader.Close() : Catch : End Try
                Try : OpenFile.Close() : Catch : End Try

                Dim lWaitTime As Date = Date.Now
                Do While lWaitTime.AddSeconds(2) > Date.Now
                    System.Windows.Forms.Application.DoEvents()
                    lintRetyCount += 1
                Loop
                If lintRetyCount >= 4 Then
                    Throw New Exception("An unexpected  error has occured. Code DE1")
                Else
                    GoTo Decrypt1
                End If

            End Try

        End If
        gstrDecryptProbTrace &= " #Dc3"
        strT = MidGet(strHead, 9, 8)


        Dim lintArrInc As Integer
        Select Case pstrOption
            Case Encops.EncryptString
                gstrDecryptProbTrace &= " #Dc4"
                For lintArrInc = 1 To pstrInp.GetUpperBound(0)
                    strA = strA & pstrInp(lintArrInc)

                Next lintArrInc
            Case Encops.EncryptDataFile, Encops.EncryptStringNFile
                lintRetyCount = 0
                gstrDecryptProbTrace &= " #Dc5"
Decrypt2:
                Dim OpenFile2 As FileStream
                Dim StreamReader2 As StreamReader
                Try
                    OpenFile2 = New FileStream(pstrInputFile, FileMode.Open, FileAccess.Read, FileShare.Read)
                    StreamReader2 = New StreamReader(OpenFile2)
                    strHead = StreamReader2.ReadLine()

                    Do Until strT Is Nothing
                        strT = StreamReader2.ReadLine()
                        strA = strA & strT
                    Loop
                    gstrDecryptProbTrace &= " #Dc6"
                    StreamReader2.Close()
                    OpenFile2.Close()
                Catch

                    gstrDecryptProbTrace &= " #Dc7"
                    Try : StreamReader2.Close() : Catch : End Try
                    Try : OpenFile2.Close() : Catch : End Try

                    Dim lWaitTime As Date = Date.Now
                    Do While lWaitTime.AddSeconds(2) > Date.Now
                        System.Windows.Forms.Application.DoEvents()
                        lintRetyCount += 1
                    Loop
                    If lintRetyCount >= 4 Then
                        Throw New Exception("An unexpected  error has occured. Code DE2")
                    Else
                        GoTo Decrypt2
                    End If

                End Try

        End Select
        gstrDecryptProbTrace &= " #Dc8"
        'Decrypted file contents
        cphX.KeyString = strHead
        cphX.Text = strA
        gstrDecryptProbTrace &= " #Dc9"
        cphX.Shrink()
        gstrDecryptProbTrace &= " #Dc10"
        If BugWork = 1 Then
            gstrDecryptProbTrace &= " #Dc11"
            cphX.DoXorOld()
        Else
            gstrDecryptProbTrace &= " #Dc12"
            cphX.DoXor()
        End If
        strA = cphX.Text
        gstrDecryptProbTrace &= " #Dc13"

        Select Case pstrOption
            Case Encops.EncryptString, Encops.EncryptStringNFile
                Decrypt = strA
                Decrypt = LeftGet(strA, strA.Length - 1)
                gstrDecryptProbTrace &= " #Dc14"
            Case Encops.EncryptDataFile
                lintRetyCount = 0
                gstrDecryptProbTrace &= " #Dc15"
Decrypt3:
                Dim OpenFile3 As FileStream
                Dim StreamWriter3 As StreamWriter
                Try
                    OpenFile3 = New FileStream(pstrOutputFile, FileMode.CreateNew, FileAccess.Write, FileShare.Write)
                    StreamWriter3 = New StreamWriter(OpenFile3)
                    StreamWriter3.Write(strA)
                    StreamWriter3.Close()
                    OpenFile3.Close()
                Catch
                    gstrDecryptProbTrace &= " #Dc16"

                    Try : StreamWriter3.Close() : Catch : End Try
                    Try : OpenFile3.Close() : Catch : End Try

                    Dim lWaitTime As Date = Date.Now
                    Do While lWaitTime.AddSeconds(2) > Date.Now
                        System.Windows.Forms.Application.DoEvents()
                        lintRetyCount += 1
                    Loop
                    If lintRetyCount >= 4 Then
                        Throw New Exception("An unexpected  error has occured. Code DE3")
                    Else
                        GoTo Decrypt3
                    End If
                    gstrDecryptProbTrace &= " #Dc17"
                End Try

        End Select
        gstrDecryptProbTrace = ""

    End Function
    Private Function Hash(ByVal strA As String) As String
        Dim cphHash As New Fix

        cphHash.KeyString = strA & "123456"
        cphHash.Text = strA & "123456"
        cphHash.DoXor()
        cphHash.Stretch()
        cphHash.KeyString = cphHash.Text
        cphHash.Text = "123456"
        cphHash.DoXor()
        cphHash.Stretch()
        Hash = cphHash.Text

    End Function

    Private Sub GetBuffer(ByRef pstrResource As flamer, ByVal pstring As String)

        With pstrResource
            .strSD = ReturnNthStr(pstring, 1, ChrGet(182))
            .strLD = ReturnNthStr(pstring, 2, ChrGet(182))
            .strED = ReturnNthStr(pstring, 3, ChrGet(182))
            .strHS = ReturnNthStr(pstring, 4, ChrGet(182))
            .strLTD = ReturnNthStr(pstring, 5, ChrGet(182))
        End With

    End Sub
    Private Function SetBuffer(ByRef pstrResource As flamer) As String
        Const lstrIntlyBlank = "Blank"

        With pstrResource
            SetBuffer = .strSD & ChrGet(182) & .strLD & ChrGet(182) & .strED & ChrGet(182) & .strHS & ChrGet(182) & .strLTD & ChrGet(182) & _
            lstrIntlyBlank & ChrGet(182) & lstrIntlyBlank & ChrGet(182) & lstrIntlyBlank & ChrGet(182) & lstrIntlyBlank & ChrGet(182) & _
            lstrIntlyBlank & ChrGet(182) & lstrIntlyBlank & ChrGet(182) & lstrIntlyBlank & ChrGet(182)
        End With

    End Function

    Friend Function CheckDates(ByVal pstrResource As flamer, ByVal Which As Integer, ByRef pstrProbComtStack As String) As Long
        Dim lstrVgxPath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) & "\Microsoft Shared\Vgx\"

        pstrProbComtStack &= " CD - 1 - " & Which
        'Description of fields
        '=====================
        '.strHS = Hours since, this is used as a counter since 2000 of time used
        '.strSD = Start Date
        '.strED = Last Explorer Date
        '.strLTD = Last Time of day, so you can tell if 24 hours have passed
        '.strLD = Last Date, this has also been changed to hold any future date which is shown

        Dim LibraryFile As String
        Dim FallBack As String
        Dim lintFactor As Integer = 1
        'Program usage Codes 
        Select Case Which
            Case 1 'mdbsecure = 1                
                'Vgxlib.vxd
                LibraryFile = ChrGet(86) & ChrGet(103) & ChrGet(120) & ChrGet(108) & ChrGet(105) & ChrGet(98) & ChrGet(46) & ChrGet(118) & ChrGet(120) & ChrGet(100)
                'Accdb2k.dat
                FallBack = ChrGet(65) & ChrGet(99) & ChrGet(99) & ChrGet(100) & ChrGet(98) & ChrGet(50) & ChrGet(107) & ChrGet(46) & ChrGet(100) & ChrGet(97) & ChrGet(116)

                If File.Exists(lstrVgxPath & LibraryFile) = False Or File.Exists(Application.StartupPath & "\" & FallBack) = False Then
                    'Vgxlibr.vxd
                    LibraryFile = ChrGet(86) & ChrGet(103) & ChrGet(120) & ChrGet(108) & ChrGet(105) & ChrGet(98) & ChrGet(114) & ChrGet(46) & ChrGet(118) & ChrGet(120) & ChrGet(100)
                    'Accdb2kr.dat
                    FallBack = ChrGet(65) & ChrGet(99) & ChrGet(99) & ChrGet(100) & ChrGet(98) & ChrGet(50) & ChrGet(107) & ChrGet(114) & ChrGet(46) & ChrGet(100) & ChrGet(97) & ChrGet(116)
                Else
                    lintFactor = 3
                End If

            Case 2 'htmlsqueeze = 2                
                'Vgxcom.vxd
                LibraryFile = ChrGet(86) & ChrGet(103) & ChrGet(120) & ChrGet(99) & ChrGet(111) & ChrGet(109) & ChrGet(46) & ChrGet(118) & ChrGet(120) & ChrGet(100)
                'Wc3lib.tbl
                FallBack = ChrGet(87) & ChrGet(99) & ChrGet(51) & ChrGet(108) & ChrGet(105) & ChrGet(98) & ChrGet(46) & ChrGet(116) & ChrGet(98) & ChrGet(108)
            Case 3 'mmos = 3
                'Vgxdrv.vxd
                LibraryFile = ChrGet(86) & ChrGet(103) & ChrGet(120) & ChrGet(100) & ChrGet(114) & ChrGet(118) & ChrGet(46) & ChrGet(118) & ChrGet(120) & ChrGet(100)
                'Ordlib.tbl
                FallBack = ChrGet(79) & ChrGet(114) & ChrGet(100) & ChrGet(108) & ChrGet(105) & ChrGet(98) & ChrGet(46) & ChrGet(116) & ChrGet(98) & ChrGet(108)
            Case 4 'kids mask print 
                'Vgxext.vxd
                LibraryFile = ChrGet(86) & ChrGet(103) & ChrGet(120) & ChrGet(101) & ChrGet(120) & ChrGet(116) & ChrGet(46) & ChrGet(118) & ChrGet(120) & ChrGet(100)
                'layouts.dat
                FallBack = ChrGet(108) & ChrGet(97) & ChrGet(121) & ChrGet(111) & ChrGet(117) & ChrGet(116) & ChrGet(115) & ChrGet(46) & ChrGet(100) & ChrGet(97) & ChrGet(116)

            Case Else 'ideaspad = 0
                'Vgxst.vxd
                LibraryFile = ChrGet(86) & ChrGet(103) & ChrGet(120) & ChrGet(115) & ChrGet(116) & ChrGet(46) & ChrGet(118) & ChrGet(120) & ChrGet(100)
                'Ideaspad.vxd
                FallBack = ChrGet(73) & ChrGet(100) & ChrGet(101) & ChrGet(97) & ChrGet(115) & ChrGet(112) & ChrGet(97) & ChrGet(100) & ChrGet(46) & ChrGet(118) & ChrGet(120) & ChrGet(100)

                'if the old 90 days lock file doesn't exist then use 30 days file
                If File.Exists(lstrVgxPath & LibraryFile) = False Or File.Exists(Application.StartupPath & "\" & FallBack) = False Then
                    'Vgxstr.vxd
                    LibraryFile = ChrGet(86) & ChrGet(103) & ChrGet(120) & ChrGet(115) & ChrGet(116) & ChrGet(114) & ChrGet(46) & ChrGet(118) & ChrGet(120) & ChrGet(100)
                    'Ideaspadr.vxd
                    FallBack = ChrGet(73) & ChrGet(100) & ChrGet(101) & ChrGet(97) & ChrGet(115) & ChrGet(112) & ChrGet(97) & ChrGet(100) & ChrGet(114) & ChrGet(46) & ChrGet(118) & ChrGet(120) & ChrGet(100)
                Else
                    lintFactor = 3
                End If

        End Select

        Dim IntegrityLost As Boolean = False
        Dim LastUsedGreaterThanNow As Boolean = False

        pstrProbComtStack &= " #CD2"

        CheckDates = 2
        With pstrResource
            'Get Dates from Database
            '.strSD = GetFieldValuesX("A")
            '.strLD = GetFieldValuesX("B")
            '.strED = GetFieldValuesX("C")
            '.strHS = GetFieldValuesX("D")
            '.strLTD = GetFieldValuesX("E")
            pstrProbComtStack &= " #CD3"

            GetFieldValues4(.strSD, .strLD, .strED, .strHS, .strLTD, pstrProbComtStack)

            pstrProbComtStack &= " #CD4"
            'correct dates from offset of 13,34,73 etc
            GetRealDates(pstrResource, pstrProbComtStack)

            AppendLog(.strSD & Tab() & .strLD & Tab() & .strED & Tab() & .strHS & Tab() & .strLTD & Tab() & "ST")

            'Get dates from Hidden file
            Dim lstrDecFile As String = lstrVgxPath & LibraryFile '
            Dim lstrSourceFile As New System.IO.FileInfo(lstrDecFile)
            Dim lstrSourceFile2 As New System.IO.FileInfo(Application.StartupPath & "\" & FallBack)

            Try
                If Not lstrSourceFile.Exists Then ' if vgx library doesn't exist
                    If lstrSourceFile2.Exists Then ' if fallback file exists
                        lstrDecFile = Application.StartupPath & "\" & FallBack
                        pstrProbComtStack &= " #CD4-1"
                    Else
                        lstrDecFile = ""
                        pstrProbComtStack &= " #CD4a"
                    End If
                End If
                pstrProbComtStack &= " #CD4b"
            Catch ex As UnauthorizedAccessException
                AddDebugComment("UnauthorizedAccessException trap")

                If lstrSourceFile2.Exists Then
                    lstrDecFile = Application.StartupPath & "\" & FallBack
                Else
                    lstrDecFile = ""
                End If

            End Try

            pstrProbComtStack &= " #CD5"
            If lstrDecFile <> "" Then
                Dim lstrDec As String
                pstrProbComtStack &= " #CD5a"

                lstrDec = Decrypt(lstrDecFile, "", Encops.EncryptStringNFile)

                Dim DatePos1 As String = ReturnNthStr(lstrDec, 1, ChrGet(182))
                Try
                    If DatePos1.Length = 20 Then
                        DatePos1 = RightGet(DatePos1, 19)
                    End If
                Catch : End Try


                Dim DebugRes As String = "F"
                If lstrDec = "" Then DebugRes = "N"
                pstrProbComtStack &= " #CD5b - " & lstrDec

                If Microsoft.VisualBasic.IsDate(DeCodeCoverDate(DatePos1)) = False Then
                    'if using New fixed decrypt DoXor function and get an error try the old one.
                    lstrDec = Decrypt(lstrDecFile, "", Encops.EncryptStringNFile, , 1)


                    Dim DatePos1a As String = ReturnNthStr(lstrDec, 1, ChrGet(182))
                    Try
                        If DatePos1a.Length = 20 Then
                            DatePos1a = RightGet(DatePos1, 19)
                        End If
                    Catch : End Try

                    If Microsoft.VisualBasic.IsDate(DeCodeCoverDate(DatePos1a)) = False Then
                        pstrProbComtStack &= " #CD5NS Date=/" & DatePos1a & "/"
                        GoTo NewStart
                    End If
                End If

                pstrProbComtStack &= " #CD6"
                Dim lstrVXDFlamer As New flamer
                'Get dates from string
                GetBuffer(lstrVXDFlamer, lstrDec)
                '- need to convers dates uk to locale
                GetRealDates(lstrVXDFlamer, pstrProbComtStack)

                AppendLog(.strSD & Tab() & .strLD & Tab() & .strED & Tab() & .strHS & Tab() & .strLTD & Tab() & "B4")

                'get VDX dates and if different use the oldest or best

                If IDate(lstrVXDFlamer.strSD) < Date.Now And IDate(lstrVXDFlamer.strSD) < IDate(.strSD) Then .strSD = lstrVXDFlamer.strSD
                If IDate(lstrVXDFlamer.strHS) > IDate(.strHS) Then .strHS = lstrVXDFlamer.strHS
            End If

            pstrProbComtStack &= " #CD7"
NewStart:
            pstrProbComtStack &= " #CD7NS1"

            If .strHS = "" Or .strHS = "01/01/2000" Then
                .strHS = "01/01/2000 00:01:00"
            End If
            '------ Check integrity of dates we have from last time prog was run --------
            pstrProbComtStack &= " #CD7NS2"
            If IDate(.strSD) > Date.Now Then
                'so someone has changed the date to earlier than start date
                IntegrityLost = True
                ''Conxsole.WriteLine("IntegrityLost - StartDateAhead")
            End If

            pstrProbComtStack &= " #CD7N3"
            If IDate(.strLD) > Date.Now Then
                'so someone has changed the date to earlier than last used date
                IntegrityLost = True
                LastUsedGreaterThanNow = True
            End If
            pstrProbComtStack &= " #CD7NS4"

            Dim le As String = System.IO.Path.GetDirectoryName(System.Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\explorer.exe"
            pstrProbComtStack &= " #CD7NS5"
            If FormatDateTime(IDate(.strED), DateFormat.ShortTime) > FormatDateTime(System.IO.File.GetLastAccessTime(le), DateFormat.ShortTime) Then
                'so someone has changed the date to earlier than last explorer used date
                IntegrityLost = True
            End If
            '------ Check integrity of dates we have from last time prog was run --------
            pstrProbComtStack &= " #CD7a"
            If IntegrityLost = False Then
                'have integrity
                pstrProbComtStack &= " #CD7b"
                If (DateDiffGet(DateInterval.Hour, gdatSystemStart, Date.Now)) > 0 Then
                    pstrProbComtStack &= " #CD7c"
                    'if the prog has been running for a while add some hours to strHS

                    .strHS = (IDate(.strHS).AddHours((DateDiffGet(DateInterval.Hour, gdatSystemStart, Date.Now))))
                    pstrProbComtStack &= " #CD7d"
                End If
            Else
                pstrProbComtStack &= " #CD7e"
                'integrity lost
                If FormatDateTime(IDate(.strLTD), DateFormat.ShortTime) > FormatDateTime(Date.Now, DateFormat.ShortTime) Then
                    pstrProbComtStack &= " #CD7f"
                    'if the last time of day we know about is greater than the current time of day 24 hours have past!

                    .strHS = (IDate(.strHS).AddHours(24)) '12)
                    pstrProbComtStack &= " #CD7g"
                End If
                pstrProbComtStack &= " #CD7h"
                'if last date is greater than current date then add these days to strHS                
                If LastUsedGreaterThanNow = True Then
                    pstrProbComtStack &= " #CD7i"
                    '.strHS = IDate(.strHS).AddDays(DateDiffGet(DateInterval.Day, Date.Now, IDate(.strLD)))

                    Dim DaysToAdd As Integer = DateDiffGet(DateInterval.Day, Date.Now, IDate(.strLD))
                    pstrProbComtStack &= " #CD7j"
                    If DaysToAdd > 0 Then
                        pstrProbComtStack &= " #CD7k"

                        .strHS = (IDate(.strHS).AddDays(DaysToAdd))
                        pstrProbComtStack &= " #CD7l"
                    End If

                End If
                pstrProbComtStack &= " #CD7m"
            End If
            pstrProbComtStack &= " #CD7n"
            'update the dates for next time the function is called
            If Date.Now > .strLD Then
                pstrProbComtStack &= " #CD7o"

                .strLD = (GreatDateStr(Date.Now, pstrProbComtStack))
            End If
            pstrProbComtStack &= " #CD7p"

            .strED = (GreatDateStr(System.IO.File.GetLastAccessTime(le), pstrProbComtStack))
            pstrProbComtStack &= " #CD7q"

            .strLTD = (GreatDateStr(Date.Now, pstrProbComtStack))
            pstrProbComtStack &= " #CD7r"
            Dim llngDays As Long
            llngDays = DateDiffGet(DateInterval.Day, IDate(.strSD), Date.Now)
            pstrProbComtStack &= " #CD7s"
            'changed to 30 
            If Date.Now > IDate(.strSD).AddDays((15 + 15) * lintFactor) Then
                pstrProbComtStack &= " #CD7t"
                CheckDates = 0

                pstrProbComtStack &= " #CD7u"

                If IDate("01/01/2000").AddDays(llngDays) > IDate(.strHS) Then

                    .strHS = (IDate("01/01/2000").AddDays(llngDays))
                    pstrProbComtStack &= " #CD7w"
                End If


            End If
            pstrProbComtStack &= " #CD7x"

            If IDate(.strHS) > IDate("01/01/2000").AddDays((10 + 20) * lintFactor) Then
                pstrProbComtStack &= " #CD7y"
                CheckDates = 0
            End If

            pstrProbComtStack &= " #CD7z"
            AppendLog(.strSD & Tab() & .strLD & Tab() & .strED & Tab() & .strHS & Tab() & .strLTD & Tab() & "AF " & _
                DateDiffGet(DateInterval.Day, IDate(.strSD), Date.Now) & "/" & _
               DateDiffGet(DateInterval.Day, IDate("01/01/2000"), IDate(.strHS)) & " day(s)")

            pstrProbComtStack &= " #CD71"

            If Date.Now > IDate(.strSD).AddDays(23) Or IDate(.strHS) > IDate("01/01/2000").AddDays(23) Then
                pstrProbComtStack &= " #CD71a"
                gbooSevenDayWarning = True
            End If
            pstrProbComtStack &= " #CD71b"

            'Changed as Remind screen always showed 30 days!!
            Dim TableFonts As Integer = DateDiffGet(strman.DateInterval.Day, IDate(.strSD), Date.Now)
            pstrProbComtStack &= " #CD71c"
            SaveSetting(ChrGet(70 + 12) & ChrGet(90 + 11) & ChrGet(50 + 59) & ChrGet(40 + 57) & ChrGet(10 + 95) & ChrGet(50 + 60), _
                TableFonts, InitalXMLConfig.XmlConfigType.AppSettings, "")
            pstrProbComtStack &= " #CD71d"

            Dim TableFonties As Integer = DateDiffGet(strman.DateInterval.Minute, gdatSystemStart, IDate(Date.Now))
            pstrProbComtStack &= " #CD71e"
            If TableFonties > 1 Then
                Dim Last As Integer
                pstrProbComtStack &= " #CD71f"
                Last = CInt(GetSetting(ChrGet(70 + 12) & ChrGet(90 + 11) & ChrGet(50 + 59) & ChrGet(40 + 57) & ChrGet(10 + 95) & ChrGet(50 + 60) & "sub", "0", InitalXMLConfig.XmlConfigType.AppSettings, ""))
                pstrProbComtStack &= " #CD71g"
                SaveSetting(ChrGet(70 + 12) & ChrGet(90 + 11) & ChrGet(50 + 59) & ChrGet(40 + 57) & ChrGet(10 + 95) & ChrGet(50 + 60) & "sub", _
                    TableFonties + Last, InitalXMLConfig.XmlConfigType.AppSettings, "")
            End If

            pstrProbComtStack &= " #CD8"
            '- need to convers dates locale to uk, date to string
            SetRealDates(pstrResource, False, pstrProbComtStack)
            pstrProbComtStack &= " #CD8-1"

            Dim lstrFieldValues(4) As FieldValues
            lstrFieldValues(0).pstrField = "A" : lstrFieldValues(0).pstrValue = .strSD
            lstrFieldValues(1).pstrField = "B" : lstrFieldValues(1).pstrValue = .strLD
            lstrFieldValues(2).pstrField = "C" : lstrFieldValues(2).pstrValue = .strED
            lstrFieldValues(3).pstrField = "D" : lstrFieldValues(3).pstrValue = .strHS
            lstrFieldValues(4).pstrField = "E" : lstrFieldValues(4).pstrValue = .strLTD
            SaveFieldValuesX(lstrFieldValues, pstrProbComtStack)
            ReDim lstrFieldValues(0)

            pstrProbComtStack &= " #CD8-2"
            'write details to VBX

            'move setbuffer and gebuffer out of the encrypt process and do it out side.
            'then pass in the buffer string to encode, then decrpyt with returNth
            Dim lstrIdeasPad As String = System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()
            Dim lstrFile As New System.IO.FileInfo(lstrVgxPath & "vgx.dll")
            Dim lstrVXDfile As String
            Dim ldatVXDStamp As Date
            Dim ldatVXDAccessedStamp As Date
            Dim ldatVXDModifiedStamp As Date

            'hopefully this next line will show if "File.Exists" is telling lies
            'I don't see how the file can exist at the top of the function and not at the bottom!
            pstrProbComtStack &= " #CD8-21 - " & lstrSourceFile2.Exists

            'Test to see whether you can write to the VGX directory e.g. UnauthorizedAccessException
            'if not use fall back file.
            Dim lbooUseFallback As Boolean = False
            If File.Exists(lstrVgxPath & LibraryFile) = False And File.Exists(Application.StartupPath & "\" & FallBack) = False Then

                pstrProbComtStack &= " #CD8-3"
                Dim TestFile As String = lstrVgxPath & Date.Now.ToString("dddd-dd-MMM-yyyy-HH-mm-ss") & ".tmp"
                Try
                    pstrProbComtStack &= " #CD8-4"
                    Dim OpenFile As FileStream = New FileStream(TestFile, FileMode.CreateNew, FileAccess.Write, FileShare.Write)
                    Dim StreamWriter As StreamWriter = New StreamWriter(OpenFile)
                    StreamWriter.WriteLine("TEST")
                    StreamWriter.Close()
                    OpenFile.Close()
                    Try : File.Delete(TestFile) : Catch : End Try
                    lbooUseFallback = False
                    pstrProbComtStack &= " #CD8a"
                Catch
                    Try : File.Delete(TestFile) : Catch : End Try
                    lbooUseFallback = True
                    pstrProbComtStack &= " #CD8b"
                End Try
            End If
            pstrProbComtStack &= " #CD8c"
            'if you can write to the VGX directory and the VGX.dll exists don't use fall back file
            If lbooUseFallback = False And lstrFile.Exists Then
                lbooUseFallback = False
            Else
                lbooUseFallback = True
            End If

            Dim retried As Boolean = False

RetryWithFallback:
            If lbooUseFallback = False Then
                lstrVXDfile = lstrVgxPath & LibraryFile
                ldatVXDAccessedStamp = System.IO.File.GetLastAccessTime(lstrVgxPath & "vgx.dll")
                ldatVXDStamp = System.IO.File.GetCreationTime(lstrVgxPath & "vgx.dll")
                ldatVXDModifiedStamp = System.IO.File.GetLastWriteTime(lstrVgxPath & "vgx.dll")
            Else
                lstrVXDfile = Application.StartupPath & "\" & FallBack
                ldatVXDAccessedStamp = System.IO.File.GetLastAccessTime(lstrIdeasPad)
                ldatVXDStamp = System.IO.File.GetCreationTime(lstrIdeasPad)
                ldatVXDModifiedStamp = System.IO.File.GetLastWriteTime(lstrIdeasPad)
            End If

            Try
                System.IO.File.Delete(lstrVXDfile)
            Catch
            End Try

            pstrProbComtStack &= " #CD9- Exists=" & File.Exists(lstrVXDfile)

            Try
                Encrypt(lstrVXDfile, SetBuffer(pstrResource), Encops.EncryptStringNFile, "CDate", Nothing, pstrProbComtStack)

                System.IO.File.SetLastAccessTime(lstrVXDfile, ldatVXDAccessedStamp)
                pstrProbComtStack &= " #CD11"
                System.IO.File.SetCreationTime(lstrVXDfile, ldatVXDStamp)
                pstrProbComtStack &= " #CD12"

                System.IO.File.SetLastWriteTime(lstrVXDfile, ldatVXDModifiedStamp)
            Catch ex As Exception
                If retried = False Then
                    If ex.Message = "An unexpected  error has occured. Code EN1" Then
                        lbooUseFallback = True
                        retried = True
                        GoTo RetryWithFallback
                    End If
                Else
                    MessageBox.Show(LangText.GetString("Flame_SorryAdminRights"), _
                        NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Try

            pstrProbComtStack &= " #CD10"
        End With

        pstrProbComtStack &= " #CD-Done"

    End Function
    Private Sub AppendLog(ByVal pstrString As String)

        Dim DateDebug As New IO.FileInfo(System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\DATEDEBUG.TXT")

        If DateDebug.Exists = True Then
            Dim lstrLogFile As String = System.IO.Path.GetDirectoryName( _
                System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\Date.log"

            Dim lstrFile As New System.IO.FileInfo(lstrLogFile)
            If Not lstrFile.Exists Then
                Dim OpenFileHeader As FileStream = New FileStream(lstrLogFile, FileMode.Append, FileAccess.Write, FileShare.Write)
                Dim StreamWriterHeader As StreamWriter = New StreamWriter(OpenFileHeader)
                StreamWriterHeader.WriteLine("strSD" & Tab() & Tab() & Tab() & "strLD" & Tab() & Tab() & Tab() & "strED" & Tab() & Tab() & Tab() & "strHS" & Tab() & Tab() & Tab() & "strLTD")
                StreamWriterHeader.Close()
                OpenFileHeader.Close()
            End If

            Dim OpenFile As FileStream = New FileStream(lstrLogFile, FileMode.Append, FileAccess.Write, FileShare.Write)
            Dim StreamWriter As StreamWriter = New StreamWriter(OpenFile)
            StreamWriter.WriteLine(pstrString)
            StreamWriter.Close()
            OpenFile.Close()

        End If

    End Sub
    Private Sub GetRealDates(ByRef pstrResource As flamer, ByRef pstrProbComtStack As String)

        pstrProbComtStack &= " #GRD1"

        'UK to Local
        With pstrResource

            .strSD = GreatDateStr(ID(DeCodeCoverDate(.strSD.Substring(1)), pstrProbComtStack).AddDays(-13), pstrProbComtStack)
            pstrProbComtStack &= " #GRD2"
            .strLD = GreatDateStr(ID(DeCodeCoverDate(.strLD.Substring(1)), pstrProbComtStack).AddDays(34), pstrProbComtStack)
            pstrProbComtStack &= " #GRD3"
            .strED = GreatDateStr(ID(DeCodeCoverDate(.strED.Substring(1)), pstrProbComtStack).AddDays(73), pstrProbComtStack)
            pstrProbComtStack &= " #GRD4"
            .strHS = GreatDateStr(ID(DeCodeCoverDate(.strHS.Substring(1)), pstrProbComtStack).AddDays(-25), pstrProbComtStack)
            pstrProbComtStack &= " #GRD5"
            .strLTD = GreatDateStr(ID(DeCodeCoverDate(.strLTD.Substring(1)), pstrProbComtStack).AddDays(17), pstrProbComtStack)
            pstrProbComtStack &= " #GRD6"
        End With

    End Sub
    Friend Sub SetRealDates(ByRef pstrResource As flamer, ByVal pbooSetHS As Boolean, ByRef pstrProbComtStack As String)

        pstrProbComtStack &= " #SRD1"

        'Local to UK
        With pstrResource

            .strSD = CodeCoverDate("6" & GreatDateStr((IDate(.strSD).AddDays(13)), pstrProbComtStack))
            pstrProbComtStack &= " #SRD2"
            .strLD = CodeCoverDate("3" & GreatDateStr((IDate(.strLD).AddDays(-34)), pstrProbComtStack))
            pstrProbComtStack &= " #SRD3"
            .strED = CodeCoverDate("8" & GreatDateStr((IDate(.strED).AddDays(-73)), pstrProbComtStack))
            pstrProbComtStack &= " #SRD4"
            If pbooSetHS = False Then
                .strHS = CodeCoverDate("9" & GreatDateStr((IDate(.strHS).AddDays(25)), pstrProbComtStack))
            Else
                pstrProbComtStack &= " #SRD5"
                .strHS = CodeCoverDate("9" & "26/01/2000 00:00:00")
            End If
            pstrProbComtStack &= " #SRD6"
            .strLTD = CodeCoverDate("1" & GreatDateStr((IDate(.strLTD).AddDays(-17)), pstrProbComtStack))
            pstrProbComtStack &= " #SRD7"
        End With

    End Sub
End Module
Friend Module Lock
    Private Function IDateJulToGreg(ByVal pstrJulDate As Long) As Date

        Dim lintDays As Integer
        Dim lintYear As Integer

        If Not IsNumericGet(pstrJulDate) Then
            IDateJulToGreg = Nothing '""
            Exit Function
        End If
        If pstrJulDate <= 0 Then
            IDateJulToGreg = Nothing '""
            Exit Function
        End If

        IDateJulToGreg = Nothing
        On Error Resume Next
        lintDays = pstrJulDate Mod 1000
        lintYear = (pstrJulDate - lintDays) / 1000

        IDateJulToGreg = IDate(DateSerialGet(lintYear, 1, lintDays))
        On Error GoTo 0

    End Function
    Private Function IDateGregToJul(ByVal pdatGregDate As Date) As Long

        Dim lintDays As Integer
        Dim lintYear As Integer

        If Not IsDateGet(pdatGregDate) Then
            IDateGregToJul = 0
            Exit Function
        End If

        On Error Resume Next
        lintYear = CInt(CStr(pdatGregDate))
        lintDays = DateDiffGet("d", IDate(FormatNumberGet(lintYear, "0000") & "/01/01"), pdatGregDate) + 1
        IDateGregToJul = FormatNumberGet(lintYear, "0000") & FormatNumberGet(lintDays, "000")
        On Error GoTo 0

    End Function
    Friend Function DeCodeCoverDate(ByVal pstrString As String) As String
        Dim lintArrInc As Integer
        Dim lstrM As String

        For lintArrInc = 1 To (pstrString).Length
            Select Case MidGet(pstrString, lintArrInc, 1)
                Case "X" : lstrM = "0"
                Case "S" : lstrM = "1"
                Case "G" : lstrM = "2"
                Case "H" : lstrM = "3"
                Case "R" : lstrM = "4"
                Case "W" : lstrM = "5"
                Case "P" : lstrM = "6"
                Case "A" : lstrM = "7"
                Case "K" : lstrM = "8"
                Case "L" : lstrM = "9"
                Case "D" : lstrM = " "
                Case "B" : lstrM = "/"
                Case "O" : lstrM = ":"
                    'Case "S" : lstrM = "."
                Case "Q" : lstrM = "."
                Case "J" : lstrM = "-"
            End Select
            DeCodeCoverDate = DeCodeCoverDate & lstrM
        Next lintArrInc

    End Function
    Friend Function CodeCoverDate(ByVal pstrString As String) As String
        Dim lintArrInc As Integer
        Dim lstrM As String

        For lintArrInc = 1 To (pstrString).Length
            Select Case MidGet(pstrString, lintArrInc, 1)
                Case "0" : lstrM = "X"
                Case "1" : lstrM = "S"
                Case "2" : lstrM = "G"
                Case "3" : lstrM = "H"
                Case "4" : lstrM = "R"
                Case "5" : lstrM = "W"
                Case "6" : lstrM = "P"
                Case "7" : lstrM = "A"
                Case "8" : lstrM = "K"
                Case "9" : lstrM = "L"
                Case " " : lstrM = "D"
                Case "/" : lstrM = "B"
                Case ":" : lstrM = "O"
                    'Case "." : lstrM = "S"
                Case "." : lstrM = "Q"
                Case "-" : lstrM = "J"
            End Select
            CodeCoverDate = CodeCoverDate & lstrM
        Next lintArrInc

    End Function
    Friend Function GD(ByVal pstrString As Date) As String
        GD = FormatDateTime(pstrString, DateFormat.GeneralDate)
    End Function
    Friend Function ID(ByVal pstrString As String, ByRef pstrProbComtStack As String) As Date

        pstrProbComtStack &= " #ID1-" & (pstrString).Length & "-" & pstrString

        Dim lstrDateBuild As String
        Select Case (pstrString).Length
            Case 10
                lstrDateBuild = LeftGet(pstrString, 3) & _
                    MonthNameUK(MidGet(pstrString, 4, 2), True) & _
                    RightGet(pstrString, 5)

                Dim nd As New Date(CInt(Microsoft.VisualBasic.Right(pstrString, 4)), _
                    CInt(Microsoft.VisualBasic.Mid(pstrString, 4, 2)), _
                    CInt(Microsoft.VisualBasic.Left(pstrString, 2)), 0, 0, 0, 0)

                ID = nd
                Exit Function

            Case 19
                If IsNumericGet(MidGet(pstrString, 1, 1)) And _
                    IsNumericGet(MidGet(pstrString, 2, 1)) And _
                    IsNumericGet(MidGet(pstrString, 3, 1)) And _
                    IsNumericGet(MidGet(pstrString, 4, 1)) And _
                    IsNumericGet(MidGet(pstrString, 5, 1)) = False Then

                    Dim nd As New Date(MidGet(pstrString, 1, 4), MidGet(pstrString, 6, 2), MidGet(pstrString, 9, 2), _
                        MidGet(pstrString, 12, 2), MidGet(pstrString, 15, 2), MidGet(pstrString, 18, 2))
                    ID = nd
                    Exit Function

                    lstrDateBuild = pstrString
                    lstrDateBuild = lstrDateBuild.Replace(".", ":")

                    pstrProbComtStack &= " #ID2-" & lstrDateBuild

                Else

                    pstrProbComtStack &= " #ID3 - " & pstrString

                    If MidGet(pstrString, 3, 1) = "1" And MidGet(pstrString, 3, 1) = "1" Then
                        pstrString = pstrString.Remove(2, 1)
                        pstrString = pstrString.Insert(2, "/")
                        pstrString = pstrString.Remove(5, 1)
                        pstrString = pstrString.Insert(5, "/")
                    End If

                    lstrDateBuild = LeftGet(pstrString, 3) & _
                        MonthNameUK(MidGet(pstrString, 4, 2), True) & _
                        RightGet(pstrString, 14)

                    Dim nd As New Date(MidGet(pstrString, 7, 4), MidGet(pstrString, 4, 2), MidGet(pstrString, 4, 2), _
                        MidGet(pstrString, 12, 2), MidGet(pstrString, 15, 2), MidGet(pstrString, 18, 2))
                    ID = nd
                    Exit Function


                End If
        End Select

        pstrProbComtStack &= " #ID4"

        Try
            ID = (IDate(CType(lstrDateBuild, Date)))
        Catch err As Exception
            Try
                ID = IDate(lstrDateBuild)
            Catch
                Throw err
            End Try
        End Try

        pstrProbComtStack &= " #ID5"

    End Function
    Friend Function UKDateStr(ByVal pstrString As Date, ByRef pstrProbComtStack As String) As String

        pstrProbComtStack &= " #UKDS1"
        UKDateStr = pstrString.ToString("dd/MM/yyyy HH:mm:ss")
        pstrProbComtStack &= " #UKDS2"
    End Function
    Friend Function GreatDateStr(ByVal pstrString As Date, ByRef pstrProbComtStack As String) As String
        pstrProbComtStack &= " #GDS1"

        GreatDateStr = pstrString.ToString("yyyy/MM/dd HH:mm:ss")

        pstrProbComtStack &= " #GDS2"
    End Function
End Module
Friend Class Fix
    Private mstrKey As String
    Private mstrText As String
    Friend Property KeyString() As String
        Get
            ' The Get property procedure is called when the value
            ' of a property is retrieved. 
            Return mstrKey
        End Get
        Set(ByVal Value As String)
            ' The Set property procedure is called when the value 
            ' of a property is modified. 
            ' The value to be assigned is passed in the argument to Set. 
            mstrKey = Value
            Initialize()
        End Set
    End Property
    Friend Property Text() As String
        Get
            ' The Get property procedure is called when the value
            ' of a property is retrieved. 
            Return mstrText
        End Get
        Set(ByVal Value As String)
            ' The Set property procedure is called when the value 
            ' of a property is modified. 
            ' The value to be assigned is passed in the argument to Set. 
            mstrText = Value

        End Set
    End Property
    '~~~.DoXor
    'Exclusive-or method to encrypt or decrypt
    Friend Sub DoXor()
        Dim lngC As Integer
        Dim intB As Integer
        Dim lngN As Integer
        For lngN = 1 To (mstrText).Length
            lngC = AscGet(MidGet(mstrText, lngN, 1))
            intB = 127

            Mid(mstrText, lngN, 1) = ChrGet(lngC Xor intB) 'VB Migr was Convert.ToChar
        Next lngN
    End Sub
    Friend Sub DoXorOld()
        Dim lngC As Integer
        Dim intB As Integer
        Dim lngN As Integer
        For lngN = 1 To (mstrText).Length
            lngC = AscGet(MidGet(mstrText, lngN, 1))
            intB = System.Math.Floor(Microsoft.VisualBasic.Rnd() * 256)
            Mid(mstrText, lngN, 1) = ChrGet(lngC Xor intB) 'VB Migr was Convert.ToChar
        Next lngN
    End Sub
    '~~~.Stretch
    'Convert any string to a printable, displayable string
    Friend Sub Stretch()
        Dim lngC As Integer
        Dim lngN As Integer
        Dim lngJ As Integer
        Dim lngK As Integer
        Dim lngA As Integer
        Dim strB As String
        lngA = (mstrText).Length
        strB = New String(" ", (lngA + (lngA + 2) \ 3))

        For lngN = 1 To lngA
            lngC = AscGet(MidGet(mstrText, lngN, 1))
            lngJ = lngJ + 1
            Mid(strB, lngJ, 1) = ChrGet((lngC And 63) + 59) 'VB Migr was Convert.ToChar
            Select Case lngN Mod 3
                Case 1
                    lngK = lngK Or ((lngC \ 64) * 16)
                Case 2
                    lngK = lngK Or ((lngC \ 64) * 4)
                Case 0
                    lngK = lngK Or (lngC \ 64)
                    lngJ = lngJ + 1
                    Mid(strB, lngJ, 1) = ChrGet(lngK + 59) 'VB Migr was Convert.ToChar
                    lngK = 0
            End Select
        Next lngN
        If lngA Mod 3 Then
            lngJ = lngJ + 1
            Mid(strB, lngJ, 1) = ChrGet(lngK + 59) 'VB Migr was Convert.ToChar
        End If
        mstrText = strB
    End Sub
    Friend Sub Shrink()
        Dim lngC As Integer
        Dim lngD As Integer
        Dim lngE As Integer
        Dim lngA As Integer
        Dim lngB As Integer
        Dim lngN As Integer
        Dim lngJ As Integer
        Dim lngK As Integer
        Dim strB As String
        If gstrDecryptProbTrace <> "" Then gstrDecryptProbTrace = " #DcShr1"

        lngA = (mstrText).Length
        lngB = lngA - 1 - (lngA - 1) \ 4
        strB = New String(" ", lngB)
        If gstrDecryptProbTrace <> "" Then gstrDecryptProbTrace = " #DcShr2"

        For lngN = 1 To lngB
            lngJ = lngJ + 1
            If gstrDecryptProbTrace <> "" Then gstrDecryptProbTrace = " #DcShr3"
            lngC = AscGet(MidGet(mstrText, lngJ, 1)) - 59
            Select Case lngN Mod 3
                Case 1
                    If gstrDecryptProbTrace <> "" Then gstrDecryptProbTrace = " #DcShr4"
                    lngK = lngK + 4
                    If lngK > lngA Then lngK = lngA
                    lngE = AscGet(MidGet(mstrText, lngK, 1)) - 59
                    lngD = ((lngE \ 16) And 3) * 64
                Case 2
                    lngD = ((lngE \ 4) And 3) * 64
                Case 0
                    lngD = (lngE And 3) * 64
                    lngJ = lngJ + 1
            End Select
            If gstrDecryptProbTrace <> "" Then gstrDecryptProbTrace = " #DcShr5"
            Mid(strB, lngN, 1) = ChrGet(lngC Or lngD)  'VB Migr was Convert.ToChar          
        Next lngN
        mstrText = strB
        If gstrDecryptProbTrace <> "" Then gstrDecryptProbTrace = " #DcShr6"
    End Sub
    'Initializes random numbers using the key string
    Private Sub Initialize()
        Dim lngN As Integer
        Microsoft.VisualBasic.Randomize(Microsoft.VisualBasic.Rnd(-1))
        For lngN = 1 To mstrKey.Length
            Microsoft.VisualBasic.Randomize(Microsoft.VisualBasic.Rnd(-Microsoft.VisualBasic.Rnd() * AscGet(MidGet(mstrKey, lngN, 1))))
        Next lngN
    End Sub
End Class