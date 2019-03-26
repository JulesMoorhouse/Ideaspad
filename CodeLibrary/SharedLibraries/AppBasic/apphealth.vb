Imports System
Imports System.IO
Imports System.Xml
Imports System.Collections.Specialized
Imports System.Diagnostics
Public Module apphealth
    'Public Structure ManifestInfo
    '    Dim strSitePath As String
    '    Dim strManifestDir As String
    '    Dim strManifestFile As String
    'End Structure
    Dim LangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("AppBasic.AppBasic", _
        System.Reflection.Assembly.GetExecutingAssembly()) 

    Public gbooNeedToRestartProgAfterCFU As Boolean = False
    Public gstrCFUTempDir As String
    'Function hasMultipleInstances(ByVal procName As String, ByVal pstrCaption As String) As Boolean
    '    Try
    '        '''Vars for detecting multiple instances of an app
    '        ''Dim proc As Process
    '        ''Dim processes() As Process
    '        '''Dim procName As String = "IdeasPad" 'Substitute your appname here for your apps
    '        ''Dim procIndex As Integer
    '        ''Dim procCount As Integer
    '        '''Gets all the process by this name and adds them to the array of processess
    '        ''processes = Process.GetProcessesByName(procName)
    '        ''xx()
    '        '''Gets the number of instances of the process
    '        ''procCount = processes.Length
    '        '''to check for more than one instance of process
    '        ''If procCount > 1 Then
    '        ''    'MxessageBox.Show("You already have one instance of " & procName & " running on your computer.", pstrCaption)
    '        ''    MessageBox.Show(LangText.GetString("AppHealth_AlreadyInstance").Replace("[ProdName]", pstrCaption), pstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

    '        ''    For Each proc In processes
    '        ''        If procIndex > 0 Then
    '        ''            Return True
    '        ''        End If
    '        ''        procIndex = procIndex + 1
    '        ''    Next
    '        ''Else
    '        ''    Return False
    '        ''End If
    '        xxx()
    '        
    '        'Added due to a bug possible with XP SP2, however someone on GotDotNet could get similar code to the above to work
    '        Dim appMutex As New System.Threading.Mutex(False, procName)
    '        If appMutex.WaitOne(0, False) Then
    '            hasMultipleInstances = False
    '        Else
    '            hasMultipleInstances = True
    '            MessageBox.Show(LangText.GetString("AppHealth_AlreadyInstance").Replace("[ProdName]", pstrCaption), pstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        End If
    '        

    '    Catch ProcErr As Exception
    '        'MxessageBox.Show(ProcErr.Message)
    '    End Try
    'End Function
    Sub Busy(ByVal pojForm As Form, ByVal pbooFlags As Boolean)

        If pbooFlags = True Then
            pojForm.Cursor = Cursors.WaitCursor
            'pojForm.Enabled = False
        Else
            pojForm.Cursor = Cursors.Default
            'pojForm.Enabled = True
        End If

    End Sub
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

        '''CreateBlankConfigFile()
        If File.Exists(ConfigFile) = False Then
            Dim CreateFile As FileStream = New FileStream(ConfigFile, FileMode.Create, FileAccess.Write, FileShare.Write)
            Dim StreamWriter As StreamWriter = New StreamWriter(CreateFile)

            'Dim lstrOutPut As String = "<configuration>" & Environment.NewLine & _
            '    "  <appSettings>" & Environment.NewLine & _
            '    "  </appSettings>" & Environment.NewLine & _
            '    "</configuration>"

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

        'Dim OpenFile As FileStream = New FileStream(ConfigFile, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        
        Dim OpenFile As FileStream = New FileStream(ConfigFile, FileMode.Open, FileAccess.Read, FileShare.Read)
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

        
        Dim RetrtCount As Integer = 0
TryLoadAgain:
        Try
            xDoc.Load(ConfigFile) 'OpenFile
        Catch err As System.IO.IOException

            If RetrtCount <= 5 Then
                RetrtCount += 1
                Sleep(2)
                Application.DoEvents()
                GoTo TryLoadAgain
            Else
                Throw err
            End If
        End Try
        

        Try 'update
            
            'at = xDoc.SelectSingleNode("configuration/" & lstrChildNode & "/add[@key='" & pstrKey & "']").Attributes("Value")
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
    Sub BatchXMLItemWrite(ByVal xDoc As XmlDocument, ByVal pstrSection As String, ByVal pstrKey As String, ByVal pstrValue As String)
        Dim at As XmlAttribute

        Try 'update
            at = xDoc.SelectSingleNode("configuration/" & pstrSection & "/add[@key='" & pstrKey & "']").Attributes("value")
            at.Value = pstrValue
        Catch ex As System.NullReferenceException
            'add new
            Dim n1 As XmlNode = xDoc.SelectSingleNode("./configuration/" & pstrSection & "")

            If n1 Is Nothing Then
                Dim newElem As XmlNode = xDoc.CreateNode(XmlNodeType.Element, pstrSection, "")
                newElem.InnerText = ""
                'add the new node to the document 
                Dim root As XmlElement = xDoc.DocumentElement
                root.AppendChild(newElem)
                n1 = xDoc.SelectSingleNode("./configuration/" & pstrSection & "")
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
            Case InitalXMLConfig.XmlConfigType.UserSettings 
                GetSectionString = "UserSettings-" & pstrParamString 
        End Select

    End Function
    Sub CleanUpAfterDupeBug(ByVal openFile As String)
        

        Dim location As String = openFile 'Application.StartupPath + "/CubeCartByWeightAlter.exe.dat"
        Dim io As New IO.StreamReader(location)
        Dim xmlArray As New ArrayList()
        Do While io.Peek <> -1
            Dim lineread As String = io.ReadLine()
            Dim bFound As Boolean = False

            ' Loop through the arraylist and check to see if any occurences exist, if so replace them.

            Dim xlocation As Integer = lineread.IndexOf("=", lineread.IndexOf("=") + 1)

            Dim splittext As String
            If xlocation > 0 Then
                splittext = lineread.Substring(0, xlocation)

                Dim p As Integer
                For p = 0 To xmlArray.Count - 1
                    ' If xmlArray(p).contains(splittext) Then
                    If InStrGet(xmlArray(p), splittext) > 0 Then
                        xmlArray(p) = lineread
                        bFound = True
                    End If
                Next
            End If
            ' ---

            ' If no match was found, then add this into the arraylist.
            If bFound = False Then
                xmlArray.Add(lineread)
            End If

        Loop

        io.Close() ' close the file so we can write to it

        ' Do the writing back to the file with only the latest values!
        Dim z As Integer
        Dim ir As New IO.StreamWriter(openFile) 'Application.StartupPath + "/CubeCartByWeightAlter.exe.dat")
        ir.Flush()
        For z = 0 To xmlArray.Count - 1
            ir.WriteLine(xmlArray(z))
        Next
        ir.Close()

        xmlArray.Clear()

    End Sub
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
        UserSettings 
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