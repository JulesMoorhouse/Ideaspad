Imports mshtml
Imports System.IO

Friend Module Templates

    Friend lstrTempFiles(0) As String

    Dim ass As System.Reflection.Assembly = System.Reflection.Assembly.Load("IPTemplates")
    Friend Sub ShowForm(ByVal pstrResouceFile As String, ByRef BrowserControl As WinOnly.WebOCHostCtrl, ByVal pbooUseResource As Boolean)

        'Console.WriteLine("ShowForm Start")
        'Get CSS in variable from settings file
        Dim lbooSystemScheme As Boolean = False
        Dim lstrSchemeName As String = GetSetting("Template Scheme", "SYSTEM:slick.css", InitalXMLConfig.XmlConfigType.AppSettings, "") 'added Slick.css 

        If lstrSchemeName <> "" Then
            If InStrGet(lstrSchemeName, "SYSTEM:") > 0 Then
                lbooSystemScheme = True
                lstrSchemeName = Microsoft.VisualBasic.Replace(lstrSchemeName, "SYSTEM:", "")
            End If
        End If

        'Get CSS file itself and put in temp file
        Dim lstrSchemeLocalFile As String
        If lstrSchemeName <> "" Then
            If lbooSystemScheme = True Then
                Dim stream As System.IO.Stream = ass.GetManifestResourceStream("IPTemplates." & lstrSchemeName)
                'Dim StreamReader As New System.IO.StreamReader(stream)
                
                Dim StreamReader As New System.IO.StreamReader(stream, System.Text.Encoding.GetEncoding("ISO-8859-1"))
                lstrSchemeLocalFile = TrimGet(Microsoft.VisualBasic.Environ("TEMP")) & "\~S" & Microsoft.VisualBasic.Format(DateTime.Now(), "MMddhhmmssff") & ".tmp"
                ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1)
                lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = lstrSchemeLocalFile
                Dim StreamWriter As StreamWriter = New StreamWriter(lstrSchemeLocalFile)
                StreamWriter.WriteLine(StreamReader.ReadToEnd)
                StreamReader.Close()
                StreamWriter.Close()
            Else
                'lstrSchemeLocalFile = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & _
                '    "\Layouts\" & lstrSchemeName
                lstrSchemeLocalFile = lstrSchemeName 
            End If
        End If

        If pbooUseResource = True Then
            Dim stream As System.IO.Stream = ass.GetManifestResourceStream("IPTemplates." & pstrResouceFile)
            Dim StreamReader As New System.IO.StreamReader(stream)
            Dim lstrTempFile As String = TrimGet(Microsoft.VisualBasic.Environ("TEMP")) & "\~T" & Microsoft.VisualBasic.Format(DateTime.Now(), "MMddhhmmssff") & ".tmp"
            Dim StreamWriter As StreamWriter = New StreamWriter(lstrTempFile)

            ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1)
            lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = lstrTempFile

            'Replace CSS occurence in template with CSS variable
            Dim lstrHTMLFileData As String = StreamReader.ReadToEnd
            lstrHTMLFileData = Microsoft.VisualBasic.Replace(lstrHTMLFileData, "XXXXX.CSS", lstrSchemeLocalFile)
            StreamWriter.WriteLine(lstrHTMLFileData)
            StreamReader.Close()
            StreamWriter.Close()

            BrowserControl.Navigate(lstrTempFile) ', Nothing)
        Else
            'BrowserControl.Navigate(pstrResouceFile)
            

            If InStrGet(pstrResouceFile, ":") > 0 Then 
                BrowserControl.Navigate(pstrResouceFile) 
            Else
                BrowserControl.Navigate(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) & _
                        "\Layouts\" & pstrResouceFile)
            End If

        End If

    End Sub
    Friend Function FillTemplatesUsedList(ByRef lstrUsedTemplatesIDs() As String, ByRef lstrTemplateFileName() As String, _
    ByRef lstrTemplateResources() As IPTemplates._main.resources, ByRef lstTemplates As ListBox) As String
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        Dim lbooRedimmed As Boolean = False
        ReDim lstrUsedTemplatesIDs(0)
        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        Dim lstrSQL As String = "SELECT DISTINCT TemplateID FROM TopicDetail WHERE TemplateID <> ' ' ORDER BY TemplateID;"

        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, _
         ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        With lsnaLists
            Do While Not .EOF
                If lbooRedimmed = False Then
                    ReDim Preserve lstrUsedTemplatesIDs(lstrUsedTemplatesIDs.GetUpperBound(0))
                    lbooRedimmed = True
                Else
                    ReDim Preserve lstrUsedTemplatesIDs(lstrUsedTemplatesIDs.GetUpperBound(0) + 1)
                End If
                lstrUsedTemplatesIDs(lstrUsedTemplatesIDs.GetUpperBound(0)) = .Fields("TemplateID").Value & ""
                
                Try
                    lstrUsedTemplatesIDs(lstrUsedTemplatesIDs.GetUpperBound(0)) = lstrUsedTemplatesIDs(lstrUsedTemplatesIDs.GetUpperBound(0)).ToUpper
                Catch
                    '
                End Try
                
                .MoveNext()
            Loop
        End With

        lsnaLists.Close()
        lcnn1.Close()

        ReDim lstrTemplateFileName(0)

        Dim lintArrInc, lintArrInc2 As Integer
        For lintArrInc = 0 To lstrUsedTemplatesIDs.GetUpperBound(0)
            Dim lbooFoundSystemTemplate As Boolean = False
            For lintArrInc2 = 0 To lstrTemplateResources.GetUpperBound(0)
                If lstrUsedTemplatesIDs(lintArrInc) = lstrTemplateResources(lintArrInc2).ID Then
                    lbooFoundSystemTemplate = True
                    lstTemplates.Items.Add(lstrTemplateResources(lintArrInc2).Name)
                    ReDim Preserve lstrTemplateFileName(lintArrInc)
                    lstrTemplateFileName(lintArrInc) = "SYSTEM:" & lstrTemplateResources(lintArrInc2).file
                    Exit For
                End If
            Next lintArrInc2
            If lbooFoundSystemTemplate = False Then
                'Add user template info
                'Dim UserTemplateConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.UserTemplates, lstrUsedTemplatesIDs(lintArrInc))
                
                If lstrUsedTemplatesIDs(lintArrInc) <> "" Then 
                    Dim UserTemplateConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.UserTemplates, lstrUsedTemplatesIDs(lintArrInc).ToUpper)
                    With UserTemplateConfig
                        lstTemplates.Items.Add(.GetValue("Name", ""))
                        ReDim Preserve lstrTemplateFileName(lintArrInc)
                        lstrTemplateFileName(lintArrInc) = .GetValue("FileName", "")
                    End With
                End If 
            End If
        Next lintArrInc

    End Function
    Friend Sub SpawnBrowserObject(ByRef AxWebBrowser As WinOnly.WebOCHostCtrl, ByRef pme As Form)
        'Dim AxWebBrowser As AxSHDocVw.AxWebBrowser
        AxWebBrowser = New WinOnly.WebOCHostCtrl()
        AxWebBrowser.Visible = False

        'CType(AxWebBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
        AxWebBrowser.Enabled = True
        AxWebBrowser.Location = New System.Drawing.Point(980, 192) ' New System.Drawing.Point(280, 192)
        'Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TemplateSelection))
        'AxWebBrowser.OcxState = CType(resources.GetObject("AxWebBrowser.OcxState"), System.Windows.Forms.AxHost.State)
        AxWebBrowser.Size = New System.Drawing.Size(64, 24)
        AxWebBrowser.TabIndex = 8
        pme.Controls.AddRange(New System.Windows.Forms.Control() {AxWebBrowser})

        'CType(AxWebBrowser, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub
    Function GetData(ByVal pstrRawString, ByVal pstrSearchStringStart, ByVal pstrSeachStringEnd)
        Dim lintDomPos
        Dim lintStartPos

        'pstrURL = Trim(UCase(pstrURL))
        lintStartPos = InStrGet(1, pstrRawString, pstrSearchStringStart)
        If lintStartPos > 0 Then
            lintDomPos = InStrGet(lintStartPos + pstrSearchStringStart.length, pstrRawString, pstrSeachStringEnd)
            'If lintDomPos <> 0 Then
            If lintDomPos <> 0 And (lintStartPos + pstrSearchStringStart.length) <> lintDomPos Then 
                GetData = MidGet(pstrRawString, lintStartPos + pstrSearchStringStart.length, lintDomPos - lintStartPos - pstrSearchStringStart.length)
            Else
                GetData = ""
            End If
            'GetData = Mid(pstrRawString + 5, lintStartPos, 10)
        End If

    End Function
    Friend Sub DeleteTempFiles()
        Dim lintArrInc As Integer

        Try
            For lintArrInc = 0 To lstrTempFiles.GetUpperBound(0)
                If lstrTempFiles(lintArrInc) <> "" Then
                    If RightGet(lstrTempFiles(lintArrInc), 1) = "\" Then 'directory
                        Try 
                            Directory.Delete(lstrTempFiles(lintArrInc), True)
                        Catch
                        End Try
                    Else
                        Try 
                            File.Delete(lstrTempFiles(lintArrInc))
                        Catch
                        End Try
                    End If
                End If
            Next lintArrInc
        Catch ex As Exception
        End Try
    End Sub
    Friend Sub ExportTopics(ByVal pstrTopics() As Export.Topics, ByVal pbooAllTopics As Boolean)
        Dim strChunk As String = ""
        Dim Offset As Long
        Dim Totalsize As Long
        Dim ChunkSize As Long
        Dim lstrSQL As String
        Dim lintArrInc As Integer

        If gstrSortOrder = "ALPHA" Then
            lstrSQL = "SELECT CLng(Left([ParentTopicCode] & '0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), " & _
                "* FROM Topics WHERE (InUse = True) ORDER BY Topics.Level, CLng(Left([ParentTopicCode] & " & _
                "'0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), Title;"
        Else
            lstrSQL = "SELECT CLng(Left([ParentTopicCode] & '0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), " & _
            "* FROM Topics WHERE (InUse = True) ORDER BY Topics.Level, CLng(Left([ParentTopicCode] & " & _
            "'0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), SeqNum, Title;"
        End If

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        Dim lintTArrInc As Integer
        With lsnaLists
            Do While Not .EOF
                Dim lstrThisTopicCode As String = .Fields("TopicCode").Value
                For lintArrInc = 0 To pstrTopics.GetUpperBound(0)
                    If pstrTopics(lintArrInc).Code = lstrThisTopicCode Then
                        strChunk = ""

                        '--- Fill array too ---
                        For lintTArrInc = 0 To pstrTopics.GetUpperBound(0)
                            If pstrTopics(lintTArrInc).Code = lstrThisTopicCode Then
                                If Microsoft.VisualBasic.IsDBNull(.Fields("ImgIdx").Value) Then
                                    pstrTopics(lintTArrInc).ImgIdx = 0
                                Else
                                    pstrTopics(lintTArrInc).ImgIdx = .Fields("ImgIdx").Value
                                End If

                                pstrTopics(lintTArrInc).Level = .Fields("Level").Value & ""
                                pstrTopics(lintTArrInc).Parent = .Fields("ParentTopicCode").Value & ""
                                pstrTopics(lintTArrInc).Sequence = .Fields("SeqNum").Value & ""
                                pstrTopics(lintTArrInc).Title = .Fields("Title").Value & ""
                                pstrTopics(lintTArrInc).TrueTopicCode = ReturnTrueTopicStr(lstrThisTopicCode)
                            End If
                        Next lintTArrInc
                        '--- Fill array too ---
                    End If
                Next lintArrInc
                .MoveNext()

            Loop
        End With

        lsnaLists.Close()
        lcnn1.Close()
    End Sub
    Friend Sub ExportTopicsDetails(ByVal pstrOutputDir As String, ByVal pstrTopics() As Export.Topics, ByVal pbooAllTopics As Boolean, _
    ByRef pstrTD() As Export.TopicDetail)
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        'Dim strChunk As String = ""
        Dim builder As New System.Text.StringBuilder() 

        Dim Offset As Long
        Dim Totalsize As Long
        Dim ChunkSize As Long
        Dim lstrSQL As String

        AddDebugComment("Templates.ExportTopicsDetails") 
        Dim lintDoeventsInc As Integer 

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        Dim lintArrInc As Integer

        lstrSQL = "SELECT * FROM TopicDetail"

        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        Dim lintTArrInc As Integer
        With lsnaLists
            Do While Not .EOF
                Dim lstrThisTopicCode As String = .Fields("TopicCode").Value
                For lintArrInc = 0 To pstrTopics.GetUpperBound(0)
                    If pstrTopics(lintArrInc).TrueTopicCode = lstrThisTopicCode Then
                        Dim lstrThisTemplateID As String = .Fields("TemplateID").Value & ""
                        
                        Try
                            lstrThisTemplateID = lstrThisTemplateID.ToUpper
                        Catch
                            '
                        End Try
                        'not needed 
                        'Dim lintByteLen As Integer = .Fields("ByteLen").Value 
                        
                        'AddTopicDetailArrayItem(pstrTD, ReturnTrueTopicStr(lstrThisTopicCode), lstrThisTemplateID)
                        
                        'AddTopicDetailArrayItem(pstrTD, ReturnTrueTopicStr(lstrThisTopicCode), lstrThisTemplateID)
                        
                        Dim lstrOptions As String = .Fields("options").Value
                        AddTopicDetailArrayItem(pstrTD, ReturnTrueTopicStr(lstrThisTopicCode), lstrThisTemplateID, lstrOptions)

                        'strChunk = ""
                        builder = New System.Text.StringBuilder() 

                        'commented out
                        'Try
                        '    System.IO.File.Delete(pstrOutputDir & lstrThisTopicCode & ".top")
                        'Catch ex As Exception
                        'End Try

                        Dim lstrCurrentTopicFile As String = pstrOutputDir & lstrThisTopicCode & ".top" 

                        ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1) 
                        lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = lstrCurrentTopicFile 

                        
                        Dim lbooProceed As Boolean = True
                        If File.Exists(lstrCurrentTopicFile) = True Then
                            If Microsoft.VisualBasic.FileLen(lstrCurrentTopicFile) <> 0 Then
                                lbooProceed = False
                            End If
                        End If
                        

                        If lbooProceed = True Then 'cater for linked topics

                            Dim OpenFile As FileStream = New FileStream(lstrCurrentTopicFile, _
                                FileMode.CreateNew, FileAccess.Write, FileShare.Write) 
                            'Dim StreamWriter As StreamWriter = New StreamWriter(OpenFile)
                            
                            Dim StreamWriter As StreamWriter = New StreamWriter(OpenFile, System.Text.Encoding.GetEncoding("ISO-8859-1"))

                            Offset = 0
                            ChunkSize = 1000
                            Totalsize = lsnaLists("Detail").ActualSize

                            Do While Offset < Totalsize
                                builder.Append(lsnaLists("Detail").GetChunk(ChunkSize)) 
                                Offset = Offset + ChunkSize
                            Loop

                            Dim lintByteLength As Integer = lsnaLists("ByteLen").Value
                            Dim sbOutput As New System.Text.StringBuilder() 
                            If lintByteLength <> -1 And builder.Length > 0 Then
                                AddDebugComment("Inflate")
                                Dim InfDef As New InflateDeflate()
                                sbOutput.Append(InfDef.Inflate(builder.ToString, lintByteLength)) 
                            End If
                            
                            StreamWriter.WriteLine(sbOutput.ToString) 
                            StreamWriter.Close()
                            OpenFile.Close() 
                        End If 
                    End If
                Next lintArrInc

                
                lintDoeventsInc += 1
                If lintDoeventsInc > 10 Then
                    System.Windows.Forms.Application.DoEvents()
                    lintDoeventsInc = 0
                End If
                
                .MoveNext()
            Loop
        End With

        lsnaLists.Close()
        lcnn1.Close()

    End Sub
    Friend Sub ExportTopicsDetailsOLD(ByVal pstrOutputDir As String, ByVal pstrTopics() As Export.Topics, ByVal pbooAllTopics As Boolean, _
        ByRef pstrTD() As Export.TopicDetail)
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim strChunk As String = ""
        Dim Offset As Long
        Dim Totalsize As Long
        Dim ChunkSize As Long
        Dim lstrSQL As String

        AddDebugComment("Templates.ExportTopicsDetails") 
        Dim lintDoeventsInc As Integer 

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        Dim lintArrInc As Integer

        lstrSQL = "SELECT * FROM TopicDetail"

        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        Dim lintTArrInc As Integer
        With lsnaLists
            Do While Not .EOF
                Dim lstrThisTopicCode As String = .Fields("TopicCode").Value
                For lintArrInc = 0 To pstrTopics.GetUpperBound(0)
                    If pstrTopics(lintArrInc).TrueTopicCode = lstrThisTopicCode Then
                        Dim lstrThisTemplateID As String = .Fields("TemplateID").Value & ""
                        
                        Try
                            lstrThisTemplateID = lstrThisTemplateID.ToUpper
                        Catch
                            '
                        End Try
                        'not needed 
                        'Dim lintByteLen As Integer = .Fields("ByteLen").Value 
                        
                        'AddTopicDetailArrayItem(pstrTD, ReturnTrueTopicStr(lstrThisTopicCode), lstrThisTemplateID)
                        
                        'AddTopicDetailArrayItem(pstrTD, ReturnTrueTopicStr(lstrThisTopicCode), lstrThisTemplateID)
                        
                        Dim lstrOptions As String = .Fields("options").Value
                        AddTopicDetailArrayItem(pstrTD, ReturnTrueTopicStr(lstrThisTopicCode), lstrThisTemplateID, lstrOptions)

                        strChunk = ""

                        'commented out
                        'Try
                        '    System.IO.File.Delete(pstrOutputDir & lstrThisTopicCode & ".top")
                        'Catch ex As Exception
                        'End Try

                        Dim lstrCurrentTopicFile As String = pstrOutputDir & lstrThisTopicCode & ".top" 

                        ReDim Preserve lstrTempFiles(lstrTempFiles.GetUpperBound(0) + 1) 
                        lstrTempFiles(lstrTempFiles.GetUpperBound(0)) = lstrCurrentTopicFile 

                        
                        Dim lbooProceed As Boolean = True
                        If File.Exists(lstrCurrentTopicFile) = True Then
                            If Microsoft.VisualBasic.FileLen(lstrCurrentTopicFile) <> 0 Then
                                lbooProceed = False
                            End If
                        End If
                        

                        If lbooProceed = True Then 'cater for linked topics

                            Dim OpenFile As FileStream = New FileStream(lstrCurrentTopicFile, _
                                FileMode.CreateNew, FileAccess.Write, FileShare.Write) 
                            
                            Dim StreamWriter As StreamWriter = New StreamWriter(OpenFile, System.Text.Encoding.GetEncoding("ISO-8859-1"))
             
                            Offset = 0
                            ChunkSize = 1000
                            Totalsize = lsnaLists("Detail").ActualSize

                            Do While Offset < Totalsize
                                strChunk = strChunk + lsnaLists("Detail").GetChunk(ChunkSize)
                                Offset = Offset + ChunkSize
                            Loop

                            Dim lintByteLength As Integer = lsnaLists("ByteLen").Value
                            If lintByteLength <> -1 And strChunk <> "" Then
                                AddDebugComment("Inflate")
                                Dim InfDef As New InflateDeflate()
                                strChunk = InfDef.Inflate(strChunk, lintByteLength)
                            End If
                            
                            StreamWriter.WriteLine(strChunk)
                            StreamWriter.Close()
                            OpenFile.Close() 
                        End If 
                    End If
                Next lintArrInc

                
                lintDoeventsInc += 1
                If lintDoeventsInc > 10 Then
                    System.Windows.Forms.Application.DoEvents()
                    lintDoeventsInc = 0
                End If
                
                .MoveNext()
            Loop
        End With

        lsnaLists.Close()
        lcnn1.Close()

    End Sub
    Private Sub AddTopicDetailArrayItem(ByRef pstrTD() As Export.TopicDetail, ByVal pstrTrueTopicCode As String, _
        ByVal pstrTemplateID As String, ByVal pOptions As String)

        Dim lintArrInc As Integer
        Dim lbooAlreadyGot As Boolean = False

        For lintArrInc = 0 To pstrTD.GetUpperBound(0)
            
            Try
                pstrTD(lintArrInc).TemplateID = pstrTD(lintArrInc).TemplateID.ToUpper
            Catch
                '
            End Try
            Try
                pstrTemplateID = pstrTemplateID.ToUpper
            Catch
                '
            End Try

            
            If pstrTD(lintArrInc).Code = pstrTrueTopicCode And pstrTD(lintArrInc).TemplateID = pstrTemplateID Then
                lbooAlreadyGot = True
                Exit For
            End If
        Next lintArrInc

        If lbooAlreadyGot = False Then
            If pstrTD(0).Code = "" And pstrTD.GetUpperBound(0) = 0 Then
                'dont redim
            Else
                ReDim Preserve pstrTD(pstrTD.GetUpperBound(0) + 1)
            End If

            pstrTD(pstrTD.GetUpperBound(0)).Code = pstrTrueTopicCode
            pstrTD(pstrTD.GetUpperBound(0)).OldCode = pstrTrueTopicCode
            pstrTD(pstrTD.GetUpperBound(0)).TemplateID = pstrTemplateID
            'not needed 
            'pstrTD(pstrTD.GetUpperBound(0)).ByteLen = pintByteLen 
            pstrTD(pstrTD.GetUpperBound(0)).Options = pOptions
        End If

    End Sub
    Friend Sub LoadUserCSSListbox(ByRef pstrCSSArray() As String, ByRef pcboColourScheme As Object)
        Dim lintArrInc As Integer

        Dim source As DirectoryInfo = New DirectoryInfo(Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Layouts\")

        Directory.CreateDirectory(Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Layouts\")

        Dim files() As FileInfo = source.GetFiles
        Dim pfile As FileInfo
        For Each pfile In files
            If RightGet(pfile.ToString, 4).ToUpper = ".CSS" Then
                'cboDTColourScheme.Items.Add(pfile.ToString)
                ReDim Preserve pstrCSSArray(pstrCSSArray.GetUpperBound(0) + 1)
                pstrCSSArray(pstrCSSArray.GetUpperBound(0)) = pfile.ToString
            End If
        Next pfile

        For lintArrInc = 0 To pstrCSSArray.GetUpperBound(0)
            If pstrCSSArray(lintArrInc) <> "" Then
                pcboColourScheme.Items.Add(pstrCSSArray(lintArrInc))
            End If
        Next lintArrInc

    End Sub
    Friend Sub LoadUserTemplatesListbox(ByRef plstListBox As ListBox)
        Dim source As DirectoryInfo = New DirectoryInfo(Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().Location) & "\Layouts\")

        Dim files() As FileInfo = source.GetFiles
        Dim pfile As FileInfo

        For Each pfile In files
            If RightGet(pfile.ToString, 5).ToUpper = ".HTML" Or RightGet(pfile.ToString, 4).ToUpper = ".HTM" Then
                plstListBox.Items.Add(pfile.ToString)
            End If
        Next pfile
    End Sub
    Friend Sub WildcardCopy(ByVal SourceDir As String, ByVal DestDir As String, ByVal WildExt As String)
        Dim source As DirectoryInfo = New DirectoryInfo(SourceDir)
        Dim files() As FileInfo = source.GetFiles
        Dim pfile As FileInfo
        For Each pfile In files
            If RightGet(pfile.ToString, WildExt.Length + 1).ToUpper = "." & WildExt Then
                'cboDTColourScheme.Items.Add(pfile.ToString)
                File.Copy(SourceDir & pfile.ToString, DestDir & pfile.ToString, True)
            End If
        Next pfile
    End Sub
    Friend Sub AllUserTemplatesList(ByVal pstrAdd As Boolean, ByVal pstrTempFileName As String, ByVal pstrTemplateID As String, _
        Optional ByRef pstrFiles() As IPTemplates._main.resources = Nothing)
        Dim lintArrInc As Integer
        Dim lbooFound As Boolean = False
        Dim lintCount As Integer

        Dim AllUserTemplates As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AllUserTemplates, "")
        With AllUserTemplates
            lintCount = CLng(.GetValue("Count", "0"))
            If Not pstrFiles Is Nothing Then
                ReDim pstrFiles(lintCount)
            End If
            For lintArrInc = 0 To lintCount
                If .GetValue("TemplateFile-" & lintArrInc, "") = pstrTempFileName Then
                    lbooFound = True
                End If
                If Not pstrFiles Is Nothing Then
                    pstrFiles(lintArrInc).ID = .GetValue("TemplateID-" & lintArrInc, "")
                    pstrFiles(lintArrInc).file = .GetValue("TemplateFile-" & lintArrInc, "")
                    pstrFiles(lintArrInc).Name = .GetValue("TemplateName-" & lintArrInc, "")
                End If
            Next lintArrInc


            '---
            If .GetValue("TemplateID-0", "") = "" Then
                lintCount = -1
            Else
                lintCount = 0
            End If
            '---
        End With
        'If lintCount = 0 Then
        '    lintCount = -1
        'End If

        If pstrAdd = True And lbooFound = False Then
            SaveSetting("TemplateFile-" & lintCount + 1, pstrTempFileName, InitalXMLConfig.XmlConfigType.AllUserTemplates, "")
            SaveSetting("TemplateID-" & lintCount + 1, pstrTemplateID, InitalXMLConfig.XmlConfigType.AllUserTemplates, "")
            Dim lstrTemplateName As String = pstrTempFileName
            lstrTemplateName = Microsoft.VisualBasic.Replace(lstrTemplateName, ".html", "")
            lstrTemplateName = Microsoft.VisualBasic.Replace(lstrTemplateName, ".htm", "")
            SaveSetting("TemplateName-" & lintCount + 1, lstrTemplateName, InitalXMLConfig.XmlConfigType.AllUserTemplates, "")
            SaveSetting("Count", lintCount + 1, InitalXMLConfig.XmlConfigType.AllUserTemplates, "")
        End If

    End Sub
    Private Sub TvTemplatesToArray(ByVal ptv As TreeView, ByRef pstrFiles() As IPTemplates._main.resources)
        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1
        Dim lintArrCtr As Integer = pstrFiles.GetUpperBound(0) + 1

        ''ReDim pstrFiles(0)

        cNodes = ptv.GetNodeCount(False) 'don't need to check sub trees

        If cNodes = 0 Then
            'Bxsy(Me, False)
            Exit Sub
        End If

        ReDim ndxs(cNodes)
        GetNodes(ptv.Nodes(0), ndxs, curNode, True)

        'Dim lintArrinc As Integer
        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            'If n.Checked = True Then 
            ReDim Preserve pstrFiles(lintArrCtr)
            pstrFiles(lintArrCtr).file = n.Text
            lintArrCtr += 1
            'End If
        Next n

    End Sub
    Friend Sub GetArrayOfExportedTemplatedIDs(ByVal ptv As TreeView, ByRef pstrExportTemplates() As IPTemplates._main.resources)

        

        'Dim TR As New IPTemplates._main()
        'Dim lstrSystemTemplates() As IPTemplates._main.resources
        'TR.HTMLForms(lstrSystemTemplates)

        ''--- testing purposes ---
        'Dim ArrMsg As String
        'Dim x As Integer
        'For x = 0 To pstrExportTemplates.GetUpperBound(0)
        '    ArrMsg &= x & "#" & pstrExportTemplates(x).ID & "#" & pstrExportTemplates(x).file & "#" & pstrExportTemplates(x).Name & CR()
        'Next x
        'MessageBox.Show(ArrMsg, "GetArrayOfExportedTemplatedIDs1")
        ''--- testing purposes ---

        ''Get export filenames into array 'jut the select ones and add other details like filename
        TvTemplatesToArray(ptv, pstrExportTemplates)

        ''--- testing purposes ---
        ''Dim ArrMsg As String
        ''Dim x As Integer
        'For x = 0 To pstrExportTemplates.GetUpperBound(0)
        '    ArrMsg &= x & "#" & pstrExportTemplates(x).ID & "#" & pstrExportTemplates(x).file & "#" & pstrExportTemplates(x).Name & CR()
        'Next x
        'MessageBox.Show(ArrMsg, "GetArrayOfExportedTemplatedIDs2")
        ''--- testing purposes ---

        'oh this is only used for reference purposes, to populate the export treeview selections.
        Dim lstrAllUserTemplates(0) As IPTemplates._main.resources 'just using array, doesn't need populating from DLL
        AllUserTemplatesList(False, "", "", lstrAllUserTemplates)

        'the next bit is merging reference information base on file names
        'add templateid to export filesnames
        Dim lintArrinc, lintArrinc2 As Integer
        For lintArrinc = 0 To pstrExportTemplates.GetUpperBound(0)
            Dim lstrThisFile As String = pstrExportTemplates(lintArrinc).file
            
            Try
                lstrThisFile = lstrThisFile.ToUpper
            Catch
                '
            End Try
            
            For lintArrinc2 = 0 To lstrAllUserTemplates.GetUpperBound(0)
                With lstrAllUserTemplates(lintArrinc2)

                    
                    Dim lstrFile As String
                    Try
                        lstrFile = .file.ToUpper
                    Catch
                        '
                    End Try
                    
                    If lstrThisFile = lstrFile Then
                        If pstrExportTemplates(lintArrinc).ID = "" Then 'added to stop system template files with same name being overwritten by user templates
                            pstrExportTemplates(lintArrinc).ID = .ID
                            pstrExportTemplates(lintArrinc).Name = .Name
                            Exit For 
                        End If
                    End If
                End With
            Next lintArrinc2
        Next lintArrinc

        ''--- testing purposes ---
        ''Dim ArrMsg As String
        ''Dim x As Integer
        'For x = 0 To pstrExportTemplates.GetUpperBound(0)
        '    ArrMsg &= x & "#" & pstrExportTemplates(x).ID & "#" & pstrExportTemplates(x).file & "#" & pstrExportTemplates(x).Name & CR()
        'Next x
        'MessageBox.Show(ArrMsg, "GetArrayOfExportedTemplatedIDs3")
        ''--- testing purposes ---

    End Sub
    Friend Sub GetTitleNTempIDs(ByVal pstrTopics() As Export.Topics, ByRef pstrDN() As Export.DetailNames)

        AddDebugComment("Templates.GetTitleNTempIDs") 
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        'lstrSQL = "SELECT Topics.Title, Topics.TopicCode, TopicDetail.TemplateID FROM Topics, TopicDetail WHERE " & _
        ' "(((TopicDetail.TemplateID)<>'') AND ((TopicDetail.TopicCode)=Mid([Topics]." & _
        ' "[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics].[TopicCode])-InStr(1,[" & _
        ' "Topics].[TopicCode],'T')+1)));"
        
        lstrSQL = "SELECT Topics.Title, Topics.TopicCode, TopicDetail.TemplateID, TopicDetail.ByteLen, TopicDetail.Options FROM Topics, TopicDetail WHERE " & _
            "(((TopicDetail.TemplateID)<>'') AND ((TopicDetail.TopicCode)=Mid([Topics]." & _
            "[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics].[TopicCode])-InStr(1,[" & _
            "Topics].[TopicCode],'T')+1)));"
        'added TopicDetail.Options 
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        Dim lintRecCounter As Integer
        With lsnaLists
            Do While Not .EOF
                Dim lstrTitle As String = .Fields("Title").Value
                Dim lstrTopicsTopicCode As String = .Fields("TopicCode").Value
                Dim lstrTemplateID As String = .Fields("TemplateID").Value & ""
                Dim lintByteLen As String = .Fields("ByteLen").Value 
                Dim lstrOptions As String = .Fields("Options").Value & "" 
                
                Try
                    lstrTemplateID = lstrTemplateID.ToUpper
                Catch
                    '
                End Try
                
                Dim lintArrinc As Integer
                For lintArrinc = 0 To pstrTopics.GetUpperBound(0)
                    If pstrTopics(lintArrinc).Code = lstrTopicsTopicCode Then
                        ReDim Preserve pstrDN(lintRecCounter)
                        pstrDN(lintRecCounter).Title = lstrTitle
                        pstrDN(lintRecCounter).TemplateID = lstrTemplateID
                        pstrDN(lintRecCounter).ByteLen = lintByteLen 
                        pstrDN(lintRecCounter).Options = lstrOptions 
                        lintRecCounter += 1
                        Exit For
                        'Exit Sub
                    End If
                Next lintArrinc
                .MoveNext()

            Loop
        End With

        lsnaLists.Close()
        lcnn1.Close()

    End Sub
    Friend Function GetDefaultTemplateID() As String

        Dim InitialConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings)
        With InitialConfig
            If CBool(.GetValue("Use Template By Default", "FALSE")) = True Then
                GetDefaultTemplateID = .GetValue("Default Template ID", "")
            Else 
                GetDefaultTemplateID = "" 
            End If
        End With
        '"Default Template Name"
        '"Default Template File Name"
        
        Try
            GetDefaultTemplateID = GetDefaultTemplateID.ToUpper
        Catch
        End Try
        
    End Function
    Friend Function GenerateDataFile(ByVal pstrOutPutFile As String, ByVal psrTemplateID As String, ByVal pstrFields() As String, _
        ByVal pPanel As Object, ByVal pOutputType As TemplateOutput, Optional ByVal pTemplateName As String = "") As Boolean 'added pOutputType 

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lintArrInc As Integer
        Dim lstrThisOutputLine As String
        Dim lstrFieldHeader As String
        Dim lbooAddHeader As Boolean = True

        GenerateDataFile = True 
        
        Try
            If File.Exists(pstrOutPutFile) = True Then
                File.Delete(pstrOutPutFile)
            End If
        Catch
            GenerateDataFile = False
            Exit Function
        End Try
        

        Dim OpenFile As FileStream = New FileStream(pstrOutPutFile, FileMode.CreateNew, FileAccess.Write, FileShare.Write)
        Dim StreamWriter As StreamWriter = New StreamWriter(OpenFile)

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        Select Case pOutputType 
            Case TemplateDataTypes.TemplateOutput.TabbedDelim 
                Dim lstrSQL As String = "SELECT Detail from TopicDetail WHERE TemplateID = '" & psrTemplateID & "';"

                gstrLastSQL = lstrSQL 
                lsnaLists.Open(lstrSQL, lcnn1, _
                 ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            Case TemplateDataTypes.TemplateOutput.XML 
                Dim lstrSQL As String = "SELECT Detail, TopicCode from TopicDetail WHERE TemplateID = '" & psrTemplateID & "';"

                gstrLastSQL = lstrSQL 
                lsnaLists.Open(lstrSQL, lcnn1, _
                 ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly) 
        End Select 

        Dim lstrSectionStr As String = "" 
        'lstrSectionStr = "<?xml version=""1.0"" encoding=""Windows-1252"" ?> " & CR() & "<Ideaspad_Data>" & CR() 
        lstrSectionStr = "<?xml ?> " & CR() & "<Ideaspad_Data>" & CR() 

        With lsnaLists
            '.RecordCount
            If Not pPanel Is Nothing Then 
                pPanel.Maximum = .RecordCount
                pPanel.Minimum = 0
                pPanel.Value = 0
            End If

            Do While Not .EOF
                Select Case pOutputType 
                    Case TemplateDataTypes.TemplateOutput.TabbedDelim 

                        For lintArrInc = 0 To pstrFields.GetUpperBound(0)
                            If lbooAddHeader = True Then
                                lstrFieldHeader += pstrFields(lintArrInc) & Tab()
                            End If
                            Dim lstrThisFormField As String = Reverse(pstrFields(lintArrInc))
                            Dim lstrThisValue As String = GetData(.Fields("Detail").Value & "", "<" & lstrThisFormField & ">", "</" & lstrThisFormField & ">")
                            lstrThisOutputLine += lstrThisValue & Tab()

                        Next lintArrInc
                        If lstrFieldHeader <> "" And lbooAddHeader = True Then
                            lstrThisOutputLine = lstrFieldHeader & CR() & lstrThisOutputLine 
                            lstrFieldHeader = ""
                            lbooAddHeader = False
                        End If
                        'writeline
                    Case TemplateDataTypes.TemplateOutput.XML 
                        

                        lstrSectionStr &= Tab() & Tab() & "<" & pTemplateName.Replace(" ", "_") & "-" & psrTemplateID & ">" & CR() & Tab() & Tab() & Tab() & "<Key>" & .Fields("TopicCode").Value & "</Key>" & CR()

                        For lintArrInc = 0 To pstrFields.GetUpperBound(0)
                            Dim lstrThisFormField As String = Reverse(pstrFields(lintArrInc))
                            Dim lstrThisValue As String = GetData(.Fields("Detail").Value & "", "<" & lstrThisFormField & ">", "</" & lstrThisFormField & ">")
                            lstrThisOutputLine &= lstrSectionStr & Tab() & Tab() & Tab() & "<" & pstrFields(lintArrInc) & ">" & lstrThisValue & "</" & pstrFields(lintArrInc) & ">" & CR()
                            lstrSectionStr = ""
                        Next lintArrInc
                        lstrThisOutputLine &= Tab() & Tab() & "</" & pTemplateName.Replace(" ", "_") & "-" & psrTemplateID & ">"
                        
                End Select

                StreamWriter.WriteLine(lstrThisOutputLine) 
                lstrThisOutputLine = ""
                If Not pPanel Is Nothing Then 
                    pPanel.Increment(1)
                End If
                .MoveNext()
            Loop
        End With

        lstrThisOutputLine &= CR() & "</Ideaspad_Data>" 
        StreamWriter.WriteLine(lstrThisOutputLine) 

        If Not pPanel Is Nothing Then 
            pPanel.Value = 0
        End If

        StreamWriter.Close()
        lsnaLists.Close()
        lcnn1.Close()
    End Function
    Friend Sub ProduceAllTemplateFieldArray(ByVal pme As Form, ByRef pAllFields() As TemplateFields)
        'Added 
        Dim lstrUsedTemplatesIDs() As String
        Dim lstrTemplateFileName() As String
        Dim lstrTemplateResources() As IPTemplates._main.resources

        Dim lstTemplates As New ListBox()

        pme.SuspendLayout()
        Dim TR As New IPTemplates._main()
        TR.HTMLForms(lstrTemplateResources)
        FillTemplatesUsedList(lstrUsedTemplatesIDs, lstrTemplateFileName, lstrTemplateResources, lstTemplates)


        If lstrTemplateFileName Is Nothing Then
            Exit Sub
        End If
        If lstrTemplateFileName.GetUpperBound(0) = 0 And lstrTemplateFileName(0) = "" Then
            Exit Sub
        End If

        pme.ResumeLayout()

        Dim AxWebBrowser As WinOnly.WebOCHostCtrl

        SpawnBrowserObject(AxWebBrowser, pme)

        Dim lintFieldCounter As Integer = 0

        Dim lintArrInc As Integer
        For lintArrInc = 0 To lstrTemplateFileName.GetUpperBound(0)

            'Dim lstrFields() As String
            Dim lbooDLL As Boolean = False
            Dim lstrFileName As String = lstrTemplateFileName(lintArrInc)
            If lstrFileName <> "" Then
                If InStrGet(lstrFileName, "SYSTEM:") > 0 Then
                    lstrFileName = Microsoft.VisualBasic.Replace(lstrFileName, "SYSTEM:", "")
                    lbooDLL = True
                End If
                ShowForm(lstrFileName, AxWebBrowser, lbooDLL)

                WaitForBrowser(AxWebBrowser)

                Dim HtmlDoc As IHTMLDocument2 = CType(AxWebBrowser.HtmlDocument, IHTMLDocument2)
                Dim FormCol As IHTMLElementCollection = HtmlDoc.forms

                Dim iForms As Integer = FormCol.length
                Dim i As Integer = 0
                Dim x As Integer = 0
                '                Dim lintFieldCounter As Integer = 0
                Dim ThisTemplateID As String 

                '################# This next line may not work, just a guess!!!
                ThisTemplateID = lstrUsedTemplatesIDs(lintArrInc) 

                For i = 0 To iForms - 1
                    Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(i, Object), CType(i, Object)), IHTMLFormElement)
                    For x = 0 To oForm.length - 1
                        'Console.WriteLine(oForm.elements(x).name)

                        'If CStr(oForm.elements(x).name).ToUpper = "TemplateID".ToUpper Then
                        '    ThisTemplateID = oForm.elements(x).value
                        'End If

                        If CStr(oForm.elements(x).name).ToUpper <> "TemplateID".ToUpper Then
                            ReDim Preserve pAllFields(lintFieldCounter)
                            pAllFields(lintFieldCounter).NormalField = oForm.elements(x).name 
                            pAllFields(lintFieldCounter).RevField = Reverse(pAllFields(lintFieldCounter).NormalField)  
                            pAllFields(lintFieldCounter).TemplateID = ThisTemplateID 
                            lintFieldCounter += 1
                        End If
                    Next
                Next i

            End If
        Next lintArrInc
    End Sub
    Function GenerateTemplateTopicXML(ByVal pstrInputTopicStr As String, ByVal pstrTemplateID As String, _
        ByVal pAllFields() As TemplateFields, ByVal pstrTopicCode As String) As String
        'Added 
        'you don't need to set the level!!

        Dim RetStr As String = ""
        Dim lstrThisOutputLine As String = ""

        Dim lstrSectionStr As String = ""

        ''lstrSectionStr &= "<" & pstrTemplateID & ">" & CR() & "<Key>" & pstrTopicCode & "</Key>" & CR()

        Dim lintArrInc As Integer
        For lintArrInc = 0 To pAllFields.GetUpperBound(0)
            If pAllFields(lintArrInc).TemplateID = pstrTemplateID Then


                Dim lstrThisFormField As String = pAllFields(lintArrInc).RevField
                Dim lstrThisValue As String = GetData(pstrInputTopicStr & "", "<" & lstrThisFormField & ">", "</" & lstrThisFormField & ">")
                'lstrThisOutputLine &= lstrSectionStr & "<" & pAllFields(lintArrInc).NormalField & ">" & lstrThisValue & "</" & pAllFields(lintArrInc).NormalField & ">" & CR()
                
                lstrThisOutputLine &= lstrSectionStr & "<" & pAllFields(lintArrInc).NormalField & ">" & Web.HttpUtility.HtmlEncode(lstrThisValue) & "</" & pAllFields(lintArrInc).NormalField & ">" & CR()

                lstrSectionStr = ""


                RetStr &= lstrThisOutputLine
                lstrThisOutputLine = ""
            End If
        Next lintArrInc

        ''lstrThisOutputLine &= "</" & pstrTemplateID & ">" & CR()

        RetStr &= lstrThisOutputLine

        Return RetStr

    End Function
End Module
Friend Module TemplateDataTypes
    Friend Enum TemplateOutput
        TabbedDelim
        XML
    End Enum
    Friend Structure TemplateFields
        Dim TemplateID As String
        Dim RevField As String
        Dim NormalField As String
    End Structure
End Module
