
Friend Class beside
    Friend Function Interpret(ByVal pstrCommLine As String, ByVal pstrDecryptTest As String) As String
        'added BugWork 
        Dim lintArrItems As Integer
        Dim lintArrInc As Integer

        lintArrItems = Occurences(pstrCommLine, "X3X")
        Dim lstrDec(lintArrItems) As String

        lstrDec(0) = ReturnNthStr(pstrCommLine, 1, "X3X")

        For lintArrInc = 1 To lintArrItems - 1
            lstrDec(lintArrInc) = RightGet(ReturnNthStr(pstrCommLine, lintArrInc + 1, "X3X"), ReturnNthStr(pstrCommLine, lintArrInc + 1, "X3X").Length - 2)
        Next lintArrInc

        If lbooErrDebug = True Then : MessageBox.Show("F1 Interpret") 

        End If
        'Pass it to Decrypt
        Dim lstrDecStr As String
        Interpret = Decrypt(lstrDec, 0) 'added 0 for BugWork 
        If lbooErrDebug = True Then : MessageBox.Show("Interpret A - " & Interpret) : End If 

        
        If InStrGet(Interpret, pstrDecryptTest) = 0 Then  
            Interpret = Decrypt(lstrDec, 1) 'old
            If lbooErrDebug = True Then : MessageBox.Show("Interpret  B - " & Interpret) : End If 
        End If
        

        ReDim lstrDec(0)

    End Function
End Class
