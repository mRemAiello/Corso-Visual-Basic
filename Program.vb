Imports System.Data.SQLite

Module Module1

    Dim connString As String = "Data Source=utenti.db;Version=3;"

    Sub Main()
        CreaDatabase()

        AddUtente("Luca", "luca@email.it")
        AddUtente("Maria", "maria@email.it")
        AddUtente("Giorgio", "giorgio@email.it")

        Console.WriteLine("Tutti gli utenti:")
        ListaUtenti()

        Console.WriteLine(vbCrLf & "Cerca utente 'Maria':")
        CercaUtentePerNome("Maria")

        Console.WriteLine(vbCrLf & "Rimuovi utente 'Giorgio'")
        RimuoviUtente("Giorgio")

        Console.WriteLine(vbCrLf & "Lista aggiornata:")
        ListaUtenti()

        Console.WriteLine(vbCrLf & "Premi un tasto per uscire...")
        Console.ReadKey()
    End Sub

    Sub CreaDatabase()
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim cmd As New SQLiteCommand("
                CREATE TABLE IF NOT EXISTS utenti (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nome TEXT NOT NULL,
                    email TEXT NOT NULL
                );", conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Sub AddUtente(nome As String, email As String)
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim cmd As New SQLiteCommand("INSERT INTO utenti (nome, email) VALUES (@nome, @email);", conn)
            cmd.Parameters.AddWithValue("@nome", nome)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Sub ListaUtenti()
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM utenti;", conn)
            Dim reader = cmd.ExecuteReader()
            ' reader.Read() -> True -> reader("id"), reader("nome"), reader("email")
            While reader.Read()
                Console.WriteLine($"ID: {reader("id")}, Nome: {reader("nome")}, Email: {reader("email")}")
            End While
        End Using
    End Sub

    Sub RimuoviUtente(nome As String)
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim cmd As New SQLiteCommand("DELETE FROM utenti WHERE nome = @nome;", conn)
            cmd.Parameters.AddWithValue("@nome", nome)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Sub CercaUtentePerNome(nome As String)
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM utenti WHERE nome = @nome;", conn)
            cmd.Parameters.AddWithValue("@nome", nome)
            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                Console.WriteLine($"ID: {reader("id")}, Nome: {reader("nome")}, Email: {reader("email")}")
            End While
        End Using
    End Sub

End Module
