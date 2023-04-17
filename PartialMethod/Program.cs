namespace PartialMethod
{
    public partial class AddNumber
    {
        public partial void AddTwoNumber(int number1, int number2);
       
    }
    public partial class AddNumber

    {
        public partial void AddTwoNumber(int number1,int number2)
        {
            Console.WriteLine(number1+number2);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AddNumber add= new AddNumber();
            int number1 = 10;
            int number2 = 20;
            add.AddTwoNumber(10,20);

        }
    }
}