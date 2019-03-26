Imports System.Collections
Imports System.Text
Imports System.Net
Imports System.Web.HttpUtility
Imports System.IO
Imports System.Xml
Imports System
Imports WinOnly
Imports System.Diagnostics
Public Class Survey
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents cboCompetition As System.Windows.Forms.ComboBox
    Friend WithEvents cboReason As System.Windows.Forms.ComboBox
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents lblApologise As System.Windows.Forms.Label
    Friend WithEvents lblPleaseTellUs As System.Windows.Forms.Label
    Friend WithEvents lblIfYouFOundproblems As System.Windows.Forms.Label
    Friend WithEvents lblWin As System.Windows.Forms.Label
    Friend WithEvents lblIfWeFind As System.Windows.Forms.Label
    Friend WithEvents lblThingsYouMight As System.Windows.Forms.Label
    Friend WithEvents lblIWouldLike As System.Windows.Forms.Label
    Friend WithEvents lblWeWill As System.Windows.Forms.Label
    Friend WithEvents lblThanks As System.Windows.Forms.Label
    Friend WithEvents lblBasicReasons As System.Windows.Forms.Label
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lblOptionalBut As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblOptional1 As System.Windows.Forms.Label
    Friend WithEvents lblOptional2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblApologise = New System.Windows.Forms.Label()
        Me.lblPleaseTellUs = New System.Windows.Forms.Label()
        Me.lblIfYouFOundproblems = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.lblIfWeFind = New System.Windows.Forms.Label()
        Me.lblThingsYouMight = New System.Windows.Forms.Label()
        Me.lblIWouldLike = New System.Windows.Forms.Label()
        Me.lblWeWill = New System.Windows.Forms.Label()
        Me.cboCompetition = New System.Windows.Forms.ComboBox()
        Me.cboReason = New System.Windows.Forms.ComboBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.lblBasicReasons = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.lblOptionalBut = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblOptional1 = New System.Windows.Forms.Label()
        Me.lblOptional2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblApologise
        '
        Me.lblApologise.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApologise.ForeColor = System.Drawing.Color.Gray
        Me.lblApologise.Location = New System.Drawing.Point(8, 24)
        Me.lblApologise.Name = "lblApologise"
        Me.lblApologise.Size = New System.Drawing.Size(576, 23)
        Me.lblApologise.TabIndex = 0
        Me.lblApologise.Text = "We'd like to Apologise for not meeting your needs with Ideaspad!"
        Me.lblApologise.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPleaseTellUs
        '
        Me.lblPleaseTellUs.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleaseTellUs.ForeColor = System.Drawing.Color.Gray
        Me.lblPleaseTellUs.Location = New System.Drawing.Point(32, 56)
        Me.lblPleaseTellUs.Name = "lblPleaseTellUs"
        Me.lblPleaseTellUs.Size = New System.Drawing.Size(456, 23)
        Me.lblPleaseTellUs.TabIndex = 1
        Me.lblPleaseTellUs.Text = "Please tell us where we went wrong"
        '
        'lblIfYouFOundproblems
        '
        Me.lblIfYouFOundproblems.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIfYouFOundproblems.ForeColor = System.Drawing.Color.Gray
        Me.lblIfYouFOundproblems.Location = New System.Drawing.Point(32, 72)
        Me.lblIfYouFOundproblems.Name = "lblIfYouFOundproblems"
        Me.lblIfYouFOundproblems.Size = New System.Drawing.Size(448, 23)
        Me.lblIfYouFOundproblems.TabIndex = 2
        Me.lblIfYouFOundproblems.Text = "e.g. If you've found problems... "
        '
        'lblWin
        '
        Me.lblWin.Font = New System.Drawing.Font("Arial", 12.0!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.ForeColor = System.Drawing.Color.Gray
        Me.lblWin.Location = New System.Drawing.Point(8, 96)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(576, 23)
        Me.lblWin.TabIndex = 3
        Me.lblWin.Text = "Win / Earn a FREE copy of Ideaspad."
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblIfWeFind
        '
        Me.lblIfWeFind.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIfWeFind.ForeColor = System.Drawing.Color.Gray
        Me.lblIfWeFind.Location = New System.Drawing.Point(32, 128)
        Me.lblIfWeFind.Name = "lblIfWeFind"
        Me.lblIfWeFind.Size = New System.Drawing.Size(528, 32)
        Me.lblIfWeFind.TabIndex = 4
        Me.lblIfWeFind.Text = "If we find your feedback useful and / or leads to a product improvement, we will " & _
        "reward you with a free license."
        '
        'lblThingsYouMight
        '
        Me.lblThingsYouMight.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThingsYouMight.ForeColor = System.Drawing.Color.Gray
        Me.lblThingsYouMight.Location = New System.Drawing.Point(32, 168)
        Me.lblThingsYouMight.Name = "lblThingsYouMight"
        Me.lblThingsYouMight.Size = New System.Drawing.Size(528, 40)
        Me.lblThingsYouMight.TabIndex = 5
        Me.lblThingsYouMight.Text = "Things you might include, feedback on the product / website, a new feature or a p" & _
        "roblem. Try and provide as much detail as possible. We may also wish to contact " & _
        "you to discuss your feedback."
        '
        'lblIWouldLike
        '
        Me.lblIWouldLike.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIWouldLike.ForeColor = System.Drawing.Color.Gray
        Me.lblIWouldLike.Location = New System.Drawing.Point(32, 224)
        Me.lblIWouldLike.Name = "lblIWouldLike"
        Me.lblIWouldLike.Size = New System.Drawing.Size(336, 32)
        Me.lblIWouldLike.TabIndex = 6
        Me.lblIWouldLike.Text = "I would like my feedback to be considered for a free license?"
        '
        'lblWeWill
        '
        Me.lblWeWill.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeWill.ForeColor = System.Drawing.Color.Gray
        Me.lblWeWill.Location = New System.Drawing.Point(32, 264)
        Me.lblWeWill.Name = "lblWeWill"
        Me.lblWeWill.Size = New System.Drawing.Size(528, 32)
        Me.lblWeWill.TabIndex = 7
        Me.lblWeWill.Text = "We will contact you if we feel your feedback qualifies, if you don�t hear from us" & _
        ", you will have been unsuccessful."
        '
        'cboCompetition
        '
        Me.cboCompetition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompetition.ForeColor = System.Drawing.Color.Gray
        Me.cboCompetition.Items.AddRange(New Object() {"No", "Yes"})
        Me.cboCompetition.Location = New System.Drawing.Point(384, 224)
        Me.cboCompetition.Name = "cboCompetition"
        Me.cboCompetition.Size = New System.Drawing.Size(72, 21)
        Me.cboCompetition.TabIndex = 0
        '
        'cboReason
        '
        Me.cboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReason.ForeColor = System.Drawing.Color.Gray
        Me.cboReason.Items.AddRange(New Object() {"(Please select)", "Found it too complicated", "Missing an expected feature", "Had a problem", "Wasn't what I thought it would be", "I would have bought the program but it was too expensive", "Just didn't like the program", "Trial expired", "I might be interested in the future", "Other"})
        Me.cboReason.Location = New System.Drawing.Point(191, 312)
        Me.cboReason.Name = "cboReason"
        Me.cboReason.Size = New System.Drawing.Size(222, 21)
        Me.cboReason.TabIndex = 1
        '
        'txtComments
        '
        Me.txtComments.ForeColor = System.Drawing.Color.Gray
        Me.txtComments.Location = New System.Drawing.Point(89, 352)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComments.Size = New System.Drawing.Size(447, 56)
        Me.txtComments.TabIndex = 2
        Me.txtComments.Text = ""
        '
        'txtContactName
        '
        Me.txtContactName.ForeColor = System.Drawing.Color.Gray
        Me.txtContactName.Location = New System.Drawing.Point(197, 432)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(221, 20)
        Me.txtContactName.TabIndex = 3
        Me.txtContactName.Text = "Fred Smith"
        '
        'txtEmail
        '
        Me.txtEmail.ForeColor = System.Drawing.Color.Gray
        Me.txtEmail.Location = New System.Drawing.Point(197, 456)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(221, 20)
        Me.txtEmail.TabIndex = 4
        Me.txtEmail.Text = "joe@example.com"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(226, 488)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(142, 23)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send us your thoughts!"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(381, 488)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        '
        'lblThanks
        '
        Me.lblThanks.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThanks.ForeColor = System.Drawing.Color.Gray
        Me.lblThanks.Location = New System.Drawing.Point(8, 528)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(576, 23)
        Me.lblThanks.TabIndex = 15
        Me.lblThanks.Text = "Thanks in Advance!"
        Me.lblThanks.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBasicReasons
        '
        Me.lblBasicReasons.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBasicReasons.ForeColor = System.Drawing.Color.Gray
        Me.lblBasicReasons.Location = New System.Drawing.Point(56, 304)
        Me.lblBasicReasons.Name = "lblBasicReasons"
        Me.lblBasicReasons.Size = New System.Drawing.Size(128, 23)
        Me.lblBasicReasons.TabIndex = 16
        Me.lblBasicReasons.Text = "Basic Reasons :"
        Me.lblBasicReasons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblComments
        '
        Me.lblComments.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.ForeColor = System.Drawing.Color.Gray
        Me.lblComments.Location = New System.Drawing.Point(88, 336)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(184, 16)
        Me.lblComments.TabIndex = 17
        Me.lblComments.Text = "Problem / Comments :"
        '
        'lblOptionalBut
        '
        Me.lblOptionalBut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptionalBut.ForeColor = System.Drawing.Color.Lime
        Me.lblOptionalBut.Location = New System.Drawing.Point(264, 336)
        Me.lblOptionalBut.Name = "lblOptionalBut"
        Me.lblOptionalBut.Size = New System.Drawing.Size(216, 16)
        Me.lblOptionalBut.TabIndex = 18
        Me.lblOptionalBut.Text = "(Optional, but we'd be grateful!)"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Gray
        Me.lblName.Location = New System.Drawing.Point(72, 432)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(120, 23)
        Me.lblName.TabIndex = 19
        Me.lblName.Text = "Name :"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gray
        Me.lblEmail.Location = New System.Drawing.Point(80, 456)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(112, 23)
        Me.lblEmail.TabIndex = 20
        Me.lblEmail.Text = "E-mail :"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOptional1
        '
        Me.lblOptional1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptional1.ForeColor = System.Drawing.Color.Lime
        Me.lblOptional1.Location = New System.Drawing.Point(424, 432)
        Me.lblOptional1.Name = "lblOptional1"
        Me.lblOptional1.Size = New System.Drawing.Size(120, 16)
        Me.lblOptional1.TabIndex = 21
        Me.lblOptional1.Text = "(Optional)"
        '
        'lblOptional2
        '
        Me.lblOptional2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptional2.ForeColor = System.Drawing.Color.Lime
        Me.lblOptional2.Location = New System.Drawing.Point(424, 456)
        Me.lblOptional2.Name = "lblOptional2"
        Me.lblOptional2.Size = New System.Drawing.Size(120, 16)
        Me.lblOptional2.TabIndex = 22
        Me.lblOptional2.Text = "(Optional)"
        '
        'Survey
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(592, 582)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblOptional2, Me.lblOptional1, Me.lblEmail, Me.lblName, Me.lblOptionalBut, Me.lblComments, Me.lblBasicReasons, Me.lblThanks, Me.btnCancel, Me.btnSend, Me.txtEmail, Me.txtContactName, Me.txtComments, Me.cboReason, Me.cboCompetition, Me.lblWeWill, Me.lblIWouldLike, Me.lblThingsYouMight, Me.lblIfWeFind, Me.lblWin, Me.lblIfYouFOundproblems, Me.lblPleaseTellUs, Me.lblApologise})
        Me.Name = "Survey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Survey"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Enum SubmissionValues
        Sucess
        Failure
    End Enum
    Dim mstrSession As String
    Public Property Session() As String
        Get

            Return mstrSession
        End Get
        Set(ByVal Value As String)
            mstrSession = Value
        End Set
    End Property
    Dim LangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("Beside03.Beside03", _
        System.Reflection.Assembly.GetExecutingAssembly())
    Private StandLangText As System.Resources.ResourceManager = New _
        System.Resources.ResourceManager("AppBasic.AppBasic", _
        System.Reflection.Assembly.Load("AppBasic")) 
    Dim lstrCaption As String 
    Private Sub Survey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IsAboveOrEqualWinXp() = True Then
            btnSend.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If

        Dim lstrLanguage As String = ""
        Try
            Dim ThisAssName As String = System.Reflection.Assembly.GetEntryAssembly.GetName.Name.ToString
            Dim ThisLocation As String = System.Reflection.Assembly.GetEntryAssembly.Location.ToString
            Dim IdeaspadDataFile As String = Replace(ThisLocation, ThisAssName, "IdeasPad") & ".dat"

            lstrLanguage = AppBasic.GetSetting("Language", "", InitalXMLConfig.XmlConfigType.AppSettings, "", IdeaspadDataFile)

            If lstrLanguage = "" Then

                Dim myBaseItem As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( _
                    "SOFTWARE\Mindwarp Consultancy Ltd\Ideaspad", True)

                If Not myBaseItem Is Nothing Then
                    lstrLanguage = CType(myBaseItem.GetValue("Language", ""), String)
                    SaveSetting("Language", lstrLanguage, InitalXMLConfig.XmlConfigType.AppSettings, "", IdeaspadDataFile)

                End If

            End If

            If lstrLanguage = "" Then
                Dim LangSel As New ls()
                With LangSel
                    .FormIcon = New System.Drawing.Icon( _
                        System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("IdeasPad.mcl32.ico"))
                    Dim Res As New IPIconsPack.Resource()
                    .MCLLogo = Res.picMCLLogo.Image 
                    .ShowDialog()
                    lstrLanguage = .Lang2Letters
                End With
                SaveSetting("Language", lstrLanguage, InitalXMLConfig.XmlConfigType.AppSettings, "", IdeaspadDataFile)

                
            End If
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(LeftGet(lstrLanguage, 2).ToLower)

        Catch
            '
        End Try

        cboCompetition.SelectedIndex = 0
        cboReason.SelectedIndex = 0

        Dim MainAppConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings, "", System.Reflection.Assembly.GetEntryAssembly.Location.ToString().Replace("Beside03", "IdeasPad") & ".dat")

        txtContactName.Text = MainAppConfig.GetValue("ContactName", "")
        txtEmail.Text = MainAppConfig.GetValue("Email", "")

        lstrCaption = LangText.GetString("Beside03_Caption")

        lblApologise.Text = LangText.GetString("Beside03_Apologise")
        lblPleaseTellUs.Text = LangText.GetString("Beside03_PleaseTellUs")
        lblIfYouFOundproblems.Text = LangText.GetString("Beside03_IfYouFoundProblems")
        lblWin.Text = LangText.GetString("Beside03_Win")

        lblIfWeFind.Text = LangText.GetString("Beside03_IfWeFind")
        lblThingsYouMight.Text = LangText.GetString("Beside03_ThingsYouMight")
        lblIWouldLike.Text = LangText.GetString("Beside03_IWouldLike")

        cboCompetition.Items.Clear()
        cboCompetition.Items.Add(StandLangText.GetString("StandText_No"))
        cboCompetition.Items.Add(StandLangText.GetString("StandText_Yes"))
        cboCompetition.SelectedIndex = 0

        lblWeWill.Text = LangText.GetString("Beside03_WeWill")
        lblBasicReasons.Text = LangText.GetString("Beside03_BasicReasons")

        cboReason.Items.Clear()
        cboReason.Items.Add(LangText.GetString("Beside03_BasicReasonsPleaseSelect"))
        cboReason.Items.Add(LangText.GetString("Beside03_BasicReasonFoundTooComp"))
        cboReason.Items.Add(LangText.GetString("Beside03_BasicReasonsMissingAn"))
        cboReason.Items.Add(LangText.GetString("Beside03_BasicReasonsHadAProb"))
        cboReason.Items.Add(LangText.GetString("Beside03_BasicReasonsWasntWhatThought"))
        cboReason.Items.Add(LangText.GetString("Beside03_BasicReasonsWouldExpensive"))
        cboReason.Items.Add(LangText.GetString("Beside03_BasicReasonsJustDidntLike"))
        cboReason.Items.Add(LangText.GetString("Beside03_BasicReasonsTrialExpired"))
        cboReason.Items.Add(LangText.GetString("Beside03_BasicReasonsMightFuture"))
        cboReason.Items.Add(LangText.GetString("Beside03_BasicReasonsOther"))
        cboReason.SelectedIndex = 0

        lblComments.Text = LangText.GetString("Beside03_Comments")
        lblOptionalBut.Text = LangText.GetString("Beside03_OptionalBut")

        lblName.Text = LangText.GetString("Beside03_YourName")
        lblEmail.Text = LangText.GetString("Beside03_YourEmail")
        lblOptional1.Text = LangText.GetString("Beside03_Optional")
        lblOptional2.Text = LangText.GetString("Beside03_Optional")

        btnSend.Text = LangText.GetString("Beside03_SendUsYourThoughts")
        btnCancel.Text = StandLangText.GetString("StandText_Cancel")

        lblThanks.Text = LangText.GetString("Beside03_lblThanks")

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click


        BusyBug(True)

        Dim lbooSucess As SubmissionValues = SubmissionValues.Failure
        lbooSucess = Submit(txtEmail.Text) 'this read current and previous dumps and sends them
        'now you can clear log?

        Dim BugSendStatus As New StatusDialog(Me)

        BugSendStatus.Show()

        BugSendStatus.Status = LangText.GetString("Beside03_Sent") 
        Application.DoEvents()


        BugSendStatus.Close()
        Application.DoEvents()

        BusyBug(False)

        If lbooSucess = SubmissionValues.Sucess Then
            MessageBox.Show(LangText.GetString("Beside03_SentOK"), lstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Information) 
        Else
            MessageBox.Show(LangText.GetString("Beside03_FailedToSend"), lstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning) 

        End If

        Me.Close()

    End Sub
    Private Function Submit(ByVal pstrEmail As String) As SubmissionValues
        Dim BugSendStatus As New StatusDialog(Me)

        Try
            Submit = SubmissionValues.Failure
            Dim client As New WebClient()

            With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly.Location.Replace("Beside03.exe", "IdeasPad.exe"))
                client.Headers.Add("User-Agent", .ProductName & " V" & .ProductVersion)
            End With

            Dim form As New System.Collections.Specialized.NameValueCollection()
            Dim lstrVerifyCode As String = Date.Now.ToString("dddd-dd-MMM-yyyy-HH-mm-ss")

            BugSendStatus.Show()
            BugSendStatus.Status = LangText.GetString("Beside03_Sending")
            Application.DoEvents()

            form.Add("verification", lstrVerifyCode)

            If txtContactName.Text <> "" Then
                form.Add("realname", txtContactName.Text)
            End If

            If pstrEmail <> "" Then
                form.Add("email", pstrEmail)
            End If

            form.Add("detail", txtComments.Text)
            form.Add("Reason", cboReason.Text)
            form.Add("Competition", cboCompetition.Text)
            form.Add("session", mstrSession)

            Application.DoEvents()

            Dim responseData As [Byte]() = client.UploadValues("http://www.example.com/_ipdsurvey.php", form)


            Dim response As String = Encoding.ASCII.GetString(responseData)

            'MsgBox(response.ToLower, MsgBoxStyle.Information, lstrVerifyCode.ToLower)

            If InStrGet(response.ToLower, "<verification>" & lstrVerifyCode.ToLower & "</verification>") > 0 Then
                Submit = SubmissionValues.Sucess
            End If

        Catch webEx As WebException
            MessageBox.Show(webEx.Message, lstrCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        BugSendStatus.Close()
        Application.DoEvents()

    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub
    Private Sub BusyBug(ByVal pbool As Boolean)

        Busy(Me, pbool)

        If pbool = True Then pbool = False Else pbool = True

        btnSend.Enabled = pbool
        btnCancel.Enabled = pbool
        txtEmail.Enabled = pbool
        txtComments.Enabled = pbool
        txtContactName.Enabled = pbool

    End Sub

    Private Sub lblThingsYouMight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblThingsYouMight.Click

    End Sub

    Private Sub lblWeWill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblWeWill.Click

    End Sub
End Class
