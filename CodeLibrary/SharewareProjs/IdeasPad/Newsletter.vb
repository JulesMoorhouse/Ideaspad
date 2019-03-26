Imports System.Net
Imports System.Web.HttpUtility
Imports System.Text
Public Class Newsletter
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblInFuture As System.Windows.Forms.Label
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkDontSendMeEmails As System.Windows.Forms.CheckBox
    Friend WithEvents chkDontShow As System.Windows.Forms.CheckBox
    Friend WithEvents lblContactName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblInFuture = New System.Windows.Forms.Label()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkDontSendMeEmails = New System.Windows.Forms.CheckBox()
        Me.chkDontShow = New System.Windows.Forms.CheckBox()
        Me.lblContactName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(13, 7)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(331, 20)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Label1"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInFuture
        '
        Me.lblInFuture.Location = New System.Drawing.Point(13, 32)
        Me.lblInFuture.Name = "lblInFuture"
        Me.lblInFuture.Size = New System.Drawing.Size(354, 34)
        Me.lblInFuture.TabIndex = 1
        Me.lblInFuture.Text = "Label1"
        '
        'txtContactName
        '
        Me.txtContactName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactName.Location = New System.Drawing.Point(120, 78)
        Me.txtContactName.MaxLength = 100
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(248, 23)
        Me.txtContactName.TabIndex = 0
        Me.txtContactName.Text = ""
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(120, 108)
        Me.txtEmail.MaxLength = 255
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(248, 23)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.Text = ""
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(208, 184)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "Button1"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(288, 184)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Button2"
        '
        'chkDontSendMeEmails
        '
        Me.chkDontSendMeEmails.Location = New System.Drawing.Point(120, 138)
        Me.chkDontSendMeEmails.Name = "chkDontSendMeEmails"
        Me.chkDontSendMeEmails.Size = New System.Drawing.Size(248, 16)
        Me.chkDontSendMeEmails.TabIndex = 2
        Me.chkDontSendMeEmails.Text = "CheckBox1"
        '
        'chkDontShow
        '
        Me.chkDontShow.Location = New System.Drawing.Point(120, 156)
        Me.chkDontShow.Name = "chkDontShow"
        Me.chkDontShow.Size = New System.Drawing.Size(240, 16)
        Me.chkDontShow.TabIndex = 3
        Me.chkDontShow.Text = "CheckBox2"
        '
        'lblContactName
        '
        Me.lblContactName.Location = New System.Drawing.Point(16, 78)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.TabIndex = 8
        Me.lblContactName.Text = "Label1"
        Me.lblContactName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(16, 108)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Label2"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Newsletter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(379, 214)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblEmail, Me.lblContactName, Me.chkDontShow, Me.chkDontSendMeEmails, Me.btnCancel, Me.btnSend, Me.txtEmail, Me.txtContactName, Me.lblInFuture, Me.lblWelcome})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Newsletter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newsletter"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly())

    Dim StandLangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("AppBasic.AppBasic", _
        System.Reflection.Assembly.Load("AppBasic"))

    Dim mbooFromMenu As Boolean = False
    Public Property FromMenu() As Boolean
        Get
            Return mbooFromMenu
        End Get
        Set(ByVal Value As Boolean)
            mbooFromMenu = Value
        End Set
    End Property

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblContactName.Click

    End Sub

    Private Sub Newsletter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IsAboveOrEqualWinXp() = True Then
            btnSend.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If

        SetBackcolors()

        If System.IO.File.Exists(System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat") = False Then
            GetSetting("Default Information Base File", "", InitalXMLConfig.XmlConfigType.AppSettings, "")
        End If



        lblWelcome.Text = LangText.GetString("NewsLetters_Welcome").Replace("[ProdName]", NameMe(""))
        lblInFuture.Text = LangText.GetString("NewsLetters_InFuture")
        lblContactName.Text = LangText.GetString("NewsLetters_ContactName")
        lblEmail.Text = LangText.GetString("NewsLetters_Email")
        btnSend.Text = LangText.GetString("NewsLetters_Send")
        btnCancel.Text = StandLangText.GetString("StandText_Cancel")
        chkDontSendMeEmails.Text = LangText.GetString("Newsletters_IDontWishRecieve")
        chkDontShow.Text = LangText.GetString("NewsLetters_DontShowMeAgain")

        If mbooFromMenu = True Then
            chkDontShow.Visible = False
            chkDontSendMeEmails.Visible = False 
        End If

    End Sub
    Private Sub BusyBug(ByVal pbool As Boolean)

        Busy(Me, pbool)

        If pbool = True Then pbool = False Else pbool = True

        btnSend.Enabled = pbool
        btnCancel.Enabled = pbool
        txtEmail.Enabled = pbool
        txtContactName.Enabled = pbool

    End Sub
    Sub SetBackcolors()

        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        lblContactName.BackColor = Color.FromArgb(0, lblContactName.BackColor)
        lblEmail.BackColor = Color.FromArgb(0, lblEmail.BackColor)
        btnSend.BackColor = Color.FromArgb(0, btnSend.BackColor)

        chkDontSendMeEmails.BackColor = Color.FromArgb(0, chkDontSendMeEmails.BackColor)
        chkDontShow.BackColor = Color.FromArgb(0, chkDontShow.BackColor)
        lblWelcome.BackColor = Color.FromArgb(0, lblWelcome.BackColor)
        lblInFuture.BackColor = Color.FromArgb(0, lblInFuture.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub Newsletter_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate()
    End Sub

    Private Sub Newsletter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        If mbooFromMenu = False Then
            SaveSetting("NewsletterDlg", CStr(Not chkDontShow.Checked), InitalXMLConfig.XmlConfigType.AppSettings, "")
        End If

        Me.Close()

    End Sub

    Private Sub btnSend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSend.Click


        If CheckEmailAddress(txtEmail.Text) = "" Then
            MessageBox.Show(LangText.GetString("Newsletters_PleaseCheckEmail"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            BusyBug(True)
            'SEND STUFF HERE
            '----
            Try
                Dim client As New WebClient()

                With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly.Location)
                    client.Headers.Add("User-Agent", .ProductName & " V" & .ProductVersion)
                End With

                Dim form As New System.Collections.Specialized.NameValueCollection()
                Dim lstrVerifyCode As String = Date.Now.ToString("dddd-dd-MMM-yyyy-HH-mm-ss")

                form.Add("verification", lstrVerifyCode)

                form.Add("from", txtEmail.Text)
                form.Add("username", txtContactName.Text)
                
                Try
                    Dim lstrLanguage As String
                    lstrLanguage = GetSetting("Language", "", InitalXMLConfig.XmlConfigType.AppSettings, "")
                    form.Add("language", lstrLanguage)
                Catch
                    '
                End Try
                

                Application.DoEvents()

                Dim responseData As [Byte]() = client.UploadValues("http://www.example.com/php/ipdnews.php", form)
                'Console.WriteLine("RD: " & Encoding.ASCII.GetString(responseData))

                Dim response As String = Encoding.ASCII.GetString(responseData)

                If InStrGet(response.ToLower, "<verification>" & lstrVerifyCode.ToLower & "</verification>") > 0 Then
                    MessageBox.Show(LangText.GetString("Newsletters_InformationSentOK"))
                    SaveSetting("ContactName", txtContactName.Text, InitalXMLConfig.XmlConfigType.DebugReports, "")
                    SaveSetting("Email", txtEmail.Text, InitalXMLConfig.XmlConfigType.DebugReports, "")
                    SaveSetting("NewsletterDlg", "False", InitalXMLConfig.XmlConfigType.AppSettings, "")
                Else
                    MessageBox.Show(LangText.GetString("Newsletters_InformationFailedToSend"))
                End If

            Catch webEx As WebException
                    'If webEx.Status = WebExceptionStatus.ConnectFailure Then
                    '    Console.WriteLine("Are you behind a firewall?  If so, go through the proxy server.")
                    'End If
                    'Console.Write(webEx.ToString())
                    MessageBox.Show(webEx.Message, NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                '----
                BusyBug(True)

        End If

        Me.Close()

    End Sub

    Private Sub chkDontSendMeEmails_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDontSendMeEmails.CheckedChanged


        If chkDontSendMeEmails.Checked = True Then
            btnSend.Enabled = False
        Else
            btnSend.Enabled = True
        End If

    End Sub
End Class
