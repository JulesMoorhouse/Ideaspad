Imports System.IO
Imports ICSharpCode.SharpZipLib.Zip
Imports ICSharpCode.SharpZipLib.Checksums

Imports ICSharpCode.SharpZipLib.GZip
Module zipupdcreate
    Sub Main()
        Main(Environment.GetCommandLineArgs())
    End Sub

    Private Sub Main(ByVal args() As String)
        Dim lstrBaseDir As String
        Dim lstrDestZipFile As String
        Dim lstrProdVerFile As String
        Dim lstrXMLFile As String
        Dim lstrUpSiteURL As String
        Dim lstrUpSitePath As String
        Dim lstrUploadDir As String
        Dim lstrFromVers As String
        If args Is Nothing OrElse args.Length > 9 Then '8 
            Console.WriteLine("ZipUpdCreate: Invalid argurments....")
        Else
            On Error Resume Next

            REM ZipUpdCreate ZipFile-BaseDir DestZipFile ProdVerFile XMLFile
            '"D:\CodeLibrary\SharewareProjs\ZipUpdCreate\bin\ZipUpdCreate.exe" "D:\Build\IPDemo\UpdateToZip\" "ipd.dat" "ideaspad.exe" "ipdemo.xml"
            lstrBaseDir = args(1)
            lstrDestZipFile = args(2)
            lstrProdVerFile = args(3)
            lstrXMLFile = args(4)
            lstrUpSiteURL = args(5)
            lstrUpSitePath = args(6)
            lstrUploadDir = args(7)
            lstrFromVers = args(8) 

            On Error GoTo 0

            'Console.WriteLine("1 " & lstrBaseDir & " " & lstrDestZipFile & " " & lstrProdVerFile & " " & lstrXMLFile)
            'Console.WriteLine("2 " & lstrBaseDir & "Temp\" & lstrProdVerFile)

            'get version number of prog
            Dim lstrSourceFile As FileVersionInfo = FileVersionInfo.GetVersionInfo(lstrBaseDir & "Temp\" & lstrProdVerFile)
            'MsgBox(lstrSourceFile.FileVersion)
            'Console.WriteLine("3 " & lstrSourceFile.FileVersion)

            'create version dir
            On Error Resume Next
            'MkDir("D:\Build\IPDemo\UpdateToZip\" & lstrUploadDir & "\" & lstrSourceFile.FileVersion & "\")
            MkDir(lstrBaseDir & lstrUploadDir & "\" & lstrSourceFile.FileVersion & "\")
            On Error GoTo 0

            'create xml file
            Dim lintFreeFile As Integer
            Dim lstrOutPut As String

            '<VersionConfig>
            '	<AvailableVersion>1.0.0.0</AvailableVersion>	
            '	<DownloadSite>http://www.example.co.uk</DownloadSite>	
            '	<DownloadDir>updates/neptune/2.0.0.0/</DownloadDir>	
            '	<DownloadFile>ipdtest.dat</DownloadFile>	
            '</VersionConfig>

            
            'Dim lstrFromVers As String = "1.0.3.0#1.0.4.0#1.0.5.0#1.0.6.0#"
            Dim lstrFromVersSection As String
            If lstrFromVers <> "" Then
                Dim lintArrInc As Integer
                For lintArrInc = 1 To 20 'lets hope you don't have more than 20 versions :)
                    Dim lstrThisSearch As String = AppBasic.strman.ReturnNthStr(lstrFromVers, lintArrInc, "#")
                    If lstrThisSearch <> "" Then
                        lstrFromVersSection &= "	<FromVer" & lstrThisSearch & ">fv" & lstrThisSearch & ".dat</FromVer" & lstrThisSearch & ">" & Environment.NewLine
                    End If
                Next lintArrInc
            End If
            

            lstrOutPut = "<VersionConfig>" & vbCrLf & _
                "	<AvailableVersion>" & lstrSourceFile.FileVersion & "</AvailableVersion>" & vbCrLf & _
                "	<DownloadSite>" & lstrUpSiteURL & "</DownloadSite>" & vbCrLf & _
                "	<DownloadDir>" & lstrUpSitePath & lstrSourceFile.FileVersion & "/</DownloadDir>" & vbCrLf & _
                "	<DownloadFile>" & lstrDestZipFile & "</DownloadFile>" & vbCrLf & lstrFromVersSection & _
                "</VersionConfig>"

            lintFreeFile = FreeFile()
            FileOpen(lintFreeFile, lstrBaseDir & lstrUploadDir & "\" & lstrXMLFile, OpenMode.Output)
            PrintLine(lintFreeFile, lstrOutPut)
            FileClose(lintFreeFile)

            Dim astrFileNames() As String = Directory.GetFiles(lstrBaseDir & "Temp\")
            Dim objCrc32 As New Crc32()
            Dim strmZipOutputStream As ZipOutputStream

            strmZipOutputStream = New ZipOutputStream(File.Create(lstrBaseDir & lstrUploadDir & "\" & lstrSourceFile.FileVersion & "\" & lstrDestZipFile))
            strmZipOutputStream.SetLevel(6)

            REM Compression Level: 0-9
            REM 0: no(Compression)
            REM 9: maximum compression

            Dim strFile As String

            For Each strFile In astrFileNames
                Dim strmFile As FileStream = File.OpenRead(strFile)
                Dim abyBuffer(strmFile.Length - 1) As Byte

                strmFile.Read(abyBuffer, 0, abyBuffer.Length)

                Dim ThisstrFile As String = Path.GetFileName(strFile)

                'Dim objZipEntry As ZipEntry = New ZipEntry(strFile)
                Dim objZipEntry As ZipEntry = New ZipEntry(ThisstrFile)

                objZipEntry.DateTime = DateTime.Now
                objZipEntry.Size = strmFile.Length
                strmFile.Close()
                objCrc32.Reset()
                objCrc32.Update(abyBuffer)
                objZipEntry.Crc = objCrc32.Value
                strmZipOutputStream.PutNextEntry(objZipEntry)
                strmZipOutputStream.Write(abyBuffer, 0, abyBuffer.Length)

            Next

            strmZipOutputStream.Finish()
            strmZipOutputStream.Close()

            'MessageBox.Show("Operation complete")
            Console.WriteLine("ZipUpdCreate: zipped " & lstrDestZipFile & "...")
            End If
    End Sub

    Private Sub ZipFile(ByVal strFileToZip As String, ByVal strZippedFile As String, ByVal nCompressionLevel As Integer, ByVal nBlockSize As Integer)
        If (Not System.IO.File.Exists(strFileToZip)) Then
            Throw New System.IO.FileNotFoundException("The specified file " + strFileToZip + "could not be found. Zipping aborted.")
        End If

        Dim strmStreamToZip As System.IO.FileStream
        strmStreamToZip = New System.IO.FileStream(strFileToZip, System.IO.FileMode.Open, System.IO.FileAccess.Read)

        Dim strmZipFile As System.IO.FileStream
        strmZipFile = System.IO.File.Create(strZippedFile)

        Dim strmZipStream As ZipOutputStream
        strmZipStream = New ZipOutputStream(strmZipFile)

        Dim myZipEntry As ZipEntry
        myZipEntry = New ZipEntry("ZippedFile")
        strmZipStream.PutNextEntry(myZipEntry)
        strmZipStream.SetLevel(nCompressionLevel)

        Dim abyBuffer(nBlockSize) As Byte
        Dim nSize As System.Int32
        nSize = strmStreamToZip.Read(abyBuffer, 0, abyBuffer.Length)
        strmZipStream.Write(abyBuffer, 0, nSize)

        Try
            While (nSize < strmStreamToZip.Length)
                Dim nSizeRead As Integer
                nSizeRead = strmStreamToZip.Read(abyBuffer, 0, abyBuffer.Length)
                strmZipStream.Write(abyBuffer, 0, nSizeRead)
                nSize = nSize + nSizeRead
            End While

        Catch Ex As System.Exception
            Throw Ex

        End Try

        strmZipStream.Finish()
        strmZipStream.Close()
        strmStreamToZip.Close()
    End Sub
End Module
