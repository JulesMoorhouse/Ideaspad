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
                'MessageBox.Show("missing " & pstrFileArr(lintArrInc))
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
    Function BrowseToUrl(ByVal pstrURL As String, ByVal pme As Form) As Boolean
        'Created
        BrowseToUrl = False

        If Not pme Is Nothing Then 
            Busy(pme, True)
        End If

        Try
            Dim htmlFile As String = System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".html"
            If System.IO.File.Exists(htmlFile) = False Then
                File.CreateText(htmlFile)
            End If
            Dim fa As New WinOnly.FindApp()
            Dim strBrowser As String = fa.FindAssociatedApplication(htmlFile)
            'MsgBox(strBrowser)
            Dim psInfo As New System.Diagnostics.ProcessStartInfo(strBrowser, pstrURL)
            psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
            psInfo.CreateNoWindow = True
            Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.Start(psInfo)
            BrowseToUrl = True
            myProcess = Nothing
            
        Catch
            Try
                Dim psInfo As New System.Diagnostics.ProcessStartInfo("IEXPLORE", pstrURL)
                psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
                psInfo.CreateNoWindow = True
                Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.Start(psInfo)
                BrowseToUrl = True
                myProcess = Nothing 
            Catch
                Try
                    Dim psInfo As New System.Diagnostics.ProcessStartInfo(pstrURL)
                    psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
                    psInfo.CreateNoWindow = True
                    Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.Start(psInfo)
                    BrowseToUrl = True
                    myProcess = Nothing
                Catch
                    Dim iexp As Object
                    iexp = Microsoft.VisualBasic.CreateObject("InternetExplorer.application")
                    If Not (iexp Is Nothing) Then ' you want an error!!
                        iexp.Navigate(pstrURL)
                        iexp.Application.Visible = True
                        iexp = Nothing
                        BrowseToUrl = True
                    End If
                End Try

            End Try
        End Try 

        If Not pme Is Nothing Then 
            Busy(pme, False)
        End If

    End Function
    Friend Function IDate(ByVal pstrDate As String) As Date
        'added 'replacement for CDate

        Dim RetVal As Date

        Try
            IDate = DateTime.Parse(pstrDate)
        Catch err As Exception

            
            Try
                Dim strRegionalDateFormat As String = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FullDateTimePattern.ToString
                Dim dFormat As New System.Globalization.DateTimeFormatInfo()
                dFormat.FullDateTimePattern = strRegionalDateFormat
                IDate = DateTime.ParseExact(pstrDate, strRegionalDateFormat, dFormat)

            Catch
                AddDebugComment("IDate-Err: #" & pstrDate & "#")
                Throw err
            End Try
            
        End Try

    End Function
    Friend Function IDate(ByVal pDate As Date) As Date
        'added 
        Return pDate

    End Function
