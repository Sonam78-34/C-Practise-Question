namespace Find_maximum__occurance_of_charcter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string input = Console.ReadLine();
            char maximumChararacter= ' ';
            int maximumCount = 0;

            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int currentCount = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == currentChar)
                    {
                        currentCount++;
                    }
                }

                // Update the maximum character and count 
                if (currentCount > maxCount)
                {
                    maximumChar = currentChar;
                    maximumCount = currentCount;
                }
            }


            Console.WriteLine("The most repeated character is " + maximumChar + ", " + maximumCount);
        }
    }
}