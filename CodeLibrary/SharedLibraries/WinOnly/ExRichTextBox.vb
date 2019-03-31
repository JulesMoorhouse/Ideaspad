
Imports System
Imports System.Collections.Specialized
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms



#Region "Public Enums" '
'ToDo: Error processing original source shown below
'
' #region Public Enums
'--^--- Syntax error: '}' expected

' Enum for possible RTF colors

Public Enum RtfColor
    Black
    Maroon
    Green
    Olive
    Navy
    Purple
    Teal
    Gray
    Silver
    Red
    Lime
    Yellow
    Blue
    Fuchsia
    Aqua
    White
End Enum 'RtfColor

#End Region

'/ <summary>
'/ This class adds the following functionality to RichTextBox:
'/ 
'/ 1.	Allows plain text to be inserted or appended programmatically to RTF
'/		content.
'/ 2.	Allows the font, text color, and highlight color of plain text to be
'/		specified when inserting or appending text as RTF.
'/	3.	Allows images to be inserted programmatically, or with interaction from
'/		the user.
'/ </summary>
'/ <remarks>
'/ Many solutions to the problem of programmatically inserting images
'/ into a RichTextBox use the clipboard or hard code the RTF for
'/ the image in the program.  This class is an attempt to make the process of
'/ inserting images at runtime more flexible without the overhead of maintaining
'/ the clipboard or the use of huge, cumbersome strings.
'/ 
'/ RTF Specification v1.6 was used and is referred to many times in this document.
'/ http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnrtfspec/html/rtfspec.asp
'/ 
'/ For information about the RichEdit (Unmanaged RichTextBox) ...
'/ http://msdn.microsoft.com/library/default.asp?url=/library/en-us/shellcc/platform/commctls/richedit/richeditcontrols/aboutricheditcontrols.asp
'/ </remarks>

Public Class ExRichTextBox
    Inherits System.Windows.Forms.RichTextBox

#Region "My Enums"

    ' Specifies the flags/options for the unmanaged call to the GDI+ method
    ' Metafile.EmfToWmfBits().

    Private Enum EmfToWmfBitsFlags

        ' Use the default conversion
        EmfToWmfBitsFlagsDefault = &H0

        ' Embedded the source of the EMF metafiel within the resulting WMF
        ' metafile
        EmfToWmfBitsFlagsEmbedEmf = &H1

        ' Place a 22-byte header in the resulting WMF file.  The header is
        ' required for the metafile to be considered placeable.
        EmfToWmfBitsFlagsIncludePlaceable = &H2

        ' Don't simulate clipping by using the XOR operator.
        EmfToWmfBitsFlagsNoXORClip = &H4
    End Enum 'EmfToWmfBitsFlags
    'Private __unknown As __unknown '
    'ToDo: Error processing original source shown below
    '   EmfToWmfBitsFlagsNoXORClip = 0x00000004
    '  };
    '----^--- Syntax error: 'identifier' expected

#End Region

#Region "My Constants"

    ' Not used in this application.  Descriptions can be found with documentation
    ' of Windows GDI function SetMapMode
    Private Const MM_TEXT As Integer = 1
    Private Const MM_LOMETRIC As Integer = 2
    Private Const MM_HIMETRIC As Integer = 3
    Private Const MM_LOENGLISH As Integer = 4
    Private Const MM_HIENGLISH As Integer = 5
    Private Const MM_TWIPS As Integer = 6

    ' Ensures that the metafile maintains a 1:1 aspect ratio
    Private Const MM_ISOTROPIC As Integer = 7

    ' Allows the x-coordinates and y-coordinates of the metafile to be adjusted
    ' independently
    Private Const MM_ANISOTROPIC As Integer = 8

    ' Represents an unknown font family
    Private Const FF_UNKNOWN As String = "UNKNOWN"

    ' The number of hundredths of millimeters (0.01 mm) in an inch
    ' For more information, see GetImagePrefix() method.
    Private Const HMM_PER_INCH As Integer = 2540

    ' The number of twips in an inch
    ' For more information, see GetImagePrefix() method.
    Private Const TWIPS_PER_INCH As Integer = 1440

#End Region

