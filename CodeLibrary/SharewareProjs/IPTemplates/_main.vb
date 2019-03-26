Public Class _main
    Public Structure resources
        Dim file As String
        Dim ID As String
        Dim Name As String
    End Structure

    Public Sub HTMLForms(ByRef Ress() As resources)

        ReDim Ress(4)


        
        Dim lstrLang2Char As String = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName
        Select Case lstrLang2Char
            Case "de"
                lstrLang2Char = "de." 'see if resource manger will handle it
                Ress(0).Name = "Kontakt Form" 'Address
                'Ress(1).Name = "Tagebuch Form" 'Diary
                'Ress(2).Name = "Termin Form" 'Appointment
                'Ress(3).Name = "Ausgaben Form" 'Expense
                'Ress(4).Name = "Einnahmen Form" 'Income

                'Ress(0).Name = "Adresse Form"
                'Ress(1).Name = "Tagebuchform"
                'Ress(2).Name = "Verabredung Form"
                'Ress(3).Name = "Unkostenform"
                'Ress(4).Name = "Einkommenform"

                'Ress(0).Name = "Eingabemaske f�r die Adresse" 'Address form
                'Ress(1).Name = "Eingabemaske f�r das Tagebuch" 'Diary form
                'Ress(2).Name = "Eingabemaske f�r die Verabredung" 'Appointment form
                'Ress(3).Name = "Eingabemaske f�r die Einnahmen" 'Income form
                'Ress(4).Name = "Eingabemaske f�r die Ausgaben" 'Expense form

                Ress(0).Name = "Adresse" 'Address form
                Ress(1).Name = "Tagebucheintrag" 'Diary form
                Ress(2).Name = "Termin" 'Appointment form
                Ress(3).Name = "Einnahmen" 'Income form
                Ress(4).Name = "Ausgaben" 'Expense form
            Case Else
                lstrLang2Char = ""
                Ress(0).Name = "Address Form"
                Ress(1).Name = "Diary Form"
                Ress(2).Name = "Appointment Form"
                Ress(3).Name = "Expense Form"
                Ress(4).Name = "Income Form"
        End Select
        

        Ress(0).file = lstrLang2Char & "contact" & ".html" '"contact.html"
        Ress(0).ID = "Cntfrom000001".ToUpper 'added ToUpper

        Ress(1).file = lstrLang2Char & "diary" & ".html"  ' "diary.html"
        Ress(1).ID = "Dryfrom000001".ToUpper 'added ToUpper

        Ress(2).file = lstrLang2Char & "Appointment" & ".html"  '"Appointment.html"
        Ress(2).ID = "Appfrom000001".ToUpper 'added ToUpper

        Ress(3).file = lstrLang2Char & "Expense" & ".html"  '"Expense.html"
        Ress(3).ID = "Expfrom000001".ToUpper 'added ToUpper

        Ress(4).file = lstrLang2Char & "Income" & ".html"  '"Income.html"
        Ress(4).ID = "Incfrom000001".ToUpper 'added ToUpper



    End Sub
    Public Sub CSSSheets(ByRef Ress() As String)

        ReDim Ress(1)
        Ress(0) = "slick.css"

    End Sub
    Public Sub StartupFiles(ByRef Files() As String) 

        ReDim Files(0)
        'Files(0) = "smallyellowball.bmp"

    End Sub
    Public Function GetStartupHTMLName() As String

        Dim lstrLang2Char As String = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName
        Select Case lstrLang2Char
            Case "de"
                GetStartupHTMLName = "de.startup.html"
            Case Else
                GetStartupHTMLName = "startup.html"
        End Select

    End Function
End Class
