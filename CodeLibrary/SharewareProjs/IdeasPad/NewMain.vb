Friend Module NewMain
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    'moved from mod Ideaspad 'so I could handle old Iconpacks
    Friend Sub main()

        gstrMRPs = "0001"

        'If AreDLLsPresent() = False Then 
        '    'mxessagebox.show("Some essential program files are missing, please re-install the program!", "Ideaspad") 
        '    MxessageBox.Show(LangText.GetString("Ideaspad_EssentialFilesMissing"), "Ideaspad") 

        '    Exit Sub
        'End If
        
        Dim lstrEssentialFiles() As String = {"ADODB.dll", "ADOX.dll", "AppBasic.dll", "AxInterop.SHDocVw.dll", _
            "Beside01.exe", "Beside02.exe", "" & gProgName & ".exe", "IPIconsPack.dll", "IPTemplates.dll", "JRO.dll", _
            "MCLCore.dll", "printtemplate.html", "ProbHand.dll", "RTFStand.dll", "SharpZipLib.dll", "SHDocVw.dll", "tipofday.txt", _
             "WinOnly.dll", "" & gProgName & ".exe.manifest", "de\AppBasic.resources.dll", "de\" & gProgName & ".resources.dll", _
             "de\tipofday.de.txt", "de\RTFStand.resources.dll", _
             "de\ProbHand.resources.dll"}


        'added ProbHand.dll, de\ProbHand.resources.dll
        'added IdeasPad.exe.manifest

        Dim lstrPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString())

        If EssentialFileCheck(lstrEssentialFiles, lstrPath) = False Then
            MessageBox.Show(LangText.GetString("Ideaspad_EssentialFilesMissing").Replace("[Program]", gProgName), _
                gProgName, MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props
            Exit Sub
        End If

        
        Dim fvi As System.Diagnostics.FileVersionInfo
        fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(lstrPath & "\IPIconsPack.dll")

        'System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()
        If fvi.FileVersion = "1.0.0.0" Then
            MessageBox.Show(LangText.GetString("NewMain_IconPackVer"), _
                NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 
            'MessageBox.Show("You may not use the current Icon Pack as it was designed for an older version of the program!", gProgName, MessageBoxButtons.OK, MessageBoxIcon.Error) 
            Exit Sub
        End If

        gstrMRPs = "0010"
        mainStart()
    End Sub
End Module
