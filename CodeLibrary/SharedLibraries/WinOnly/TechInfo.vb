Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Management
'to be moved to WinOnly DLL
Public Class TechInfo
    'Imports System.Globalization

    Private Declare Sub GlobalMemoryStatus Lib "kernel32" (ByVal MemoryStatus) '(ByVal lpBuffer As MEMORYSTATUS)
    <StructLayout(LayoutKind.Sequential)> Structure MEMORYSTATUS
        Dim dwLength As Integer
        Dim dwMemoryLoad As Integer
        Dim dwTotalPhys As Integer
        Dim dwAvailPhys As Integer
        Dim dwTotalPageFile As Integer
        Dim dwAvailPageFile As Integer
        Dim dwTotalVirtual As Integer
        Dim dwAvailVirtual As Integer
    End Structure


    Private Declare Sub GetSystemInfo Lib "kernel32.dll" (ByRef lpSystemInfo As SYSTEM_INFO)
    Private Structure SYSTEM_INFO
        Dim dwOemID As Int32
        Dim dwPageSize As Int32
        Dim lpMinimumApplicationAddress As Int32
        Dim lpMaximumApplicationAddress As Int32
        Dim dwActiveProcessorMask As Int32
        Dim dwNumberOrfProcessors As Int32
        Dim dwProcessorType As Int32
        Dim dwAllocationGranularity As Int32
        Dim dwReserved As Int32
    End Structure

    Dim mOSBuild As String = ""
    Public ReadOnly Property OSBuild() As String
        'ALL OSs
        Get
            Return mOSBuild
        End Get
    End Property
    Public Enum OSs
        Windows95
        WindowsNT351
        WindowsNT40
        Windows98
        Windows98SE
        Windows2000
        WindowsME
        WindowsXP
        WindowsServer2003
        Unknown
    End Enum
    Public Enum ProcessorType
        PROCESSOR_INTEL_386
        PROCESSOR_INTEL_486
        PROCESSOR_INTEL_PENTIUM
        PROCESSOR_MIPS_R4000
        PROCESSOR_ALPHA_21064
        PROCESSOR_DURON 
        PROCESSOR_ATHLON 
        Unknown
    End Enum
    Dim mMDACVer As String = ""
    Public ReadOnly Property MDACVer() As String
        Get
            Return mMDACVer
        End Get
    End Property
    
    Dim mDotNetFXLang As String = ""
    Public ReadOnly Property DotNetFxLang() As String
        Get
            Return mDotNetFXLang
        End Get
    End Property
    Dim mstrInstalledDays As String = ""
    Public ReadOnly Property InstalledDays() As String
        Get
            Return mstrInstalledDays
        End Get
    End Property
    
    Dim mDotNetFXVer As String = ""
    Public ReadOnly Property DotNetFXVer() As String
        'ALL OSs
        Get
            Return mDotNetFXVer
        End Get
    End Property
    Dim mOSVersion As OSs
    Public ReadOnly Property OSVersion() As OSs
        'ALL OSs
        Get
            Return mOSVersion
        End Get
    End Property
    Dim mOSVersionName As String = ""
    Public ReadOnly Property OSVersionName() As String
        'ALL OSs
        Get
            Return mOSVersionName
        End Get
    End Property
    Dim mCPUType As ProcessorType = ProcessorType.Unknown
    Public ReadOnly Property CPUType() As ProcessorType
        'ALL OSs
        Get
            Return mCPUType
        End Get
    End Property
    Dim mCPUTypeName As String
    Public ReadOnly Property CPUTypeName() As String
        'ALL OSs
        Get
            Return mCPUTypeName
        End Get
    End Property
    Dim mIEVersion As String = ""
    Public ReadOnly Property IEVersion() As String
        'ALL OSs
        Get
            Return mIEVersion
        End Get
    End Property
    Dim mAvailMemKB As Single
    Public ReadOnly Property AvailMemKB() As Single
        'ALL OSs
        Get
            Return mAvailMemKB
        End Get
    End Property
    Dim mProcessorDesc As String = ""
    Public ReadOnly Property ProcessorDesc() As String
        Get
            Return mProcessorDesc
        End Get
    End Property
    Dim mProcessorSpeed As String = ""
    Public ReadOnly Property ProcessorSpeed() As String
        Get
            Return mProcessorSpeed
        End Get
    End Property
    Dim mL2CacheSize As String = ""
    Public ReadOnly Property L2CacheSize() As String
        Get
            Return mL2CacheSize
        End Get
    End Property
    Dim mL2CacheSpeed As String = ""
    Public ReadOnly Property L2CacheSpeed() As String
        Get
            Return mL2CacheSpeed
        End Get
    End Property
    Dim mProcessorManufacturer As String = ""
    Public ReadOnly Property ProcessorManufacturer() As String
        Get
            Return mProcessorManufacturer
        End Get
    End Property
    Dim mProcessorName As String = ""
    Public ReadOnly Property ProcessorName() As String
        Get
            Return mProcessorName
        End Get
    End Property
    Dim mProcessorSocket As String = ""
    Public ReadOnly Property ProcessorSocket() As String
        Get
            Return mProcessorSocket
        End Get
    End Property
    Dim mInstallDate As String = ""
    Public ReadOnly Property InstallDate() As String
        Get
            Return mInstallDate
        End Get
    End Property
    Dim mOSLanguage As String = ""
    Public ReadOnly Property OSLanguage() As String
        Get
            Return mOSLanguage
        End Get
    End Property
    Dim mServicePack As String = ""
    Public ReadOnly Property ServicePack() As String
        Get
            Return mServicePack
        End Get
    End Property
    Dim mSysDir As String = ""
    Public ReadOnly Property SysDir() As String
        Get
            Return mSysDir
        End Get
    End Property
    Dim mTotMemory As Single
    Public ReadOnly Property TotMemory() As Single
        Get
            Return mTotMemory
        End Get
    End Property
    Dim mWinDir As String = ""
    Public ReadOnly Property WinDir() As String
        Get
            Return mWinDir
        End Get
    End Property
    Dim mScreenRes As String = ""
    Public ReadOnly Property ScreenRes() As String
        'ALL OSs
        Get
            Return mScreenRes
        End Get
    End Property
    Dim mScreenColours As Integer
    Public ReadOnly Property ScreenColours() As Integer
        'ALL OSs
        Get
            Return mScreenColours
        End Get
    End Property
    Dim mRegionLocale As String = ""
    Public ReadOnly Property RegionLocale() As String
        'ALL OSs
        Get
            Return mRegionLocale
        End Get
    End Property
    Dim mDateFormat As String = ""
    Public ReadOnly Property DateFormat() As String
        'ALL OSs
        Get
            Return mDateFormat
        End Get
    End Property
    Dim mDefaultPrinterName As String = ""
    Public ReadOnly Property DefaultPrinterName() As String
        'ALL OSs
        Get
            Return mDefaultPrinterName
        End Get
    End Property
    Dim mAllProcesses As String = ""
    Public ReadOnly Property AllProcesses() As String
        'ALL OSs
        Get
            Return mAllProcesses
        End Get
    End Property
    Public Sub New()

        IExploreVer()
        Try : AvailableMemKB() : Catch : End Try

        Application.DoEvents()

        GetOSVersion()
        OSVerEnumToString()
        GetOSBuild()

        Select Case mOSVersion
            Case OSs.Windows98, mOSVersion = OSs.Windows98SE, OSs.Windows95, OSs.WindowsNT351, OSs.WindowsNT40
                Try : APIProcessorType() : Catch : End Try
                'W98 & NT4 etc may not WMI, therefore use API above
                Try : WMISysInfo() : Catch : End Try
            Case Else
                'W98 & NT4 etc may not WMI, therefore use API above
                Try : WMISysInfo() : Catch : End Try
                GetCPUTypeToEnum()
        End Select

        Application.DoEvents()

        GetCPUTypeToString()

        GetDotNetFXVer()
        GetScreenRes()
        GetRegionLocale()
        GetDateFormat()
        GetScreenCours()
        GetWindowsDir()
        GetSysDir()
        GetMDACVer()
        FormatLongDates()

        APITotalMem()
        GetDefaultPrinter()
        GetAllProcessesString()

        GetDotNetFXLang() 
        GetProgDaysInstalled() 

    End Sub
    Private Sub APIProcessorType()

        Const PROCESSOR_INTEL_386 = 386
        Const PROCESSOR_INTEL_486 = 486
        Const PROCESSOR_INTEL_PENTIUM = 586
        Const PROCESSOR_MIPS_R4000 = 4000
        Const PROCESSOR_ALPHA_21064 = 21064

        Dim mySys As SYSTEM_INFO

        GetSystemInfo(mySys)

        Select Case mySys.dwProcessorType
            Case PROCESSOR_INTEL_386
                mCPUType = ProcessorType.PROCESSOR_INTEL_386 ' "Intel 386"
            Case PROCESSOR_INTEL_486
                mCPUType = ProcessorType.PROCESSOR_INTEL_486 '"Intel 486"
            Case PROCESSOR_INTEL_PENTIUM
                mCPUType = ProcessorType.PROCESSOR_INTEL_PENTIUM '"Intel Pentium"
            Case PROCESSOR_MIPS_R4000
                mCPUType = ProcessorType.PROCESSOR_MIPS_R4000 '"RISC R4000"
            Case PROCESSOR_ALPHA_21064
                mCPUType = ProcessorType.PROCESSOR_ALPHA_21064 '"Alpha 21064"
            Case Else
                mCPUType = ProcessorType.Unknown
        End Select

    End Sub
    Private Sub IExploreVer()

        mIEVersion = "" 

        Dim IEStr As String = "C:\Program Files\Internet Explorer\IEXPLORE.EXE"
        If File.Exists(IEStr) = True Then
            Dim IEFileVer As System.Diagnostics.FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(IEStr)
            mIEVersion = IEFileVer.FileVersion
        End If
        
        If mIEVersion = "" Then
            Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey( _
                "SOFTWARE\Microsoft\Internet Explorer")
            mIEVersion = CType(regKey.GetValue("Version", "0.0.0.0"), String)
            regKey.Close()
        End If
        

    End Sub
    Private Sub AvailableMemKB()
        Dim pc As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter()

        pc.CategoryName = "Memory"
        pc.CounterName = "Available KBytes"
        mAvailMemKB = pc.NextValue()
        pc = Nothing

    End Sub
    Private Sub GetOSBuild()
        mOSBuild = Environment.OSVersion.Version.ToString()
    End Sub
    Private Sub GetOSVersion()

        mOSVersion = OSs.Unknown

        Dim osInfo As OperatingSystem
        osInfo = System.Environment.OSVersion
        'osInfo = OSVersion
        With osInfo
            Select Case .Platform

                Case .Platform.Win32Windows
                    Select Case (.Version.Minor)
                        Case 0
                            mOSVersion = OSs.Windows95 ' = "Windows 95" 'won't happen
                        Case 10
                            If .Version.Revision.ToString() = "2222A" Then
                                mOSVersion = OSs.Windows98SE ' = "Windows 98 Second Edition"
                            Else
                                mOSVersion = OSs.Windows98 '= "Windows 98"
                            End If
                        Case 90
                            mOSVersion = OSs.WindowsME '= "Windows Me"
                    End Select

                Case .Platform.Win32NT
                    OSVerToEnum(.Version.Major, .Version.Minor)
            End Select
        End With
    End Sub
    Private Function OSVerToEnum(ByVal intMajor As Integer, ByVal intMinor As Integer)

        Select Case intMajor
            Case 3
                mOSVersion = OSs.WindowsNT351 '= "Windows NT 3.51"
            Case 4
                mOSVersion = OSs.WindowsNT40 '= "Windows NT 4.0"
            Case 5
                Select Case intMinor
                    Case 0
                        mOSVersion = OSs.Windows2000 '= "Windows 2000"
                    Case 1
                        mOSVersion = OSs.WindowsXP ' = "Windows XP"
                    Case 2
                        mOSVersion = OSs.WindowsServer2003 '= "Windows Server 2003"
                End Select
            Case Else
                mOSVersion = OSs.Unknown '= "Failed"
        End Select
    End Function
    Private Sub WMISysInfo()

        Dim lstrOut1 As String = ""
        Dim lstrOut2 As String = ""
        '----------- Win32_Processor --------------
        'Dim Win32Pro As String() = {"Caption", "CreationClassName", "CurrentClockSpeed", "L2CacheSize", "L2CacheSpeed", "Manufacturer", "MaxClockSpeed", "Name", "SocketDesignation"}
        '----------- Win32_OperatingSystem --------------
        'Dim Win32OS As String() = {"BuildNumber", "Caption", "CountryCode", "CSDVersion", "CSName", "CurrentTimeZone", "FreePhysicalMemory", "FreeSpaceInPagingFiles", "FreeVirtualMemory", "InstallDate", "LastBootUpTime", "LocalDateTime", "OSLanguage", "ServicePackMajorVersion", "ServicePackMinorVersion", "SystemDirectory", "SystemDrive", "TotalVirtualMemorySize", "TotalVisibleMemorySize", "Version", "WindowsDirectory"}
        Dim lintArrInc As Integer

        Dim cimClass As String() = {"Win32_Processor", "Win32_OperatingSystem"}
        Dim cc As String
        For Each cc In cimClass
            'Console.WriteLine("----------- {0} --------------", cc)
            Dim cimobject As New ManagementClass(cc)


            Dim moc As ManagementObjectCollection = cimobject.GetInstances()
            Dim mo As ManagementObject
            For Each mo In moc
                Dim s As PropertyData
                Dim lstrThisProp As String = ""
                For Each s In mo.Properties
                    Try
                        'Console.WriteLine((s.Name + ":" + ChrGet(9) + ChrGet(9) + mo(s.Name).ToString()))
                        lstrThisProp = s.Name
                    Catch ex As Exception
                        'Console.WriteLine(("No object reference for: " + s.Name))
                        GoTo ContinueForEach3
                    End Try
