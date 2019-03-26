Imports mshtml
<DoNotObfuscateAttribute()> Friend Class ipsplash
    Inherits System.Windows.Forms.Form
    Private LangText As System.Resources.ResourceManager = New _
            System.Resources.ResourceManager("Ideaspad.Ideaspad", _
            System.Reflection.Assembly.GetExecutingAssembly()) 
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'ipsplash
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(489, 224)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "ipsplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ideaspad"
        Me.TransparencyKey = System.Drawing.Color.White

    End Sub

#End Region
    Dim G As Graphics
    Dim tempG As Graphics
    Dim tempBitmap As Bitmap
    Dim lbooDoneOnce As Boolean = False
    Dim mbooShiftPressed As Boolean = False
    Dim mbooAcceptShift As Boolean = False
    Dim mstrRegWho As String 
    Dim UpTime As DateTime = Date.Now() 
    Friend WriteOnly Property RegWho() As String 
        Set(ByVal Value As String)
            mstrRegWho = Value
        End Set
    End Property
    Friend Property AcceptShift() As Boolean
        Get
            'Return mbooAcceptShift
            Return mbooAcceptShift 'What, why was this commented out ?? 
        End Get
        Set(ByVal Value As Boolean)
            mbooAcceptShift = Value
        End Set
    End Property
    Friend Property ShiftPressed() As Boolean
        Get
            Return mbooShiftPressed
        End Get
        Set(ByVal Value As Boolean)
            mbooShiftPressed = Value
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        Dim lconIdeaspadShadow As New Color()
        Dim lconIdeaspadHighlight As New Color()
        Dim lconDevelopedByShadow As New Color()
        Dim lconDevelopedByHighlight As New Color()
        Dim lconMCLShadow As New Color()
        Dim lconMCLHighlight As New Color()
        Dim lconVersionBox As New Color()
        Dim lconVersionBack As New Color()
        Dim lconVersionText As New Color()

        Dim BHeight As Integer = 224
        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then
            BHeight = 245 '260
            Me.Height = BHeight
        End If

        tempBitmap = New Bitmap(489, BHeight)
        tempG = Graphics.FromImage(DirectCast(tempBitmap, Image))
        G = Me.CreateGraphics()

        tempG.FillRectangle(New SolidBrush(Color.White), New Rectangle(0, 0, 489, BHeight))

        tempG.DrawRectangle(New Pen(Color.Black), New Rectangle(0, 0, 488, BHeight - 1)) 

        lconIdeaspadShadow = Color.LightBlue
        lconIdeaspadHighlight = Color.FromArgb(255, 64, 64, 64) 'Color.Gray
        lconDevelopedByShadow = Color.LightBlue
        lconDevelopedByHighlight = Color.Black
        lconMCLShadow = Color.LightBlue
        lconMCLHighlight = Color.Black
        lconVersionBack = Color.DarkBlue
        lconVersionBox = Color.Black
        lconVersionText = Color.Yellow

        Dim x As New GetColorDepth()
        Select Case x.ScreenColors
            Case 4 ' aka 16 colours
                lconIdeaspadShadow = Color.Cyan
                lconDevelopedByShadow = Color.Cyan
                lconMCLShadow = Color.Cyan
        End Select
        x = Nothing

        tempG.SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias

        Dim FS2 As Integer = 60

        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then FS2 = 52

        tempG.DrawString("IDEASPAD", New Font("Arial", FS2, FontStyle.Bold), New SolidBrush(lconIdeaspadShadow), 10, 10)
        tempG.DrawString("IDEASPAD", New Font("Arial", FS2, FontStyle.Bold), New SolidBrush(lconIdeaspadShadow), 14, 14)
        tempG.DrawString("IDEASPAD", New Font("Arial", FS2, FontStyle.Bold), New SolidBrush(lconIdeaspadShadow), 10, 14)
        tempG.DrawString("IDEASPAD", New Font("Arial", FS2, FontStyle.Bold), New SolidBrush(lconIdeaspadShadow), 14, 10)

        Dim lintArrInc As Integer
        For lintArrInc = 1 To FS2 - 5
            tempG.DrawString("IDEASPAD", New Font("Arial", (FS2) - lintArrInc _
                , FontStyle.Bold), New SolidBrush(lconIdeaspadShadow), 10 + lintArrInc, 10 + lintArrInc)
        Next lintArrInc
        tempG.DrawString("IDEASPAD", New Font("Arial", FS2, FontStyle.Bold), New SolidBrush(lconIdeaspadHighlight), 12, 12)

        Dim XOff As Integer = 370
        Dim YOff As Integer = 30

        Dim XOf As Integer = -10
        Dim YOf As Integer = -25

        If InStrGet(NameMe("").ToUpper, "TRIAL") > 0 Then
            XOf = -7
            YOf = -17
        Else 'standard
            FS2 = 25

            For lintArrInc = 1 To FS2 - 5

                tempG.DrawString(gYear, New Font("Arial", (FS2) - lintArrInc _
                    , FontStyle.Regular), New SolidBrush(lconIdeaspadShadow), 10 + XOff + lintArrInc, 10 + lintArrInc + YOff)
            Next lintArrInc

            tempG.DrawString(gYear, New Font("Arial", FS2, FontStyle.Regular), New SolidBrush(lconIdeaspadHighlight), 12 + XOff, 12 + YOff)

        End If

        Const FS As Integer = 20
        Dim lintArrinc2 As Integer
        Dim lintArrinc3 As Integer
        For lintArrinc2 = 1 To 4
            For lintArrinc3 = 1 To 4
                'tempG.DrawString("Developed by", New Font("Arial", FS - 5, FontStyle.Regular), _
                '    New SolidBrush(lconDevelopedByShadow), 30 + lintArrinc2 + XOf, 115 + lintArrinc3 + YOf)
                
                tempG.DrawString(LangText.GetString("IpSplash_DevelopedBy"), New Font("Arial", FS - 5, FontStyle.Regular), _
                    New SolidBrush(lconDevelopedByShadow), 30 + lintArrinc2 + XOf, 115 + lintArrinc3 + YOf)

            Next lintArrinc3
        Next lintArrinc2
        
        tempG.DrawString(LangText.GetString("IpSplash_DevelopedBy"), New Font("Arial", FS - 5, FontStyle.Regular), New SolidBrush(lconDevelopedByHighlight), 32 + XOf, 117 + YOf)
   
        For lintArrinc2 = 1 To 4
            For lintArrinc3 = 1 To 4

                tempG.DrawString("Mindwarp Consultancy Ltd. �" & gYear, New Font("Arial", FS, FontStyle.Regular), _
                    New SolidBrush(lconMCLShadow), 28 + lintArrinc2 + XOf, 137 + lintArrinc3 + YOf)
            Next lintArrinc3
        Next lintArrinc2

        tempG.DrawString("Mindwarp Consultancy Ltd. �" & gYear, New Font("Arial", FS, FontStyle.Regular), New SolidBrush(lconMCLHighlight), 30 + XOf, 139 + YOf)
        '----
        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then
            For lintArrinc2 = 1 To 4
                For lintArrinc3 = 1 To 4
                    tempG.DrawString(LangText.GetString("IpSplash_StandardVersion"), New Font("Arial", 30, FontStyle.Regular), _
                        New SolidBrush(lconMCLShadow), 28 + lintArrinc2 + XOf + 60, 169 + lintArrinc3 + YOf)

                Next lintArrinc3
            Next lintArrinc2
            
            tempG.DrawString(LangText.GetString("IpSplash_StandardVersion"), New Font("Arial", 30, FontStyle.Regular), New SolidBrush(lconMCLHighlight), 30 + XOf + 60, 171 + YOf)

        Else 
            tempG.FillRectangle(New SolidBrush(lconVersionBack), New Rectangle(30, 180 + YOf, 430, 30))
            tempG.DrawRectangle(New Pen(lconVersionBox, 2), New Rectangle(30, 180 + YOf, 430, 30))
            tempG.DrawString(LangText.GetString("IpSplash_SharewareVersion"), New Font("Arial", FS, FontStyle.Regular), New SolidBrush(lconVersionText), 170, 178 + YOf)

        End If

        Dim lintShiftNVerHeight As Integer = 220
        If InStrGet(NameMe("").ToUpper, "TRIAL") = 0 Then
            lintShiftNVerHeight = 240
            
            tempG.DrawString(LangText.GetString("IpSplash_LicensedTo"), _
                New Font("Arial", 8, FontStyle.Regular), New SolidBrush(lconDevelopedByHighlight), 30 + XOf + 40, 220 + YOf)

            tempG.DrawString(mstrRegWho, _
                New Font("Arial", 8, FontStyle.Regular), New SolidBrush(lconVersionBack), 100 + XOf + 40, 220 + YOf)
        End If
                
        If mbooAcceptShift = True Then
            tempG.DrawString(LangText.GetString("IpSplash_PressShift"), New Font("Arial", 8, FontStyle.Regular), New SolidBrush(lconVersionBox), -5 + XOf + 60, lintShiftNVerHeight + YOf)
        End If

        tempG.DrawString("V" & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).ProductVersion, _
            New Font("Arial", 8, FontStyle.Regular), New SolidBrush(lconDevelopedByHighlight), 440 + XOf, lintShiftNVerHeight + YOf)
        
        e.Graphics.DrawImage(tempBitmap, 0, 0)
        Me.TransparencyKey = System.Drawing.Color.Tomato 

        System.Windows.Forms.Application.DoEvents()

        Try 
            'with    12.25 seconds to dbchoice screen 
            'without  7.24 seconds
            '''PreloadInternetDlls()
        Catch 
        End Try 

    End Sub
    Private Sub PreloadInternetDlls()

        If lbooDoneOnce = False Then
            lbooDoneOnce = True
        Else
            Exit Sub
        End If
        Me.SuspendLayout()

        Dim AxWebBrowser As New WinOnly.WebOCHostCtrl()
        Me.SuspendLayout()
        AxWebBrowser.Visible = False

        'Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ipsplash))

        SpawnBrowserObject(AxWebBrowser, Me)

        'AxWebBrowser.Navigate("about:blank")
        Dim TR As New IPTemplates._main()

        Dim lstrTemplateResources() As IPTemplates._main.resources
        TR.HTMLForms(lstrTemplateResources)

        ShowForm(lstrTemplateResources(0).file, AxWebBrowser, True)

        ' use a system template
        'Dim HtmlDoc As IHTMLDocument2 = CType(AxWebBrowser.Document, IHTMLDocument2)
        'Dim FormCol As IHTMLElementCollection = HtmlDoc.forms
        'Dim oForm As IHTMLFormElement = CType(FormCol.item(CType(0, Object), CType(0, Object)), IHTMLFormElement)

        'If AxWebBrowser.ReadyState = SHDocVw.tagREADYSTATE.READYSTATE_LOADING Then
        '    Do Until AxWebBrowser.ReadyState <> SHDocVw.tagREADYSTATE.READYSTATE_LOADING '= SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE
        '        System.Windows.Forms.Application.DoEvents()
        '        'AxWebBrowser1.Refresh()
        '    Loop
        'End If
        WaitForBrowser(AxWebBrowser) 

        PopulateHTMLFields("     ", AxWebBrowser)

        AxWebBrowser = Nothing

        Me.ResumeLayout()

    End Sub
    Private Sub ipstdsplash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If mbooAcceptShift = True Then 
            If e.KeyCode = Keys.ShiftKey Then
                mbooShiftPressed = True
                'MessageBox.Show("Shift Pressed") 'FOR TESTING PURPOSES ONLY 
            End If
        End If 

    End Sub
    'Why the hell do you need this then??? No background!! 
    'Private Sub ipsplash_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    '    Me.Invalidate() 
    'End Sub
End Class

