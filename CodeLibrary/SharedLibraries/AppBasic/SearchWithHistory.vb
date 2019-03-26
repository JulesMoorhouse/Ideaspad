Public Class SearchWithHistory 
    Dim StandLangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("AppBasic.AppBasic", _
        System.Reflection.Assembly.GetExecutingAssembly())

    Dim SearchHistory As New Queue()
    Public DefaultText As String = StandLangText.GetString("StandText_SearchText")
    Public ClearText As String = StandLangText.GetString("StandText_SearchHistoryClear")

    Public Sub New(ByVal searchCombo As ComboBox, ByVal InitialConfig As InitalXMLConfig)

        LoadSearchHistory(InitialConfig)
        RefreshSearchHistory(searchCombo)
        If searchCombo.Items.Count = 1 Then
            searchCombo.Text = DefaultText
        Else
            searchCombo.SelectedIndex = 0
        End If


    End Sub
    Private Sub LoadSearchHistory(ByVal pInitialConfig As InitalXMLConfig)

        Dim lintArrInc As Integer

        With pInitialConfig
            Dim lintItemCount As Integer = .GetValue("SearchHistoryItems", -1)
            For lintArrInc = 0 To lintItemCount
                SearchHistory.Enqueue(.GetValue("SearchItem" & lintArrInc, ""))
            Next lintArrInc

        End With

    End Sub
    Public Function ButtonClick(ByVal searchCombo) As Boolean

        ButtonClick = True

        If searchCombo.Text = DefaultText Then
            'do nothing
        ElseIf searchCombo.Text = ClearText Then
            SearchHistory.Clear()
            RefreshSearchHistory(searchCombo)
            searchCombo.Text = DefaultText
            ButtonClick = False
        Else
            AddSearchHistoryItem(searchCombo)
        End If

    End Function
    Private Sub RefreshSearchHistory(ByVal SearchCombo As ComboBox)

        SearchCombo.Items.Clear()
        Dim ItemCount As Integer = SearchHistory.Count - 1

        If ItemCount > -1 Then
            Dim TempArr(ItemCount) As String
            Dim myEnumerator As System.Collections.IEnumerator = SearchHistory.GetEnumerator()
            While myEnumerator.MoveNext()
                TempArr(ItemCount) = myEnumerator.Current
                ItemCount -= 1
            End While

            SearchCombo.Items.AddRange(TempArr)
        End If

        SearchCombo.Items.Add(ClearText)

    End Sub
    Public Sub SaveSearchHistory()

        Dim lintArrInc As Integer
        Dim lintItemCount As Integer


        Dim myEnumerator As System.Collections.IEnumerator = SearchHistory.GetEnumerator()
        While myEnumerator.MoveNext()
            SaveSetting("SearchItem" & lintArrInc, myEnumerator.Current, InitalXMLConfig.XmlConfigType.AppSettings, "")
            lintArrInc += 1
        End While

        SaveSetting("SearchHistoryItems", SearchHistory.Count - 1, InitalXMLConfig.XmlConfigType.AppSettings, "")

    End Sub
    Private Sub AddSearchHistoryItem(ByVal SearchCombo As ComboBox)

        If SearchHistory.Contains(SearchCombo.Text) = True Then
            Exit Sub
        End If

        SearchHistory.Enqueue(SearchCombo.Text)

        If SearchHistory.Count >= 11 Then
            SearchHistory.Dequeue()
        End If

        RefreshSearchHistory(SearchCombo)

    End Sub
End Class
