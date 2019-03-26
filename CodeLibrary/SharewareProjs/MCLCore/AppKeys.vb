Imports System
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.Remoting
Imports System.Threading
Imports System.Globalization
'Namespace VBAppKeys

<Serializable()> Public Class AppKeys
    'Private Const KEYFILENAME As String = "AppUpdatersKeys.dll"
    Private Const KEYFILENAME As String = "MCLKeys.dll"
    Private AD As AppDomain
    Private KeyList()() As Byte
    Private ExceptionList() As String
    Private Validator As KeyValidator
    Private AppUrl As String
    Public Sub AppKeys(ByVal pappUrl As String)
        AppUrl = pappUrl
    End Sub
    Public Sub InitializeKeyCheck()

        UnInitializeKeyCheck()

        AD = AppDomain.CreateDomain("KeyValidatorDomain")

        Dim flags As BindingFlags = (BindingFlags.Public Or BindingFlags.Instance Or BindingFlags.CreateInstance)

        Dim objh As ObjectHandle = AD.CreateInstance("MCLCore", "MCLCore.KeyValidator", False, flags, _
            Nothing, Nothing, Nothing, Nothing, Nothing)

        Dim obj As Object = objh.Unwrap()
        Validator = CType(obj, KeyValidator)

        KeyList = GetKeyList(AppUrl.TrimEnd(New Char() {"/"} + "/") + KEYFILENAME)

    End Sub
    Public Sub UnInitializeKeyCheck()

        If Not IsNothing(AD) Then
            AppDomain.Unload(AD)
            Thread.Sleep(TimeSpan.FromSeconds(2))
            AD = Nothing
        End If

    End Sub
    Public Function ValidateAsembly(ByVal assemblyLocation As String) As Boolean

        'Try
        Return (Validator.Validate(assemblyLocation, KeyList, ExceptionList))
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        '    Debug.Assert(True)
        'End Try

    End Function
    Private Function GetKeyList(ByVal keyFileUrl As String) As Byte()()
        Dim RemoteKeys()() As Byte = Nothing

        Try
            Dim AN As New AssemblyName()
            AN.CodeBase = keyFileUrl
            Dim KeyAssembly As [Assembly]
            KeyAssembly = [Assembly].Load(AN)

            If KeyValidator.CompareKeys(KeyAssembly.GetName().GetPublicKey, New Byte()() {[Assembly].GetEntryAssembly().GetName().GetPublicKey()}) Then
                Dim t As Type = KeyAssembly.GetType("MCLKeys.KeyList")
                RemoteKeys = t.GetField("PubKeys").GetValue(Nothing)
                ExceptionList = t.GetField("ExceptionList").GetValue(Nothing)
            End If

        Catch ex As Exception
            Dim lstrMessage As String
            lstrMessage = "no remote keys found! " & vbCrLf & ex.Message & vbCrLf
            Debug.WriteLine(lstrMessage)
        End Try

        'This is the key list, first add keys from app you are running
        'then from the remote dll file.
        Dim PubKeys()() As Byte = Nothing
        If Not IsNothing(RemoteKeys) Then
            ReDim PubKeys(RemoteKeys.Length + 1)
            PubKeys(0) = [Assembly].GetEntryAssembly().GetName().GetPublicKey()
            RemoteKeys.CopyTo(PubKeys, 1)
        Else
            ReDim PubKeys(1)
            PubKeys(0) = [Assembly].GetEntryAssembly().GetName().GetPublicKey()
        End If

        Return PubKeys

    End Function
End Class
<Serializable()> Public Class KeyValidator 'Friend 
    Inherits MarshalByRefObject
    Private Function KeyValidator()
    End Function
    Friend Function Validate(ByVal AssemblyLocation As String, ByVal KeyList()() As Byte, ByVal ExceptionList() As String) As Boolean

        Try
            If IsException(AssemblyLocation, ExceptionList) Then
                Return True
            End If

            Dim A As [Assembly] = [Assembly].LoadFrom(AssemblyLocation)
            Return (CompareKeys(A.GetName().GetPublicKey(), KeyList))

        Catch e As Exception
            Debug.WriteLine("V=" & e.ToString)
            Return False
        End Try

    End Function
    Private Shared Function IsException(ByVal FilePath As String, ByVal ExceptionList() As String) As Boolean
        'Static
        If IsNothing(ExceptionList) Then
            Return False
        End If

        Dim exceptionFile As String

        'Try
        For Each exceptionFile In ExceptionList
            'Debug.WriteLine("IE=" & exceptionFile.ToLower(New CultureInfo("en-US")))
            If Path.GetFileName(FilePath).ToLower(New CultureInfo("en-US")) = exceptionFile.ToLower(New CultureInfo("en-US")) Then
                Return True
            End If

        Next exceptionFile
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

    End Function
    Friend Shared Function CompareKeys(ByVal AssemblyKey() As Byte, ByVal ValidKeys()() As Byte) As Boolean
        'Static
        Try
            Dim AE As ASCIIEncoding = New ASCIIEncoding()

            Dim PubKeys() As Byte
            'Dim PubKeys As Byte

            For Each PubKeys In ValidKeys
                'Debug.WriteLine("CK=" & AE.GetString(PubKeys) & "#" & AE.GetString(AssemblyKey) & "#")
                If AE.GetString(PubKeys) = AE.GetString(AssemblyKey) Then
                    Return True
                End If
            Next
        Catch e As Exception
            Debug.WriteLine("CK=" & e.ToString)
        End Try
    End Function
End Class

'End Namespace

