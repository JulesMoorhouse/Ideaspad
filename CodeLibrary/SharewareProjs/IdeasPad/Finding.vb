Friend Class Finding
    Friend Function TitleSearch(ByVal pTreeview As TreeView, ByVal SearchString As String)
        'Foremely RtfSearch
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim llngRecCount As Long
        Dim lstrSQL As String

        If SearchString.Length = 0 Then
            pTreeview.Nodes.Clear()
            Exit Function
        End If

        Try
            pTreeview.BeginUpdate()
            pTreeview.Nodes.Clear()

            lcnn1 = New ADODB.Connection()
            lcnn1.Open(gstrConnectionString)

            lstrSQL = "SELECT TopicCode AS tc, Title, ImgIdx FROM Topics WHERE (((Title) Like '%" & SearchString & "%'));"
            gstrLastSQL = lstrSQL 

            lsnaLists.Open(lstrSQL, _
                lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            With lsnaLists
                llngRecCount = 0
                Do While Not .EOF

                    Dim tnNew As New TreeNode()
                    tnNew.Text = .Fields("Title").Value & ""
                    tnNew.Tag = .Fields("tc").Value & ""

                    'the Field ImgIdx is now used as a tag to the true index stored in the icon dll
                    'Tag is in the DB e.g. Simpson03, the Idx of the image list is used on screen
                    Dim lintImgIdx As Integer = IPIconsPack.GetImgIdx(.Fields("ImgIdx").Value)
                    tnNew.ImageIndex = lintImgIdx
                    tnNew.SelectedImageIndex = lintImgIdx

                    pTreeview.Nodes.Add(tnNew)

                    .MoveNext()
                Loop
            End With

            If llngRecCount = 0 Then
            End If

            lsnaLists.Close()
            lcnn1.Close()

            pTreeview.EndUpdate()

        Catch ex As Exception
            Try : lsnaLists.Close() : Catch ex1 As Exception : End Try
            Try : lcnn1.Close() : Catch ex2 As Exception : End Try
        End Try
    End Function
    Friend Function DetailsSearch(ByVal pTreeview As TreeView, ByVal pProgressBar As Object, ByVal SearchString As String)
        'Foremely TemplateSearch
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String
        Dim strChunk As String = ""
        Dim Offset As Long
        Dim Totalsize As Long
        Dim ChunkSize As Long
        Dim lintByteLength As Integer

        If SearchString.Length = 0 Then
            Exit Function
        End If

        Try

            pTreeview.BeginUpdate()

            lcnn1 = New ADODB.Connection()
            lcnn1.Open(gstrConnectionString)

            'lstrSQL = "SELECT Topics.TopicCode AS tc, Title, ImgIdx, ByteLen, Detail FROM Topics, TopicDetail WHERE " & _
            '    "(((TopicDetail.ByteLen)<>-1) AND ((TopicDetail.TemplateID)='') AND " & _
            '    "((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics]" & _
            '    ".[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)));"
            
            'lstrSQL = "SELECT Topics.TopicCode AS tc, Title, ImgIdx, ByteLen, Detail FROM Topics, TopicDetail WHERE " & _
            '    "(((TopicDetail.ByteLen)=-1) AND ((TopicDetail.TemplateID)<>'') AND " & _
            '    "((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics]" & _
            '    ".[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)));"
            
            lstrSQL = "SELECT Topics.TopicCode AS tc, Title, ImgIdx, ByteLen, Detail FROM Topics, TopicDetail WHERE " & _
                "( " & _
                "((TopicDetail.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics]" & _
                ".[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)));"
            gstrLastSQL = lstrSQL 

            lsnaLists.Open(lstrSQL, _
                lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            pProgressBar.Maximum = lsnaLists.RecordCount
            Dim lintTimer As Date = Date.Now

            Dim TempRTB As New RichTextBox() 

            With lsnaLists
                Do While Not .EOF

                    If DateDiffGet(strman.DateInterval.Second, lintTimer, Date.Now) > 2 Then
                        Application.DoEvents()
                        lintTimer = Date.Now
                    End If
                    If gintThreadEnd = 1 Then
                        Exit Do
                    End If
                    ChunkSize = 1000
                    Offset = 0
                    Totalsize = lsnaLists("Detail").ActualSize
                    lintByteLength = lsnaLists("ByteLen").Value

                    Do While Offset < Totalsize
                        strChunk = strChunk + lsnaLists("Detail").GetChunk(ChunkSize)
                        Offset = Offset + ChunkSize
                    Loop

                    If strChunk <> " " Then
                        Try
                            If lintByteLength <> -1 And strChunk <> "" Then
                                AddDebugComment("Inflate")
                                Dim InfDef As New InflateDeflate()
                                strChunk = InfDef.Inflate(strChunk, lintByteLength)
                                lintByteLength = -1
                                
                                Try
                                    TempRTB.Rtf = strChunk
                                    strChunk = TempRTB.Text
                                Catch
                                    '
                                End Try
                                
                            End If

                            If InStrGet(strChunk.ToUpper, SearchString.ToUpper) > 0 Then
                                Dim tnNew As New TreeNode()
                                tnNew.Text = .Fields("Title").Value & ""
                                tnNew.Tag = .Fields("tc").Value & ""

                                Dim lintImgIdx As Integer = IPIconsPack.GetImgIdx(.Fields("ImgIdx").Value)
                                tnNew.ImageIndex = lintImgIdx
                                tnNew.SelectedImageIndex = lintImgIdx

                                pTreeview.Nodes.Add(tnNew)
                            End If
                            strChunk = ""
                        Catch

                        End Try
                    End If

                    pProgressBar.Value += 1
                    .MoveNext()
                Loop
            End With

            pProgressBar.Value = 0

            lsnaLists.Close()
            lcnn1.Close()

            pTreeview.EndUpdate()

        Catch ex As Exception
            Try : lsnaLists.Close() : Catch ex1 As Exception : End Try
            Try : lcnn1.Close() : Catch ex2 As Exception : End Try
        End Try

    End Function
    Friend Function TableHumanStringSearch(ByVal pTreeview As TreeView, ByVal pProgressBar As Object, ByVal SearchString As String)
        
        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String
        Dim HumanReadStr As String = ""

        If SearchString.Length = 0 Then
            Exit Function
        End If

        Try

            pTreeview.BeginUpdate()

            lcnn1 = New ADODB.Connection()
            lcnn1.Open(gstrConnectionString)

            lstrSQL = "SELECT Topics.TopicCode AS tc, Title, ImgIdx, HumanRText FROM Topics, TableDetails WHERE " & _
              "( " & _
              "((TableDetails.TopicCode)=Mid([Topics].[TopicCode],InStr(1,[Topics].[TopicCode],'T'),Len([Topics]" & _
              ".[TopicCode])-InStr(1,[Topics].[TopicCode],'T')+1)));"
            gstrLastSQL = lstrSQL

            lsnaLists.Open(lstrSQL, _
                lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            pProgressBar.Maximum = lsnaLists.RecordCount
            Dim lintTimer As Date = Date.Now

            Dim TempRTB As New RichTextBox()

            With lsnaLists
                Do While Not .EOF

                    If DateDiffGet(strman.DateInterval.Second, lintTimer, Date.Now) > 2 Then
                        Application.DoEvents()
                        lintTimer = Date.Now
                    End If
                    If gintThreadEnd = 1 Then
                        Exit Do
                    End If
 
                    HumanReadStr = lsnaLists("HumanRText").Value & ""

                    If HumanReadStr <> "" Then
                        Try
                            If InStrGet(HumanReadStr.ToUpper, SearchString.ToUpper) > 0 Then
                                Dim tnNew As New TreeNode()
                                tnNew.Text = .Fields("Title").Value & ""
                                tnNew.Tag = .Fields("tc").Value & ""

                                Dim lintImgIdx As Integer = IPIconsPack.GetImgIdx(.Fields("ImgIdx").Value)
                                tnNew.ImageIndex = lintImgIdx
                                tnNew.SelectedImageIndex = lintImgIdx

                                pTreeview.Nodes.Add(tnNew)
                            End If
                            HumanReadStr = ""
                        Catch

                        End Try
                    End If

                    pProgressBar.Value += 1
                    .MoveNext()
                Loop
            End With

            pProgressBar.Value = 0

            lsnaLists.Close()
            lcnn1.Close()

            pTreeview.EndUpdate()

        Catch ex As Exception
            Try : lsnaLists.Close() : Catch ex1 As Exception : End Try
            Try : lcnn1.Close() : Catch ex2 As Exception : End Try
        End Try

    End Function
End Class
