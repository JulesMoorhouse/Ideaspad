Imports System
Imports System.IO
Imports System.Drawing.Printing
Imports mshtml
Friend Module main
    <DoNotObfuscateAttribute()> Friend gstrDecryptProbTrace As String = "" 
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    'Friend gstrManifestSite(1) As ManifestInfo 'moved 
    '---- DB choice vars ----
    'Public Const gconstrTitlPrefix = "IdeasPad"
    'Friend gstrConnectionString As String'moved 
    '''Friend gstrIniAppName As String 'commeted ount 
    ''Friend gstrLocalConnectionString As String
    '    Friend gstrDataFileName As String'moved 
    'Friend gconstrConnectionProvider As String 'moved 

    'Friend gconstrConnectionJustProvider As String 'moved 
    'Friend DBChoice As New frmDBChoice() 'moved 
    '---- DB choice vars ----


    'Friend gdatSystemStart As Date 'moved 

    Friend Function GetTopicDetailRTF(ByVal pstrTopicCode As String, ByVal pobjRichTextBox As RichTextBox, _
        ByRef BrowserControl As WinOnly.WebOCHostCtrl, ByRef pMe As frmPad, ByRef TemplateFileName As String, _
        ByRef SysTemplate As Boolean, ByRef FormData As String, Optional ByRef RtfLen As Integer = -1) As String

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim strChunk As String = ""
        Dim Offset As Long
        'Dim Totalsize As Long
        Dim Totalsize As Integer 
        Dim ChunkSize As Long
        Dim lstrTemplateID As String = " "
        Dim lintByteLength As Integer 
        Dim lstrOptions As String = "" 

        'If elEvts = True Then : Console.WriteLine("GetTopicDetailRTF " & pstrTopicCode) : End If 
        AddDebugComment("main.GetTopicDetailRTF " & pstrTopicCode) 

        Dim TR As New IPTemplates._main()
        Dim lstrTemplateResources() As IPTemplates._main.resources
        TR.HTMLForms(lstrTemplateResources)

        lcnn1 = New ADODB.Connection()
        'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive 'commented out with locking changes
        lcnn1.Open(gstrConnectionString)

        lsnaLists.CursorType = ADODB.CursorTypeEnum.adOpenStatic

        'lsnaLists.Open("SELECT Detail FROM TopicDetail WHERE TopicCode='" & pstrTopicCode & "';", lcnn1)
        'Dim lstrSQL As String = "SELECT Detail, TemplateID FROM TopicDetail WHERE TopicCode='" & pstrTopicCode & "';"
        
        'Dim lstrSQL As String = "SELECT Detail, TemplateID, LockingFlag FROM TopicDetail WHERE TopicCode='" & pstrTopicCode & "';"
        
        'Dim lstrSQL As String = "SELECT Detail, TemplateID, LockingFlag, ByteLen FROM TopicDetail WHERE TopicCode='" & pstrTopicCode & "';"
        
        Dim lstrSQL As String = "SELECT Detail, TemplateID, LockingFlag, ByteLen, Options FROM TopicDetail WHERE TopicCode='" & pstrTopicCode & "';"
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1) 

        If Not lsnaLists.EOF Then
            ChunkSize = 1000
            Totalsize = lsnaLists("Detail").ActualSize

            
            If Totalsize < 2000000 Then
                Do While Offset < Totalsize
                    strChunk = strChunk + lsnaLists("Detail").GetChunk(ChunkSize)
                    Offset = Offset + ChunkSize
                Loop

                'Dim builder As New System.Text.StringBuilder(Totalsize)
                'For Offset = 0 To Totalsize Step ChunkSize
                '    builder.Append(lsnaLists("Detail").GetChunk(ChunkSize))
                'Next Offset
                'strChunk = builder.ToString
            Else
                strChunk = lsnaLists("Detail").Value
            End If
            

            If Microsoft.VisualBasic.IsDBNull(lsnaLists.Fields("TemplateID").Value) Then 
                lstrTemplateID = "" 
            Else
                lstrTemplateID = lsnaLists("TemplateID").Value 
                
                Try
                    lstrTemplateID = lstrTemplateID.ToUpper
                Catch
                    '
                End Try
                
                'lintByteLength = lsnaLists("ByteLen").Value 
            End If

            lintByteLength = lsnaLists("ByteLen").Value 'moved freom 2 lines above
            lstrOptions = lsnaLists("Options").Value 

            GetTopicDetailRTF = lsnaLists("LockingFlag").Value 
            lsnaLists.Close()
        End If 
            lcnn1.Close() 

            'If elEvts = True Then : Console.WriteLine("   GTF Lock=" & GetTopicDetailRTF) : End If 
            Dim lstrDebugLockFlag As String 
            If GetTopicDetailRTF = "" Then 
                lstrDebugLockFlag = "Unknown" 
            Else
                'lstrDebugLockFlag = GetTopicDetailRTF.Replace(System.Environment.UserName, "Privacy") 
                Dim lstrCurUser As String = GetUserName() 
                Try : lstrCurUser = LeftGet(lstrCurUser, 17) : Catch : End Try 
                'lstrDebugLockFlag = GetTopicDetailRTF.Replace(GetUserName, "Privacy") 
                lstrDebugLockFlag = GetTopicDetailRTF.Replace(lstrCurUser, "Privacy") 
            End If

            AddDebugComment("main.GetTopicDetailRTF - Lock=" & lstrDebugLockFlag) 

            '''pMe.SuspendLayout() 

            If lstrTemplateID.Trim <> "" Then  
                

                Dim lstrTemplateFileName As String
                Dim lintArrinc As Integer
                Dim lbooSysTemplate As Boolean = False
                For lintArrinc = 0 To lstrTemplateResources.GetUpperBound(0)
                    If lstrTemplateID = lstrTemplateResources(lintArrinc).ID Then
                        lstrTemplateFileName = lstrTemplateResources(lintArrinc).file
                        lbooSysTemplate = True
                        Exit For
                    End If
                Next lintArrinc

                If lbooSysTemplate = False Then
                    'Dim UserTemplateConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.UserTemplates, lstrTemplateID)
                    
                    If lstrTemplateID <> "" Then
                        lstrTemplateID = lstrTemplateID.ToUpper
                    End If
                    Dim UserTemplateConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.UserTemplates, lstrTemplateID)
                    lstrTemplateFileName = UserTemplateConfig.GetValue("FileName", "")
                End If

                If lstrTemplateFileName = "" Then
                    'mxessagebox.show("Template not found, please check you have the required template file!", NameMe(""))
                    If gbooAlwaysOnTop = True Then pMe.Activate() 
                    
                    MessageBox.Show(LangText.GetString("Main_TemplateNotFound"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Warning) 'other props
                    AddDebugComment(gstrProbComtStack) 
                    gstrProbComtStack = "" 
                    Exit Function
                End If

                'Console.WriteLine(lstrTemplateFileName & " " & lstrTemplateID)

                If strChunk <> " " Then
                    FormData = strChunk
                End If

                TemplateFileName = lstrTemplateFileName
                SysTemplate = lbooSysTemplate
                'ShowForm(lstrTemplateFileName, BrowserControl, lbooSysTemplate)

                'If BrowserControl.ReadyState = SHDocVw.tagREADYSTATE.READYSTATE_LOADING Then
                '    Do Until BrowserControl.ReadyState <> SHDocVw.tagREADYSTATE.READYSTATE_LOADING '= SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE
                '        System.Windows.Forms.Application.DoEvents()
                '        'AxWebBrowser1.Refresh()
                '    Loop
                'End If

                'If strChunk <> " " Then
                '    GetTopicDetailRTF = strChunk
                '    'PopulateHTMLFields(strChunk, BrowserControl)
                'End If

                'pobjRichTextBox.Visible = False
                'BrowserControl.BringToFront()
                'BrowserControl.Visible = True
                'pMe.StatusBar1.SendToBack()
                If Not pMe Is Nothing Then 
                    pMe.ShowBrowser()
                End If
                
            Else
                'BrowserControl.Visible = False 
                'pobjRichTextBox.BringToFront()
                'pobjRichTextBox.Visible = True 
                'pMe.StatusBar1.SendToBack()
                If Not pMe Is Nothing Then 
                    pMe.ShowRTF()
                End If

                
                Select Case lstrOptions
                    Case "Default", ""
                        pobjRichTextBox.BackColor = SystemColors.Window
                    Case Else
                        If InStrGet(lstrOptions & "", ",") > 0 Or lstrOptions = "Default" Then 
                            Try 
                                pobjRichTextBox.BackColor = AppBasic.StringToColor(lstrOptions)
                            Catch 
                                AddDebugComment("main.GetTopicDetailRTF - CX1")

                                pobjRichTextBox.BackColor = SystemColors.Window 
                            End Try 
                        Else 
                            Try : pobjRichTextBox.BackColor = Color.FromArgb(lstrOptions) : Catch : End Try 
                        End If 

                End Select
                

                If strChunk <> " " Then
                    Try 
                        

                        If lintByteLength <> -1 And strChunk <> "" Then 'added And strChunk <> "" 
                            AddDebugComment("Inflate") 

                            Dim InfDef As New InflateDeflate()
                            strChunk = InfDef.Inflate(strChunk, lintByteLength)

                        End If
                        

                        pobjRichTextBox.Rtf = strChunk
                        RtfLen = strChunk.Length 
                    'Catch  
                    '     pobjRichTextBox.Rtf = "" 
                Catch ex2 As System.ArgumentException 
                    pobjRichTextBox.Rtf = "" 
                Catch ex1 As System.OutOfMemoryException 
                    MessageBox.Show("Out of memory!" & Environment.NewLine & _
                        "The contents of this topic is too big and can not be shown.") 
                    pobjRichTextBox.Rtf = "" 
                Catch ex3 As Exception 
                    'MessageBox.Show(ex3.ToString) ' used for testing new errors.
                    pobjRichTextBox.Rtf = "" 
                End Try
            Else
                    pobjRichTextBox.Rtf = Nothing
                End If
            End If

            '''pMe.ResumeLayout() 
            AddDebugComment("main.GetTopicDetailRTF - End") 

    End Function
    Friend Function GetTopicLockFlag(ByVal pstrTopicCode As String) As String
        

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        lsnaLists.CursorType = ADODB.CursorTypeEnum.adOpenStatic

        Dim lstrSQL As String = "SELECT LockingFlag FROM TopicDetail WHERE TopicCode='" & pstrTopicCode & "';"
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1)

        If Not lsnaLists.EOF Then
            GetTopicLockFlag = lsnaLists("LockingFlag").Value
            lsnaLists.Close()
        End If
        lcnn1.Close()
        'LOCKING
    End Function
    Function GetLockStr(ByVal LockFlag As String) As String 

        Dim lintHashPos As Integer = InStrGet(LockFlag, "#")
        If lintHashPos > 0 Then
            Return RightGet(LockFlag, LockFlag.Length - lintHashPos)
        End If
        'LOCKING
    End Function
    Function GetLockTopicCode(ByVal LockFlag As String) As String 

        Dim lintHashPos As Integer = InStrGet(LockFlag, "#") - 1
        If lintHashPos > 0 Then
            Return LeftGet(LockFlag, lintHashPos)
        End If

    End Function
    Function AskLockingQuestion(ByVal pstrLockFlag As String, ByVal pstrRecLockFlag As String, ByVal ThisTopicCode As String, ByVal pMe As Form) As DialogResult
        'LOCKING
        If GetLockTopicCode(pstrLockFlag) = GetLockTopicCode(pstrRecLockFlag) And GetLockTopicCode(pstrLockFlag) <> "" And _
            GetLockTopicCode(pstrRecLockFlag) <> "" Then 

            If pstrRecLockFlag <> pstrLockFlag Then
                'Console.WriteLine(Environment.NewLine & GetLockTopicCode(pstrLockFlag) & _
                '    Environment.NewLine & pstrRecLockFlag & Environment.NewLine & pstrLockFlag & Environment.NewLine)

                pstrRecLockFlag = GetLockStr(pstrRecLockFlag) 

                'Return MxessageBox.Show("Someone else has modified this topic while you have been using it!" & Environment.NewLine & _
                '"Do you wish to overwrite it or cancel any changes you have made?" & Environment.NewLine & Environment.NewLine & _
                '"The persons user name and modfied date are show below:" & Environment.NewLine & Tab() & pstrRecLockFlag, NameMe(""), MessageBoxButtons.OKCancel)
                If gbooAlwaysOnTop = True Then pMe.Activate() 
                
                Return MessageBox.Show(LangText.GetString("Main_SomeoneModified").Replace("[CR]", _
                Environment.NewLine).Replace("[CR2]", Environment.NewLine & _
                Environment.NewLine) & Environment.NewLine & Tab() & pstrRecLockFlag, NameMe(""), MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) 'other props

            Else
                Return DialogResult.None
            End If
        Else
            Return DialogResult.None
        End If

    End Function

    Friend Function UpdateTopicDetailRTF(ByVal pstrTopicCode As String, ByVal pobjRichTextBox As RichTextBox, _
        ByVal BrowserControl As WinOnly.WebOCHostCtrl, ByRef LockingFlag As String, ByVal OldFormData As String, ByVal pMe As Form) As Boolean

        UpdateTopicDetailRTF = True 

        'Console.WriteLine("UpdateTopicDetailRTF")
        '--- 
        Dim lstrFormUpdatedData As String
        If Not pobjRichTextBox Is Nothing Then
            If pobjRichTextBox.Visible = False Then   
                lstrFormUpdatedData = GenerateFormData(BrowserControl)
                If lstrFormUpdatedData = OldFormData Then
                    Exit Function
                End If
                'If elEvts = True Then : Console.WriteLine("UpdateTopicDetailRTF RTF " & pstrTopicCode) : End If 
                AddDebugComment("main.UpdateTopicDetailRTF RTF " & pstrTopicCode) 
            End If
        Else
            lstrFormUpdatedData = GenerateFormData(BrowserControl)
            If lstrFormUpdatedData = OldFormData Then
                Exit Function
            End If
            'If elEvts = True Then : Console.WriteLine("UpdateTopicDetailRTF WEB" & pstrTopicCode) : End If 
            AddDebugComment("main.UpdateTopicDetailRTF WEB" & pstrTopicCode) 
        End If
        '--- 

        'Console.WriteLine("UpdateTopicDetailRTF " & pstrTopicCode)  

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        If LockingFlag = "" Then 
            'record has just been added!
        End If

        Dim lbooRecordDeleted As Boolean = False 
        Dim lstrTemplateID As String 
        Dim lbooChangedFromTemplate As Boolean = False 

        With lsnaLists
            .CursorType = ADODB.CursorTypeEnum.adOpenKeyset
            .LockType = ADODB.LockTypeEnum.adLockOptimistic
            '.Open("SELECT Detail, TemplateID FROM TopicDetail WHERE TopicCode='" & pstrTopicCode & "';", lcnn1)
            
            '.Open("SELECT Detail, TemplateID, LockingFlag FROM TopicDetail WHERE TopicCode='" & pstrTopicCode & "';", lcnn1)
            
            '.Open("SELECT Detail, TemplateID, LockingFlag, ByteLen FROM TopicDetail WHERE TopicCode='" & pstrTopicCode & "';", lcnn1)

            Dim lstrSQL As String = "SELECT Detail, TemplateID, LockingFlag, ByteLen, Options FROM TopicDetail WHERE TopicCode='" & pstrTopicCode & "';"

            gstrLastSQL = lstrSQL 

            
            .Open(lstrSQL, lcnn1)

            If Not .EOF Then
                
                Dim lstrRecLockFlag As String = ""
                If Not Microsoft.VisualBasic.IsDBNull(lsnaLists.Fields("LockingFlag").Value) Then
                    lstrRecLockFlag = lsnaLists("LockingFlag").Value
                End If
                'LOCKING
                If AskLockingQuestion(LockingFlag, lstrRecLockFlag, pstrTopicCode, pMe) = DialogResult.Cancel Then
                    lsnaLists.Close()
                    lcnn1.Close()
                    LockingFlag = "" 
                    Exit Function
                End If
                lstrTemplateID = lsnaLists("TemplateID").Value & "" 
                
                Try
                    lstrTemplateID = lstrTemplateID.ToUpper
                Catch
                    '
                End Try
                
                
                If Not pobjRichTextBox Is Nothing Then 
                    If pobjRichTextBox.Visible = True Then

                        
                        'lsnaLists("Detail").Value = pobjRichTextBox.Rtf
                        Dim ByteLength As Integer
                        AddDebugComment("Deflate")
                        Dim InfDef As New InflateDeflate()

                        Dim strDeflated As String = InfDef.Deflate(pobjRichTextBox.Rtf, ByteLength)


                        lsnaLists("Detail").Value = strDeflated
                        lsnaLists("ByteLen").Value = ByteLength
                        

                        'Dim BackColour As String = ColorToString(pobjRichTextBox.BackColor) 
                        Dim BackColour As String = pobjRichTextBox.BackColor.ToArgb 
                        lsnaLists("Options").Value = BackColour
                    Else


                        If lstrTemplateID <> "" Then 
                            lsnaLists("Detail").Value = lstrFormUpdatedData 'GenerateFormData(BrowserControl)
                            lsnaLists("ByteLen").Value = -1 
                        Else

                            'The startup screen could be showing to!!!
                            If lstrFormUpdatedData <> " " Then 
                                lbooChangedFromTemplate = True 
                            End If 
                        End If
                    End If
                Else
                    If lstrTemplateID <> "" Then 
                        lsnaLists("Detail").Value = GenerateFormData(BrowserControl)
                        lsnaLists("ByteLen").Value = -1 
                    Else
                        lbooChangedFromTemplate = True 
                    End If
                End If
                'LOCKING
                LockingFlag = CreateLockingFlag(pstrTopicCode) 
                lsnaLists("LockingFlag").Value = LockingFlag  
                .Update()

            Else
                lbooRecordDeleted = True 
            End If

            lsnaLists.Close()
            lcnn1.Close()
        End With

        If lbooRecordDeleted = True Then 
            If gbooAlwaysOnTop = True Then pMe.Activate() 
            'mxessagebox.show("The topic has been deleted since you started using it!  Any changes you made will be lost!", NameMe("")) 
            
            MessageBox.Show(LangText.GetString("Main_DeletedLoose"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 
        End If

        If lbooChangedFromTemplate = True Then
            If gbooAlwaysOnTop = True Then pMe.Activate() 
            'mxessagebox.show("The topic has been changed from a template to RTF!  Any changes you made will be lost!", NameMe("")) 
            
            MessageBox.Show(LangText.GetString("Main_ChangedLoose"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 
        End If

        If LockingFlag Is Nothing Then 
            LockingFlag = "Unknown" 
        End If
        'If elEvts = True Then : Console.WriteLine("   UTD Lock=" & LockingFlag) : End If 
        'Dim lstrDebugLockFlag As String = LockingFlag.Replace(System.Environment.UserName, "Privacy") 
        Dim lstrCurUser As String = GetUserName() 
        Try : lstrCurUser = LeftGet(lstrCurUser, 17) : Catch : End Try 

        'Dim lstrDebugLockFlag As String = LockingFlag.Replace(GetUserName, "Privacy") 
        Dim lstrDebugLockFlag As String = LockingFlag.Replace(lstrCurUser, "Privacy") 

        
        If lbooRecordDeleted = True Then
            UpdateTopicDetailRTF = False
        End If
        

        AddDebugComment("main.UTD Lock=" & lstrDebugLockFlag) 

    End Function
    Friend Function GenerateFormData(ByVal BrowserControl As WinOnly.WebOCHostCtrl) As String
        Dim HtmlDoc As IHTMLDocument2 = CType(BrowserControl.HtmlDocument, IHTMLDocument2)
        Dim FormCol As IHTMLElementCollection = HtmlDoc.forms

        'Console.WriteLine("GenerateFormData")
        GenerateFormData = " "

        Dim iForms As Integer = FormCol.length
        Dim i As Integer
        Dim x As Integer
        For i = 0 To iForms - 1
            Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(i, Object), CType(i, Object)), IHTMLFormElement)
            'Console.WriteLine("#" & oForm.name)
            For x = 0 To oForm.length - 1
                Dim lstrThisFormField As String = Reverse(oForm.elements(x).name)
                Dim lstrThisValue As String
                'see this site for some general help
                'http://www.activevb.de/tutorials/tut_browsertags/browsertags.html
                'WebBrowser1.Document.Forms(0).elements(0).Checked = True
                Select Case oForm.elements(x).type
                    Case "text", "textarea"
                        lstrThisValue = oForm.elements(x).value
                    Case "select-one"
                        Dim y As Integer
                        For y = 0 To oForm.elements(x).length - 1
                            If oForm.elements(x).options(y).selected = True Then
                                lstrThisValue = oForm.elements(x).options(y).text
                                Exit For
                            End If
                        Next y
                End Select

                lstrThisValue = JetSQLFixup(lstrThisValue)
                GenerateFormData += "<" & lstrThisFormField & ">" & lstrThisValue & "</" & lstrThisFormField & ">"
            Next
        Next i
    End Function
    Friend Enum PopulateTreeDisables
        NoDisables = 0
        DisableTemplateTopics = 1
    End Enum
    Friend Sub PopulateTree(ByRef oTv As TreeView, ByRef pstrIndexArray() As TreeTopics, ByVal pMe As Form, _
        Optional ByVal booCheckAll As Boolean = False, Optional ByVal pstrSortOrder As String = "ALPHA", _
        Optional ByVal pbooDisableCode As PopulateTreeDisables = PopulateTreeDisables.NoDisables)

        AddDebugComment("main.PopulateTree") 

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String
        '// PURPOSE: This function will populate a TreeView control from the 
        '// database.

        ReDim pstrIndexArray(0)
        lcnn1 = New ADODB.Connection()

        lcnn1.Open(gstrConnectionString)

        If pstrSortOrder = "ALPHA" Then
            If pbooDisableCode = PopulateTreeDisables.NoDisables Then 
                lstrSQL = "SELECT CLng(Left([ParentTopicCode] & '0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), " & _
                "* FROM Topics WHERE (((Topics.InUse)=True)) ORDER BY Topics.Level, CLng(Left([ParentTopicCode] & " & _
                "'0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), Title;"
            ElseIf pbooDisableCode = PopulateTreeDisables.DisableTemplateTopics Then                 
                lstrSQL = "SELECT CLng(Left([ParentTopicCode] & '0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), " & _
                "Topics.Level, Topics.Title, Topics.InUse, Topics.ParentTopicCode, TopicDetail.TemplateID, Topics.SeqNum, " & _
                "Topics.ImgIdx, Topics.TopicCode FROM Topics, TopicDetail WHERE (((Topics.InUse)=True) AND " & _
                "((Right([Topics].[TopicCode],(Len([Topics].[TopicCode])-InStr([Topics].[TopicCode],'T')+1)))=[TopicDetail].[TopicCode])) ORDER BY Topics.Level, " & _
                "CLng(Left([ParentTopicCode] & '0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), Topics.Title;"
            End If
        Else
            If pbooDisableCode = PopulateTreeDisables.NoDisables Then 
                lstrSQL = "SELECT CLng(Left([ParentTopicCode] & '0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), " & _
                "* FROM Topics WHERE (((Topics.InUse)=True)) ORDER BY Topics.Level, CLng(Left([ParentTopicCode] & " & _
                "'0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), SeqNum, Title;"
            ElseIf pbooDisableCode = PopulateTreeDisables.DisableTemplateTopics Then 
                
                lstrSQL = "SELECT CLng(Left([ParentTopicCode] & '0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), " & _
                "Topics.Level, Topics.Title, Topics.InUse, Topics.ParentTopicCode, TopicDetail.TemplateID, Topics.SeqNum, " & _
                "Topics.ImgIdx, Topics.TopicCode FROM Topics, TopicDetail WHERE (((Topics.InUse)=True) AND " & _
                "((Right([Topics].[TopicCode],(Len([Topics].[TopicCode])-InStr([Topics].[TopicCode],'T')+1)))=[TopicDetail].[TopicCode])) ORDER BY Topics.Level, " & _
                "CLng(Left([ParentTopicCode] & '0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), Topics.SeqNum, Topics.Title;"

            End If
        End If
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        Dim collNodeKeys As New Microsoft.VisualBasic.Collection()
        Dim tnNew As TreeNode
        Dim tnParent As TreeNode
        Dim lstrTopicCode As String
        Dim llngThisTopicNum As Long
        Dim lintTPos As Integer

        Dim lintRecCounter As Integer

        glngLastTopicNum = 0 'Added to cater for use of this function multiple times 

        oTv.BeginUpdate() 
        oTv.Enabled = False 
        oTv.Nodes.Clear() 

        With lsnaLists
            Do Until .EOF
                ReDim Preserve pstrIndexArray(lintRecCounter)
                lstrTopicCode = .Fields("TopicCode").Value
                pstrIndexArray(lintRecCounter).strTopicCode = lstrTopicCode
                lintTPos = InStrGet(1, lstrTopicCode, "T")
                llngThisTopicNum = CLng(RightGet(lstrTopicCode, (lstrTopicCode.Length - lintTPos)))

                If llngThisTopicNum > glngLastTopicNum Then
                    glngLastTopicNum = llngThisTopicNum
                End If

                If .Fields("Level").Value = 1 Then
                    tnNew = oTv.Nodes.Add(CType(.Fields("Title").Value, String))
                    'tnNew = oTv.Nodes.Add(CType(.Fields("Title").Value, String) & " " & CType(lsnaLists.Fields("TopicCode").Value, String))
                    With tnNew
                        .Tag() = CType(lsnaLists.Fields("TopicCode").Value, String)
                        If booCheckAll = True Then
                            .Checked = True
                        End If
                        
                        Dim lintImgIdx As Integer
                        If Microsoft.VisualBasic.IsDBNull(lsnaLists.Fields("ImgIdx").Value) Then
                            lintImgIdx = 0
                        Else
                            lintImgIdx = CType(lsnaLists.Fields("ImgIdx").Value & "", Integer)
                        End If
                        
                        'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
                        'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
                        lintImgIdx = IPIconsPack.GetImgIdx(lintImgIdx)
                        
                        .ImageIndex = lintImgIdx
                        .SelectedImageIndex = lintImgIdx

                        
                        If pbooDisableCode = PopulateTreeDisables.DisableTemplateTopics Then
                            If Microsoft.VisualBasic.IsDBNull(lsnaLists.Fields("TemplateID").Value) Then
                                '
                            Else
                                If lsnaLists.Fields("TemplateID").Value <> "" Then
                                    .ForeColor = SystemColors.GrayText
                                End If
                            End If
                        End If
                        
                        
                    End With
                    '// Record the relationship of uid to node.  This will allow
                    '// us to retrieve a given node by providing the uid as a key.
                    collNodeKeys.Add(tnNew, CType(.Fields("TopicCode").Value, String))
                Else
                    '// Get the parent node based on the relationship stored in the
                    '// database.  This relationship is recorded or updated when a
                    '// call is made to CTreeView.SaveTreeNodeCollection().

                    tnParent = CType(collNodeKeys.Item(CType(.Fields("ParentTopicCode").Value, String)), TreeNode)
                    '// Add the child to the parent;
                    tnNew = tnParent.Nodes.Add(CType(.Fields("Title").Value, String))
                    'tnNew = tnParent.Nodes.Add(CType(.Fields("Title").Value, String) & " " & CType(lsnaLists.Fields("TopicCode").Value, String))
                    With tnNew
                        .Tag() = CType(lsnaLists.Fields("TopicCode").Value, String)
                        If booCheckAll = True Then
                            .Checked = True
                        End If
                        
                        Dim lintImgIdx As Integer
                        If Microsoft.VisualBasic.IsDBNull(lsnaLists.Fields("ImgIdx").Value) Then
                            lintImgIdx = 0
                        Else
                            lintImgIdx = CType(lsnaLists.Fields("ImgIdx").Value & "", Integer)
                        End If
                        
                        'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
                        'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
                        lintImgIdx = IPIconsPack.GetImgIdx(lintImgIdx)
                        
                        .ImageIndex = lintImgIdx
                        .SelectedImageIndex = lintImgIdx
                        
                        If pbooDisableCode = PopulateTreeDisables.DisableTemplateTopics Then
                            If Microsoft.VisualBasic.IsDBNull(lsnaLists.Fields("TemplateID").Value) Then
                                '
                            Else
                                If lsnaLists.Fields("TemplateID").Value <> "" Then
                                    .ForeColor = SystemColors.GrayText
                                End If
                            End If
                        End If
                        
                        
                    End With
                    '// Record the relationship of uid to node.  This will allow
                    '// us to retrieve a given node by providing the uid as a key.
                    'collNodeKeys.Add(tnNew, CType(.Fields("TopicCode").Value, String))

                    'duplicates have occured inthe dbase some how.. need protection against this...
                    If (containsKey(collNodeKeys, .Fields("TopicCode").Value.ToString) = False) Then
                        collNodeKeys.Add(tnNew, CType(.Fields("TopicCode").Value, String))
                    End If


                End If
                .MoveNext()
                lintRecCounter = lintRecCounter + 1
            Loop
        End With

        'Catch ex As Exception 
        '    If gbooAlwaysOnTop = True Then pMe.Activate() 
        '    MessageBox.Show(LangText.GetString("Pad_CorruptIB"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Warning) 
        'End Try 

        lsnaLists.Close()
        lcnn1.Close()

        oTv.Enabled = True 
        oTv.EndUpdate() 

        'MessageBox.Show("PopulateTree glngLastTopicNum=" & glngLastTopicNum)
        'Conxsole.WriteLine("PopulateTree Done!")
    End Sub
    Friend Sub BuildRTFPrint(ByVal pobjRTF As RichTextBox, ByVal n As TreeNode, ByVal pbooShowHeaders As Boolean)
        Dim lstrNodePath As String
        Dim lstrTopicStr As String

        If n.Checked = True Then

            lstrNodePath = (n.FullPath)
            lstrNodePath = FormatNodePath(lstrNodePath)

            
            Dim lstrTemplateID As String
            lstrTopicStr = GetTopic(ReturnTrueTopicStr(n.Tag), lstrTemplateID)

            If lstrTemplateID <> "" Then 'If lstrTemplateID = "" Then
                Exit Sub
            End If
            

            If pbooShowHeaders = True Then
                If pobjRTF.Text <> "" Then
                    pobjRTF.SelectedRtf = "{\rtf1\ansi\ansicpg1252\deff0\deftab720{\fonttbl{\f0\fswiss MS Sans Serif;}{\f1\froman\fcharset2 Symbol;}{\f2\fswiss Arial;}{\f3\fswiss Arial;}}" & CR() & _
                        "{\colortbl\red0\green0\blue0;}" & CR() & "\deflang2057\pard\plain\f2\fs20 " & CR() & _
                        "\par \par \plain\f2\fs28\cf0\b\ul " & lstrNodePath & "\p\plain\f2\fs20 " & CR() & "\par \plain\f3\fs20 \par \par }"
                Else
                    pobjRTF.SelectedRtf = "{\rtf1\ansi\ansicpg1252\deff0\deftab720{\fonttbl{\f0\fswiss MS Sans Serif;}{\f1\froman\fcharset2 Symbol;}{\f2\fswiss Arial;}{\f3\fswiss Arial;}}" & CR() & _
                        "{\colortbl\red0\green0\blue0;}" & CR() & "\deflang2057\pard\plain\f2\fs20 " & CR() & _
                        "\plain\f2\fs28\cf0\b\ul " & lstrNodePath & "\p\plain\f2\fs20 " & CR() & "\par \plain\f3\fs20 \par \par }"
                End If
            Else
                pobjRTF.SelectedRtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fcharset0 Arial;}}" & CR() & _
                    "\viewkind4\uc1\pard\f0\fs20\par" & CR() & "\par" & CR() & "}" & CR()
            End If

            If lstrTopicStr.Trim <> "" Then 
                Try 
                    pobjRTF.SelectedRtf = lstrTopicStr 
                Catch 
                    '
                End Try 
            End If

            AddRTFFooter(pobjRTF, True)

        End If
    End Sub
    Friend Function GetNextTopicID() As Long
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim llngRecCount As Long

        lcnn1 = New ADODB.Connection()
        
        lcnn1.Open(gstrConnectionString)

        Dim lstrSQL As String = "SELECT max(val(left(TopicCode,instr(1,TopicCode,'T')-1))) as CountOfTopicCode  from Topics;"

        gstrLastSQL = lstrSQL 

        
        lsnaLists.Open(lstrSQL, _
            lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        With lsnaLists

            llngRecCount = 0

            If Not .EOF Then
                If .Fields("CountOfTopicCode").Value & "" = "" Then

                    GetNextTopicID = 1
                Else
                    GetNextTopicID = CLng(.Fields("CountOfTopicCode").Value) + 1

                End If
            End If

        End With


        If llngRecCount = 0 Then
        End If

        lsnaLists.Close()
        lcnn1.Close()

    End Function
    Friend Function ReturnTrueTopicStr(ByVal pstrFullTopicStr As String) As String

        ReturnTrueTopicStr = pstrFullTopicStr.Substring(InStrGet(1, pstrFullTopicStr, "T") - 1)
    End Function
    Friend Function NodateLevel(ByVal node As TreeNode) As Integer

        Dim level As Integer = 0

        While Not node Is Nothing

            node = node.Parent

            level = level + 1

        End While
        NodateLevel = level
    End Function
    Private Function FormatNodePath(ByVal pstrFullPath As String, Optional ByVal pbooOneSlash As Boolean = False) As String
        Dim lintPos


        lintPos = InStrGet(1, pstrFullPath, "~")

        If lintPos <> 0 Then
            Do Until lintPos = 0
                lintPos = InStrGet(1, pstrFullPath, "~")
                If lintPos <> 0 Then
                    If pbooOneSlash = False Then
                        pstrFullPath = LeftGet(pstrFullPath, lintPos - 1) & " \\ " & RightGet(pstrFullPath, ((pstrFullPath).Length - lintPos))
                    Else
                        pstrFullPath = LeftGet(pstrFullPath, lintPos - 1) & " \ " & RightGet(pstrFullPath, ((pstrFullPath).Length - lintPos))
                    End If
                End If
            Loop
        End If

        FormatNodePath = pstrFullPath

    End Function
    Private Function GetTopic(ByVal pstrKey As String, ByRef pstrTemplateID As String) As String
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String
        Dim llngRecCount As Long

        GetTopic = "" 

        'used in the printing process

        'On Error GoTo ErrHandler

        lcnn1 = New ADODB.Connection()
        'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive'commented out with locking changes
        lcnn1.Open(gstrConnectionString)
        'Conxsole.WriteLine("DB:GetTopic")

        pstrKey = RightGet(pstrKey, ((pstrKey).Length - InStrGet(1, pstrKey, "T")) + 1)

        'lsnaLists = gdatLocalDatabase.OpenRecordset("Select * from TopicDetail where TopicCode='" & pstrKey & "';", dbOpenSnapshot)

        lstrSQL = "Select * from TopicDetail where TopicCode='" & pstrKey & "';"

        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, _
            lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        With lsnaLists

            llngRecCount = 0

            
            Dim strChunk As String = ""
            Dim Offset As Long
            Dim Totalsize As Long
            Dim ChunkSize As Long
            Dim lintByteLength As Integer
            

            If Not .EOF Then

                Try : pstrTemplateID = .Fields("TemplateID").Value & "" : Catch : End Try 

                ChunkSize = 1000
                Totalsize = lsnaLists("Detail").ActualSize
                Do While Offset < Totalsize
                    strChunk = strChunk + lsnaLists("Detail").GetChunk(ChunkSize)
                    Offset = Offset + ChunkSize
                Loop
                lintByteLength = lsnaLists("ByteLen").Value

                If strChunk <> " " Then
                    Try
                        If lintByteLength <> -1 And strChunk <> "" Then
                            AddDebugComment("Inflate")
                            Dim InfDef As New InflateDeflate()
                            strChunk = InfDef.Inflate(strChunk, lintByteLength)
                        End If
                        GetTopic = strChunk
                    Catch
                        GetTopic = ""
                    End Try
                Else
                    GetTopic = "" '???
                End If

                If GetTopic <> "" Then 
                    If RightGet(GetTopic, 1) = "}" Then
                        GetTopic = LeftGet(GetTopic, (GetTopic).Length - 1)
                    End If
                End If
            Else
                
                'When here, highlight a missing detail records, Denise had this!
                'Think it was due to draging branches etc.

            End If

        End With

        If llngRecCount = 0 Then
        End If

        lsnaLists.Close()
        lcnn1.Close()

    End Function
    Friend Function GetTopicCountAsParent(ByVal pstrKey As String) As Integer
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String
        Dim llngRecCount As Long

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        lstrSQL = "SELECT Count(Topics.TopicCode) AS CountOfTID FROM Topics HAVING ParentTopicCode = '" & pstrKey & "';"
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        With lsnaLists

            llngRecCount = 0

            If Not .EOF Then
                GetTopicCountAsParent = .Fields("CountOfTID").Value & ""
            End If

        End With

        If llngRecCount = 0 Then
        End If

        lsnaLists.Close()
        lcnn1.Close()
  
    End Function


    Friend Sub GetNodes(ByVal Node As TreeNode, ByRef rgndxs() As TreeNode, ByRef rgCount As Integer, ByVal pbooJustChecked As Boolean)

        On Error Resume Next
        While Not Node Is Nothing
            ' If this node is checked ADD it to the list
            ' then recurse to handle the children.
            If pbooJustChecked = True Then
                If Node.Checked Then
                    'rgCount += 1
                    rgndxs(rgCount + 1) = Node
                    rgCount += 1
                End If
            Else
                'rgCount += 1
                rgndxs(rgCount + 1) = Node
                rgCount += 1
            End If

            ' Handle the child nodes
            If Not Node.Nodes Is Nothing Then
                If Node.Nodes.Count > 0 Then
                    GetNodes(Node.Nodes(0), rgndxs, rgCount, pbooJustChecked)
                End If
            End If
            ' Move on to the next node.
            Node = Node.NextNode
        End While
    End Sub
    Friend Sub AddNewTopicCopyDetails(ByVal plngLevel As Long, ByVal pstrTitle As String, ByVal pstrTopicCode As String, _
        ByVal pstrParentCode As String, ByVal pstrOldTopiCode As String, ByVal pintTreeIdx As Integer, ByVal pstrTemplateID As String, _
        ByRef pstrLockingFlag As String, ByVal pSeqNum As Integer, ByVal pOptions As String)

        
        'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
        'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
        pintTreeIdx = IPIconsPack.GetImgTag(pintTreeIdx)
        

        
        Try
            pstrTemplateID = pstrTemplateID.ToUpper
        Catch
        End Try
        

        Dim lcnn1 As New ADODB.Connection()
        'Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String

        lcnn1 = New ADODB.Connection()
        'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive'commented out with locking changes
        lcnn1.Open(gstrConnectionString)
        'Conxsole.WriteLine("DB:AddNewTOpicCopyDetails")

        If pstrOldTopiCode = "" Then
            AddDebugComment("main.AddNewTopicCopyDetails - pstrOldTopiCode = ''") 
            'lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse ) " & _
            '     "Values(" & plngLevel & ", '" & pstrTitle & "', '" & pstrTopicCode & "', '" & pstrParentCode & "', 0, True);"

            
            'lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse, ImgIdx ) " & _
            '     "Values(" & plngLevel & ", '" & pstrTitle & "', '" & pstrTopicCode & "', '" & pstrParentCode & _
            '     "', 0, True, " & pintTreeIdx & ");"
            
            lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse, ImgIdx ) " & _
                 "Values(" & plngLevel & ", '" & pstrTitle & "', '" & pstrTopicCode & "', '" & pstrParentCode & _
                 "', " & pSeqNum & ", True, " & pintTreeIdx & ");"
        Else

            AddDebugComment("main.AddNewTopicCopyDetails - pstrOldTopiCode <> ''") 
            'lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse ) " & _
            '    "SELECT " & plngLevel & " AS Expr1, '" & pstrTitle & "' AS Expr2, '" & pstrTopicCode & _
            '    "' AS Expr3, '" & pstrParentCode & "' AS Expr4, SeqNum, InUse FROM Topics WHERE TopicCode='" & _
            '    pstrOldTopiCode & "';"

            
            lstrSQL = "INSERT INTO Topics ( [Level], Title, TopicCode, ParentTopicCode, SeqNum, InUse, ImgIdx ) " & _
                "SELECT " & plngLevel & " AS Expr1, '" & pstrTitle & "' AS Expr2, '" & pstrTopicCode & _
                "' AS Expr3, '" & pstrParentCode & "' AS Expr4, SeqNum, InUse, " & pintTreeIdx & _
                " FROM Topics WHERE TopicCode='" & _
                pstrOldTopiCode & "';"


        End If

        gstrLastSQL = lstrSQL 

        'Conxsole.WriteLine("ANTCD-A: " & lstrSQL)
        lcnn1.Execute(lstrSQL)
        'Conxsole.WriteLine("ANTCD-B: " & lstrSQL)

        If pstrTemplateID.Trim = "" Then 
            pstrTemplateID = GetDefaultTemplateID() 'if blank use the default template if selected
        End If

        'LOCKING
        pstrLockingFlag = CreateLockingFlag(ReturnTrueTopicStr(pstrTopicCode)) 

        If pstrOldTopiCode = "" Then
            'lstrSQL = "INSERT INTO TopicDetail ( [Level], TopicCode, Detail ) Values(" & plngLevel & ", '" & _
            '    ReturnTrueTopicStr(pstrTopicCode) & "',' ');"
            'level not required in TopicDetail
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail ) Values('" & _
            '    ReturnTrueTopicStr(pstrTopicCode) & "',' ');"
            'Conxsole.WriteLine("ANTCD-B: " & lstrSQL)

            
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID ) Values('" & _
            '    ReturnTrueTopicStr(pstrTopicCode) & "',' ','" & pstrTemplateID & "');"
            
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag ) Values('" & _
            'ReturnTrueTopicStr(pstrTopicCode) & "',' ','" & pstrTemplateID & "','" & pstrLockingFlag & "');"

            
            Dim lstrDetail As String
            Try 
                If pstrTemplateID.Trim <> "" Then
                    lstrDetail = "<emaNtcatnoC></emaNtcatnoC>"
                End If
            Catch 
            End Try 

            AddDebugComment("main.AddNewTopicCopyDetails - pstrOldTopiCode = '' INSERT INTO TopicDetail ") 
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag ) Values('" & _
            '    ReturnTrueTopicStr(pstrTopicCode) & "','" & lstrDetail & "','" & pstrTemplateID & "','" & pstrLockingFlag & "');"
            
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag, ByteLen ) Values('" & _
            '    ReturnTrueTopicStr(pstrTopicCode) & "','" & lstrDetail & "','" & pstrTemplateID & "','" & pstrLockingFlag & "', -1);"
            
            lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag, ByteLen, Options ) Values('" & _
                ReturnTrueTopicStr(pstrTopicCode) & "','" & lstrDetail & "','" & pstrTemplateID & "','" & pstrLockingFlag & "', -1, '" & pOptions & "');"

            
        Else

            AddDebugComment("main.AddNewTopicCopyDetails - Else pstrOldTopiCode = '' INSERT INTO TopicDetail ") 
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, [Level], Detail ) SELECT TopicCode, [Level], Detail " & _
            '    "FROM TopicDetail  WHERE TopicCode='" & ReturnTrueTopicStr(pstrOldTopiCode) & "';"
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, [Level], Detail ) SELECT '" & ReturnTrueTopicStr(pstrTopicCode) & "' as TopicCode, " & _
            '    "[Level], Detail FROM TopicDetail WHERE TopicCode='" & ReturnTrueTopicStr(pstrOldTopiCode) & "';"
            'level not required in TopicDetail
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail ) SELECT '" & ReturnTrueTopicStr(pstrTopicCode) & "' as TopicCode, " & _
            '    "Detail FROM TopicDetail WHERE TopicCode='" & ReturnTrueTopicStr(pstrOldTopiCode) & "';"

            
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID ) SELECT '" & ReturnTrueTopicStr(pstrTopicCode) & "' as TopicCode, " & _
            '    "Detail, TemplateID FROM TopicDetail WHERE TopicCode='" & ReturnTrueTopicStr(pstrOldTopiCode) & "';"

            
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFLag ) SELECT '" & ReturnTrueTopicStr(pstrTopicCode) & "' as TopicCode, " & _
            '    "Detail, TemplateID, '" & pstrLockingFlag & "' FROM TopicDetail WHERE TopicCode='" & ReturnTrueTopicStr(pstrOldTopiCode) & "';"
            
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFLag, ByteLen ) SELECT '" & ReturnTrueTopicStr(pstrTopicCode) & "' as TopicCode, " & _
            '    "Detail, TemplateID, '" & pstrLockingFlag & "', ByteLen FROM TopicDetail WHERE TopicCode='" & ReturnTrueTopicStr(pstrOldTopiCode) & "';"

            
            'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFLag, ByteLen, Options ) SELECT '" & ReturnTrueTopicStr(pstrTopicCode) & "' as TopicCode, " & _
            '    "Detail, TemplateID, '" & pstrLockingFlag & "', ByteLen, Options FROM TopicDetail WHERE TopicCode='" & ReturnTrueTopicStr(pstrOldTopiCode) & "';"

            
            lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFLag, ByteLen, Options ) SELECT '" & ReturnTrueTopicStr(pstrTopicCode) & "' as TopicCode, " & _
            "Detail, TemplateID &'', '" & pstrLockingFlag & "', ByteLen, Options FROM TopicDetail WHERE TopicCode='" & ReturnTrueTopicStr(pstrOldTopiCode) & "';"

            'Conxsole.WriteLine("ANTCD-C: " & lstrSQL)

        End If
        gstrLastSQL = lstrSQL 

        lcnn1.Execute(lstrSQL)
        'Conxsole.WriteLine("ANTCD-C: ")
        lcnn1.Close()

    End Sub
    Friend Sub AddQuickLaunchEtc(ByVal lintDialogResult As DialogResult)
        If InStrGet(NameMe("").ToUpper, "TRIAL") > 0 Then 'Changed to Trial 
            
            'CreateURLShortCut("IdeasPad", "How to Buy IdeasPad.url", "URLSMenu", _
            '"http://www.example.com/buy-products.html")
            If lintDialogResult = DialogResult.Yes Then
                'CopyStartMenuLnkToQuickLaunch("Ideaspad", "Ideaspad (Shareware Version).lnk")
                
                CopyStartMenuLnkToQuickLaunch(gProgName, LangText.GetString("Main_IdeaspadSharewareLNK").Replace("[Program]", gProgName))

            End If
        Else
            
            'CreateURLShortCut("IdeasPad", "IdeasPad Support.url", "URLSMenu", _
            '"http://www.example.com/support.html")
            If lintDialogResult = DialogResult.Yes Then
                'CopyStartMenuLnkToQuickLaunch("Ideaspad", "Ideaspad 2003 Standard.lnk")
                
                CopyStartMenuLnkToQuickLaunch(gProgName, LangText.GetString("Main_IdeaspadStandardLNK").Replace("[Program]", gProgName).Replace("2004", gYear))

            End If
        End If
    End Sub
    Friend Function CheckToMakeOrphan(ByVal pstrTopic As String) As Integer
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String

        pstrTopic = ReturnTrueTopicStr(pstrTopic) 

        lcnn1 = New ADODB.Connection()
        'lcnn1.Mode = ADODB.ConnectModeEnum.adModeShareExclusive
        lcnn1.Open(gstrConnectionString)
        'Conxsole.WriteLine("DB:CheckToMakeOrphan")

        lstrSQL = "SELECT Count(1) AS TopicCount FROM(Topics) WHERE " & _
            "(((Right([TopicCode],Len([TopicCode])-InStr(1,[TopicCode],'T')+1))='" & pstrTopic & "'));"
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        'Console.WriteLine(lstrSQL)
        With lsnaLists

            If Not .EOF Then
                CheckToMakeOrphan = CInt(.Fields("TopicCount").Value & "")
            End If
        End With

        lsnaLists.Close()
        lcnn1.Close()

    End Function
    Friend Function SearchParentsNodeForSelf(ByVal node As TreeNode, ByVal pstrTopicCode As String) As Boolean

        'Console.WriteLine("Search for " & pstrTopicCode)
        SearchParentsNodeForSelf = False

        Try
            While Not node Is Nothing

                node = node.Parent
                'Console.WriteLine(node.Text & " " & node.Tag & " " & node.Parent.Tag)
                If node.Tag = pstrTopicCode Then
                    'found
                    SearchParentsNodeForSelf = True
                    Exit While
                End If
                
                If node.Parent.Tag = pstrTopicCode Then
                    'Console.WriteLine(node.Text & node.Parent.Tag)
                    SearchParentsNodeForSelf = True
                    Exit While
                End If
                
            End While
        Catch ex As Exception
            '
        End Try

    End Function
    Friend Function SelectNodeByTag(ByVal pstrTag As String, ByVal ptreeview As TreeView, Optional ByRef pcurDocumentView As frmPad.DocumentViews = frmPad.DocumentViews.NormalTopic) As Boolean
        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1

        SelectNodeByTag = False 
        ' Allocate enough space to indicate that ALL nodes are checked.
        cNodes = ptreeview.GetNodeCount(True)

        If cNodes > 0 Then 
            ReDim ndxs(cNodes)
            GetNodes(ptreeview.Nodes(0), ndxs, curNode, False)

            ' Shrink the array to just the # of selected nodes.
            ReDim Preserve ndxs(curNode)
            For Each n In ndxs
                If n.Tag = pstrTag Then
                    'lbooViewingMCLDoc = False
                    pcurDocumentView = frmPad.DocumentViews.NormalTopic 
                    ptreeview.SelectedNode = n
                    SelectNodeByTag = True 
                    Exit For
                End If
            Next
        End If

    End Function
    Friend Sub PopulateHTMLFields(ByVal pstrFormData As String, ByRef BrowserControl As WinOnly.WebOCHostCtrl)
        Dim allDone As Boolean = False

        Do Until allDone = True
            Dim HtmlDoc As IHTMLDocument2 = CType(BrowserControl.HtmlDocument, IHTMLDocument2)
            Dim FormCol As IHTMLElementCollection = HtmlDoc.forms


            Dim iForms As Integer = FormCol.length
            Dim i As Integer
            Dim x As Integer
            For i = 0 To iForms - 1
                Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(i, Object), CType(i, Object)), IHTMLFormElement)

                ''Console.WriteLine("P-A " & Date.Now)
                For x = 0 To oForm.length - 1
                    Dim lstrThisFormField As String = Reverse(oForm.elements(x).name)
                    Dim lstrThisValue As String = GetData(pstrFormData, "<" & lstrThisFormField & ">", "</" & lstrThisFormField & ">")

                    lstrThisValue = UnJetSQLFixup(lstrThisValue) 

                    'see this site for some general help
                    'http://www.activevb.de/tutorials/tut_browsertags/browsertags.html
                    'WebBrowser1.Document.Forms(0).elements(0).Checked = True
                    If Not lstrThisValue Is Nothing Then 
                        Select Case oForm.elements(x).type
                            Case "text", "textarea"
                                oForm.elements(x).value = lstrThisValue
                            Case "select-one"
                                ''' this works ''' oForm.elements(x).options(2).selected = True
                                Dim y As Integer
                                For y = 0 To oForm.elements(x).length - 1
                                    'Console.WriteLine(oForm.elements(x).options(y).text & " " & y)
                                    If oForm.elements(x).options(y).text = lstrThisValue Then
                                        oForm.elements(x).options(y).selected = True
                                        Exit For
                                    End If
                                Next y
                            Case "Check box" '??
                            Case "SELECT-multiple" '??
                            Case Else
                                'Console.WriteLine(oForm.elements(x).type)
                        End Select
                    End If
                    ''Console.WriteLine("P-B " & lstrThisFormField & " " & Date.Now)
                    allDone = True
                Next
            Next i
            'Console.WriteLine(BrowserControl.ReadyState)
            System.Windows.Forms.Application.DoEvents()
            'BrowserControl.Refresh()
            'BrowserControl.Refresh2()

        Loop

    End Sub
    Function GetIcon(ByVal pobObject As Object, ByVal pstrIcon As String) As Icon

        'Don't forget!! if your getting a null error, you haven't set the icon as
        'an emmeded resource in its properties.  Be carefully, as it can screw up
        'your form! So Save your form first!
        'Return New Icon(Me.GetType().Assembly.GetExecutingAssembly.GetManifestResourceStream(Me.GetType(), pstrIcon))
        Return New Icon(pobObject.GetType().Assembly.GetExecutingAssembly.GetManifestResourceStream(pobObject.GetType(), pstrIcon))

    End Function
    Function GetHelpFile() As String
        'Internationalized
        Dim lstrHelpFile As String
        Dim lstrLang2Char As String = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName
        Select Case lstrLang2Char
            Case "de"
                lstrHelpFile = Application.StartupPath & "\de\" & gProgName & ".de.chm"
            Case Else
                lstrHelpFile = Application.StartupPath & "\" & gProgName & ".chm"
        End Select

        Return lstrHelpFile

    End Function
    Friend Enum HelpTopic
        'spelling
        support 'in use
        templatemenu 'in use
        templatesearch 'in use
        toolsoptions 'in use
        'welcome
        'whatsatemplate
        buy 'in use
        'importrichtext
        'sharingtemplates
        templatesprovided 'in use
        bookmarks 'in use
        branchprops 'in use
        'createtemplates
        exporttempldata 'in use
        exportwizard 'in use
        importwizard 'in use
        maintenance 'in use
        quickstart 'in use
        bookmark_organise 'in use
        Template_options_create 'in use
        Rapid_Entry 
    End Enum
    Function GetHelpTopic(ByVal HelpTopic As HelpTopic) As String

        Select Case HelpTopic
            'Case HelpTopic.spelling
            '    Return "spelling.html"
        Case HelpTopic.support
                Return "support.html"
            Case HelpTopic.templatemenu
                Return "templatemenu.html"
            Case HelpTopic.templatesearch
                Return "templatesearch.html"
            Case HelpTopic.toolsoptions
                Return "toolsoptions.html"
                'Case HelpTopic.welcome
                '    Return "welcome.html"
                'Case HelpTopic.whatsatemplate
                '    Return "whatsatemplate.html"
            Case HelpTopic.buy
                Return "buy.html"
                'Case HelpTopic.importrichtext
                '    Return "importrichtext.html"
                'Case HelpTopic.sharingtemplates
                '    Return "sharingtemplates.html"
            Case HelpTopic.templatesprovided
                Return "templatesprovided.html"
            Case HelpTopic.bookmarks
                Return "bookmarks.html"
            Case HelpTopic.branchprops
                Return "branchprops.html"
                'Case HelpTopic.createtemplates
                '    Return "createtemplates.html"
            Case HelpTopic.exporttempldata
                Return "exporttempldata.html"
            Case HelpTopic.exportwizard
                Return "exportwizard.html"
            Case HelpTopic.importwizard
                Return "importwizard.html"
            Case HelpTopic.maintenance
                Return "maintenance.html"
            Case HelpTopic.quickstart
                Return "quickstart.html"
            Case HelpTopic.bookmark_organise
                Return "bookmarks.html#bookmark_organise"
            Case HelpTopic.Template_options_create
                Return "templatesprovided.html#Template_options_create"
            Case HelpTopic.Rapid_Entry 
                Return "rapidentry.html" 
        End Select

    End Function
    Friend Function CreateLockingFlag(ByVal pstrCurTopicCode As String) As String
        'LOCKING
        Dim lstrCurUser As String = GetUserName() 
        Try : lstrCurUser = LeftGet(lstrCurUser, 16) : Catch : End Try 

        '21 + 19 ?? say 50
        If pstrCurTopicCode = "" Then
            'Return System.Environment.UserName & " at " & Date.Now
            'Return GetUserName() & " at " & Date.Now 
            'Return JetSQLFixup(GetUserName()) & " at " & Date.Now 
            Return JetSQLFixup(lstrCurUser) & " at " & Date.Now 
        Else
            'Return pstrCurTopicCode & "#" & System.Environment.UserName & " at " & Date.Now
            'Return pstrCurTopicCode & "#" & GetUserName() & " at " & Date.Now 
            'Return pstrCurTopicCode & "#" & JetSQLFixup(GetUserName()) & " at " & Date.Now 
            Return pstrCurTopicCode & "#" & JetSQLFixup(lstrCurUser) & " at " & Date.Now 
        End If

    End Function
    Friend Function GetLastTopicRealNumber() As Long
        'Created to resolve multi user topic issues, adding topics etc with glngLastTopicNum 
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lngPrevLastTopicNum As Long = glngLastTopicNum 

        lcnn1.Open(gstrConnectionString)
        Dim lstrSQL As String = "SELECT max(val(Mid([TopicCode],InStr(1,[TopicCode],'T')+1))) AS tot  FROM Topics;"

        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, _
         lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        With lsnaLists
            If Not .EOF Then
                Try
                    GetLastTopicRealNumber = CLng(.Fields("tot").Value)
                Catch
                    GetLastTopicRealNumber = 0
                End Try
            End If

        End With

        lsnaLists.Close()
        lcnn1.Close()

        
        If GetLastTopicRealNumber <= lngPrevLastTopicNum Then
            GetLastTopicRealNumber = lngPrevLastTopicNum
        End If
        
    End Function
    Friend Sub DebugDBComment()

        If gstrProbComtStack <> "" Then 
            AddDebugComment(gstrProbComtStack) 
        End If

        If gstrDecryptProbTrace <> "" Then   
            AddDebugComment(gstrDecryptProbTrace) 
        End If

        
        Try
            Dim lcnn1 As New ADODB.Connection()
            Dim lsnaLists As New ADODB.Recordset()
            Dim lstrSQL As String
            Dim DebugComment As String

            lcnn1 = New ADODB.Connection()
            lcnn1.Open(gstrConnectionString)

            lstrSQL = "Select * from Topics;"

            lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            Dim Dm As String = "#"
            Dim lintRecCounter As Integer
            With lsnaLists
                Do While Not .EOF
                    'DebugComment &= "Insert into Topics (TopicCode, [Level], ParentTopicCode, SeqNum) values ('" & _
                    '    .Fields("TopicCode").Value & "', " & .Fields("Level").Value & ", '" & .Fields("ParentTopicCode").Value & _
                    '    "', " & .Fields("SeqNum").Value & " );" & Environment.NewLine

                    DebugComment &= .Fields("TopicCode").Value & Dm & .Fields("Level").Value & Dm & _
                        lintRecCounter & Dm & .Fields("ParentTopicCode").Value & Dm & .Fields("SeqNum").Value & _
                        Dm & .Fields("InUse").Value & Dm & .Fields("ImgIdx").Value & Environment.NewLine


                    .MoveNext()
                    lintRecCounter += 1
                Loop
            End With


            lsnaLists.Close()
            lcnn1.Close()

            AddDebugComment("main.DB: " & DebugComment)
            AddDebugComment("main.LastSQL: " & gstrLastSQL) 

            
            Try
                Dim DBStr As String = GetData(gstrConnectionString, "Data Source=", ";")
                Dim DBSize As Double = (Microsoft.VisualBasic.FileLen(DBStr) / 1024) / 1024
                AddDebugComment("main.DB: Size = " & RoundUP(DBSize) & "mb")
            Catch
                '
            End Try
            
        Catch
            '
        End Try

        
        Dim BesideErr As String
        Try : BesideErr = GetSetting("Beside01Err", "Null", InitalXMLConfig.XmlConfigType.AppSettings, "") : Catch : End Try
        AddDebugComment("main.BesideErr: " & BesideErr)
        

    End Sub
    Friend Function CountSiblings(ByVal tv As TreeNode) As Integer
        
        Dim level As Integer = 0

        Dim oNode As TreeNode
        For Each oNode In tv.Nodes
            level = level + 1
        Next
        CountSiblings = level

    End Function
    Friend Function CountSiblings(ByVal tv As TreeView) As Integer
        
        Dim level As Integer = 0
        If Not tv.SelectedNode Is Nothing Then
            Dim oNode As TreeNode
            For Each oNode In tv.Nodes
                level = level + 1
            Next
        End If
        CountSiblings = level

    End Function
    Friend Function IsFormOpen(ByVal pMe As Form, ByVal pstrTitle As String) As Boolean
        'added 
        IsFormOpen = False

        Dim frm As System.Windows.Forms.Form

        For Each frm In pMe.OwnedForms
            If frm.Text = pstrTitle Then 'The form is open
                IsFormOpen = True
                Exit For
            End If
        Next frm

    End Function
    Dim LastParentTag As TreeNode 


    Function BuildRTFXMLOutput(ByVal pobjRTF As RichTextBox, ByVal n As TreeNode, ByVal pbooShowHeaders As Boolean, _
        ByVal pAllFields() As TemplateFields, ByRef pintEndsTopicRequired As Integer)
        Dim lstrNodePath As String
        Dim lstrTopicStr As String

        Dim lbooIsParent As Boolean 

        If n.Checked = True Then

            lstrNodePath = (n.FullPath)
            lstrNodePath = FormatNodePath(lstrNodePath)

            
            Dim lstrTemplateID As String
            lstrTopicStr = GetTopic(ReturnTrueTopicStr(n.Tag), lstrTemplateID)

            


            If lstrTemplateID <> "" Then 'If lstrTemplateID = "" Then
                pobjRTF.SelectedText = GenerateTemplateTopicXML(lstrTopicStr, lstrTemplateID, pAllFields, n.Tag)
                Exit Function
            End If
            

            If pbooShowHeaders = True Then
                If pobjRTF.Text <> "" Then

                    'need to make it xml
                    'you don't need to set the level!!
                    pobjRTF.SelectedText = "<Richtext>{\rtf1\ansi\ansicpg1252\deff0\deftab720{\fonttbl{\f0\fswiss MS Sans Serif;}{\f1\froman\fcharset2 Symbol;}{\f2\fswiss Arial;}{\f3\fswiss Arial;}}" & CR() & _
                        "{\colortbl\red0\green0\blue0;}" & CR() & "\deflang2057\pard\plain\f2\fs20 " & CR() & _
                        "\par \par \plain\f2\fs28\cf0\b\ul " & lstrNodePath & "\p\plain\f2\fs20 " & CR() & "\par \plain\f3\fs20 \par \par }"
                Else
                    pobjRTF.SelectedText = "<Richtext>{\rtf1\ansi\ansicpg1252\deff0\deftab720{\fonttbl{\f0\fswiss MS Sans Serif;}{\f1\froman\fcharset2 Symbol;}{\f2\fswiss Arial;}{\f3\fswiss Arial;}}" & CR() & _
                        "{\colortbl\red0\green0\blue0;}" & CR() & "\deflang2057\pard\plain\f2\fs20 " & CR() & _
                        "\plain\f2\fs28\cf0\b\ul " & lstrNodePath & "\p\plain\f2\fs20 " & CR() & "\par \plain\f3\fs20 \par \par }"
                End If
            Else
                pobjRTF.SelectedText = "<Richtext>{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fcharset0 Arial;}}" & CR() & _
                    "\viewkind4\uc1\pard\f0\fs20\par" & CR() & "\par" & CR() & "}" & CR()
            End If


            If lstrTopicStr.Trim <> "" Then
                Try 
                    pobjRTF.SelectedText = lstrTopicStr
                Catch
                    '
                End Try
            End If

            AddRTFFooter(pobjRTF, False)

            pobjRTF.SelectedText = "</Richtext>" & CR()
        End If



    End Function

    Friend Function WriteTreeView(ByVal tv As TreeView, ByVal pobjRTF As RichTextBox, _
        ByVal pbooShowHeaders As Boolean, ByVal pAllFields() As TemplateFields) As String
        'added 


        Dim sb As New MemoryStream() 'Text.StringBuilder()
        'Dim enc As Text.Encoding = Text.Encoding.GetEncoding("ISO-8859-1")


        'Dim writer As New Xml.XmlTextWriter(New StringWriter(sb))
        Dim writer As New Xml.XmlTextWriter(sb, Text.UTF8Encoding.UTF8)

        'comment out next 2 if not displaying the XML
        writer.Formatting = Xml.Formatting.None ' Xml.Formatting.Indented

        writer.Indentation = 4

        'write TreeView props
        writer.WriteStartDocument()
        writer.WriteStartElement("Ideaspad_Outliner")
        writer.WriteElementString("Version", "1.0")

        'write each root node and children.
        Dim node As TreeNode
        For Each node In tv.Nodes
            If node.Parent Is Nothing Then
                If node.Checked = True Then 
                    WriteNode(writer, node, pobjRTF, pbooShowHeaders, pAllFields)
                End If 
            End If
        Next node
        writer.WriteEndElement()
        writer.WriteEndDocument()
        'writer.Close()
        writer.Flush()


        Dim strReader As StreamReader = New StreamReader(sb)
        sb.Seek(0, SeekOrigin.Begin)
        Return strReader.ReadToEnd()


        'Return sb.ToString()
    End Function 'WriteTreeView

    'recursive: writes node and child nodes of node
    Private Sub WriteNode(ByVal writer As Xml.XmlTextWriter, ByVal node As TreeNode, ByVal pobjRTF As RichTextBox, _
        ByVal pbooShowHeaders As Boolean, ByVal pAllFields() As TemplateFields)
        'added 
        If node Is Nothing Then
            Return
        End If
        writer.WriteStartElement("Topic")
        'write node properties

        'writer.WriteElementString("Name", node.Text)
        
        writer.WriteElementString("Name", Web.HttpUtility.HtmlEncode(node.Text))

        writer.WriteElementString("TopicCode", node.Tag)
        Dim ParentCode As String = ""
        If Not node.Parent Is Nothing Then
            ParentCode = node.Parent.Tag
        End If
        writer.WriteElementString("ParentTopicCode", ParentCode)
        writer.WriteElementString("Icon", node.ImageIndex)

        '--- 
        Dim lstrTopicStr As String
        Dim lstrTemplateID As String
        Dim lstrNodePath As String

        lstrTopicStr = GetTopic(ReturnTrueTopicStr(node.Tag), lstrTemplateID)
        lstrNodePath = (node.FullPath)


        If lstrTemplateID <> "" Then 'If lstrTemplateID = "" Then
            writer.WriteElementString("Format", "Template")
            writer.WriteElementString("TemplateID", lstrTemplateID)
            pobjRTF.SelectedText = GenerateTemplateTopicXML(lstrTopicStr, lstrTemplateID, pAllFields, node.Tag)

        Else
            writer.WriteElementString("Format", "RichText")
            If pbooShowHeaders = True Then
                If pobjRTF.Text <> "" Then

                    'need to make it xml
                    'you don't need to set the level!!
                    pobjRTF.SelectedText = "<Richtext>{\rtf1\ansi\ansicpg1252\deff0\deftab720{\fonttbl{\f0\fswiss MS Sans Serif;}{\f1\froman\fcharset2 Symbol;}{\f2\fswiss Arial;}{\f3\fswiss Arial;}}" & CR() & _
                        "{\colortbl\red0\green0\blue0;}" & CR() & "\deflang2057\pard\plain\f2\fs20 " & CR() & _
                        "\par \par \plain\f2\fs28\cf0\b\ul " & lstrNodePath & "\p\plain\f2\fs20 " & CR() & "\par \plain\f3\fs20 \par \par }"
                Else
                    pobjRTF.SelectedText = "<Richtext>{\rtf1\ansi\ansicpg1252\deff0\deftab720{\fonttbl{\f0\fswiss MS Sans Serif;}{\f1\froman\fcharset2 Symbol;}{\f2\fswiss Arial;}{\f3\fswiss Arial;}}" & CR() & _
                        "{\colortbl\red0\green0\blue0;}" & CR() & "\deflang2057\pard\plain\f2\fs20 " & CR() & _
                        "\plain\f2\fs28\cf0\b\ul " & lstrNodePath & "\p\plain\f2\fs20 " & CR() & "\par \plain\f3\fs20 \par \par }"
                End If
            Else
                pobjRTF.SelectedText = "<Richtext>{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fcharset0 Arial;}}" & CR() & _
                    "\viewkind4\uc1\pard\f0\fs20\par" & CR() & "\par" & CR() & "}" & CR()
            End If


            If lstrTopicStr.Trim <> "" Then
                Try 
                    pobjRTF.SelectedText = lstrTopicStr
                Catch
                    '
                End Try
            End If

            AddRTFFooter(pobjRTF, False)

            pobjRTF.SelectedText = "</Richtext>" & CR()

        End If

        writer.WriteRaw(pobjRTF.Text) 
        pobjRTF.Text = "" 

        '--- 

        Dim childNode As TreeNode
        For Each childNode In node.Nodes
            WriteNode(writer, childNode, pobjRTF, pbooShowHeaders, pAllFields)
        Next childNode

        writer.WriteEndElement()

    End Sub 'WriteNode
    Friend Function GetSettingsValue(ByVal pstrItem As String, Optional ByVal conn As ADODB.Connection = Nothing) As String
        'added 
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        If conn Is Nothing Then
            lcnn1 = New ADODB.Connection()
            lcnn1.Open(gstrConnectionString)
        Else
            lcnn1 = conn
        End If

        GetSettingsValue = ""

        Try 
            Dim lstrSQL As String = "SELECT data FROM Sets where ident ='" & pstrItem & "';"

            gstrLastSQL = lstrSQL 
            lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            With lsnaLists
                If Not .EOF Then
                    GetSettingsValue = .Fields("data").Value & ""
                End If
            End With
            lsnaLists.Close()
        Catch ex As Exception
            '
        Finally

            If conn Is Nothing Then
                lcnn1.Close()
            End If
        End Try


    End Function
    Friend Sub SaveSettingsValue(ByVal pstrItem As String, ByVal pstrValue As String)
        'added 
        Dim lcnn1 As New ADODB.Connection()
        Dim lintArrInc As Integer

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        If GetSettingsValue(pstrItem, lcnn1) <> "" Then

            Dim lstrSQL As String = "Update Sets set data ='" & pstrValue & "' Where ident ='" & pstrItem & "';" 

            gstrLastSQL = lstrSQL 
            lcnn1.Execute(lstrSQL) 
        Else
            Dim lstrSQL As String = "Insert into Sets (ident, data) values ('" & pstrItem & "', '" & pstrValue & "');"

            gstrLastSQL = lstrSQL 
            lcnn1.Execute(lstrSQL) 
        End If

        lcnn1.Close()

    End Sub
    Dim mCrashLineStr As String
    Dim mCrashLineIdx As Integer
    Friend Sub AddCrashComment(ByVal pstrComment As String)
        'added 
        'Dim UpdateTotal As Boolean = False

        If (mCrashLineStr + pstrComment).Length > 250 Then
            mCrashLineIdx = mCrashLineIdx + 1
            mCrashLineStr = ""
            'UpdateTotal = True
        End If

        mCrashLineStr = mCrashLineStr + pstrComment + " "

        Dim myBaseItem As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( _
            "SOFTWARE\Mindwarp Consultancy Ltd\" & NameMe(""), True)

        If myBaseItem Is Nothing Then
            myBaseItem = Microsoft.Win32.Registry.CurrentUser.CreateSubKey( _
            "SOFTWARE\Mindwarp Consultancy Ltd\" & NameMe(""))
        End If

        myBaseItem.SetValue("comm" + CStr(mCrashLineIdx), mCrashLineStr)

        'If UpdateTotal = True Then
        myBaseItem.SetValue("commtot", CStr(mCrashLineIdx))
        ' End If

        AddDebugComment(pstrComment)


    End Sub
    Friend Sub ClearCrashReport()
        'added 

        Dim myBaseItem As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( _
            "SOFTWARE\Mindwarp Consultancy Ltd\" & NameMe(""), True)

        Dim RawCommTot As String = ""

        If Not myBaseItem Is Nothing Then
            RawCommTot = CType(myBaseItem.GetValue("commtot", ""), String)
        End If

        Dim TotItems As Integer
        Dim lintArrInc As Integer

        If RawCommTot <> "" Then
            TotItems = Val(RawCommTot)

            For lintArrInc = 0 To TotItems
                myBaseItem.SetValue("comm" + CStr(lintArrInc), "")
            Next lintArrInc
        End If

        myBaseItem.SetValue("commtot", "")

        mCrashLineStr = ""
        mCrashLineIdx = 0
        myBaseItem.Close()

    End Sub
    Friend Sub CheckForCrashOrProbReport(ByVal pbooForceAnyReport As Boolean, ByVal pbooQuiet As Boolean, ByRef pSplashScreen As ipsplash)
        'added 
        Dim myBaseItem As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( _
            "SOFTWARE\Mindwarp Consultancy Ltd\" & NameMe(""), True)
        Dim RawCommTot As String = ""

        If Not myBaseItem Is Nothing Then
            RawCommTot = CType(myBaseItem.GetValue("commtot", ""), String)
        End If

        Dim TotItems As Integer
        Dim lintArrInc As Integer
        Dim Arr() As String
        Dim str As String
        Dim dlgRes As Integer
        Dim lstrAllReports() As String

        If pbooForceAnyReport = True Then
            RawCommTot = "FORCE"
        End If

        If RawCommTot <> "" Then
            If RawCommTot <> "FORCE" Then
                TotItems = Val(RawCommTot)

                ReDim Arr(TotItems)

                For lintArrInc = 0 To TotItems
                    Arr(lintArrInc) = CType(myBaseItem.GetValue("comm" + CStr(lintArrInc)), String)
                Next lintArrInc

                For lintArrInc = 0 To Arr.GetUpperBound(0)
                    str = str + Arr(lintArrInc) + ChrGet(10)
                Next lintArrInc

                AddDebugComment("<Font color=Blue>--- Crash Dump ---</font>")
                AddDebugComment(str)
                AddDebugComment("<Font color=Blue>--- Crash Dump ---</font>")
            End If

            If pbooQuiet = False Then

                'dlgRes = MessageBox.Show("At some point the program has created a problem report." + CR() + CR() + _
                '    "Please send us this report!", NameMe(""))

                pSplashScreen.ShowInTaskbar = True 
                pSplashScreen.Icon = New System.Drawing.Icon( _
                                    System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico")) 

                dlgRes = MessageBox.Show(LangText.GetString("Main_AtSomePoint").Replace("[CR2]", Environment.NewLine & _
                    Environment.NewLine), NameMe("")) 

                AddExtraDebugInfo()

                Dim ErrRep As New ProbHand.BugReport(gbooAlwaysOnTop)
                With ErrRep
                    .SysStartTime = gdatSystemStart
                    .Caption = NameMe("")
                    .FormIcon = New System.Drawing.Icon( _
                        System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico"))
                    Application.DoEvents()
                    .ShowDialog()
                End With


                pSplashScreen.ShowInTaskbar = False 

                LoadReportsNames(lstrAllReports)
                DumpThisErrorLog(NameMe(""), lstrAllReports, gdatSystemStart)
                ClearCrashReport()


            End If
        End If

    End Sub
    Friend Sub AddExtraDebugInfo()
        'added 
    End Sub
    Private Function containsKey(ByVal coll As Microsoft.VisualBasic.Collection, ByVal str As String) As Boolean
        Dim collKey As TreeNode
        Dim i As Integer
        For i = 1 To coll.Count
            collKey = coll.Item(i)
            If collKey.Tag = str Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
