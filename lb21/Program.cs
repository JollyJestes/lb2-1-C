using System;
//171
//Перемешать колоду из n игральных карт(n = 36 или n = 52).
//Заполнить массив K(n) числами натурального ряда K(i) = i.
//При перемешивании использовать обмен переменных со сгенерированными случайными номерами.
class Program
{
    static Random random = new Random();

    static void ShuffleDeck(int[] deck)
    {
        int n = deck.Length;
        for (int i = 0; i < n; i++)
        {
            int j = i + random.Next(n - i); 

            
            int temp = deck[i];
            deck[i] = deck[j];
            deck[j] = temp;
        }
    }

    static void FillNaturalNumbers(int[] K)
    {
        for (int i = 0; i < K.Length; i++)
        {
            K[i] = i + 1; 
        }
    }

    static void Main()
    {
        int n = 36; // Выберите n = 36 или n = 52 в зависимости от колоды
        int[] deck = new int[n];
        int[] K = new int[n];

        FillNaturalNumbers(K); 
        for (int i = 0; i < n; i++)
        {
            deck[i] = i + 1; 
        }
        ShuffleDeck(deck);     

        
        Console.WriteLine("Перемешанная колода:");
        foreach (int card in deck)
        {
            Console.Write(card + " ");
        }

        Console.WriteLine("\nМассив K:");
        foreach (int number in K)
        {
            Console.Write(number + " ");
        }

        Console.ReadLine();
    }
}