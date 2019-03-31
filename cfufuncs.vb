Imports System
Imports System.Net
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Runtime.Remoting
Imports System.Threading
Imports System.Globalization
Imports ICSharpCode.SharpZipLib.Zip
Public Structure ManifestInfo
    Dim strSitePath As String
    Dim strManifestDir As String
    Dim strManifestFile As String
End Structure
Friend Module CFUFuncs
    Private PubKeys As New MCLCore.AppKeys()
    Friend Enum ManifestParams
        AvailableVersion
        DownloadSite
        DownloadDir
        DownloadFile
    End Enum
    Friend Structure DownloadInfo
        Dim strDownloadSite As String
        Dim strDownloadDir As String
        Dim strDownloadFile As String
    End Structure
    Friend Function GetParamValue(ByVal pstrSearchString As String, ByVal pstrParam As ManifestParams) As String
        Dim llngPos1 As Long
        Dim llngPos2 As Long
        Dim llngSSLen As Long = (pstrSearchString).Length

        'function changed 

        Dim lstrParamStr As String
        Select Case pstrParam
            Case ManifestParams.AvailableVersion : lstrParamStr = "AvailableVersion"
            Case ManifestParams.DownloadDir : lstrParamStr = "DownloadDir"
            Case ManifestParams.DownloadFile : lstrParamStr = "DownloadFile"
            Case ManifestParams.DownloadSite : lstrParamStr = "DownloadSite"
        End Select

        If llngSSLen > 0 Then
            llngPos1 = InStrGet(pstrSearchString, "<" & lstrParamStr & ">")
            If llngPos1 > 0 Then
                llngPos1 = llngPos1 + (lstrParamStr).Length + 2
                llngPos2 = InStrGet(pstrSearchString, "</" & lstrParamStr & ">")
                If llngPos2 > 0 Then
                    GetParamValue = MidGet(pstrSearchString, llngPos1, llngPos2 - llngPos1)
                End If
            End If
        End If

    End Function
    Friend Function GetParamValue(ByVal pstrSearchString As String, ByVal pstrParam As String) As String
        Dim llngPos1 As Long
        Dim llngPos2 As Long
        Dim llngSSLen As Long = (pstrSearchString).Length

        If llngSSLen > 0 Then
            llngPos1 = InStrGet(pstrSearchString, "<" & pstrParam.ToString & ">")
            If llngPos1 > 0 Then
                llngPos1 = llngPos1 + (pstrParam.ToString).Length + 2
                llngPos2 = InStrGet(pstrSearchString, "</" & pstrParam.ToString & ">")
                If llngPos2 > 0 Then
                    GetParamValue = MidGet(pstrSearchString, llngPos1, llngPos2 - llngPos1)
                End If
            End If
        End If

    End Function
    Friend Function GetFileString(ByVal pstrFileName As String) As String
        Dim lstrFile As New System.IO.FileStream(pstrFileName, System.IO.FileMode.Open)

        'stream = New IO.StreamReader(stream)
        'GetFileString = stream.ReadToEnd
    End Function
    Friend Function ReadFileAsString(ByVal path As String) As String
        Dim fs As New FileStream(path, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)

        Dim by(Convert.ToInt32(fs.Length - 1)) As Byte
        fs.Read(by, 0, by.Length)
        fs.Close()
        Return System.Text.Encoding.UTF8.GetString(by)

    End Function

    Friend Function IsNewer(ByVal pstrDownloadVersion As String, ByRef pThisVerNumber As String) As Boolean
        'MxessageBox.Show("pstrDownloadVersion=" & pstrDownloadVersion & " pThisVerNumber=" & pThisVerNumber)
        pstrDownloadVersion = pstrDownloadVersion & "."
        Dim lintMajor As Integer = ReturnNthStr(pstrDownloadVersion, 1, ".")
        Dim lintMinor As Integer = ReturnNthStr(pstrDownloadVersion, 2, ".")
        Dim lintBuild As Integer = ReturnNthStr(pstrDownloadVersion, 3, ".")
        Dim lintPrivate As Integer = ReturnNthStr(pstrDownloadVersion, 4, ".")

        'Dim llngFullPassNumner As Long = CLng(lintMajor & lintMinor & lintBuild & lintPrivate) 
        Dim llngFullPassNumner As Long = CLng(threedigs(lintMajor) & threedigs(lintMinor) & threedigs(lintBuild) & threedigs(lintPrivate)) 

        Dim llngFullThisNumber As Long

        'With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location)
        
        With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly.Location)
            'If lintMajor > .ProductMajorPart Then IsNewer = True : Exit Function
            'If lintMinor > .ProductMinorPart Then IsNewer = True : Exit Function
            'If lintBuild > .ProductBuildPart Then IsNewer = True : Exit Function
            'If lintPrivate > .ProductPrivatePart Then IsNewer = True : Exit Function


            ''llngFullThisNumber = CLng(.ProductMajorPart & .ProductMinorPart & .ProductBuildPart & .ProductPrivatePart)
            
            llngFullThisNumber = CLng(.ProductMajorPart) & threedigs(.ProductMinorPart) & threedigs(.ProductBuildPart) & _
                 threedigs(.ProductPrivatePart)
            pThisVerNumber = .ProductMajorPart & "." & .ProductMinorPart & "." & .ProductBuildPart & "." & .ProductPrivatePart 

        End With

        If llngFullPassNumner > llngFullThisNumber Then 
            IsNewer = True
        End If


    End Function
    Friend Function ValidateNow(ByVal pstrKeyPath As String, ByVal pstrDownDir As String) As Boolean

        ValidateNow = True
        'this is supposed to be the keys.dll on the webserver to avoid collision when accessing to compare
        'Dim PubKeys As New Appupdater.AppKeys() '= Appupdater.appkeys( "d:\keys.dll")
        'PubKeys.AppKeys("D:\desktopnt\") 'keys.dll")
        PubKeys.AppKeys(pstrKeyPath)

        PubKeys.InitializeKeyCheck()

        Try
            'ValidateDownloadFiles("D:\DesktopNT\New Folder\")
            ValidateDownloadFiles(pstrDownDir)

        Catch e As Exception
            PubKeys.UnInitializeKeyCheck()
            PubKeys = Nothing
            'delete download files

            'end here, friendly error
            'Throw New System.Exception("Invalid download")
            ValidateNow = False
        End Try

        Try 
            PubKeys.UnInitializeKeyCheck()
            PubKeys = Nothing
        Catch 
        End Try 

    End Function
    Private Sub ValidateDownloadFiles(ByVal pstrDir As String)

        Try
            Dim source As DirectoryInfo = New DirectoryInfo(pstrDir)
            Dim files() As FileInfo = source.GetFiles
            Dim pfile As FileInfo

            For Each pfile In files
                Select Case RightGet(pfile.FullName, 3).ToUpper 
                    Case "EXE", "DLL" 
                        If Not PubKeys.ValidateAsembly(pfile.FullName) Then
                            '--- testing ----
                            'MessageBox.Show("Invalid assembly " & pfile.FullName)
                            '--- testing ----
                            Throw New Exception("Invalid assembly " + pfile.FullName)
                        End If
                    Case Else 
                        ' can't validate none assembly files.
                End Select 
            Next pfile

            Dim Directories() As DirectoryInfo = source.GetDirectories
            Dim pDirectory As DirectoryInfo

            For Each pDirectory In Directories
                ValidateDownloadFiles(Path.Combine(pstrDir, pDirectory.Name))
            Next pDirectory
        Catch e As Exception
            Debug.WriteLine("Failed to validate new version")
            Debug.WriteLine(e.ToString)
            Throw
        End Try
    End Sub
