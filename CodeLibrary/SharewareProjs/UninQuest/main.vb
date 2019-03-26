Imports System.IO
Friend Module main
    Dim errTrace As Boolean = False 'True
    Friend Sub Main()
        If errTrace = True Then MessageBox.Show("Start Pos 0")
        Main(Environment.GetCommandLineArgs())
    End Sub

    Private Sub Main(ByVal args() As String)

        '------------------ crc check -------------------------
        Dim IRes As Integer

        'With Environment.Version
        '    'Return .Major & "-" & .Build   '& "." & .Minor & "." & .Revision
        '    MessageBox.Show("Currently using Dotnet Framework " & .Major & "." & .Build & "." & .Minor & "." & .Revision)
        'End With

        If errTrace = True Then MessageBox.Show("Start Pos A")

        IRes = GetWrittenCRC(AppExe)

        If errTrace = True Then MessageBox.Show("Start Pos B1")

        Dim AppShort As String = ""
        Try : AppShort = args(1) : Catch : IRes = -1 : End Try

        If errTrace = True Then MessageBox.Show("Start Pos B2")

        '==== TESTING PURPOSES ONLY ====
        'IRes = 1
        'AppShort = "IPD"
        '==== TESTING PURPOSES ONLY ====

        Dim lstrDetails(3) As String 
        'Dim lstrDetails(2) As String '3) As String
        Dim lstrRetVal3 As String


        'lstrDetails(0) = "33WWy]JrZe@EpAI=Zl"
        'lstrDetails(1) = "KHRz?dGj[d[FSoy_blHjPZT>\ydexWtDFsHdfWMeK>oRpQjz;puMd?qeRVH]kUvCfuhSFp"
        'lstrDetails(2) = "H\GAVhjWOlkxO<]FP]qPbGBGmOfjQ=lomAYjc`Wmf_yzAzZav]<RQQhitxflGPGzAHPijf"
        'lstrDetails(3) = "Rq;Uvc=arLPQDPrkfiQSDvOxoH^cpXS"
        
        lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        lstrDetails(1) = "xUG;QVU;JGmPpmpPwKJ;AHQ;SRF;QZHpJJFPZmQKLVC;YHJ;ZwKKLGE;NFY;LWA;ZnFKVL"
        lstrDetails(2) = "m@pyNKNZH?QSR;FGZ<HUG;UHD;UVL<mpmPpfRKQGZ<JHK;SHY;MZQ?GZE?GUZ<TKH;ZEGK"
        lstrDetails(3) = "UZX?AZF?RUZ<MYQ;LZJ?HKS;HYM;LmO"
        

        If errTrace = True Then MessageBox.Show("Start Pos C")

        lstrRetVal3 = Decrypt(lstrDetails)
        ReDim lstrDetails(0)

        If IRes = 1 Then
            '
        ElseIf IRes = -1 Then
            MessageBox.Show(lstrRetVal3, "Beside03")
            End
            GoTo Exhaust
        Else
            MessageBox.Show(lstrRetVal3, "Beside03")
            End
            GoTo Exhaust
        End If
        lstrRetVal3 = ""
        '------------------ crc check -------------------------

        If errTrace = True Then MessageBox.Show("Start Pos D")

        Dim AppName As String
        Dim UniPage As String
        Dim Param As String


        ReDim lstrDetails(4)
        ''lstrDetails(0) = "33BPvnDr@]y?gMDmZ?"
        ''lstrDetails(1) = "AQJhSpy_r_tv<^AibauRLQs;XRV]D_WmQI=TZTzvx<yBF\]=dCjV^xnxltJmKh>\G`[jqK"
        ''lstrDetails(2) = "<vV`Qr<nwED\PQhQQaR<XDNqtatJB;zvNlPCXK^PNQotoilz<TAcQecpU<ogH^Vw`rergp"
        ''lstrDetails(3) = "uwn<AyCdVDLbal?\hqe^gS\RKPlrnmFHLmd<UeBrOoobHnSJyF]Z]oJmGSWHLdrbhEyd`J"
        ''lstrDetails(4) = "qGvK]f"
        
        'lstrDetails(0) = "33vK>q;aOqHArBeO\U"
        'lstrDetails(1) = "zUIi;OVy]eCs^GtxgAOfS;uykxkx`jsWmiDBOK;Av]vR<yYpWjiZi?JQqlyXHPBTpC]Nj?"
        'lstrDetails(2) = "ZmOEIIXzriF<YHAjXsDfFU[XsT<RN`ieASKJkACblweCg<S;TzQLxY>ux;fU_Zf]C`SjSa"
        'lstrDetails(3) = "qxNSJDXIw[BqmikGdPzGzbu]Ye<Myg>f_>TZLNKOH<B[NwDBtjb@EjDktz=srveZATk;vo"
        'lstrDetails(4) = "JxlkgEOsGgS<v[i`s"
        '
        'lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        'lstrDetails(1) = "nYL;SEY;SUN<eGU;ZfUKMJN;YFU;ZxAKZvUKTYE;NFN<vQW;FQK;LYH;AtQ;NUN<vUT;YE"
        'lstrDetails(2) = "N;FZq?LTK;HMY;FQK;LZx?YGU;ZtQKNUN<gRK;HFl;YMU;N^uKHHK;HvE;MJG;^N^?nYA;"
        'lstrDetails(3) = "KEF;G^N<LVYKFN^?OUA;TQN;ULM?WNW<JNHPNENPCNAPNINPGNEPNCNPAWIPNGNPDNBPNJ"
        'lstrDetails(4) = "NPHNFPNDNPBNJPWmO"
        '

        '--- 
        lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        lstrDetails(1) = "nYL;SEY;SUN<eGU;ZfUKMJN;YFU;ZxAKZvUKTYE;NFN<vQW;FQK;LYH;AtQ;NUN<vUT;YE"
        lstrDetails(2) = "N;FZq?LTK;HMY;FQK;LZx?YGU;ZtQKNUN<gRK;HFl;YMU;N^uKHHK;HvE;MJG;^N^?nYA;"
        lstrDetails(3) = "KEF;G^N<LVYKFN^?OUA;TQN;ULM?WNN<hUM;YQL;GEX;WJNPHNEPNCNPANIPNGNPENCPNA"
        lstrDetails(4) = "WPINGPNDNPBNJPNHNPFNDPNBNPJWmP"
        '--- 

        '=== Arrays ==
        'Language,Use Template By Default,DictionaryFile,Default Information Base File,ShortName,\ErrorDumps\,\Layouts\,.dat,\keyfile.mcl#0,2,5,7,9,1,3,5,7,9#1,3,6,8,0,2,4,6,8,0#
        '"Language", "Use Template By Default", "DictionaryFile", "Default Information Base File", _
        '    "ShortName", "\ErrorDumps\", "\Layouts\", ".dat", "\keyfile.mcl"
        'Dim vvOn() As String = {"0", "2", "5", "7", "9", "1", "3", "5" ,7 ,9}
        'Dim vOff() As String = {"1", "3", "6", "8", "0", "2", "4", "6" ,8 ,0}

        If errTrace = True Then MessageBox.Show("Start Pos E1")

        lstrRetVal3 = Decrypt(lstrDetails)

        If errTrace = True Then MessageBox.Show(lstrRetVal3)

        If errTrace = True Then MessageBox.Show("Start Pos E2")
        ReDim lstrDetails(0)

        Dim BasicSplit() As String = Split(lstrRetVal3, "#")
        If errTrace = True Then MessageBox.Show("Start Pos E3")
        lstrRetVal3 = ""

        Dim SetsArr() As String = Split(BasicSplit(0), ",")
        If errTrace = True Then MessageBox.Show("Start Pos E4")
        Dim vvOn() As String = Split(BasicSplit(1), ",")
        If errTrace = True Then MessageBox.Show("Start Pos E5")
        Dim vOff() As String = Split(BasicSplit(2), ",")
        If errTrace = True Then MessageBox.Show("Start Pos E6")
        ReDim BasicSplit(0)

        If errTrace = True Then MessageBox.Show("Start Pos F")

        '=== Arrays ==

        Dim OS As Integer = GetOSVersion() 
        Dim fx As Integer = GetDotNetFXVer() 

        
        Dim mdac As String = vOff(8)
        If GetMDACVerNum() >= 2.7 Then
            mdac = vvOn(8)
        End If
        Dim jet As String = vOff(9)
        If IsJet4Installed() = 1 Then
            jet = vvOn(9)
        End If
        

        
        '3 digs
        Dim FxVers As String = GetInstalledFxVers()
        

        If errTrace = True Then MessageBox.Show(AppShort)

        'Moved from further down 
        Dim ThisDir As String = Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location)

        Dim HostURL As String 

        
        Select Case AppShort
            Case "IPD"
                AppName = "IdeasPad.exe"
            Case "MDBS"
                AppName = "MDBSecure.exe"
            Case "HTMLS"
                AppName = "HTMLSqueeze.exe"
            Case "KMP"
                AppName = "KidsMaskPrint.exe"
        End Select

        Dim MainAppConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings, "", ThisDir & "\" & AppName & SetsArr(7))

        'SetsArr(9) 'aka Remainsub
        Dim MinsUsed As String = "0"
        Try
            MinsUsed = MainAppConfig.GetValue(SetsArr(9), "0")
            If MinsUsed.Length > 2 Then
                MinsUsed = "99"
            ElseIf MinsUsed.Length = 1 Then
                MinsUsed = "0" & MinsUsed
            End If
        Catch : End Try
        


        
        Dim MRP As String
        Try
            MRP = MainAppConfig.GetValue("MRP", "0000")
        Catch
        End Try
        

        
        Dim AppDayNum As String
        Try
            AppDayNum = System.IO.File.GetLastWriteTime(ThisDir & "\" & AppName).DayOfYear
        Catch
            AppDayNum = "000"
        End Try
        AppDayNum = threedigs(AppDayNum)
        

        
        Dim Crashed As String = MainAppConfig.GetValue("CRS.", "UNC")
        Dim Crash As String
        Select Case Crashed
            Case "YES"
                Crash = "1"
            Case "NO"
                Crash = "2"
            Case "UNC"
                Crash = "3"
            Case Else
                Crash = "4"
        End Select
        

        Select Case AppShort
            Case "IPD"
                UniPage = "ideaspad_uninstall.html"

                Dim lintArrInc As Integer
                Dim ibfCount As String = "00"
                Dim intibfCount As Integer = 0

                '=== Gather useage info ===
                Dim y As String = vOff(0)
                Dim y1 As String = vOff(1)
                Dim y2 As String = vOff(2)
                Dim y3 As String = vOff(3)

                Try
                    'Dim MainAppConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings, "", AppName & SetsArr(7)) '".dat")
                    
                    'Dim MainAppConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings, "", ThisDir & "\" & AppName & SetsArr(7))

                    y = MainAppConfig.GetValue(SetsArr(0), "") '"Language", "")
                    'If y = "" Then y = vvOn(0) Else y = vOff(0)
                    If y.ToUpper = "EN" Then y = vvOn(0) Else y = vOff(0) 

                    y1 = MainAppConfig.GetValue(SetsArr(1), "") '"Use Template By Default", "")
                    If y1 = "" Then y1 = vvOn(1) Else y1 = vOff(1)

                    y2 = MainAppConfig.GetValue(SetsArr(2), "") '"DictionaryFile", "")
                    If y2 = "" Then y2 = vvOn(2) Else y2 = vOff(2)

                    y3 = MainAppConfig.GetValue(SetsArr(3), "") '"Default Information Base File", "")
                    If y3 = "" Then y3 = vvOn(3) Else y3 = vOff(3)

                    For lintArrInc = 0 To 20
                        If MainAppConfig.GetValue(SetsArr(4) & lintArrInc, "") <> "" Then '.GetValue("ShortName" & lintArrInc, "") <> "" Then
                            intibfCount += 1
                        End If
                    Next lintArrInc
                    ibfCount = twodigs(intibfCount)

                Catch : End Try

                If errTrace = True Then MessageBox.Show("Point 1")

                '--- Days since Dir Creation date ---
                Dim di As New DirectoryInfo(ThisDir)
                Dim daysInst As Integer
                daysInst = DateDiffGet(Overlap.DateInterval.Day, di.CreationTime, Date.Now)
                If daysInst > 999 Then
                    daysInst = 999
                End If

                Dim DaysInstalled As String = threedigs(daysInst)
                '--- Days since Dir Creation date ---

                If errTrace = True Then MessageBox.Show("Point 2")

                '--- if ErrorDumps exists, files count ---
                Dim ErrDumpDir As String = ThisDir & SetsArr(5) '"\ErrorDumps\"
                Dim edfc As String = "00"
                If Directory.Exists(ErrDumpDir) = True Then 'changed from file exists
                    Dim eddi As New DirectoryInfo(ErrDumpDir)
                    edfc = twodigs(eddi.GetFiles.Length)
                End If
                '--- if ErrorDumps exists, files count ---

                If errTrace = True Then MessageBox.Show("Point 3")

                '--- count of layout files ---
                Dim LayDir As String = ThisDir & SetsArr(6) '"\Layouts\"
                Dim ldfc As String = "00"
                If Directory.Exists(LayDir) = True Then 'changed from file exists
                    Dim lydi As New DirectoryInfo(LayDir)
                    ldfc = twodigs(lydi.GetFiles.Length)
                End If
                '--- count of layout files ---

                If errTrace = True Then MessageBox.Show("Point 4")

                Dim y4 As String = vOff(4) '3)
                If File.Exists(ThisDir & SetsArr(8)) = True Then 'keyfile
                    y4 = vvOn(4) '3)
                End If
                '=== Gather useage info ===

                
                Dim VerString As String = "00"
                Try
                    'VerString = GetAppVerNum(AppName)
                    
                    verstring = GetAppVerNum(ThisDir & "\" & AppName)
                Catch
                End Try
                

                If errTrace = True Then MessageBox.Show("Point 5")
                Param = "?session=" & OS & fx & y & y1 & y2 & y3 & y4 & ibfCount & _
                    DaysInstalled & edfc & ldfc & VerString & mdac & jet & FxVers & MinsUsed + MRP + AppDayNum + Crash

                'MsgBox("OS=" & OS & cr & _
                '    "fx=" & fx & cr & _
                '    "Lang=" & y & cr & _
                '    "UseTempsByDef=" & y1 & cr & _
                '    "DicFile=" & y2 & cr & _
                '    "DefIBF=" & y3 & cr & _
                '    "Keyfile=" & y4 & cr & _
                '    "ibfcount=" & ibfCount & cr & _
                '    "DaysInstalled=" & DaysInstalled & cr & _
                '    "ErrDumps=" & edfc & cr & _
                '    "NumLays=" & ldfc & cr & _
                '    "VerString=" & VerString & cr & "mdac=" & mdac & cr & _
                '    "jet=" & jet & cr & "FxVers=" & FxVers & cr & "MinsUsed=" & MinsUsed & cr & _
                '    "MRP=" & MRP & cr & "AppDayNum=" & AppDayNum + cr + "Crash=" & Crash)

                Clipboard.SetDataObject(Param)

                HostURL = "http://www.example.com/" 

                '1      = OS
                '2/3    = FX currently running
                '4      = y = language
                '5      = y1 = Use Template By Default
                '6      = y2 = DictionaryFile
                '7      = y3 = Default Information Base File
                '8      = y4 = Keyfile exists
                '9/10    = ibfcount
                '11/12/13 = Days installed
                '14/15  = ErrorDumps Dir exists
                '16/17  = Layouts directory created
                '18/19  = VerString
                '20     = MDAC 2.7 installed
                '21     = JetInstalled
                '22,23,24 = Framework Versions Installed
                '25,26 = Mins used, over 2 digs = 99
                '27,28,29,30 = MRP
                '31,31,33 = AppDayNum

                '710035790403900001579111


                'Case "MDBS"
                '    UniPage = "mdbsecure-uninstall.html"

                '    If errTrace = True Then MessageBox.Show("Point 6")
                '    '--- Days since Dir Creation date ---
                '    'Dim ThisDir As String = Path.GetDirectoryName( _
                '    '    System.Reflection.Assembly.GetExecutingAssembly().Location)
                '    Dim di As New DirectoryInfo(ThisDir)
                '    Dim DaysInstalled As String = twodigs(DateDiffGet(Overlap.DateInterval.Day, di.CreationTime, Date.Now))
                '    '--- Days since Dir Creation date ---

                '    If errTrace = True Then MessageBox.Show("Point 7")
                '    '--- if ErrorDumps exists, files count ---
                '    Dim ErrDumpDir As String = ThisDir & SetsArr(5) '"\ErrorDumps\"
                '    Dim edfc As String = "00" 
                '    If Directory.Exists(ErrDumpDir) = True Then 'changed from file exists
                '        Dim eddi As New DirectoryInfo(ErrDumpDir)
                '        edfc = twodigs(eddi.GetFiles.Length)
                '    End If
                '    '--- if ErrorDumps exists, files count ---
                '    If errTrace = True Then MessageBox.Show("Point 8")

                '    Dim y4 As String = vOff(3)
                '    If File.Exists(ThisDir & SetsArr(8)) = True Then 'keyfile
                '        y4 = vvOn(3)
                '    End If
                '    If errTrace = True Then MessageBox.Show("Point 9")

                '    
                '    Dim VerString As String = "00"
                '    Try
                '        'VerString = GetAppVerNum(AppName)
                '        
                '        verstring = GetAppVerNum(ThisDir & "\" & AppName)
                '    Catch
                '    End Try
                '    

                '    '
                '    ''--- if ErrorDumps exists, files count ---
                '    'Dim ErrDumpDir As String = ThisDir & SetsArr(5) '"\ErrorDumps\"
                '    'Dim edfc As String = "00"
                '    'If File.Exists(ErrDumpDir) = True Then
                '    '    Dim eddi As New DirectoryInfo(ErrDumpDir)
                '    '    edfc = twodigs(eddi.GetFiles.Length)
                '    'End If
                '    ''--- if ErrorDumps exists, files count ---

                '    Param = "?session=" & y4 & DaysInstalled & edfc & OS & fx & VerString & mdac & jet & FxVers & MinsUsed

                '    HostURL = "http://www.example.com/" 

                '    '1      = keyfile
                '    '2/3    = Days Installed
                '    '4/5    = ErrorDumps Dir exists
                '    '6      = OS Number 1-9
                '    '7/8    = FX currently running
                '    '9/10   = VerString
                '    '11     = MDAC 2.7 installed
                '    '12     = JetInstalled
                '    '13,14,15 = Framework Versions Installed
                '    '16,17 = Mins used, over 2 digs = 99

            Case "HTMLS"
                UniPage = "htmlsqueeze-uninstall.html"

                If errTrace = True Then MessageBox.Show("Point 10")
                '--- Days since Dir Creation date ---
                'Dim ThisDir As String = Path.GetDirectoryName( _
                '    System.Reflection.Assembly.GetExecutingAssembly().Location)
                Dim di As New DirectoryInfo(ThisDir)
                Dim DaysInstalled As String = threedigs(DateDiffGet(Overlap.DateInterval.Day, di.CreationTime, Date.Now))
                '--- Days since Dir Creation date ---

                If errTrace = True Then MessageBox.Show("Point 11")

                '--- if ErrorDumps exists, files count ---
                Dim ErrDumpDir As String = ThisDir & SetsArr(5) '"\ErrorDumps\"
                Dim edfc As Integer
                If Directory.Exists(ErrDumpDir) = True Then 'changed from file.exists 
                    Dim eddi As New DirectoryInfo(ErrDumpDir)
                    edfc = eddi.GetFiles.Length
                End If
                '--- if ErrorDumps exists, files count ---

                If errTrace = True Then MessageBox.Show("Point 12")

                Param = "?session=" & DaysInstalled & edfc & OS & fx

                HostURL = "http://www.example.com/" 

            Case "KMP"
                UniPage = "survey.php"

                'Dim lintArrInc As Integer


                If errTrace = True Then MessageBox.Show("Point 1")

                Dim intMaskCount As Integer
                Dim MaskCount As String = "000"
                If Directory.Exists(ThisDir & "\Masks\") = True Then
                    Dim mask As New DirectoryInfo(ThisDir & "\Masks\")
                    intMaskCount = mask.GetFiles.Length
                End If
                MaskCount = threedigs(intMaskCount)

                If errTrace = True Then MessageBox.Show("Point 2")

                Dim intPackCount As Integer
                Dim PackCount As String = "00"
                If Directory.Exists(ThisDir & "\FaceParts\") = True Then
                    Dim pack As New DirectoryInfo(ThisDir & "\FaceParts\")
                    intPackCount = pack.GetFiles.Length
                End If
                PackCount = twodigs(intPackCount)

                If errTrace = True Then MessageBox.Show("Point 3")


                'Dim MainAppConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings, "", ThisDir & "\" & AppName & SetsArr(7))

                Dim intUsercount As Integer = Occurences(MainAppConfig.GetValue("Users", ""), ChrGet(255)) + 1
                Dim UserCount As String = twodigs(intUsercount)

                If errTrace = True Then MessageBox.Show("Point 4")

                '--- Days since Dir Creation date ---
                Dim di As New DirectoryInfo(ThisDir)
                Dim DaysInstalled As String = threedigs(DateDiffGet(Overlap.DateInterval.Day, di.CreationTime, Date.Now))
                '--- Days since Dir Creation date ---

                If errTrace = True Then MessageBox.Show("Point 5")

                Dim ErrDumpDir As String = ThisDir & SetsArr(5) '"\ErrorDumps\"
                Dim edfc As String = "00"
                If Directory.Exists(ErrDumpDir) = True Then 'changed from file exists
                    Dim eddi As New DirectoryInfo(ErrDumpDir)
                    edfc = twodigs(eddi.GetFiles.Length)
                End If

                If errTrace = True Then MessageBox.Show("Point 6")

                Dim y4 As String = vOff(4) '3)
                If File.Exists(ThisDir & SetsArr(8)) = True Then 'keyfile
                    y4 = vvOn(4) '3)
                End If

                Dim VerString As String = "00"
                Try
                    verstring = GetAppVerNum(ThisDir & "\" & AppName)
                Catch
                End Try



                If errTrace = True Then MessageBox.Show("Point 7")

                Param = "?session=" & OS & fx & MaskCount & PackCount & UserCount & y4 & _
                    DaysInstalled & edfc & VerString & FxVers & MinsUsed + MRP + AppDayNum

                HostURL = "http://www.example.com/"

                Dim cr As String = Environment.NewLine




                
            Case Else
                Exit Sub
        End Select

        If errTrace = True Then MessageBox.Show("Point 13")

        
        If AppShort = "IPD" Then

            Dim sv As New Survey()
            sv.Session = Replace(Param, "?session=", "")
            sv.ShowDialog()
        Else
            
            If errTrace = True Then MessageBox.Show("Point 13B " & HostURL & UniPage & Param)

            If UniPage <> "" Then
                'Dim x As New Browse()
                Dim ErrNum As Integer 
                ErrNum = BrowseToUrl(HostURL & UniPage & Param, Nothing)
                If errTrace = True Then MessageBox.Show("Point 14 - " & ErrNum)
                'x = Nothing

            End If
        End If 

        If errTrace = True Then MessageBox.Show("Point 15 - All Done")

Exhaust:
    End Sub
    'Private Function ModReduce(ByVal strNum As String) As String
    '    Dim lintArrInc As Integer

    '    Dim Inp As Long = CLng(strNum)

    '    For lintArrInc = 9999 To 2 Step -1
    '        Dim Res As Integer = Inp Mod lintArrInc
    '        If Res = 0 Then
    '            ModReduce = (Inp / lintArrInc) & "-" & twodigs(lintArrInc)
    '            Exit Function
    '        End If

    '    Next lintArrInc

    'End Function
    Private Function GetAppVerNum(ByVal pstrProg As String) As String

        With System.Diagnostics.FileVersionInfo.GetVersionInfo(pstrProg)
            GetAppVerNum = (.FileMinorPart & .FileBuildPart)
        End With


    End Function
    Friend Sub AddDebugComment(ByVal pstrString As String)

    End Sub
End Module
