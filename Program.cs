using System;
class Program{
    static void Main()
    {
        // Erstelle ein Array mit zufälligen Zahlen
        int[] array = new int[10];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100);
        }

        // Gib das unsortierte Array aus
        Console.WriteLine("Unsortiertes Array:");
        foreach (int zahl in array)
        {
            Console.Write(zahl + " ");
        }
        Console.WriteLine();

        // Sortiere das Array mit Selection Sort
        InsertionSort(array);
        // Gib das sortierte Array aus
        Console.WriteLine("Sortiertes Array:");
        foreach (int zahl in array)
        {
            Console.Write(zahl + " ");
        }


    }  static void InsertionSort(int[] array)

    {
        for (int i = 1; i < array.Length; i++)
        {
            // Das aktuelle Element, das wir einfügen möchten
        int key = array[i];
        int j = i -1;
        Console.WriteLine($"Schritt {1}: key = {key}" );
        // Vergleiche das aktuelle Element mit den vorherigen Elementen
        // und verschiebe sie nach rechts, wenn sie größer sind
        while(j >= 0 && array[j] > key)
        {
            Console.WriteLine($"Vergleiche: array[{j}] = {array[j]} > key = {key} --> verschiebe");
            // Verschiebe das Element nach rechts
            array[j + 1] = array[j];
            j--;
            Console.WriteLine($"Array nach Verschiebung: {string.Join(", ", array)}");
        }
        // Füge das aktuelle Element an der richtigen Stelle ein
        array[j + 1] = key;
        Console.WriteLine($"Füge {key} an Position {j + 1} ein");
        Console.WriteLine($"Array nach Einfügen: {string.Join(", ", array)}");
        }
    }
}