
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Imports System.Xml
Imports System.Collections.Specialized
Imports System.IO

Friend Module Overlap


    Enum DateInterval
        Day = 4
        Hour = 7
        Month = 2
        Second = 9
        Minute = 8
    End Enum

    Friend Function Reverse(ByVal pstrString As String) As String
        Dim lintArrInc As Integer

        For lintArrInc = 0 To pstrString.Length - 1
            Reverse = Reverse & Microsoft.VisualBasic.Right(pstrString, 1)
            pstrString = Microsoft.VisualBasic.Left(pstrString, pstrString.Length - 1)
        Next lintArrInc

    End Function
    Friend Function Occurences(ByVal strSearchString As String, ByVal strSearchFor As String) As Integer
        Dim r As New Regex(strSearchFor)
        Dim m As MatchCollection = r.Matches(strSearchString)

        Occurences = m.Count.ToString
    End Function
    Friend Sub Sleep(ByVal Seconds As Long)
        Dim Start As DateTime = Date.Now

        While Not DateDiffGet(DateInterval.Second, Start, Date.Now) >= Seconds
            ' do nothing 
        End While

    End Sub
    Friend Function DateDiffGet(ByVal Interval As DateInterval, ByVal Date1 As Date, ByVal Date2 As Date) As Long

        Select Case Interval
            Case DateInterval.Day
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Day, Date1, Date2)
            Case DateInterval.Hour
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Hour, Date1, Date2)
            Case DateInterval.Minute
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Minute, Date1, Date2)
            Case DateInterval.Second
                DateDiffGet = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Second, Date1, Date2)
            Case Else
                MessageBox.Show("DateDiffGet 1 Invalid Date Param")
        End Select
        Exit Function

        Dim ts As TimeSpan

        ts = Date2.Subtract(Date1)
        Select Case Interval
            Case DateInterval.Day
                DateDiffGet = ts.Days
            Case DateInterval.Hour
                DateDiffGet = ts.Hours
            Case DateInterval.Minute 
                DateDiffGet = ts.Minutes
            Case DateInterval.Second
                DateDiffGet = ts.Seconds
            Case Else
                MessageBox.Show("DateDiffGet 1 Invalid Date Param")
        End Select

    End Function
    Friend Function ReturnNthStr(ByVal pstrString As String, ByVal pintPosition As Integer, ByVal pstrChar As String) As String
        Dim lintArrInc As Integer
        Dim llngPos As Long
        Dim llngLastPos As Long
        Dim lintErrPos As Integer

        lintErrPos = 0
        'On Error GoTo EndFunc
        Try
            lintErrPos = 1
            Do Until lintArrInc = pintPosition
                lintErrPos = 2
                lintArrInc = lintArrInc + 1
                lintErrPos = 3
                'llngPos = InxStr(llngLastPos + 1, pstrString, pstrChar)
                llngPos = InStr(llngLastPos + 1, pstrString, pstrChar, CompareMethod.Text)
                lintErrPos = 4
                ReturnNthStr = Mid(pstrString, llngLastPos + 1, (llngPos - llngLastPos) - 1)
                lintErrPos = 5
                llngLastPos = llngPos
                lintErrPos = 6
            Loop
            lintErrPos = 7
        Catch ex As Exception

            ReturnNthStr = ""
        End Try

        'EndFunc:
        'Select Case Err.Number
        '    Case 5
        '        If lintErrPos = 4 Then
        'ReturnNthStr = ""
        'Exit Function
        '        End If
        '        'Case Else
        '        '    MsgxBox Err.Number & " " & Err.Description
        'End Select
        'Exit Function
    End Function
    Friend Sub Busy(ByVal pojForm As Form, ByVal pbooFlags As Boolean)

        If pbooFlags = True Then
            pojForm.Cursor = Cursors.WaitCursor
            'pojForm.Enabled = False
        Else
            pojForm.Cursor = Cursors.Default
            'pojForm.Enabled = True
        End If

    End Sub
    Friend Function AscGet(ByVal pstrChar As Char) As Integer
        Dim b As Byte() = System.Text.Encoding.Default.GetBytes(New [Char]() {pstrChar})
        AscGet = b(0).ToString()

        If AscGet <> Microsoft.VisualBasic.Asc(pstrChar) Then
            MessageBox.Show("AscGet - Inaccurate! AscGet='" & AscGet & "' and VB.Asc='" & Microsoft.VisualBasic.Asc(pstrChar) & "'")
        End If
    End Function
    Friend Function ChrGet(ByVal CharCode As Integer) As Char
        Dim chDEC(0) As Char
        Dim bControlChars As Byte() = {CharCode}   '**char number in ASCII table for CARRIAGE RETURN
        Dim dec As System.Text.Decoder = System.Text.Encoding.Default.GetDecoder()
        dec.GetChars(bControlChars, 0, bControlChars.Length, chDEC, 0)
        ChrGet = chDEC(0)
    End Function
    Friend Function LeftGet(ByVal pstrString As String, ByVal plngPos As Long) As String

        LeftGet = pstrString.Substring(0, plngPos)

        If LeftGet <> Microsoft.VisualBasic.Left(pstrString, plngPos) Then
            MessageBox.Show("LeftGet - Inaccurate!")
        End If
    End Function
    Friend Function MidGet(ByVal Target As String, ByVal Start As Integer, Optional ByVal Length As Integer = 0) As String

        If Length = 0 Then Length = Target.Length - (Start - 1)

        If Start - 1 + Length > Target.Length Then
            Length = Target.Length - (Start - 1)
        End If

        MidGet = Target.Substring(Start - 1, Length)

        If MidGet <> Microsoft.VisualBasic.Mid(Target, Start, Length) Then
            MessageBox.Show("MidGet - Inaccurate!")
        End If
    End Function
    Friend Function RightGet(ByVal pstrString As String, ByVal plngPos As Long) As String

        'RightGet = pstrString.Substring(plngPos)
        'MxessageBox.Show(MyString.Substring(MyString.Length - n, n), Microsoft.VisuxalBasic.Right(MyString, 5))
        RightGet = pstrString.Substring(pstrString.Length - plngPos, plngPos)

        If RightGet <> Microsoft.VisualBasic.Right(pstrString, plngPos) Then
            MessageBox.Show("RIGHTGET - Inaccurate!")
        End If
    End Function
    Friend Function InStrGet(ByVal String1 As String, ByVal String2 As String) As Long

        InStrGet = String1.IndexOf(String2) + 1

        If InStrGet <> Microsoft.VisualBasic.InStr(String1, String2) Then
            MessageBox.Show("InStrGet1 - Inaccurate!")
        End If
    End Function
    Friend Function threedigs(ByVal str As String) As String
        'added 
        If str.Length = 1 Then
            Return "00" & str
        ElseIf str.Length = 2 Then
            Return "0" & str
        Else
            Return str
        End If

    End Function
    Friend Sub SaveSetting(ByVal pstrKey As String, ByVal pstrValue As String, ByVal pConfigType As InitalXMLConfig.XmlConfigType, _
            ByVal pstrParamString As String, Optional ByVal outputFile As String = "")
        Dim xDoc As New XmlDocument()
        Dim at As XmlAttribute

        Dim ConfigFile As String

        
        Try
            If pConfigType = InitalXMLConfig.XmlConfigType.UserTemplates Then
                pstrValue = pstrValue.ToUpper
            End If
        Catch
            '
        End Try
        
        If outputFile = "" Then 
            'ConfigFile = System.Reflection.Assembly.GetExecutingAssembly.Location.ToString() & ".dat"
            
            ConfigFile = System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat"
        Else
            ConfigFile = outputFile
        End If

        Dim lstrChildNode As String = GetSectionString(pConfigType, pstrParamString)  

        xDoc.Load(ConfigFile) 'OpenFile
        Try 'update
            at = xDoc.SelectSingleNode("configuration/" & lstrChildNode & "/add[@key='" & pstrKey & "']").Attributes("value")
            at.Value = pstrValue
        Catch ex As System.NullReferenceException
            'add new
            Dim n1 As XmlNode = xDoc.SelectSingleNode("./configuration/" & lstrChildNode & "")

            
            If n1 Is Nothing Then
                Dim newElem As XmlNode = xDoc.CreateNode(XmlNodeType.Element, lstrChildNode, "")
                newElem.InnerText = ""
                'add the new node to the document 
                Console.WriteLine("Add the new element to the existing document...")
                Dim root As XmlElement = xDoc.DocumentElement
                root.AppendChild(newElem)
                n1 = xDoc.SelectSingleNode("./configuration/" & lstrChildNode & "")

            End If
            

            If Not (n1 Is Nothing) AndAlso Not (n1.ChildNodes Is Nothing) Then
                Dim n2 As XmlNode = xDoc.CreateNode(XmlNodeType.Element, "add", String.Empty)
                Dim xmlAttr As XmlAttribute

                xmlAttr = xDoc.CreateAttribute("key")
                xmlAttr.Value = pstrKey
                n2.Attributes.Append(xmlAttr)

                xmlAttr = xDoc.CreateAttribute("value")
                xmlAttr.Value = pstrValue
                n2.Attributes.Append(xmlAttr)

                n1.AppendChild(n2)
            End If

        End Try

        xDoc.Save(ConfigFile)
        xDoc = Nothing
        'OpenFile.Close()
        'OpenFile = Nothing


    End Sub
    Friend Function GetSectionString(ByVal pConfigType As InitalXMLConfig.XmlConfigType, ByVal pstrParamString As String) As String

        Select Case pConfigType
            Case InitalXMLConfig.XmlConfigType.AppSettings
                GetSectionString = "appSettings"
            Case InitalXMLConfig.XmlConfigType.Bookmarks
                GetSectionString = "Bookmarks-" & pstrParamString
            Case InitalXMLConfig.XmlConfigType.TemplatesMenu
                GetSectionString = "TemplatesMenu-" & pstrParamString
            Case InitalXMLConfig.XmlConfigType.UserTemplates
                GetSectionString = "UserTemplates-" & pstrParamString
            Case InitalXMLConfig.XmlConfigType.Topics
                GetSectionString = "Topics"
            Case InitalXMLConfig.XmlConfigType.TopicDetails
                GetSectionString = "TopicDetails"
            Case InitalXMLConfig.XmlConfigType.AllUserTemplates
                GetSectionString = "AllUserTemplates"
            Case InitalXMLConfig.XmlConfigType.Membership 
                GetSectionString = "Membership" 
            Case InitalXMLConfig.XmlConfigType.DebugReports 
                GetSectionString = "DebugReports" 
        End Select

    End Function
    '--- tech info
    Private Enum OSs
        Windows95 '0
        WindowsNT351 '1
        WindowsNT40 '2
        Windows98 '3
        Windows98SE '4
        Windows2000 '5
        WindowsME '6
        WindowsXP '7
        WindowsServer2003 '8
        Unknown '9
    End Enum
    Friend Function GetOSVersion() As Integer

        Dim mOSVersion As Integer
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
                    mOSVersion = OSVerToEnum(.Version.Major, .Version.Minor)
            End Select
        End With

        Return mOSVersion

    End Function
    Private Function OSVerToEnum(ByVal intMajor As Integer, ByVal intMinor As Integer) As Integer

        Dim mOSVersion As Integer
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

        Return mOSVersion
    End Function

    Friend Function GetDotNetFXVer() As Integer

        With Environment.Version
            'Return .Major & "-" & .Build   '& "." & .Minor & "." & .Revision
            Return .Major & .Minor     '& "." & .Minor & "." & .Revision
        End With

    End Function
    Friend Function twodigs(ByVal str As String) As String

        If str.Length = 1 Then
            Return "0" & str
        Else
            Return str
        End If

    End Function
    'Friend Function GetMDACVerNum() As Single 'changed to single 
    '    

    '    Try 
    '        Dim ADODB As Object
    '        ADODB = Microsoft.VisualBasic.CreateObject("ADODB.Connection")
    '        If Not (ADODB Is Nothing) Then
    '            GetMDACVerNum = ADODB.Version
    '        End If
    '    Catch 
    '        
    '        Try
    '            Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey( _
    '                "SOFTWARE\Microsoft\DataAccess")
    '            Dim ver As String = CType(regKey.GetValue("FullInstallVer", "0.0.0.0"), String)
    '            regKey.Close()
    '            GetMDACVerNum = CSng(LeftGet(ver, 3))
    '        Catch
    '            '
    '        End Try
    '        
    '    End Try 

    'End Function
    'Friend Function IsJet4Installed() As Integer
    '    'added 
    '    IsJet4Installed = 0

    '    Try
    '        Dim oRoot As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot
    '        Dim oRKey As Microsoft.Win32.RegistryKey = oRoot.OpenSubKey("Microsoft.Jet.OLEDB.4.0")

    '        If CStr(oRKey.GetValue("", "")) = "Microsoft.Jet.OLEDB.4.0" Then
    '            IsJet4Installed = 1
    '        Else
    '            IsJet4Installed = 0
    '        End If
    '    Catch
    '        IsJet4Installed = -1
    '    End Try

    'End Function

    Friend Function GetInstalledFxVers()
        'added 
        Dim fx10 As String = "0"
        Dim fx11 As String = "0"
        Dim fx20 As String = "0"

        Try
            
            Dim WinFxDir As String = System.Environment.GetFolderPath( _
                Environment.SpecialFolder.System).Replace("\System32", "").Replace("\System", "") & _
                "\Microsoft.NET\Framework"
            If Directory.Exists(WinFxDir) = False Then
                WinFxDir = "C:\Windows\Microsoft.NET\Framework"
                If Directory.Exists(WinFxDir) = False Then
                    WinFxDir = "C:\Winnt\Microsoft.NET\Framework"
                    If Directory.Exists(WinFxDir) = False Then
                        WinFxDir = System.Environment.GetEnvironmentVariable("windir") & "Microsoft.NET\Framework"
                        If Directory.Exists(WinFxDir) = False Then
                            Return "999"
                        End If
                    End If
                End If
            End If
            

            'Dim source As DirectoryInfo = New DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("\System32", "").Replace("\System", "") & "\Microsoft.NET\Framework")
            Dim source As DirectoryInfo = New DirectoryInfo(WinFxDir)

            Dim files() As DirectoryInfo = source.GetDirectories("v*")
            Dim pfile As DirectoryInfo
            For Each pfile In files
                Select Case pfile.ToString
                    Case "v1.0.3705" : fx10 = "1"
                    Case "v1.1.4322" : fx11 = "1"
                    Case "v2.0.40607" : fx20 = "1"
                End Select
            Next pfile
            'Return fx10 & fx11 & fx20
        Catch
            
            'Return "ERR"
            If fx10 = 0 Then fx10 = 9
            If fx11 = 0 Then fx11 = 9
            If fx20 = 0 Then fx20 = 9
            
        End Try

        Return fx10 & fx11 & fx20 

    End Function

