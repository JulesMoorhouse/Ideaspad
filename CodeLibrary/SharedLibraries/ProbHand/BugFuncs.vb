Imports System.Collections
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Imports System.Xml
Public Module BugFuncs
    Friend DebugComment As New Queue()
    Dim mInitialBookmarks As InitalXMLConfig
    Public mbooLimitReportSize As Boolean = True 
    Public Function AddDebugComment(ByVal Comment As String)

        Comment = Comment.Replace(Environment.NewLine, "<BR>") 
        Comment = Comment.Replace(ChrGet(10), "<BR>") 
        Comment = Comment.Replace(ChrGet(12), "<BR>") 

        Dim Line As String = "<tr><td nowrap>" & Date.Now.ToString(System.Globalization.CultureInfo.InvariantCulture) & "</td><td>" & Comment & "</td></tr>"

        DebugComment.Enqueue(Line)

        If mbooLimitReportSize = True Then 
            If DebugComment.Count >= 51 Then
                DebugComment.Dequeue()
            End If
        End If 

    End Function
    Friend Function ErrHeader(ByVal pstrCaption As String, ByVal pdatSysStartTime As Date) As String
        Dim lstrHeader As String = "<tr><td align=right><b>Product Desc:</b></td><td>" & pstrCaption & "</td></tr>"

        With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly.Location)
            
            Dim ProgFileModifiedDate As String = ""
            Try

                'ProgFileModifiedDate = " " & System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetEntryAssembly.Location).ToString("dd/MMM/yyyy HH:mm.ss") 
                
                ProgFileModifiedDate = " " & System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetEntryAssembly.Location).ToString(System.Globalization.CultureInfo.InvariantCulture)
            Catch : End Try
            
            lstrHeader &= "<tr><td align=right><b>Product:</b></td><td>" & .ProductName & " V" & .ProductVersion & _
                ProgFileModifiedDate & "</td></tr>"
        End With

        'lstrHeader &= "<tr><td align=right><b>Date/Time:</b></td><td>" & Date.Now.ToString("dd/MMM/yyyy HH:mm.ss") & "</td></tr>"
        
        lstrHeader &= "<tr><td align=right><b>Date/Time:</b></td><td>" & Date.Now.ToString(System.Globalization.CultureInfo.InvariantCulture) & "</td></tr>"
        'lstrHeader &= "<tr><td align=right><b>Error Info:</b></td><td>" & "Divide by zero etc" & "</td></tr>"
        'Ideaspad Language
        '
        

        'lstrHeader &= "<tr><td align=right><b>Sys Start:</b></td><td>" & pdatSysStartTime.ToString("dd/MMM/yyyy HH:mm.ss") & "</td></tr>"
        
        lstrHeader &= "<tr><td align=right><b>Sys Start:</b></td><td>" & pdatSysStartTime.ToString(System.Globalization.CultureInfo.InvariantCulture) & "</td></tr>"

        lstrHeader &= "<tr><td align=right><b>&nbsp;</b></td><td>&nbsp;</td></tr>"

        Return lstrHeader

    End Function
    Friend Function CombineLog(ByVal myCollection As IEnumerable) As String

        Dim myEnumerator As System.Collections.IEnumerator = _
           myCollection.GetEnumerator()
        While myEnumerator.MoveNext()
            CombineLog &= myEnumerator.Current
        End While

    End Function
    Public Function DumpThisErrorLog(ByVal pstrCaption As String, ByRef pstrAllReports() As String, ByVal pdatSysStartTime As Date)

        Dim lstrErrorDump As String
        Dim clsEnc As New MyCrypto()


        Dim lstrErrString = "<table border=1>" & ErrHeader(pstrCaption, pdatSysStartTime) & CombineLog(DebugComment) & _
            "</table>"

        lstrErrorDump = clsEnc.Encrypt(lstrErrString, "00F0FF000F")
        clsEnc = Nothing

        Dim ErrDir As String = System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetEntryAssembly.Location.ToString()) & "\ErrorDumps\"

        If Directory.Exists(ErrDir) = False Then
            Directory.CreateDirectory(ErrDir)
        End If

        Dim lstrEncFile As String = Date.Now.ToString("dddd-dd-MMM-yyyy-HH-mm-ss") & ".dat"

        Dim lintFreeFile As Integer = Microsoft.VisualBasic.FreeFile()
        Microsoft.VisualBasic.FileOpen(lintFreeFile, ErrDir & lstrEncFile, Microsoft.VisualBasic.OpenMode.Output)
        Microsoft.VisualBasic.Print(lintFreeFile, lstrErrorDump)
        Microsoft.VisualBasic.FileClose(lintFreeFile)

        'Write a link to the error file in your DAT ini file
        If pstrAllReports.GetUpperBound(0) = 0 And pstrAllReports(0) = "" Then
            '
        Else
            ReDim Preserve pstrAllReports(pstrAllReports.GetUpperBound(0) + 1)
        End If

        pstrAllReports(pstrAllReports.GetUpperBound(0)) = lstrEncFile

        SaveReportNames(False, pstrAllReports)

    End Function
    Public Sub LoadReportsNames(ByRef pstrAllReports() As String)

        Dim DebugReports As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.DebugReports)
        Dim intDebugReports As Integer = Val(DebugReports.GetValue("ItemCount", "-1"))
        Dim lintArrInc As Integer
        If intDebugReports = -1 Then
            ReDim pstrAllReports(0)
        Else

            ReDim pstrAllReports(intDebugReports)

            For lintArrInc = 0 To intDebugReports
                pstrAllReports(lintArrInc) = DebugReports.GetValue("Report" & lintArrInc, "")
            Next lintArrInc
        End If

    End Sub
    Friend Sub SaveReportNames(ByVal pbooClear As Boolean, ByRef pstrAllReports() As String)
        Dim lintTrueRepCount As Integer = -1

        If pstrAllReports.GetUpperBound(0) = 0 And pstrAllReports(0) = "" Then
            Exit Sub
        End If
        Dim xDoc As New XmlDocument()
        Dim ConfigFile As String = System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat"
        xDoc.Load(ConfigFile)

        Dim lintArrInc As Integer

        With mInitialBookmarks
            'Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", "-1")))
            For lintArrInc = 0 To pstrAllReports.GetUpperBound(0)
                'If mInitialBookmarks.GetValue("Report" & lintArrInc, "") Is Obj And Not Obj Is Nothing Then

                If pbooClear = False Then
                    If pstrAllReports(lintArrInc) <> "" Then
                        BatchXMLItemWrite(xDoc, GetSectionString(InitalXMLConfig.XmlConfigType.DebugReports, ""), "Report" & lintArrInc, pstrAllReports(lintArrInc))
                        lintTrueRepCount += 1
                    End If
                Else
                    BatchXMLItemWrite(xDoc, GetSectionString(InitalXMLConfig.XmlConfigType.DebugReports, ""), "Report" & lintArrInc, "")
                End If
                'BatchXMLItemWrite(xDoc, GetSectionString(mXMLConfigType, ""), mstrBookMarkRefTag & lintArrInc, txtBookmarkName.Tag)
                'BatchXMLItemWrite(xDoc, GetSectionString(mXMLConfigType, ""), mstrBookMarkImgIdxTag & lintArrInc, lblIconSelect.ImageIndex)


                'End If
            Next lintArrInc
        End With

        BatchXMLItemWrite(xDoc, GetSectionString(InitalXMLConfig.XmlConfigType.DebugReports, ""), "ItemCount", lintTrueRepCount)

        xDoc.Save(ConfigFile)
        xDoc = Nothing


    End Sub
    ''Friend Function StrToHex(ByVal strString As String) As String
    ''    'you can comment this function out it has been added to appbasic, just need to compile it 
    ''    Dim char1() As Char = strString.ToCharArray
    ''    Dim sresult As String

    ''    Dim lintArrInc As Integer
    ''    For lintArrInc = 0 To strString.Length - 1
    ''        sresult &= Convert.ToInt32(char1(lintArrInc)).ToString("x")
    ''    Next lintArrInc
    ''    Return sresult

    ''End Function
