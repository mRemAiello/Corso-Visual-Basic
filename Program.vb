Module Program
    Sub Main()

        ' Creazione di una lista (List) di interi
        Dim listaNumeri As New List(Of Integer)()

        ' Aggiunta di elementi alla lista
        listaNumeri.Add(1)
        listaNumeri.Add(2)
        listaNumeri.Add(3)

        ' Aggiunta di più elementi in una volta
        listaNumeri.AddRange(New Integer() {4, 5, 6})

        ' Inserimento di un elemento in una posizione specifica
        listaNumeri.Insert(0, 0)

        ' Rimozione di un elemento specifico
        listaNumeri.Remove(3)
        listaNumeri.Remove(5)

        ' Rimozione dell'elemento in una posizione specifica
        listaNumeri.RemoveAt(0)

        ' Controllo se un elemento è presente nella lista
        Dim contiene As Boolean = listaNumeri.Contains(5)
        Console.WriteLine("La lista contiene il numero 5? " & contiene)

        ' Trova l'indice di un elemento
        Dim indice As Integer = listaNumeri.IndexOf(5)
        Console.WriteLine("Indice del numero 5: " & indice)

        ' Ordinamento della lista
        listaNumeri.Sort()

        ' Inversione dell'ordine della lista
        listaNumeri.Reverse()

        ' Stampa degli elementi della lista
        Console.WriteLine("Lista dopo modifiche:")
        For Each numero In listaNumeri
            Console.WriteLine(numero)
        Next

        ' Ottiene il numero di elementi nella lista
        Console.WriteLine("Numero di elementi nella lista: " & listaNumeri.Count)

        ' Accesso a un elemento specifico
        Console.WriteLine("Elemento alla posizione 2: " & listaNumeri(2))

        ' Cancella tutti gli elementi della lista
        listaNumeri.Clear()
        Console.WriteLine("La lista è vuota? " & (listaNumeri.Count = 0))

    End Sub
End Module