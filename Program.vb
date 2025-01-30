Module Program
    Sub Main()
        Console.Write("Inserisci la tua età: ")
        Dim età As Integer = Convert.ToInt32(Console.ReadLine())

        If età >= 18 And età <= 65 Then
            Console.WriteLine("Sei maggiorenne.")
        ElseIf età >= 14 And età < 18 Then
            Console.WriteLine("Sei minorenne.")
        ElseIf età < 14 Or età > 65 Then
            Console.WriteLine("Sei un bambino o un anziano.")
        End If

        ' Verifica se a è uguale a b
        If a = b Then
            Console.WriteLine("a è uguale a b")
            ' Azione da eseguire se a è uguale a b
        End If

        ' Verifica se a è diverso da b
        If a <> b Then
            Console.WriteLine("a è diverso a b")
            ' Azione da eseguire se a è diverso da b
        End If

        If a Mod 2 = 0 Then
            ' Azione da eseguire se a è pari
            Console.WriteLine("a è pari")
        End If

        Console.ReadKey()
    End Sub
End Module