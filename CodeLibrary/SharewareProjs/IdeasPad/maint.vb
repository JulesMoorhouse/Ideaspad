Imports ADOX
Imports System.Drawing.Printing
Friend Class frmMaint
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Friend Sub New()
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
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRepair As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMaint))
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRepair = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.AccessibleDescription = CType(resources.GetObject("btnNew.AccessibleDescription"), String)
        Me.btnNew.AccessibleName = CType(resources.GetObject("btnNew.AccessibleName"), String)
        Me.btnNew.Anchor = CType(resources.GetObject("btnNew.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
        Me.btnNew.Dock = CType(resources.GetObject("btnNew.Dock"), System.Windows.Forms.DockStyle)
        Me.btnNew.Enabled = CType(resources.GetObject("btnNew.Enabled"), Boolean)
        Me.btnNew.FlatStyle = CType(resources.GetObject("btnNew.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnNew.Font = CType(resources.GetObject("btnNew.Font"), System.Drawing.Font)
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = CType(resources.GetObject("btnNew.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnNew.ImageIndex = CType(resources.GetObject("btnNew.ImageIndex"), Integer)
        Me.btnNew.ImeMode = CType(resources.GetObject("btnNew.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnNew.Location = CType(resources.GetObject("btnNew.Location"), System.Drawing.Point)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.RightToLeft = CType(resources.GetObject("btnNew.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnNew.Size = CType(resources.GetObject("btnNew.Size"), System.Drawing.Size)
        Me.btnNew.TabIndex = CType(resources.GetObject("btnNew.TabIndex"), Integer)
        Me.btnNew.Text = resources.GetString("btnNew.Text")
        Me.btnNew.TextAlign = CType(resources.GetObject("btnNew.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnNew.Visible = CType(resources.GetObject("btnNew.Visible"), Boolean)
        '
        'btnRename
        '
        Me.btnRename.AccessibleDescription = CType(resources.GetObject("btnRename.AccessibleDescription"), String)
        Me.btnRename.AccessibleName = CType(resources.GetObject("btnRename.AccessibleName"), String)
        Me.btnRename.Anchor = CType(resources.GetObject("btnRename.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnRename.BackgroundImage = CType(resources.GetObject("btnRename.BackgroundImage"), System.Drawing.Image)
        Me.btnRename.Dock = CType(resources.GetObject("btnRename.Dock"), System.Windows.Forms.DockStyle)
        Me.btnRename.Enabled = CType(resources.GetObject("btnRename.Enabled"), Boolean)
        Me.btnRename.FlatStyle = CType(resources.GetObject("btnRename.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnRename.Font = CType(resources.GetObject("btnRename.Font"), System.Drawing.Font)
        Me.btnRename.Image = CType(resources.GetObject("btnRename.Image"), System.Drawing.Image)
        Me.btnRename.ImageAlign = CType(resources.GetObject("btnRename.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnRename.ImageIndex = CType(resources.GetObject("btnRename.ImageIndex"), Integer)
        Me.btnRename.ImeMode = CType(resources.GetObject("btnRename.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnRename.Location = CType(resources.GetObject("btnRename.Location"), System.Drawing.Point)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.RightToLeft = CType(resources.GetObject("btnRename.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnRename.Size = CType(resources.GetObject("btnRename.Size"), System.Drawing.Size)
        Me.btnRename.TabIndex = CType(resources.GetObject("btnRename.TabIndex"), Integer)
        Me.btnRename.Text = resources.GetString("btnRename.Text")
        Me.btnRename.TextAlign = CType(resources.GetObject("btnRename.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnRename.Visible = CType(resources.GetObject("btnRename.Visible"), Boolean)
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleDescription = CType(resources.GetObject("btnDelete.AccessibleDescription"), String)
        Me.btnDelete.AccessibleName = CType(resources.GetObject("btnDelete.AccessibleName"), String)
        Me.btnDelete.Anchor = CType(resources.GetObject("btnDelete.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.Dock = CType(resources.GetObject("btnDelete.Dock"), System.Windows.Forms.DockStyle)
        Me.btnDelete.Enabled = CType(resources.GetObject("btnDelete.Enabled"), Boolean)
        Me.btnDelete.FlatStyle = CType(resources.GetObject("btnDelete.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnDelete.Font = CType(resources.GetObject("btnDelete.Font"), System.Drawing.Font)
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = CType(resources.GetObject("btnDelete.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnDelete.ImageIndex = CType(resources.GetObject("btnDelete.ImageIndex"), Integer)
        Me.btnDelete.ImeMode = CType(resources.GetObject("btnDelete.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnDelete.Location = CType(resources.GetObject("btnDelete.Location"), System.Drawing.Point)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeft = CType(resources.GetObject("btnDelete.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnDelete.Size = CType(resources.GetObject("btnDelete.Size"), System.Drawing.Size)
        Me.btnDelete.TabIndex = CType(resources.GetObject("btnDelete.TabIndex"), Integer)
        Me.btnDelete.Text = resources.GetString("btnDelete.Text")
        Me.btnDelete.TextAlign = CType(resources.GetObject("btnDelete.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnDelete.Visible = CType(resources.GetObject("btnDelete.Visible"), Boolean)
        '
        'btnOpen
        '
        Me.btnOpen.AccessibleDescription = CType(resources.GetObject("btnOpen.AccessibleDescription"), String)
        Me.btnOpen.AccessibleName = CType(resources.GetObject("btnOpen.AccessibleName"), String)
        Me.btnOpen.Anchor = CType(resources.GetObject("btnOpen.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.BackgroundImage = CType(resources.GetObject("btnOpen.BackgroundImage"), System.Drawing.Image)
        Me.btnOpen.Dock = CType(resources.GetObject("btnOpen.Dock"), System.Windows.Forms.DockStyle)
        Me.btnOpen.Enabled = CType(resources.GetObject("btnOpen.Enabled"), Boolean)
        Me.btnOpen.FlatStyle = CType(resources.GetObject("btnOpen.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnOpen.Font = CType(resources.GetObject("btnOpen.Font"), System.Drawing.Font)
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageAlign = CType(resources.GetObject("btnOpen.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnOpen.ImageIndex = CType(resources.GetObject("btnOpen.ImageIndex"), Integer)
        Me.btnOpen.ImeMode = CType(resources.GetObject("btnOpen.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnOpen.Location = CType(resources.GetObject("btnOpen.Location"), System.Drawing.Point)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.RightToLeft = CType(resources.GetObject("btnOpen.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnOpen.Size = CType(resources.GetObject("btnOpen.Size"), System.Drawing.Size)
        Me.btnOpen.TabIndex = CType(resources.GetObject("btnOpen.TabIndex"), Integer)
        Me.btnOpen.Text = resources.GetString("btnOpen.Text")
        Me.btnOpen.TextAlign = CType(resources.GetObject("btnOpen.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnOpen.Visible = CType(resources.GetObject("btnOpen.Visible"), Boolean)
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleDescription = CType(resources.GetObject("btnCancel.AccessibleDescription"), String)
        Me.btnCancel.AccessibleName = CType(resources.GetObject("btnCancel.AccessibleName"), String)
        Me.btnCancel.Anchor = CType(resources.GetObject("btnCancel.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Dock = CType(resources.GetObject("btnCancel.Dock"), System.Windows.Forms.DockStyle)
        Me.btnCancel.Enabled = CType(resources.GetObject("btnCancel.Enabled"), Boolean)
        Me.btnCancel.FlatStyle = CType(resources.GetObject("btnCancel.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnCancel.Font = CType(resources.GetObject("btnCancel.Font"), System.Drawing.Font)
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = CType(resources.GetObject("btnCancel.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnCancel.ImageIndex = CType(resources.GetObject("btnCancel.ImageIndex"), Integer)
        Me.btnCancel.ImeMode = CType(resources.GetObject("btnCancel.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnCancel.Location = CType(resources.GetObject("btnCancel.Location"), System.Drawing.Point)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = CType(resources.GetObject("btnCancel.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnCancel.Size = CType(resources.GetObject("btnCancel.Size"), System.Drawing.Size)
        Me.btnCancel.TabIndex = CType(resources.GetObject("btnCancel.TabIndex"), Integer)
        Me.btnCancel.Text = resources.GetString("btnCancel.Text")
        Me.btnCancel.TextAlign = CType(resources.GetObject("btnCancel.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnCancel.Visible = CType(resources.GetObject("btnCancel.Visible"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = CType(resources.GetObject("Label1.AccessibleDescription"), String)
        Me.Label1.AccessibleName = CType(resources.GetObject("Label1.AccessibleName"), String)
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = CType(resources.GetObject("Label4.AccessibleDescription"), String)
        Me.Label4.AccessibleName = CType(resources.GetObject("Label4.AccessibleName"), String)
        Me.Label4.Anchor = CType(resources.GetObject("Label4.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = CType(resources.GetObject("Label4.AutoSize"), Boolean)
        Me.Label4.Dock = CType(resources.GetObject("Label4.Dock"), System.Windows.Forms.DockStyle)
        Me.Label4.Enabled = CType(resources.GetObject("Label4.Enabled"), Boolean)
        Me.Label4.Font = CType(resources.GetObject("Label4.Font"), System.Drawing.Font)
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = CType(resources.GetObject("Label4.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label4.ImageIndex = CType(resources.GetObject("Label4.ImageIndex"), Integer)
        Me.Label4.ImeMode = CType(resources.GetObject("Label4.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label4.Location = CType(resources.GetObject("Label4.Location"), System.Drawing.Point)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = CType(resources.GetObject("Label4.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label4.Size = CType(resources.GetObject("Label4.Size"), System.Drawing.Size)
        Me.Label4.TabIndex = CType(resources.GetObject("Label4.TabIndex"), Integer)
        Me.Label4.Text = resources.GetString("Label4.Text")
        Me.Label4.TextAlign = CType(resources.GetObject("Label4.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label4.Visible = CType(resources.GetObject("Label4.Visible"), Boolean)
        '
        'btnRepair
        '
        Me.btnRepair.AccessibleDescription = CType(resources.GetObject("btnRepair.AccessibleDescription"), String)
        Me.btnRepair.AccessibleName = CType(resources.GetObject("btnRepair.AccessibleName"), String)
        Me.btnRepair.Anchor = CType(resources.GetObject("btnRepair.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnRepair.BackgroundImage = CType(resources.GetObject("btnRepair.BackgroundImage"), System.Drawing.Image)
        Me.btnRepair.Dock = CType(resources.GetObject("btnRepair.Dock"), System.Windows.Forms.DockStyle)
        Me.btnRepair.Enabled = CType(resources.GetObject("btnRepair.Enabled"), Boolean)
        Me.btnRepair.FlatStyle = CType(resources.GetObject("btnRepair.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnRepair.Font = CType(resources.GetObject("btnRepair.Font"), System.Drawing.Font)
        Me.btnRepair.Image = CType(resources.GetObject("btnRepair.Image"), System.Drawing.Image)
        Me.btnRepair.ImageAlign = CType(resources.GetObject("btnRepair.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnRepair.ImageIndex = CType(resources.GetObject("btnRepair.ImageIndex"), Integer)
        Me.btnRepair.ImeMode = CType(resources.GetObject("btnRepair.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnRepair.Location = CType(resources.GetObject("btnRepair.Location"), System.Drawing.Point)
        Me.btnRepair.Name = "btnRepair"
        Me.btnRepair.RightToLeft = CType(resources.GetObject("btnRepair.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnRepair.Size = CType(resources.GetObject("btnRepair.Size"), System.Drawing.Size)
        Me.btnRepair.TabIndex = CType(resources.GetObject("btnRepair.TabIndex"), Integer)
        Me.btnRepair.Text = resources.GetString("btnRepair.Text")
        Me.btnRepair.TextAlign = CType(resources.GetObject("btnRepair.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnRepair.Visible = CType(resources.GetObject("btnRepair.Visible"), Boolean)
        '
        'btnHelp
        '
        Me.btnHelp.AccessibleDescription = CType(resources.GetObject("btnHelp.AccessibleDescription"), String)
        Me.btnHelp.AccessibleName = CType(resources.GetObject("btnHelp.AccessibleName"), String)
        Me.btnHelp.Anchor = CType(resources.GetObject("btnHelp.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.BackgroundImage = CType(resources.GetObject("btnHelp.BackgroundImage"), System.Drawing.Image)
        Me.btnHelp.Dock = CType(resources.GetObject("btnHelp.Dock"), System.Windows.Forms.DockStyle)
        Me.btnHelp.Enabled = CType(resources.GetObject("btnHelp.Enabled"), Boolean)
        Me.btnHelp.FlatStyle = CType(resources.GetObject("btnHelp.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnHelp.Font = CType(resources.GetObject("btnHelp.Font"), System.Drawing.Font)
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageAlign = CType(resources.GetObject("btnHelp.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnHelp.ImageIndex = CType(resources.GetObject("btnHelp.ImageIndex"), Integer)
        Me.btnHelp.ImeMode = CType(resources.GetObject("btnHelp.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnHelp.Location = CType(resources.GetObject("btnHelp.Location"), System.Drawing.Point)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.RightToLeft = CType(resources.GetObject("btnHelp.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnHelp.Size = CType(resources.GetObject("btnHelp.Size"), System.Drawing.Size)
        Me.btnHelp.TabIndex = CType(resources.GetObject("btnHelp.TabIndex"), Integer)
        Me.btnHelp.Text = resources.GetString("btnHelp.Text")
        Me.btnHelp.TextAlign = CType(resources.GetObject("btnHelp.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnHelp.Visible = CType(resources.GetObject("btnHelp.Visible"), Boolean)
        '
        'frmMaint
        '
        Me.AccessibleDescription = CType(resources.GetObject("$this.AccessibleDescription"), String)
        Me.AccessibleName = CType(resources.GetObject("$this.AccessibleName"), String)
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnHelp, Me.btnRepair, Me.Label4, Me.Label1, Me.btnCancel, Me.btnOpen, Me.btnDelete, Me.btnRename, Me.btnNew})
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.KeyPreview = True
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimizeBox = False
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmMaint"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ShowInTaskbar = False
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend gstrChosenDB As String
    Friend gbooSilentMode As Boolean = False
    Friend gbooDBComplete As Boolean = False
    Private mintSelListIdx As Integer
    Private mintListItemCount As Integer
    Friend lbooUltraQuiet As Boolean = False 

    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
    Friend Property SelListIdx() As Integer
        Get

            Return mintSelListIdx
        End Get
        Set(ByVal Value As Integer)
            mintSelListIdx = Value
        End Set
    End Property
    Friend Property ListItemCount() As Integer
        Get

            Return mintListItemCount
        End Get
        Set(ByVal Value As Integer)
            mintListItemCount = Value
        End Set
    End Property
    Private Sub oldAddNewDB(ByVal pstrFileName As String, ByVal pstrShortName As String)
        Dim lintArrInc As Integer
        Dim lbooAdded As Boolean

        lbooAdded = False
        Busy(Me, True)
        BusyButtons(True) 

        Dim lintMaxHist As Integer = 3
        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then 'Changed to Trial 
            lintMaxHist = 19
        End If
        For lintArrInc = 0 To lintMaxHist
            'If GetSetting(gstrIniAppName, "DBChoice", "FileName" & lintArrInc) = "" Then
            If GetSetting("FileName" & lintArrInc, "", InitalXMLConfig.XmlConfigType.AppSettings, "") = "" Then
                lbooAdded = True
                'SaveSetting(gstrIniAppName, "DBChoice", "FileName" & lintArrInc, pstrFileName)
                'SaveSetting(gstrIniAppName, "DBChoice", "ShortName" & lintArrInc, pstrShortName)
                SaveSetting("FileName" & lintArrInc, pstrFileName, InitalXMLConfig.XmlConfigType.AppSettings, "")
                SaveSetting("ShortName" & lintArrInc, pstrShortName, InitalXMLConfig.XmlConfigType.AppSettings, "")
                ''lstDatabase.Items.Add(pstrFileName)
                ''lstrDBTag(lintCounter - 1) = pstrShortName
                ''lintCounter = lintCounter + 1
                Busy(Me, False)
                BusyButtons(False) 
                Exit For
            End If
        Next lintArrInc

        If gbooSilentMode = False Then
            If lbooAdded = False Then
                Busy(Me, False)
                BusyButtons(False) 
                'Dim lstrDetails(2) As String
                'lstrDetails(0) = "33<a^\b`JQ;BfzvHnC"
                'lstrDetails(1) = "MasHFS@[fmCDEUusrWUhhUGdFtYimg`Il?fy\;psUxYUZqy?`LM`uZFAeYYtE_ZqxOAXuN"
                'lstrDetails(2) = "dj?STCVnAwGkeHxSi_PE]DuJ`eXKqoc^t\;Tnm\;"

                'mxessagebox.show(Decrypt("", "", flame.Encops.EncryptString, lstrDetails), NameMe(""))

                'MsgBox("Your 'Information Base' was not added, you may have execeeded the amount allowed!")
                
                MessageBox.Show(LangText.GetString("Maint_Exceeded").Replace("[Program]", gProgName), _
                    NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props
            Else
                Busy(Me, False)
                BusyButtons(False) 
                'mxessagebox.show("Your 'Information Base' was added!", NameMe(""))
                
                MessageBox.Show(LangText.GetString("Maint_YourIBWasAdded").Replace("[Program]", gProgName), _
                    NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props

            End If
        End If
        Busy(Me, False)
        BusyButtons(False) 
    End Sub

    Friend Sub AddNewDB(ByVal pstrFileName As String, ByVal pstrShortName As String)
        Dim lintArrInc As Integer
        Dim lbooAdded As Boolean

        lbooAdded = False
        Busy(Me, True)

        Dim lintMaxHist As Integer = 3
        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then 'Changed to Trial 
            lintMaxHist = 19
        End If

        Dim lstrFiles(lintMaxHist) As String
        Dim lstrShorts(lintMaxHist) As String
        Dim lintLastArrayItem As Integer
        Dim lintDupeArrInc As Integer

        Dim InitialConfig As New InitalXMLConfig(InitalXMLConfig.XmlConfigType.AppSettings)
        With InitialConfig

            'Add everything to array
            For lintArrInc = 0 To lintMaxHist

                If .GetValue("FileName" & lintArrInc, "").ToUpper <> pstrFileName.ToUpper And _
                    .GetValue("FileName" & lintArrInc, "") <> "" Then
                    lstrFiles(lintDupeArrInc) = .GetValue("FileName" & lintArrInc, "")
                    lstrShorts(lintDupeArrInc) = .GetValue("ShortName" & lintArrInc, "")
                    lintLastArrayItem = lintDupeArrInc
                    lintDupeArrInc += 1
                End If

            Next lintArrInc

            If lintLastArrayItem < lintMaxHist Then
                lbooAdded = True
                lstrFiles(lintLastArrayItem + 1) = pstrFileName
                lstrShorts(lintLastArrayItem + 1) = pstrShortName
            End If

            '3. write array, add entry
            For lintArrInc = 0 To lintMaxHist
                SaveSetting("FileName" & lintArrInc, lstrFiles(lintArrInc), InitalXMLConfig.XmlConfigType.AppSettings, "")
                SaveSetting("ShortName" & lintArrInc, lstrShorts(lintArrInc), InitalXMLConfig.XmlConfigType.AppSettings, "")
            Next lintArrInc
        End With

        If gbooSilentMode = False Then
            If lbooAdded = False Then
                Busy(Me, False)

                'Dim lstrDetails(2) As String
                'lstrDetails(0) = "33<a^\b`JQ;BfzvHnC"
                'lstrDetails(1) = "MasHFS@[fmCDEUusrWUhhUGdFtYimg`Il?fy\;psUxYUZqy?`LM`uZFAeYYtE_ZqxOAXuN"
                'lstrDetails(2) = "dj?STCVnAwGkeHxSi_PE]DuJ`eXKqoc^t\;Tnm\;"

                'mxessagebox.show(Decrypt("", "", flame.Encops.EncryptString, lstrDetails), NameMe(""))

                'MsgBox("Your 'Information Base' was not added, you may have execeeded the amount allowed!")
                
                MessageBox.Show(LangText.GetString("Maint_Exceeded").Replace("[Program]", gProgName), _
                    NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props
            Else
                Busy(Me, False)
                'mxessagebox.show("Your 'Information Base' was added!", NameMe(""))
                MessageBox.Show(LangText.GetString("Maint_YourIBWasAdded").Replace("[Program]", gProgName), _
                    NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props

            End If
        End If
        Busy(Me, False)

    End Sub
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim lstrShortName As String

        Dim OpenInput As New InputBox(False)
        
        lstrShortName = OpenInput.Display(LangText.GetString("Maint_WordDescription").Replace("[Program]", gProgName), NameMe(""))

        OpenInput.Dispose()
        Busy(Me, True) 
        BusyButtons(True) 

        System.Windows.Forms.Application.DoEvents() 

        If lstrShortName <> "" Then
            On Error Resume Next

            Dim OpenFileDialog1 As New OpenFileDialog() 'added following Hajo problem, may csude similar problems

            With OpenFileDialog1
                .DefaultExt = "ibf" '"mdb"
                
                .Filter = LangText.GetString("Maint_InfBaseFilter").Replace("[Program]", gProgName)
                .RestoreDirectory = True 
                
                .Title = LangText.GetString("Maint_OpenTitle").Replace("[Program]", gProgName)
                Busy(Me, False) 
                BusyButtons(False) 
                .ShowDialog()
                Busy(Me, True) 
                BusyButtons(True) 
                If OpenFileDialog1.FileName = "" Then
                    Busy(Me, False) 
                    BusyButtons(False) 
                    
                    MessageBox.Show(LangText.GetString("Maint_NoFileSelected"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'other props

                    Exit Sub
                End If

                System.Windows.Forms.Application.DoEvents() 
                AddNewDB(OpenFileDialog1.FileName, lstrShortName)
            End With
        End If
        Busy(Me, False) 
        BusyButtons(False) 
        System.Windows.Forms.Application.DoEvents() 
        Me.Close()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub
    Friend Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim NewDB As ADOX.Catalog = New ADOX.Catalog()
        Dim lstrSystemDB As String
        Dim lstrPreDB As String
        Dim lstrNewConnString As String
        Dim lcnn1 As New ADODB.Connection()
        Dim tblADOXTopics As ADOX.Table = New ADOX.Table()
        Dim tblADOXTopicDetail As ADOX.Table = New ADOX.Table()
        Dim tblADOXTopicMatches As ADOX.Table = New ADOX.Table()
        Dim tblADOXLicenses As ADOX.Table = New ADOX.Table() 
        Dim tblADOXSettings As ADOX.Table = New ADOX.Table() 
        Dim tblADOXTabDets As ADOX.Table = New ADOX.Table() 
        Dim tblADOTopicCodeIdx As New ADOX.Index() 
        Dim lflaDBResult As Long

        Dim lbooErrorLog As Boolean = False 'True 

        Busy(Me, True) 
        BusyButtons(True) 
        System.Windows.Forms.Application.DoEvents() 

        If gbooSilentMode = False Then
            gstrConnectionString = gconstrConnectionProvider & gstrDataFileName & ";Jet OLEDB:System database=" & _
                LeftGet(gstrDataFileName, gstrDataFileName.Length - 1) & "w"

            Dim lstrProbComtStack As String = "" 
            lflaDBResult = CheckDates(gstrDBFlamer, False, lstrProbComtStack)

            If lstrProbComtStack <> "" Then 
                AddDebugComment(lstrProbComtStack) 
            End If
            If lflaDBResult = 0 Then

            End If
        End If

        lstrPreDB = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\~predb.tmp"
        Try : System.IO.File.Delete(lstrPreDB) : Catch : End Try 
        
        Dim InitalDir As String = ""
        If IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) = True Then
            If IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & gProgName & "\") = False Then ' added & "\Ideaspad\" 
                Try
                    IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & gProgName & "")
                    InitalDir = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & gProgName & "\"
                Catch
                    InitalDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\"
                End Try
            Else
                InitalDir = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & gProgName & "\"
            End If
        Else
            InitalDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\"
        End If
        
        If lbooUltraQuiet = False Then 
            Dim SaveFileDialog1 As New SaveFileDialog() 

            With SaveFileDialog1
                .CheckPathExists = True

                If InitalDir <> "" Then 
                    .InitialDirectory = InitalDir 
                End If

                .FileName = LangText.GetString("Maint_SaveDefName")

                .Filter = LangText.GetString("Maint_InfBaseFilter")
                .RestoreDirectory = True 

                .Title = LangText.GetString("Maint_SaveTitle").Replace("[Program]", gProgName)

                .DefaultExt = "ibf"
            End With

            Busy(Me, False) 
            BusyButtons(False) 
            System.Windows.Forms.Application.DoEvents() 

            AddDebugComment("maint.btnNew_Click - About to Show SFD") 

            If SaveFileDialog1.ShowDialog() <> DialogResult.Cancel And SaveFileDialog1.FileName <> "" Then
                lstrSystemDB = LeftGet(SaveFileDialog1.FileName, SaveFileDialog1.FileName.Length - 1) & "w"
            Else 
                Busy(Me, False) 
                BusyButtons(False) 
                Exit Sub 
            End If

            Busy(Me, True) 
            BusyButtons(True) 
            System.Windows.Forms.Application.DoEvents() 

            gstrChosenDB = SaveFileDialog1.FileName

        Else 
            lstrSystemDB = InitalDir & "project.ibw" 
            gstrChosenDB = InitalDir & "project.ibf" 
            Busy(Me, True) 
            BusyButtons(True) 
            System.Windows.Forms.Application.DoEvents() 
        End If

        Dim eh As CustomExceptionHandler = New CustomExceptionHandler() 
        Try 
            If lbooErrorLog = True Then MessageBox.Show(gstrChosenDB, "Position A") 

            gstrProbComtStack = " #BN1" 

            Try : System.IO.File.Delete(lstrSystemDB) : Catch : End Try 
            Try : System.IO.File.Delete(gstrChosenDB) : Catch : End Try 

            Dim lstrComm(0) As String
            Dim lintCLArrInc1 As Integer

            Dim lstrCommandLine1 As String = "DBNWMAKE@" & lstrPreDB & "@" & lstrSystemDB & "@Admin@none@CEF01FE3D66AC@IPUser@SuperUsrs@"

            If lbooErrorLog = True Then MessageBox.Show(lstrCommandLine1, "Position B") 

            gstrProbComtStack &= " #BN2" 

            Encrypt("", lstrCommandLine1, flame.Encops.EncryptString, "olkljoijoi", lstrComm, gstrProbComtStack)
            lstrCommandLine1 = ""
            For lintCLArrInc1 = 0 To lstrComm.GetUpperBound(0)
                If lbooErrorLog = True Then MessageBox.Show(lstrComm(lintCLArrInc1)) 
                lstrCommandLine1 = lstrCommandLine1 & lstrComm(lintCLArrInc1) & "X3X"

            Next lintCLArrInc1

            If lbooErrorLog = True Then MessageBox.Show(lstrCommandLine1, "Position D") 

            gstrProbComtStack &= " #BN3" 

            If lbooErrorLog = True Then MessageBox.Show("First call to Beside", "Position E") 

            If lbooErrorLog = True Then MessageBox.Show("First call to Beside", "Position F") 
            
            Dim Beside01FirstCall As New AppRun() 

            If Beside01FirstCall.Run(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\", _
                "Beside01.exe", lstrCommandLine1, 40, False) = False Then
                gstrProbComtStack &= " #BN4" 
                Try : System.IO.File.Delete(lstrPreDB) : Catch : End Try
                Busy(Me, False)
                BusyButtons(False)
                MessageBox.Show(LangText.GetString("Maint_BesideError").Replace("[Program]", gProgName).Replace("[CR]", Environment.NewLine).Replace("[Code]", "B11"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)

                Exit Sub
            End If

            System.Windows.Forms.Application.DoEvents()

            '*' Things to do
            '*' ---------------
            '*' create new db - to create IPUser ownership

            Dim lstrComm2(0) As String
            Dim lintCLArrInc2 As Integer
            
            Dim lstrCommandLine2 As String = "DBMAKE@" & _
                gstrChosenDB & "@" & lstrSystemDB & "@IPUser@CEF01FE3D66AC@NONE@NONE@NONE@"

            gstrProbComtStack &= " #BN5" 
            Encrypt("", lstrCommandLine2, flame.Encops.EncryptString, "dsdfsffsfsaik", lstrComm2, gstrProbComtStack)
            lstrCommandLine2 = ""
            For lintCLArrInc2 = 0 To lstrComm2.GetUpperBound(0)
                If lbooErrorLog = True Then MessageBox.Show(lstrComm2(lintCLArrInc2)) 
                lstrCommandLine2 = lstrCommandLine2 & lstrComm2(lintCLArrInc2) & "X3X"
            Next lintCLArrInc2
            If lbooErrorLog = True Then MessageBox.Show(lstrCommandLine2) 
            gstrProbComtStack &= " #BN6" 
            
            Dim Beside01SecondCall As New AppRun() 
            If Beside01SecondCall.Run(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location.ToString()) & "\", _
                "Beside01.exe", lstrCommandLine2, 40, False) = False Then
                gstrProbComtStack &= " #BN7" 
                Try : System.IO.File.Delete(lstrPreDB) : Catch : End Try
                Busy(Me, False)
                BusyButtons(False)
                MessageBox.Show(LangText.GetString("Maint_BesideError").Replace("[Program]", _
                    gProgName).Replace("[CR]", Environment.NewLine).Replace("[Code]", "B12"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error)

                Exit Sub
            End If
            

            System.Windows.Forms.Application.DoEvents()

            gstrProbComtStack &= " #BN8" 
            '*' open new db
            lcnn1 = New ADODB.Connection()

            lstrNewConnString = gconstrConnectionJustProvider & gstrChosenDB & _
                ";User ID=IPUser;Password=CEF01FE3D66AC;Jet OLEDB:System database=" & lstrSystemDB

            gstrProbComtStack &= " #BN9 - SYS=" & IO.File.Exists(lstrSystemDB) & " MDB=" & IO.File.Exists(gstrChosenDB) 

            If IO.File.Exists(lstrSystemDB) = False Then
                gstrProbComtStack &= " #BN9a - SYS=" & lstrSystemDB
            End If

            If IO.File.Exists(gstrChosenDB) = False Then
                gstrProbComtStack &= " #BN9b - MDB=" & gstrChosenDB
            End If
            

            lcnn1.Open(lstrNewConnString)

            NewDB.ActiveConnection = lcnn1

            Dim lstrDetails(1) As String
            '#### E3 - Admin Password
            
            lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
            lstrDetails(1) = "LLB<BPALhPP;PCC;GJNOmK"
            
            gstrProbComtStack &= " #BN10" 

            NewDB.Users("Admin").ChangePassword("", Decrypt("", "", flame.Encops.EncryptString, lstrDetails))
            ReDim lstrDetails(0)
            gstrProbComtStack &= " #BN11" 

            '*' Add tables
            With tblADOXTopics
                .Name = "Topics"
                .Columns.Append("TopicCode", DataTypeEnum.adVarWChar, 13)

                tblADOTopicCodeIdx.Name = "TopicCode"
                tblADOTopicCodeIdx.Columns.Append("TopicCode")
                tblADOTopicCodeIdx.Unique = True
                tblADOXTopics.Indexes.Append(tblADOTopicCodeIdx)
                
                .Columns.Append("Level", DataTypeEnum.adInteger)
                .Columns.Append("Title", DataTypeEnum.adVarWChar, 50)
                .Columns.Append("ParentTopicCode", DataTypeEnum.adVarWChar, 13)
                .Columns("ParentTopicCode").Attributes = ColumnAttributesEnum.adColNullable
                .Columns.Append("SeqNum", DataTypeEnum.adInteger)
                .Columns.Append("InUse", DataTypeEnum.adBoolean)
                .Columns.Append("ImgIdx", DataTypeEnum.adInteger) 
            End With
            NewDB.Tables.Append(tblADOXTopics)
            gstrProbComtStack &= " #BN12" 

            With tblADOXTopicDetail
                .Name = "TopicDetail"
                .Columns.Append("TopicCode", DataTypeEnum.adVarWChar, 13)
                'level not required in TopicDetail
                .Columns.Append("Detail", DataTypeEnum.adLongVarWChar)
                .Columns.Append("TemplateID", DataTypeEnum.adVarWChar, 13)
                .Columns.Append("LockingFlag", DataTypeEnum.adVarWChar, 50)
                .Columns.Append("ByteLen", DataTypeEnum.adInteger) 
                .Columns.Append("Options", DataTypeEnum.adVarWChar, 15) 
            End With
            NewDB.Tables.Append(tblADOXTopicDetail)

            gstrProbComtStack &= " #BN13" 

            With tblADOXTopicMatches
                .Name = "TopicMatches"
                .Columns.Append("A", DataTypeEnum.adVarWChar, 25)
                .Columns.Append("B", DataTypeEnum.adVarWChar, 25)
                .Columns.Append("C", DataTypeEnum.adVarWChar, 25)
                .Columns.Append("D", DataTypeEnum.adVarWChar, 25)
                .Columns.Append("E", DataTypeEnum.adVarWChar, 25)
                .Columns.Append("DBID", DataTypeEnum.adVarWChar, 50) 
                .Columns("DBID").Attributes = ColumnAttributesEnum.adColNullable 
                .Columns.Append("DBVer", DataTypeEnum.adVarWChar, 10) 
                .Columns("DBVer").Attributes = ColumnAttributesEnum.adColNullable 
            End With
            NewDB.Tables.Append(tblADOXTopicMatches)

            gstrProbComtStack &= " #BN14" 
            
            With tblADOXLicenses
                .Name = "LICENSES"
                .Columns.Append("1", DataTypeEnum.adVarWChar, 50)
                .Columns.Append("2", DataTypeEnum.adVarWChar, 50)
                .Columns.Append("3", DataTypeEnum.adVarWChar, 50)
                .Columns.Append("4", DataTypeEnum.adVarWChar, 50)
                .Columns.Append("5", DataTypeEnum.adVarWChar, 1)
            End With
            NewDB.Tables.Append(tblADOXLicenses)
            
            gstrProbComtStack &= " #BN15" 
            
            With tblADOXSettings
                .Name = "Sets"
                .Columns.Append("ident", DataTypeEnum.adVarWChar, 10)
                .Columns.Append("data", DataTypeEnum.adVarWChar, 255)
            End With
            NewDB.Tables.Append(tblADOXSettings)

            With tblADOXTabDets
                .Name = "TableDetails"
                .Columns.Append("TID", DataTypeEnum.adVarWChar, 10)
                .Columns.Append("TopicCode", DataTypeEnum.adVarWChar, 13)
                .Columns.Append("Instructs", DataTypeEnum.adLongVarWChar)
                .Columns.Append("HumanRText", DataTypeEnum.adLongVarWChar)
            End With
            NewDB.Tables.Append(tblADOXTabDets)
            
            NewDB = Nothing

            lcnn1.Close()

            gstrProbComtStack &= " #BN16" 

            Dim lcnn2 As New ADODB.Connection()
            lcnn2 = New ADODB.Connection()

            ReDim lstrDetails(2)
            '#### E4 - Part Connection String / IP User password
            
            lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
            lstrDetails(1) = "?eGKUHZ<qv=<qje;GUH;?jYKGGC;KHV;=wuKtJI@tuG<vDD@yw?<pUF;ZknKuvx;@gAKGF"
            lstrDetails(2) = "U;MZV?YFY;XYG;U=m@"
            
            lstrNewConnString = gconstrConnectionJustProvider & gstrChosenDB & _
                Decrypt("", "", flame.Encops.EncryptString, lstrDetails) & lstrSystemDB

            ReDim lstrDetails(0)

            lcnn2.Mode = ADODB.ConnectModeEnum.adModeShareExclusive 'Leave in 
            lcnn2.Open(lstrNewConnString)

            ReDim lstrDetails(1)
            '#### E5 - Alter SQL DB Password
            
            lstrDetails(0) = "33IHGPFEDPIHGPFEDP"
            lstrDetails(1) = "yNF;UHZ<vYF;YXY;GUZ<jYG;GCK;HVZ<GHOORVG;GYA<CDZPlen;nm?"
            
            lcnn2.Execute(Decrypt("", "", flame.Encops.EncryptString, lstrDetails))
            ReDim lstrDetails(0)

            ''#### E6 - Alter SQL IPUser Password
            gstrProbComtStack &= " #BN17" 
            Dim le As String = System.IO.Path.GetDirectoryName(System.Environment.GetFolderPath(Environment.SpecialFolder.System)) & "\explorer.exe"
            Dim lstrSQL As String


            With gstrDBFlamer
                If .strSD & .strLD & .strHS & .strLTD & .strED <> "" Then

                    lstrSQL = "Insert into TopicMatches (A,B,C,D,E) values ('" & _
                        .strSD & "', '" & .strLD & "', '" & .strED & "', '" & _
                        .strHS & "', '" & .strLTD & "');"
                Else
                    gstrProbComtStack &= " #BN18" 
                    Dim lstrNewFlamer As New flamer()
                    'set values

                    lstrNewFlamer.strSD = GreatDateStr(Date.Now, gstrProbComtStack) 
                    lstrNewFlamer.strLD = GreatDateStr(Date.Now, gstrProbComtStack) 
                    lstrNewFlamer.strED = GreatDateStr(System.IO.File.GetLastAccessTime(le), gstrProbComtStack) 
                    lstrNewFlamer.strHS = "01/01/2000 00:01:00"
                    lstrNewFlamer.strLTD = GreatDateStr(Date.Now, gstrProbComtStack) 
                    'code them
                    SetRealDates(lstrNewFlamer, True, gstrProbComtStack)
                    lstrSQL = "Insert into TopicMatches (A,B,C,D,E) values ('" & _
                              lstrNewFlamer.strSD & "', '" & lstrNewFlamer.strLD & "', '" & lstrNewFlamer.strED & "', '" & _
                              lstrNewFlamer.strHS & "', '" & lstrNewFlamer.strLTD & "');"

                End If
            End With

            lcnn2.Execute(lstrSQL)
            lcnn2.Close()

            Try : System.IO.File.Delete(lstrPreDB) : Catch : End Try 
            gbooDBComplete = True

            Busy(Me, False)
            BusyButtons(False) 
            If gbooSilentMode = False Then
                gstrProbComtStack &= " #BN19" 
                Dim lstrShortName As String
                Dim OpenInput As New InputBox(False) 
                
                lstrShortName = OpenInput.Display(LangText.GetString("Maint_WordDescription").Replace("[Program]", gProgName), NameMe(""))

                OpenInput.Dispose()
                System.Windows.Forms.Application.DoEvents() 
                If lstrShortName <> "" Then
                    AddNewDB(gstrChosenDB, lstrShortName)
                Else
                    MessageBox.Show(LangText.GetString("Maint_NewIBCreated").Replace("[Program]", gProgName), _
                        NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props

                End If
                System.Windows.Forms.Application.DoEvents() 
                Me.Close()
            End If

            gstrProbComtStack &= " #BN-End" 
        Catch ex As Exception 
            AddDebugComment(gstrProbComtStack) 
            gstrProbComtStack = ""
            AddDebugComment("<Font color=Red>MSG:" & ex.ToString & "</font>") 
            eh.pMe = Me 
            eh.OnThreadException(Nothing, Nothing) 

        End Try 

        AddDebugComment(gstrProbComtStack) 

        Busy(Me, False)
        BusyButtons(False) 

    End Sub
    Private Sub btnRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRename.Click
        Dim lstrNewShortName As String

        If mintSelListIdx = -1 Then
            MessageBox.Show(LangText.GetString("Maint_RenameSelect").Replace("[Program]", gProgName), NameMe("") _
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 

            Exit Sub
        End If
        Dim RenameBox As New InputBox(False) 
        Dim lstrShortName As String = GetSetting("ShortName" & mintSelListIdx, "", InitalXMLConfig.XmlConfigType.AppSettings, "")
        
        lstrNewShortName = RenameBox.Display(LangText.GetString("Maint_RenameName").Replace("[Program]", gProgName), NameMe(""), lstrShortName)

        RenameBox.Dispose()
        System.Windows.Forms.Application.DoEvents() 

        If lstrNewShortName <> "" Then
            Busy(Me, True)
            BusyButtons(True) 
            SaveSetting("ShortName" & mintSelListIdx, lstrNewShortName, InitalXMLConfig.XmlConfigType.AppSettings, "")
            Busy(Me, False)
            BusyButtons(False) 
        End If
        Me.Close()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim lintRetVal As DialogResult
        Dim lstrFileName As String
        Dim lstrShortName As String

        If mintSelListIdx = -1 Then
            MessageBox.Show(LangText.GetString("Maint_DeleteSelect").Replace("[Program]", gProgName), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Exit Sub
        End If

        If mintListItemCount <= 1 Then
            MessageBox.Show(LangText.GetString("Maint_DeleteDenied"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Warning) 'other props

            Exit Sub
        End If
        System.Windows.Forms.Application.DoEvents() 

        Busy(Me, True)
        BusyButtons(True) 
        lstrShortName = GetSetting("ShortName" & mintSelListIdx, "", InitalXMLConfig.XmlConfigType.AppSettings, "")
        lstrFileName = GetSetting("FileName" & mintSelListIdx, "", InitalXMLConfig.XmlConfigType.AppSettings, "")
        Busy(Me, False)
        BusyButtons(False) 
        
        lintRetVal = MessageBox.Show(LangText.GetString("Maint_DeleteConfirm").Replace("[Program]", gProgName).Replace("[ShortName]", lstrShortName), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props

        System.Windows.Forms.Application.DoEvents() 

        If lintRetVal = DialogResult.Yes Then
            Busy(Me, True)
            BusyButtons(True) 
            Try 
                System.IO.File.Delete(lstrFileName) 
                System.IO.File.Delete(LeftGet(lstrFileName, lstrFileName.Length - 1) & "w")
            Catch
                Busy(Me, False) 
                BusyButtons(False) 
                
                MessageBox.Show(LangText.GetString("Maint_DeleteInUse").Replace("[Program]", gProgName), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 

                Exit Sub 
            End Try

            SaveSetting("FileName" & mintSelListIdx, "", InitalXMLConfig.XmlConfigType.AppSettings, "")
            SaveSetting("ShortName" & mintSelListIdx, "", InitalXMLConfig.XmlConfigType.AppSettings, "")
            Sleep(2) 

            Busy(Me, False)
            BusyButtons(False) 
            
            MessageBox.Show(LangText.GetString("Maint_DeleteSuccess").Replace("[Program]", gProgName).Replace("[ShortName]", lstrShortName), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props

        End If

        System.Windows.Forms.Application.DoEvents() 

        Busy(Me, False)
        BusyButtons(False) 
        Me.Close()
    End Sub
    Private Sub frmMaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = NameMe(LangText.GetString("Maint_Caption")) 

        Label4.Text = Label4.Text.Replace("[Program]", gProgName) 
        btnOpen.Text = btnOpen.Text.Replace("[Program]", gProgName) 
        btnDelete.Text = btnDelete.Text.Replace("[Program]", gProgName) 
        btnRename.Text = btnRename.Text.Replace("[Program]", gProgName) 
        btnNew.Text = btnNew.Text.Replace("[Program]", gProgName) 

        Label4.Text = Label4.Text.Replace("2004", gYear) 

        
        If IsAboveOrEqualWinXp() = True Then  
            btnNew.FlatStyle = FlatStyle.System
            btnRename.FlatStyle = FlatStyle.System
            btnDelete.FlatStyle = FlatStyle.System
            btnOpen.FlatStyle = FlatStyle.System
            btnRepair.FlatStyle = FlatStyle.System
            btnHelp.FlatStyle = FlatStyle.System
            btnCancel.FlatStyle = FlatStyle.System
        End If 
        

        SetBackcolors() 

        btnNew.Select() 

        Dim Info As New System.IO.FileInfo(gstrDataFileName)
        If Not Info.Exists Then
            btnNew.Enabled = False
            btnRepair.Enabled = False
        Else 
            btnNew.Enabled = True 
            btnRepair.Enabled = True 
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        UIStyle.Spanner(e)


    End Sub
    Private Sub btnRepair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepair.Click

        
        'Dim lstrMSG As String = "Please select which repair feature you'd like to use, either (YES/NO) :- " & Environment.NewLine & Environment.NewLine & _
        '    ChrGet(9) & "Repair & Compact  = YES" & Environment.NewLine & Environment.NewLine & _
        '    ChrGet(9) & "OR" & Environment.NewLine & Environment.NewLine & ChrGet(9) & "Data Fix = NO" & Environment.NewLine & Environment.NewLine & _
        '    "NB.  Before using the Data Fix feature please gain assistance from " & Environment.NewLine & _
        '    "Mindwarp Consultancy Ltd, this can be done via the web site. " & Environment.NewLine & Environment.NewLine & _
        '    "Please ensure that no other user is using the 'Information Base' " & Environment.NewLine & _
        '    "before proceeding with either of the repair features."

        
        Dim lstrMSG As String = LangText.GetString("Maint_RepairOptions")
        lstrMSG = lstrMSG.Replace("[CR2]", Environment.NewLine + Environment.NewLine)
        lstrMSG = lstrMSG.Replace("[CR]", Environment.NewLine)
        lstrMSG = lstrMSG.Replace("[TAB]", ChrGet(9))
        

        Dim DlgRes As DialogResult = MessageBox.Show(lstrMSG, NameMe(""), MessageBoxButtons.YesNoCancel)
        Select Case DlgRes
            Case DialogResult.Cancel
                Exit Sub
            Case DialogResult.Yes
                'Repair & Compact
                'do nothhing, just continue
            Case DialogResult.No
                Dim lstrFileName As String
                lstrFileName = GetSetting("FileName" & mintSelListIdx, "", InitalXMLConfig.XmlConfigType.AppSettings, "")
                Try
                    gstrConnectionString = gconstrConnectionProvider & lstrFileName & ";Jet OLEDB:System database=" & _
                    LeftGet(lstrFileName, (lstrFileName).Length - 1) & "w"
                    Dim ProblemFound As Boolean = False
                    Dim AllTopic(0) As String
                    ProblemFound = FixTopic(AllTopic)

                    FixMissingDetails(AllTopic)

                    Dim RepairTree As New TreeView()
                    Dim mstrIndexArray() As TreeTopics
                    PopulateTree(RepairTree, mstrIndexArray, Me)
                    ReIndex(RepairTree)

                    If ProblemFound = True Then
                        'MessageBox.Show("The Data Fix process found a problem and fixed it!", NameMe(""))
                        MessageBox.Show(LangText.GetString("Maint_RepairFixedButFound"), NameMe("")) 
                    Else
                        'MessageBox.Show("The Data Fix process completed!", NameMe(""))
                        MessageBox.Show(LangText.GetString("Maint_RepairFixedComplete"), NameMe("")) 
                    End If
                Catch ex As Exception
                    'MessageBox.Show("The Data Fix process wasn't able to repair the problem, please use the support" & Environment.NewLine & _
                    '                "feature on the Mindwarp Consultancy Website to gain assistance!", NameMe(""))

                    MessageBox.Show(LangText.GetString("Maint_RepairNotFixed").Replace("[CR]", Environment.NewLine), NameMe("")) 
                End Try
                Exit Sub
        End Select
        

        Dim JetEng As New JRO.JetEngine()
        Dim lintRetVal As DialogResult
        Dim lstrCutName As String
        Dim strSourceConnect As String
        Dim strDestConnect As String

        'lintRetVal = MxessageBox.Show("Do you wish to Reapir/Compact the selected 'Information Base' file?" & Environment.NewLine() & _
        '        "File : " & gstrDataFileName & Environment.NewLine() & Environment.NewLine() & _
        '        "This process keeps a backup of your database, just in case the compact" & Environment.NewLine() & _
        '        "process fails.  By continuing the backup from last time will be deleted!" & Environment.NewLine() & Environment.NewLine() & _
        '        "Do you wish to proceed?", NameMe(""), MessageBoxButtons.YesNo)

        
        lintRetVal = MessageBox.Show(LangText.GetString("Maint_RepairConfirm").Replace("[Program]", gProgName).Replace("[CR]", _
                Environment.NewLine).Replace("[File]", gstrDataFileName).Replace("[CR2]", Environment.NewLine & _
                Environment.NewLine), NameMe(""), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'other props

        If lintRetVal <> DialogResult.Yes Then Exit Sub 'moved from further down

        Busy(Me, True) 
        BusyButtons(True) 
        System.Windows.Forms.Application.DoEvents() 

        'If lintRetVal <> DialogResult.Yes Then Exit Sub

        'check to see if locked

        Try : System.IO.File.Delete(LeftGet(gstrDataFileName, gstrDataFileName.Length - 3) & "new")
        Catch e1 As Exception : End Try

        Try : System.IO.File.Delete(LeftGet(gstrDataFileName, gstrDataFileName.Length - 3) & "bak")
        Catch e1 As Exception : End Try

        Try

            lstrCutName = LeftGet(gstrDataFileName, (gstrDataFileName).Length - 3)

            strSourceConnect = gconstrConnectionProvider & gstrDataFileName & ";Jet OLEDB:System database=" & _
                LeftGet(gstrDataFileName, (gstrDataFileName).Length - 1) & "w"

            strDestConnect = gconstrConnectionProvider & lstrCutName & "new" & ";Jet OLEDB:System database=" & _
                LeftGet(gstrDataFileName, (gstrDataFileName).Length - 1) & "w"

            JetEng.CompactDatabase(strSourceConnect, strDestConnect)

            'rename
            System.IO.File.Move("" & gstrDataFileName, lstrCutName & "bak")
            System.IO.File.Move("" & lstrCutName & "new", gstrDataFileName)

            Busy(Me, False) 
            BusyButtons(False) 
            'mxessagebox.show("Repair / Compact completed successfully!", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Maint_RepairSuccess"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Information) 'other props


        Catch eh As Exception
            Busy(Me, False) 
            BusyButtons(False) 
            'mxessagebox.show("There has been a problem, please refer to our web site for help on this matter!", NameMe(""))
            
            MessageBox.Show(LangText.GetString("Maint_RepairProblem"), NameMe(""), MessageBoxButtons.OK, MessageBoxIcon.Error) 'other props

        End Try

        System.Windows.Forms.Application.DoEvents() 

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


    Private Sub frmMaint_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = System.Windows.Forms.Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If

        If e.KeyCode = System.Windows.Forms.Keys.F1 Then 
            btnHelp_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, GetHelpFile, GetHelpTopic(main.HelpTopic.maintenance)) 
    End Sub
    Private Sub BusyButtons(ByVal pbool As Boolean)
        

        If pbool = True Then pbool = False Else pbool = True

        btnDelete.Enabled = pbool
        btnCancel.Enabled = pbool
        btnHelp.Enabled = pbool
        btnNew.Enabled = pbool
        btnOpen.Enabled = pbool
        btnRename.Enabled = pbool
        btnRepair.Enabled = pbool

        If Not gstrDataFileName Is Nothing Then
            Dim Info As New System.IO.FileInfo(gstrDataFileName)
            If Not Info.Exists Then
                btnNew.Enabled = False
                btnRepair.Enabled = False
            Else
                btnNew.Enabled = pbool 'True
                btnRepair.Enabled = pbool 'True
            End If
        End If

    End Sub
    Private Function FixTopic(ByRef pAllTopics() As String) As Boolean
        'created
        FixTopic = False

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String
        lcnn1 = New ADODB.Connection()

        lcnn1.Open(gstrConnectionString)

        lstrSQL = "SELECT CLng(Left([ParentTopicCode] & '0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), " & _
        "* FROM Topics WHERE (((Topics.InUse)=True)) ORDER BY Topics.Level, CLng(Left([ParentTopicCode] & " & _
        "'0T',InStr(1,[ParentTopicCode] & '0T','T')-1)), Title;"
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)


        Dim lstrTopicCode As String
        Dim llngThisTopicNum As Long
        Dim lintTPos As Integer
        Dim lintLevel As Integer
        Dim lintRecCounter As Integer
        Dim lstrParents(0) As String
        Dim lstrParentsLevel(0) As String
        Dim lstrDetailCode As String
        Dim lstrParent As String
        Dim lintArrInc As Integer
        'Dim lstrDebug As String

        Dim ErrorTopicCode As String

        With lsnaLists
            Do Until .EOF
                lstrTopicCode = .Fields("TopicCode").Value
                lintTPos = InStrGet(1, lstrTopicCode, "T")
                llngThisTopicNum = CLng(RightGet(lstrTopicCode, (lstrTopicCode.Length - lintTPos)))
                lintLevel = .Fields("Level").Value()
                lstrDetailCode = ReturnTrueTopicStr(lstrTopicCode)
                lstrParent = .Fields("ParentTopicCode").Value

                lstrParents(lintRecCounter) = lstrTopicCode
                lstrParentsLevel(lintRecCounter) = lintLevel

                '--- Check parent exists ---
                Dim lbooParentExists As Boolean = False
                If lstrParent <> "" Then
                    For lintArrInc = 0 To lstrParents.GetUpperBound(0)
                        If lstrParents(lintArrInc) = lstrParent Then
                            'parent exists
                            lbooParentExists = True

                            'If lstrParentsLevel(lintArrInc) <> (lintLevel - 1) Then
                            '    lstrDebug &= Environment.NewLine & "PL: " & lstrTopicCode & " " & lintLevel & " " & .Fields("Title").Value
                            'End If
                            Exit For
                        End If
                    Next lintArrInc
                    If lbooParentExists = False Then
                        ErrorTopicCode = lstrTopicCode
                        FixTopic = True
                        'lstrDebug &= Environment.NewLine & "PM: " & lstrTopicCode & " " & lintLevel & " " & .Fields("Title").Value
                    End If
                End If
                '--- Check parent exists ---

                'Dim lintImgIdx As Integer
                'If Microsoft.VisualBasic.IsDBNull(lsnaLists.Fields("ImgIdx").Value) Then
                '    lintImgIdx = 0
                'Else
                '    lintImgIdx = CType(lsnaLists.Fields("ImgIdx").Value & "", Integer)
                'End If

                .MoveNext()
                lintRecCounter = lintRecCounter + 1
                ReDim Preserve lstrParents(lintRecCounter)
                ReDim Preserve lstrParentsLevel(lintRecCounter)
            Loop
        End With

        lstrSQL = "UPDATE Topics SET ParentTopicCode = '', [Level] = 1 WHERE TopicCode='" & ErrorTopicCode & "';"
        lcnn1.Execute(lstrSQL)

        lsnaLists.Close()
        lcnn1.Close()

        pAllTopics = lstrParents

        'MessageBox.Show(lstrDebug)

    End Function
    Private Sub ReIndex(ByVal pTreeview As TreeView)

        Dim lstrSQL As String
        Dim lcnn1 As New ADODB.Connection()
        Dim llnglevel As Long
        'Dim lstrCurTopicCode As String 
        Dim mstrIndexArray() As TreeTopics 
        lcnn1 = New ADODB.Connection()
        lcnn1.Open(gstrConnectionString)

        llnglevel = 1

        'lstrCurTopicCode = TreeView1.SelectedNode.Tag

        Dim n As TreeNode
        Dim cNodes As Integer
        Dim ndxs() As TreeNode
        Dim curNode As Integer = -1

        cNodes = pTreeview.GetNodeCount(True)

        'ProgresPanel.Maximum = cNodes
        'ProgresPanel.Minimum = 0
        'ProgresPanel.Value = 0

        ReDim ndxs(cNodes)

        GetNodes(pTreeview.Nodes(0), ndxs, curNode, False)

        Dim llngCounter As Integer
        ReDim Preserve ndxs(curNode)
        For Each n In ndxs
            llnglevel = NodateLevel(n)
            lstrSQL = "Update Topics set [Level] = " & llnglevel & " WHERE TopicCode='" & n.Tag & "';"
            lcnn1.Execute(lstrSQL)

            'ProgresPanel.Increment(1)
            llngCounter += 1
            If llngCounter > 10 Then
                System.Windows.Forms.Application.DoEvents()
                llngCounter = 0
            End If
        Next n

        lcnn1.Close()

        'ProgresPanel.Value = 0


    End Sub

    Private Function FixMissingDetails(ByRef pAllTopics() As String) As Boolean
        'created
        FixMissingDetails = False

        Dim lcnn1 As New ADODB.Connection()
        Dim lsnaLists As New ADODB.Recordset()
        Dim lstrSQL As String
        lcnn1 = New ADODB.Connection()

        lcnn1.Open(gstrConnectionString)

        lstrSQL = "SELECT TopicCode From TopicDetail;"
        gstrLastSQL = lstrSQL 

        lsnaLists.Open(lstrSQL, lcnn1, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        Dim lstrDetails(0) As String
        Dim lintRecCounter As Integer

        With lsnaLists
            Do Until .EOF
                lstrDetails(lintRecCounter) = .Fields("TopicCode").Value
                .MoveNext()
                lintRecCounter += 1
                ReDim Preserve lstrDetails(lintRecCounter)
            Loop
        End With

        Dim lintArrInc As Integer
        Dim lintArrInc2 As Integer
        For lintArrInc = 0 To pAllTopics.GetUpperBound(0) - 1
            Dim lstrSearchTopic As String = ReturnTrueTopicStr(pAllTopics(lintArrInc))
            Dim lbooDetailFound As Boolean = False
            For lintArrInc2 = 0 To lintRecCounter - 1
                If lstrDetails(lintArrInc2) = lstrSearchTopic And lstrDetails(lintArrInc2) <> "" Then
                    lbooDetailFound = True
                    Exit For
                End If
            Next lintArrInc2
            If lbooDetailFound = False And lstrSearchTopic <> "" Then
                'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag ) Values('" & _
                '    lstrSearchTopic & "','','', 'Error Fix');"
                
                'lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag, ByteLen ) Values('" & _
                '    lstrSearchTopic & "','','', 'Error Fix', -1);"
                
                lstrSQL = "INSERT INTO TopicDetail ( TopicCode, Detail, TemplateID, LockingFlag, ByteLen, Options ) Values('" & _
                    lstrSearchTopic & "','','', 'Error Fix', -1,'Default');"

                lcnn1.Execute(lstrSQL)
            End If
        Next lintArrInc

        lsnaLists.Close()
        lcnn1.Close()

    End Function
    Private Sub SetBackcolors()

        'Added 
        btnNew.BackColor = Color.FromArgb(0, btnNew.BackColor)
        btnCancel.BackColor = Color.FromArgb(0, btnCancel.BackColor)
        btnRename.BackColor = Color.FromArgb(0, btnRename.BackColor)
        btnHelp.BackColor = Color.FromArgb(0, btnHelp.BackColor)
        btnDelete.BackColor = Color.FromArgb(0, btnDelete.BackColor)
        btnOpen.BackColor = Color.FromArgb(0, btnOpen.BackColor)
        btnRepair.BackColor = Color.FromArgb(0, btnRepair.BackColor)
        Label1.BackColor = Color.FromArgb(0, Label1.BackColor)
        Label4.BackColor = Color.FromArgb(0, Label4.BackColor)

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        'Added 
        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub frmMaint_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class