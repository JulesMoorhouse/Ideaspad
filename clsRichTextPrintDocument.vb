
'   *************************************************************************************************
'   ******   This RichTextPrintDocument class is a VB.NET version of the RichTextPrintDocument ******
'   ******   class created by Christian Jaensch of Cortex Brainware GmbH.  The C# code written ******
'   ******   by Christian Jaensch was converted to VB.NET by Ron Beauchemin.  Christian        ******
'   ******   Jaensch based his C# class on the intial work of Martin Muller.                   ******
'   ******   The RichTextPrintDocument class allows the user to print RTF formatted text       ******
'   ******   contained within a RichTextbox control.  This class provides the functionality    ******
'   ******   of the VB6 RichTexbox SelPrint method.  For some unknown reason Microsoft did not ******
'   ******   include RTF printing capability within the .NET Framework in version 1.0.         ******
'   *************************************************************************************************   

Imports System
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms


Public Class RichTextPrintDocument
    Inherits PrintDocument

    '   *************************************************************************************
    '   ******   The following data structures needed by SendMessage API function call ******
    '   ******   which sends the EM_FORMATRANGE message to the RichTextbox control.    ******
    '   ******   send to RichTextBox control windows handle via SendMessage()          ******
    '   ******   The windows message handling is based on code posted by Martin M�ller ******
    '   ******   on 08.Feb.2002 in his RichTextBoxEx class.                            ******
    '   *************************************************************************************

    <StructLayout(LayoutKind.Sequential)> _
   Private Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure CHARACTER_RANGE
        Public cpMin As Integer
        Public cpMax As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure FORMAT_RANGE
        Public hdc As IntPtr
        Public hdcTarget As IntPtr
        Public Rectangle As RECT
        Public PageRectangle As RECT
        Public CharacterRange As CHARACTER_RANGE
    End Structure

    Private Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, _
                                                                ByVal msg As Integer, _
                                                                ByVal wParam As IntPtr, _
                                                                ByVal lParam As IntPtr) As IntPtr

    Private WM_USER As Integer = &H400
    Private EM_FORMATRANGE As Integer = WM_USER + 57

    'Private m_objRichTextBox As ExRichTextBox 
    'changed back to what was, due to loop of millions of pages
    Private m_objRichTextBox As RichTextBox
    Private m_intTextLength As Integer
    Private m_intFirstCharacterToPrint As Integer
    Private m_intLastCharacterToPrint As Integer
    Private m_blnPrintSelectedTextOnly As Boolean

    '    Public Sub New(ByVal vobjRichTextBox As RichTextBox, _
    '               Optional ByVal vblnPrintSelectedTextOnly As Boolean = False)
    
    'Public Sub New(ByVal vobjRichTextBox As ExRichTextBox, _
    '               Optional ByVal vblnPrintSelectedTextOnly As Boolean = False)
    'changed back to what was, due to loop of millions of pages
    Public Sub New(ByVal vobjRichTextBox As RichTextBox, _
               Optional ByVal vblnPrintSelectedTextOnly As Boolean = False)

        m_objRichTextBox = vobjRichTextBox
        m_blnPrintSelectedTextOnly = vblnPrintSelectedTextOnly

        With vobjRichTextBox
            If m_blnPrintSelectedTextOnly And .SelectionLength > 0 Then
                m_intFirstCharacterToPrint = .SelectionStart
                m_intLastCharacterToPrint = (.SelectionStart + .SelectionLength) - 1
                m_intTextLength = .SelectionLength
            Else
                m_intFirstCharacterToPrint = 0
                'm_intLastCharacterToPrint = GetTextLen(vobjRichTextBox) 
                'changed back to what was, due to loop of millions of pages
                m_intLastCharacterToPrint = .TextLength
            End If

        End With

    End Sub

    '   **************************************************************************************
    '   ******   Override the OnPrintPage event to provide the document printing logic  ******
    '   **************************************************************************************

    Protected Overrides Sub OnPrintPage(ByVal ev As PrintPageEventArgs)
        MyBase.OnPrintPage(ev)

        '   **********************************************************************************
        '   ******   Calculate and render as much text as will fit on the page and      ******
        '   ******   and remember the last character printed so that we can start       ******
        '   ******   printing the next page from the proper starting point.             ******
        '   **********************************************************************************

        m_intFirstCharacterToPrint = FormatRange(ev, m_intFirstCharacterToPrint, m_intLastCharacterToPrint)

        If m_intFirstCharacterToPrint < m_intLastCharacterToPrint Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
        End If

    End Sub

    '   **********************************************************************************
    '   ******   Override OnEndPrint to perform clean up after printing             ******
    '   **********************************************************************************

    Protected Overrides Sub OnEndPrint(ByVal ev As PrintEventArgs)

        MyBase.OnBeginPrint(ev)
        FormatRangeDone()

    End Sub

    '   **********************************************************************************
    '   ******    Convert between 1/100 inch (unit used by the .NET framework) and  ******
    '   ******    twips (1/1440 inch, used by Win32 API calls)                      ******
    '   ******    The HundredthInchToTwips method returns the number of twips       ******
    '   ******    for the number of hundreths of inches passed                      ******
    '   **********************************************************************************

    Private Function HundredthInchToTwips(ByVal intNumHundredthsOfInch As Integer) As Integer

        Return CInt(intNumHundredthsOfInch * 14.4)

    End Function

    '   ****************************************************************************************
    '   ******   Calculate and render the contents of the RichTextbox as a printed page   ******
    '   ******   The PrintPageEventArgs parameter is the PrintPageEventArgs object from   ******
    '   ******   the PrintPage event.                                                     ******
    '   ****************************************************************************************

    Private Function FormatRange(ByVal ev As PrintPageEventArgs, _
                                 ByVal intStartingPosition As Integer, _
                                 ByVal intEndingPosition As Integer) As Integer

        Dim structCharacterRange As CHARACTER_RANGE
        Dim structRectangle As RECT
        Dim structPageRectangle As RECT
        Dim structFormatRange As FORMAT_RANGE
        Dim ptrHdc As IntPtr
        Dim ptrResource As IntPtr
        Dim ptrWparm As New IntPtr(1)
        Dim ptrLparm As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(structFormatRange))

        With structCharacterRange
            .cpMin = intStartingPosition
            .cpMax = intEndingPosition
        End With

        With structRectangle
            .top = HundredthInchToTwips(ev.MarginBounds.Top)
            .bottom = HundredthInchToTwips(ev.MarginBounds.Bottom)
            .left = HundredthInchToTwips(ev.MarginBounds.Left)
            .right = HundredthInchToTwips(ev.MarginBounds.Right)
        End With

        With structPageRectangle
            .top = HundredthInchToTwips(ev.PageBounds.Top)
            .bottom = HundredthInchToTwips(ev.PageBounds.Bottom)
            .left = HundredthInchToTwips(ev.PageBounds.Left)
            .right = HundredthInchToTwips(ev.PageBounds.Right)
        End With

        ptrHdc = ev.Graphics.GetHdc()

        With structFormatRange
            .CharacterRange = structCharacterRange
            .hdc = ptrHdc
            .hdcTarget = ptrHdc
            .Rectangle = structRectangle
            .PageRectangle = structPageRectangle
        End With

        '   **************************************************************************************
        '   ******   Build SendMessage API function arguments                               ******
        '   **************************************************************************************

        Marshal.StructureToPtr(structFormatRange, ptrLparm, False)

        '   **************************************************************************************
        '   ******   Let the richTextBox control format its content for printing            ******
        '   **************************************************************************************

        ptrResource = SendMessage(m_objRichTextBox.Handle, EM_FORMATRANGE, ptrWparm, ptrLparm)

        '   **************************************************************************************
        '   ******   Clean-up resources                                                     ******
        '   **************************************************************************************

        Marshal.FreeCoTaskMem(ptrLparm)
        ev.Graphics.ReleaseHdc(ptrHdc)

        Return ptrResource.ToInt32()

    End Function


    '   **************************************************************************************
    '   ******   Clean-up method after the print job is finished to release cached      ******
    '   ******   information                                                            ******
    '   **************************************************************************************

    Private Sub FormatRangeDone()

        Dim ptrWparm As New IntPtr(0)
        Dim ptrLparm As New IntPtr(0)

        SendMessage(m_objRichTextBox.Handle, EM_FORMATRANGE, ptrWparm, ptrLparm)

    End Sub

    Public Property PrintSelectedTextOnly() As Boolean
        Get
            Return m_blnPrintSelectedTextOnly
        End Get

        Set(ByVal vblnPrintSelectedTextOnly As Boolean)

            With m_objRichTextBox
                m_blnPrintSelectedTextOnly = vblnPrintSelectedTextOnly
                If m_blnPrintSelectedTextOnly And .SelectionLength > 0 Then
                    m_intFirstCharacterToPrint = .SelectionStart
                    m_intLastCharacterToPrint = (.SelectionStart + .SelectionLength) - 1
                    m_intTextLength = .SelectionLength
                Else
                    m_intFirstCharacterToPrint = 0
                    'm_intLastCharacterToPrint = GetTextLen(m_objRichTextBox) 
                    'm_intTextLength = GetTextLen(m_objRichTextBox) 
                    'changed back to what was, due to loop of millions of pages
                    m_intLastCharacterToPrint = .TextLength
                    m_intTextLength = .TextLength
                End If
            End With

        End Set

    End Property

End Class
