Imports System.Runtime.InteropServices

Public Class Win32API

    Public Const MENU_CLASS As String = "#32768"
    Public Const WM_NCCALCSIZE As Integer = &H83
    Public Const WM_WINDOWPOSCHANGING As Integer = &H46
    Public Const WM_PAINT As Integer = &HF
    Public Const WM_CREATE As Integer = 1
    Public Const WM_NCCREATE As Integer = &H81
    Public Const WM_NCPAINT As Integer = 133
    Public Const WM_PRINT As Integer = 791
    Public Const WM_DESTROY As Integer = &H2
    Public Const WM_SHOWWINDOW As Integer = &H18
    Public Const WM_SHARED_MENU As Integer = 482
    Public Const HC_ACTION As Integer = 0
    Public Const WH_CALLWNDPROC As Integer = 4
    Public Const GWL_WNDPROC As Integer = -4

    Public Delegate Function WndProc(ByVal hwnd As IntPtr, ByVal msg As Integer, ByVal wparam As IntPtr, ByVal lparam As IntPtr) As Integer
    Public Delegate Function HookProc(ByVal code As Integer, ByVal wparam As IntPtr, ByRef cwp As CWPSTRUCT) As Integer

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure CWPSTRUCT
        Public lparam As IntPtr
        Public wparam As IntPtr
        Public message As Integer
        Public hwnd As IntPtr
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure WINDOWPOS
        Public hWnd As IntPtr
        Public hWndInsertAfter As IntPtr
        Public x As Integer
        Public y As Integer
        Public cx As Integer
        Public cy As Integer
        Public flags As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure NCCALCSIZE_PARAMS
        Public rgrc0, rgrc1, rgrc2 As RECT
        Public lppos As IntPtr
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function GetWindowRect(ByVal hWnd As IntPtr, ByRef rect As RECT) As Boolean
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function GetDlgItem(ByVal hDlg As IntPtr, ByVal nControlID As Integer) As IntPtr
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function SetWindowsHookEx(ByVal type As Integer, ByVal hook As HookProc, ByVal instance As IntPtr, ByVal threadID As Integer) As IntPtr
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function UnhookWindowsHookEx(ByVal hookHandle As IntPtr) As Boolean
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function GetWindowThreadProcessId(ByVal hwnd As IntPtr, ByVal ID As Integer) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function GetClassName(ByVal hwnd As IntPtr, ByVal className As System.Text.StringBuilder, ByVal maxCount As Integer) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function SetWindowLong(ByVal hwnd As IntPtr, ByVal index As Integer, ByVal wp As WndProc) As IntPtr
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function SetWindowLong(ByVal hwnd As IntPtr, ByVal index As Integer, ByVal dwNewLong As IntPtr) As IntPtr
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function CallNextHookEx(ByVal hookHandle As IntPtr, ByVal code As Integer, ByVal wparam As IntPtr, ByRef cwp As CWPSTRUCT) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function CallWindowProc(ByVal wndProc As IntPtr, ByVal hwnd As IntPtr, ByVal msg As Integer, ByVal wparam As IntPtr, ByVal lparam As IntPtr) As Integer
    End Function

End Class