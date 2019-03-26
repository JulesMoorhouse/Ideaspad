Imports System.Threading
Imports System.Globalization
Public Class DateAndTime
    Inherits System.Windows.Forms.Form
    Dim mstrReturnDate As String
    Public Property ReturnDate() As String
        Get
            Return mstrReturnDate
        End Get
        Set(ByVal Value As String)
            mstrReturnDate = Value
        End Set
    End Property
    Friend WithEvents lstDateSelection As ListBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button

    Public Sub New()

        Dim StandLangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("AppBasic.AppBasic", _
            System.Reflection.Assembly.Load("AppBasic"))

        Dim LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("RTFStand.RTFStand", _
            System.Reflection.Assembly.GetExecutingAssembly())

        lstDateSelection = New ListBox()
        btnOK = New Button()
        btnCancel = New Button()

        With lstDateSelection
            .Top = 10
            .Left = 10
            .Width = 300
            .Height = 280 '400
            .TabIndex = 0
        End With

        'With btnOK
        '    .Left = lstDateSelection.Left
        '    .Top = lstDateSelection.Top + lstDateSelection.Height + 10
        '    .TabIndex = 1
        '    .Text = StandLangText.GetString("StandText_OK")
        '    .FlatStyle = FlatStyle.System
        '    .BackColor = Color.FromArgb(0, .BackColor)
        'End With

        With btnCancel
            .Left = 10 + (lstDateSelection.Width) - .Width
            .Top = lstDateSelection.Top + lstDateSelection.Height + 10
            .TabIndex = 2
            .Text = StandLangText.GetString("StandText_Cancel")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        With btnOK
            .Left = (btnCancel.Left - .Width) - 10
            .Top = lstDateSelection.Top + lstDateSelection.Height + 10
            .TabIndex = 1
            .Text = StandLangText.GetString("StandText_OK")
            If IsAboveOrEqualWinXp() = True Then .FlatStyle = FlatStyle.System 
            .BackColor = Color.FromArgb(0, .BackColor)
        End With

        Me.Text = LangText.GetString("DateTime_Title").Replace("&", "")
        Me.Width = lstDateSelection.Left + lstDateSelection.Width + 20
        Me.Height = btnOK.Top + btnOK.Height + 40
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.ShowInTaskbar = False 
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.KeyPreview = True
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lstDateSelection, Me.btnOK, Me.btnCancel})

    End Sub
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click

        mstrReturnDate = lstDateSelection.Text

        Me.Close()
        'Me.Dispose()

    End Sub
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        mstrReturnDate = ""
        Me.Close()
        'Me.Dispose()

    End Sub

    Private Sub Class1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dt As DateTime = DateTime.Now
        Dim myformat() As String = {"d", "D", _
                                    "f", "F", _
                                    "g", "G", _
                                    "m", _
                                    "r", _
                                    "s", _
                                    "t", "T", _
                                    "u", _
                                    "y", _
                                    "dd/MMM/yyyy", _
                                    "dd/MMM/yy", _
                                    "MMM/dd/yyyy", _
                                    "ddd, MMM d ""'""yy", _
                                    "dddd, MMMM dd", _
                                    "M/yy", _
                                    "dd-MM-yy"}
        Dim mydate As String
        Dim lintArrInc As Integer
        For lintArrInc = 0 To myformat.Length - 1
            mydate = dt.ToString(myformat(lintArrInc), DateTimeFormatInfo.InvariantInfo)
            'Console.WriteLine(String.Concat(myformat(i), " :", mydate))
            'lstDateSelection.Items.Add(String.Concat(myformat(lintArrInc), " :", mydate))
            lstDateSelection.Items.Add(mydate)
        Next lintArrInc

        lstDateSelection.SelectedIndex = 0

    End Sub
    Private Sub lstDateSelection_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDateSelection.DoubleClick

        btnOK_Click(Nothing, Nothing)

    End Sub
    Private Sub lstDateSelection_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstDateSelection.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnOK_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub DatePicker_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            btnCancel_Click(Nothing, Nothing)
        End If

    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        Dim PaintBack As New UIStyle.Painting()
        PaintBack.PaintBackground(pevent, Me)

    End Sub

    Private Sub DateAndTime_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Invalidate() 
    End Sub
End Class