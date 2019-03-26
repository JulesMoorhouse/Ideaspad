Imports System.Drawing.Imaging

Friend Module TableEditorFuncs
    Friend Function SetTableTranslations() As System.Collections.Specialized.StringDictionary
        'easy swap out function for my main program
        AddDebugComment("TableEditorFuncs.SetTableTranslations - start") 
        ' Translations
        Dim table As New System.Collections.Specialized.StringDictionary()

        ' Property grid
        table.Add("fontname", "Font")
        table.Add("fontdescription", "The font used in the text")
        table.Add("textname", "Text")
        table.Add("textdescription", "The text of the cell")
        table.Add("rowspanname", "Row span")
        table.Add("rowspandescription", "The row span")
        table.Add("colspanname", "Col span")
        table.Add("colspandescription", "The col span")
        table.Add("bgcolorname", "Background color")
        table.Add("bgcolordescription", "The color of the background")
        table.Add("bordercolorname", "Border color")
        table.Add("bordercolordescription", "The color of the border")
        table.Add("textcolorname", "Text color")
        table.Add("textcolordescription", "The color of the text")
        table.Add("textalignname", "Text alignment")
        table.Add("textaligndescription", "The alignment of the text")
        table.Add("bgimagename", "Background image")
        table.Add("bgimagedescription", "An image to display as background")
        table.Add("tablebgcolorname", "Background color")
        table.Add("tablebgcolordescription", "The background color of the table")
        table.Add("cellspacingname", "Cell spacing")
        table.Add("cellspacingdescription", "The cell spacing")
        table.Add("cellpaddingname", "Cell padding")
        table.Add("cellpaddingdescription", "The cell padding")
        table.Add("cellpaddingcolorname", "Cell padding color")
        table.Add("cellpaddingcolordescription", "The color used for the space left by the cell padding")
        table.Add("bordersizename", "Border size")
        table.Add("bordersizedescription", "The size of the border")


        table.Add("tabledefaultcellfontname", "Default font")
        table.Add("tabledefaultcellfontdescription", "The default font for the cells of the table")
        table.Add("tabledefaulttextcolorname", "Default text color")
        table.Add("tabledefaulttextcolordescription", "The default text color for the cells of the table")
        table.Add("tabledefaultcellcolorname", "Default background color")
        table.Add("tabledefaultcellcolordescription", "The default background color for the cells of the table")
        table.Add("exteriorbordersizename", "Exterior border size")
        table.Add("exteriorbordersizedescription", "The size of the space left outside the table")

        table.Add("shadowdistancename", "Shadow distance")
        table.Add("shadowdistancedescription", "The distance of the shadow to the the table")
        table.Add("shadowcolorname", "Shadow color")
        table.Add("shadowcolordescription", "The color of the shadow")

        ' Dimensions dialog
        table.Add("rownumber", "Rows:")
        table.Add("columnnumber", "Columns:")

        ' Buttons
        table.Add("buttonok", "OK")
        table.Add("buttoncancel", "Cancel")
        table.Add("buttonadvanced", "Advanced")
        table.Add("buttonbasic", "Basic")
        table.Add("buttonhelp", "Help")

        ' Menu items
        table.Add("menuaddrow", "Add row")
        table.Add("menuaddcolumn", "Add column")
        table.Add("menuremoverow", "Remove row")
        table.Add("menuremovecolumn", "Remove column")
        table.Add("menuedit", "Edit")
        table.Add("menusplit", "Split")
        table.Add("menuproperties", "Properties")

        ' Form titles
        table.Add("formdefinetable", "Define table")
        table.Add("formsplit", "Split")
        table.Add("formeditor", "Table editor")

        ' Other form texts
        table.Add("tabledimensions", "Table dimensions")
        table.Add("invalidcolor", "The value {0} is not valid for a color")
        table.Add("invalidnumber", "The value {0} is not valid for a positive integer")

        table.Add("advancedproperties", "Advanced properties")

        ' End of translations
        AddDebugComment("TableEditorFuncs.SetTableTranslations - end") 
        Return table

    End Function
    Friend Function UpdateTableDetailsRec(ByVal pintTID As Long, ByVal pstrTopicCode As String, _
        ByVal pstrInstructs As String, ByVal pstrHumanRead As String)

        AddDebugComment("TableEditorFuncs.UpdateTableDetailsRec - start") 

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)


        With lsnaLists
            .CursorType = ADODB.CursorTypeEnum.adOpenKeyset
            .LockType = ADODB.LockTypeEnum.adLockOptimistic

            Dim lstrSQL As String = "SELECT * FROM TableDetails WHERE TID='" & pintTID & "';"

            gstrLastSQL = lstrSQL
            .Open(lstrSQL, lcnn1)

            If Not .EOF Then

                lsnaLists("Instructs").Value = pstrInstructs
                lsnaLists("HumanRText").Value = pstrHumanRead

                lsnaLists("TopicCode").Value = pstrTopicCode
                .Update()
            End If

            lsnaLists.Close()
            lcnn1.Close()
        End With

        AddDebugComment("TableEditorFuncs.UpdateTableDetailsRec - end") 

    End Function
    Friend Function GetTabeDetailRec(ByVal pintTID As Long) As String

        AddDebugComment("TableEditorFuncs.GetTabeDetailRec - start") 

        GetTabeDetailRec = "NONE"

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        lsnaLists.CursorType = ADODB.CursorTypeEnum.adOpenStatic

        Dim lstrSQL As String = "SELECT * FROM TableDetails WHERE TID='" & pintTID & "';"
        gstrLastSQL = lstrSQL

        lsnaLists.Open(lstrSQL, lcnn1)

        If Not lsnaLists.EOF Then
            GetTabeDetailRec = lsnaLists("Instructs").Value
            lsnaLists.Close()
        End If
        lcnn1.Close()

        AddDebugComment("TableEditorFuncs.GetTabeDetailRec - end") 

    End Function
    Friend Function GetNextTID() As Long

        AddDebugComment("TableEditorFuncs.GetNextTID - start") 

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        Dim lstrSQL As String = "SELECT max(TID) as CountOfTID  from TableDetails;"

        gstrLastSQL = lstrSQL

        lsnaLists.Open(lstrSQL, _
            lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        With lsnaLists
            If Not .EOF Then
                If .Fields("CountOfTID").Value & "" = "" Then
                    GetNextTID = 1
                Else
                    GetNextTID = CLng(.Fields("CountOfTID").Value) + 1
                End If
            End If
        End With

        lsnaLists.Close()
        lcnn1.Close()

        AddDebugComment("TableEditorFuncs.GetNextTID - end") 

    End Function
    Friend Sub AddNewTableDetailsRec(ByVal pintTID As Long, ByVal pstrTopicCode As String, _
        ByVal pstrInstructs As String, ByVal pstrHumanRead As String)

        AddDebugComment("TableEditorFuncs.AddNewTableDetailsRec - start") 

        Dim lcnn1 As New ADODB.Connection()
        Dim lstrSQL As String

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        lstrSQL = "INSERT INTO TableDetails ( TID, TopicCode, Instructs, HumanRText ) Values('" & pintTID & _
            "','" & pstrTopicCode & "','" & pstrInstructs & "','" & pstrHumanRead & "');"

        gstrLastSQL = lstrSQL

        lcnn1.Execute(lstrSQL)
        lcnn1.Close()

        AddDebugComment("TableEditorFuncs.AddNewTableDetailsRec - end") 

    End Sub
    Friend Sub SetBasicTableEditorProperties(ByVal ptbe As TableEditor.MainTableEditor, ByVal pRTB As WinOnly.ExRichTextBox)

        AddDebugComment("TableEditorFuncs.SetBasicTableEditorProperties - start") 

        With ptbe
            '.ImagesFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            .DefaultCellFont = pRTB.SelectionFont '  New Font("Arial", 12)
            .DefaultCellTextColor = pRTB.SelectionColor ' Me.ForeColor
            .Width = 700
            '.PropertyGridWidth = 200
            .Height = 400
            .SetPropertyGridColumnWidth(130, 130) 

            MessageBox.Show("TODO: Set German values for table dialog descptions!")
            .Translations = SetTableTranslations()
            .AlwaysOnTop = gbooAlwaysOnTop 
            .Icon = New System.Drawing.Icon( _
                System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico")) 
        End With

        AddDebugComment("TableEditorFuncs.SetBasicTableEditorProperties - end") 

    End Sub
    Friend Function GetIDFromMetafile(ByVal pGetImg As GetRTBImage, ByVal pWidth As Integer, ByVal pHeight As Integer) As Long

        AddDebugComment("TableEditorFuncs.GetIDFromMetafile - start") 

        Try
            Dim bitmaps As New IO.MemoryStream()
            pGetImg.Pictures(1).Save(bitmaps, System.Drawing.Imaging.ImageFormat.Bmp)
            Dim bitmapimg As Bitmap = New Bitmap(bitmaps)

            Dim bm_dest As New Bitmap(pWidth, pHeight)

            ' Make a Graphics object for the result Bitmap.
            Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
            'gr_dest.SmoothingMode = Drawing2D.SmoothingMode.None
            gr_dest.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor

            ' Copy the source image into the destination bitmap.
            gr_dest.DrawImage(bitmapimg, 0, 0, _
                bm_dest.Width, _
                bm_dest.Height)

            AddDebugComment("TableEditorFuncs.GetIDFromMetafile - middle") 

            Dim ret As String = TableEditor.MainTableEditor.GetIdFromImage(bm_dest) 
            
            If LeftGet(ret, 1) = "T" Then
                ret = RightGet(ret, ret.Length - 1)
            ElseIf LeftGet(ret, 1) = "G" Then
                ret = RightGet(ret, ret.Length - 1)
            End If
            
            Return ret

        Catch ex As ArgumentException
            If InStrGet(ex.Message, "Parameter is not valid") > 0 Then
                MessageBox.Show("This is a known problem on 64bit Computers, please contact us for a special 64bit build!")
                AddDebugComment("TableEditorFuncs.GetIDFromMetafile - 64bit") 
                Return "-1"
            End If
        End Try

        AddDebugComment("TableEditorFuncs.GetIDFromMetafile - end") 

    End Function

    Friend Function GetImageIDForCurrentRTFSelection(ByVal pRTB As WinOnly.ExRichTextBox) As Long

        AddDebugComment("TableEditorFuncs.GetImageIDForCurrentRTFSelection - start") 

        Dim picWidth As Integer
        Dim picHeight As Integer
        Dim GetImg As New GetRTBImage()
        GetImg.FindMetafiles(pRTB, picWidth, picHeight)
        If GetImg.Pictures Is Nothing Then
            Return -1
        ElseIf GetImg.Pictures.Length > 0 Then
            AddDebugComment("TableEditorFuncs.GetImageIDForCurrentRTFSelection - middle1") 
            Return GetIDFromMetafile(GetImg, picWidth, picHeight)
        Else
            AddDebugComment("TableEditorFuncs.GetImageIDForCurrentRTFSelection - middle2") 
            Return -1
        End If

        AddDebugComment("TableEditorFuncs.GetImageIDForCurrentRTFSelection - end") 

    End Function
    Friend Function IfRTFImage(ByVal pRTB As WinOnly.ExRichTextBox) As Boolean

        If pRTB.SelectedRtf.IndexOf("\pict") <> -1 And pRTB.SelectionType = RichTextBoxSelectionTypes.Object Then
            Return True
        Else
            Return False
        End If

    End Function
End Module
Friend Class GetRTBImage

    Private Declare Function SetEnhMetaFileBits Lib "gdi32" (ByVal cbBuffer As Integer, ByRef lpData As Byte) As IntPtr
    Private Declare Function SetWinMetaFileBits Lib "gdi32" (ByVal cbBuffer As Integer, ByRef lpbBuffer As Byte, ByVal hDCRef As IntPtr, ByRef lpmfp As METAFILEPICT) As IntPtr

    Private Structure METAFILEPICT
        Dim mm As Integer
        Dim xExt As Integer
        Dim yExt As Integer
        Dim hMF As Integer
    End Structure

    Private HexString As String
    Private Buffer(1) As Byte
    Friend Pictures() As Metafile

    Friend Sub FindMetafiles(ByVal pRTB As WinOnly.ExRichTextBox, ByRef TrueWidth As Integer, ByRef TrueHeight As Integer)

        AddDebugComment("GetRTBImage.FindMetafiles - start") 

        Dim plaatje, BoxCopy, Properties As String
        Dim i, n, m, StartCode, StartofImage, EndofImage As Long
        Dim FoundBegin, FoundEnd As Boolean
        Dim number As Int32 = 0
        Dim xnorm, ynorm, xgoal, ygoal, mmtype As Integer

        FoundBegin = False
        FoundEnd = False

        'Find the Pics and save them to Metafile array:

        'BoxCopy = RichTextBox1.Rtf
        BoxCopy = pRTB.SelectedRtf

        Try
            For n = 0 To BoxCopy.Length - 1 '- 7
                ' Console.WriteLine(n & " / " & BoxCopy.Length)
                ' Try
                If FoundBegin = False And FoundEnd = False Then
                    If BoxCopy.Substring(n, 6) = "{\pict" Then
                        StartofImage = n
                        FoundBegin = True
                    End If
                End If

                '
                If FoundBegin = True Then
                    If BoxCopy.Substring(n, 1) = "}" Then
                        EndofImage = n - 2
                        'n = BoxCopy.Length
                        FoundEnd = True
                    End If
                End If
                ' Catch ex As Exception
                '    Throw ex
                '  End Try


                'Execute the piece if the beginning({\pic) and the end (}) of the image is found
                If FoundBegin = True And FoundEnd = True Then
                    FoundEnd = False
                    FoundBegin = False
                    number += 1
                    ReDim Preserve Pictures(number)
                    '
                    'Find beginning of Hex code of picture; this might give problems if the image properties are more than one line!!
                    StartCode = StartofImage
                    For m = StartofImage To StartofImage + 200 'max(?) of preferences of picture (e.g. \pichgoal)
                        If BoxCopy.Substring(m, 1).GetHashCode = 177583 Then
                            StartCode = m + 1
                            m = StartofImage + 200
                        End If
                    Next
                    '
                    'We now can cut off the hexcode to process it further
                    HexString = BoxCopy.Substring(StartCode, EndofImage - StartCode)
                    '
                    'We also need the properties of the image (\picxgoal...etc) so:
                    Properties = BoxCopy.Substring(StartofImage, StartCode - StartofImage) & "             "  'Add this extra spaces (>=10) as 'safety' zone so the
                    '
                    'Now try to extract the image sizes and mmtype:
                    For m = 0 To Properties.Length - 10 'This -10 is for preventing error when string is at end and the program checks for "\wmetafile"
                        If Properties.Substring(m, 10) = "\wmetafile" Then
                            mmtype = Val(Properties.Substring(m + 10, 1))
                            'MsgBox("mmtype: " & mmtype)

                        ElseIf Properties.Substring(m, 5) = "\picw" And Not Properties.Substring(m, 9) = "\picwgoal" Then
                            xnorm = Val(Properties.Substring(m + 5, 4))     'Warning: I assume here that the number is 4 digits long (xxxx),.. this goes wrong with 1,2,3,,5,6.. digits!!
                            'MsgBox("xnorm: " & xnorm)

                        ElseIf Properties.Substring(m, 5) = "\pich" And Not Properties.Substring(m, 9) = "\pichgoal" Then
                            ynorm = Val(Properties.Substring(m + 5, 4))     'Warning: I assume here that the number is 4 digits long (xxxx),.. this goes wrong with 1,2,3,,5,6.. digits!
                            'MsgBox("ynorm: " & ynorm)

                        ElseIf Properties.Substring(m, 9) = "\picwgoal" Then
                            xgoal = Val(Properties.Substring(m + 9, 4))     'Warning: I assume here that the number is 4 digits long (xxxx),.. this goes wrong with 1,2,3,,5,6.. digits!
                            'MsgBox("xgoal: " & xgoal)
                            TrueWidth = xgoal / 15 

                        ElseIf Properties.Substring(m, 9) = "\pichgoal" Then
                            ygoal = Val(Properties.Substring(m + 9, 4))     'Warning: I assume here that the number is 4 digits long (xxxx),.. this goes wrong with 1,2,3,,5,6.. digits!
                            'MsgBox("ygoal: " & ygoal)
                            TrueHeight = ygoal / 15

                        End If
                    Next
                    '
                    RemoveCrLr()
                    CopyIntoBuffer()
                    Pictures(number) = paint_it(Buffer, mmtype, xgoal, ygoal)
                    Exit For
                End If
                '
            Next

        Catch

        End Try

        '  Microsoft.VisualBasic.MsgBox("here")

        ' Microsoft.VisualBasic.MsgBox("Number of pictures found: " & number)

        AddDebugComment("GetRTBImage.FindMetafiles - end") 

    End Sub

    Sub RemoveCrLr()
        HexString = HexString.Replace(Microsoft.VisualBasic.Constants.vbCrLf, "")
    End Sub

    Private Sub CopyIntoBuffer()
        Dim i As Integer
        Dim intArraySize As Integer = CInt((Microsoft.VisualBasic.Len(HexString) + 1) / 2) - 1
        ReDim Buffer(intArraySize)
        For i = 0 To intArraySize
            Buffer(i) = "&H" & Microsoft.VisualBasic.Mid(HexString, i * 2 + 1, 2)
        Next i
    End Sub

    Private Function paint_it(ByVal bufferimage() As Byte, _
                      ByVal mtype As Integer, _
                      ByVal p_x As Integer, _
                      ByVal p_y As Integer) As Metafile

        AddDebugComment("GetRTBImage.paint_it - start") 

        Dim lengte As Integer = bufferimage.Length
        Dim pointer As IntPtr

        Dim _metaFile As METAFILEPICT

        _metaFile.mm = mtype
        '_metaFile.xExt = p_x
        '_metaFile.yExt = p_y
        _metaFile.xExt = p_x * 10 
        _metaFile.yExt = p_y * 10 

        Dim _hEmf As IntPtr

        pointer = SetWinMetaFileBits(lengte, bufferimage(0), _hEmf, _metaFile)

        paint_it = New Imaging.Metafile(pointer, True)

        AddDebugComment("GetRTBImage.paint_it - end") 

    End Function
End Class
