Friend Module FlameDB
    Friend Function GetFieldValuesX(ByVal pstrField As String) As String
        Dim lcnn1 As New ADODB.Connection
        Dim lsnaLists As New ADODB.Recordset

        lcnn1 = New ADODB.Connection
        lcnn1.Open(gstrConnectionString)
        Try
            Dim lstrSQL As String = "SELECT " & pstrField & " FROM TopicMatches;"
            gstrLastSQL = lstrSQL

            lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            With lsnaLists
                If Not .EOF Then
                    GetFieldValuesX = .Fields(pstrField).Value & ""
                End If
            End With
            lsnaLists.Close()
        Catch ex As Exception
            '
        Finally

            lcnn1.Close()
        End Try

    End Function
    Friend Sub SaveFieldValuesX(ByVal pstrValues() As FieldValues, ByRef pstrProbComtStack As String)
        Dim lcnn1 As New ADODB.Connection
        Dim lintArrInc As Integer

        lcnn1 = New ADODB.Connection
        lcnn1.Open(gstrConnectionString)

        For lintArrInc = 0 To pstrValues.GetUpperBound(0)
            Dim lstrSQL As String = "Update TopicMatches set " & pstrValues(lintArrInc).pstrField & " = '" & pstrValues(lintArrInc).pstrValue & "';"
            gstrLastSQL = lstrSQL

            lcnn1.Execute(lstrSQL)
        Next lintArrInc
        lcnn1.Close()

    End Sub
    Friend Function GetFieldValues4(ByRef pA As String, ByRef pB As String, ByRef pC As String, ByRef pD As String, _
        ByRef pE As String, ByRef pstrProbComtStack As String) As String
        Dim lcnn1 As New ADODB.Connection
        Dim lsnaLists As New ADODB.Recordset

        pstrProbComtStack &= " #GFV4#"

        lcnn1 = New ADODB.Connection
        lcnn1.Open(gstrConnectionString)
        Try
            Dim lstrSQL As String = "SELECT * FROM TopicMatches;"
            gstrLastSQL = lstrSQL

            lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            With lsnaLists
                If Not .EOF Then
                    pA = .Fields("A").Value & ""
                    pB = .Fields("B").Value & ""
                    pC = .Fields("C").Value & ""
                    pD = .Fields("D").Value & ""
                    pE = .Fields("E").Value & ""
                End If
            End With
            lsnaLists.Close()
        Catch ex As Exception
            '
        Finally

            lcnn1.Close()
        End Try

    End Function
End Module