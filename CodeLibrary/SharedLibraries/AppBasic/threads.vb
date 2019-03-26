Imports System
Imports System.IO
Module threads
    'Private Crc32Table(255) As Integer
    'Friend Function InitCrc32(Optional ByVal Seed As Integer = &HEDB88320, Optional ByVal Precondition As Integer = &HFFFFFFFF) As Integer
    '    '// Declare counter variable iBytes, counter variable iBits, value variables lCrc32 and lTempCrc32
    '    Dim iBytes As Short, iBits As Short, lCrc32 As Integer, lTempCrc32 As Integer
    '    '// Turn on error trapping
    '    On Error Resume Next
    '    '// Iterate 256 times

    '    For iBytes = 0 To 255
    '        '// Initiate lCrc32 to counter variable
    '        lCrc32 = iBytes
    '        '// Now iterate through each bit in counter byte


    '        For iBits = 0 To 7
    '            '// Right shift unsigned integer 1 bit
    '            lTempCrc32 = lCrc32 And &HFFFFFFFE
    '            lTempCrc32 = lTempCrc32 \ &H2
    '            lTempCrc32 = lTempCrc32 And &H7FFFFFFF
    '            '// Now check if temporary is less than zero and then mix Crc32 checksum with Seed value


    '            If (lCrc32 And &H1) <> 0 Then
    '                lCrc32 = lTempCrc32 Xor Seed
    '            Else
    '                lCrc32 = lTempCrc32
    '            End If
    '        Next
    '        '// Put Crc32 checksum value in the holding array
    '        Crc32Table(iBytes) = lCrc32
    '    Next
    '    '// After this is done, set function value to the precondition value
    '    InitCrc32 = Precondition
    'End Function
    ''// The function above is the initializing function, now we have to write the computation function
    'Friend Function AddCrc32(ByVal Item As String, ByVal CRC32 As Integer) As Integer
    '    '// Declare following variables
    '    Dim bCharValue As Byte, iCounter As Short, lIndex As Integer
    '    Dim lAccValue As Integer, lTableValue As Integer
    '    '// Turn on error trapping
    '    On Error Resume Next
    '    '// Iterate through the string that is to be checksum-computed


    '    For iCounter = 1 To (Item).Length
    '        '// Get ASCII value for the current character
    '        bCharValue = AscGet(MidGet(Item, iCounter, 1))
    '        '// Right shift an Unsigned integer 8 bits
    '        lAccValue = CRC32 And &HFFFFFF00
    '        lAccValue = lAccValue \ &H100
    '        lAccValue = lAccValue And &HFFFFFF
    '        '// Now select the right adding value from the holding table
    '        lIndex = CRC32 And &HFF
    '        lIndex = lIndex Xor bCharValue
    '        lTableValue = Crc32Table(lIndex)
    '        '// Then mix new Crc32 value with previous accumulated Crc32 value
    '        CRC32 = lAccValue Xor lTableValue
    '    Next
    '    '// Set function value the the new Crc32 checksum
    '    AddCrc32 = CRC32
    'End Function
    ''// At last, we have to write a function so that we can get the Crc32 checksum value at any time
    'Friend Function GetCrc32(ByVal CRC32 As Integer) As Integer
    '    '// Turn on error trapping
    '    On Error Resume Next
    '    '// Set function to the current Crc32 value
    '    GetCrc32 = CRC32 Xor &HFFFFFFFF
    'End Function
    ''// To Test the Routines Above...
    'Friend Function Compute(ByVal ToGet As String) As String
    '    Dim lCrc32Value As Integer
    '    On Error Resume Next
    '    lCrc32Value = InitCrc32()
    '    lCrc32Value = AddCrc32(ToGet, lCrc32Value)
    '    Compute = HexGet(GetCrc32(lCrc32Value))
    'End Function
    Friend Function AppExe() As String
        On Error Resume Next
        Dim AP As String
        AP = Application.ExecutablePath
        If RightGet(AP, 1) <> "\" Then AP = AP & "\"
        '''AppExe = AP & App.EXEName & ".exe"
        'needs to be the actul assembly which is calling it.
        AppExe = System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()


    End Function
    '<VBFixedString(8), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=8)> Dim CRCStr As String
    'Friend Function SetTopicTree() As Integer
    '    'Returns:
    '    '  -1   =   No CRC found at the end of the file :-/
    '    '  -2   =   File CRC and Real CRC dont match :-/
    '    '  1    =   Both CRCs match - file is ok! :-)
    '    Dim lCrc32Value As Integer
    '    '''Dim CRCStr As String * 8
    '    'Dim CRCStr As String = Space(8)
    '    'CRCStr = "        "


    '    On Error Resume Next


    '    Dim FileStr As String
    '    Dim CRCStr As String
    '    'Dim lintFreeFile As Short = FreeFile()
    '    'FileStr$ = Space(FileLen(AppExe) - 8)
    '    'CRCStr = Space(8)
    '    'FileOpen(lintFreeFile, AppExe, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
    '    'Do Until EOF(lintFreeFile)
    '    'FileGet(lintFreeFile, FileStr$)
    '    'FileGet(lintFreeFile, CRCStr)
    '    'Loop
    '    'FileClose()

    '    'Dim OpenFile As FileStream = New FileStream(AppExe, FileMode.Open, FileAccess.Read, FileShare.Read)
    '    'Dim sr As StreamReader = New StreamReader(OpenFile)
    '    ''FileStr = sr.ReadToEnd()
    '    'FileStr = sr.ReadToEnd()
    '    'FileStr = LeftGet(FileStr, FileStr.Length - 8)
    '    'sr.Close()
    '    'OpenFile.Close()

    '    Dim BR As New BinaryReader(File.OpenRead(AppExe))
    '    Dim FileLength As Long = New FileInfo(AppExe).Length
    '    Dim Bytes0() As Byte = BR.ReadBytes(FileLength)
    '    'Dim DataString As String = (Bytes0).GetValue
    '    'Dim DataString As String = System.Text.Encoding.UTF8.GetString(Bytes0)
    '    Dim DataString As String = System.Text.Encoding.UTF8.GetString(Bytes0)
    '    'FileStr = DataString
    '    FileStr = LeftGet(DataString, DataString.Length - 8)
    '    BR.Close()

    '    Dim myStream = New System.IO.FileStream(AppExe, IO.FileMode.Open, FileAccess.Read, FileShare.Read)
    '    Dim MyReader = New System.IO.BinaryReader(myStream)
    '    ' Dim sData As String
    '    Dim bytes(myStream.Length) As Char
    '    MyReader.BaseStream.Position = MyReader.BaseStream.Seek(-8, IO.SeekOrigin.End)
    '    bytes = MyReader.ReadChars(8)
    '    CRCStr = (bytes)
    '    myStream.close()

    '    If (CRCStr).Trim = "" Or (CRCStr).Trim = StringR(8, ChrGet(0)) Then
    '        SetTopicTree = -1
    '        Exit Function
    '    End If
    '    lCrc32Value = InitCrc32()
    '    lCrc32Value = AddCrc32(FileStr$, lCrc32Value)

    '    Dim RealCRC As String
    '    RealCRC = CStr(HexGet(GetCrc32(lCrc32Value)))
    '    'MxessageBox.Show("Real CRC=" & RealCRC & Environment.NewLine & "File CRC=" & CRCStr, "CRC32 Results for " & AppExe())
    '    If RealCRC <> CRCStr Or (CRCStr).Trim = "" Or (CRCStr).Trim = StringR(8, ChrGet(0)) Then
    '        SetTopicTree = -2
    '        Exit Function
    '    Else
    '        SetTopicTree = 1
    '        Exit Function
    '    End If

    'End Function
    'Function StringR(ByVal repetitions As Integer, ByVal myCharacter As Char) As String

    '    Dim result As String

    '    result = ""
    '    StringR = result.PadLeft(repetitions, myCharacter)

    'End Function

    Function Decrypt(ByRef pstrInp() As String, Optional ByVal BugWork As Integer = 0) As String
        Dim strHead As String
        Dim strA As String
        Dim strT As String
        Dim cphX As New Fix() 'clsCipher()

        strHead = pstrInp(0)
        'MessageBox.Show(strHead, "Decrpyt 1")
        strT = MidGet(strHead, 9, 8)
        'MessageBox.Show(strT, "Decrpyt 2")

        Dim lintArrInc As Integer
        For lintArrInc = 1 To pstrInp.GetUpperBound(0)
            strA = strA & pstrInp(lintArrInc)
        Next lintArrInc

        'MessageBox.Show(strA, "Decrpyt 3")

        'Decrypted file contents
        cphX.KeyString = strHead
        cphX.Text = strA
        cphX.Shrink()
        
        If BugWork = 1 Then
            cphX.DoXorOld()
        Else
            cphX.DoXor()
        End If
        
        strA = cphX.Text

        'MessageBox.Show(strA, "Decrpyt 4")

        'Decrypt = strA 
        Decrypt = LeftGet(strA, strA.Length - 1)
        'Console.WriteLine(Decrypt)
        'MessageBox.Show(Decrypt, "Decrpyt 5")

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
            'intB = System.Math.Floor(Microsoft.VisualBasic.Rnd() * 256)
            intB = 127 
            'RND now works in Fx 1.1

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
        'strB = Space(lngA + (lngA + 2) \ 3)
        'strB.PadLeft((lngA + (lngA + 2) \ 3), " ")
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
    '~~~.Shrink
    'Inverse of the Stretch method;
    'result can contain any of the 256-byte values
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
        lngA = (mstrText).Length
        lngB = lngA - 1 - (lngA - 1) \ 4
        'strB.PadLeft(lngB, " ")
        strB = New String(" ", lngB)

        For lngN = 1 To lngB
            lngJ = lngJ + 1
            lngC = AscGet(MidGet(mstrText, lngJ, 1)) - 59
            Select Case lngN Mod 3
                Case 1
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
            Mid(strB, lngN, 1) = ChrGet(lngC Or lngD)  'VB Migr was Convert.ToChar          
        Next lngN
        mstrText = strB
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
