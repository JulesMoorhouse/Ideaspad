Public Class clsCipher
    Private mstrKey As String
    Private mstrText As String
    Friend Property KeyString() As String
        Get
            ' The Get property procedure is called when the value
            ' of a property is retrieved. 
            Return mstrKey
        End Get
        Set(ByVal Value As String)
            ' The Set property procedure is called when the value 
            ' of a property is modified. 
            ' The value to be assigned is passed in the argument to Set. 
            mstrKey = Value
            Initialize()
        End Set
    End Property
    Friend Property Text() As String
        Get
            ' The Get property procedure is called when the value
            ' of a property is retrieved. 
            Return mstrText
        End Get
        Set(ByVal Value As String)
            ' The Set property procedure is called when the value 
            ' of a property is modified. 
            ' The value to be assigned is passed in the argument to Set. 
            mstrText = Value

        End Set
    End Property
    '~~~.DoXor
    'Exclusive-or method to encrypt or decrypt
    Friend Sub DoXor()
        Dim lngC As Integer
        Dim intB As Integer
        Dim lngN As Integer
        For lngN = 1 To (mstrText).Length
            lngC = AscGet(MidGet(mstrText, lngN, 1))
            intB = System.Math.Floor(Microsoft.VisualBasic.Rnd() * 256)
            Mid(mstrText, lngN, 1) = ChrGet(lngC Xor intB) 'VB Migr was Convert.ToChar
        Next lngN
    End Sub
    '~~~.Stretch
    'Convert any string to a printable, displayable string
    Friend Sub Stretch()
        Dim lngC As Integer
        Dim lngN As Integer
        Dim lngJ As Integer
        Dim lngK As Integer
        Dim lngA As Integer
        Dim strB As String
        lngA = (mstrText).Length
        'strB = Space(lngA + (lngA + 2) \ 3)
        'strB.PadLeft((lngA + (lngA + 2) \ 3), " ")
        strB = New String(" ", (lngA + (lngA + 2) \ 3))

        For lngN = 1 To lngA
            lngC = AscGet(MidGet(mstrText, lngN, 1))
            lngJ = lngJ + 1
            Mid(strB, lngJ, 1) = ChrGet((lngC And 63) + 59) 'VB Migr was Convert.ToChar
            Select Case lngN Mod 3
                Case 1
                    lngK = lngK Or ((lngC \ 64) * 16)
                Case 2
                    lngK = lngK Or ((lngC \ 64) * 4)
                Case 0
                    lngK = lngK Or (lngC \ 64)
                    lngJ = lngJ + 1
                    Mid(strB, lngJ, 1) = ChrGet(lngK + 59) 'VB Migr was Convert.ToChar
                    lngK = 0
            End Select
        Next lngN
        If lngA Mod 3 Then
            lngJ = lngJ + 1
            Mid(strB, lngJ, 1) = ChrGet(lngK + 59) 'VB Migr was Convert.ToChar
        End If
        mstrText = strB
    End Sub
    '~~~.Shrink
    'Inverse of the Stretch method;
    'result can contain any of the 256-byte values
    Friend Sub Shrink()
        Dim lngC As Integer
        Dim lngD As Integer
        Dim lngE As Integer
        Dim lngA As Integer
        Dim lngB As Integer
        Dim lngN As Integer
        Dim lngJ As Integer
        Dim lngK As Integer
        Dim strB As String
        lngA = (mstrText).Length
        lngB = lngA - 1 - (lngA - 1) \ 4
        'strB.PadLeft(lngB, " ")
        strB = New String(" ", lngB)

        For lngN = 1 To lngB
            lngJ = lngJ + 1
            lngC = AscGet(MidGet(mstrText, lngJ, 1)) - 59
            Select Case lngN Mod 3
                Case 1
                    lngK = lngK + 4
                    If lngK > lngA Then lngK = lngA
                    lngE = AscGet(MidGet(mstrText, lngK, 1)) - 59
                    lngD = ((lngE \ 16) And 3) * 64
                Case 2
                    lngD = ((lngE \ 4) And 3) * 64
                Case 0
                    lngD = (lngE And 3) * 64
                    lngJ = lngJ + 1
            End Select
            Mid(strB, lngN, 1) = ChrGet(lngC Or lngD)  'VB Migr was Convert.ToChar          
        Next lngN
        mstrText = strB
    End Sub
    'Initializes random numbers using the key string
    Private Sub Initialize()
        Dim lngN As Integer
        Microsoft.VisualBasic.Randomize(Microsoft.VisualBasic.Rnd(-1))
        For lngN = 1 To mstrKey.Length
            Microsoft.VisualBasic.Randomize(Microsoft.VisualBasic.Rnd(-Microsoft.VisualBasic.Rnd() * AscGet(MidGet(mstrKey, lngN, 1))))
        Next lngN
    End Sub
End Class