End Module
Friend Class InitalXMLConfig
    Private config As NameValueCollection
    Public Enum XmlConfigType
        AppSettings
        Bookmarks
        TemplatesMenu
        UserTemplates
        Topics 'for use with export file only
        TopicDetails 'for use with export file only
        AllUserTemplates 'for use with export file only
        Membership 
        DebugReports 
    End Enum
    Public Sub New(ByVal pConfigType As XmlConfigType, Optional ByVal pstrParamString As String = "", Optional ByVal InputFile As String = "")
        config = New NameValueCollection()
        Dim xDoc As New XmlDocument()
        Dim ConfigFile As String
        Dim lstrSingleNode As String

        If InputFile = "" Then 
            'ConfigFile = System.Reflection.Assembly.GetExecutingAssembly.Location.ToString() & ".dat"
            
            ConfigFile = System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat"
        Else
            ConfigFile = InputFile
        End If

        lstrSingleNode = "./configuration/" & GetSectionString(pConfigType, pstrParamString) 

        Dim OpenFile As FileStream = New FileStream(ConfigFile, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        xDoc.Load(OpenFile)

        Dim n1 As XmlNode = xDoc.SelectSingleNode(lstrSingleNode)

        If Not (n1 Is Nothing) AndAlso Not (n1.ChildNodes Is Nothing) Then
            Dim list As XmlNodeList = n1.ChildNodes

            Dim lintArrInc As Integer
            For lintArrInc = 0 To list.Count - 1
                Dim xNode As XmlNode = list(lintArrInc)
                Dim key As String = xNode.Attributes.GetNamedItem("key").Value
                Dim val As String = xNode.Attributes.GetNamedItem("value").Value
                'Console.WriteLine(key & " " & val)
                
                Try
                    If pConfigType = InitalXMLConfig.XmlConfigType.UserTemplates Then
                        val = val.ToUpper
                    End If
                Catch
                    '
                End Try
                
                config(key) = val
            Next lintArrInc
        End If

        xDoc = Nothing
        OpenFile.Close()
        OpenFile = Nothing

    End Sub 'New
    Public Property GetValue(ByVal pstrKey As String, ByVal pstrDefaultValue As String) As String
        Get
            Dim s As String = config(pstrKey)
            If s Is Nothing Then s = ""

            If s.Trim = "" Then
                s = pstrDefaultValue
            End If
            Return s
        End Get
        Set(ByVal Value As String)
            'm = Value
        End Set
    End Property
End Class
'Friend Class Browse
'    Function BrowseToUrlNew(ByVal pstrURL As String, ByVal pme As Form) As Integer
'        'Created
'        Dim RetVal As Integer = 0

'        If Not pme Is Nothing Then 
'            Busy(pme, True)
'        End If

'        Try
'            Dim psInfo As New System.Diagnostics.ProcessStartInfo("IEXPLORE", pstrURL)
'            psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
'            psInfo.CreateNoWindow = True
'            Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.Start(psInfo)

'            myProcess = Nothing
'            RetVal = 1
'        Catch
'            Try
'                Dim psInfo As New System.Diagnostics.ProcessStartInfo(pstrURL)
'                psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
'                psInfo.CreateNoWindow = True
'                Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.Start(psInfo)

'                myProcess = Nothing
'                RetVal = 2
'            Catch
'                Dim iexp As Object
'                iexp = Microsoft.VisualBasic.CreateObject("InternetExplorer.application")

'                If Not (iexp Is Nothing) Then ' you want an error!!
'                    iexp.Navigate(pstrURL)
'                    iexp.Application.Visible = True
'                    iexp = Nothing
'                    RetVal = 3
'                End If
'            End Try

'        End Try

'        RetVal += 10 

'        If Not pme Is Nothing Then 
'            Busy(pme, False)
'        End If

'        Return RetVal

'    End Function

'End Class
