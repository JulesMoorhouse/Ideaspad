Imports System.Xml
Public Class SuffleGenericBookmarks
    Dim mstrBookMarkNameTag As String
    Dim mstrBookMarkRefTag As String
    Dim mstrBookMarkImgIdxTag As String
    Dim mstrBookMarkFileTag As String 
    Enum BookmarkTypes
        Boomarks
        TemplateBookMarks
    End Enum
    Dim mXMLConfigType As InitalXMLConfig.XmlConfigType
    Dim mBookmarkType As BookmarkTypes
    Dim mstrDBID As String
    Public Property BookmarkType() As BookmarkTypes
        Get
            Return mBookmarkType
        End Get
        Set(ByVal Value As BookmarkTypes)
            mBookmarkType = Value
            Select Case mBookmarkType
                Case BookmarkTypes.Boomarks
                    mstrBookMarkNameTag = "BookmarkName-"
                    mstrBookMarkRefTag = "Bookmarks-"
                    mstrBookMarkImgIdxTag = "BookmarkImgIdx-"
                    mstrBookMarkFileTag = "" 
                    mXMLConfigType = InitalXMLConfig.XmlConfigType.Bookmarks
                Case BookmarkTypes.TemplateBookMarks
                    mstrBookMarkNameTag = "Name"
                    mstrBookMarkRefTag = "ID"
                    mstrBookMarkImgIdxTag = "ImgIdx"
                    mstrBookMarkFileTag = "FileName" 
                    mXMLConfigType = InitalXMLConfig.XmlConfigType.TemplatesMenu
            End Select
        End Set
    End Property
    Public Property DBID() As String
        Get
            Return mstrDBID
        End Get
        Set(ByVal Value As String)
            mstrDBID = Value
        End Set
    End Property
    Public Sub Shuffle()
        Dim lintArrInc As Integer
        Dim lintSavedItemNum As Integer = -1

        Dim xDoc As New XmlDocument()
        Dim ConfigFile As String = System.Reflection.Assembly.GetEntryAssembly.Location.ToString() & ".dat"
        xDoc.Load(ConfigFile)

        Dim lInitialBookmarks As InitalXMLConfig = New InitalXMLConfig(mXMLConfigType, mstrDBID)

        Dim lstrSection As String = apphealth.GetSectionString(mXMLConfigType, mstrDBID)
        With lInitialBookmarks
            Dim llngItemCount As Long = CLng(Val(.GetValue("ItemCount", ""))) 

            For lintArrInc = 0 To llngItemCount '19
                'Clear Here
                BatchXMLItemWrite(xDoc, lstrSection, mstrBookMarkNameTag & lintArrInc, "")
                BatchXMLItemWrite(xDoc, lstrSection, mstrBookMarkRefTag & lintArrInc, "")
                BatchXMLItemWrite(xDoc, lstrSection, mstrBookMarkImgIdxTag & lintArrInc, "")
                If mstrBookMarkFileTag <> "" Then 
                    BatchXMLItemWrite(xDoc, lstrSection, mstrBookMarkFileTag & lintArrInc, "") 
                End If
            Next lintArrInc

            For lintArrInc = 0 To llngItemCount '19
                Dim lstrBookMarkName As String = .GetValue(mstrBookMarkNameTag & lintArrInc, "")
                Dim lstrBookMarkCode As String = .GetValue(mstrBookMarkRefTag & lintArrInc, "")
                Dim lstrBookMarkImgIdxCode As String = .GetValue(mstrBookMarkImgIdxTag & lintArrInc, "")
                Dim lstrBookMarkFile As String = .GetValue(mstrBookMarkFileTag & lintArrInc, "")
                If lstrBookMarkName = "" Then
                    'Clear Here
                Else
                    'save here
                    lintSavedItemNum += 1
                    BatchXMLItemWrite(xDoc, lstrSection, mstrBookMarkNameTag & lintSavedItemNum, lstrBookMarkName)
                    BatchXMLItemWrite(xDoc, lstrSection, mstrBookMarkRefTag & lintSavedItemNum, lstrBookMarkCode)
                    BatchXMLItemWrite(xDoc, lstrSection, mstrBookMarkImgIdxTag & lintSavedItemNum, lstrBookMarkImgIdxCode)

                    If mstrBookMarkFileTag <> "" Then 
                        BatchXMLItemWrite(xDoc, lstrSection, mstrBookMarkFileTag & lintSavedItemNum, lstrBookMarkFile) 
                    End If

                    BatchXMLItemWrite(xDoc, lstrSection, "ItemCount", lintSavedItemNum) 
                End If
            Next lintArrInc
        End With

        xDoc.Save(ConfigFile)
        xDoc = Nothing
    End Sub
End Class
