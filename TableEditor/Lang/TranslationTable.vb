Class TranslationTable
    Shared hash As New System.Collections.Specialized.StringDictionary
    Public Shared Sub AddTranslation(ByVal key As String, ByVal value As String)
        hash.Add(key.ToLower, value)
    End Sub

    Public Shared Function ContainsTranslation(ByVal key As String) As Boolean
        Return hash.ContainsKey(key.ToLower)
    End Function

    Public Shared Function GetTranslation(ByVal key As String) As String
        If ContainsTranslation(key) Then
            Return hash.Item(key.ToLower)
        Else
            Return "No translation for " + key
        End If
    End Function

    Public Shared Sub SetTranslationTable(ByVal table As System.Collections.Specialized.StringDictionary)
        hash = table
    End Sub
End Class