#Region "My Privates"

    ' The default text color
    Private textColor As rtfColor

    ' The default text background color
    Private highlightColor As rtfColor

    ' Dictionary that maps color enums to RTF color codes
    Private rtfColor As HybridDictionary

    ' Dictionary that mapas Framework font families to RTF font families
    Private rtfFontFamily As HybridDictionary

    ' The horizontal resolution at which the control is being displayed
    Private xDpi As Single

    ' The vertical resolution at which the control is being displayed
    Private yDpi As Single

#End Region

#Region "Elements required to create an RTF document"

    ' RTF HEADER
    '		 * ----------
    '		 * 
    '		 * \rtf[N]		- For text to be considered to be RTF, it must be enclosed in this tag.
    '		 *				  rtf1 is used because the RichTextBox conforms to RTF Specification
    '		 *				  version 1.
    '		 * \ansi		- The character set.
    '		 * \ansicpg[N]	- Specifies that unicode characters might be embedded. ansicpg1252
    '		 *				  is the default used by Windows.
    '		 * \deff[N]		- The default font. \deff0 means the default font is the first font
    '		 *				  found.
    '		 * \deflang[N]	- The default language. \deflang1033 specifies US English.
    '		 * 
    Private Const RTF_HEADER As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033"

    ' RTF DOCUMENT AREA
    '		 * -----------------
    '		 * 
    '		 * \viewkind[N]	- The type of view or zoom level.  \viewkind4 specifies normal view.
    '		 * \uc[N]		- The number of bytes corresponding to a Unicode character.
    '		 * \pard		- Resets to default paragraph properties
    '		 * \cf[N]		- Foreground color.  \cf1 refers to the color at index 1 in
    '		 *				  the color table
    '		 * \f[N]		- Font number. \f0 refers to the font at index 0 in the font
    '		 *				  table.
    '		 * \fs[N]		- Font size in half-points.
    '		 * 
    Private Const RTF_DOCUMENT_PRE As String = "\viewkind4\uc1\pard\cf1\f0\fs20"
    Private Const RTF_DOCUMENT_POST As String = "\cf0\fs17}"
    Private RTF_IMAGE_POST As String = "}"

#End Region


