Imports System.IO
Imports System.Windows.Forms
Imports ICSharpCode.SharpZipLib.Zip
Imports ICSharpCode.SharpZipLib.Checksums
Imports ICSharpCode.SharpZipLib.GZip

Module ZipToSelfEx
    Sub Main()
        Main(Environment.GetCommandLineArgs())
    End Sub
    Private Sub Main(ByVal args() As String)
        'Dim lstrSourceZipWithPath As String
        Dim lstrVerSourceExeWithPath As String
        Dim lstrDestFilePrefix5Chars As String
        Dim lstrDestPath As String
        Dim lstrZipSourcePath As String

        If args Is Nothing OrElse args.Length > 5 Then
            Console.WriteLine("Zip2SelfEx: Invalid argurments....")
        Else
            On Error Resume Next

            lstrVerSourceExeWithPath = args(1)
            lstrDestFilePrefix5Chars = args(2)
            lstrZipSourcePath = args(3)
            lstrDestPath = args(4) 'e.g. c:\temp\  including \

            'Dim lintArrInc As Integer
            'For lintArrInc = 1 To 4
            '    Console.WriteLine("Arg(" & lintArrInc & ") =" & args(lintArrInc))
            'Next lintArrInc
            'MsgBox("Pause")

            If Right(lstrDestPath, 1) = Chr(34) Then
                lstrDestPath = Left(lstrDestPath, Len(lstrDestPath) - 1)
                lstrDestPath &= "\"
            End If
            If Right(lstrZipSourcePath, 1) = Chr(34) Then
                lstrZipSourcePath = Left(lstrZipSourcePath, Len(lstrZipSourcePath) - 1)
                lstrZipSourcePath &= "\"
            End If
            On Error GoTo 0
            Dim lVersionSourceExeWithPathInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(lstrVerSourceExeWithPath)
            Dim lstr3Chars As String

            lstr3Chars = lVersionSourceExeWithPathInfo.FileMajorPart & _
                lVersionSourceExeWithPathInfo.FileMinorPart & _
                lVersionSourceExeWithPathInfo.FileBuildPart

            'Dim lstrZipFileAndPath As String = lstrDestPath & "temp\" & lstrDestFilePrefix5Chars & lstr3Chars
            ' Dim lstrZipFileAndPath As String = lstrZipSourcePath & lstrDestFilePrefix5Chars & lstr3Chars

            Dim psInfo As New System.Diagnostics.ProcessStartInfo("wzzip.exe", _
                lstrZipSourcePath & "temp\" & lstrDestFilePrefix5Chars & lstr3Chars & ".zip " & _
                lstrZipSourcePath & "\*.*")
            Dim myProcess As Process = System.Diagnostics.Process.Start(psInfo)
            myProcess.WaitForExit(40000) '40 seconds

            If File.Exists(lstrZipSourcePath & "temp\" & lstrDestFilePrefix5Chars & lstr3Chars & ".zip") Then
                Console.WriteLine("Zip2SelfEx: zip file created")
            End If
            'copy old zip file to name with version nums
            'then pass to sub to create exe
            File.Delete(lstrZipSourcePath & "temp\" & lstrDestFilePrefix5Chars & lstr3Chars & ".exe") 'just incase this is a re-build of the same version number
            SpawnAndMakeSelfEx(lstrZipSourcePath & "temp\" & lstrDestFilePrefix5Chars & lstr3Chars & ".zip")

            MessageBox.Show("Press any key once Self Extrator is built OK!")

            If File.Exists(lstrZipSourcePath & "temp\" & lstrDestFilePrefix5Chars & lstr3Chars & ".exe") Then
                Console.WriteLine("Zip2SelfEx: Success")
            End If

            File.Delete(lstrDestPath & lstrDestFilePrefix5Chars & lstr3Chars & ".exe") 'just incase this is a re-build of the same version number
            File.Copy(lstrZipSourcePath & "temp\" & lstrDestFilePrefix5Chars & lstr3Chars & ".exe", lstrDestPath & lstrDestFilePrefix5Chars & lstr3Chars & ".exe")
            File.Delete(lstrZipSourcePath & "temp\" & lstrDestFilePrefix5Chars & lstr3Chars & ".zip")
            File.Delete(lstrZipSourcePath & "temp\" & lstrDestFilePrefix5Chars & lstr3Chars & ".exe")

        End If
    End Sub
    Sub SpawnAndMakeSelfEx(ByVal pstrSourceZipWithPath As String)

        Dim psInfo As New System.Diagnostics.ProcessStartInfo("Winzip32.exe", pstrSourceZipWithPath)
        Dim myProcess As Process = System.Diagnostics.Process.Start(psInfo)
        myProcess.WaitForInputIdle()
        Sleep(2) 'Sleep(1)

        SendKeys.SendWait("+K")
        Sleep(2) 'Sleep(1)
        SendKeys.SendWait("~") 'Enter
        Sleep(2) 'Sleep(1)
        SendKeys.SendWait("%N") 'SendKeys.Send("%N")
        Sleep(1) 'Sleep(0.5)
        SendKeys.SendWait("{ESC}") 'SendKeys.Send("{ESC}")
        Sleep(1) 'Sleep(0.5)
        SendKeys.SendWait("%{F4}") 'SendKeys.Send("%{F4}")
    End Sub
    Sub ZipFiles(ByVal pstrZipSourceDir As String, ByVal pstrDestZipFile As String)
        Dim astrFileNames() As String = Directory.GetFiles(pstrZipSourceDir)
        Dim objCrc32 As New Crc32()
        Dim strmZipOutputStream As ZipOutputStream

        strmZipOutputStream = New ZipOutputStream(File.Create(pstrDestZipFile))
        strmZipOutputStream.SetLevel(6)

        REM Compression Level: 0-9
        REM 0: no(Compression)
        REM 9: maximum compression

        Dim strFile As String

        For Each strFile In astrFileNames
            Dim strmFile As FileStream = File.OpenRead(strFile)
            Dim abyBuffer(strmFile.Length - 1) As Byte

            strmFile.Read(abyBuffer, 0, abyBuffer.Length)

            Dim ThisstrFile As String = Path.GetFileName(strFile)

            'Dim objZipEntry As ZipEntry = New ZipEntry(strFile)
            Dim objZipEntry As ZipEntry = New ZipEntry(ThisstrFile)

            objZipEntry.DateTime = DateTime.Now
            objZipEntry.Size = strmFile.Length
            strmFile.Close()
            objCrc32.Reset()
            objCrc32.Update(abyBuffer)
            objZipEntry.Crc = objCrc32.Value
            strmZipOutputStream.PutNextEntry(objZipEntry)
            strmZipOutputStream.Write(abyBuffer, 0, abyBuffer.Length)

        Next

        strmZipOutputStream.Finish()
        strmZipOutputStream.Close()
    End Sub
    Sub Sleep(ByVal Seconds As Long)
        Dim Start As DateTime = Date.Now
        While Not DateDiff(DateInterval.Second, Start, Date.Now) >= Seconds
            ' do nothing 
        End While
    End Sub
End Module
