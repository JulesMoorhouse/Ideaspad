Imports System.IO
Imports Microsoft.VisualBasic
Friend Module EveryApp
    Friend Function AreDLLsPresent() As Boolean
        AreDLLsPresent = True
        Try
            Dim ev As System.Security.Policy.Evidence = System.AppDomain.CurrentDomain.Evidence
            Dim ads As System.AppDomainSetup = System.AppDomain.CurrentDomain.SetupInformation
            Dim ad As System.AppDomain = System.AppDomain.CreateDomain("Error Domain", ev, ads)
            Dim names As System.Reflection.AssemblyName() = System.Reflection.Assembly.GetCallingAssembly().GetReferencedAssemblies()
            Dim an As System.Reflection.AssemblyName
            Dim fvi As System.Diagnostics.FileVersionInfo
            Dim str As String
            Dim x() As String
            For Each an In names
                Try
                    Dim assem As System.Reflection.Assembly = ad.Load(an)

                    fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assem.Location)
                Catch ex As System.IO.IOException
                    AreDLLsPresent = False
                    Exit For
                    'mxessagebox.show(an.FullName)
                End Try
                'If Application.StartupPath.ToUpper = Microsoft.VisualBasic.Mid(fvi.FileName, 1, Application.StartupPath.Length).ToUpper Then
                '    If System.IO.File.Exists(fvi.FileName) = False Then
                '        AreDLLsPresent = False
                '        Exit For
                '    End If
                'End If
                'Console.WriteLine(fvi.OriginalFilename)
            Next an ' fvi.FileName;
            ' fvi.FileVersion;
            ' an.Version.ToString();
            System.AppDomain.Unload(ad)
        Catch
        End Try

    End Function
    Friend Function EssentialFileCheck(ByVal pstrFileArr() As String, ByVal pstrPath As String) As Boolean

        Dim lstrAllFiles(0) As String
        EssProcessDirectory(pstrPath, lstrAllFiles, pstrPath & "\")

        EssentialFileCheck = True
        Dim lintArrInc, lintArrInc2 As Integer
        For lintArrInc = 0 To pstrFileArr.GetUpperBound(0)
            Dim lbooFoundEssFile As Boolean = False
            For lintArrInc2 = 0 To lstrAllFiles.GetUpperBound(0)
                If lstrAllFiles(lintArrInc2).ToUpper = pstrFileArr(lintArrInc).ToUpper Then
                    'Console.WriteLine("found " & lstrAllFiles(lintArrInc2))
                    lbooFoundEssFile = True
                    Exit For
                End If
            Next
            If lbooFoundEssFile = False Then
#If Debug Then 
                MessageBox.Show("missing " & pstrFileArr(lintArrInc)) 
#End If

                EssentialFileCheck = False
                Exit For
            End If
        Next lintArrInc

    End Function
    Private Sub EssProcessDirectory(ByVal targetDirectory As String, ByRef AllFiles() As String, ByVal StartPath As String)

        Dim fileEntries As String() = Directory.GetFiles(targetDirectory)

        Dim fileName As String
        For Each fileName In fileEntries
            EssProcessFile(fileName, AllFiles, StartPath)

        Next fileName
        Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)

        Dim subdirectory As String
        For Each subdirectory In subdirectoryEntries
            EssProcessDirectory(subdirectory, AllFiles, StartPath)
        Next subdirectory

    End Sub
    Private Sub EssProcessFile(ByVal path As String, ByRef AllFiles() As String, ByVal StartPath As String)

        If AllFiles(0) <> "" Then
            ReDim Preserve AllFiles(AllFiles.GetUpperBound(0) + 1)
        End If
        AllFiles(AllFiles.GetUpperBound(0)) = path.Replace(StartPath, "")
    End Sub

    Friend Function IDate(ByVal pstrDate As String) As Date

        Dim RetVal As Date

        Try
            IDate = DateTime.Parse(pstrDate)
        Catch err As Exception

            Try
                Dim strRegionalDateFormat As String = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FullDateTimePattern.ToString
                Dim dFormat As New System.Globalization.DateTimeFormatInfo
                dFormat.FullDateTimePattern = strRegionalDateFormat
                IDate = DateTime.ParseExact(pstrDate, strRegionalDateFormat, dFormat)

            Catch
                Throw err
            End Try
        End Try

    End Function
    Friend Function IDate(ByVal pDate As Date) As Date

        Return pDate

    End Function
