using GenericCastDelegate;

namespace GenericCastDelegate
{
    public class Program
    {
         public static void Main(string[] args)
        {
            //for func generic delegate
           /* 
            Func<int,int > squareDelegate = Square;
           Func<int,int> cubeDelegate = Cube;

            int squareValue = squareDelegate(10);
            int cubeValue = cubeDelegate(10);
            Console.WriteLine("The Square of number is "+squareValue);
            Console.WriteLine("The cube of number is "+ cubeValue);
           */
            




            //for action generic delegate
            
            Action<string> findAInMessage = ActionGenericDelegate.FindAInMessage;
            findAInMessage("Sonam Singh");
            



            //for predicate delegate
            /*
            Predicate<string> mail = isemail;
            bool mailCheck= mail("sonam@gmail.com");
            Console.WriteLine("The mail is "+mailCheck);
            */




        }
    }
}