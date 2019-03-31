Friend Module Overlap
    Friend Function IsAboveOrEqualWinXp() As Boolean 

        IsAboveOrEqualWinXp = False

        Dim osInfo As OperatingSystem
        osInfo = System.Environment.OSVersion

        With osInfo

            If .Platform = PlatformID.Win32NT Then
                If .Version.Major >= 5 Then
                    If .Version.Minor >= 1 Then
                        IsAboveOrEqualWinXp = True
                    End If
                End If
            End If
        End With
    End Function
    Public Function IsWin98ME() As Boolean 

        IsWin98ME = False

        Dim osInfo As OperatingSystem
        osInfo = System.Environment.OSVersion

        With osInfo
            If .Platform = .Platform.Win32Windows Then
                Select Case (.Version.Minor)
                    Case 10 '= "Windows 98"
                        IsWin98ME = True
                    Case 90 '= "Windows Me"
                        IsWin98ME = True
                End Select
            End If
        End With
    End Function
End Module
