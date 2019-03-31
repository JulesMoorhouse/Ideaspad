' A WebBrowser host fashioned as a UserControl. This allows us to:
' (1) Encapsulate common tasks while using the WebOC (performing actions on DocumentComplete, saving files to 
' disk, etc.).
' (2) Reuse all the above functionality on different forms - particularly
' useful for handling NewWindow2. 

Imports mshtml
Imports System.Resources
Imports System.Runtime.InteropServices
Public Class WebOCHostCtrl
    Inherits System.Windows.Forms.UserControl

    '    '--- Win32Hook --- 
    '    <DllImport("kernel32")> _
    '    Private Shared Function GetCurrentThreadId() As Integer
    '    End Function
    '    <DllImport("user32", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    '    Private Shared Function SetWindowsHookEx(ByVal idHook As HookType, ByVal lpfn As HOOKPROC, ByVal hmod As Integer, ByVal dwThreadId As Integer) As Integer
    '    End Function
    '    Private Declare Function UnhookWindowsHookEx Lib "user32" (ByVal hHook As Integer) As Integer

    '    Public Enum HookType
    '        WH_KEYBOARD = 2
    '    End Enum 'HookType

    '    Delegate Function HOOKPROC(ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    '    Private Declare Function CallNextHookEx Lib "user32" (ByVal hHook As Integer, ByVal ncode As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    '    Private _KeyboardHook As Integer

    '    Public Function KbdHook(ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    '        'MsgBox("hi")
    '        'Console.WriteLine("nCode=" & nCode & " wParam=" & wParam & " lParam=" & lParam)


    '        'Select Case wParam
    '        'Case System.Windows.Forms.Keys.Escape
    '        If nCode > 0 And lParam > 0 Then
    '            RaiseEvent KeyPressed(wParam)
    '        Else
    '            'Case Else
    ''            Return CallNextHookEx(_KeyboardHook, nCode, wParam, lParam)
    '        End If        'End Select
    'Return CallNextHookEx(_KeyboardHook, nCode, wParam, lParam)
    '    End Function
    '    Public Event KeyPressed(ByVal KeyCode As System.Windows.Forms.Keys)

    '    '--- Win32Hook --- 

    ' Expose WebBrowser events so that clients can sink them simply and 
    ' directly, without exposing the underlying control.
    'Public Event CommandStateChange(ByVal Sender As Object, ByVal E As AxSHDocVw.DWebBrowserEvents2_CommandStateChangeEvent)
    'Public Event EnableBack(ByVal Sender As Object, ByVal E As System.EventArgs)
    'Public Event DisableBack(ByVal Sender As Object, ByVal E As System.EventArgs)
    'Public Event EnableForward(ByVal Sender As Object, ByVal E As System.EventArgs)
    'Public Event DisableForward(ByVal Sender As Object, ByVal E As System.EventArgs)
    'Public Event StatusTextChange(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEvent) 
    'Public Event DocumentComplete(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent)

    Public Event DocumentComplete(ByVal sender As Object, ByVal e As Object) 

    'Public Event TopLevelNavigateComplete2(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event)

    ' Instance data.
    Private enableCtxMenu As Boolean

    ' The current instance of MSHTML.
    Private WithEvents doc As HtmlDocument

    ' The GUID we need to invoke FInd, View Source and Options on
    ' WebBrowser. Note that the second param is in its two complement
    ' representation because the number otherwise outstrips the size
    ' of a VB short.
    Private cmdGUID As New Guid(&HED016940, -17061, &H11CF, &HBA, &H4E, &H0, &HC0, &H4F, &HD7, &H8, &H16)

    ' Constants for the above-named commands
    Private Enum MiscCommandTarget
        Find = 1
        ViewSource
        Options
    End Enum

    ' Constants for regular OLECMDID command targets.


    ' Constants for forward/back testing.
    Enum CommandState
        UpdateCommands = -1
        Forward = 1
        Back = 2
    End Enum

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'SetWindowsHookEx(HookType.WH_KEYBOARD, AddressOf KbdHook, 0, GetCurrentThreadId()) 

        ' Load resources.
        rm = New ResourceManager("WebOCHostCtrl", System.Reflection.Assembly.GetExecutingAssembly())
    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If

            rm = Nothing
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents webBrowser As AxSHDocVw.AxWebBrowser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(WebOCHostCtrl))
        Me.webBrowser = New AxSHDocVw.AxWebBrowser()
        CType(Me.webBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'webBrowser
        '
        Me.webBrowser.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.webBrowser.Enabled = True
        Me.webBrowser.OcxState = CType(resources.GetObject("webBrowser.OcxState"), System.Windows.Forms.AxHost.State)
        Me.webBrowser.Size = New System.Drawing.Size(616, 320)
        Me.webBrowser.TabIndex = 0
        '
        'WebOCHostCtrl
        '
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.webBrowser})
        Me.Name = "WebOCHostCtrl"
        Me.Size = New System.Drawing.Size(616, 320)
        CType(Me.webBrowser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    ' PRIVATE INSTANCE VARIABLES
    ' 
    Private rm As ResourceManager

    '
    ' PROPERTIES
    ' 

    ' Obtain a reference to the hosted HTML document. 
    Public ReadOnly Property HtmlDocument() As mshtml.HTMLDocument
        Get
            Dim doc As HTMLDocument
            Try
                doc = CType(webBrowser.Document, mshtml.HTMLDocument)
            Catch
                Throw (New Exception(rm.GetString("Err_HtmlDocumentNotReady")))
            End Try

            HtmlDocument = doc
        End Get
    End Property

    ' 
    ' METHODS
    ' 

    ' Define a simple Navigate to handle most navigation circumstances.
    Public Overloads Sub Navigate(ByVal url As String)
        Dim o As New Object()

        webBrowser.Navigate(url, o, o, o, o)
    End Sub

    Public Overloads Sub Navigate(ByVal url As String, ByVal o As Object)

    End Sub

    ' Print a document, telling the WebBrowser whether or not to display
    ' the UI. MSHTML exposes a method to print as well, but we want these
    ' semantics to work for any document server (Word, Excel, etc.), so we
    ' perform the op against the doc host instead.
    Public Sub Print(ByVal doUI As Boolean)
        Dim doOpt As SHDocVw.OLECMDEXECOPT

        If doUI Then
            doOpt = SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER
        Else
            doOpt = SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER
        End If

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINT, doOpt)
        Catch 
        End Try 

    End Sub

    ' Print a document using an MSHTML Print Template.
    Public Sub PrintFormatted(ByVal tmplPath As String)
        Dim o As New Object()

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, CType(tmplPath, Object), o)
        Catch 
        End Try 

    End Sub

    Public Function IsUndoEnabled() As Boolean
        
        Dim res As SHDocVw.OLECMDF = webBrowser.QueryStatusWB(SHDocVw.OLECMDID.OLECMDID_UNDO)
        If (res And SHDocVw.OLECMDF.OLECMDF_ENABLED) = SHDocVw.OLECMDF.OLECMDF_ENABLED Then
            IsUndoEnabled = True
        Else
            IsUndoEnabled = False
        End If

    End Function

    Public Function IsRedoEnabled() As Boolean
        
        Dim res As SHDocVw.OLECMDF = webBrowser.QueryStatusWB(SHDocVw.OLECMDID.OLECMDID_REDO)
        If (res And SHDocVw.OLECMDF.OLECMDF_ENABLED) = SHDocVw.OLECMDF.OLECMDF_ENABLED Then
            IsRedoEnabled = True
        Else
            IsRedoEnabled = False
        End If

    End Function
    ' Easy commands to test copy/cut/paste status of the control.
    Public Function IsCutEnabled() As Boolean

        Dim res As SHDocVw.OLECMDF = webBrowser.QueryStatusWB(SHDocVw.OLECMDID.OLECMDID_CUT)
        If (res And SHDocVw.OLECMDF.OLECMDF_ENABLED) = SHDocVw.OLECMDF.OLECMDF_ENABLED Then
            IsCutEnabled = True
        Else
            IsCutEnabled = False
        End If
    End Function

    Public Function IsCopyEnabled() As Boolean
        Dim res As SHDocVw.OLECMDF = webBrowser.QueryStatusWB(SHDocVw.OLECMDID.OLECMDID_COPY)
        If (res And SHDocVw.OLECMDF.OLECMDF_ENABLED) = SHDocVw.OLECMDF.OLECMDF_ENABLED Then
            IsCopyEnabled = True
        Else
            IsCopyEnabled = False
        End If
    End Function

    Public Function IsPasteEnabled() As Boolean
        Dim qVal As SHDocVw.OLECMDF = webBrowser.QueryStatusWB(SHDocVw.OLECMDID.OLECMDID_PASTE)
        Dim i As Integer
        If (qVal And SHDocVw.OLECMDF.OLECMDF_ENABLED) = SHDocVw.OLECMDF.OLECMDF_ENABLED Then
            IsPasteEnabled = True
        Else
            IsPasteEnabled = False
        End If
    End Function

    ' View the source of the current HTML page in Notepad.
    Public Sub ViewSource()
        Dim cmdt As IOleCommandTarget
        Dim o As Object

        ' If the doc object isn't set to anything, or there's
        ' some bizarre error in accessing IOleCommandTarget,
        ' exit gracefully.
        Try
            cmdt = CType(doc, IOleCommandTarget)
            cmdt.Exec(cmdGUID, MiscCommandTarget.ViewSource, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, o, o)
        Catch ex As Exception
            Throw (New Exception(ex.Message))
        End Try
    End Sub

    Public Sub Find()
        Dim cmdt As IOleCommandTarget
        Dim o As Object

        ' If the doc object isn't set to anything, or there's
        ' some bizarre error in accessing IOleCommandTarget,
        ' exit gracefully.
        Try
            cmdt = CType(doc, IOleCommandTarget)
            cmdt.Exec(cmdGUID, MiscCommandTarget.Find, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, o, o)
        Catch ex As Exception
            Throw (New Exception(ex.Message))
        End Try
    End Sub

    Public Sub InternetOptions()
        Dim cmdt As IOleCommandTarget
        Dim o As Object

        ' If the doc object isn't set to anything, or there's
        ' some bizarre error in accessing IOleCommandTarget,
        ' exit gracefully.
        Try
            cmdt = CType(doc, IOleCommandTarget)
            cmdt.Exec(cmdGUID, MiscCommandTarget.Options, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, o, o)
        Catch
            ' Throw (New Exception(Err.GetException().Message))
        End Try
    End Sub

    ' Enable or disable IE's context menu? This allows the parent host
    ' to render its own.
    Public Property BrowserContextMenu() As Boolean
        Get
            BrowserContextMenu = enableCtxMenu
        End Get
        Set(ByVal Value As Boolean)
            ' Disable it. Note that we'll need to do this for each
            ' page navigation, as the event sink is specific to an 
            ' instance of MSHTML.
            If (True = Value) Then
                DisableContextMenu()
            Else
                EnableContextMenu()
            End If

            enableCtxMenu = Value
        End Set
    End Property

    ' Some simple thunks
    Public Sub GoBack()
        webBrowser.GoBack()
    End Sub

    Public Sub GoForward()
        webBrowser.GoForward()
    End Sub

    Public Sub GoHome()
        webBrowser.GoHome()
    End Sub

    Public Sub Delete() 
        
        Try
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_DELETE, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
        Catch
        End Try
    End Sub
    Public Sub Undo() 
        
        Try
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_UNDO, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
        Catch
        End Try
    End Sub
    Public Sub Redo() 
        
        Try
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_REDO, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
        Catch
        End Try
    End Sub
    ' Cut/copy/paste methods.
    Public Sub Cut()

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_CUT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
        Catch 
        End Try 

    End Sub

    Public Sub Copy()

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_COPY, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
        Catch 
        End Try 

    End Sub
    Public Sub SelectAll() 

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_SELECTALL, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER) 
        Catch 
        End Try 

    End Sub
    Public Sub Paste()

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_PASTE, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
        Catch 
        End Try 

    End Sub
    Public Function ReadyState() As SHDocVw.tagREADYSTATE
        Return webBrowser.ReadyState
    End Function
    Public Sub DecreaseFontSize() 

        Dim Z As Object      'Z is the value to hold the zoom level.

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, Nothing, Z)
        Catch 
        End Try 

        If Z > 0 Then
            Z = Z - 1
        Else
            Z = 0
        End If

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, Z, Nothing)
        Catch 
        End Try 

    End Sub
    Public Function GetFontSize() As Integer    

        Dim Z As Object      'Z is the value to hold the zoom level.

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, Nothing, Z)
        Catch 
        End Try 

        Return Z
    End Function
    Public Sub SetFontSize(ByVal pZ As Integer) 

        Dim Z As Object      'Z is the value to hold the zoom level.

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, Nothing, Z)
        Catch 
        End Try 

        If Z > 0 Then
            Z = Z - 1
        Else
            Z = 0
        End If

        If Z < 4 Then
            Z = Z + 1
        Else
            Z = 4
        End If

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, Z, Nothing)
        Catch 
        End Try 

    End Sub
    Public Sub IncreaseFontSize() 

        Dim Z As Object      'Z is the value to hold the zoom level.

        Try
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, Nothing, Z)
        Catch 
        End Try 

        If Z < 4 Then
            Z = Z + 1
        Else
            Z = 4
        End If

        Try 
            webBrowser.ExecWB(SHDocVw.OLECMDID.OLECMDID_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, Z, Nothing)
        Catch 
        End Try 

    End Sub
    ' 
    ' PRIVATE METHODS
    '
    Public Sub DisableContextMenu()
        'Console.WriteLine("DisableContextMenu")
    End Sub

    Public Sub EnableContextMenu()
        'Console.WriteLine("EnableContextMenu")
    End Sub

    ' Multiplex this event, so that hosts don't have to fuss with
    ' the CSC_ values or repeat this logic for every hosted
    ' instance.
    'Private Sub webBrowser_CommandStateChange(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_CommandStateChangeEvent) Handles webBrowser.CommandStateChange
    '    If CommandState.Back = e.command Then
    '        If True = e.enable Then
    '            RaiseEvent EnableBack(sender, New System.EventArgs())
    '        Else
    '            RaiseEvent DisableBack(sender, New System.EventArgs())
    '        End If
    '    ElseIf CommandState.Forward = e.command Then
    '        If True = e.enable Then
    '            RaiseEvent EnableForward(sender, New System.EventArgs())
    '        Else
    '            RaiseEvent DisableForward(sender, New System.EventArgs())
    '        End If
    '    Else
    '        RaiseEvent CommandStateChange(sender, e)
    '    End If
    'End Sub

    ' Perform per-document init tasks.
    Private Sub webBrowser_DocumentComplete(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent) Handles webBrowser.DocumentComplete
        Try
            doc = CType(webBrowser.Document, mshtml.HTMLDocument)
        Catch
            ' Not a fatal error - we might be hosting a Word doc in-place,
            ' e.g.
        End Try

        ' Bubble up to our host.
        'RaiseEvent DocumentComplete(sender, e)
        RaiseEvent DocumentComplete(sender, CType(e, Object)) 
    End Sub

    'Sink the event and raise it to the container. 
    'Private Sub webBrowser_StatusTextChange(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEvent) Handles webBrowser.StatusTextChange
    '    RaiseEvent StatusTextChange(sender, e)
    'End Sub


    'Private Sub webBrowser_TopLevelNavigateComplete2(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event) Handles webBrowser.NavigateComplete2
    '    If (webBrowser.LocationURL).Equals(Convert.ToString(e.uRL)) Then
    '        RaiseEvent TopLevelNavigateComplete2(sender, e)
    '    End If
    'End Sub
    Public Overridable Overloads ReadOnly Property Busy() As Boolean 
        Get
            Return webBrowser.Busy
        End Get

    End Property

    Sub x()

    End Sub

End Class