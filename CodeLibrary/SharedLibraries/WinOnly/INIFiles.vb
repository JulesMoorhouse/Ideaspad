Imports System.Text


Public Module INIFiles
    'added 
    Private Const MAX_ENTRY As Integer = 32768
    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32.dll" Alias "GetPrivateProfileStringA" _
        (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, _
        ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
    (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Integer

    Public Function GetPrivateINI(ByVal PrivateINI As String, ByVal section As String, ByVal key As String, ByVal defVal As String) As String
        Dim sb As New StringBuilder(MAX_ENTRY)
        Dim Ret As Integer = GetPrivateProfileString(section, key, defVal, sb, MAX_ENTRY, PrivateINI)
        Return sb.ToString()
    End Function

    Public Function SetPrivateINI(ByVal PrivateINI As String, ByVal section As String, ByVal key As String, ByVal value As String) As Boolean

        WritePrivateProfileString(section, key, value, PrivateINI)

    End Function

End Module
