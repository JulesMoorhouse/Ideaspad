Imports System.Runtime.InteropServices
Imports mshtml
Imports System.Diagnostics
Public Module appsecurity
    Private Declare Function CloseHandle Lib "kernel32" (ByVal hFile As Integer) As Integer
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer

    Private Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, _
        ByVal dwShareMode As Integer, ByVal lpSecurityAttributes As Integer, ByVal dwCreationDisposition As Integer, _
        ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Long) As Integer

    Private Const GENERIC_WRITE = &H40000000
    Private Const GENERIC_READ = &H80000000
    Private Const FILE_SHARE_READ = &H1
    Private Const FILE_SHARE_WRITE = &H2
    Private Const OPEN_EXISTING = 3
    Private Const CREATE_NEW = 1
    Private Const FILE_ATTRIBUTE_NORMAL = &H80

    
    Private Declare Function GetVolumeSerialNumber Lib "kernel32.dll" Alias _
        "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal _
        lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, _
        ByRef lpVolumeSerialNumber As Long, ByVal lpMaximumComponentLength As Integer, _
        ByVal lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal _
        nFileSystemNameSize As Integer) As Long

    Public Function GetHardDriveSerial() As String 

        Dim VolLabel As String
        Dim VolSize As Long
        Dim Serial As Long
        Dim MaxLen As Long
        Dim Flags As Long
        Dim Name As String
        Dim NameSize As Long
        Dim s As String

        'If GetVolumeSerialNumber(Microsoft.VisualBasic.Mid(Application.ExecutablePath, 1, Microsoft.VisualBasic.InStr(Application.ExecutablePath, "\")), _
        'VolLabel, VolSize, Serial, MaxLen, Flags, Name, NameSize) Then
        'will cater for people trying to run multiple copies of program from a network drive.
        If GetVolumeSerialNumber(Microsoft.VisualBasic.Mid(System.Environment.GetFolderPath(Environment.SpecialFolder.System), 1, Microsoft.VisualBasic.InStr(System.Environment.GetFolderPath(Environment.SpecialFolder.System), "\")), _
        VolLabel, VolSize, Serial, MaxLen, Flags, Name, NameSize) Then
            Return Serial.ToString()
        End If

    End Function
    Public Function flamenow() As Boolean
        Dim hfile As Long
        Dim retval As Long


        ''------------------ crc check -------------------------
        'Dim IRes As Integer
        'IRes = SetTopicTree()

        'Dim lstrDetails(2) As String
        'Dim lstrRetVal3 As String

        'lstrDetails(0) = "33BlmanKSHXtepRhVs"
        'lstrDetails(1) = "b?\jaiTqB;Tx_@fhh;VpdrcEgr<;s<QdrZ_atk[?rDGvOuHbOa?R\P]rjS]iAV?<W?Do?D"
        'lstrDetails(2) = "Kq@bj;jnkNhfMc?sFqxxL<XLAogPOJL;eCzfLWaf=_`ENz`Fg`JPrglqVV"

        'lstrRetVal3 = Decrypt(lstrDetails)

        'If IRes = 1 Then
        '    '
        'ElseIf IRes = -1 Then
        '    flamenow = True
        '    Exit Function
        'Else
        '    flamenow = True
        '    Exit Function
        'End If
        ''------------------ crc check -------------------------


        Dim sRegMonClass As String, sFileMonClass As String
        '\\We break up the class names to avoid
        '     detection in a hex editor
        sRegMonClass = "R" & "e" & "g" & "m" & "o" & "n" & "C" & "l" & "a" & "s" & "s"
        sFileMonClass = "F" & "i" & "l" & "e" & "M" & "o" & "n" & "C" & "l" & "a" & "s" & "s"
        '\\See if RegMon or FileMon are running


        Select Case True
            'Case FindWindow(sRegMonClass, vbNullString) <> 0
        Case FindWindow(sRegMonClass, "") <> 0
                'Regmon is running...throw an access vio
                '     lation
                flamenow = True
                Exit Function
            Case FindWindow(sFileMonClass, "") <> 0
                'FileMon is running...throw an access vi
                '     olation
                flamenow = True
                Exit Function
        End Select
        '\\So far so good...check for SoftICE in
        '     memory
        hfile = CreateFile("\\.\NTICE", GENERIC_WRITE Or GENERIC_READ, FILE_SHARE_READ Or FILE_SHARE_WRITE, 0, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, 0)

        If hfile <> -1 Then
            ' SoftICE is detected.
            retval = CloseHandle(hfile) ' Close the file handle
            flamenow = True
            Exit Function
        Else
            ' SoftICE is not found.
            flamenow = False
        End If

        hfile = CreateFile("\\.\SICE", GENERIC_WRITE Or GENERIC_READ, FILE_SHARE_READ Or FILE_SHARE_WRITE, 0, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, 0)
        If hfile <> -1 Then
            ' SoftICE is detected.
            retval = CloseHandle(hfile) ' Close the file handle
            flamenow = True
            Exit Function
        Else
            ' SoftICE is not found.
            flamenow = False
        End If
    End Function
End Module
Public Class GetColorDepth
    <DllImport("Gdi32", ExactSpelling:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function GetDeviceCaps(ByVal hDC As IntPtr, ByVal nIndex As Integer) As Integer
    End Function

    Private Declare Auto Function CreateDC Lib "Gdi32" Alias "CreateDC" (ByVal lpszDriver As String, _
    ByVal lpszDeviceName As String, ByVal lpszOutput As String, ByVal devMode As IntPtr) As IntPtr

    <DllImport("Gdi32", ExactSpelling:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function DeleteDC(ByVal hDC As IntPtr) As Boolean

    End Function

    Private Const BITSPIXEL As Integer = 12
    Private Const PLANES As Integer = 14

    Public ReadOnly Property ScreenColors() As Integer
        Get
            ' get the device info
            Dim screenDC As IntPtr = CreateDC("DISPLAY", Nothing, Nothing, IntPtr.Zero)
            Dim bitDepth As Integer = GetDeviceCaps(screenDC, BITSPIXEL)
            bitDepth *= GetDeviceCaps(screenDC, PLANES)
            ' delete the DC we created
            DeleteDC(screenDC)

            Return bitDepth
            '4 = 16 colours
            '8 = 256 colours
            '32 = 16 million colours
        End Get
    End Property

End Class
Public Module WindowsSpecific
    Private Enum MiscCommandTarget
        Find = 1
        ViewSource
        Options
    End Enum
    ' The GUID we need to invoke FInd, View Source and Options on
    ' WebBrowser. Note that the second param is in its two complement
    ' representation because the number otherwise outstrips the size
    ' of a VB short.
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure OLECMDTEXT
        Public cmdtextf As UInt32
        Public cwActual As UInt32
        Public cwBuf As UInt32
        Public rgwz As Char
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure OLECMD
        Public cmdID As Long
        Public cmdf As UInt64
    End Structure
    ' Interop definition for IOleCommandTarget. 
    <ComImport(), Guid("b722bccb-4e68-101b-a2bc-00aa00404770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> _
    Public Interface IOleCommandTarget
        ' IMPORTANT: The order of the methods is critical here. We're going to
        ' perform early binding in most cases, so the order of the methods
        ' here MUST match the order of their vtable layout (which is determined
        ' by their layout in IDL). The interop calls key off the vtable ordering,
        ' not the symbolic names, so if you switched these method declarations
        ' and attempted to call Exec() on an IOleCommandTarget interface from your
        ' app, it would translate into a call to QueryStatus() instead.
        Sub QueryStatus(ByRef pguidCmdGroup As Guid, ByVal cCmds As UInt32, <MarshalAs(UnmanagedType.LPArray, SizeParamIndex:=1)> ByVal prgCmds As OLECMD, ByRef pCmdText As OLECMDTEXT)
        Sub Exec(ByRef pguidCmdGroup As Guid, ByVal nCmdId As Long, ByVal nCmdExecOpt As Long, ByRef pvaIn As Object, ByRef pvaOut As Object)
    End Interface
    Public Sub ViewSource(ByVal BrowserControl As AxSHDocVw.AxWebBrowser)
        Dim cmdGUID As New Guid(&HED016940, -17061, &H11CF, &HBA, &H4E, &H0, &HC0, &H4F, &HD7, &H8, &H16)
        Dim doc As IHTMLDocument2 = CType(BrowserControl.Document, IHTMLDocument2)

        Dim cmdt As IOleCommandTarget
        Dim o As Object

        ' If the doc object isn't set to anything, or there's
        ' some bizarre error in accessing IOleCommandTarget,
        ' exit gracefully.
        Try
            cmdt = CType(doc, IOleCommandTarget)
            cmdt.Exec(cmdGUID, MiscCommandTarget.ViewSource, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, o, o)
        Catch
            ' Throw (New Exception(Err.GetException().Message))
        End Try
    End Sub
End Module
Public Class AppRun

    <STAThread()> Public Function Run(ByVal WorkDir As String, ByVal App As String, ByVal CommLine As String, _
        ByVal TimeOutSecs As Integer, ByVal DontWait As Boolean) As Boolean

        Run = True
        Dim lbooErrDebug As Boolean = False 'True 
        Dim lintErrStage As Integer 

        ''If IsWin98orME() = False Then 
        Dim psInfo As New ProcessStartInfo() '(App, CommLine)
        If IsWin98ME() = False Then 
            psInfo.FileName = App
            psInfo.WorkingDirectory = WorkDir 
        Else 
            psInfo.FileName = Return83Format(App) 
            psInfo.WorkingDirectory = Return83Format(WorkDir) 
        End If

        psInfo.Arguments = CommLine
        psInfo.WindowStyle = ProcessWindowStyle.Hidden
        psInfo.CreateNoWindow = True
        'If IsWin98orME() = False Then 
        psInfo.UseShellExecute = True
        'Else
        '    psInfo.UseShellExecute = False 
        'End If

        'If IsWin98orME() = False Then 
        ''        psInfo.WorkingDirectory = WorkDir
        'Else 
        '    psInfo.WorkingDirectory = Return83Format(WorkDir)  
        'End If

        'MessageBox.Show(psInfo.WorkingDirectory & "\" & App, "RunApp")

        'Dim lbooFoundFile As Boolean = IO.File.Exists(psInfo.WorkingDirectory & App)
        'MessageBox.Show("File : " & psInfo.WorkingDirectory & App & Environment.NewLine & "Has been found? : " & lbooFoundFile)


        Try 
            'Throw New System.ComponentModel.Win32Exception()

            If lbooErrDebug = True Then 
                MessageBox.Show("App=" & App & CR() & _
                "WorkDir=" & WorkDir & CR() & _
                "psInfo.FileName=" & psInfo.FileName & CR() & _
                "psInfo.WorkingDirectory=" & psInfo.WorkingDirectory & CR() & _
                "psInfo.Arguments=" & psInfo.Arguments)
            End If 

            Dim myProcess As Process = Process.Start(psInfo)


            lintErrStage = 1 
            If lbooErrDebug = True Then MessageBox.Show("AppRun " & lintErrStage) 

            If DontWait = False Then 
                myProcess.WaitForExit(TimeOutSecs * 1000)
                If Not myProcess.HasExited Then
                    myProcess.Kill()
                    Run = False

                    lintErrStage = 2 
                    If lbooErrDebug = True Then MessageBox.Show("AppRun " & lintErrStage) 
                    Exit Function
                End If
            End If 

            lintErrStage = 3 
            If lbooErrDebug = True Then MessageBox.Show("AppRun " & lintErrStage) 

        Catch ex As System.ComponentModel.Win32Exception
            'MessageBox.Show(WorkDir & App & Environment.NewLine & CommLine, "RunNWait")

            lintErrStage = 4 
            If lbooErrDebug = True Then MessageBox.Show("AppRun " & lintErrStage) 

            Try 
                RunNWait(WorkDir & App, CommLine, True)
            Catch

                lintErrStage = 5 
                If lbooErrDebug = True Then MessageBox.Show("AppRun " & lintErrStage) 
            End Try
        End Try

        ''Else 
        ''
        ''Try
        ''    RunNWait(WorkDir & App, CommLine, True)
        ''Catch
        ''    Run = False
        ''    lintErrStage = 6
        ''    If lbooErrDebug = True Then MessageBox.Show("AppRun " & lintErrStage)
        ''End Try
        ''
        ''End If 

        Application.DoEvents()

        lintErrStage = 7 
        If lbooErrDebug = True Then MessageBox.Show("AppRun " & lintErrStage) 

    End Function
End Class