#Region "Insert Image"


    '/ <summary>
    '/ Inserts an image into the RichTextBox.  The image is wrapped in a Windows
    '/ Format Metafile, because although Microsoft discourages the use of a WMF,
    '/ the RichTextBox (and even MS Word), wraps an image in a WMF before inserting
    '/ the image into a document.  The WMF is attached in HEX format (a string of
    '/ HEX numbers).
    '/ 
    '/ The RTF Specification v1.6 says that you should be able to insert bitmaps,
    '/ .jpegs, .gifs, .pngs, and Enhanced Metafiles (.emf) directly into an RTF
    '/ document without the WMF wrapper. This works fine with MS Word,
    '/ however, when you don't wrap images in a WMF, WordPad and
    '/ RichTextBoxes simply ignore them.  Both use the riched20.dll or msfted.dll.
    '/ </summary>
    '/ <remarks>
    '/ NOTE: The image is inserted wherever the caret is at the time of the call,
    '/ and if any text is selected, that text is replaced.
    '/ </remarks>
    '/ <param name="_image"></param>
    Public Sub InsertImage(ByVal _image As Image, ByVal pPanel As Object)

        Dim PanSegment As Integer = 1
        If Not pPanel Is Nothing Then 
            pPanel.Maximum = 9
            pPanel.Minimum = 0
            pPanel.Value = 0
        End If

        Dim _rtf As New StringBuilder()

        ' Append the RTF header
        _rtf.Append(RTF_HEADER)

        If Not pPanel Is Nothing Then pPanel.Increment(PanSegment) 

        ' Create the font table using the RichTextBox's current font and append
        ' it to the RTF string
        _rtf.Append(GetFontTable(Me.Font))

        If Not pPanel Is Nothing Then pPanel.Increment(PanSegment) 

        ' Create the image control string and append it to the RTF string
        _rtf.Append(GetImagePrefix(_image))

        If Not pPanel Is Nothing Then pPanel.Increment(PanSegment) 

        ' Create the Windows Metafile and append its bytes in HEX format
        _rtf.Append(GetRtfImage(_image))

        If Not pPanel Is Nothing Then pPanel.Increment(PanSegment) 

        ' Close the RTF image control string
        _rtf.Append(RTF_IMAGE_POST)

        If Not pPanel Is Nothing Then pPanel.Increment(PanSegment) 

        
        'Me.SelectedRtf = _rtf.ToString()
        'catering for undo!
        Dim lbooDonePaste As Boolean = False 
        Try
            Dim KeptData As New DataObject()
            KeptData = Clipboard.GetDataObject()
            If Not pPanel Is Nothing Then pPanel.Increment(PanSegment) 

            Dim ImgData As DataObject = New DataObject(DataFormats.Rtf, _rtf.ToString)
            Clipboard.SetDataObject(ImgData, False)
            If Not pPanel Is Nothing Then pPanel.Increment(PanSegment) 

            Me.Paste()
            lbooDonePaste = True 
            If Not pPanel Is Nothing Then pPanel.Increment(PanSegment) 

            'this cater for the error which pastes then throws and error and adds rtf so
            'you get two graphics instead of one!
            Clipboard.SetDataObject(New DataObject()) 

            Clipboard.SetDataObject(KeptData)
        Catch
            If lbooDonePaste = False Then 
                Me.SelectedRtf = _rtf.ToString()
            End If 
        End Try
        

        'String spareData = editBox.SelectedRtf;
        'DataObject newData = new DataObject(DataFormats.Rtf, spareData);
        'Clipboard.SetDataObject(newData, true);

        If Not pPanel Is Nothing Then pPanel.Value = 0

    End Sub 'InsertImage


    '/ <summary>
    '/ Creates the RTF control string that describes the image being inserted.
    '/ This description (in this case) specifies that the image is an
    '/ MM_ANISOTROPIC metafile, meaning that both X and Y axes can be scaled
    '/ independently.  The control string also gives the images current dimensions,
    '/ and its target dimensions, so if you want to control the size of the
    '/ image being inserted, this would be the place to do it. The prefix should
    '/ have the form ...
    '/ 
    '/ {\pict\wmetafile8\picw[A]\pich[B]\picwgoal[C]\pichgoal[D]
    '/ 
    '/ where ...
    '/ 
    '/ A	= current width of the metafile in hundredths of millimeters (0.01mm)
    '/		= Image Width in Inches * Number of (0.01mm) per inch
    '/		= (Image Width in Pixels / Graphics Context's Horizontal Resolution) * 2540
    '/		= (Image Width in Pixels / Graphics.DpiX) * 2540
    '/ 
    '/ B	= current height of the metafile in hundredths of millimeters (0.01mm)
    '/		= Image Height in Inches * Number of (0.01mm) per inch
    '/		= (Image Height in Pixels / Graphics Context's Vertical Resolution) * 2540
    '/		= (Image Height in Pixels / Graphics.DpiX) * 2540
    '/ 
    '/ C	= target width of the metafile in twips
    '/		= Image Width in Inches * Number of twips per inch
    '/		= (Image Width in Pixels / Graphics Context's Horizontal Resolution) * 1440
    '/		= (Image Width in Pixels / Graphics.DpiX) * 1440
    '/ 
    '/ D	= target height of the metafile in twips
    '/		= Image Height in Inches * Number of twips per inch
    '/		= (Image Height in Pixels / Graphics Context's Horizontal Resolution) * 1440
    '/		= (Image Height in Pixels / Graphics.DpiX) * 1440
    '/	
    '/ </summary>
    '/ <remarks>
    '/ The Graphics Context's resolution is simply the current resolution at which
    '/ windows is being displayed.  Normally it's 96 dpi, but instead of assuming
    '/ I just added the code.
    '/ 
    '/ According to Ken Howe at pbdr.com, "Twips are screen-independent units
    '/ used to ensure that the placement and proportion of screen elements in
    '/ your screen application are the same on all display systems."
    '/ 
    '/ Units Used
    '/ ----------
    '/ 1 Twip = 1/20 Point
    '/ 1 Point = 1/72 Inch
    '/ 1 Twip = 1/1440 Inch
    '/ 
    '/ 1 Inch = 2.54 cm
    '/ 1 Inch = 25.4 mm
    '/ 1 Inch = 2540 (0.01)mm
    '/ </remarks>
    '/ <param name="_image"></param>
    '/ <returns></returns>
    Private Function GetImagePrefix(ByVal _image As Image) As String



        ' Get the horizontal and vertical resolutions at which the object is
        ' being displayed
        Dim _graphics As Graphics = Me.CreateGraphics()
        Try
            xDpi = _graphics.DpiX
            yDpi = _graphics.DpiY
        Finally
            _graphics.Dispose()
        End Try

        Dim _rtf As New StringBuilder()

        ' Calculate the current width of the image in (0.01)mm
        Dim picw As Integer = Microsoft.VisualBasic.Fix(Math.Round(_image.Width / xDpi * HMM_PER_INCH))

        ' Calculate the current height of the image in (0.01)mm
        Dim pich As Integer = Microsoft.VisualBasic.Fix(Math.Round(_image.Height / yDpi * HMM_PER_INCH))

        ' Calculate the target width of the image in twips
        Dim picwgoal As Integer = Microsoft.VisualBasic.Fix(Math.Round(_image.Width / xDpi * TWIPS_PER_INCH))

        ' Calculate the target height of the image in twips
        Dim pichgoal As Integer = Microsoft.VisualBasic.Fix(Math.Round(_image.Height / yDpi * TWIPS_PER_INCH))

        ' Append values to RTF string
        _rtf.Append("{\pict\wmetafile8")
        _rtf.Append("\picw")
        _rtf.Append(picw)
        _rtf.Append("\pich")
        _rtf.Append(pich)
        _rtf.Append("\picwgoal")
        _rtf.Append(picwgoal)
        _rtf.Append("\pichgoal")
        _rtf.Append(pichgoal)
        _rtf.Append(" ")

        Return _rtf.ToString()
    End Function 'GetImagePrefix


    '/ <summary>
    '/ Use the EmfToWmfBits function in the GDI+ specification to convert a 
    '/ Enhanced Metafile to a Windows Metafile
    '/ </summary>
    '/ <param name="_hEmf">
    '/ A handle to the Enhanced Metafile to be converted
    '/ </param>
    '/ <param name="_bufferSize">
    '/ The size of the buffer used to store the Windows Metafile bits returned
    '/ </param>
    '/ <param name="_buffer">
    '/ An array of bytes used to hold the Windows Metafile bits returned
    '/ </param>
    '/ <param name="_mappingMode">
    '/ The mapping mode of the image.  This control uses MM_ANISOTROPIC.
    '/ </param>
    '/ <param name="_flags">
    '/ Flags used to specify the format of the Windows Metafile returned
    '/ </param>
    <DllImportAttribute("gdiplus.dll")> _
    Private Shared Function GdipEmfToWmfBits(ByVal _hEmf As IntPtr, ByVal _bufferSize As System.UInt32, ByVal _buffer() As Byte, ByVal _mappingMode As Integer, ByVal _flags As EmfToWmfBitsFlags) As System.UInt32

    End Function
    Private Function GetRtfImage(ByVal _image As Image) As String

        Dim _rtf As StringBuilder = Nothing

        ' Used to store the enhanced metafile
        Dim _stream As MemoryStream = Nothing

        ' Used to create the metafile and draw the image
        Dim _graphics As Graphics = Nothing

        ' The enhanced metafile
        Dim _metaFile As Metafile = Nothing

        ' Handle to the device context used to create the metafile
        Dim _hdc As IntPtr

        Try
            _rtf = New StringBuilder()
            _stream = New MemoryStream()

            Try '
                _graphics = Me.CreateGraphics()

                ' Get the device context from the graphics context
                _hdc = _graphics.GetHdc()

                ' Create a new Enhanced Metafile from the device context
                _metaFile = New Metafile(_stream, _hdc)

                ' Release the device context
                _graphics.ReleaseHdc(_hdc)
            Finally
                _graphics.Dispose()
            End Try

            ' Get a graphics context from the Enhanced Metafile
            Try '
                _graphics = Graphics.FromImage(_metaFile)

                ' Draw the image on the Enhanced Metafile
                _graphics.DrawImage(_image, New Rectangle(0, 0, _image.Width, _image.Height))
            Finally
                _graphics.Dispose()
            End Try

            ' Get the handle of the Enhanced Metafile
            Dim _hEmf As IntPtr = _metaFile.GetHenhmetafile()

            ' A call to EmfToWmfBits with a null buffer return the size of the
            ' buffer need to store the WMF bits.  Use this to get the buffer
            ' size.
            'Dim _bufferSize As System.UInt32 = GdipEmfToWmfBits(_hEmf, 0, Nothing, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault) 'ToDo: Unsigned Integers not supported
            Dim x As UInt32 = System.Convert.ToUInt32(0)

            Dim _bufferSize As System.UInt32 = GdipEmfToWmfBits(_hEmf, x, Nothing, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault) 'ToDo: Unsigned Integers not supported

            ' Create an array to hold the bits
            'Dim _buffer(_bufferSize) As Byte

            'Dim x2 As Integer = System.Convert.ToInt16(_bufferSize)
            'Dim _buffer(x2) As Byte 

            Dim x2 As Integer = System.Convert.ToInt32(_bufferSize) 

            Dim _buffer(x2) As Byte 

            ' A call to EmfToWmfBits with a valid buffer copies the bits into the
            ' buffer an returns the number of bits in the WMF.  
            Dim _convertedSize As System.UInt32 = GdipEmfToWmfBits(_hEmf, _bufferSize, _buffer, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault) 'ToDo: Unsigned Integers not supported

            ' Append the bits to the RTF string
            Dim i As Integer
            For i = 0 To _buffer.Length - 1
                _rtf.Append(String.Format("{0:X2}", _buffer(i)))
            Next i

            Return _rtf.ToString()
        Finally
            If Not (_graphics Is Nothing) Then
                _graphics.Dispose()
            End If
            If Not (_metaFile Is Nothing) Then
                _metaFile.Dispose()
            End If
            If Not (_stream Is Nothing) Then
                _stream.Close()
            End If
        End Try
    End Function 'GetRtfImage 
