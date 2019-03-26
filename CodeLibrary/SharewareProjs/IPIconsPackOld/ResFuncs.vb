Imports Microsoft.VisualBasic
Public Module ResFuncs
    Public Enum IconIdent
        Print = 0
        NewRoot = 1
        NewSubBranch = 2
        Cut = 3
        Copy = 4
        Paste = 5
        Undo = 6
        Redo = 7
        AlignLeft = 8
        AlignCentre = 9
        AlignRight = 10
        FontSytle = 11
        Spelling = 12
        WordWrap = 13
        BranchProps = 14
        RapidEntry = 15
        FontBold = 16
        FontItalics = 17
        FontUnderline = 18
        FontColour = 19
        InsertGraphics = 20
        Bullets = 21
        MoveBranchUp = 22
        MoveBranchDown = 23
        MoveBranchTop = 24
        MoveBranchBottom = 25
        PageColour = 26
    End Enum

    Public Function CheckIconPackCompatibility() As Integer
        '0 OK
        '2 Ideaspad_IconCompatCFUWarn, SHOW MSG, THEN SHOW CFU, OR PROCEED IF CLICK CANCEL
        '3 Ideaspad_IconCompatCFUError, SHOW MSG, THEN SHOW CFU, THEN QUIT

        If IsNewEnough() = True Then
            CheckIconPackCompatibility = 0
        Else
            CheckIconPackCompatibility = 2
        End If

    End Function
    Friend Function IsNewEnough() As Boolean


        Dim llngFullPassNumner As Long = 1047
        Dim llngFullThisNumber As Long

        With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly.Location)
            llngFullThisNumber = CLng(.ProductMajorPart & .ProductMinorPart & .ProductBuildPart & .ProductPrivatePart)
        End With

        If llngFullThisNumber > llngFullPassNumner Then
            IsNewEnough = True
        End If


    End Function
    Public Function GetImgTag(ByVal pintImgIdx As Integer) As Integer
        'created
        Return intTreeIconTag(pintImgIdx)

    End Function
    Public Function GetImgIdx(ByVal pintImgTag As Integer) As Integer
        'created

        Dim lintArrInc As Integer

        For lintArrInc = 0 To intTreeIconTag.GetUpperBound(0)
            If pintImgTag = intTreeIconTag(lintArrInc) Then
                GetImgIdx = lintArrInc
                Exit Function
            End If
        Next lintArrInc

    End Function
End Module
