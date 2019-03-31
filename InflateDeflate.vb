'Imports System.IO
'Imports System.Text
'Imports ICSharpCode.SharpZipLib.Zip.Compression
'Imports ICSharpCode.SharpZipLib.Zip.Compression.Streams

'Public Class InflateDeflate
'    'added 
'    Const CompressLevel As Integer = 5  'does work, but slow!! '9'6'3  ' 1-4 = bug, doesn't work!
'    'Public DeflateStart As Date
'    'Public InflateStart As Date
'    Public Function Deflate(ByVal strUncompressed As String, ByRef pByteLength As Integer) As String

'        'DeflateStart = Date.Now
'        Dim ByteConverter As New UnicodeEncoding()

'        Dim Source() As Byte = ByteConverter.GetBytes(strUncompressed)

'        Dim ms As New MemoryStream()
'        Dim deflater As New Deflater(CompressLevel)
'        Dim outStream As New DeflaterOutputStream(ms, deflater)

'        pByteLength = Source.Length
'        outStream.Write(Source, 0, Source.Length)
'        outStream.Flush()
'        outStream.Finish()

'        Return ByteConverter.GetString(ms.ToArray)


'    End Function
'    Public Function Inflate(ByVal strCompressed As String, ByRef pByteLength As Integer) As String

'        'InflateStart = Date.Now

'        Dim RecLen As Integer = 50000000
'        Dim ByteConverter As New UnicodeEncoding()
'        Dim CompressedMS As New MemoryStream(ByteConverter.GetBytes(strCompressed))
'        Dim buf(9999999) As Byte

'        CompressedMS.Seek(0, SeekOrigin.Begin)
'        Dim inStream As New InflaterInputStream(CompressedMS)
'        Dim buf2(pByteLength) As Byte

'        Dim pos As Integer = 0
'        While True
'            Dim numRead As Integer
'             
'            Try
'                numRead = inStream.Read(buf2, pos, buf2.GetUpperBound(0))
'            Catch ex As Exception
'                Microsoft.VisualBasic.MsgBox("INFLATE: " & ex.Message)
'            End Try
'             
'            If numRead <= 0 Then
'                Exit While
'            End If
'            pos += numRead
'            If pos + 1 > pByteLength Then
'                Exit While
'            End If

'        End While

'        Return ByteConverter.GetString(buf2)

'    End Function

'    Private dotnet As Integer = 1

'    Public Function Deflate(ByVal strUncompressed As String, ByRef pByteLength As Integer) As String

'        'DeflateStart = Date.Now
'        Dim ByteConverter As New UnicodeEncoding()

'        Dim Source() As Byte = ByteConverter.GetBytes(strUncompressed)

'        Dim ms As New MemoryStream()
'        Dim deflater As New Deflater(CompressLevel)
'        Dim outStream As New DeflaterOutputStream(ms, deflater)

'        pByteLength = Source.Length
'        outStream.Write(Source, 0, Source.Length)
'        outStream.Flush()
'        outStream.Finish()

'        If dotnet = 1 Then
'            Return ByteConverter.GetString(ms.ToArray)
'        Else
'            Return Convert.ToBase64String(ms.ToArray)
'        End If


'    End Function
'    Public Function Inflate(ByVal strCompressed As String, ByRef pByteLength As Integer) As String

'        'InflateStart = Date.Now

'        Dim tMo As Byte() = Convert.FromBase64String(strCompressed)
'        Dim ByteConverter As New UnicodeEncoding()
'        Dim CompressedMS As MemoryStream

'        If dotnet >= 2 Then
'            CompressedMS = New MemoryStream()

'            Dim i As Integer
'            For i = 0 To tMo.Length - 1
'                CompressedMS.WriteByte(tMo(i))
'            Next
'        Else
'            CompressedMS = New MemoryStream(ByteConverter.GetBytes(strCompressed))
'        End If

'        Dim buf(9999999) As Byte
'        Dim RecLen As Integer = 50000000

'        CompressedMS.Seek(0, SeekOrigin.Begin)

'        Dim inStream As New InflaterInputStream(CompressedMS)

'        Dim buf2(pByteLength) As Byte

'        Dim pos As Integer = 0
'        While True
'            Dim numRead As Integer
'            Try
'                numRead = inStream.Read(buf2, pos, buf2.Length)
'            Catch ex As Exception
'                Microsoft.VisualBasic.MsgBox(ex.Message)
'            End Try