End Module
Friend Module CRC
    Friend Function StringR(ByVal repetitions As Integer, ByVal myCharacter As Char) As String

        Dim result As String
        result = ""
        StringR = result.PadLeft(repetitions, myCharacter)

    End Function
    Friend Function GetLast8Digs(ByVal pstrFile As String) As String

        Dim myStream = New System.IO.FileStream(pstrFile, IO.FileMode.Open, FileAccess.Read, FileShare.Read)
        Dim MyReader = New System.IO.BinaryReader(myStream)
        Dim bytes(myStream.Length) As Char
        MyReader.BaseStream.Position = MyReader.BaseStream.Seek(-8, IO.SeekOrigin.End)
        bytes = MyReader.ReadChars(8)
        MyReader.close()
        myStream.close()

        Return bytes

    End Function

    Friend Function GetWrittenCRC(ByVal pstrFileToCheck As String) As Integer
        'Returns:
        '  -1   =   No CRC found at the end of the file :-/
        '  -2   =   File CRC and Real CRC dont match :-/
        '  1    =   Both CRCs match - file is ok! :-)
        Dim lCrc32Value As Integer

        On Error Resume Next
        Dim Last8Digs As String = GetLast8Digs(pstrFileToCheck)

        Dim c As New CRC32
        Dim crc As Integer = 0
        Dim f As FileStream = New FileStream(pstrFileToCheck, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        crc = c.GetCrc32(f, False)
        f.Close()
        Dim RealCRC As String = String.Format("{0:X8}", crc)

        If RealCRC <> Last8Digs Or (Last8Digs).Trim = "" Or (Last8Digs).Trim = StringR(8, ChrGet(0)) Then
            GetWrittenCRC = -2
            Exit Function
        Else
            GetWrittenCRC = 1
            Exit Function
        End If

    End Function
End Module
Friend Class CRC32

    Private crc32Table() As Integer
    Private Const BUFFER_SIZE As Integer = 1024

    Friend Function GetCrc32(ByRef stream As System.IO.Stream, Optional ByVal pbooGetAll As Boolean = False) As Integer

        Dim Restrict As Integer = 9 '7 '8
        If pbooGetAll = True Then
            Restrict = 0
        End If

        Dim RequiredLength As Long = stream.Length() - Restrict

        Dim crc32Result As Integer
        crc32Result = &HFFFFFFFF

        Dim buffer(BUFFER_SIZE) As Byte
        Dim readSize As Integer = BUFFER_SIZE

        Dim count As Integer = stream.Read(buffer, 0, readSize)
        Dim i As Integer
        Dim iLookup As Integer
        Dim tot As Integer = 0
        Dim lintCtr As Integer = -1
        Do While (count > 0)
            For i = 0 To count - 1
                iLookup = (crc32Result And &HFF) Xor buffer(i)
                crc32Result = ((crc32Result And &HFFFFFF00) \ &H100) And &HFFFFFF   ' nasty shr 8 with vb :/
                crc32Result = crc32Result Xor crc32Table(iLookup)
                lintCtr += 1
                If lintCtr >= RequiredLength Then
                    Exit Do
                End If
            Next i
            count = stream.Read(buffer, 0, readSize)
        Loop

        GetCrc32 = Not (crc32Result)

    End Function

    Friend Sub New()

        ' This is the official polynomial used by CRC32 in PKZip.
        ' Often the polynomial is shown reversed (04C11DB7).
        Dim dwPolynomial As Integer = &HEDB88320
        Dim i As Integer, j As Integer

        ReDim crc32Table(256)
        Dim dwCrc As Integer

        For i = 0 To 255
            dwCrc = i
            For j = 8 To 1 Step -1
                If (dwCrc And 1) Then
                    dwCrc = ((dwCrc And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                    dwCrc = dwCrc Xor dwPolynomial
                Else
                    dwCrc = ((dwCrc And &HFFFFFFFE) \ 2&) And &H7FFFFFFF
                End If
            Next j
            crc32Table(i) = dwCrc
        Next i
    End Sub

End Class
