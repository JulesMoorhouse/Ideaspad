Imports ADOX
Friend Module main
    Friend pstrParam As String
    Friend pstrFileName As String
    Friend pstrWorkgroup As String
    Friend pstrUserName As String
    Friend pstrPassword As String
    Friend pstrNewPassword As String
    Friend pstrSuperUserName As String
    Friend pstrSuperGroup As String
    Friend pstrExtraSettings As String 

    Friend Sub Main()
        Main(Environment.GetCommandLineArgs())
    End Sub

    Private Sub Main(ByVal args() As String)
        Dim lstrErrStage As String 

        lstrErrStage = "A" 
        If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
        'Dim lintArrItems As Integer
        'Dim lintArrInc As Integer
        '------------------ crc check -------------------------
        Dim IRes As Integer
        'IRes = SetTopicTree()
        IRes = GetWrittenCRC(AppExe) 

        lstrErrStage = "B" 
        If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 

        Dim lstrDetails(3) As String
        Dim lstrRetVal3 As String
        'lstrDetails(0) = "33eV[AsWYllNw[l[HR"
        'lstrDetails(1) = "LwpETrYMIDxAD@\[XEjvQClFDb@H>sAziaCLlzlXStip\Uq[u@OIEGcVIZQx_xZeSvnk?A"
        'lstrDetails(2) = "^k?iz_l<DIRsxfiPL@vYLrfB\gpydTVsFt_lCgHXBBrDUR]LjePN;>Ty\?OERrcWdVZJ[X"
        'lstrDetails(3) = "Zn?GrObcvG[nKOon;OlpxWqWQ\?"
        
        lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
        lstrDetails(1) = "xUG;QVU;JImPpmpPwKJ;AHQ;SRF;QZHpJJGPZmQKLVC;YHJ;ZwKKLGE;NFY;LWA;ZnFKVL"
        lstrDetails(2) = "Z@mpyONNZ<HQS;RFG;ZHUKGUH;DUV;LmpPmpfORQG;ZJHKKSH;YMZ<QGZ<TKH;ZEGKUZX?"
        lstrDetails(3) = "AZF?RUZ<MYQ;LZJ?HKS;HYM;LmO"
        

        lstrRetVal3 = Decrypt(lstrDetails)

        lstrErrStage = "C" 
        If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 

        If IRes = 1 Then
            '
        ElseIf IRes = -1 Then
            MessageBox.Show(lstrRetVal3, "Beside01   ")
            End
            GoTo Exhaust
        Else
            MessageBox.Show(lstrRetVal3, "Beside01     ")
            End
            GoTo Exhaust
        End If
        '------------------ crc check -------------------------

        lstrErrStage = "D" 
        If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 

        'If args Is Nothing Or args.Length > 7 Or args.Length = 1 Then
        'MessageBox.Show(args.Length)
        If args Is Nothing Or args.Length <> 2 Then
            MessageBox.Show(lstrRetVal3, "Beside01    ")

            lstrErrStage = "E" 
            If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
        Else
            lstrErrStage = "F" 
            If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 

            On Error Resume Next
            pstrParam = args(1)

            Dim lstrDecStr As String
            Dim IntBeside As New beside()
            lstrDecStr = IntBeside.Interpret(pstrParam, "MAKE")
            IntBeside = Nothing


            lstrErrStage = "G" 
            If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 

            'lintArrItems = Occurences(pstrParam, "X3X")
            'Dim lstrDec(lintArrItems) As String

            'lstrDec(0) = ReturnNthStr(pstrParam, 1, "X3X")

            'For lintArrInc = 1 To lintArrItems
            'lstrDec(lintArrInc) = RightGet(ReturnNthStr(pstrParam, lintArrInc + 1, "X3X"), ReturnNthStr(pstrParam, lintArrInc + 1, "X3X").Length - 2)
            'Next lintArrInc

            ''Pass it to Decrypt
            'Dim lstrDecStr As String
            'lstrDecStr = Decrypt(lstrDec)
            'ReDim lstrDec(0)

            pstrParam = ReturnNthStr(lstrDecStr, 1, "@")
            pstrFileName = ReturnNthStr(lstrDecStr, 2, "@")
            pstrWorkgroup = ReturnNthStr(lstrDecStr, 3, "@")
            pstrUserName = ReturnNthStr(lstrDecStr, 4, "@")
            pstrPassword = ReturnNthStr(lstrDecStr, 5, "@")
            pstrNewPassword = ReturnNthStr(lstrDecStr, 6, "@")
            pstrSuperUserName = ReturnNthStr(lstrDecStr, 7, "@")
            pstrSuperGroup = ReturnNthStr(lstrDecStr, 8, "@")
            pstrExtraSettings = ReturnNthStr(lstrDecStr, 9, "@") 

            lstrErrStage = "H" 
            If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 

            'lstrDecStr = ""


            If pstrParam = "" Or pstrFileName = "" Or pstrWorkgroup = "" Or pstrUserName = "" Or _
                pstrPassword = "" Or pstrNewPassword = "" Or pstrSuperUserName = "" Or pstrSuperGroup = "" Then
                MessageBox.Show(lstrRetVal3, "Beside01    ")
                'MessageBox.Show("Param: " & pstrParam & Environment.NewLine & _
                '   "File: " & pstrFileName & Environment.NewLine & _
                '    "Workgroup: " & pstrWorkgroup & Environment.NewLine & _
                '    "Usr: " & pstrUserName & Environment.NewLine & _
                '    "Pass: " & pstrPassword & Environment.NewLine & _
                '    "New Pass: " & pstrNewPassword & Environment.NewLine & _
                '    "SuperUser: " & pstrSuperUserName & Environment.NewLine & _
                '    "SuperGroup: " & pstrSuperGroup & Environment.NewLine & lstrDecStr)
                Exit Sub
            End If
            On Error GoTo 0
            If pstrPassword = "none" Then pstrPassword = ""

            If lbooErrDebug = True Then 
                MessageBox.Show("Param: " & pstrParam & Environment.NewLine & _
                    "File: " & pstrFileName & Environment.NewLine & _
                    "Workgroup: " & pstrWorkgroup & Environment.NewLine & _
                    "Usr: " & pstrUserName & Environment.NewLine & _
                    "Pass: " & pstrPassword & Environment.NewLine & _
                    "New Pass: " & pstrNewPassword & Environment.NewLine & _
                    "SuperUser: " & pstrSuperUserName & Environment.NewLine & _
                    "SuperGroup: " & pstrSuperGroup)
            End If

            createdb(pstrFileName)


        End If
