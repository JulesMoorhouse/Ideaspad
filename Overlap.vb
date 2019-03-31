
Imports System.Text.RegularExpressions
''Imports System.Globalization
Imports Microsoft.VisualBasic
Imports System.Xml
Imports System.Collections.Specialized
Imports System.IO
Module Overlap
    'As UpdateRestart aka Beside02 updates files, including AppBasic.dll it can use Appbasic.dll
    'Therefore the required functions have been copied here.
    'created

    Enum DateInterval
        Day = 4
        Hour = 7
        Month = 2
        Second = 9
        Minute = 8
    End Enum

    Function Reverse(ByVal pstrString As String) As String
        Dim lintArrInc As Integer

        For lintArrInc = 0 To pstrString.Length - 1
            Reverse = Reverse & Microsoft.VisualBasic.Right(pstrString, 1)
            pstrString = Microsoft.VisualBasic.Left(pstrString, pstrString.Length - 1)
        Next lintArrInc

    End Function
    Function Occurences(ByVal strSearchString As String, ByVal strSearchFor As String) As Integer
        Dim r As New Regex(strSearchFor)
        Dim m As MatchCollection = r.Matches(strSearchString)

        Occurences = m.Count.ToString
    End Function
    Sub Sleep(ByVal Seconds As Long)
        Dim Start As DateTime = Date.Now

        While Not DateDiffGet(DateInterval.Second, Start, Date.Now) >= Seconds
            ' do nothing 
        End While

    End Sub
    Function DateDiffGet(ByVal Interval As DateInterval, ByVal Date1 As Date, ByVal Date2 As Date) As Long

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
    Function ReturnNthStr(ByVal pstrString As String, ByVal pintPosition As Integer, ByVal pstrChar As String) As String
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
    Sub Busy(ByVal pojForm As Form, ByVal pbooFlags As Boolean)

        If pbooFlags = True Then
            pojForm.Cursor = Cursors.WaitCursor
            'pojForm.Enabled = False
        Else
            pojForm.Cursor = Cursors.Default
            'pojForm.Enabled = True
        End If

    End Sub
    Function AscGet(ByVal pstrChar As Char) As Integer
        Dim b As Byte() = System.Text.Encoding.Default.GetBytes(New [Char]() {pstrChar})
        AscGet = b(0).ToString()

        If AscGet <> Microsoft.VisualBasic.Asc(pstrChar) Then
            MessageBox.Show("AscGet - Inaccurate! AscGet='" & AscGet & "' and VB.Asc='" & Microsoft.VisualBasic.Asc(pstrChar) & "'")
        End If
    End Function
    Function ChrGet(ByVal CharCode As Integer) As Char
        Dim chDEC(0) As Char
        Dim bControlChars As Byte() = {CharCode}   '**char number in ASCII table for CARRIAGE RETURN
        Dim dec As System.Text.Decoder = System.Text.Encoding.Default.GetDecoder()
        dec.GetChars(bControlChars, 0, bControlChars.Length, chDEC, 0)
        ChrGet = chDEC(0)
    End Function
    Function LeftGet(ByVal pstrString As String, ByVal plngPos As Long) As String

        LeftGet = pstrString.Substring(0, plngPos)

        If LeftGet <> Microsoft.VisualBasic.Left(pstrString, plngPos) Then
            MessageBox.Show("LeftGet - Inaccurate!")
        End If
    End Function
    Function MidGet(ByVal Target As String, ByVal Start As Integer, Optional ByVal Length As Integer = 0) As String

        If Length = 0 Then Length = Target.Length - (Start - 1)

        If Start - 1 + Length > Target.Length Then
            Length = Target.Length - (Start - 1)
        End If

        MidGet = Target.Substring(Start - 1, Length)

        If MidGet <> Microsoft.VisualBasic.Mid(Target, Start, Length) Then
            MessageBox.Show("MidGet - Inaccurate!")
        End If
    End Function
    Function RightGet(ByVal pstrString As String, ByVal plngPos As Long) As String

        'RightGet = pstrString.Substring(plngPos)
        'MxessageBox.Show(MyString.Substring(MyString.Length - n, n), Microsoft.VisuxalBasic.Right(MyString, 5))
        RightGet = pstrString.Substring(pstrString.Length - plngPos, plngPos)

        If RightGet <> Microsoft.VisualBasic.Right(pstrString, plngPos) Then
            MessageBox.Show("RIGHTGET - Inaccurate!")
        End If
    End Function
    Function InStrGet(ByVal String1 As String, ByVal String2 As String) As Long

        InStrGet = String1.IndexOf(String2) + 1

        If InStrGet <> Microsoft.VisualBasic.InStr(String1, String2) Then
            MessageBox.Show("InStrGet1 - Inaccurate!")
        End If
    End Function
    Function threedigs(ByVal str As String) As String
        'added 
        If str.Length = 1 Then
            Return "00" & str
        ElseIf str.Length = 2 Then
            Return "0" & str
        Else
            Return str
        End If

    End Function
    Sub SaveSetting(ByVal pstrKey As String, ByVal pstrValue As String, ByVal pConfigType As InitalXMLConfig.XmlConfigType, _
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
    Function GetSectionString(ByVal pConfigType As InitalXMLConfig.XmlConfigType, ByVal pstrParamString As String) As String

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
    Function GetSetting(ByVal SettingKey As String, ByVal DefaultValue As String, ByVal pConfigType As InitalXMLConfig.XmlConfigType, _
        ByVal pstrParamString As String, Optional ByVal outputFile As String = "") As String

        Dim xDoc As New XmlDocument()
        Dim at As XmlAttribute
        Dim ConfigFile As String

        If outputFile = "" Then 
            'ConfigFile = System.Reflection.Assembly.GetExecutingAssembly.Location.ToString() & ".dat"
            
            ConfigFile = System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat"
        Else
            ConfigFile = outputFile
        End If

        Dim lstrChildNode As String = GetSectionString(pConfigType, pstrParamString)  

        If File.Exists(ConfigFile) = False Then
            Dim CreateFile As FileStream = New FileStream(ConfigFile, FileMode.Create, FileAccess.Write, FileShare.Write)
            Dim StreamWriter As StreamWriter = New StreamWriter(CreateFile)

            Dim lstrOutPut As String = "<configuration>" & Environment.NewLine & _
                "  <appSettings>" & Environment.NewLine & _
                "  </appSettings> " & Environment.NewLine & _
                "  <Bookmarks->" & Environment.NewLine & _
                "  </Bookmarks->" & Environment.NewLine & _
                "  <TemplatesMenu->" & Environment.NewLine & _
                "  </TemplatesMenu->" & Environment.NewLine & _
                "  <UserTemplates>" & Environment.NewLine & _
                "  </UserTemplates>" & Environment.NewLine & _
                "  <AllUserTemplates>" & Environment.NewLine & _
                "  </AllUserTemplates>" & Environment.NewLine & _
                "</configuration>"

            If outputFile <> "" Then 
                lstrOutPut = "<configuration>" & Environment.NewLine & _
                    "  <appSettings>" & Environment.NewLine & _
                    "  </appSettings> " & Environment.NewLine & _
                    "  <Bookmarks->" & Environment.NewLine & _
                    "  </Bookmarks->" & Environment.NewLine & _
                    "  <TemplatesMenu->" & Environment.NewLine & _
                    "  </TemplatesMenu->" & Environment.NewLine & _
                    "  <UserTemplates>" & Environment.NewLine & _
                    "  </UserTemplates>" & Environment.NewLine & _
                    "  <AllUserTemplates>" & Environment.NewLine & _
                    "  </AllUserTemplates>" & Environment.NewLine & _
                    "  <Topics>" & Environment.NewLine & _
                    "  </Topics>" & Environment.NewLine & _
                    "  <TopicDetails>" & Environment.NewLine & _
                    "  </TopicDetails>" & Environment.NewLine & _
                    "</configuration>"
            End If

            StreamWriter.Write(lstrOutPut)
            StreamWriter.Close()
            CreateFile.Close()
        End If
        '----

        Dim OpenFile As FileStream = New FileStream(ConfigFile, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        xDoc.Load(OpenFile)

        Try
            'at = xDoc.SelectSingleNode("configuration/appSettings/add[@key='" & SettingKey & "']").Attributes("value")
            at = xDoc.SelectSingleNode("configuration/" & lstrChildNode & "/add[@key='" & SettingKey & "']").Attributes("value")

            GetSetting = at.Value
            
            Try
                If pConfigType = InitalXMLConfig.XmlConfigType.UserTemplates Then
                    GetSetting = GetSetting.ToUpper
                End If
            Catch
                '
            End Try
            
        Catch ex As System.NullReferenceException
        Finally
            xDoc = Nothing
            OpenFile.Close()
            OpenFile = Nothing
        End Try

        If GetSetting = "" And DefaultValue <> "" Then
            GetSetting = DefaultValue
        End If
    End Function
End Module
Public Class InitalXMLConfig
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
End Class