Public Class Symbol
    Inherits System.Windows.Forms.Form
    Dim mstrReturnChar As String
    Dim mstrReturnFont As String
    Public Property ReturnFont() As String
        Get
            Return mstrReturnFont
        End Get
        Set(ByVal Value As String)
            mstrReturnFont = Value
        End Set
    End Property
    Public Property ReturnChar() As String
        Get
            Return mstrReturnChar
        End Get
        Set(ByVal Value As String)
            mstrReturnChar = Value
        End Set
    End Property
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cboFontName As ComboBox
    Dim btnSlot() As Button = New Button(255) {}
    Dim mbooTopMost As Boolean 
    Public Sub New(ByVal pbooTopMost As Boolean)

        Dim StandLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))

        Dim LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("RTFStand.RTFStand", _
            System.Reflection.Assembly.GetExecutingAssembly())

        mbooTopMost = pbooTopMost 

        btnOK = New Button()
        btnCancel = New Button()
        cboFontName = New ComboBox()

        Me.Width = 405
        Me.Height = 480 '440

        'With btnOK
        '    .Left = 15
        '    .Top = (Me.Height - .Height) - 40
        '    .TabIndex = 1
        '    .Text = StandLangText.GetString("StandText_OK")
        '    .FlatStyle = FlatStyle.System
        '    .BackColor = Color.FromArgb(0, .BackColor)
        'End With

        With btnCancel
            .Left = (Me.Width - .Width) - 20
            .Top = (Me.Height - .Height) - 40
            .TabIndex = 2
            .Text = StandLangText.GetString("StandText_Cancel")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        With btnOK
            .Left = (btnCancel.Left - .Width) - 10
            .Top = (Me.Height - .Height) - 40
            .TabIndex = 1
            .Text = StandLangText.GetString("StandText_OK")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        With cboFontName
            .Left = 15
            .Top = 15
            .Width = 300
            .TabIndex = 0
        End With

        Dim lintArrInc As Integer
        Dim CurrentRow As Integer = 15 + cboFontName.Height + 15
        Dim RowIncr As Integer = 22
        Dim CurrentCol As Integer = 15
        Dim ColIncr As Integer = 23
        Dim ColIdx As Integer

        For lintArrInc = 0 To btnSlot.Length - 1 'Step i + 1
            btnSlot(lintArrInc) = New Button()

            btnSlot(lintArrInc).BackColor = System.Drawing.SystemColors.ControlLightLight
            btnSlot(lintArrInc).FlatStyle = System.Windows.Forms.FlatStyle.Flat
            btnSlot(lintArrInc).Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            btnSlot(lintArrInc).Size = New System.Drawing.Size(24, 23)
            btnSlot(lintArrInc).TabIndex = 0
            btnSlot(lintArrInc).TabStop = False
            btnSlot(lintArrInc).Text = ChrGet(lintArrInc)

            btnSlot(lintArrInc).Location = New Point(CurrentCol, CurrentRow)
            ColIdx += 1

            If ColIdx >= 16 Then
                CurrentRow += RowIncr
                ColIdx = 0
                CurrentCol = 0
                CurrentCol = (CurrentCol - ColIncr) + 15
            End If

            CurrentCol += ColIncr

            AddHandler btnSlot(lintArrInc).Click, AddressOf Me.btnSlot_Click
            ''AddHandler btnSlot(lintArrInc).DoubleClick, AddressOf Me.btnSlot_DoubleClick

            Me.Controls.Add(btnSlot(lintArrInc))
        Next

        Me.Text = LangText.GetString("Symbol_Title").Replace("&", "")
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ShowInTaskbar = False 
        Me.KeyPreview = True
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnOK, Me.btnCancel, Me.cboFontName})

        '--- load font styles ---
        Dim CurrentFontNameIdx As Integer = -2
        With cboFontName
            Dim ff As FontFamily
            For Each ff In System.Drawing.FontFamily.Families
                .Items.Add(ff.Name)
            Next ff
            .Text = "Arial"
        End With
        '---

    End Sub
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        mstrReturnFont = cboFontName.Text

        Me.Close()
        'Me.Dispose()

    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        mstrReturnFont = ""
        mstrReturnChar = ""

        Me.Close()
        'Me.Dispose()

    End Sub
    Private Sub DatePicker_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If

    End Sub
    Dim LastClicked As DateTime

    Protected Sub btnSlot_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        mstrReturnChar = (CType(sender, Button).Text)

        
        Dim TimeNow As DateTime = Date.Now
        Dim ClickDifference As Double = TimeNow.Subtract(LastClicked).TotalMilliseconds()
        If ClickDifference < 1000 And ClickDifference <> 0 Then
            btnOK_Click(Nothing, Nothing)
            'MsgBox("Double-clicked")
        Else
            LastClicked = TimeNow
        End If
        

    End Sub
    'Protected Sub btnSlot_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    '    btnOK_Click(Nothing, Nothing)

    'End Sub
    Private Sub cboFontName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFontName.SelectedIndexChanged

        Dim lintArrInc As Integer
        For lintArrInc = 0 To btnSlot.Length - 1
            Try 
                btnSlot(lintArrInc).Font = New System.Drawing.Font(cboFontName.Text, 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Catch
                Try
                    btnSlot(lintArrInc).Font = New System.Drawing.Font(cboFontName.Text, 9.75!, _
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) 
                Catch
                    Try
                        btnSlot(lintArrInc).Font = New System.Drawing.Font(cboFontName.Text, 9.75!, _
                                       System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) 
                    Catch
                        Try
                            btnSlot(lintArrInc).Font = New System.Drawing.Font(cboFontName.Text, 9.75!, _
                                           System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) 
                        Catch
                            Try
                                btnSlot(lintArrInc).Font = New System.Drawing.Font(cboFontName.Text, 9.75!, _
                                               System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) 
                            Catch
                                If mbooTopMost = True Then Me.Activate() 
                                MessageBox.Show("There was an unexpected Error!")
                            End Try
                        End Try
                    End Try
                End Try
            End Try
        Next lintArrInc

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub Symbol_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