End Module
Friend Module CRC

    '''Friend Crc32Table(255) As Integer
    ''''// Then all we have to do is writing public functions like these...
    '''Friend Function InitCrc32(Optional ByVal Seed As Integer = &HEDB88320, Optional ByVal Precondition As Integer = &HFFFFFFFF) As Integer
    '''    '// Declare counter variable iBytes, counter variable iBits, value variables lCrc32 and lTempCrc32
    '''    Dim iBytes As Short, iBits As Short, lCrc32 As Integer, lTempCrc32 As Integer
    '''    '// Turn on error trapping
    '''    On Error Resume Next
    '''    '// Iterate 256 times

    '''    For iBytes = 0 To 255
    '''        '// Initiate lCrc32 to counter variable
    '''        lCrc32 = iBytes
    '''        '// Now iterate through each bit in counter byte


    '''        For iBits = 0 To 7
    '''            '// Right shift unsigned integer 1 bit
    '''            lTempCrc32 = lCrc32 And &HFFFFFFFE
    '''            lTempCrc32 = lTempCrc32 \ &H2
    '''            lTempCrc32 = lTempCrc32 And &H7FFFFFFF
    '''            '// Now check if temporary is less than zero and then mix Crc32 checksum with Seed value


    '''            If (lCrc32 And &H1) <> 0 Then
    '''                lCrc32 = lTempCrc32 Xor Seed
    '''            Else
    '''                lCrc32 = lTempCrc32
    '''            End If
    '''        Next
    '''        '// Put Crc32 checksum value in the holding array
    '''        Crc32Table(iBytes) = lCrc32
    '''    Next
    '''    '// After this is done, set function value to the precondition value
    '''    InitCrc32 = Precondition
    '''End Function
    ''''// The function above is the initializing function, now we have to write the computation function
    '''Friend Function AddCrc32(ByVal Item As String, ByVal CRC32 As Integer) As Integer
    '''    '// Declare following variables
    '''    Dim bCharValue As Byte, lIndex As Integer
    '''    Dim lAccValue As Integer, lTableValue As Integer
    '''    'dim iCounter As Short 
    '''    Dim iCounter As Long 
    '''    '// Turn on error trapping
    '''    'On Error Resume Next
    '''    '// Iterate through the string that is to be checksum-computed


    '''    For iCounter = 1 To Item.Length 
    '''        '// Get ASCII value for the current character
    '''        'bCharValue = AscGet(MidGet(Item, iCounter, 1))
    '''        'tried to see if would be faster
    '''        bCharValue = Asc(Mid(Item, iCounter, 1))
    '''        '// Right shift an Unsigned integer 8 bits
    '''        lAccValue = CRC32 And &HFFFFFF00
    '''        lAccValue = lAccValue \ &H100
    '''        lAccValue = lAccValue And &HFFFFFF
    '''        '// Now select the right adding value from the holding table
    '''        lIndex = CRC32 And &HFF
    '''        lIndex = lIndex Xor bCharValue
    '''        lTableValue = Crc32Table(lIndex)
    '''        '// Then mix new Crc32 value with previous accumulated Crc32 value
    '''        CRC32 = lAccValue Xor lTableValue
    '''    Next
    '''    '// Set function value the the new Crc32 checksum
    '''    AddCrc32 = CRC32
    '''End Function
    ''''// At last, we have to write a function so that we can get the Crc32 checksum value at any time
    '''Friend Function GetCrc32(ByVal CRC32 As Integer) As Integer
    '''    '// Turn on error trapping
    '''    On Error Resume Next
    '''    '// Set function to the current Crc32 value
    '''    GetCrc32 = CRC32 Xor &HFFFFFFFF
    '''End Function
    ''''// To Test the Routines Above...
    '''Friend Function Compute(ByVal ToGet As String) As String
    '''    Dim lCrc32Value As Integer
    '''    On Error Resume Next
    '''    lCrc32Value = InitCrc32()
    '''    lCrc32Value = AddCrc32(ToGet, lCrc32Value)
    '''    Compute = Microsoft.VisualBasic.Hex$(GetCrc32(lCrc32Value))
    '''End Function
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
    ''Function GetFirstPartOfFile(ByVal pstrFileName As String, Optional ByVal pbooGetAll As Boolean = False) As String



    ''    Dim Restrict As Integer = 8
    ''    If pbooGetAll = True Then
    ''        Restrict = 0
    ''    End If

    ''    Dim BR As New BinaryReader(File.OpenRead(pstrFileName), System.Text.Encoding.UTF8)
    ''    Dim FileLength As Long = New FileInfo(pstrFileName).Length - Restrict
    ''    Dim Bytes0() As Byte = BR.ReadBytes(FileLength)
    ''    'Dim DataString As String = System.Text.Encoding.UTF8.GetString(Bytes0)
    ''    ''Return ReadString(BR, FileLength)
    ''    'Dim Bytes0(Convert.ToInt32((FileLength - 1) - Restrict)) As Byte
    ''    'BR.Read(Bytes0, 0, Bytes0.Length - Restrict)
    ''    BR.Close()
    ''    'Return BitConverter.ToString(Bytes0)
    ''    Return System.Text.Encoding.UTF8.GetString(Bytes0)

    ''    'THIS DOES RETURN SOMETHING!!!!!!
    ''    



    ''End Function
    'Private Function ReadString(ByVal reader As BinaryReader, ByVal length As Integer) As String
    '    Dim chars(length - 1) As Char
    '    Dim i As Integer

    '    For i = 0 To length - 1
    '        chars(i) = ChrW(reader.ReadByte())
    '    Next

    '    Return New String(chars)
    'End Function

    Friend Function GetWrittenCRC(ByVal pstrFileToCheck As String) As Integer
        'Returns:
        '  -1   =   No CRC found at the end of the file :-/
        '  -2   =   File CRC and Real CRC dont match :-/
        '  1    =   Both CRCs match - file is ok! :-)
        Dim lCrc32Value As Integer

        On Error Resume Next
        Dim Last8Digs As String = GetLast8Digs(pstrFileToCheck)

        '''Dim FileWithoutLast8Digs As String = GetFirstPartOfFile(pstrFileToCheck)

        '''If (Last8Digs).Trim = "" Or (Last8Digs).Trim = StringR(8, ChrGet(0)) Then
        '''    GetWrittenCRC = -1
        '''    Exit Function
        '''End If

        ''''--- compare the two codes ---
        '''lCrc32Value = InitCrc32()

        '''lCrc32Value = AddCrc32(FileWithoutLast8Digs, lCrc32Value)

        '''Dim RealCRC As String
        '''RealCRC = CStr(Microsoft.VisualBasic.Hex(GetCrc32(lCrc32Value)))

        'Console.WriteLine("RealCRC=" & RealCRC & " Last8Digs=" & Last8Digs)


        
        Dim c As New CRC32()
        Dim crc As Integer = 0
        Dim f As FileStream = New FileStream(pstrFileToCheck, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        crc = c.GetCrc32(f, False)
        f.Close()
        Dim RealCRC As String = String.Format("{0:X8}", crc)
        ''MessageBox.Show("RealCRC=" & RealCRC & " Last8Digs=" & Last8Digs) 'For Testing Purposes ONLY
        

        If RealCRC <> Last8Digs Or (Last8Digs).Trim = "" Or (Last8Digs).Trim = StringR(8, ChrGet(0)) Then
            'mxessagebox.show("Real CRC=" & RealCRC & Environment.NewLine & "File CRC=" & Last8Digs, "CRC32 Results for " & pstrFileToCheck)
            GetWrittenCRC = -2
            Exit Function
        Else
            GetWrittenCRC = 1
            Exit Function
        End If
        '--- compare the two codes ---

    End Function


End Module
Friend Class CRC32 'added 

    ' This is v2 of the VB CRC32 algorithm provided by Paul
    ' (wpsjr1@succeed.net) - much quicker than the nasty
    ' original version I posted.  Excellent work!

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

        'MessageBox.Show(lintCtr & " " & RequiredLength)'testing purposes
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