End Module
Friend Class MyCrypto
    ' declare crypto service provider 
    'someday the class will be able to use DES TripelDES and RijndaelManaged 
    Private myCryptoService As New RijndaelManaged()
    'create the key 
    Private Function GetLegalKey(ByVal key As String) As Byte()
        Dim sTemp As String

        If myCryptoService.LegalKeySizes.Length > 0 Then
            Dim lessSize As Integer = 0
            Dim moreSize = myCryptoService.LegalKeySizes(0).MinSize

            While key.Length * 8 > moreSize
                lessSize = moreSize
                moreSize += myCryptoService.LegalKeySizes(0).SkipSize
            End While
            sTemp = key.PadRight(moreSize / 8, " ")
        Else
            sTemp = key
        End If
        Return ASCIIEncoding.ASCII.GetBytes(sTemp)
    End Function
    Friend Function Decrypt(ByVal vText As String, ByVal vkey As String) As String
        Try
            Dim msin As New System.IO.MemoryStream()
            Try
                msin.Write(Convert.FromBase64String(vText), 0, Convert.FromBase64String(vText).Length)
            Catch
                Return "Error Processing Request!"
            End Try
            msin.Position = 0

            Dim msout As New System.IO.MemoryStream()
            Dim buf() As Byte = New Byte(4096) {}
            Dim byteKey() As Byte = GetLegalKey(vkey)
            myCryptoService.Key = byteKey
            myCryptoService.IV = byteKey

            Dim trans As ICryptoTransform = myCryptoService.CreateDecryptor()
            Dim cs As CryptoStream = New CryptoStream(msin, trans, CryptoStreamMode.Read)
            Dim nLen As Integer
            nLen = cs.Read(buf, 0, buf.Length)
            While (nLen > 0)
                msout.Write(buf, 0, nLen)
                nLen = cs.Read(buf, 0, buf.Length)
            End While

            Decrypt = System.Text.Encoding.Default.GetString(msout.ToArray)

            msin.Close()
            msout.Close()
        Catch e As CryptographicException
            Return "Error Processing Request!"
        End Try
    End Function
    Friend Function Encrypt(ByVal vText As String, ByVal vKey As String) As String
        Try
            Dim msin As New System.IO.MemoryStream()
            msin.Write(System.Text.Encoding.Default.GetBytes(vText), 0, System.Text.Encoding.Default.GetBytes(vText).Length)
            msin.Position = 0

            Dim msout As New System.IO.MemoryStream()
            Dim buf() As Byte = New Byte(4096) {}
            Dim byteKey() As Byte = GetLegalKey(vKey)
            myCryptoService.Key = byteKey
            myCryptoService.IV = byteKey

            Dim trans As ICryptoTransform = myCryptoService.CreateEncryptor()
            Dim cs As CryptoStream = New CryptoStream(msout, trans, CryptoStreamMode.Write)
            Dim nLen As Integer

            nLen = msin.Read(buf, 0, buf.Length)

            While (nLen > 0)
                cs.Write(buf, 0, nLen)
                nLen = msin.Read(buf, 0, buf.Length)
            End While

            cs.FlushFinalBlock()

            Encrypt = System.Convert.ToBase64String(msout.ToArray)

            cs.Close()
            msin.Close()
        Catch e As CryptographicException
            Return e.Message & "Error Processing Request!"
        End Try
    End Function
End Class