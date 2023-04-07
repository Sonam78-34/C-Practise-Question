namespace Sequence_of_number
{
    public class Block
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start number");
            int startNumber= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end number");
            int endNumber= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the steps");
            int steps= int.Parse(Console.ReadLine());

            int sum=0;
            if(startNumber==endNumber)
            {
                Console.WriteLine("0");
            }
            for(int number=startNumber; number<=endNumber; number+=steps)
            {
                sum += number;
            }
            Console.WriteLine(sum);

        }
    }
}