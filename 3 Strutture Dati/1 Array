Module Program
    Sub Main()      

        ' Dichiarazione e inizializzazione di un array di interi
        Dim arrayNumeri As Integer() = {1, 2, 3, 4, 5}
        Console.WriteLine("Array originale:")
        StampaArray(arrayNumeri)

        ' Accesso a un elemento specifico dell'array
        Console.WriteLine("Elemento alla posizione 2: " & arrayNumeri(2))

        ' Modifica di un elemento dell'array
        arrayNumeri(2) = 10
        Console.WriteLine("Array dopo la modifica dell'elemento alla posizione 2:")
        StampaArray(arrayNumeri)

        ' Ordinamento dell'array
        Array.Sort(arrayNumeri)
        Console.WriteLine("Array ordinato:")
        StampaArray(arrayNumeri)

        ' Inversione dell'array
        Array.Reverse(arrayNumeri)
        Console.WriteLine("Array invertito:")
        StampaArray(arrayNumeri)

        ' Lunghezza dell'array
        Console.WriteLine("Lunghezza dell'array: " & arrayNumeri.Length)

        ' Creazione di un nuovo array ridimensionato
        ReDim Preserve arrayNumeri(7)
        arrayNumeri(5) = 6
        arrayNumeri(6) = 7
        arrayNumeri(7) = 8
        Console.WriteLine("Array dopo il ridimensionamento:")
        StampaArray(arrayNumeri)

        ' Ricerca di un elemento nell'array
        Dim indice As Integer = Array.IndexOf(arrayNumeri, 7)
        Console.WriteLine("Indice del numero 7: " & indice)

        ' Copia dell'array in un altro array
        Dim arrayCopia(7) As Integer
        Array.Copy(arrayNumeri, arrayCopia, arrayNumeri.Length)
        Console.WriteLine("Copia dell'array:")
        StampaArray(arrayCopia)

        ' Pulizia di una parte dell'array
        Array.Clear(arrayNumeri, 0, 3)
        Console.WriteLine("Array dopo aver cancellato i primi 3 elementi:")
        StampaArray(arrayNumeri)

        Console.ReadKey()

    End Sub

    ' Funzione per stampare l'array
    Sub StampaArray(ByVal arr As Integer())
        For Each numero In arr
            Console.WriteLine(numero)
        Next
    End Sub
End Module
