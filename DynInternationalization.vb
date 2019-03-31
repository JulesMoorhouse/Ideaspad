Public Module DynInternationalization
    Public Sub xSetInternationalResources(ByVal pMe As Form, ByVal pstrFormName As String, ByVal pResMan As System.Resources.ResourceManager)
        'Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))

        Dim st As System.IO.Stream
        Dim ass As System.Reflection.Assembly = pMe.GetType().Assembly
        'Dim lstrResXName As String = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & "." & pstrFormName & ".resources"
        Dim lstrResXName As String = System.Reflection.Assembly.GetCallingAssembly.GetName.Name & "." & pstrFormName & ".resources"
        st = ass.GetManifestResourceStream(lstrResXName)

        Dim reader = New System.Resources.ResourceReader(st)
        Dim en As IDictionaryEnumerator = reader.GetEnumerator()

        '--- a ---
        'Dim ldat As Date = Date.Now
        Dim props As System.ComponentModel.PropertyDescriptorCollection = System.ComponentModel.TypeDescriptor.GetProperties(pMe)
        Dim p As System.ComponentModel.PropertyDescriptor
        '--- each control ---

        Dim ctrl As Control
        While en.MoveNext()
            Dim lstrThisRESXKey As String = CStr(en.Key).Replace(">>", "")
            If Microsoft.VisualBasic.Right(lstrThisRESXKey, (".Name").Length) <> ".Name" Then
                If Microsoft.VisualBasic.Left(lstrThisRESXKey, "$this.".Length) <> "$this." Then
                    For Each ctrl In pMe.Controls
                        'If Not en.Value Is Nothing Then
                        '    SetChildControl(ctrl.Controls, lstrThisRESXKey, en.Value, pResMan)
                        'End If
                        'Console.WriteLine(ctrl.Name)
                        If Microsoft.VisualBasic.Left(lstrThisRESXKey, ctrl.Name.Length) = ctrl.Name Then
                            Dim props2 As System.ComponentModel.PropertyDescriptorCollection = System.ComponentModel.TypeDescriptor.GetProperties(ctrl)
                            Dim p2 As System.ComponentModel.PropertyDescriptor
                            For Each p2 In props2
                                If lstrThisRESXKey = ctrl.Name.ToString & "." & p2.Name Then
                                    If p2.Name = "Parent" Then
                                        'If en.Value = "$this" Then
                                        Try : MessageBox.Show(lstrThisRESXKey & "=" & lstrThisRESXKey) : Catch : End Try
                                        p2.SetValue(ctrl, pMe)
                                        'Else
                                        '    'p2.SetValue(ctrl, en.Value)
                                        '    p2.SetValue(ctrl, pResMan.GetObject(lstrThisRESXKey))
                                        '    Console.WriteLine(lstrThisRESXKey)
                                        'End If
                                    Else
                                        'p2.SetValue(ctrl, en.Value)
                                        Try : MessageBox.Show(lstrThisRESXKey & "=" & lstrThisRESXKey) : Catch : End Try
                                        p2.SetValue(ctrl, pResMan.GetObject(lstrThisRESXKey))
                                    End If
                                    'Try : Console.WriteLine(lstrThisRESXKey & "=" & pResMan.GetObject(lstrThisRESXKey)) : Catch : End Try
                                    'Try : MxessageBox.Show(lstrThisRESXKey & "=" & pResMan.GetObject(lstrThisRESXKey)) : Catch : End Try
                                    Exit For
                                End If
                            Next p2
                        End If
                    Next
                    'if it gets here then must be a control within a control
                    'or a propterty with no RESX settings

                    ''--- a ---
                    'If Microsoft.VisualBasic.Right(lstrThisRESXKey, (".Parent").Length) = ".Parent" Then
                    '    If en.Value <> "$this" Then
                    '        Console.WriteLine(lstrThisRESXKey)
                    '    End If
                    'End If
                    For Each ctrl In pMe.Controls
                        If Not en.Value Is Nothing Then
                            SetChildControl(ctrl.Controls, lstrThisRESXKey, en.Value, pResMan)
                        End If
                    Next
                    ''--- a ---

                Else
                    For Each p In props
                        If lstrThisRESXKey = "$this." & p.Name Then
                            'p.SetValue(Me, en.Value)
                            Try : MessageBox.Show(lstrThisRESXKey & "=" & lstrThisRESXKey) : Catch : End Try
                            p.SetValue(pMe, pResMan.GetObject(lstrThisRESXKey))
                            'Try : Console.WriteLine(lstrThisRESXKey & "=" & pResMan.GetObject(lstrThisRESXKey)) : Catch : End Try
                            'Try : MessageBox.Show(lstrThisRESXKey & "=" & pResMan.GetObject(lstrThisRESXKey)) : Catch : End Try
                            Exit For
                        End If
                    Next p
                End If
            End If
        End While
        '--- each control ---
        'Console.WriteLine(ldat & " " & Date.Now)

        'MxessageBox.Show("Done!")
    End Sub

    Public Sub SetChildControl(ByRef ctrls As Control.ControlCollection, ByVal ResKey As String, ByVal pval As Object, ByVal pResman As System.Resources.ResourceManager)
        Dim oCtrl As Control
        For Each oCtrl In ctrls
            If Microsoft.VisualBasic.Left(ResKey, oCtrl.Name.Length) = oCtrl.Name Then
                Dim props2 As System.ComponentModel.PropertyDescriptorCollection = System.ComponentModel.TypeDescriptor.GetProperties(oCtrl)
                Dim p2 As System.ComponentModel.PropertyDescriptor
                For Each p2 In props2
                    If ResKey = oCtrl.Name.ToString & "." & p2.Name Then
                        If p2.Name = "Parent" Then
                            'If en.Value = "$this" Then
                            '''p2.SetValue(oCtrl, Me)
                            'Else
                            '    'p2.SetValue(ctrl, en.Value)
                            '    p2.SetValue(ctrl, pResMan.GetObject(lstrThisRESXKey))
                            '    Console.WriteLine(lstrThisRESXKey)
                            'End If
                        Else
                            'p2.SetValue(ctrl, en.Value)
                            Try : MessageBox.Show(ResKey & "=" & ResKey) : Catch : End Try
                            p2.SetValue(oCtrl, pResman.GetObject(ResKey))
                        End If
                        'Try : Console.WriteLine(ResKey & "=" & pResman.GetObject(ResKey)) : Catch : End Try
                        'Try : MxessageBox.Show(ResKey & "=" & pResman.GetObject(ResKey)) : Catch : End Try
                        Exit For
                    End If
                Next
            End If
            SetChildControl(oCtrl.Controls, ResKey, pval, pResman)
        Next
    End Sub

End Module
