Public Class InsertUrl
    Inherits System.Windows.Forms.Form
    Dim mstrReturnURL As String
    Public Property ReturnURL() As String
        Get
            Return mstrReturnURL
        End Get
        Set(ByVal Value As String)
            mstrReturnURL = Value
        End Set
    End Property
    Friend WithEvents lstHyperChoice As ComboBox
    Friend WithEvents txtUrl As TextBox
    Private lblHyperChoice As Label
    Private lblUrl As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button

    Public Sub New()

        Dim StandLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))

        Dim LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("RTFStand.RTFStand", _
            System.Reflection.Assembly.GetExecutingAssembly())

        lstHyperChoice = New ComboBox()
        txtUrl = New TextBox()
        lblHyperChoice = New Label()
        lblUrl = New Label()
        btnOK = New Button()
        btnCancel = New Button()

        With lstHyperChoice
            .Top = 10
            .Left = 100
            .Width = 100
            .DropDownStyle = ComboBoxStyle.DropDownList
            .TabIndex = 0
            .Items.AddRange(New Object() {"file://", "ftp://", "gopher://", "http://", "https://", "mailto://", "news://", "telnet://"})
            .SelectedIndex = 3
        End With

        With lblHyperChoice
            .Top = lstHyperChoice.Top
            .Left = 10
            .Width = 85
            .Text = LangText.GetString("InsertUrl_HyperLinkType")
            .TextAlign = ContentAlignment.MiddleRight
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        With txtUrl
            .Top = lstHyperChoice.Top + lstHyperChoice.Height + 10
            .Left = lstHyperChoice.Left
            .Width = 300
            .TabIndex = 1
            .Text = "http://"
        End With

        With lblUrl
            .Top = txtUrl.Top
            .Left = 10
            .Width = 85
            .Text = "URL :"
            .TextAlign = ContentAlignment.MiddleRight
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        'With btnOK
        '    .Left = lblHyperChoice.Left
        '    .Top = txtUrl.Top + txtUrl.Height + 10
        '    .TabIndex = 2
        '    .Text = StandLangText.GetString("StandText_OK")
        '    .FlatStyle = FlatStyle.System
        '    .BackColor = Color.FromArgb(0, .BackColor)
        'End With

        Me.Width = txtUrl.Left + txtUrl.Width + 20

        With btnCancel
            .Left = ((Me.Width) - .Width) - 20
            .Top = txtUrl.Top + txtUrl.Height + 10
            .TabIndex = 3
            .Text = StandLangText.GetString("StandText_Cancel")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        With btnOK
            .Left = (btnCancel.Left - .Width) - 10
            .Top = txtUrl.Top + txtUrl.Height + 10
            .TabIndex = 2
            .Text = StandLangText.GetString("StandText_OK")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        Me.Text = LangText.GetString("InsertUrl_Title").Replace("&", "")
        Me.Height = btnOK.Top + btnOK.Height + 40
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.ShowInTaskbar = False 
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.KeyPreview = True
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lstHyperChoice, Me.lblHyperChoice, Me.txtUrl, Me.lblUrl, Me.btnOK, Me.btnCancel})
    End Sub
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim JustLocation As String
        Dim Standard As String
        JustLocation = GetURLStandard(Standard)

        'mstrReturnURL = Web.HttpUtility.UrlEncode(txtUrl.Text)

        mstrReturnURL = Standard & Web.HttpUtility.UrlEncode(JustLocation)

        Me.Close()
        'Me.Dispose()

    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        mstrReturnURL = ""
        Me.Close()
        'Me.Dispose()

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub
    Private Sub InsertUrl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub txtUrl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUrl.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnOK_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub lstHyperChoice_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstHyperChoice.SelectedIndexChanged

        If txtUrl.Text = "" Then
            Exit Sub
        End If

        Dim NewText As String
        'Dim lintArrInc As Integer

        'For lintArrInc = 0 To lstHyperChoice.Items.Count - 1
        '    Dim CurItem As String = lstHyperChoice.Items(lintArrInc)
        '    'Console.WriteLine(CurItem)
        '    If txtUrl.Text.Length >= CurItem.Length Then
        '        If LeftGet(txtUrl.Text, CurItem.Length) = CurItem Then
        '            NewText = RightGet(txtUrl.Text, txtUrl.Text.Length - CurItem.Length)
        '            Exit For
        '        End If
        '    End If
        'Next lintArrInc

        NewText = GetURLStandard(Nothing) 

        txtUrl.Text = lstHyperChoice.Text & NewText

    End Sub
    Private Function GetURLStandard(ByRef StandardRetVal As String) As String

        Dim NewText As String
        Dim lintArrInc As Integer
        Dim CurItem As String

        For lintArrInc = 0 To lstHyperChoice.Items.Count - 1
            CurItem = lstHyperChoice.Items(lintArrInc)
            'Console.WriteLine(CurItem)
            If txtUrl.Text.Length >= CurItem.Length Then
                If LeftGet(txtUrl.Text, CurItem.Length) = CurItem Then
                    NewText = RightGet(txtUrl.Text, txtUrl.Text.Length - CurItem.Length)
                    Exit For
                End If
            End If
        Next lintArrInc

        StandardRetVal = CurItem
        Return NewText

    End Function

    Private Sub InsertUrl_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class
