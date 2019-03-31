Imports System.IO
Friend Module main
    Friend lbooErrDebug As Boolean = False 
    Friend Sub Main()
        Main(Environment.GetCommandLineArgs())
    End Sub

    Private Sub Main(ByVal args() As String)
        Dim lstrTempDownloadDir As String
        Dim lErrTrace As Boolean = False 
        Dim lstrErrPos As String = "0" 
        '------------------ crc check -------------------------
        Dim IRes As Integer
        'IRes = SetTopicTree()
        IRes = GetWrittenCRC(AppExe) 

        Dim lstrDetails(3) As String
        Dim lstrRetVal3 As String
        'lstrDetails(0) = "33ZXqxRgH>tLgI<k_M"
        'lstrDetails(1) = "Iu\PJq]tVVgt?kFqmpM?QsEx[RixUzTwpTbxWlhThQaYzUQIeos;;B<N=pSCA_`sPXAx;c"
        'lstrDetails(2) = "A_jA^BwETyWZwzGsI^;mLFwij[kty`^NPC[JygFVpYSpMPNoDHDFkYwVRM=gLKWHfVF[]L"
        'lstrDetails(3) = "oFTR[gVPYlDyYHdefi`nmPjE_Ag"
        
        lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        lstrDetails(1) = "xUG;QVU;JHmPpmpPwKJ;AHQ;SRF;QZHpJJGPZmQKLVC;YHJ;ZwKKLGE;NFY;LWA;ZnFKVL"
        lstrDetails(2) = "Z@mpyONNZ<HQS;RFG;ZHUKGUH;DUV;LmpPmpfORQG;ZJHKKSH;YMZ<QGZ<TKH;ZEGKUZX?"
        lstrDetails(3) = "AZF?RUZ<MYQ;LZJ?HKS;HYM;LmO"
        

        lstrRetVal3 = Decrypt(lstrDetails, 0) 'addec0 for bug fix 

        ''--- TESTING ---
        'IRes = -1
        ''--- TESTING ---

        If IRes = 1 Then
            '
        ElseIf IRes = -1 Then
            MessageBox.Show(lstrRetVal3, "Beside02")
            End
            GoTo Exhaust
        Else
            MessageBox.Show(lstrRetVal3, "Beside02")
            End
            GoTo Exhaust
        End If
        '------------------ crc check -------------------------

        lstrErrPos &= ",1"

        If args Is Nothing Or args.Length > 2 Or args.Length = 1 Then
            MessageBox.Show(lstrRetVal3, "Beside02")
        Else
            If (args(1)).Trim = "" Then
                MessageBox.Show(lstrRetVal3, "Beside02")
                Exit Sub
            End If
            Try 
                ''On Error Resume Next
                Try : lstrTempDownloadDir = args(1) : Catch : End Try 'added try etc 


                'Clipboard.SetDataObject(lstrTempDownloadDir, True) 

                lstrErrPos &= ",5"

                Dim lstrDecStr As String
                Dim IntBeside As New beside()
                'lstrDecStr = IntBeside.Interpret(lstrTempDownloadDir)
                lstrDecStr = IntBeside.Interpret(lstrTempDownloadDir, ".EXE") 
                IntBeside = Nothing

                lstrErrPos &= ",10"

                Try : lstrTempDownloadDir = ReturnNthStr(lstrDecStr, 1, "@") : Catch : End Try 'added try etc 
                Dim lstrProgToExecute As String 
                Try : lstrProgToExecute = ReturnNthStr(lstrDecStr, 2, "@") : Catch : End Try 'added try etc 
                'pstrFileName = args(2)
                'pstrWorkgroup = args(3)
                'pstrUserName = args(4)
                'pstrPassword = args(5)
                ''On Error GoTo 0

                lstrErrPos &= ",20"

                'lstrTempDownloadDir = Right(Left(lstrTempDownloadDir, Len(lstrTempDownloadDir) - 1), Len(lstrTempDownloadDir) - 1)
                'lstrTempDownloadDir = Left(lstrTempDownloadDir, Len(lstrTempDownloadDir) - 1)



                'MsgBox(lstrTempDownloadDir)
                'Sleep(2) 'taken out after ading wait for process to end code
                'lstrTempDownloadDir = "D:\DesktopNT\New Folder\Temp-Monday-27-Jan-2003-17-12-38"

                ''
                ''don't realy need this, might be useful in the future!
                '''Get version number of old main prog
                ''Dim llngOldProgVer As Long

                ''With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.IO.Path.GetDirectoryName( _
                ''    System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\" & lstrProgToExecute)
                ''    llngOldProgVer = CLng(.ProductMajorPart) & "." & threedigs(.ProductMinorPart) & "." & threedigs(.ProductBuildPart) & _
                ''        "." & threedigs(.ProductPrivatePart)
                ''End With
                ''

                
                Dim lintCtr As Integer
                If CheckMainAppRunning(lstrProgToExecute.Replace(".exe", "")) = True Then
                    lstrErrPos &= ",30"
                    System.Windows.Forms.Application.DoEvents()
                    Sleep(1)
                    lintCtr += 1
                    If lintCtr >= 120 Then
                        MessageBox.Show("Unable to update your program, please seek technical support!", "Check For Updates")
                        Exit Sub
                    End If
                End If
                

                lstrErrPos &= ",40"

                '--- 
                Dim lintOldFileVer As Integer = GetFileVerNum(System.IO.Path.GetDirectoryName( _
                    System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\" & lstrProgToExecute)
                '--- 

                lstrErrPos &= ",50"

                Dim lintArrInc As Integer ', listDir() As String = System.IO.Directory.GetFiles(lstrTempDownloadDir & "\unzip")
                Dim listDir(0) As String 

                ProcessDirectory(lstrTempDownloadDir & "\unzip", listDir, lstrTempDownloadDir & "\unzip", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()))  

                lstrErrPos &= ",60"

                For lintArrInc = 0 To listDir.Length - 1
                    Select Case (System.IO.Path.GetFileName(listDir(lintArrInc))).ToUpper
                        Case "BESIDE02.EXE"
                            lstrErrPos &= ",70"
                            ' do nothing
                            'You've already copied this file
                            System.Windows.Forms.Application.DoEvents()
                            'System.IO.File.Delete(listDir(lintArrInc))
                            
                            System.IO.File.Delete(lstrTempDownloadDir & "\unzip" & listDir(lintArrInc))
                            System.Windows.Forms.Application.DoEvents()
                            lstrErrPos &= ",80"
                        Case Else
                            lstrErrPos &= ",90"

                            '---- 
                            Dim lstrCurrentFile As String = listDir(lintArrInc)
                            Dim lstrNewDirShort As String = ""
                            'If File which should be in a sub directory is found....
                            If InStrGet(listDir(lintArrInc), "#") > 0 Then
                                lstrErrPos &= ",93"
                                lstrNewDirShort = LeftGet(listDir(lintArrInc), InStrGet(listDir(lintArrInc), "#") - 1)
                                Dim lstrNewDir As String = System.IO.Path.GetDirectoryName( _
                                    System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\" & lstrNewDirShort
                                If System.IO.Directory.Exists(lstrNewDir) = False Then
                                    System.IO.Directory.CreateDirectory(lstrNewDir)
                                End If
                                lstrErrPos &= ",96"
                                lstrCurrentFile = listDir(lintArrInc).Replace(lstrNewDirShort & "#", "")
                                lstrNewDirShort &= "\" 
                            End If
                            '---- 


                            ''MsgBox(UCase(System.IO.Path.GetFileName(listDir(lintArrInc))))
                            ''System.IO.File.Copy(listDir(lintArrInc), _
                            ''    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & _
                            ''    "\" & System.IO.Path.GetFileName(listDir(lintArrInc)), True)
                            '
                            'System.IO.File.Copy(lstrTempDownloadDir & "\unzip" & listDir(lintArrInc), _
                            '    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & _
                            '    listDir(lintArrInc), True)
                            'System.Windows.Forms.Application.DoEvents()
                            ''System.IO.File.Delete(listDir(lintArrInc))
                            '
                            'System.IO.File.Delete(lstrTempDownloadDir & "\unzip" & listDir(lintArrInc))
                            'System.Windows.Forms.Application.DoEvents()
                            '
                            'Console.WriteLine(lstrTempDownloadDir & "\unzip" & listDir(lintArrInc) & " " & _
                            '    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & _
                            '    listDir(lintArrInc))


                            '---- 
                            'MessageBox.Show(lstrTempDownloadDir & "\unzip" & listDir(lintArrInc) & " " & _
                            '    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & _
                            '    lstrNewDirShort & lstrCurrentFile)
                            lstrErrPos &= ",100"
CurrentCopy:             
                            Try 
                                System.IO.File.Copy(lstrTempDownloadDir & "\unzip" & listDir(lintArrInc), _
                                            System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & _
                                            lstrNewDirShort & lstrCurrentFile, True)
                                System.Windows.Forms.Application.DoEvents()
                                
                            Catch
                                'added to cater for file lock error.
                                Sleep(2)
                                GoTo CurrentCopy
                            End Try
                            

                            ''On Error Resume Next 
                            Try : System.IO.File.Delete(lstrTempDownloadDir & "\unzip" & listDir(lintArrInc)) : Catch : End Try 'added try etc 
                            ''On Error GoTo 0 
                            System.Windows.Forms.Application.DoEvents()



                            '---- 

                    End Select
                    lstrErrPos &= ",110"
                Next lintArrInc

                ''On Error Resume Next
                Try : System.IO.File.Delete(lstrTempDownloadDir & "\mclkeys.dll") : Catch : End Try 'added try etc 
                '            On Error GoTo 0
                lstrErrPos &= ",120"
                'System.IO.Directory.Delete(lstrTempDownloadDir & "\unzip")
                Try : System.IO.Directory.Delete(lstrTempDownloadDir & "\unzip", True) : Catch : End Try 'added try etc 
                lstrErrPos &= ",130"
                'System.IO.Directory.Delete(lstrTempDownloadDir)
                Try : System.IO.Directory.Delete(lstrTempDownloadDir, True) : Catch : End Try 'added try etc 
                ''On Error GoTo 0 
                System.Windows.Forms.Application.DoEvents()

                'Dim psInfo As New System.Diagnostics.ProcessStartInfo(System.IO.Path.GetDirectoryName( _
                '    System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\IdeasPad.exe")

                
                Dim lstrExeTry As String = System.IO.Path.GetDirectoryName( _
                    System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\" & lstrProgToExecute

                '---- Fix for older program versions 
                If Not File.Exists(lstrExeTry) Then
                    lstrExeTry = System.IO.Path.GetDirectoryName( _
                        System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\IdeasPad.exe"
                    If Not File.Exists(lstrExeTry) Then
                        lstrExeTry = System.IO.Path.GetDirectoryName( _
                            System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\MDBSecure.exe"
                        If Not File.Exists(lstrExeTry) Then
                            lstrExeTry = System.IO.Path.GetDirectoryName( _
                                System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\HTMLSqueeze.exe"
                            If Not File.Exists(lstrExeTry) Then
                                MessageBox.Show("You may now re-open your program!")
                                Exit Sub
                            End If
                        End If
                    End If
                End If
                '---- Fix for older program versions 

                
                'Write CFU Updated From Version Number
                'lstrProgToExecute
                'to lstrExeTry & ".dat"
                Dim lstrUpdateCode As String = "10"
                If InStrGet(lstrExeTry.ToUpper, "IDEASPAD") > 0 Then
                    If lintOldFileVer < 1001000000 Then '1.1.0.0
                        lstrUpdateCode = "30"
                    End If
                End If
                If InStrGet(lstrExeTry.ToUpper, "MDBSECURE") > 0 Then 'added MDBSecure
                    If lintOldFileVer < 1000003000 Then '1.0.3.0
                        lstrUpdateCode = "30"
                    End If

                End If

                lstrErrPos &= ",140"

                Try 
                    'added check for MDBSecure, v1.0.2 does use Dat file.
                    If System.IO.File.Exists(lstrExeTry & ".dat") = False Then 
                        GetSetting("Default Information Base File", "", InitalXMLConfig.XmlConfigType.AppSettings, "", lstrExeTry & ".dat") 
                    End If 
                    SaveSetting("CFU Code", lstrUpdateCode, InitalXMLConfig.XmlConfigType.AppSettings, "", lstrExeTry & ".dat")
                Catch 
                End Try 
                

                lstrErrPos &= ",150"
                Dim psInfo As New System.Diagnostics.ProcessStartInfo(lstrExeTry)

                'psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                'psInfo.CreateNoWindow = True
                Dim myProcess As Process = System.Diagnostics.Process.Start(psInfo)

                lstrErrPos &= ",160"

            Catch ex As Exception 
   
                If lErrTrace = True Then
                    MessageBox.Show(ex.ToString & Environment.NewLine & Environment.NewLine & lstrErrPos)
                End If
            End Try 
        End If



        'FileClose(lintFreeFile)
Exhaust:
    End Sub
    Private Sub ProcessDirectory(ByVal targetDirectory As String, ByRef plistDir() As String, ByVal TrueDir As String, ByVal pstrDestDir As String) 
        If TrueDir = "" Then
            TrueDir = targetDirectory
        End If
        Dim fileEntries As String() = Directory.GetFiles(targetDirectory)
        ' Process the list of files found in the directory
        Dim fileName As String
        For Each fileName In fileEntries
            ProcessFile(fileName, plistDir, targetDirectory, TrueDir, pstrDestDir)

        Next fileName
        Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)
        ' Recurse into subdirectories of this directory
        Dim subdirectory As String
        For Each subdirectory In subdirectoryEntries
            ProcessDirectory(subdirectory, plistDir, TrueDir, pstrDestDir)
        Next subdirectory

    End Sub 'ProcessDirectory

    ' Real logic for processing found files would go here.
    Private Sub ProcessFile(ByVal path As String, ByRef plistDir() As String, ByVal targetDirectory As String, ByVal TrueDir As String, ByVal pstrDestDir As String) 
        'Console.WriteLine("Processed file '{0}'.", path)
        If plistDir(0) <> "" Then
            ReDim Preserve plistDir(plistDir.GetUpperBound(0) + 1)
        End If
        plistDir(plistDir.GetUpperBound(0)) = path.Replace(TrueDir, "")

        'Dim lintSubDirs As Integer = AppBasic.strman.Occurences(plistDir(plistDir.GetUpperBound(0)), "\") - 1
        'If lintSubDirs > 0 Then
        '    'if there are new sub directories
        'Dim JustDir As String = AppBasic.strman.Reverse(pstrDestDir & plistDir(plistDir.GetUpperBound(0)))
        'JustDir = AppBasic.RightGet(JustDir, JustDir.Length - AppBasic.strman.InStrGet(JustDir, "\"))
        'JustDir = AppBasic.strman.Reverse(JustDir)
        
        Dim JustDir As String = Reverse(pstrDestDir & plistDir(plistDir.GetUpperBound(0)))
        JustDir = Microsoft.VisualBasic.Right(JustDir, JustDir.Length - Microsoft.VisualBasic.InStr(JustDir, "\"))
        JustDir = Reverse(JustDir)

        If pstrDestDir <> JustDir Then
            Try
                Directory.CreateDirectory(JustDir)
            Catch
                'MessageBox.Show("error")
            End Try
        End If
        'End If
    End Sub 'ProcessFile
    Function CheckMainAppRunning(ByVal procName As String) As Boolean
        Try
            Dim proc As Process
            Dim processes() As Process
            Dim procIndex As Integer
            Dim procCount As Integer

            processes = Process.GetProcessesByName(procName)
            procCount = processes.Length

            If procCount > 1 Then
                'MxessageBox.Show("You already have one instance of " & procName & " running on your computer.", pstrCaption)
                'MessageBox.Show(LangText.GetString("AppHealth_AlreadyInstance").Replace("[ProdName]", pstrCaption), pstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

                For Each proc In processes
                    If procIndex > 0 Then
                        Return True
                    End If
                    procIndex = procIndex + 1
                Next
            Else
                Return False
            End If

        Catch ProcErr As Exception
            'MxessageBox.Show(ProcErr.Message)
        End Try
    End Function
    Friend Function GetFileVerNum(ByVal pstrFile As String) As Long
        'added 
        With System.Diagnostics.FileVersionInfo.GetVersionInfo(pstrFile)

            Return CLng(.ProductMajorPart) & threedigs(.ProductMinorPart) & threedigs(.ProductBuildPart) & _
                threedigs(.ProductPrivatePart)

        End With


    End Function

End Module
