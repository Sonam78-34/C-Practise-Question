namespace Remove_paranthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String originalString = Console.ReadLine();
            String updatedstring = "";
            for (int i = 0; i < OriginalString.Length; i++)
            {
                if (originalStringi] == '(')
                {

                    for (char c = originalString[i]; originalString[i] != ')'; i++)
                    {
                        continue;
                    }

                }

                else
                {
                    updatedstr += originalString[i];
                }

            }
            Console.WriteLine(updatedstr);

        }
    }
}