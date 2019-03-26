Imports System.IO

Friend Module FlameNoDB
    'added 
    Private A As String
    Private B As String
    Private C As String
    Private D As String
    Private E As String
    Private Const f As String = "ffe"
    Private fileStr As String = Application.StartupPath & "\uninstall01.dat"
    Private Sub SaveCodes(ByRef pstrProbComtStack As String)
        'ByRef pstrProbComtStack As String added 

        ' A = 1 : B = 2 : C = 3 : D = 4 : E = 5

        pstrProbComtStack &= " #SC1" 
        Dim clsEnc As New MyCrypto()
        Dim lstrTemp As String

        Dim Code As String
        pstrProbComtStack &= " #SC2" 

        Code = f & A & f & B & f & C & f & D & f & E & f

        lstrTemp = clsEnc.Encrypt(Code, "password")
        pstrProbComtStack &= " #SC3" 
        clsEnc = Nothing

        Try : File.Delete(fileStr) : Catch : End Try
        pstrProbComtStack &= " #SC4" 
        Application.DoEvents() 

        Try
            If File.Exists(fileStr) = True Then
                pstrProbComtStack &= " #SC4-ExTrue" 

                Dim fa As FileAttributes 
                fa = File.GetAttributes(fileStr) 
                If fa = FileAttributes.ReadOnly Then
                    pstrProbComtStack &= " #SC4-RoTrue" 
                Else
                    pstrProbComtStack &= " #SC4-RoTrue" 
                End If
                If fa = FileAttributes.Normal Then
                    pstrProbComtStack &= " #SC4-NoTrue" 
                Else
                    pstrProbComtStack &= " #SC4-NoTrue" 
                End If

            Else
                pstrProbComtStack &= " #SC4-ExFalse" 
            End If
        Catch
            pstrProbComtStack &= " #SC4-ExFalse2" 
        End Try

        Dim OpenFile As FileStream = New FileStream(fileStr, FileMode.CreateNew, _
            FileAccess.Write, FileShare.Write)
        pstrProbComtStack &= " #SC7" 

        Dim StreamWriter As StreamWriter = New StreamWriter(OpenFile)
        pstrProbComtStack &= " #SC9" 

        StreamWriter.Write(lstrTemp)
        StreamWriter.Close()
        OpenFile.Close()
        pstrProbComtStack &= " #SC11" 

    End Sub
    Private Sub ClearCodes()
        A = "" : B = "" : C = "" : D = "" : E = ""
    End Sub
    Private Sub GetCodes(ByRef pstrProbComtStack As String)

        pstrProbComtStack &= " #GC1"
        ClearCodes()
        pstrProbComtStack &= " #GC2"
        If File.Exists(fileStr) = False Then
            
            Dim le As String = System.IO.Path.GetDirectoryName(System.Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\explorer.exe"
            pstrProbComtStack &= " #GC3"
            Dim lstrFieldValues(4) As FieldValues
            'With gstrDBFlamer

            Dim lstrNewFlamer As New flamer()
            pstrProbComtStack &= " #GC4"
            'set values

            'UKDateStr

            lstrNewFlamer.strSD = (GreatDateStr(Date.Now, pstrProbComtStack)) 'added UKDateStr 
            lstrNewFlamer.strLD = (GreatDateStr(Date.Now, pstrProbComtStack)) 'added UKDateStr  
            lstrNewFlamer.strED = (GreatDateStr(System.IO.File.GetLastAccessTime(le), pstrProbComtStack)) 'added UKDateStr  
            lstrNewFlamer.strHS = "01/01/2000 00:01:00"
            lstrNewFlamer.strLTD = (GreatDateStr(Date.Now, pstrProbComtStack)) 'added UKDateStr  
            pstrProbComtStack &= " #GC5"
            SetRealDates(lstrNewFlamer, True, pstrProbComtStack)
            pstrProbComtStack &= " #GC6"
            lstrFieldValues(0).pstrField = "A" : lstrFieldValues(0).pstrValue = lstrNewFlamer.strSD
            lstrFieldValues(1).pstrField = "B" : lstrFieldValues(1).pstrValue = lstrNewFlamer.strLD
            lstrFieldValues(2).pstrField = "C" : lstrFieldValues(2).pstrValue = lstrNewFlamer.strED
            lstrFieldValues(3).pstrField = "D" : lstrFieldValues(3).pstrValue = lstrNewFlamer.strHS
            lstrFieldValues(4).pstrField = "E" : lstrFieldValues(4).pstrValue = lstrNewFlamer.strLTD
            pstrProbComtStack &= " #GC7"
            SaveFieldValuesX(lstrFieldValues, pstrProbComtStack)
            pstrProbComtStack &= " #GC8"
            A = lstrNewFlamer.strSD
            B = lstrNewFlamer.strLD
            C = lstrNewFlamer.strED
            D = lstrNewFlamer.strHS
            E = lstrNewFlamer.strLTD
            pstrProbComtStack &= " #GC9"
            Exit Sub
            ' End With

            
        End If
        pstrProbComtStack &= " #GC10"
        Dim lstrFileStr As String = ""

        Dim OpenFile As FileStream = New FileStream(fileStr, FileMode.Open, _
            FileAccess.Read, FileShare.Read)
        Dim StreamReader As StreamReader = New StreamReader(OpenFile)
        lstrFileStr = StreamReader.ReadToEnd
        StreamReader.Close()
        OpenFile.Close()
        pstrProbComtStack &= " #GC11"
        Dim clsDec As New MyCrypto()
        Dim lstrTemp As String
        pstrProbComtStack &= " #GC12"
        lstrTemp = clsDec.Decrypt(lstrFileStr, "password")
        clsDec = Nothing
        pstrProbComtStack &= " #GC13"
        A = RightGet(ReturnNthStr(lstrTemp, 2, f), ReturnNthStr(lstrTemp, 2, f).Length - 2)
        B = RightGet(ReturnNthStr(lstrTemp, 3, f), ReturnNthStr(lstrTemp, 3, f).Length - 2)
        C = RightGet(ReturnNthStr(lstrTemp, 4, f), ReturnNthStr(lstrTemp, 4, f).Length - 2)
        D = RightGet(ReturnNthStr(lstrTemp, 5, f), ReturnNthStr(lstrTemp, 5, f).Length - 2)
        E = RightGet(ReturnNthStr(lstrTemp, 6, f), ReturnNthStr(lstrTemp, 6, f).Length - 2)
        pstrProbComtStack &= " #GC14"
        'MessageBox.Show("A=" + A + " " + CStr((A).Length) + " " + DeCodeCoverDate(A) + ChrGet(10) + _
        '    "B=" + B + " " + CStr((B).Length) + " " + DeCodeCoverDate(B) + ChrGet(10) + _
        '    "C=" + C + " " + CStr((C).Length) + " " + DeCodeCoverDate(C) + ChrGet(10) + _
        '    "D=" + D + " " + CStr((D).Length) + " " + DeCodeCoverDate(D) + ChrGet(10) + _
        '    "E=" + E + " " + CStr((E).Length) + " " + DeCodeCoverDate(E))

    End Sub
    Friend Function GetFieldValuesX(ByVal pstrField As String, ByRef pstrProbComtStack As String) As String

        GetCodes(pstrProbComtStack)

        Select Case pstrField
            Case "A" : If A <> "" Then GetFieldValuesX = A
            Case "B" : If B <> "" Then GetFieldValuesX = B
            Case "C" : If C <> "" Then GetFieldValuesX = C
            Case "D" : If D <> "" Then GetFieldValuesX = D
            Case "E" : If E <> "" Then GetFieldValuesX = E
        End Select

        ClearCodes()

    End Function
    Friend Sub SaveFieldValuesX(ByVal pstrValues() As FieldValues, ByRef pstrProbComtStack As String)


        Dim lintArrInc As Integer
        pstrProbComtStack &= " #SFVX1"
        For lintArrInc = 0 To pstrValues.GetUpperBound(0)
            Select Case pstrValues(lintArrInc).pstrField
                Case "A" : A = pstrValues(lintArrInc).pstrValue
                Case "B" : B = pstrValues(lintArrInc).pstrValue
                Case "C" : C = pstrValues(lintArrInc).pstrValue
                Case "D" : D = pstrValues(lintArrInc).pstrValue
                Case "E" : E = pstrValues(lintArrInc).pstrValue
            End Select
        Next lintArrInc
        pstrProbComtStack &= " #SFVX2"
        SaveCodes(pstrProbComtStack)
        pstrProbComtStack &= " #SFVX3"
        ClearCodes()
        pstrProbComtStack &= " #SFVX4"
    End Sub
    Friend Function GetFieldValues4(ByRef pA As String, ByRef pB As String, ByRef pC As String, ByRef pD As String, _
        ByRef pE As String, ByRef pstrProbComtStack As String) As String

        pstrProbComtStack &= " #GFV41"
        GetCodes(pstrProbComtStack)

        If A <> "" Then pA = A
        If B <> "" Then pB = B
        If C <> "" Then pC = C
        If D <> "" Then pD = D
        If E <> "" Then pE = E

        ClearCodes()
        pstrProbComtStack &= " #GFV42"
    End Function
End Module