ContinueForEach3:
                    Dim lbooProceed As Boolean = True
                    If cc = "Win32_Processor" Then
                        Select Case lstrThisProp
                            Case "Caption"
                                'lstrOut1 &= "<tr><td><b>" & s.Name & "</b></td><td>" & mo(s.Name).ToString() & "</td></tr>"
                                mProcessorDesc = mo(s.Name).ToString()
                                'Case "CreationClassName"
                                '    x = mo(s.Name).ToString()
                            Case "CurrentClockSpeed"
                                mProcessorSpeed = mo(s.Name).ToString()
                            Case "L2CacheSize"
                                mL2CacheSize = mo(s.Name).ToString()
                            Case "L2CacheSpeed"
                                mL2CacheSpeed = mo(s.Name).ToString()
                            Case "Manufacturer"
                                mProcessorManufacturer = mo(s.Name).ToString()
                                'Case "MaxClockSpeed"
                                '    x = mo(s.Name).ToString()
                            Case "Name"
                                mProcessorName = mo(s.Name).ToString()
                            Case "SocketDesignation"
                                mProcessorSocket = mo(s.Name).ToString()
                        End Select
                    ElseIf cc = "Win32_OperatingSystem" Then
                        Select Case lstrThisProp
                            Case "Caption"
                                Dim lstrCaption As String = mo(s.Name).ToString()
                                If InStrGet(lstrCaption, "Windows 95") > 0 Then
                                    mOSVersion = OSs.Windows95
                                ElseIf InStrGet(lstrCaption, "Windows 98 Second Edition") > 0 Then
                                    mOSVersion = OSs.Windows98SE
                                ElseIf InStrGet(lstrCaption, "Windows 98") > 0 Then
                                    mOSVersion = OSs.Windows98
                                ElseIf InStrGet(lstrCaption, "Windows Me") > 0 Then
                                    mOSVersion = OSs.WindowsME
                                ElseIf InStrGet(lstrCaption, "Windows NT 3.51") > 0 Then
                                    mOSVersion = OSs.WindowsNT351
                                ElseIf InStrGet(lstrCaption, "Windows NT 4.0") > 0 Then
                                    mOSVersion = OSs.WindowsNT40
                                ElseIf InStrGet(lstrCaption, "Windows 2000") > 0 Then
                                    mOSVersion = OSs.Windows2000
                                ElseIf InStrGet(lstrCaption, "Windows XP") > 0 Then
                                    mOSVersion = OSs.WindowsXP
                                ElseIf InStrGet(lstrCaption, "Windows Server 2003") > 0 Then
                                    mOSVersion = OSs.WindowsServer2003
                                Else
                                    mOSVersion = OSs.Unknown
                                End If
                            Case "InstallDate"
                                mInstallDate = mo(s.Name).ToString()
                                
                                Try
                                    Dim id As Date = CDate(mInstallDate)
                                    mInstallDate = id.ToString(System.Globalization.CultureInfo.InvariantCulture)
                                Catch

                                End Try
                                
                            Case "OSLanguage"
                                mOSLanguage = mo(s.Name).ToString()
                            Case "ServicePackMajorVersion"
                                mServicePack = mo(s.Name).ToString()
                            Case "ServicePackMinorVersion"
                                mServicePack &= "." & mo(s.Name).ToString()
                            Case "TotalVisibleMemorySize"
                                mTotMemory = mo(s.Name).ToString()
                            Case "Version"
                                If mOSVersion = OSs.Unknown Then
                                    Dim lstrVersion As String = mo(s.Name).ToString()
                                    Dim lintMajor As Integer = ReturnNthStr(lstrVersion, 1, ".")
                                    Dim lintMinor As Integer = ReturnNthStr(lstrVersion, 2, ".")

                                    OSVerToEnum(lintMajor, lintMinor)
                                End If
                        End Select
                    End If
                Next s
            Next mo
        Next cc

    End Sub
    'Private Sub NT4Environment()
    '    Dim lintArrInc As Integer

    '    Dim environmentVariables As IDictionary = Environment.GetEnvironmentVariables()
    '    Dim de As DictionaryEntry
    '    For Each de In environmentVariables
    '        Select Case de.Key.ToString.ToUpper
    '            Case "PROCESSOR_ARCHITECTURE"
    '                x = de.Value.ToString
    '            Case "PROCESSOR_IDENTIFIER"
    '                x = de.Value.ToString
    '            Case "OS"
    '                x = de.Value.ToString
    '            Case "SYSTEMROOT"
    '                x = de.Value.ToString
    '            Case "WINDIR"
    '                x = de.Value.ToString
    '            Case "TEMP"
    '                x = de.Value.ToString
    '        End Select
    '    Next de

    'End Sub
    Private Sub GetDotNetFXVer()
        With Environment.Version
            mDotNetFXVer = .Major & "." & .Build & "." & .Minor & "." & .Revision
        End With
    End Sub
    Private Sub GetDotNetFXLang()
        
        mDotNetFXLang = System.Threading.Thread.CurrentThread.CurrentCulture.EnglishName

    End Sub
    Private Sub GetProgDaysInstalled()
        
        Dim ThisDir As String = Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location)

        Dim di As New DirectoryInfo(ThisDir)
        mstrInstalledDays = threedigs(DateDiffGet(DateInterval.Day, di.CreationTime, Date.Now))

    End Sub
    Private Sub GetScreenRes()
        mScreenRes = Screen.PrimaryScreen.Bounds.Width & "x" & Screen.PrimaryScreen.Bounds.Height
    End Sub
    Private Sub GetRegionLocale()
        'mRegionLocale = System.Threading.Thread.CurrentThread.CurrentCulture.DisplayName.ToString
        'mRegionLocale = System.Globalization.CultureInfo.CurrentCulture.DisplayName.ToString
        mRegionLocale = GetSetting("Language", "en", InitalXMLConfig.XmlConfigType.AppSettings, "")
    End Sub
    Private Sub GetDateFormat()
        mDateFormat = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FullDateTimePattern.ToString
    End Sub
    Private Sub GetScreenCours()
        Dim x As New GetColorDepth()
        mScreenColours = x.ScreenColors()
    End Sub
    Private Sub GetWindowsDir()
        'mWinDir = System.Environment.GetFolderPath(CType(&H24, System.Environment.SpecialFolder))

        Dim sSystemPath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.System)

        mWinDir = sSystemPath.Substring(0, sSystemPath.LastIndexOf("\")).ToLower

    End Sub
    Private Sub GetSysDir()
        mSysDir = Environment.GetFolderPath(Environment.SpecialFolder.System).ToLower
    End Sub
    Private Sub OSVerEnumToString()

        Select Case mOSVersion
            Case OSs.Windows95
                mOSVersionName = "Windows 95"
            Case OSs.Windows98
                mOSVersionName = "Windows 98"
            Case OSs.Windows98SE
                mOSVersionName = "Windows 98 Second Edition"
            Case OSs.WindowsME
                mOSVersionName = "Windows Me"
            Case OSs.WindowsNT351
                mOSVersionName = "Windows NT 3.51"
            Case OSs.WindowsNT40
                mOSVersionName = "Windows NT 4.0"
            Case OSs.Windows2000
                mOSVersionName = "Windows 2000"
            Case OSs.WindowsXP
                mOSVersionName = "Windows XP"
            Case OSs.WindowsServer2003
                mOSVersionName = "Windows Server 2003"
            Case Else
                mOSVersionName = "Unknown"
        End Select
    End Sub
    Private Sub GetCPUTypeToString()

        Select Case mCPUType
            Case ProcessorType.PROCESSOR_INTEL_386
                mCPUTypeName = "Intel 386"
            Case ProcessorType.PROCESSOR_INTEL_486
                mCPUTypeName = "Intel 486"
            Case ProcessorType.PROCESSOR_INTEL_PENTIUM
                mCPUTypeName = "Intel Pentium"
            Case ProcessorType.PROCESSOR_MIPS_R4000
                mCPUTypeName = "RISC R4000"
            Case ProcessorType.PROCESSOR_ALPHA_21064
                mCPUTypeName = "Alpha 21064"
            Case ProcessorType.PROCESSOR_DURON 
                mCPUTypeName = "Duron" 
            Case ProcessorType.PROCESSOR_ATHLON 
                mCPUTypeName = "Athlon" 
            Case ProcessorType.Unknown
                mCPUTypeName = "Unknown"
        End Select
    End Sub
    Private Sub GetCPUTypeToEnum()
        If InStrGet(mProcessorName.ToUpper, "386") > 0 Then
            mCPUType = ProcessorType.PROCESSOR_INTEL_386
        ElseIf InStrGet(mProcessorName.ToUpper, "486") > 0 Then
            mCPUType = ProcessorType.PROCESSOR_INTEL_486
        ElseIf InStrGet(mProcessorName.ToUpper, "PENTIUM") > 0 Then
            mCPUType = ProcessorType.PROCESSOR_INTEL_PENTIUM
        ElseIf InStrGet(mProcessorName.ToUpper, "RISC") > 0 Then
            mCPUType = ProcessorType.PROCESSOR_MIPS_R4000
        ElseIf InStrGet(mProcessorName.ToUpper, "ALPHA") > 0 Then
            mCPUType = ProcessorType.PROCESSOR_ALPHA_21064
        ElseIf InStrGet(mProcessorName.ToUpper, "DURON") > 0 Then 
            mCPUType = ProcessorType.PROCESSOR_DURON 
        ElseIf InStrGet(mProcessorName.ToUpper, "ATHLON") > 0 Then 
            mCPUType = ProcessorType.PROCESSOR_ATHLON 
        Else
            mCPUType = ProcessorType.Unknown
        End If

    End Sub
    Private Sub GetMDACVer()

        mMDACVer = "Not Available"
        Try
            'Dim lcnn1 As New ADODB.Connection()
            'Ver = lcnn1.Version
            'To cater for MCL Apps which don't include ADO etc
            'Dim ADODB As Object
            'ADODB = Microsoft.VisualBasic.CreateObject("ADODB.Connection")
            'If Not (ADODB Is Nothing) Then
            '    mMDACVer = ADODB.Version
            'End If
            mMDACVer = GetMDACVerNum() 

        Catch
            '
        End Try

    End Sub
    Private Sub FormatLongDates()

        Try 
            Dim lstrTemp As String = mInstallDate
            '20031203070100.500000+000
            mInstallDate = MidGet(lstrTemp, 7, 2) & "/"
            mInstallDate &= MonthName(MidGet(lstrTemp, 5, 2), True) & "/"
            mInstallDate &= MidGet(lstrTemp, 1, 4) & " "
            mInstallDate &= MidGet(lstrTemp, 9, 2) & ":"
            mInstallDate &= MidGet(lstrTemp, 11, 2) '& "."
            'mInstallDate &= MidGet(lstrTemp, 13, 2)
        Catch 
        End Try 

    End Sub
    Private Sub APITotalMem()

        Try
            Dim uMS As MEMORYSTATUS
            uMS.dwLength = Marshal.SizeOf(uMS)
            GlobalMemoryStatus(uMS)

            If mTotMemory = 0 Then
                mTotMemory = (uMS.dwTotalPhys / 1024).ToString
            End If
            If mAvailMemKB = 0 Then
                mTotMemory = (uMS.dwAvailPhys / 1024).ToString
            End If
        Catch
            '
        End Try

    End Sub
    Private Sub GetDefaultPrinter()

        Try
            Dim objprinter As System.Drawing.Printing.PageSettings = New System.Drawing.Printing.PageSettings()
            mDefaultPrinterName = objprinter.PrinterSettings.PrinterName
        Catch
            '
        End Try

    End Sub
    Private Sub GetAllProcessesString()

        Try
            Dim proc As System.Diagnostics.Process
            Dim processes() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcesses()

            For Each proc In processes
                mAllProcesses &= proc.ProcessName & ", "
            Next
        Catch ProcErr As Exception
            '
        End Try
    End Sub
End Class
