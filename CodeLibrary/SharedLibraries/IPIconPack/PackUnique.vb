'Public Module PackUnique


'End Module
Friend Class PackUnique

    'old 16x16 icons
    'Friend Const ToolbarSettingsComboTop As Integer = 1
    'Friend Const ToolbarSettingsNumOfFontComboSpacers As Integer = 11
    'Friend Const ToolbarSettingsNumOfSearchComboSpacers As Integer = 4
    'Friend Const ToolbarSettingsIdentity As String = "16x16Set2003"
    'Friend Const toolbarSettingsFontStyleComboWidth As Integer = 195
    'Friend Const toolbarSettingsFontSizeComboWidth As Integer = 50
    'Friend Const toolbarSettingsSearchTextComboWidth As Integer = 160

    'new 24x24 icons
    Friend Const ToolbarSettingsComboTop As Integer = 5
    Friend Const ToolbarSettingsNumOfFontComboSpacers As Integer = 9
    Friend Const ToolbarSettingsNumOfSearchComboSpacers As Integer = 5 '6
    Friend Const ToolbarSettingsIdentity As String = "24x24Set2004"
    Friend Const toolbarSettingsFontStyleComboWidth As Integer = 210 '195
    Friend Const toolbarSettingsFontSizeComboWidth As Integer = 50
    Friend Const toolbarSettingsSearchTextComboWidth As Integer = 145 '140 '160


    Friend intTreeIconTag() As String = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, _
        17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38}

    'Friend tbWidths() As Integer = {315, 185, 540, 230} ' old icons 16x16
    'new icons 24x24
    Friend tbWidths() As Integer = {315 + (8 * 12), _
        185 + (8 * 7), _
        507 + (8 * 21), _
        160 + (8 * 5)}

    Friend tbIntialLocations(3) As System.Drawing.Point
    Sub New()
        'old 16x16 icons
        'tbIntialLocations(0) = New System.Drawing.Point(2, 2)
        'tbIntialLocations(1) = New System.Drawing.Point(2, 54)
        'tbIntialLocations(2) = New System.Drawing.Point(2, 28)
        'tbIntialLocations(3) = New System.Drawing.Point(319, 2)

        'new 24x24 icons
        tbIntialLocations(0) = New System.Drawing.Point(2, 2)
        tbIntialLocations(1) = New System.Drawing.Point(2, 70)
        tbIntialLocations(2) = New System.Drawing.Point(2, 36)
        tbIntialLocations(3) = New System.Drawing.Point(415, 2)

    End Sub
End Class