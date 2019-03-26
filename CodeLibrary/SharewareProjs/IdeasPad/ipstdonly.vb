Friend Module IPVersion
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    Friend Sub AddRTFFooter(ByVal pobjRTF As RichTextBox, ByVal pbooRTForText As Boolean)

        If InStrGet(NameMe("").ToUpper, "TRIAL") > 0 Then
            If pbooRTForText = True Then 
                pobjRTF.SelectedRtf = _
                    "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fcharset0 Arial;}}{\colortbl ;\red0\green0\blue255;}" & _
                    "\viewkind4\uc1\pard\ul\b\i\f0\fs20\par\cf1\ulnone " & _
                    LangText.GetString("IpstdOnly_ThanksForEval").Replace("[Program]", gProgName).Replace("2004", gYear) & _
                    ".\cf0\par}" 
            Else 
                pobjRTF.SelectedText = _
                 "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fcharset0 Arial;}}{\colortbl ;\red0\green0\blue255;}" & _
                 "\viewkind4\uc1\pard\ul\b\i\f0\fs20\par\cf1\ulnone " & _
                 LangText.GetString("IpstdOnly_ThanksForEval").Replace("[Program]", gProgName).Replace("2004", gYear) & _
                 ".\cf0\par}"
            End If 

        End If

    End Sub
    Friend Function NameMe(ByVal pstrCaption As String) As String

        Dim lstrVersion As String
        If mintVersion = 32 Then
            lstrVersion = gProgName & " " & gYear
        Else
            lstrVersion = gProgName & " Trial " & LangText.GetString("IpstdOnly_Version") 

        End If

        If pstrCaption <> "" Then
            If (pstrCaption).ToUpper = gProgName.ToUpper Then
                NameMe = lstrVersion
            Else
                NameMe = lstrVersion & " - " & pstrCaption
            End If
        Else
            NameMe = lstrVersion
        End If

    End Function
    Friend Sub AssignCFUVars()

        With gstrManifestSite(0)
            .strSitePath = "http://www.example.com"
            .strManifestDir = "updates/neptune/"
            .strManifestFile = "ipdemo.xml"
        End With
        
        With gstrManifestSite(1)
            .strSitePath = "http://www.example2.com"
            .strManifestDir = "updates/neptune/"
            .strManifestFile = "ipdemo.xml"
        End With

        'MessageBox.Show("Don't forget to take out testing CFU vars")
        'With gstrManifestSite(0)
        '    .strSitePath = "http://localhost"
        '    .strManifestDir = "ipcfu/neptune/"
        '    .strManifestFile = "ipdemo.xml"
        'End With

        'With gstrManifestSite(1)
        '    .strSitePath = "http://localhost"
        '    .strManifestDir = "ipcfu/neptune/"
        '    .strManifestFile = "ipdemo.xml"
        'End With
    End Sub
    Friend Sub StandardUpgradeTidy()

        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then
            Dim lstrDemoBuyPage As String = _
            System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu.Programs) & _
                gProgName & "\" & LangText.GetString("IpstdOnly_HowToBuyURL").Replace("[Program]", gProgName)

            Dim lbooSucess As Boolean = False 
            If System.IO.File.Exists(lstrDemoBuyPage) = True Then
                Try
                    System.IO.File.Delete(lstrDemoBuyPage)
                    lbooSucess = True 
                Catch ex As Exception
                    '
                End Try
            End If

            '--- 'added to cater for people who have upgraded from v1.0.3. to v.1.0.4 ---
            If lbooSucess = False Then
                lstrDemoBuyPage = _
               System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) & _
                   "\Programs\" & gProgName & "\How to Buy " & gProgName & ".url"
                If System.IO.File.Exists(lstrDemoBuyPage) = True Then
                    Try
                        System.IO.File.Delete(lstrDemoBuyPage)
                        lbooSucess = True
                    Catch ex As Exception
                        '
                    End Try
                End If
            End If
            '--- 'added to cater for people who have upgraded from v1.0.3. to v.1.0.4 ---
        End If

    End Sub
    Sub InternationalShortcutTidy()
        
        Dim lstrShortcuts(3) As String
        Dim lstrProgStartFolder As String = System.Environment.GetFolderPath(Environment.SpecialFolder.StartMenu.Programs) & "\"

        Dim lstrLang2Char As String = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName

        If lstrLang2Char = "en" Then
            lstrProgStartFolder &= gProgName & " (Deutsch)\"
            lstrShortcuts(0) = lstrProgStartFolder & gProgName & ".lnk"
            lstrShortcuts(1) = lstrProgStartFolder & "Wie kann ich " & gProgName & " kaufen.url"
            lstrShortcuts(2) = lstrProgStartFolder & "Produkt Support.url"
            lstrShortcuts(3) = lstrProgStartFolder & gProgName & " Hilfe.lnk"
        Else
            lstrProgStartFolder &= gProgName & " (English)\"
            lstrShortcuts(0) = lstrProgStartFolder & gProgName & ".lnk"
            lstrShortcuts(1) = lstrProgStartFolder & "How to Buy " & gProgName & ".url"
            lstrShortcuts(2) = lstrProgStartFolder & "Product Support.url"
            lstrShortcuts(3) = lstrProgStartFolder & gProgName & " Help.lnk"
        End If

        Dim lintArrInc As Integer
        For lintArrInc = 0 To 3
            If System.IO.File.Exists(lstrShortcuts(lintArrInc)) = True Then
                Try
                    System.IO.File.Delete(lstrShortcuts(lintArrInc))
                Catch ex As Exception
                    '
                End Try
            End If
        Next lintArrInc

        Try
            System.IO.Directory.Delete(lstrProgStartFolder)
        Catch
        End Try


    End Sub
    Friend Function GetWindowsDir(ByVal pstrResource As flamer, ByRef pstrProbComtStack As String) As Long

        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then
            Return 2
        Else
            Return CheckDates(pstrResource, 0, pstrProbComtStack) 'added zero for ideaspad
        End If

    End Function

End Module