End Module
Friend Class HTTPDownload
    Friend Shared Event Progress(ByVal sender As Object, ByVal e As DownloadEventArgs)
    Friend Shared Event DownloadComplete(ByVal sender As Object, ByVal e As DownloadEventArgs)
    Friend Shared Sub Start(ByVal ServerAddress As String, ByVal ServerFileName As String, ByVal LocalFileName As String)
        Try
            Dim wc As New WebClient()                                  'Channel used to download file 
            Dim st As Stream                                            'Stream to write the downloaded data 
            Dim fn As New FileStream(LocalFileName, FileMode.Create)    'Create the FileStream 
            Dim o As Long                                              'Temp Counter 
            Dim br As Integer
            Dim buf(256) As Byte

            wc.BaseAddress = ServerAddress                              'Assign the base web address 
            st = wc.OpenRead(ServerFileName)                            'Open the file from the server 
            Do
                br = st.Read(buf, 0, 256)                              'read into the buffer and write to 
                fn.Write(buf, 0, br)                                    'our stream 
                o += br

                RaiseEvent Progress(Nothing, New DownloadEventArgs(ServerFileName, LocalFileName, o))
            Loop While (br <> 0)

            Try : fn.Close() : Catch : End Try

            RaiseEvent DownloadComplete(Nothing, New DownloadEventArgs(ServerFileName, LocalFileName, o))

        Catch noDir As System.IO.DirectoryNotFoundException            'we need to create our save directory 
            System.IO.Directory.CreateDirectory(New FileInfo(LocalFileName).DirectoryName)
            Start(ServerAddress, ServerFileName, LocalFileName)

        Catch ex As Exception                                          'Don't know :) 
            Throw ex
        End Try
    End Sub
    Friend Shared Function GetFileLength(ByVal pstrURL As String) As Long
        Dim input As IO.Stream
        Dim Req As System.Net.WebRequest = Req.Create(pstrURL)
        Dim Response As System.Net.WebResponse

        Try
            Response = Req.GetResponse
            input = Response.GetResponseStream
            Dim length As Long = 1000000 * 100
            Dim lengthavail As Boolean = False

            Dim pos As Long = 0
            If Response.ContentLength > 0 Then
                length = Response.ContentLength
                lengthavail = True
            End If
            input.Close()

            GetFileLength = length
        Catch ew As System.Net.WebException

            'If InStrGet(ew.Message, "The remote name could not be resolved") > 0 Then
            '    GetFileLength = -1
            'ElseIf InStrGet(ew.Message, "The remote server returned an error") > 0 Then
            '    GetFileLength = -1
            'ElseIf InStrGet(ew.Message, "An unexpected error occurred on a receive") > 0 Then
            '    GetFileLength = -2
            'Else
            '    Throw ew
            'End If

            
            Dim errorRespone As HttpWebResponse = CType(ew.Response, HttpWebResponse)
            If errorRespone.StatusCode = HttpStatusCode.NotFound Then '404
                GetFileLength = -1
            ElseIf errorRespone.StatusCode = HttpStatusCode.ServiceUnavailable Then 
                GetFileLength = -2
            Else
                GetFileLength = -1 'changed from -2 
            End If

                
        Catch ex As Exception                                          'Don't know :) 
            Throw ex
            GetFileLength = 0
        End Try
    End Function
