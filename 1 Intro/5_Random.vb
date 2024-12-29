Module Program
    Sub Main()
        Dim random As New Random()
        Dim numeroCasuale As Integer = random.Next(1, 101) ' Genera un numero casuale tra 1 e 100

        Console.WriteLine("Il numero casuale generato è: " & numeroCasuale)
        Console.ReadKey()
    End Sub
End Module