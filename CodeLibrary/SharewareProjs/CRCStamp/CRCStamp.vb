Imports System.IO
Module CRCStamp
    Sub Main()
        Main(Environment.GetCommandLineArgs())
    End Sub

    Private Sub Main(ByVal args() As String)
        Dim lstrInputFile As String
        Dim lstrTestFile As String = ""

        If args Is Nothing OrElse args.Length > 6 Then

            Console.WriteLine("CRCSTAMP: Invalid argurments....")
        Else
Start:
            On Error Resume Next
            lstrInputFile = args(1)
            lstrTestFile = args(2) 
            On Error GoTo 0

            If lstrTestFile = "" Then lstrTestFile = lstrInputFile 

            Dim lCrc32Value As Integer
            'On Error Resume Next
            'Dim FileStr As String
            'Dim lintFreeFile As Short = FreeFile()
            Dim llngFileLength As Integer
            Dim llngRestartCounter As Long
            Dim lstrCRCOutPut As String

            If lstrInputFile = "" Then
                Console.WriteLine("CRCSTAMP: No file specified... Exit...")
                Exit Sub
            End If


            
            lstrCRCOutPut = lstrInputFile & ".CRC.exe"
            File.Copy(lstrInputFile, lstrCRCOutPut, True)

            ''''Dim FullFile As String = GetFirstPartOfFile(lstrCRCOutPut, True)
            '''Dim FullFile As String = GetFirstPartOfFile(lstrTestFile, True) 'this is looking at the test file which has been pre strong named

            '''Sleep(2)
            ''''---- add crc block to file ----
            '''lCrc32Value = InitCrc32()
            '''lCrc32Value = AddCrc32(FullFile, lCrc32Value)

            '''Dim RealCRC As String
            '''RealCRC = CStr(Hex$(GetCrc32(lCrc32Value)))


            
            Dim FullFile As String = lstrTestFile
            Dim c As New CRC32()
            Dim crc As Integer = 0
            Dim f As FileStream = New FileStream(FullFile, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
            crc = c.GetCrc32(f, True) 'used with full file param
            f.Close()
            Dim RealCRC As String = String.Format("{0:X8}", crc)
            

            'Debug.WriteLine(RealCRC)
            llngFileLength = FileLen(lstrCRCOutPut)

            Dim lintFreeFile2 As Integer = FreeFile()
            FileOpen(lintFreeFile2, lstrCRCOutPut, OpenMode.Binary, OpenAccess.Write, OpenShare.LockWrite)
            FilePut(lintFreeFile2, RealCRC, llngFileLength + 1)
            'FilePut(lintFreeFile2, RealCRC, llngFileLength)
            FileClose()
            '---- add crc block to file ----

            ''---- check to see if written correctly ----
            ''GetWritteCRC = 1 = OK
            'If GetWrittenCRC(lstrCRCOutPut, lstrTestFile) <> 1 Then
            '    'fail
            '    If llngRestartCounter < 50 Then
            '        GoTo start
            '        llngRestartCounter = llngRestartCounter + 1
            '    End If
            'Else
            File.Copy(lstrCRCOutPut, lstrInputFile, True)
            File.Delete(lstrCRCOutPut)
            If lstrTestFile <> lstrInputFile Then 
                File.Delete(lstrTestFile)
            End If
            '    If llngRestartCounter = 0 Then
            Console.WriteLine("CRCSTAMP: File (" & lstrInputFile & ", CRC=" & RealCRC & ") Stamped OK! ")
            '    Else
            '        Console.WriteLine("CRCSTAMP: File (" & lstrInputFile & ", CRC=" & RealCRC & ") OK! Attempts=" & llngRestartCounter)
            '    End If
            'End If
            '' ---- check to see if written correctly ----
            End If
    End Sub
    Sub Sleep(ByVal Seconds As Long)
        Dim Start As DateTime = Date.Now

        While Not DateDiff(DateInterval.Second, Start, Date.Now) >= Seconds
            ' do nothing 
        End While


    End Sub
    

End Module
