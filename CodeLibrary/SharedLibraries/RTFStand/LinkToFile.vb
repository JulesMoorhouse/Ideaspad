Public Class LinkToFile
    Inherits System.Windows.Forms.Form
    Dim mstrReturnFile As String
    Public Property ReturnFile() As String
        Get
            Return mstrReturnFile
        End Get
        Set(ByVal Value As String)
            mstrReturnFile = Value
        End Set
    End Property
    Friend WithEvents txtFile As TextBox
    Private lblFile As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCancel As Button

    Public Sub New()

        Dim StandLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))

        Dim LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("RTFStand.RTFStand", _
            System.Reflection.Assembly.GetExecutingAssembly())

        txtFile = New TextBox()
        lblFile = New Label()
        btnOK = New Button()
        btnBrowse = New Button()
        btnCancel = New Button()

        With txtFile
            .Top = 10
            .Left = 100
            .Width = 300
            .TabIndex = 1
            .Text = ""
        End With

        With lblFile
            .Top = txtFile.Top
            .Left = 10
            .Width = 85
            .Text = "File / Program :"
            .Text = LangText.GetString("LinkToFile_FileProgram")
            .TextAlign = ContentAlignment.MiddleRight
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        Me.Width = txtFile.Left + txtFile.Width + 20

        With btnBrowse
            .Left = ((Me.Width) - .Width) - 20
            .Top = txtFile.Top + txtFile.Height + 10
            .TabIndex = 3
            .Text = StandLangText.GetString("StandText_Browse")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        With btnCancel
            .Left = ((Me.Width) - .Width) - 20
            .Top = btnBrowse.Top + btnBrowse.Height + 10
            .TabIndex = 3
            .Text = StandLangText.GetString("StandText_Cancel")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        With btnOK
            .Left = (btnCancel.Left - .Width) - 10
            .Top = btnBrowse.Top + btnBrowse.Height + 10
            .TabIndex = 2
            .Text = StandLangText.GetString("StandText_OK")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        Me.Text = LangText.GetString("LinkToFile_Title").Replace("&", "")
        Me.Height = btnOK.Top + btnOK.Height + 40
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ShowInTaskbar = False 
        Me.KeyPreview = True
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtFile, Me.lblFile, Me.btnBrowse, Me.btnOK, Me.btnCancel})
    End Sub
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        mstrReturnFile = "file://" & Web.HttpUtility.UrlEncode(txtFile.Text)

        Me.Close()
        'Me.Dispose()

    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        mstrReturnFile = ""
        Me.Close()
        'Me.Dispose()

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub
    Private Sub txtFile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFile.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnOK_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub LinkToFile_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        Dim OpenFile As New OpenFileDialog()
        With OpenFile
            .CheckPathExists = True
            .RestoreDirectory = True 

            If .ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            txtFile.Text = .FileName
        End With

    End Sub

    Private Sub LinkToFile_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
