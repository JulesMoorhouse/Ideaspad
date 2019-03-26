Imports System
Imports System.IO
Imports mshtml
Imports System.Windows.Forms
Imports System.Drawing.Printing
Friend Module IdeasPad

    Friend mintVersion As Integer 
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    Private StandLangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("AppBasic.AppBasic", _
        System.Reflection.Assembly.Load("AppBasic")) 
    'Sub main()
    '    'If AreDLLsPresent() = False Then 
    '    '    'mxessagebox.show("Some essential program files are missing, please re-install the program!", "Ideaspad") 
    '    '    MxessageBox.Show(LangText.GetString("Ideaspad_EssentialFilesMissing"), "Ideaspad") 

    '    '    Exit Sub
    '    'End If
    '    
    '    Dim lstrEssentialFiles() As String = {"ADODB.dll", "ADOX.dll", "AppBasic.dll", "AxInterop.SHDocVw.dll", _
    '        "Beside01.exe", "Beside02.exe", "IdeasPad.exe", "IPIconsPack.dll", "IPTemplates.dll", "JRO.dll", _
    '        "MCLCore.dll", "printtemplate.html", "ProbHand.dll", "RTFStand.dll", "SharpZipLib.dll", "SHDocVw.dll", "tipofday.txt", _
    '         "WinOnly.dll", "de\AppBasic.resources.dll", "de\IdeasPad.resources.dll", "de\tipofday.de.txt", "de\RTFStand.resources.dll", _
    '         "de\ProbHand.resources.dll"}
    '    'added ProbHand.dll, de\ProbHand.resources.dll

    '    Dim lstrPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString())

    '    If EssentialFileCheck(lstrEssentialFiles, lstrPath) = False Then
    '        MessageBox.Show(LangText.GetString("Ideaspad_EssentialFilesMissing"), "Ideaspad", MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props
    '        Exit Sub
    '    End If
    '    
    '    MessageBox.Show("a")
    '    mainStart()
    'End Sub
    Sub mainStart()

        gstrMRPs = "0011"

        'mbooLimitReportSize = False 

        '---- Debug startup timing ---
        Dim lbooStartupTimed As Boolean = False  
        Dim lstrStartupDebug As String 
        '---- Debug startup timing ---

        '--- Moved from below 
        Dim lbooNoDataFound As Boolean = True
        Dim lstrDefDB As String
        Dim ipSplashScr As ipsplash
        Dim lbooQuit As Boolean = True
        '--- Moved from below 

        Dim eh1 As CustomExceptionHandler = New CustomExceptionHandler() 'START ERR HAND 
        Try 'START ERR HAND 
            gstrMRPs = "0015"
            'AddDebugComment("Ideaspad.mainStart - Topmost") 
            gstrProbComtStack = " Topmost" 
            gdatSystemStart = Date.Now 

            If lbooStartupTimed = True Then : lstrStartupDebug &= "A " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If

            Dim lintArrInc As Integer
            'Dim lbooNoDataFound As Boolean = True
            Dim lbooVBXNotFound As Boolean = True

            Dim lintThreads As Integer = 259

            gstrMRPs = "0018"
            
            If System.IO.File.Exists(System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat") = False Then

                Try 
                    GetSetting("Default Information Base File", "", InitalXMLConfig.XmlConfigType.AppSettings, "")
                Catch 
                    
                    gstrMRPs = "0020"
                    MessageBox.Show(LangText.GetString("Ideaspad_AdminRightsRequired").Replace("[CR]", Environment.NewLine), _
                        NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

                    'MessageBox.Show("The program has been unable to write settings, please ensure you" & Environment.NewLine & _
                    '    "have Administrator privileges and try again!" _
                    '    , NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End
                    GoTo Exhaust
                    
                End Try 
            End If

            'AddDebugComment("Ideaspad.mainStart - 1") 
            gstrProbComtStack &= " #MS1" 
            

            SaveSetting("CRS.", "YES", InitalXMLConfig.XmlConfigType.AppSettings, "") 

            gstrMRPs = "0022"
            Dim AppSettings As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings)

            lstrDefDB = AppSettings.GetValue("Default Information Base File", "") 
            If lstrDefDB Is Nothing Then lstrDefDB = "" 

            gstrProbComtStack &= " #MS2" 
            gstrMRPs = "0025"
            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "B " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If
            
            Dim lstrLanguage As String = ""
            Try
                gstrMRPs = "0027"
                lstrLanguage = AppSettings.GetValue("Language", "") 

                '--- Read Language passed from Setup ---
                If lstrLanguage = "" Then

                    Dim myBaseItem As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( _
                        "SOFTWARE\Mindwarp Consultancy Ltd\Ideaspad", True)

                    If Not myBaseItem Is Nothing Then
                        lstrLanguage = CType(myBaseItem.GetValue("Language", ""), String)
                        SaveSetting("Language", lstrLanguage, InitalXMLConfig.XmlConfigType.AppSettings, "")
                    End If

                End If
                '--- Read Language passed from Setup ---

                If lstrLanguage = "" Then 
                    Dim LangSel As New ls()
                    With LangSel
                        .FormIcon = New System.Drawing.Icon( _
                            System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico"))
                        Dim Res As New IPIconsPack.Resource()
                        .MCLLogo = Res.picMCLLogo.Image 
                        .ShowDialog()
                        lstrLanguage = .Lang2Letters
                    End With
                    SaveSetting("Language", lstrLanguage, InitalXMLConfig.XmlConfigType.AppSettings, "")
                    
                End If
                System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(LeftGet(lstrLanguage, 2).ToLower)

            Catch
                '
            End Try
            gstrMRPs = "0036"
            
            gstrProbComtStack &= " #MS2a" 
            ipSplashScr = New ipsplash() 

            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "C " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If

            If lstrDefDB <> "" Then 
                ipSplashScr.AcceptShift = True 
            End If

            AssignCFUVars() 
            gstrMRPs = "0041"

            If IsAboveOrEqualWinVista() = False Then
                If flamenow() Then

                    Dim lstrDetails2(2) As String
                    Dim lstrDetails1(1) As String
                    Dim lstrRetVal As String
                    Dim lstrRetVal1 As String
                    
                    lstrDetails2(0) = "33IHGPFEDPIHGPFEDP"
                    lstrDetails2(1) = "qVU;YGj;YVZ<RYG;LSF?ZSKKFZU?LKE;SRZ<GAG;FUM;ZHUKGKE;HWU;GZF?KZH?ELZ<JH"
                    lstrDetails2(2) = "K;JUH;NAL<mK"
                    
                    lstrRetVal = Decrypt("", "", flame.Encops.EncryptString, lstrDetails2)

                    lstrDetails1(0) = "33IHGPFEDPIHGPFEDP"
                    lstrDetails1(1) = "jNU;YGU;ZWNKKGU;ZGKKMUZ<KTZ<AKE;HZK?FRU;HZJ?HKS;HYM;GZY?LVZ<HUF;HAY<mK"
                    

                    lstrRetVal1 = Decrypt("", "", flame.Encops.EncryptString, lstrDetails1)

                    MessageBox.Show(lstrRetVal & Environment.NewLine & Environment.NewLine & lstrRetVal1, gProgName, MessageBoxButtons.OK, MessageBoxIcon.Error) 
                    lstrRetVal1 = ""
                    lstrRetVal = ""
                    SaveMaxReachedPoint() 
                    End
                    GoTo Exhaust
                End If
            End If

            gstrMRPs = "0060"
            gstrProbComtStack &= " #MS3" 

            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "D " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If

            gstrProbComtStack &= " #MS3a" 

            Dim Dets As strat1.UnlockDetails 
            gstrProbComtStack &= " #MS3b" 
            TakeCare(lintThreads, Dets) 'moved from further down 
            gstrProbComtStack &= " #MS3c" 
            gstrMRPs = "0110"

            If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then
                gstrProbComtStack &= " #MS3d " & NameMe("").ToUpper & " " & InStrGet(NameMe("").ToUpper, "TRIAL") 

                With Dets
                    If .str4State.ToUpper = "UNAVAILABLE" Or .str6Country.ToUpper = "UNAVAILABLE" Then 
                        ipSplashScr.RegWho = ProperCase(Dets.str1Name & ", " & .str7Email) 
                    Else
                        ipSplashScr.RegWho = ProperCase(Dets.str1Name & ", " & Dets.str4State & ", " & Dets.str6Country) 
                    End If
                End With
            End If 
            Dets = Nothing 
            gstrProbComtStack &= " #MS3e" 
            gstrMRPs = "0120"
            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "E " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If

            ipSplashScr.Show() 'moved from further up 
            gstrMRPs = "0135"
            gstrProbComtStack &= " #MS3f" 
            System.Windows.Forms.Application.DoEvents() 'THIS LINE MUST BE HERE TO MAKE SPLASH SCREEN VISIBLE

            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "F " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If

            gstrProbComtStack &= " #MS4a" 
            Dim IRes As Integer
            IRes = GetWrittenCRC(AppExe)
            gstrMRPs = "0170"
            'IRes = 1 for testing purposes only
            gstrProbComtStack &= " #MS4b" 

            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "G " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If
            gstrProbComtStack &= " #MS4c" 
            Dim lstrDetails3(2) As String
            Dim lstrRetVal3 As String
            
            lstrDetails3(0) = "33IHGPFEDPIHGPFEDP"
            lstrDetails3(1) = "fRU;ZqVKUYG;jYV;ZJHKKSH;YMZ<TQN;UZR?YGZ<XUW;KMU;ZWKKHHE;JFU;VNZ@JNU;YG"
            lstrDetails3(2) = "U;ZHUKMQLKGFY;NNZ<FRU;ZJHKKSH;YMY<mK"
            
            gstrProbComtStack &= " #MS4d" 
            lstrRetVal3 = Decrypt("", "", flame.Encops.EncryptString, lstrDetails3)
            gstrProbComtStack &= " #MS4e" 

            gstrMRPs = "0200"
#If Not Debug Then 
            If IRes = 1 Then
                '
            ElseIf IRes = -1 Then
                MessageBox.Show(lstrRetVal3, gProgName, MessageBoxButtons.OK, MessageBoxIcon.Error) 

                SaveMaxReachedPoint
                End
                GoTo Exhaust
            Else
                MessageBox.Show(lstrRetVal3, gProgName, MessageBoxButtons.OK, MessageBoxIcon.Error) 
              SaveMaxReachedPoint
                End
                GoTo Exhaust
            End If
#End If 

            lstrRetVal3 = ""
            gstrMRPs = "0204"
            System.Windows.Forms.Application.DoEvents() 'for splash screen

            gstrProbComtStack &= " #MS5a" 
            'TakeCare(lintThreads) moved further up 
            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "H " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If
            gstrProbComtStack &= " #MS5b" 
            Dim lintMaxHist As Integer = 3
            If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then 'Changed to Trial 
                lintMaxHist = 19
            End If
            gstrProbComtStack &= " #MS5c" 
            For lintArrInc = 0 To lintMaxHist
                'If GetSetting("FileName" & lintArrInc, "", InitalXMLConfig.XmlConfigType.AppSettings, "") <> "" Then
                If AppSettings.GetValue("FileName" & lintArrInc, "") <> "" Then 
                    lbooNoDataFound = False
                    Exit For 
                End If
            Next lintArrInc
            gstrMRPs = "0211"

            gstrProbComtStack &= " #MS5d" 
            'TakeCare(lintThreads) moved higher 
            If lbooNoDataFound = True Then
                Dim lstrLocation As String = _
                Microsoft.VisualBasic.GetSetting(gProgName, "Config", "Location")
                Dim lstrDest As String = _
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & _
                            "\" & gProgName & ".exe.dat"
                If File.Exists(lstrLocation) = True And lstrLocation.ToUpper <> lstrDest.ToUpper Then 
                    Dim lintRetVal As DialogResult
                    'lintRetVal = MxessageBox.Show("A previous configuration has been found would you like to use it?", NameMe(""), _
                    'MessageBoxButtons.YesNo)
                    lintRetVal = MessageBox.Show(LangText.GetString("Ideaspad_PrevConfigFound").Replace("[Program]", gProgName), _
                        NameMe(""), _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props
                    gstrProbComtStack &= " #MS5e" 
                    System.Windows.Forms.Application.DoEvents()
                    If lintRetVal = DialogResult.Yes Then
                        'Try
                        'File.Delete(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & _
                        '    "\IdeasPad.exe.dat")
                        'GC.Collect()
                        'GC.WaitForPendingFinalizers()
                        'Catch ex As Exception
                        '    '
                        'End Try
                        File.Copy(lstrLocation, lstrDest, True)
                        Microsoft.VisualBasic.SaveSetting(gProgName, "Config", "Location", _
                            System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & _
                            "\" & gProgName & ".exe.dat")
                        gstrProbComtStack &= " #MS5e" 
                        For lintArrInc = 0 To 19 '3
                            'If GetSetting(gstrIniAppName, "DBChoice", "FileName" & lintArrInc) <> "" Then
                            'If GetSetting("FileName" & lintArrInc, "", InitalXMLConfig.XmlConfigType.AppSettings, "") <> "" Then
                            If AppSettings.GetValue("FileName" & lintArrInc, "") <> "" Then 
                                lbooNoDataFound = False
                            End If
                        Next lintArrInc
                    End If
                End If
            End If
            gstrMRPs = "0230"
            'AddDebugComment("Ideaspad.mainStart - 6") 
            gstrProbComtStack &= " #MS6a" 
            
            Dim FirstStartupStatus As New StatusDialog(ipSplashScr)

            If lbooNoDataFound = True Then
                FirstStartupStatus.Status = StandLangText.GetString("StandText_StartingProgFirstTime").Replace("[Program]", gProgName & "... ")
                FirstStartupStatus.Show()
            End If
            
            gstrProbComtStack &= " #MS6b" 
            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "I " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If

            'commented out 
            'If lintThreads <> 250 + 7 Then
            '    Exit Sub
            'End If

            '--- Icon Compatibility Check --- 
            gstrMRPs = "0236"
            Try
                Dim lintCompatIdx As Integer = IPIconsPack.CheckIconPackCompatibility()
                gstrMRPs = "0250"
                If lintCompatIdx > 1 Then
                    Select Case lintCompatIdx
                        Case 2
                            MessageBox.Show(LangText.GetString("Ideaspad_IconCompatCFUWarn").Replace("[Program]", gProgName), _
                                NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case 3
                            MessageBox.Show(LangText.GetString("Ideaspad_IconCompatCFUError").Replace("[Program]", gProgName), _
                                NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Select
                    gstrProbComtStack &= " #MS6c" 
                    Dim NewCFU As New frmCFU(gbooAlwaysOnTop)
                    With NewCFU
                        .Caption = NameMe("")
                        '.FormIcon = Me.Icon
                        
                        .FormIcon = New System.Drawing.Icon( _
                            System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico"))
                        .strManifestSite(gstrManifestSite)
                        .ShowDialog()
                    End With
                    gstrMRPs = "0265"

                    ProcessAnyCFU()
                    If gbooNeedToRestartProgAfterCFU = True And gstrCFUTempDir <> "" Then
                        Exit Sub
                    End If
                    If lintCompatIdx = 3 Then
                        Exit Sub
                    End If
                End If
            Catch
            End Try
            '--- Icon Compatibility Check --- 
            gstrMRPs = "0300"
            'AddDebugComment("Ideaspad.mainStart - 7") 
            gstrProbComtStack &= " #MS7a" 

            Dim lstrDetails(3) As String
            '#### E1 - Connection String
            'lstrDetails(0) = "33_X=QUicknjWAD>]j"
            'lstrDetails(1) = "AmDcB^]DFyW?ElgbcqX?ANx^qyZA`jISk<lLulsJ^j^iWeGWO>W<PSAf\LqF=qEYlBATND"
            'lstrDetails(2) = "oGqIA?WqZVz`[L=AFuXdeJnyvDRfV_`LAt;HtaWTrLS^rzyKnInEIzDqJ<WkCYAcQw_jjW"
            'lstrDetails(3) = "TnJGBMqHkq];nDaD_wnyMiHgU;"
            
            lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
            lstrDetails(1) = "jHK;DQV;UH=<mQW;HKG;KTF;LpUKFLk?nuv;xLF@LJ?PpUF;ZknKuvx;@vYKFYX;YGU;Zj"
            lstrDetails(2) = "YKGGC;KHV;=GHPORV;GGY;ACDP?eGKUHZ<qv=<qje;GUH;?jYKGGC;KHV;=wuKtJI@tuG<"
            lstrDetails(3) = "vDD@yw?<vYF;YZg?KEH;WU=<mK"
            
            gstrProbComtStack &= " #MS7b" 
            gconstrConnectionProvider = Decrypt("", "", flame.Encops.EncryptString, lstrDetails)
            ReDim lstrDetails(0)

            ReDim lstrDetails(1)
            '#### E2 - Just Provider String
            'lstrDetails(0) = "33[B\W[T;tqIkpV\gY"
            'lstrDetails(1) = "SgkCrpZsbXhcfJloER\EDMey[d=]oVBCb_C>PenGwKdnZsrgfm;;YNzKNR\Rn["
            
            lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
            lstrDetails(1) = "jHK;DQV;UH=<mQW;HKG;KTF;LpUKFLk?nuv;xLF@LJ?PvYF;YZg?KEH;WU=<mK"
            
            gstrMRPs = "0305"
            gstrProbComtStack &= " #MS7c" 
            gconstrConnectionJustProvider = Decrypt("", "", flame.Encops.EncryptString, lstrDetails)
            ReDim lstrDetails(0)
            gstrMRPs = "0308"
            System.Windows.Forms.Application.DoEvents() 'for splash screen
            'Sleep(2) 'for splash screen
            'System.Windows.Forms.Application.DoEvents()

            'AddDebugComment("Ideaspad.mainStart - 8") 
            gstrProbComtStack &= " #MS8" 

            Dim lbooShowMDACMsg As Boolean = False 
            
            Try
                gstrMRPs = "0312"
                If GetMDACVerNum() < 2.7 Then
                    lbooShowMDACMsg = True 
                    'MessageBox.Show(StandLangText.GetString("StandText_MDACReq").Replace("[Program]", NameMe("")), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Exit Sub
                End If
            Catch
                lbooShowMDACMsg = True 
                'MessageBox.Show(StandLangText.GetString("StandText_MDACReq").Replace("[Program]", NameMe("")), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)
                ''Exit Sub
            End Try

            gstrMRPs = "0320"

            
            'AddDebugComment("Ideaspad.mainStart - 9") 
            gstrProbComtStack &= " #MS9" 

            
            Dim lbooShowJetMsg As Boolean = False 
            Dim osInfo As OperatingSystem 
            osInfo = System.Environment.OSVersion 
            'W2k should have Jet4 preinstalled.
            If osInfo.Platform.Win32NT <= 4 Or IsWin98ME() = True Then 
                Try
                    If IsJet4Installed() <> 1 Then
                        lbooShowJetMsg = True 
                        'MessageBox.Show(StandLangText.GetString("StandText_MDACReq").Replace("[Program]", NameMe("")).Replace("Data Access Components (MDAC) 2.7", "Jet 4.0 Service Pack 8"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'Exit Sub
                    End If
                Catch
                    lbooShowJetMsg = True 
                    'MessageBox.Show(StandLangText.GetString("StandText_MDACReq").Replace("[Program]", NameMe("")).Replace("Data Access Components (MDAC) 2.7", "Jet 4.0 Service Pack 8"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Exit Sub
                End Try
            End If 
            
            gstrMRPs = "0345"
            
            Dim dldRes As DialogResult
            If lbooShowMDACMsg = True Or lbooShowJetMsg = True Then
                Dim FirstText As String = StandLangText.GetString("StandText_MDACReq").Replace("[Program]", NameMe(""))
                If lbooShowJetMsg = True Then
                    FirstText = FirstText.Replace("Data Access Components (MDAC) 2.7", "Jet 4.0 Service Pack 8")
                End If
                dldRes = MessageBox.Show(FirstText & CR() & CR() & _
                "If you would like to download it click YES!", NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Error)

                If dldRes = DialogResult.Yes Then
                    If lbooShowJetMsg = True Then
                        BrowseToUrl("http://support.microsoft.com/kb/q239114/", Nothing)
                    Else
                        BrowseToUrl("http://download.microsoft.com/download/3/b/f/3bf74b01-16ba-472d-9a8c-42b2b4fa0d76/mdac_typ.exe", Nothing)
                    End If
                End If
                Exit Sub
            End If
            
            gstrMRPs = "0360"
            'AddDebugComment("Ideaspad.mainStart - 10") 
            gstrProbComtStack &= " #MS10" 

            'Dim lbooQuit As Boolean = True

            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "J " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If

            'Catch ex As Exception 'START ERR HAND 
            '    AddDebugComment("<Font color=Red>MSG:" & ex.ToString & "</font>") 'START ERR HAND 
            '    eh1.OnThreadException(Nothing, Nothing) 'START ERR HAND 

            ''End Try 'START ERR HAND 

            If lbooNoDataFound = False Then
                gstrMRPs = "0362"
                '--
                Try
                    If File.Exists(lstrDefDB) = False Then
                        lstrDefDB = ""
                    End If
                Catch
                End Try

                'gdatSystemStart = Date.Now.AddSeconds(10) 'FOR TESTING PURPOSES ONLY 
                
                If ipSplashScr.AcceptShift = True Then
                    ipSplashScr.BringToFront() 
                    'allow at least 2 seconds to show splash screen
                    Dim StartTime As Date = Date.Now 
                    Do While StartTime.AddSeconds(2) > Date.Now
                        System.Windows.Forms.Application.DoEvents()
                    Loop
                End If

                gstrMRPs = "0375"
                


                
                Dim ShowNewsDlg As Boolean = False
                Try
                    ShowNewsDlg = CBool(AppSettings.GetValue("NewsletterDlg", "True"))
                Catch
                End Try
                If ShowNewsDlg = True Then
                    Dim nl As New Newsletter()
                    nl.FromMenu = False
                    nl.ShowDialog()
                End If
                
                gstrMRPs = "0380" 

                gstrProbComtStack &= " #MS11" 

                If lstrDefDB = "" Or ipSplashScr.ShiftPressed = True Then '--
                    Dim loc As String = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)) 

                    Microsoft.VisualBasic.SaveSetting(gProgName, "Config", "Location", loc & "\" & gProgName & ".exe.dat")

                    Dim DBChoice As New frmDBChoice()
                    DBChoice.gbooDBChoiceCancel = True
                    DBChoice.ShowDialog()
                    lbooQuit = DBChoice.gbooDBChoiceCancel
                Else
                    lbooQuit = False 
                    gstrDataFileName = lstrDefDB 
                End If
                'AddDebugComment("Ideaspad.mainStart - 12") 
                gstrProbComtStack &= " #MS12" 
            Else
                Try 
                    ''
                    ''Dim eh As CustomExceptionHandler = New CustomExceptionHandler() 
                    ''Try 
                    'Dim x As Integer = 1
                    'x = x / 0
                    'AddDebugComment("Ideaspad.mainStart - 13") 
                    gstrMRPs = "0387"
                    gstrProbComtStack &= " #MS13" 
                    '====== WITH STARTUP SCREEN =====
                    Dim NewStartup As New frmStartup()
                    NewStartup.ShowDialog()
                    lbooQuit = NewStartup.gbooStartupCancel
                    '====== WITH STARTUP SCREEN =====

                    'Console.WriteLine(Date.Now)

                    '''====== WITHOUT STARTUP SCREEN =====
                    ''
                    ''Dim NewMaint As New frmMaint()
                    ''NewMaint.gbooSilentMode = True
                    ''NewMaint.lbooUltraQuiet = True
                    ''NewMaint.btnNew_Click(Nothing, Nothing)
                    ''gstrDataFileName = NewMaint.gstrChosenDB
                    ''NewMaint.AddNewDB(NewMaint.gstrChosenDB, "Project")
                    ''lbooQuit = False
                    '''Console.WriteLine(Date.Now)
                    ''FirstStartupStatus.Close()
                    ''
                    '''====== WITHOUT STARTUP SCREEN =====

                    ''
                    ''Catch ex As Exception 
                    ''    AddDebugComment("<Font color=Red>MSG:" & ex.ToString & "</font>")  
                    ''    eh.OnThreadException(Nothing, Nothing) 

                    ''End Try 
                    'AddDebugComment("Ideaspad.mainStart - 14") 
                    gstrProbComtStack &= " #MS14" 
                Catch
                    '
                End Try 

            End If
            gstrMRPs = "0393"
            System.Windows.Forms.Application.DoEvents()
            If lbooQuit = False Then
                gstrConnectionString = gconstrConnectionProvider & gstrDataFileName & ";Jet OLEDB:System database=" & _
                    LeftGet(gstrDataFileName, (gstrDataFileName).Length - 1) & "w"
                gstrMRPs = "0394"
            Else
                gstrMRPs = "0396" 
                If InStrGet(NameMe("").ToUpper, "TRIAL") > 0 Then 
                    Dim Remind As New frmRemind() 
                    remind.ShowRTFHelp = False 
                    Remind.ShowDialog() 
                End If
                'Try : SaveSetting("MRP", gstrMRPs, InitalXMLConfig.XmlConfigType.AppSettings, "") : Catch : End Try 
                SaveMaxReachedPoint() 
                End
            End If
            gstrMRPs = "0402"

            'AddDebugComment("Ideaspad.mainStart - 15") 
            gstrProbComtStack &= " #MS15" 
            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "K " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now) : End If

            StandardUpgradeTidy() 'has ahreware check in function!

            InternationalShortcutTidy() 

            'AddDebugComment("Ideaspad.mainStart - Basic Checks done")
            gstrProbComtStack &= " #MS-done" : AddDebugComment(gstrProbComtStack) : gstrProbComtStack = "" 

        Catch ex As Exception 'START ERR HAND 
            AddDebugComment("<Font color=Red>MSG:" & ex.ToString & "</font>") 'START ERR HAND 
            eh1.pMe = Nothing 
            eh1.OnThreadException(Nothing, Nothing) 'START ERR HAND 

        End Try 'START ERR HAND 


        Dim lstrErrMsg As String 'moved from below 
        gstrMRPs = "0425"
        'Dim lflaDBResult As Long = GetWindowsDir(gstrDBFlamer)
        Dim lflaDBResult As Long 
        Dim lstrProbComtStack As String = "" 
        Try 
            lflaDBResult = GetWindowsDir(gstrDBFlamer, lstrProbComtStack)
        Catch ex As Exception 
            lstrErrMsg = ex.Message 
        End Try 

        If lstrProbComtStack <> "" Then 
            AddDebugComment(lstrProbComtStack) 
            lstrProbComtStack = ""
        End If
        'System.Windows.Forms.Application.DoEvents() 'for splash screen
        'ipSplashScr.Dispose()
        'ipSplashScr = Nothing
        gstrMRPs = "0440"
        If lstrErrMsg = "" Then 
            
            gstrMRPs = "0444" 
            Dim DBVer As String = GetFieldValuesX("DBVer")
            'Verified OK 
            If DBVer <> "" Then
                gstrMRPs = "0446" 
                If IsNewer(DBVer) = True Then
                    gstrMRPs = "0448" 
                    MessageBox.Show(LangText.GetString("Ideaspad_IBFNewer").Replace("[Program]", gProgName).Replace("[CR2]", _
                        Environment.NewLine & Environment.NewLine), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props
                    Dim NewCFU As New frmCFU(gbooAlwaysOnTop)
                    With NewCFU
                        .Caption = NameMe("")
                        '.FormIcon = Me.Icon
                        
                        .FormIcon = New System.Drawing.Icon( _
                            System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico"))
                        .strManifestSite(gstrManifestSite)
                        .ShowDialog()
                    End With
                    ProcessAnyCFU()
                    Exit Sub
                End If
            End If
            
            gstrMRPs = "0460"
            

            


            'Try
            If lbooStartupTimed = True Then : lstrStartupDebug &= CR() & "L " & DateDiffGet(strman.DateInterval.Second, gdatSystemStart, Date.Now)
                MessageBox.Show(lstrStartupDebug)
            End If

            CheckForCrashOrProbReport(False, False, ipSplashScr) 


            If lflaDBResult = 2 Then

                Dim Pad As New frmPad() 

                'Pad.MaximumSize = New Size(100, 200) 

                '------
                System.Windows.Forms.Application.DoEvents() 'for splash screen
                gstrMRPs = "0466"
                ipSplashScr.Dispose()
                ipSplashScr = Nothing
                '------
                'Pad.ShowDialog() 

                Dim DebugIPD As New IO.FileInfo(System.IO.Path.GetDirectoryName( _
                 System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\DEBUGBUGIPD.TXT") 

                If DebugIPD.Exists = False Then 
                    ''----- LIVE CODE ----
                    Try
                        Dim eh As CustomExceptionHandler = New CustomExceptionHandler()
                        AddHandler Application.ThreadException, AddressOf eh.OnThreadException
                        gstrMRPs = "0470"
                        Application.Run(Pad) 'New frmPad())  

                    Catch

                    End Try
                    ''----- LIVE CODE ----
                Else 
                    '----- TESTING CODE ----
                    'Try
                    Pad.ShowDialog()
                    'Catch ex As Exception
                    '    MessageBox.Show(ex.ToString)
                    'End Try
                    '----- TESTING CODE ----
                End If 

                'UpdateFlames()

                CheckDates(gstrDBFlamer, 0, lstrProbComtStack) 'added zero for ideaspad 

                If lstrProbComtStack <> "" Then 
                    AddDebugComment(lstrProbComtStack) 
                End If

                ProcessAnyCFU() 

                If gbooNeedToRestartProgAfterCFU = True And gstrCFUTempDir <> "" Then 
                    Exit Sub 
                Else 

                    'If InStrGet((NameMe("")).ToUpper, "SHAREWARE") > 0 Then 
                    '    Dim Remind As New frmRemind() 
                    '    remind.ShowRTFHelp = False 
                    '    'Remind.ShowDialog() 
                    '    remind.Show() 
                    '    Application.Run(remind) 
                    'End If
                End If 
            Else
                    'Dim passout As New frmPassOut()

                    ' Dim Remind As New frmRemind() 
                    '------
                    System.Windows.Forms.Application.DoEvents() 'for splash screen

                    ipSplashScr.Dispose()
                    ipSplashScr = Nothing
                    '------
                    'passout.ShowDialog()
                    If InStrGet(NameMe("").ToUpper, "TRIAL") > 0 Then 
                        Dim Remind As New frmRemind() 
                        Remind.ShowRTFHelp = True 
                        Remind.ShowDialog() 
                    End If
                End If
                'Catch e As System.Runtime.InteropServices.COMException
                '    lstrErrMsg = e.Message 
                '    lstrErrMsg = lstrErrMsg.Replace("IPUser", "ADMIN")

                '    'mxessagebox.show(lstrErrMsg, NameMe("")) 'commented out 
                'Catch ex As Exception 
                '    lstrErrMsg = ex.Message & Environment.NewLine 
                'End Try
            End If 

        '
        'If lstrErrMsg <> "" Then

        '    MessageBox.Show(lstrErrMsg & LangText.GetString("Ideaspad_ErrorThenCFU").Replace("[CR2]", _
        '        Environment.NewLine & Environment.NewLine).Replace("[CR]", _
        '        Environment.NewLine), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props

        '    Dim NewCFU As New frmCFU()
        '    With NewCFU
        '        .Caption = NameMe("")
        '        '.FormIcon = Me.Icon
        '        .strManifestSite(gstrManifestSite)
        '        .ShowDialog()
        '    End With

        '    ProcessAnyCFU()
        'End If
        '

Exhaust:
        'Try : SaveSetting("MRP", gstrMRPs, InitalXMLConfig.XmlConfigType.AppSettings, "") : Catch : End Try 
        SaveSetting("CRS.", "NO", InitalXMLConfig.XmlConfigType.AppSettings, "") 
        SaveMaxReachedPoint() 
    End Sub
    Private Function x(ByVal pstrString As String) As String
        Dim lintArrInc As Integer
        Dim lstrChar As String

        For lintArrInc = 0 To pstrString.Length - 1
            lstrChar = Microsoft.VisualBasic.Mid(pstrString, lintArrInc + 1, 1)
            If Microsoft.VisualBasic.Asc(lstrChar) >= 48 And Microsoft.VisualBasic.Asc(lstrChar) <= 57 Then
                x &= lstrChar
            End If
        Next lintArrInc
    End Function
    Function AcceptLicense(ByVal pform As Form) As Boolean
        Dim dlgResult As DialogResult
        Dim lAcceptReg As New AcceptReg()
        With lAcceptReg

            
            Dim lintUserLicensesBefore As Integer
            Try
                lintUserLicensesBefore = GetUserLicenseNumber()
            Catch
            End Try
            

            AcceptLicense = False 
            .Caption = NameMe("")

            .ProdName = gProgName & " " & gYear 
            dlgResult = .ShowDialog()

            If dlgResult = DialogResult.OK Then
                'create temp license file
                Dim lstrTemp As String
                Dim clsEnc As New MyCrypto()
                'Dim x As String = .LicenseCode

                'x = x.Replace(" ", "").Replace("LICENSE", "").Replace("START", "").Replace("END", "").Replace(Environment.NewLine, "")
                '
                'x = x.Replace(" ", "").Replace("Lizenzbeginn", "").Replace("Lizenzende", "").Replace(Environment.NewLine, "")
        
                If x(.LicenseCode) = "" Then
                    If gbooAlwaysOnTop = True Then pform.Activate() 
                    MessageBox.Show(LangText.GetString("Ideaspad_LicenseNotAccepted"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Function
                End If
        
                lstrTemp = clsEnc.Encrypt(x(.LicenseCode), "bUnn1es#j*mp@thr")
                clsEnc = Nothing

                Dim lstrEncFile As String = System.IO.Path.GetDirectoryName( _
                    System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\Temp-" & _
                    Date.Now.ToString("dddd-dd-MMM-yyyy-HH-mm-ss") & ".tmp"

                
                ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1)
                lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = lstrEncFile

                Dim lintFreeFile As Integer = Microsoft.VisualBasic.FreeFile()
                Microsoft.VisualBasic.FileOpen(lintFreeFile, lstrEncFile, Microsoft.VisualBasic.OpenMode.Output)
                Microsoft.VisualBasic.Print(lintFreeFile, lstrTemp)
                Microsoft.VisualBasic.FileClose(lintFreeFile)

                'check license
                Dim lintCheck As Integer = 16
                Try
                    lintCheck = Unlock(lstrEncFile, Nothing, "", "") 'added ,"" 
                Catch

                End Try

                If lintCheck <> 245 + 12 Then
                    'mxessagebox.show("Your license code was not accepted!", NameMe(""))
                    If gbooAlwaysOnTop = True Then pform.Activate() 
                    MessageBox.Show(LangText.GetString("Ideaspad_LicenseNotAccepted"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

                    Try
                        System.IO.File.Delete(lstrEncFile)
                    Catch
                        'moved furthed up 
                        'ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1)
                        'lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = lstrEncFile
                    End Try
                Else

                    'store license
                    Try
                        System.IO.File.Delete(System.IO.Path.GetDirectoryName( _
                        System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\keyfile.mcl")
                    Catch
                    End Try

                    System.IO.File.Copy(lstrEncFile, System.IO.Path.GetDirectoryName( _
                        System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\keyfile.mcl")

                    
                    'if buy more users licenses reset previously revoked users
                    'so if Mr X has several databases and has revoked people they now want to use the database
                    'Mr X must put old license in then new license into every database to reset them
                    Try
                        If GetUserLicenseNumber() > lintUserLicensesBefore Then
                            ResetRevokes()
                        End If
                    Catch
                    End Try
                    
                    If gbooAlwaysOnTop = True Then pform.Activate() 
                    'mxessagebox.show("Your license code was accepted!", NameMe(""))
                    MessageBox.Show(LangText.GetString("Ideaspad_LicenseAccepted"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 

                    AcceptLicense = True 
                    mintVersion = 32
                End If
            End If
        End With
    End Function
    Friend Function IsNewer(ByVal pstrDownloadVersion As String) As Boolean
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
            'llngFullThisNumber = CLng(.ProductMajorPart & .ProductMinorPart & .ProductBuildPart & .ProductPrivatePart)

            llngFullThisNumber = CLng(.ProductMajorPart) & threedigs(.ProductMinorPart) & threedigs(.ProductBuildPart) & _
                threedigs(.ProductPrivatePart) 

            ' pThisVerNumber = .ProductMajorPart & "." & .ProductMinorPart & "." & .ProductBuildPart & "." & .ProductPrivatePart 

        End With

        If llngFullPassNumner > llngFullThisNumber Then 
            IsNewer = True
        End If


    End Function
    Friend Sub BlackKeys(ByRef lstrKeys() As String)

        ReDim lstrKeys(3)

        'added 
        Dim lstrDetails(3) As String

        '--- Lou Jansen ---
        'lstrDetails(0) = "33Ju@XGE=;S<tdbHEi"
        'lstrDetails(1) = "NYub>UPM[Hu\EeSV;fmLD>CuQ[QfA=^kiLGUZw\elLeyLTi[DOdHk<qX`\<_DU\Of]mbLp"
        'lstrDetails(2) = "WyUjxRlVpk>]oXvcVBBCFXVu[k\bvwt>xLcUESn_I>>h\fIUYmOSlwbDa<pf>;YUgo=VeU"
        'lstrDetails(3) = "pSVyZE<_[dNOn;[axQZ[v=gdaLzOgF>hX`VdBXwVcha\_XkCzO=Z"
        
        lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        lstrDetails(1) = "KHB;wMV;IDR;IrW;BIV;AVN;KVU;KRr;WBI;VAV;NKV;UKR;rWB;IVA;VNK;VUK;RrW;NJ"
        lstrDetails(2) = "V;PNI;RHG;CNJ;BJr;Wed;hff;hgd;wf_;]bd;rWf;KPf;egg;gTR;eec;c_c;ErW;NSR;"
        lstrDetails(3) = "VDG;VSw;egg;cwj;wfw;DNI;PKR;wBD;REw;KNT;RID;R]g;fBm<"
        

        Dim lstrRetVal As String
        lstrRetVal = Decrypt("", "", flame.Encops.EncryptString, lstrDetails)
        lstrKeys(0) = lstrRetVal 
        '--- Lou Jansen ---

        '--- Lou Jansen - Refund ---
        'lstrDetails(0) = "33?wI>@qApixTEsD[h"
        'lstrDetails(1) = "dzSw[rv<lrh\[Ttl[kgU`mShAoY]bJjZYMwBmcgIkEPBjTeVPY=Cf?qMPBvwaGwH;Nw><L"
        'lstrDetails(2) = "ykCmiUB?S]PBBhqwxZXVnTgWhsy_>AicSUMgxhhJM\vj<Qvf<zV^EVPiimrgPtfHjcY_Vj"
        'lstrDetails(3) = "FluWm<;R[]e\J;HPgWy`sQulbqBtmc@?LxcON\aWEHQH`vzzGp]B"
        
        lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        lstrDetails(1) = "KHB;wMV;IDR;IrW;BIV;AVN;KVU;KRr;WBI;VAV;NKV;UKR;rWB;IVA;VNK;VUK;RrW;NJ"
        lstrDetails(2) = "V;PNI;RHG;CNJ;BJr;Wg_;hfe;hgd;wga;]eg;rWf;KPf;egg;gTR;eec;c_c;ErW;NSR;"
        lstrDetails(3) = "VDG;VSw;egg;cwj;wfw;DNI;PKR;wBD;REw;KNT;RID;R]g;fBm<"
        

        lstrRetVal = Decrypt("", "", flame.Encops.EncryptString, lstrDetails)
        lstrKeys(1) = lstrRetVal
        lstrRetVal = ""
        ReDim lstrDetails(3) '0)
        '--- Lou Jansen - Refund ---

        '--- SoftDeko --- 
        'lstrDetails(0) = "33VLVkJudmz]vPiXM`"
        'lstrDetails(1) = "c>jmZcQ_EMQJYu_R<r;;dL]>vVITn?[VBv^GDzRbd=r`;U_pxo[RsQaA@S;BOAFNqe[`wM"
        'lstrDetails(2) = "KJVHpi_qEM[nW\<EEPHoBxOHyKid@RI<NsTezh]WA_dZrYvxpuhzC^>`?WLrsaYTBbJuHY"
        'lstrDetails(3) = "`GW;=kr_AOgW]Xs`zLBcsNoB>ZRpBMFsRf;tyWpw^SS"
        
        lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        lstrDetails(1) = "SVQ;>SS;wUR;AVI;rWG;K@J;Gwr;WTR;ERS;NPN;HIw;rWP;ERV;CwU;ENC;VNI;rWD;HQ"
        lstrDetails(2) = "C;SRL;HrW;fch;ffh;gdw;f`];far;Wgf;Pde;dcf;LTd;`e`;ff^;rWN;SRV;DGV;Swe;"
        lstrDetails(3) = "ggc;wjw;fwD;NIP;KRw;BDR;EwK;NTR;IDR;]gf;Bm?"
        

        lstrRetVal = Decrypt("", "", flame.Encops.EncryptString, lstrDetails)
        lstrKeys(2) = lstrRetVal
        lstrRetVal = ""
        ReDim lstrDetails(3) '0)
        '--- SoftDeko --- 

        '--- Shareware Junction --- 
        'lstrDetails(0) = "33@PEQ<fJCuxtfJ?Qv"
        'lstrDetails(1) = "SvUXWZorR>^R_XQ]czmE;K>rV\^ejyYtFFK[PEGKPvoogaN<EsAUMQYQksSffngyhevApZ"
        'lstrDetails(2) = "DVFJqjrwLeanwvZ]ZuALvehbINfBVkrPW<[hX=JOWAZDwDjfyYAHw[Hububb@jbTzJAABX"
        'lstrDetails(3) = "Sq`CnySfzIUnyazGGE@Cgfkcy@JFY_b?zzw<PDCFg\_zOCKDGuEmKUXrPdM?FVNq@;"
        
        lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        lstrDetails(1) = "DOV;ER@;VER;wMB;ITC;NHI;wER;ANR;@Dr;WDC;Riw;Rjc;fcr;WKV;PBI;VwO;NKK;Dr"
        lstrDetails(2) = "W;BIN;CRS;wDC;VCR;DrW;ERA;NR@;rWg;_hf;fhg;dwg;`]d;arW;gfP;ded;cfL;Td`;"
        lstrDetails(3) = "e`f;f^r;WNS;RVD;GVS;weg;gcw;jwe;wDN;IPK;RwB;DRE;wKN;TRI;DR];geB;mK"
        

        lstrRetVal = Decrypt("", "", flame.Encops.EncryptString, lstrDetails)
        lstrKeys(3) = lstrRetVal
        lstrRetVal = ""

        '--- Shareware Junction --- 

        ReDim lstrDetails(0)

    End Sub
    Friend Function DataFileProductIdent(ByVal pstrProductNumber As String) As String
        'added 

        'not used in Ideaspad

    End Function
    Friend Function RBDecypt(ByVal pstrInputFile As String) As String
        'not in use in Ideaspad 
    End Function
    Friend Function SaveMaxReachedPoint()

        'added 
        Dim prevMRP As Integer
        Dim CurrentMRP As Integer = Val(gstrMRPs)
        Dim SaveMRP As Boolean = False

        Const frmPadActivated As Integer = 863
        Const DidntCreateDB As Integer = 396


        If CurrentMRP > prevMRP Then
            SaveMRP = True
        End If

        If SaveMRP = True Then
            Try : SaveSetting("MRP", gstrMRPs, InitalXMLConfig.XmlConfigType.AppSettings, "") : Catch : End Try
        End If

    End Function
    Function CheckEmailAddress(ByVal email As String) As String
        Dim FirstOcrDot
        Dim FirstOcrAt
        Dim lastOcrDot

        Try : email = Microsoft.VisualBasic.Trim(email) : Catch : End Try 

        lastOcrDot = Microsoft.VisualBasic.InStrRev(email, ".")
        FirstOcrDot = CInt(Microsoft.VisualBasic.InStr(1, email, "."))
        FirstOcrAt = CInt(Microsoft.VisualBasic.InStr(1, email, "@"))

        If Microsoft.VisualBasic.Len(email) > 5 Then
            If FirstOcrAt > 0 Then
                If Microsoft.VisualBasic.Mid(email, FirstOcrAt + 1, 1) <> "." And Microsoft.VisualBasic.Mid(email, FirstOcrAt - 1, 1) <> "." Then
                    If Microsoft.VisualBasic.InStr(1, email, " ") = 0 Then
                        If Microsoft.VisualBasic.InStrRev(email, ".") > CInt(FirstOcrAt) + 1 Then
                            If lastOcrDot < Microsoft.VisualBasic.Len(email) - 1 Then
                                If FirstOcrAt < Microsoft.VisualBasic.Len(email) - 1 And FirstOcrAt > 1 Then
                                    If FirstOcrDot > 1 Then
                                        CheckEmailAddress = email '""
                                        Exit Function
                                    Else
                                        'Response.Write "Dot in starting<br>"
                                    End If
                                Else
                                    'Response.Write "@ Not between first and last<br>"
                                End If
                            Else
                                'Response.Write ". before last two chars<br>"
                            End If
                        Else
                            'Response.Write "Last Dot after @ missing or @ and . are not seperated by a Char<br>"
                        End If
                    Else
                        'Response.Write "Space Not Allowed<br>"
                    End If
                Else
                    'Response.Write "A Dot Just before or after @ not allowed<br>"
                End If
            Else
                'Response.Write "A required Character Missing<br> "
            End If
        Else
            'Response.Write "Email cannot be less than 6 characters<br> "
        End If

        CheckEmailAddress = ""

    End Function
End Module
Friend Class CustomExceptionHandler 'created 
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly())
    Friend pMe As Form 
    Friend Sub OnThreadException(ByVal sender As Object, ByVal t As System.Threading.ThreadExceptionEventArgs)

        Dim lstrErrMsg As String = "Unknown Error" 

        'Try : SaveSetting("MRP", gstrMRPs, InitalXMLConfig.XmlConfigType.AppSettings, "") : Catch : End Try 
        SaveMaxReachedPoint() 
        Try
            If Not t Is Nothing Then 
                If InStrGet(t.Exception.ToString, "System.Runtime.InteropServices.COMException") > 0 Then
                    lstrErrMsg = t.Exception.Message
                    'lstrErrMsg = lstrErrMsg.Replace("IPUser", "ADMIN")
                    
                    lstrErrMsg &= lstrErrMsg.Replace("IPUser", "ADMIN")
                Else
                    lstrErrMsg = t.Exception.Message & Environment.NewLine
                End If
            End If
            'CFU etc here
            Try
                If lstrErrMsg <> "" Then
                    If Not pMe Is Nothing Then 
                        If gbooAlwaysOnTop = True Then pMe.Activate() 
                    End If
                    MessageBox.Show(lstrErrMsg & LangText.GetString("Ideaspad_ErrorThenCFU").Replace("[Program]", gProgName).Replace("[CR2]", _
                        Environment.NewLine & Environment.NewLine).Replace("[CR]", _
                        Environment.NewLine) & Environment.NewLine & Environment.NewLine & _
                        "Pos: " & gstrMRPs, NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Dim NewCFU As New frmCFU(gbooAlwaysOnTop)
                    With NewCFU
                        .Caption = NameMe("")
                        '.FormIcon = Me.Icon
                        
                        .FormIcon = New System.Drawing.Icon( _
                            System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico"))
                        .strManifestSite(gstrManifestSite)

                        Application.DoEvents() 

                        .ShowDialog()
                    End With

                    
                    'Dim lstrError As String = "<Font color=Red>MSG:" & t.Exception.Message & "<BR>ST:" & t.Exception.StackTrace & " <BR>SRC:" & _
                    '    t.Exception.Source & "</font>"
                    'INMSG:" & ex.InnerException.Message & "</font>"
                    
                    Dim lstrError As String = ""
                    If Not t Is Nothing Then
                        'lstrError = "<Font color=Red>MSG:" & t.Exception.Message & "<BR>ST:" & t.Exception.StackTrace & " <BR>SRC:" & _
                        '    t.Exception.Source & "</font>"
                        lstrError = "<Font color=Red>MSG:" & t.ToString & "<BR>{" & lstrErrMsg.Replace(Environment.NewLine, "") & "}</font>"
                    End If
                    

                    If lstrError <> "" Then 
                        AddDebugComment(lstrError)
                    End If 

                    DebugDBComment() 

                    If gbooNeedToRestartProgAfterCFU = True And gstrCFUTempDir <> "" Then
                        Dim lstrReportNames() As String
                        LoadReportsNames(lstrReportNames)
                        DumpThisErrorLog(NameMe(""), lstrReportNames, gdatSystemStart) 'added gdatSystemStart 
                    Else
                        Dim ErrRep As New ProbHand.BugReport(gbooAlwaysOnTop)
                        With ErrRep
                            .SysStartTime = gdatSystemStart 
                            .Caption = NameMe("")
                            
                            .FormIcon = New System.Drawing.Icon( _
                                System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico"))

                            Application.DoEvents() 

                            .ShowDialog()
                        End With
                    End If

                    ProcessAnyCFU()
                End If
            Catch
                '
            End Try
        Finally
            'Application.Exit()
            Environment.Exit(0)
        End Try

    End Sub
End Class
<DoNotObfuscateAttribute()> Friend Module Base
    <DoNotObfuscateAttribute()> Friend gstrManifestSite(1) As ManifestInfo
    <DoNotObfuscateAttribute()> Friend gdatSystemStart As Date
    <DoNotObfuscateAttribute()> Friend gconstrConnectionProvider As String
    <DoNotObfuscateAttribute()> Friend gconstrConnectionJustProvider As String
    '<DoNotObfuscateAttribute()> Friend DBChoice As New frmDBChoice()
    <DoNotObfuscateAttribute()> Friend gstrDataFileName As String
    <DoNotObfuscateAttribute()> Friend gstrConnectionString As String
    '<DoNotObfuscateAttribute()> Friend el As Boolean = False 'False ' error logging
    '<DoNotObfuscateAttribute()> Friend elEvts As Boolean = False ' error logging
    '<DoNotObfuscateAttribute()> Friend elEvtsRTB As Boolean = False ' error logging
    '<DoNotObfuscateAttribute()> Friend elEvtsRTBDragDrog As Boolean = False ' error logging
    <DoNotObfuscateAttribute()> Friend gstrSortOrder As String
    <DoNotObfuscateAttribute()> Friend lstrDBID As String = "" 
    <DoNotObfuscateAttribute()> Friend gintMoveBranchIncr As Integer = 0 
    <DoNotObfuscateAttribute()> Friend gintThreadEnd As Integer = -1 
    <DoNotObfuscateAttribute()> Friend gstrLastSQL As String 
    <DoNotObfuscateAttribute()> Friend gstrMRPs As String 
    Friend Structure TreeTopics
        Dim strTopicCode As String
        'Dim strTreePath As String
    End Structure
    <DoNotObfuscateAttribute()> Friend m_PageSettings As New PageSettings()
    <DoNotObfuscateAttribute()> Friend glngLastTopicNum As Long
    <DoNotObfuscateAttribute()> Friend gDBClstDatabaseDisplay As String = "lstDatabaseDisplay"
    <DoNotObfuscateAttribute()> Friend gDBCcmdSelect As String = "cmdSelect"
    <DoNotObfuscateAttribute()> Friend gDBCcmdMaint As String = "cmdMaint"
    <DoNotObfuscateAttribute()> Friend gDBCcmdQuit As String = "cmdQuit"
    <DoNotObfuscateAttribute()> Friend gDBClstShortNames As String = "lstShortNames"
    <DoNotObfuscateAttribute()> Friend gDBCLabel1 As String = "Label1"
    <DoNotObfuscateAttribute()> Friend gDBCLabel4 As String = "Label4"
    <DoNotObfuscateAttribute()> Friend gDBClstDatabase As String = "lstDatabase"
    <DoNotObfuscateAttribute()> Friend gDBCchkDontAskAgain As String = "chkDontAskAgain"
    <DoNotObfuscateAttribute()> Friend gDBCName As String = "frmDBChoice"
    <DoNotObfuscateAttribute()> Friend gProgName As String = "Ideaspad"
    <DoNotObfuscateAttribute()> Friend gYear As String = "2008" 
    <DoNotObfuscateAttribute()> Friend gstrProbComtStack As String = "" 
    <DoNotObfuscateAttribute()> Friend gbooAlwaysOnTop As Boolean 

End Module
<System.AttributeUsage(AttributeTargets.Class Or AttributeTargets.Field _
Or AttributeTargets.Method Or AttributeTargets.Parameter Or AttributeTargets.Enum)> _
Friend Class ObfuscateAttribute
    Inherits System.Attribute
End Class 'ObfuscateAttribute

<System.AttributeUsage(AttributeTargets.Class Or AttributeTargets.Field _
Or AttributeTargets.Method Or AttributeTargets.Parameter Or AttributeTargets.Enum)> _
Friend Class DoNotObfuscateAttribute
    Inherits System.Attribute
End Class 'DoNotObfuscateAttribute

<System.AttributeUsage(AttributeTargets.Assembly, allowmultiple:=True)> _
Friend Class ObfuscateBlockAttribute
    Inherits System.Attribute
    Private BlockString As String
    Public Sub New(ByVal BlockString As String)
        MyClass.BlockString = BlockString
    End Sub
End Class 'ObfuscateBlockAttribute
'<Assembly: ObfuscateBlock("SomeString")>

