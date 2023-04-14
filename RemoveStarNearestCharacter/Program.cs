using System.Text;

namespace RemoveStarNearestCharacter
{
    public class Program
    {

        public static  string RemoveStarCharacter(string initialString)
        {
            char[] changedIntoCharachterArray = initialString.ToCharArray();

            // Loop through all the stars in the string
            for (int iterator = 0; iterator < changedIntoCharachterArray.Length; iterator++)
            {
                if (changedIntoCharachterArray[iterator] == '*')
                {
                    
                    int secondIterator = iterator - 1;
                    while (secondIterator >= 0 && changedIntoCharachterArray[secondIterator] == '*')
                    {
                        secondIterator--;
                    }
                    
                    if (secondIterator >= 0)
                    {
                        changedIntoCharachterArray[secondIterator] = '*';
                        changedIntoCharachterArray[iterator] = '*';
                    }
                }
            }

           
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in changedIntoCharachterArray)
            {
                if (c != '*')
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString();
        }
    
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string initialString = Console.ReadLine();
            string updatedString = RemoveStarCharacter(initialString);
            Console.WriteLine(updatedString);
        }
    }
}