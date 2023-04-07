namespace Nearest_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int number = int.Parse(Console.ReadLine());
            int i = 1;
            int lowerSqaure = 1, upperSquare = 1;
            while (number > i * i)
            {
                if (i * i != number)
                {

                    lowerSqaure = i;
                    upperSquare = i+1;
                }
                i++;
            }
            if (i * i == num)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine( lowerSqaure);
                Console.WriteLine(upperSquare);
            }

        }
    }
}