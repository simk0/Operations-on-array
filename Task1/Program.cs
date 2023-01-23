using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть розміпр масиву");
        int arrSize = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть діапазон випадкових чисел\n");
        int arrRange = Convert.ToInt32(Console.ReadLine());
        int[] myArray;
        myArray = new int[arrSize];
        int Size = myArray.Length;
        Random rand = new Random();
        for (int i = 0; i < myArray.Length; i++) { 
                myArray[i] = rand.Next(-arrRange,arrRange);
             }
        Console.WriteLine("Масив:");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(" "+myArray[i]);
        }
        Console.WriteLine("\n");

        int sum = 0;
        for(int i = 0; i < myArray.Length; i++)
        {
            sum = sum +myArray[i];

        }

        Console.WriteLine();
        Console.WriteLine($"Сумма елементів масиву = {sum}");
        Console.WriteLine();
        int multiplication=1;
        for (int i = 0; i < myArray.Length; i++)
        {
            multiplication = multiplication * myArray[i];

        }
        Console.WriteLine($"Добуток елементів масиву:{multiplication}");

    }
}
        
        //Console.WriteLine("Введіть Мінімальне значення діапазону випадкових чисел\n");
        //int arrMin = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введіть Максимальне значення діапазону випадкових чисел\n");
        //int arrMax = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    myArray[i] = rand.Next(-arrMin, arrMax);
        //}


        //for (int i = 0; i < myArray.Length; i++)
        //{
        //    Console.WriteLine($"Введіть число №{Size - i}");
        //    myArray[i] = int.Parse(Console.ReadLine());
        //}

