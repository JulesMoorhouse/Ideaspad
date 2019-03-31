Imports System.Windows.Forms.Design
Imports System.Text
Public Module WinOnly

    Public Sub WaitForBrowser(ByVal pMe As WebOCHostCtrl) 

        'If AxWebBrowser.ReadyState = SHDocVw.tagREADYSTATE.READYSTATE_LOADING Then
        '    Do Until AxWebBrowser.ReadyState <> SHDocVw.tagREADYSTATE.READYSTATE_LOADING '= SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE
        '        System.Windows.Forms.Application.DoEvents()
        '        'AxWebBrowser1.Refresh()
        '    Loop
        'End If

        Dim startTime As Date = DateTime.Now

        Do
            Application.DoEvents()
        Loop Until (pMe.Busy = False) Or _
            (DateTime.Now.Subtract(startTime).TotalSeconds > 5)

    End Sub
    
    Public Declare Function LockWindowUpdate Lib "User32" (ByVal hWnd As IntPtr) As Boolean
    Public Function IsWin98ME() As Boolean 

        IsWin98ME = False

        Dim osInfo As OperatingSystem
        osInfo = System.Environment.OSVersion

        With osInfo
            If .Platform = .Platform.Win32Windows Then
                Select Case (.Version.Minor)
                    Case 10 '= "Windows 98"
                        IsWin98ME = True
                    Case 90 '= "Windows Me"
                        IsWin98ME = True
                End Select
            End If
        End With
    End Function
    
    Public Function IsAboveOrEqualWinXp() As Boolean 

        IsAboveOrEqualWinXp = False

        Dim osInfo As OperatingSystem
        osInfo = System.Environment.OSVersion

        With osInfo

            If .Platform = PlatformID.Win32NT Then
                'If .Version.Major >= 5 Then
                '    If .Version.Minor >= 1 Then
                '        IsAboveOrEqualWinXp = True
                '    End If
                'End If
                
                If .Version.Major = 5 Then
                    If .Version.Minor >= 1 Then
                        IsAboveOrEqualWinXp = True
                    End If
                End If
                If .Version.Major > 5 Then
                    IsAboveOrEqualWinXp = True
                End If
                

            End If
        End With
    End Function
    Public Function IsAboveOrEqualWinVista() As Boolean
    
        IsAboveOrEqualWinVista = False

        Dim osInfo As OperatingSystem
        osInfo = System.Environment.OSVersion

        With osInfo

            If .Platform = PlatformID.Win32NT Then
                If .Version.Major >= 6 Then
                    IsAboveOrEqualWinVista = True

                End If
            End If
        End With


    End Function
    Private Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Private Const HWND_TOPMOST = -1
    Private Const SWP_NOMOVE = &H2
    Private Const SWP_NOSIZE = &H1
    Private Const HWND_NOTOPMOST = -2
    Public Sub AlwaysOnTop(ByVal pme As Form, ByVal Enabled As Boolean)

        If Enabled = True Then
            SetWindowPos(pme.Handle.ToInt32, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE + SWP_NOSIZE)
        Else
            SetWindowPos(pme.Handle.ToInt32, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE + SWP_NOSIZE)
        End If

    End Sub
    
    Public Function GetMDACVerNum() As Single 'changed to single 
        

        Dim strMDACVer As String = "" 

        Try 
            Dim ADODB As Object
            ADODB = Microsoft.VisualBasic.CreateObject("ADODB.Connection")
            If Not (ADODB Is Nothing) Then

                Try : strMDACVer = ADODB.Version : Catch : End Try 

                If strMDACVer = "" Then 
                    Try : strMDACVer = CStr(ADODB.Version).Replace(",", ".") : Catch : End Try 
                End If 

                Try : GetMDACVerNum = ADODB.Version.Replace(",", ".") : Catch : End Try 

                If GetMDACVerNum = 0 Then 
                    GetMDACVerNum = ADODB.Version
                End If 
            End If
        Catch 
            
            Try
                Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey( _
                    "SOFTWARE\Microsoft\DataAccess")

                Dim ver As String = CType(regKey.GetValue("FullInstallVer", "0.0.0.0"), String)
                regKey.Close()

                If strMDACVer = "" Then 
                    Try : strMDACVer = Microsoft.VisualBasic.Left(ver, 3) : Catch : End Try 
                    If strMDACVer = "" Then 
                        Try : strMDACVer = ver.Replace(",", ".") : Catch : End Try 
                    End If 
                End If 

                Try : GetMDACVerNum = CSng(Microsoft.VisualBasic.Left(ver.Replace(",", "."), 3)) : Catch : End Try 

                GetMDACVerNum = CSng(Microsoft.VisualBasic.Left(ver, 3))
            Catch
                '
            End Try
            
        End Try 

        '
        'If GetMDACVerNum = 25 Then GetMDACVerNum = 2.5
        'If GetMDACVerNum = 26 Then GetMDACVerNum = 2.6
        'If GetMDACVerNum = 27 Then GetMDACVerNum = 2.7
        '

        
        Select Case GetMDACVerNum
            Case 21 : GetMDACVerNum = 2.1
            Case 22 : GetMDACVerNum = 2.2
            Case 23 : GetMDACVerNum = 2.3
            Case 24 : GetMDACVerNum = 2.4
            Case 25 : GetMDACVerNum = 2.5
            Case 26 : GetMDACVerNum = 2.6
            Case 27 : GetMDACVerNum = 2.7
            Case 28 : GetMDACVerNum = 2.8
            Case 29 : GetMDACVerNum = 2.9
            Case 30 : GetMDACVerNum = 3.0
        End Select
        

        If GetMDACVerNum = 0 Then
            Select Case strMDACVer
                Case "21" : GetMDACVerNum = 2.1
                Case "22" : GetMDACVerNum = 2.2
                Case "23" : GetMDACVerNum = 2.3
                Case "24" : GetMDACVerNum = 2.4
                Case "25" : GetMDACVerNum = 2.5
                Case "26" : GetMDACVerNum = 2.6
                Case "27" : GetMDACVerNum = 2.7
                Case "28" : GetMDACVerNum = 2.8
                Case "29" : GetMDACVerNum = 2.9
                Case "30" : GetMDACVerNum = 3.0
            End Select
            If GetMDACVerNum = 0 Then
                Try
                    Select Case Microsoft.VisualBasic.Trim(strMDACVer)
                        Case "2.1" : GetMDACVerNum = 2.1
                        Case "2.2" : GetMDACVerNum = 2.2
                        Case "2.3" : GetMDACVerNum = 2.3
                        Case "2.4" : GetMDACVerNum = 2.4
                        Case "2.5" : GetMDACVerNum = 2.5
                        Case "2.6" : GetMDACVerNum = 2.6
                        Case "2.7" : GetMDACVerNum = 2.7
                        Case "2.8" : GetMDACVerNum = 2.8
                        Case "2.9" : GetMDACVerNum = 2.9
                        Case "3.0" : GetMDACVerNum = 3.0
                    End Select
                Catch
                End Try

            End If
        End If

    End Function
    Public Function Return83Format(ByVal pstrPath As String) As String
        'added 
        Dim strShortPath As String = Space(100)
        Dim n As Int32 = GetShortPathName(pstrPath, strShortPath, 100)
        Return83Format = Microsoft.VisualBasic.Strings.Left(strShortPath, n)

        If Return83Format = "" Then 
            Return83Format = pstrPath 
        End If

    End Function
    Public Function GetUserName() As String
        'added 
        Dim RetVal As String = ""

        Try
            RetVal = System.Environment.UserName
        Catch
            '
        End Try

        If RetVal = "" Then
            Try
                Dim oRoot As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine
                Dim oRKey As Microsoft.Win32.RegistryKey = oRoot.OpenSubKey("software\microsoft\Windows\CurrentVersion")
                RetVal = CStr(oRKey.GetValue("RegisteredOwner", ""))
            Catch
                '
            End Try
        End If

        If RetVal = "" Then
            Try
                Dim oRoot As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine
                Dim oRKey As Microsoft.Win32.RegistryKey = oRoot.OpenSubKey("software\microsoft\Windows NT\CurrentVersion")
                RetVal = CStr(oRKey.GetValue("RegisteredOwner", ""))
            Catch
                '
            End Try
        End If

        If RetVal = "" Then
            RetVal = "Unknown"
        End If

        Return RetVal

    End Function
    Public Function IsJet4Installed() As Integer
        'added 
        IsJet4Installed = 0

        Try
            Dim oRoot As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot
            Dim oRKey As Microsoft.Win32.RegistryKey = oRoot.OpenSubKey("Microsoft.Jet.OLEDB.4.0")

            If CStr(oRKey.GetValue("", "")) = "Microsoft.Jet.OLEDB.4.0" Then
                IsJet4Installed = 1
            Else
                IsJet4Installed = 0
            End If
        Catch
            IsJet4Installed = -1
        End Try

    End Function
    Public Function hasMultipleInstances(ByVal procName As String, ByVal pstrCaption As String, _
        ByVal plngAppHandle As System.IntPtr, ByVal LangText As System.Resources.ResourceManager) As Boolean 
        'Function hasMultipleInstances(ByVal procName As String, ByVal pstrCaption As String) As Boolean
        ''Try
        '''Vars for detecting multiple instances of an app
        ''Dim proc As Process
        ''Dim processes() As Process
        '''Dim procName As String = "IdeasPad" 'Substitute your appname here for your apps
        ''Dim procIndex As Integer
        ''Dim procCount As Integer
        '''Gets all the process by this name and adds them to the array of processess
        ''processes = Process.GetProcessesByName(procName)
        ''xx()
        '''Gets the number of instances of the process
        ''procCount = processes.Length
        '''to check for more than one instance of process
        ''If procCount > 1 Then
        ''    'MxessageBox.Show("You already have one instance of " & procName & " running on your computer.", pstrCaption)
        ''    MessageBox.Show(LangText.GetString("AppHealth_AlreadyInstance").Replace("[ProdName]", pstrCaption), pstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

        ''    For Each proc In processes
        ''        If procIndex > 0 Then
        ''            Return True
        ''        End If
        ''        procIndex = procIndex + 1
        ''    Next
        ''Else
        ''    Return False
        ''End If

        ''
        '''Added due to a bug possible with XP SP2, however someone on GotDotNet could get similar code to the above to work
        ''Dim appMutex As New System.Threading.Mutex(False, procName)
        ''If appMutex.WaitOne(0, False) Then
        ''    hasMultipleInstances = False
        ''Else
        ''    hasMultipleInstances = True
        ''    MessageBox.Show(LangText.GetString("AppHealth_AlreadyInstance").Replace("[ProdName]", pstrCaption), pstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ''End If
        ''

        'Catch ProcErr As Exception
        '    'MxessageBox.Show(ProcErr.Message)
        ''End Try

        ''Console.WriteLine("pstrCaption=" & pstrCaption)

Start:
        
        'procName isn't used now, but has been left in just in case a fix is found for the GetProcess problem which I was getting.
        Dim lstrWinTitle As New System.Text.StringBuilder(256)
        Dim counter As Integer

        plngAppHandle = GetTopWindow(IntPtr.Zero)

        Do Until plngAppHandle.Equals(IntPtr.Zero) ' Is IntPtr.Zero '0
            GetWindowText(plngAppHandle, lstrWinTitle, 255)
            ''Console.WriteLine(lstrWinTitle.ToString.Trim)
            'If lstrWinTitle.ToString.Trim = pstrCaption Then
            If InStrGet(lstrWinTitle.ToString.Trim.ToUpper, pstrCaption.ToUpper) > 0 Then
                counter += 1
            End If
            plngAppHandle = GetWindow(plngAppHandle, 2)
        Loop

        If counter >= 2 Then
            hasMultipleInstances = True
            MessageBox.Show(LangText.GetString("AppHealth_AlreadyInstance").Replace("[ProdName]", pstrCaption), pstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            hasMultipleInstances = False
        End If
        

    End Function
    Function BrowseToUrl(ByVal pstrURL As String, ByVal pme As Form) As Boolean
        BrowseToUrl = False

        If Not pme Is Nothing Then 
            Busy(pme, True)
        End If

        Try
            Dim htmlFile As String = System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".html"
            If System.IO.File.Exists(htmlFile) = False Then
                IO.File.CreateText(htmlFile)
            End If
            Dim fa As New FindApp()
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
End Module
Public Class DirBrowser
    'added 
    Inherits FolderNameEditor

    Private m_Description As String = "Choose a Directory..."
    Private m_ReturnPath As String = ""
    Private fb As FolderBrowser = New FolderBrowser()
    Private m_StartLocation As FolderBrowserFolder = FolderBrowserFolder.Desktop
    Private m_Style As FolderBrowserStyles = FolderNameEditor.FolderBrowserStyles.RestrictToFilesystem

    Public WriteOnly Property Description()
        Set(ByVal Value)
            m_Description = Value
        End Set
    End Property

    Public WriteOnly Property StartLocation()
        Set(ByVal Value)
            m_StartLocation = Value
        End Set
    End Property

    Public WriteOnly Property Style()
        Set(ByVal Value)
            m_Style = Value
        End Set
    End Property

    Public ReadOnly Property ReturnPath() As String
        Get
            Return m_ReturnPath
        End Get
    End Property

    Public Function ShowDialog() As DialogResult
        fb.Description = m_Description
        fb.StartLocation = m_StartLocation
        fb.Style = m_Style
        Dim r As DialogResult = fb.ShowDialog

        If r = DialogResult.OK Then
            m_ReturnPath = fb.DirectoryPath
        Else
            m_ReturnPath = ""
        End If

        Return r

    End Function

End Class
Public Class KillIt
    'clas to handle previous instance added 
    Public Shared Function PrevInstance() As Process
        Dim c As Process = Process.GetCurrentProcess()
        Dim p As Process
        For Each p In Process.GetProcessesByName(c.ProcessName)
            If p.Id <> c.Id Then
                If p.MainModule.FileName = c.MainModule.FileName Then
                    ' Return c to kill the NEW process, p to kill the OLD one
                    Return c
                End If
            End If
        Next p
        Return Nothing
    End Function
End Class
Public Class FindApp
    'added 

    Private Declare Auto Function FindExecutable Lib "shell32.dll" (ByVal lpFile As String, _
        ByVal lpDirectory As String, ByVal lpResult As StringBuilder) As Int32

    Private Const SE_ERR_FNF As Int32 = 2
    Private Const SE_ERR_NOASSOC As Int32 = 31
    Private Const SE_ERR_OOM As Int32 = 8
    Private Const MAX_PATH As Int32 = 260

    Public Function FindAssociatedApplication(ByVal FileName As String) As String

        Dim sb As New StringBuilder(MAX_PATH)
        Dim n As Int32 = FindExecutable(FileName, Microsoft.VisualBasic.vbNullString, sb)
        If n > 32 Then
            Return sb.ToString()
        Else
            Dim s As String = "Unknown error."
            Select Case n
                Case SE_ERR_FNF
                    s = "File not found."
                Case SE_ERR_NOASSOC
                    s = "No file association found."
                Case SE_ERR_OOM     ' Since Windows XP.
                    s = "Out of memory."
            End Select
            Throw New Exception(s)
        End If
    End Function
End Class