Exhaust:

    End Sub

End Module

Friend Module DBFuncs
    Friend gconstrConnectionProvider As String
    Friend Const gconstrConnectionJustProvider As String = "Provider=Microsoft.Jet.OLEDB.4.0;Mode=Share Deny None;Extended Properties=;Data Source="
    Friend Const gconstrConnectionProviderNonShare As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
    Friend lbooErrDebug As Boolean = False 'True 
    Friend Sub createdb(ByVal pstrfilename As String)
        Dim lstrErrStage As String = 0
        Dim NewDB As ADOX.Catalog = New ADOX.Catalog()
        Dim lstrNewConnString As String


        Try

            gconstrConnectionProvider = "Provider=Microsoft.Jet.OLEDB.4.0;Mode=Share Deny None;Extended Properties=;User ID=" & pstrUserName & ";Password=" & pstrPassword & ";Data Source="

            lstrErrStage = 1
            If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
            'Don't know why I put this here! 
            'Try : IO.File.Delete(pstrWorkgroup) : Catch : End Try 

            'Create Workgroup File
            If pstrParam = "DBNWMAKE" Then 'used 1st call
                'NewDB.Create(gconstrConnectionJustProvider & pstrWorkgroup & ";" & "Jet OLEDB:Create System Database=True;User ID=" & pstrUserName & ";Password=" & pstrPassword & ";")
                
                NewDB.Create(gconstrConnectionJustProvider & pstrWorkgroup & ";" & "Jet OLEDB:Create System Database=True;User ID=" & pstrUserName & ";Password=" & pstrPassword & pstrExtraSettings & ";")
            End If

            'Don't know why I put this here! 
            'Try : IO.File.Delete(pstrfilename) : Catch : End Try 

            lstrErrStage = 2
            If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
            'Log in Db using Workgroup file
            If pstrParam = "DBNWMAKE" Or pstrParam = "DBMAKE" Then 'used 1st & 2nd call
                NewDB.Create(gconstrConnectionJustProvider & pstrfilename & ";User ID=" & pstrUserName & ";Password=" & pstrPassword & ";Jet OLEDB:Encrypt Database=True;Jet OLEDB:System database=" & pstrWorkgroup)
            End If
            lstrErrStage = 3
            If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
            
            If IO.File.Exists(pstrWorkgroup) = False Then
                Console.WriteLine("FNE WRK: " & pstrWorkgroup)
                If lbooErrDebug = True Then MessageBox.Show("FNE WRK: " & pstrWorkgroup) 
            End If
            If IO.File.Exists(pstrfilename) = False Then
                Console.WriteLine("FNE MDB: " & pstrfilename)
                If lbooErrDebug = True Then MessageBox.Show("FNE MDB: " & pstrfilename) 
            End If
            

            If pstrParam = "DBNWMAKE" Then 'used 1st call
                lstrErrStage = 4
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
                Dim grpNew As Group
                grpNew = New ADOX.Group()
                lstrErrStage = 5
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
                grpNew.Name = pstrSuperGroup '"SuperUsrs"
                NewDB.Groups.Append(grpNew)

                NewDB.Groups(pstrSuperGroup).SetPermissions("", ObjectTypeEnum.adPermObjDatabase, ActionEnum.adAccessSet, RightsEnum.adRightFull)
                NewDB.Groups(pstrSuperGroup).SetPermissions("", ObjectTypeEnum.adPermObjTable, ActionEnum.adAccessGrant, RightsEnum.adRightFull)

                lstrErrStage = 6
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
                'Create Super user Account
                Dim usrNew As User
                usrNew = New ADOX.User()
                usrNew.Name = pstrSuperUserName '"IPUser"
                NewDB.Users.Append(usrNew)
                'usrNew.ChangePassword("", "55jj88kk")
                
                usrNew.ChangePassword("", pstrNewPassword)
                lstrErrStage = 7
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
                usrNew.Groups.Append(pstrSuperGroup)
                usrNew.Groups.Append("Admins")

                lstrErrStage = 72
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 

                NewDB.Users(pstrSuperUserName).SetPermissions("", ObjectTypeEnum.adPermObjDatabase, ActionEnum.adAccessSet, RightsEnum.adRightFull)
                NewDB.Users(pstrSuperUserName).SetPermissions("", ObjectTypeEnum.adPermObjTable, ActionEnum.adAccessGrant, RightsEnum.adRightFull)


                lstrErrStage = 8
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 

                NewDB.Users("Admin").SetPermissions("", ObjectTypeEnum.adPermObjDatabase, ActionEnum.adAccessRevoke, RightsEnum.adRightFull)
                NewDB.Users("Admin").SetPermissions("", ObjectTypeEnum.adPermObjTable, ActionEnum.adAccessDeny, RightsEnum.adRightFull)
                lstrErrStage = 9
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
                grpNew = Nothing
                usrNew = Nothing
            ElseIf pstrParam = "DBMAKE" Then 'used 2nd call
                '*' Remove admin users * Group rights
                lstrErrStage = 10
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
                NewDB.Users("Admin").SetPermissions("", ObjectTypeEnum.adPermObjDatabase, ActionEnum.adAccessRevoke, RightsEnum.adRightFull)
                NewDB.Users("Admin").SetPermissions("", ObjectTypeEnum.adPermObjTable, ActionEnum.adAccessDeny, RightsEnum.adRightFull)

                
                Try
                    NewDB.Users("Admin").SetPermissions("", ObjectTypeEnum.adPermObjDatabase, ActionEnum.adAccessRevoke, RightsEnum.adRightMaximumAllowed)
                Catch : End Try
                Try
                    NewDB.Users("Admin").SetPermissions("", ObjectTypeEnum.adPermObjTable, ActionEnum.adAccessRevoke, RightsEnum.adRightMaximumAllowed)
                Catch : End Try
                

                NewDB.Groups("Admins").SetPermissions("", ObjectTypeEnum.adPermObjDatabase, ActionEnum.adAccessRevoke, RightsEnum.adRightFull)
                NewDB.Groups("Admins").SetPermissions("", ObjectTypeEnum.adPermObjTable, ActionEnum.adAccessDeny, RightsEnum.adRightFull)


                
                Try
                    NewDB.Groups("Admins").SetPermissions("", ObjectTypeEnum.adPermObjDatabase, ActionEnum.adAccessRevoke, RightsEnum.adRightMaximumAllowed)
                Catch : End Try
                Try
                    NewDB.Groups("Admins").SetPermissions("", ObjectTypeEnum.adPermObjTable, ActionEnum.adAccessRevoke, RightsEnum.adRightMaximumAllowed)
                Catch : End Try
                

                lstrErrStage = 11
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
                '*' delete admin user from group admins
                NewDB.Users("Admin").Groups.Delete("Admins")

                '*' Remove rights from group users
                NewDB.Groups("Users").SetPermissions("", ObjectTypeEnum.adPermObjDatabase, ActionEnum.adAccessRevoke, RightsEnum.adRightFull)
                NewDB.Groups("Users").SetPermissions("", ObjectTypeEnum.adPermObjTable, ActionEnum.adAccessDeny, RightsEnum.adRightFull)

                
                Try
                    NewDB.Groups("Users").SetPermissions("", ObjectTypeEnum.adPermObjDatabase, ActionEnum.adAccessRevoke, RightsEnum.adRightMaximumAllowed)
                Catch : End Try
                Try
                    NewDB.Groups("Users").SetPermissions("", ObjectTypeEnum.adPermObjTable, ActionEnum.adAccessRevoke, RightsEnum.adRightMaximumAllowed)
                Catch : End Try
                

                '.Groups("Users").SetPermissions Null, adPermObjTable, adAccessRevoke, adRightMaximumAllowed

                NewDB.Users("Admin").Groups.Delete("Users")
                lstrErrStage = 12
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
            End If

            If pstrParam = "DBNWMAKE" Or pstrParam = "DBMAKE" Then
                NewDB.ActiveConnection = Nothing
                lstrErrStage = 13
                If lbooErrDebug = True Then MessageBox.Show(lstrErrStage) 
            End If


        Catch ex As Exception
            Try : NewDB.ActiveConnection = Nothing : Catch : End Try 
            Try : NewDB = Nothing : Catch : End Try 

            
            Try
                Dim lstrExeTry As String
                lstrExeTry = System.IO.Path.GetDirectoryName( _
                                       System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\IdeasPad.exe"
                If Not IO.File.Exists(lstrExeTry) Then
                    lstrExeTry = System.IO.Path.GetDirectoryName( _
                        System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\MDBSecure.exe"
                    If Not IO.File.Exists(lstrExeTry) Then
                        lstrExeTry = ""
                    End If
                End If
                If lstrExeTry <> "" Then
                    If System.IO.File.Exists(lstrExeTry & ".dat") = False Then
                        GetSetting("Default Information Base File", "", InitalXMLConfig.XmlConfigType.AppSettings, "", lstrExeTry & ".dat")
                    End If
                    SaveSetting("Beside01Err", lstrErrStage & " " & Date.Now, InitalXMLConfig.XmlConfigType.AppSettings, "", lstrExeTry & ".dat")
                End If
            Catch
                '
            End Try
            


            MessageBox.Show(ex.Message & Environment.NewLine & "Error Code B2 (" & lstrErrStage & ") " & pstrParam)
            Throw
        End Try
        'lcnn1.Close()

        Try : NewDB.ActiveConnection = Nothing : Catch : End Try 
        Try : NewDB = Nothing : Catch : End Try 

        If lbooErrDebug = True Then MessageBox.Show("end") 
    End Sub

End Module
