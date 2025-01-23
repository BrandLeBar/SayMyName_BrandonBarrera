'Brandon Barrera
'Spring 2025
'RCET2265
'SayMyName
'https://github.com/BrandLeBar/SayMyName_BrandonBarrera.git

Option Explicit On
Option Strict On
Module SayMyName_BrandonB

    Sub Main()
        Dim Name As String 'Set aside RAM for variable

        Console.WriteLine("What is your name?") 'Ask the user their name
        Name = Console.ReadLine 'Set their name as a variable
        Console.WriteLine()

        If (Name = "Danger") Or (Name = "Walter") Or (Name = "danger") Or (Name = "walter") Or (Name = "Heisenburg") Or (Name = "heisenburg") Then
            Console.WriteLine("Hello Mr.White")
        ElseIf (Name = Name) Then
            Console.WriteLine("Your Name is " & Name & "!") 'Say their name
        End If

    End Sub

End Module
