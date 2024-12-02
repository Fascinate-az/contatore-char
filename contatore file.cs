// Crea un oggetto DirectoryInfo che rappresenta la cartella corrente (".")
        DirectoryInfo cartella = new DirectoryInfo(".");

        // Variabile per accumulare il totale dello spazio occupato dai file
        long spazioTotale = 0;

        // Scorre tutti i file presenti nella cartella corrente
        foreach (FileInfo file in cartella.GetFiles())
        {
            // Stampa il nome del file (allineato a destra con spazi) e la sua dimensione in byte
            Console.WriteLine($"File: {file.Name.PadRight(60, ' ')} - dimensioni: {file.Length} bytes");

            // Aggiunge la dimensione del file al totale
            spazioTotale += file.Length;
        }

        // Stampa il totale dello spazio occupato da tutti i file nella cartella
        Console.WriteLine($"\n-------------------- Totale spazio occupato dalla cartella: {spazioTotale} bytes");

        // Attende la pressione di un tasto per chiudere la console
        Console.ReadKey();
