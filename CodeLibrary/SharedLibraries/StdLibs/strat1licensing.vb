Friend Module Licensing
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    Function CheckLicense(ByVal plistBox As ListBox, ByRef pstrArray() As String) As Integer
        Dim HDDSerial As String = GetHardDriveSerial()
        Dim ThisDBID As String = GetFieldValuesX("DBID")
        Dim UserID As String = GetSetting(ThisDBID, 0, InitalXMLConfig.XmlConfigType.Membership, "")

        Dim lintUserLicNum As Integer = GetUserLicenseNumber()
        Dim lintThisDBUserCount As Integer = 0
        Dim lbooUserFoundInDb As Boolean = False
        Dim lbooRevokedUser As Boolean = False
        Dim NewDBID As New Guid()
        Dim lstrNewUserID As String = NewDBID.NewGuid.ToString

        
        If UserID = "0" Then 'if previously revoked or a new user
            UserID = lstrNewUserID
        End If

        'add any other DB license info to this DB from DAT, if not already exists for this user
        'write any other license info not found in DAT file from this DB for this user

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String

        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        If Not plistBox Is Nothing Then
            plistBox.Items.Clear()
        End If

        If Not pstrArray Is Nothing Then
            ReDim pstrArray(0)
        End If

        lstrSQL = "select * from LICENSES;" 
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        With lsnaLists
            Do Until .EOF
                'field 1 = HDDSerial | Field 2 = UserGUID | Field 3 = DBGUID | Field 4 = UserNameStr | Field 5 = Revoked
                'revoked = 0 valid = 2

                'Console.WriteLine("HDDSerial1=" & .Fields("1").Value & " UserGUID2=" & .Fields("2").Value & _
                '    " DBGUID3=" & .Fields("3").Value & " UserNameStr4=" & .Fields("4").Value & " Revoked5=" & .Fields("5").Value)

                'if this DB and record is not revoked
                If .Fields("3").Value = ThisDBID And .Fields("5").Value = 2 Then
                    'add user(s) to listbox for this DB
                    If Not plistBox Is Nothing Then
                        plistBox.Items.Add(.Fields("4").Value)
                    End If

                    If Not pstrArray Is Nothing Then
                        ReDim Preserve pstrArray(lintThisDBUserCount)
                        pstrArray(lintThisDBUserCount) = .Fields("2").Value
                    End If

                    lintThisDBUserCount += 1

                    'if above and right hdd and right userid
                    If .Fields("1").Value = HDDSerial And .Fields("2").Value = UserID Then
                        lbooUserFoundInDb = True
                        If plistBox Is Nothing Then 'if your not using this function to display stuf, you can end here
                            Exit Do
                        End If
                    End If
                End If

                'if revoked user
                'If .Fields("3").Value = ThisDBID And .Fields("5").Value = 0 And .Fields("1").Value = HDDSerial Then
                'This will unfortunetly now allow people to run Ideaspad from different directories on the same PC.
                'But it is needed if people run it from a network drive.
                If .Fields("3").Value = ThisDBID And .Fields("5").Value = 0 And _
                    .Fields("1").Value = HDDSerial And .Fields("2").Value = UserID Then 
                    lbooRevokedUser = True
                    Exit Do
                End If
                .MoveNext()
            Loop
        End With

        lsnaLists.Close()


        CheckLicense = 3 'everything OK
        If lbooRevokedUser = False Then

            If lintThisDBUserCount > lintUserLicNum Then
                'mxessagebox.show("User license exceeded on this DB")
                CheckLicense = 2
            End If
            If lbooUserFoundInDb = False And lintThisDBUserCount < lintUserLicNum Then
                'mxessagebox.show("'just add user!")
                'Dim NewDBID As New Guid()
                'Dim lstrNewUserID As String = NewDBID.NewGuid.ToString
                'moved further up! 

                SaveSetting(ThisDBID, lstrNewUserID, InitalXMLConfig.XmlConfigType.Membership, "")

                'Try : lcnn1.Execute("insert into LICENSES (1, 2, 3, 4, 5) values ('" & _
                '    HDDSerial & "', '" & lstrNewUserID & "', '" & ThisDBID & "', '" & System.Environment.UserName & _
                '    "', '2');") : Catch ex As Exception : End Try
                

                lstrSQL = "insert into LICENSES (1, 2, 3, 4, 5) values ('" & _
                    HDDSerial & "', '" & lstrNewUserID & "', '" & ThisDBID & "', '" & GetUserName() & _
                    "', '2');" 
                gstrLastSQL = lstrSQL 

                Try : lcnn1.Execute(lstrSQL) : Catch ex As Exception : End Try

                '
                If Not plistBox Is Nothing Then
                    'plistBox.Items.Add(System.Environment.UserName) '
                    plistBox.Items.Add(GetUserName) 
                End If
                CheckLicense = 1
            End If
            If lbooUserFoundInDb = False And lintThisDBUserCount = lintUserLicNum Then
                'mxessagebox.show("'about to exceed")
                CheckLicense = 2
            End If
        Else
            'mxessagebox.show("Revoked")
            CheckLicense = 4
        End If

        lcnn1.Close()

        Return CheckLicense

    End Function
    'Sub CreateLicenseTable()
    '    Dim lcnn1 As New ADODB.Connection()
    '    xx()
    '    lcnn1 = New ADODB.Connection()
    '    lcnn1.Open(gstrConnectionString)

    '    Try : lcnn1.Execute("CREATE TABLE LICENSES (1 text(50), 2 text(50), 3 text(50), 4 text(50), 5 Text(1));") : Catch ex As Exception
    '        Console.WriteLine(ex.Message & " " & ex.InnerException.Message)
    '    End Try

    '    lcnn1.Close()

    'End Sub
    Function GetUserLicenseNumber() As Integer

        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then 'Changed to Trial 
            Dim Dets As strat1.UnlockDetails
            Try
                Unlock(System.IO.Path.GetDirectoryName( _
                      System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\keyfile.mcl", Dets, "", "") 'added ,"" 
                Return Val(LeftGet(RightGet(Dets.str11LicenseName, 3), 2))
            Catch
                '
            End Try
        Else
            Return 1
        End If

    End Function
    Sub RevokeUser(ByVal pstrUserID As String)

        Dim ThisDBID As String = GetFieldValuesX("DBID")
        Dim lcnn1 As New ADODB.Connection()
        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)
        Dim lstrSQL As String = "Update LICENSES set [5]=0 where [3]='" & ThisDBID & "' and [2]='" & pstrUserID & "';"

        gstrLastSQL = lstrSQL 

        Try : lcnn1.Execute(lstrSQL) : Catch ex As Exception
            Console.WriteLine(ex.Message & " " & ex.InnerException.Message)
        End Try

        lcnn1.Close()
    End Sub
    Sub ResetRevokes() 'Is buy higher user license
        
        Dim ThisDBID As String = GetFieldValuesX("DBID")
        Dim lcnn1 As New ADODB.Connection()
        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)
        Dim lstrSQL As String = "Update LICENSES set [5]=2 where [3]='" & ThisDBID & "';"
        gstrLastSQL = lstrSQL 

        Try : lcnn1.Execute(lstrSQL) : Catch ex As Exception
            Console.WriteLine(ex.Message & " " & ex.InnerException.Message)
        End Try

        lcnn1.Close()
    End Sub
    Function StandardCheck(ByVal pMe As Form, ByVal pbooAlwaysOnTop As Boolean) As String

        Dim Result As Integer = CheckLicense(Nothing, Nothing)

        Application.DoEvents() 

        If Result = 2 Then
            Dim Lic As New frmLicenseManager()
            With Lic
                .Owner = pMe 
                .TopMost = pbooAlwaysOnTop 
                .ShowDialog()
                Application.DoEvents() 
                If .Result <> DialogResult.OK Then
                    'couldn't revoke, canceled
                    StandardCheck = LangText.GetString("Strat1_AccessDenied").Replace("[Program]", gProgName)
                    'End
                Else 'added ok after revoking someone
                    StandardCheck = ""
                End If
            End With
        ElseIf Result = 3 Then  'ok
            StandardCheck = ""
        ElseIf Result = 4 Then 'revoked
            'StandardCheck = False
            StandardCheck = LangText.GetString("Strat1_Revoked")
        End If

    End Function
End Module