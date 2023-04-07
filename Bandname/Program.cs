namespace Bandname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the noun");
            String noun = Console.ReadLine();
            String bandName = " ";


            if (noun[0] == noun[noun.Length - 1])
            {
                char firstcharacter = char.ToUpper(noun[0]);
                bandName = firstcharacter + noun.Substring(1) + noun;

            }
            else
            {
                bandName = "The " + noun;

            }
            Console.WriteLine(bandName);


        }
    }
}