'            If numRead <= 0 Then
'                Exit While
'            End If
'            pos += numRead
'            If pos + 1 > pByteLength Then
'                Exit While
'            End If
'        End While

'        Return ByteConverter.GetString(buf2)

'    End Function

'    Public Sub New()
'        dotnet = Environment.Version.Major
'    End Sub

'End Class
Imports System.IO
Imports System.Text
Imports ICSharpCode.SharpZipLib.Zip.Compression
Imports ICSharpCode.SharpZipLib.Zip.Compression.Streams

Public Class InflateDeflate
    'added 
    Const CompressLevel As Integer = 5  'does work, but slow!! '9'6'3  ' 1-4 = bug, doesn't work!
    Private newcode As Integer = 1

    Public Function Deflate(ByVal strUncompressed As String, ByRef pByteLength As Integer) As String

        'DeflateStart = Date.Now
        Dim ByteConverter As New UnicodeEncoding()

        Dim Source() As Byte = ByteConverter.GetBytes(strUncompressed)

        Dim ms As New MemoryStream()
        Dim deflater As New Deflater(CompressLevel)
        Dim outStream As New DeflaterOutputStream(ms, deflater)

        pByteLength = Source.Length
        outStream.Write(Source, 0, Source.Length)
        outStream.Flush()
        outStream.Finish()

        ' If dotnet = 1 Then
        '  Return ByteConverter.GetString(ms.ToArray)
        ' Else
        Return Convert.ToBase64String(ms.ToArray)
        '  End If


    End Function
    Public Function Inflate(ByVal strCompressed As String, ByRef pByteLength As Integer) As String

        'InflateStart = Date.Now

        Dim tMo As Byte()

        Try 
            tMo = Convert.FromBase64String(strCompressed)
        Catch 
            Return InflateOLD(strCompressed, pByteLength) 
            Exit Function 
        End Try 

        Dim ByteConverter As New UnicodeEncoding()
        Dim CompressedMS As MemoryStream

        If newcode >= 2 Then
            CompressedMS = New MemoryStream()

            Dim i As Integer
            For i = 0 To tMo.Length - 1
                CompressedMS.WriteByte(tMo(i))
            Next
        Else
            CompressedMS = New MemoryStream(ByteConverter.GetBytes(strCompressed))
        End If

        Dim buf(9999999) As Byte
        Dim RecLen As Integer = 50000000

        CompressedMS.Seek(0, SeekOrigin.Begin)

        Dim inStream As New InflaterInputStream(CompressedMS)

        Dim buf2(pByteLength) As Byte

        Dim pos As Integer = 0
        While True
            Dim numRead As Integer
            Try
                numRead = inStream.Read(buf2, pos, buf2.Length)
            Catch ex As Exception
                newcode = 2
                Return Inflate(strCompressed, pByteLength)
                Exit Function
            End Try

            If numRead <= 0 Then
                Exit While
            End If
            pos += numRead
            If pos + 1 > pByteLength Then
                Exit While
            End If
        End While

        Return ByteConverter.GetString(buf2)

    End Function
    Private Function InflateOLD(ByVal strCompressed As String, ByRef pByteLength As Integer) As String

        'InflateStart = Date.Now

        Dim RecLen As Integer = 50000000
        Dim ByteConverter As New UnicodeEncoding()
        Dim CompressedMS As New MemoryStream(ByteConverter.GetBytes(strCompressed))
        Dim buf(9999999) As Byte

        CompressedMS.Seek(0, SeekOrigin.Begin)
        Dim inStream As New InflaterInputStream(CompressedMS)
        Dim buf2(pByteLength) As Byte

        Dim pos As Integer = 0
        While True
            Dim numRead As Integer
             
            Try
                numRead = inStream.Read(buf2, pos, buf2.GetUpperBound(0))
            Catch ex As Exception
                ' Microsoft.VisualBasic.MsgBox("INFLATE: " & ex.Message)
            End Try
             
            If numRead <= 0 Then
                Exit While
            End If
            pos += numRead
            If pos + 1 > pByteLength Then
                Exit While
            End If

        End While

        Return ByteConverter.GetString(buf2)

    End Function
End Class