End Class
Public Class DownloadEventArgs
    Inherits EventArgs
    Friend ServerFileName As String
    Friend LocalFileName As String
    Friend DownloadedBytes As Integer
    Friend Sub New(ByVal SFN As String, ByVal LFN As String, ByVal DB As Integer)
        ServerFileName = SFN : LocalFileName = LFN : DownloadedBytes = DB
    End Sub
End Class
Public Module AfterProg
    Public Sub ProcessAnyCFU()
        Dim lbooTraceErr As Boolean = False 'True 

        If lbooTraceErr = True Then MessageBox.Show("ProcessAnyCFU 1")

        If gbooNeedToRestartProgAfterCFU = True And gstrCFUTempDir <> "" Then
            'Dim lstrProg As String = System.IO.Path.GetDirectoryName( _
            '    System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\Beside02.exe"
            
            Dim lstrProg As String = System.IO.Path.GetDirectoryName( _
                System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\Beside02.exe"

            If lbooTraceErr = True Then MessageBox.Show(lstrProg)

            Dim lstrComm(0) As String
            Dim lintCLArrInc1 As Integer
            'Dim lstrCommandLine1 As String = gstrCFUTempDir & "@" & _
            '    System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).OriginalFilename & "@"

            Dim lstrCommandLine1 As String = gstrCFUTempDir & "@" & _
                System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly.Location).OriginalFilename & "@"

            If lbooTraceErr = True Then MessageBox.Show("ProcessAnyCFU 2")

            If lbooTraceErr = True Then MessageBox.Show(lstrCommandLine1)

            PhaseShift(lstrCommandLine1, "olkljoijoi", lstrComm)
            lstrCommandLine1 = ""
            For lintCLArrInc1 = 0 To lstrComm.GetUpperBound(0)
                'Conxsole.WriteLine(lstrComm(lintCLArrInc1))
                lstrCommandLine1 = lstrCommandLine1 & lstrComm(lintCLArrInc1) & "X3X"
            Next lintCLArrInc1

            If lbooTraceErr = True Then MessageBox.Show("ProcessAnyCFU 3")

            If lbooTraceErr = True Then
                Try : File.Delete("c:\cfutest.bat") : Catch : End Try
                Dim SaveFile As FileStream = New FileStream("c:\cfutest.bat", FileMode.Create)
                Dim StreamWriter As StreamWriter = New StreamWriter(SaveFile)
                StreamWriter.Write(lstrProg & " " & lstrCommandLine1)
                StreamWriter.Close()
            End If

            If IsWin98ME() Then 
                
                lstrProg = ChrGet(34) & lstrProg & ChrGet(34)
                lstrCommandLine1 = ChrGet(34) & lstrCommandLine1 & ChrGet(34)
                Microsoft.VisualBasic.Shell(lstrProg & " " & lstrCommandLine1)
                
            Else
                Dim psInfo As New System.Diagnostics.ProcessStartInfo(lstrProg, lstrCommandLine1)

                If lbooTraceErr = True Then MessageBox.Show("ProcessAnyCFU 4")

                psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                psInfo.CreateNoWindow = True

                If lbooTraceErr = True Then MessageBox.Show("ProcessAnyCFU 5")

                Dim myProcess As Process = System.Diagnostics.Process.Start(psInfo)

                

            End If
            If lbooTraceErr = True Then MessageBox.Show("ProcessAnyCFU 6")

        End If

            
            'If gbooNeedToRestartProgAfterCFU = False And gstrCFUTempDir <> "" Then
            '    On Error Resume Next
            '    System.IO.File.Delete(gstrCFUTempDir & "\download.dat")
            '    System.IO.File.Delete(gstrCFUTempDir & "\MCLKeys.dll")
            '    Dim lintArrInc As Integer, listDir() As String = System.IO.Directory.GetFiles(gstrCFUTempDir & "\unzip")
            '    For lintArrInc = 0 To listDir.Length - 1
            '        System.IO.File.Delete(listDir(lintArrInc))
            '    Next lintArrInc
            '    System.IO.Directory.Delete(gstrCFUTempDir & "\unzip")
            '    System.IO.Directory.Delete(gstrCFUTempDir)

            '    On Error GoTo 0
            'End If
            

    End Sub
    Private Sub PhaseShift(ByVal pstrInput As String, ByVal pstrView As String, Optional ByRef pstrInp() As String = Nothing)
        Dim strHead As String
        Dim strT As String
        Dim strA As String
        Dim cphX As New clsCipher()
        Dim lngN As Long

        strA = pstrInput & CR()

        strT = Wash(Date.Today & CStr(Microsoft.VisualBasic.Timer))

        strHead = "33" & strT & Wash(strT & pstrView)

        cphX.KeyString = strHead
        cphX.Text = strA
        cphX.DoXor()
        cphX.Stretch()
        strA = cphX.Text

        Dim lintArrInc As Integer

        ReDim pstrInp(0)
        pstrInp(0) = strHead
        lngN = 1
        Do
            lintArrInc = lintArrInc + 1
            ReDim Preserve pstrInp(lintArrInc)
            pstrInp(lintArrInc) = MidGet(strA, lngN, 70)
            lngN = lngN + 70
        Loop Until lngN > (strA).Length

    End Sub
    Private Function Wash(ByVal strA As String) As String
        Dim cphHash As New clsCipher()

        cphHash.KeyString = strA & "123456"
        cphHash.Text = strA & "123456"
        cphHash.DoXor()
        cphHash.Stretch()
        cphHash.KeyString = cphHash.Text
        cphHash.Text = "123456"
        cphHash.DoXor()
        cphHash.Stretch()
        Wash = cphHash.Text

    End Function
