Module Program
    Sub Main()
        ' Creazione di un'istanza della classe Studente
        Dim studente1 As New Studente("Luigi", "Verdi", 20, "Informatica")

        ' Utilizzo dei metodi della classe Studente e della classe base Persona
        Console.WriteLine("Nome completo: " & studente1.GetNomeCompleto())
        Console.WriteLine("Età: " & studente1.Eta)
        Console.WriteLine("Corso di studi: " & studente1.CorsoDiStudi)

        ' Modifica del corso di studi
        studente1.CorsoDiStudi = "Ingegneria"
        Console.WriteLine("Nuovo corso di studi: " & studente1.CorsoDiStudi)

        Console.ReadKey()
    End Sub
End Module

' Classe base Persona
Public Class Persona

    ' Campi privati
    Private nome As String
    Private secondoNome as String
    Private cognome As String

    ' Proprietà pubblica per l'età
    Public Property Eta As Integer

    ' Costruttore
    Public Sub New(nome As String, cognome As String, eta As Integer)
        Me.nome = nome
        Me.cognome = cognome
        Me.Eta = eta
    End Sub

    ' Metodo per ottenere il nome completo
    Public Function GetNomeCompleto() As String
        Return nome & " " & secondoNome & " " & cognome
    End Function

End Class

' Sottoclasse Studente che eredita dalla classe Persona
Public Class Studente
Inherits Persona

    ' Proprietà per il corso di studi
    Public Property CorsoDiStudi As String

    ' Costruttore della sottoclasse Studente
    Public Sub New(nome As String, cognome As String, eta As Integer, corsoDiStudi As String)
        MyBase.New(nome, cognome, eta)
        Me.CorsoDiStudi = corsoDiStudi
    End Sub

    Public Function GetNomeCompleto() As String
        ' Override del metodo GetNomeCompleto per la classe Studente
        Return MyBase.GetNomeCompleto() & " - Studente di " & CorsoDiStudi
    End Function

End Class