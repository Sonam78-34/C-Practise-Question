namespace Occurances_of_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string stringValue = Console.ReadLine();

            stringValue = stringValue.Replace(" ", string.Empty);
            Console.WriteLine(stringValue);

            while (stringValue.Length > 0)
            {

                int count = 0;
                for (int j = 0; j < stringValue.Length; j++)
                {
                    if (stringValue[0] == stringValue[j])
                    {
                        count++;
                    }
                }
                Console.Write(stringValue[0] + " : " + count + ",");
                stringValue = stringValue.Replace(stringValue[0].ToString(), string.Empty);

            }
        }
    }
}
