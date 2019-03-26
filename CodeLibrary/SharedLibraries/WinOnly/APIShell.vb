Imports System.Runtime.InteropServices
Friend Module APIShell


    <Flags()> Private Enum FILL_ATTRIBUTES
        FOREGROUND_BLUE = &H1         ' text color contains blue.
        FOREGROUND_GREEN = &H2        ' text color contains green.
        FOREGROUND_RED = &H4          ' text color contains red.
        FOREGROUND_INTENSITY = &H8    ' text color is intensified.
        BACKGROUND_BLUE = &H10        ' background color contains blue.
        BACKGROUND_GREEN = &H20       ' background color contains green.
        BACKGROUND_RED = &H40         ' background color contains red.
        BACKGROUND_INTENSITY = &H80   ' background color is intensified.
    End Enum

    <Flags()> Private Enum START_UP_INFO_FLAGS
        STARTF_USESHOWWINDOW = &H1
        STARTF_USESIZE = &H2
        STARTF_USEPOSITION = &H4
        STARTF_USECOUNTCHARS = &H8
        STARTF_USEFILLATTRIBUTE = &H10
        STARTF_RUNFULLSCREEN = &H20
        STARTF_FORCEONFEEDBACK = &H40
        STARTF_FORCEOFFFEEDBACK = &H80
        STARTF_USESTDHANDLES = &H100
    End Enum

    <Flags()> Private Enum SHOW_WINDOW As Short
        SW_HIDE = 0
        SW_SHOWNORMAL = 1
        SW_NORMAL = 1
        SW_SHOWMINIMIZED = 2
        SW_SHOWMAXIMIZED = 3
        SW_MAXIMIZE = 3
        SW_SHOWNOACTIVATE = 4
        SW_SHOW = 5
        SW_MINIMIZE = 6
        SW_SHOWMINNOACTIVE = 7
        SW_SHOWNA = 8
        SW_RESTORE = 9
        SW_SHOWDEFAULT = 10
        SW_FORCEMINIMIZE = 11
        SW_MAX = 11
    End Enum

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)> Private Structure STARTUPINFO
        Dim cb As Integer
        Dim lpReserved As IntPtr
        Dim lpDesktop As String
        Dim lpTitle As String
        Dim dwX As Integer
        Dim dwY As Integer
        Dim dwXSize As Integer
        Dim dwYSize As Integer
        Dim dwXCountChars As Integer
        Dim dwYCountChars As Integer
        Dim dwFillAttribute As FILL_ATTRIBUTES
        Dim dwFlags As START_UP_INFO_FLAGS
        Dim wShowWindow As SHOW_WINDOW
        Dim cbReserved2 As Short
        Dim lpReserved2 As IntPtr
        Dim hStdInput As IntPtr
        Dim hStdOutput As IntPtr
        Dim hStdError As IntPtr
    End Structure

    <StructLayout(LayoutKind.Sequential)> Private Structure PROCESS_INFORMATION
        Dim hProcess As IntPtr
        Dim hThread As IntPtr
        Dim dwProcessId As Integer
        Dim dwThreadId As Integer
    End Structure

    Private Declare Auto Function CreateProcess Lib "kernel32" _
        (ByVal lpApplicationName As String, _
         ByVal lpCommandLine As String, _
         ByVal lpProcessAttributes As Integer, _
         ByVal lpThreadAttributes As Integer, _
         ByVal bInheritHandles As Boolean, _
         ByVal dwCreationFlags As Integer, _
         ByVal lpEnvironment As String, _
         ByVal lpCurrentDirectory As String, _
         ByRef lpStartupInfo As STARTUPINFO, _
         ByRef lpProcessInformation As PROCESS_INFORMATION) As Boolean



    <DllImport("kernel32.dll", EntryPoint:="CloseHandle", SetLastError:=True, CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    Private Function CloseHandle(ByVal handle As IntPtr) As Boolean
    End Function

    'Public Declare Function WaitForSingleObject Lib "KERNEL32" (ByVal hHandle As Long, ByVal dwMilliseconds As Long) As Long

    Private Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As IntPtr, ByVal dwMilliseconds As Integer) As Integer

    'Public Structure SECURITY_ATTRIBUTES
    '    Public Length As Int32
    '    Public lpSecurityDescriptor As IntPtr
    '    Public bInheritHandle As Boolean
    'End Structure

    '<DllImport("advapi32.dll", EntryPoint:="CreateProcessAsUser", SetLastError:=True, CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.StdCall)> _
    'Public Function CreateProcessAsUser(ByVal hToken As IntPtr, ByVal lpApplicationName As String, ByVal lpCommandLine As String, ByRef lpProcessAttributes As SECURITY_ATTRIBUTES, _
    ' ByRef lpThreadAttributes As SECURITY_ATTRIBUTES, ByVal bInheritHandle As Boolean, ByVal dwCreationFlags As Int32, ByVal lpEnvironment As IntPtr, _
    'ByVal lpCurrentDirectory As String, ByRef lpStartupInfo As STARTUPINFO, ByRef lpProcessInformation As PROCESS_INFORMATION) As Boolean
    'End Function
    Private Const NORMAL_PRIORITY_CLASS = &H20&

    Friend Declare Auto Function GetShortPathName Lib "kernel32.dll" ( _
    ByVal lpszLongPath As String, ByVal lpszShortPath As String, ByVal cchBuffer As Integer) As Integer

    '--- 
    Friend Declare Function GetActiveWindow Lib "user32" () As System.IntPtr

    Friend Declare Auto Function GetWindowText Lib "user32" _
     (ByVal hWnd As System.IntPtr, _
      ByVal lpString As System.Text.StringBuilder, _
      ByVal cch As Integer) As Integer

    Friend Declare Function GetTopWindow Lib "user32" (ByVal hwnd As System.IntPtr) As System.IntPtr

    Friend Declare Function GetWindow Lib "user32" (ByVal hwnd As System.IntPtr, ByVal wCmd As Integer) As System.IntPtr


    '--- 

    Friend Function RunNWait(ByVal pstrProg As String, ByVal pstrParam As String, ByVal pbooHide As Boolean)

        Dim StartInfo As STARTUPINFO
        Dim ProcessInfo As PROCESS_INFORMATION

        With StartInfo
            .cb = Marshal.SizeOf(StartInfo)
            .lpReserved = IntPtr.Zero
            .lpDesktop = Nothing
            .lpTitle = Nothing
            '.dwFlags = START_UP_INFO_FLAGS.STARTF_USESTDHANDLES
            '.hStdInput = GetStdHandle(HANDLE_TYPES.STD_INPUT_HANDLE)
            '.hStdOutput = GetStdHandle(HANDLE_TYPES.STD_OUTPUT_HANDLE)
            '.hStdError = GetStdHandle(HANDLE_TYPES.STD_ERROR_HANDLE)
            If pbooHide = True Then
                .wShowWindow = SHOW_WINDOW.SW_HIDE
            End If
        End With

        Dim ReturnValue As Integer

        'On Error GoTo ErrHandler
        ' Initialize the STARTUPINFO structure:


        ' Start the shelled application:
        'ReturnValue = CreateProcess("Calc.exe", "", 0&, 0&, 1&, NORMAL_PRIORITY_CLASS, 0&, 0&, StartInfo, ProcessInfo)

        'CreateProcess("c:\windows\system32\cmd.exe", "", 0, 0, True, 0, Nothing, Nothing, StartInfo, ProcessInfo)

        CreateProcess(pstrProg, " " & pstrParam, 0, 0, True, 0, Nothing, Nothing, StartInfo, ProcessInfo)

        'If CreateProcess("c:\windows\system32\cmd.exe", "", 0, 0, True, 0, Nothing, Nothing, StartInfo, ProcessInfo) Then
        '    CloseHandle(ProcessInfo.hProcess)
        '    CloseHandle(ProcessInfo.hThread)
        'Else
        '    Dim win As New System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error())
        '    MessageBox.Show(win.Message)
        'End If
        ' Wait for the shelled application to finish:
        Do
            ReturnValue = WaitForSingleObject(ProcessInfo.hProcess, 0)
            Application.DoEvents()

        Loop Until ReturnValue <> 258

        ReturnValue = CloseHandle(ProcessInfo.hProcess)

    End Function
 
End Module