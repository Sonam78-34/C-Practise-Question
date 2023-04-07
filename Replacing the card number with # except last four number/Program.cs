namespace Replacing_the_card_number_with___except_last_four_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the card number");
            String cardNumber= Console.ReadLine();
            String maskNumber = " ";
            if(cardNumber.Length<=4) 
            {
                Console.WriteLine(cardNumber);
            }
            else
            {
                for(int cardDigit= 0;cardDigit<cardNumber.Length-4;cardDigit++)
                {
                    maskNumber+="#";
                }
                maskNumber += cardNumber.Substring(cardNumber.Length - 4);
                Console.WriteLine(maskNumber);

            }
           
        }
    }
}