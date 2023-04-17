namespace GenericMethod
{
    using System;

    class Program
    {
         public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] words = { "apple", "banana", "cherry" };

            Console.WriteLine("First element of numbers: " + First(numbers));
            Console.WriteLine("First element of words: " + First(words));
        }

         public static T First<T>(T[] numberArray)
        {
            if (numberArray.Length == 0)
            {
                throw new InvalidOperationException("Array is empty");
            }

            return numberArray[0];
        }
    }

}