#End Region

#Region "RTF Helpers"


    '/ <summary>
    '/ Creates a font table from a font object.  When an Insert or Append 
    '/ operation is performed a font is either specified or the default font
    '/ is used.  In any case, on any Insert or Append, only one font is used,
    '/ thus the font table will always contain a single font.  The font table
    '/ should have the form ...
    '/ 
    '/ {\fonttbl{\f0\[FAMILY]\fcharset0 [FONT_NAME];}
    '/ </summary>
    '/ <param name="_font"></param>
    '/ <returns></returns>
    Private Function GetFontTable(ByVal _font As Font) As String


        Const Unknown As String = "\fnil"
        Const Roman As String = "\froman"
        Const Swiss As String = "\fswiss"
        Const Modern As String = "\fmodern"
        Const Script As String = "\fscript"
        Const Decor As String = "\fdecor"
        Const Technical As String = "\ftech"
        Const BiDirect As String = "\fbidi"


        ' Initialize the dictionary mapping default Framework font families to
        ' RTF font families
        rtfFontFamily = New HybridDictionary()
        rtfFontFamily.Add(FontFamily.GenericMonospace.Name, Modern)
        rtfFontFamily.Add(FontFamily.GenericSansSerif, Swiss)
        rtfFontFamily.Add(FontFamily.GenericSerif, Roman)
        rtfFontFamily.Add(FF_UNKNOWN, Unknown)

        Dim _fontTable As New StringBuilder()

        ' Append table control string
        _fontTable.Append("{\fonttbl{\f0")
        _fontTable.Append("\")

        ' If the font's family corresponds to an RTF family, append the
        ' RTF family name, else, append the RTF for unknown font family.
        If rtfFontFamily.Contains(_font.FontFamily.Name) Then
            _fontTable.Append(rtfFontFamily(_font.FontFamily.Name))
        Else
            _fontTable.Append(rtfFontFamily(FF_UNKNOWN))
        End If
        ' \fcharset specifies the character set of a font in the font table.
        ' 0 is for ANSI.
        _fontTable.Append("\fcharset0 ")

        ' Append the name of the font
        _fontTable.Append(_font.Name)

        ' Close control string
        _fontTable.Append(";}}")

        Return _fontTable.ToString()
    End Function 'GetFontTable


    '/ <summary>
    '/ Creates a font table from the RtfColor structure.  When an Insert or Append
    '/ operation is performed, _textColor and _backColor are either specified
    '/ or the default is used.  In any case, on any Insert or Append, only three
    '/ colors are used.  The default color of the RichTextBox (signified by a
    '/ semicolon (;) without a definition), is always the first color (index 0) in
    '/ the color table.  The second color is always the text color, and the third
    '/ is always the highlight color (color behind the text).  The color table
    '/ should have the form ...
    '/ 
    '/ {\colortbl ;[TEXT_COLOR];[HIGHLIGHT_COLOR];}
    '/ 
    '/ </summary>
    '/ <param name="_textColor"></param>
    '/ <param name="_backColor"></param>
    '/ <returns></returns>
    Private Function GetColorTable(ByVal _textColor As rtfColor, ByVal _backColor As rtfColor) As String

        Dim _colorTable As New StringBuilder()

        ' Append color table control string and default font (;)
        _colorTable.Append("{\colortbl ;")

        ' Append the text color
        _colorTable.Append(rtfColor(_textColor))
        _colorTable.Append(";")

        ' Append the highlight color
        _colorTable.Append(rtfColor(_backColor))
        _colorTable.Append(";}\n")

        Return _colorTable.ToString()
    End Function 'GetColorTable
#End Region

    
    '#Region "XP RichtextBox"

    '    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    '    Public Shared Function LoadLibrary(ByVal path As String) As IntPtr
    '    End Function

    '    Private Shared moduleHandle As IntPtr

    '    Protected Overrides ReadOnly Property CreateParams() As _
    '        System.Windows.Forms.CreateParams

    '        Get
    '            If IntPtr.op_Equality(moduleHandle, IntPtr.Zero) Then
    '                moduleHandle = LoadLibrary("msftedit.dll")
    '                If CType(moduleHandle.ToString, Integer) < &H20 Then
    '                    'removed this line, so it will use normal RTB with none XP OS's
    '                    'Throw New Win32Exception(Marshal.GetLastWin32Error(), "Could not load Msftedit.dll")

    '                End If
    '            End If

    '            Dim _CreateParams As CreateParams = MyBase.CreateParams
    '            _CreateParams.ClassName = "RichEdit50W"

    '            If Me.Multiline = True Then
    '                If ((Me.ScrollBars + RichTextBoxScrollBars.Horizontal) <> RichTextBoxScrollBars.None) _
    '                    AndAlso MyBase.WordWrap = False Then

    '                    _CreateParams.Style = _CreateParams.Style Or &H100000

    '                    If (Me.ScrollBars + CType(&H10, RichTextBoxScrollBars)) <> RichTextBoxScrollBars.None Then
    '                        _CreateParams.Style = _CreateParams.Style Or &H2000
    '                    End If
    '                End If
    '            End If

    '            If (Me.ScrollBars + RichTextBoxScrollBars.Vertical) <> RichTextBoxScrollBars.None Then

    '                _CreateParams.Style = _CreateParams.Style Or &H200000

    '                If (Me.ScrollBars + CType(&H10, RichTextBoxScrollBars)) <> RichTextBoxScrollBars.None Then
    '                    _CreateParams.Style = _CreateParams.Style Or &H2000
    '                End If
    '            End If

    '            If BorderStyle.FixedSingle = MyBase.BorderStyle AndAlso (_CreateParams.Style + &H800000) <> 0 Then

    '                _CreateParams.Style = _CreateParams.Style And -8388609
    '                _CreateParams.ExStyle = _CreateParams.ExStyle Or &H200

    '            End If

    '            Return _CreateParams

    '        End Get
    '    End Property

    '#End Region
    

End Class

Public Module RTBFuncs
    'added 

    '--- Selection BackColor ---
    ' Win API declaration, Sends a Character format message.
    <DllImport("user32.dll", EntryPoint:="SendMessage", CharSet:=CharSet.Auto)> _
    Private Function SendCharFmtMsg(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByRef cf2 As CHARFORMAT2) As Integer
    End Function

    Public Enum CHARFORMATRANGE
        FormatAll = 4
        FormatSelection = 1
        FormatWord = 3
    End Enum 'CHARFORMATRANGE
    ' Variables
    Private Const WM_USER As Integer = &H400
    Private Const CFM_BACKCOLOR As Integer = &H4000000
    Private Const EM_SETCHARFORMAT As Integer = WM_USER + 68

    ' Character Format Structure.
    <StructLayout(LayoutKind.Sequential, Pack:=4, CharSet:=CharSet.Auto)> _
    Private Structure CHARFORMAT2
        Dim cbSize As Integer
        Dim dwMask As Integer
        Dim dwEffects As Integer
        Dim yHeight As Integer
        Dim yOffset As Integer
        Dim crTextColor As Integer
        Dim bCharSet As Byte
        Dim bPitchAndFamily As Byte
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)> _
        Dim szFaceName As String
        Dim wWeight As Short
        Dim sSpacing As Short
        Dim crBackColor As Integer
        Dim lcid As Integer
        Dim dwReserved As Integer
        Dim sStyle As Short
        Dim wKerning As Short
        Dim bUnderlineType As Byte
        Dim bAnimation As Byte
        Dim bRevAuthor As Byte
        Dim bReserved1 As Byte
    End Structure 'CHARFORMAT2

    Public Sub SelectionBackColor(ByVal sourceRtb As ExRichTextBox, ByVal backColor As Color, ByVal CharFormat As CHARFORMATRANGE, ByVal DestRTB As ExRichTextBox) ', ByVal rtbHandle As IntPtr)
        
        Try 

            Dim DestSelLen As Integer = DestRTB.SelectionLength
            Dim DestSelStart As Integer = DestRTB.SelectionStart 

            ''Dim SavedSelection As String = Me.SelectedRtf
            sourceRtb.Rtf = ""

            sourceRtb.SelectedRtf = DestRTB.SelectedRtf
            sourceRtb.SelectionStart = 0
            sourceRtb.SelectionLength = DestSelLen 'Me.Rtf.Length

            Dim lR As Integer
            Dim tCF As New CHARFORMAT2()

            tCF.dwMask = CFM_BACKCOLOR

            tCF.crBackColor = ColorTranslator.ToWin32(backColor)
            tCF.cbSize = Marshal.SizeOf(tCF)
            'lR = SendCharFmtMsg(rtbHandle, EM_SETCHARFORMAT, CharFormat, tCF)
            lR = SendCharFmtMsg(sourceRtb.Handle, EM_SETCHARFORMAT, CharFormat, tCF)

            ''Dim AlteredSelection As String = Me.SelectedRtf
            ''Me.SelectedRtf = SavedSelection


            'catering for undo!
            Try
                Dim KeptData As New DataObject()
                KeptData = Clipboard.GetDataObject()
                Dim SelectionData As DataObject = New DataObject(DataFormats.Rtf, sourceRtb.SelectedRtf)
                Clipboard.SetDataObject(SelectionData, False)
                'Me.SelectedRtf = ""
                ''If Me.SelectionLength <> SelLen Then Me.SelectionLength = SelLen
                ''If Me.SelectionStart <> SelStart Then Me.SelectionStart = SelStart

                'Me.Paste()
                DestRTB.Paste()
                Clipboard.SetDataObject(New DataObject()) 

                Clipboard.SetDataObject(KeptData)
            Catch
                'Me.SelectedRtf = AlteredSelection
            End Try
            'Console.WriteLine("2 " & DestRTB.CanUndo)

            ''DestRTB.SelectionStart = DestSelStart 
            ''Console.WriteLine("3 " & DestRTB.CanUndo)
            ''DestRTB.SelectionLength = DestSelLen 
            ''Console.WriteLine("4 " & DestRTB.CanUndo)
            'Microsoft.VisualBasic.MsgBox("Pos 1")
            Try 
                'Microsoft.VisualBasic.MsgBox("Pos 2")
                SelectRange(DestRTB, DestSelStart, DestSelLen)  
                'Microsoft.VisualBasic.MsgBox("Pos 3")
            Catch 
                'Microsoft.VisualBasic.MsgBox("Pos 4")
                
                Try
                    'Microsoft.VisualBasic.MsgBox("Pos 5")
                    DestRTB.SelectionStart = DestSelStart
                    'Microsoft.VisualBasic.MsgBox("Pos 6")
                    DestRTB.SelectionLength = DestSelLen
                    'Microsoft.VisualBasic.MsgBox("Pos 7")
                Catch
                    '
                    'Microsoft.VisualBasic.MsgBox("Pos 8")
                End Try
                
            End Try 
            'Microsoft.VisualBasic.MsgBox("Pos 9")
            sourceRtb.Rtf = Nothing
            'Microsoft.VisualBasic.MsgBox("Pos 10")
            'Console.WriteLine("5 " & DestRTB.CanUndo)
        Catch 
            'Microsoft.VisualBasic.MsgBox("Pos 11")
            sourceRtb.Rtf = Nothing 
            'Microsoft.VisualBasic.MsgBox("Pos 12")
        End Try 
    End Sub 'SelectionBackColor
    '--- Selection BackColor
    Private EM_CHARFROMPOS As Integer = &HD7
    Private Structure POINTL
        Dim x As Integer
        Dim y As Integer


        Sub New(ByVal pt As Point)
            x = pt.X
            y = pt.Y
        End Sub 'New

        Sub New(ByVal x0 As Integer, ByVal y0 As Integer)
            x = x0
            y = y0
        End Sub 'New
    End Structure
    <DllImport("User32.dll", EntryPoint:="SendMessage", CharSet:=CharSet.Auto)> _
    Private Function SendMessageRefPoint(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As Integer, ByRef point As POINTL) As Integer
    End Function
    Private Const EM_SETSEL As Integer = &HB1
    'Const EM_SETSEL = &HB1
    <DllImport("user32.dll", EntryPoint:="SendMessage", CharSet:=CharSet.Auto)> _
    Private Function SendMessage(ByVal hwnd As IntPtr, ByVal message As Integer, ByVal wparam As Integer, ByVal lparam As Integer) As Integer

    End Function
    <DllImport("user32.dll")> _
       Private Function SendMessage(ByVal hwnd As IntPtr, ByVal msg As Int32, ByRef wParam As GETTEXTEX, ByVal lParam As StringBuilder) As Long
    End Function
    ''Private WM_USER As Integer = &H400 'declared above
    Private EM_GETTEXTEX As Integer = (WM_USER + 94)
    Private GT_DEFAULT As Integer = 1
    Private Structure GETTEXTEX
        Dim cb As Int32
        Dim flags As Int32
        Dim codepage As UInt32
        Dim lpDefaultChar As IntPtr
        Dim lpUsedDefChar As IntPtr
    End Structure 'GETTEXTEX
    Public Function GetText(ByVal rtb As ExRichTextBox) As String

        Dim LPGETTEXTEX As New GETTEXTEX()
        LPGETTEXTEX.cb = 1024
        LPGETTEXTEX.flags = GT_DEFAULT
        LPGETTEXTEX.codepage = System.UInt32.Parse(0) 'CP_ACP for default
        Dim result As New StringBuilder(LPGETTEXTEX.cb)

        'SendMessage(richTextBox1.Handle, EM_GETTEXTEX, ref LPGETTEXTEX, result)   
        SendMessage(rtb.Handle, EM_GETTEXTEX, LPGETTEXTEX, result)

        Try
            Return result.ToString()
        Catch
            Return ""
        End Try

    End Function
    Public Function GetTextLen(ByVal rtb As ExRichTextBox) As Integer

        Dim LPGETTEXTEX As New GETTEXTEX()
        LPGETTEXTEX.cb = 1024
        LPGETTEXTEX.flags = GT_DEFAULT
        LPGETTEXTEX.codepage = System.UInt32.Parse(0) 'CP_ACP for default
        Dim result As New StringBuilder(LPGETTEXTEX.cb)

        'SendMessage(richTextBox1.Handle, EM_GETTEXTEX, ref LPGETTEXTEX, result)   
        'Console.WriteLine("A")
        SendMessage(rtb.Handle, EM_GETTEXTEX, LPGETTEXTEX, result)
        'Console.WriteLine("B")
        Try
            'Console.WriteLine(result.ToString())
            'Console.WriteLine("C")
            Return result.ToString().Length
            'Console.WriteLine("D")
        Catch
            Return 0
        End Try

    End Function
    Public Sub SelectRange(ByVal rtb As ExRichTextBox, ByVal SelStart As Integer, ByVal SelLen As Integer)

        SendMessage(rtb.Handle, EM_SETSEL, SelStart, SelStart + SelLen)

    End Sub
    Public Function GetTextPositionFromPoint(ByVal rtb As ExRichTextBox, ByRef pt As Point) As Integer
        'added 
        Try
            Dim pointStruct As New POINTL(pt.X, pt.Y)
            Return SendMessageRefPoint(rtb.Handle, System.UInt32.Parse(EM_CHARFROMPOS), 0, pointStruct)
        Catch
            Return rtb.GetCharIndexFromPosition(pt)
        End Try

    End Function

    'not used anymore --- 
    ' '
    ''Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal _
    ''hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
    ''ByVal lParam As Integer) As Integer

    ''Private Const EM_SETTARGETDEVICE As Long = WM_USER + 72
    ''Public Sub SetWordWrap(ByVal sourceRtb As ExRichTextBox, ByVal State As Boolean)
    ''    Dim lintParam As Integer

    ''    If State = True Then
    ''        lintParam = 0
    ''    Else
    ''        lintParam = 1
    ''    End If

    ''    SendMessage(sourceRtb.Handle, EM_SETTARGETDEVICE, 0, State)

    ''End Sub
    ' '

End Module