End Module
Public Module UpdateFuncs
    Public Sub Unzip(ByVal pstrZipFile As String, ByVal strDestinationPath As String)
        Dim stmzipArchive As ZipInputStream = New ZipInputStream(File.OpenRead(pstrZipFile))
        Dim theEntry As ZipEntry

        theEntry = stmzipArchive.GetNextEntry()

        'While IsNothing(theEntry) = False
        While Not (theEntry Is Nothing)
            'Conxsole.WriteLine(theEntry.Name)
            Dim directoryName As String = Path.GetDirectoryName(theEntry.Name)
            Dim filename As String = Path.GetFileName(theEntry.Name)

            Directory.CreateDirectory(strDestinationPath & directoryName)
            If RightGet(theEntry.Name, 1) <> "/" Then 
                Dim streamWriter As FileStream = File.Create(strDestinationPath & theEntry.Name)

                Dim size As Integer = 2048
                Dim data(2048) As Byte

                While (True)
                    size = stmzipArchive.Read(data, 0, data.Length)
                    If size > 0 Then
                        streamWriter.Write(data, 0, size)
                    Else
                        Exit While
                    End If
                End While
                streamWriter.Close()
            End If 
            theEntry = stmzipArchive.GetNextEntry()
        End While
        stmzipArchive.Close()
    End Sub
    Public Function IsThisVersion(ByVal pstrDownloadVersion As String) As Boolean
        
        pstrDownloadVersion = pstrDownloadVersion & "."
        Dim lintMajor As Integer = ReturnNthStr(pstrDownloadVersion, 1, ".")
        Dim lintMinor As Integer = ReturnNthStr(pstrDownloadVersion, 2, ".")
        Dim lintBuild As Integer = ReturnNthStr(pstrDownloadVersion, 3, ".")
        Dim lintPrivate As Integer = ReturnNthStr(pstrDownloadVersion, 4, ".")

        'Dim llngFullPassNumner As Long = CLng(lintMajor & lintMinor & lintBuild & lintPrivate) 
        Dim llngFullPassNumner As Long = CLng(threedigs(lintMajor) & threedigs(lintMinor) & threedigs(lintBuild) & threedigs(lintPrivate)) 

        Dim llngFullThisNumber As Long

        With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly.Location)
            'llngFullThisNumber = CLng(.ProductMajorPart & .ProductMinorPart & .ProductBuildPart & .ProductPrivatePart)
            
            llngFullThisNumber = CLng(threedigs(.ProductMajorPart) & threedigs(.ProductMinorPart) & threedigs(.ProductBuildPart) & _
                threedigs(.ProductPrivatePart))
        End With

        If llngFullPassNumner = llngFullThisNumber Then
            IsThisVersion = True
        End If

    End Function
    Public Function IsCompatible(ByVal pstrDownloadVersion As String) As Boolean 

        '--- Certified OK 
        pstrDownloadVersion = pstrDownloadVersion & "."
        Dim lintMajor As Integer = ReturnNthStr(pstrDownloadVersion, 1, ".")
        Dim lintMinor As Integer = ReturnNthStr(pstrDownloadVersion, 2, ".")
        Dim lintBuild As Integer = ReturnNthStr(pstrDownloadVersion, 3, ".")
        Dim lintPrivate As Integer = ReturnNthStr(pstrDownloadVersion, 4, ".")

        Dim DownVer As Long = CLng(threedigs(lintMajor) & threedigs(lintMinor) & threedigs(lintBuild) & threedigs(lintPrivate)) 

        Dim AppVer As Long

        With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly.Location)
            AppVer = CLng(.ProductMajorPart) & threedigs(.ProductMinorPart) & threedigs(.ProductBuildPart) & _
                 threedigs(.ProductPrivatePart) 
        End With

        If DownVer <= AppVer Then
            IsCompatible = True
        Else
            IsCompatible = False
        End If
        '--- Certified OK 

    End Function
End Module