namespace findevenandoddstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str= Console.ReadLine();
            /*
            String evenstr = "";
            String oddstr = " ";
            for(int i=0;i<str.Length;i++)
            {
                if (i%2==0)
                {
                    evenstr =evenstr+ str[i];
                    
                }
                else
                {
                    oddstr += str[i];   
                }
            }
           Console.WriteLine(evenstr+" "+oddstr);
            ===============================*/
            String updatedstr = "";
            for(int i=0;i<str.Length;i++)
            {
                if (str[i]=='(')
                {
                    
                    for(char c = str[i];str[i]!=')';i++)
                    {
                        continue;
                    }

                }
               
                else
                {
                    updatedstr += str[i];
                }
                
            }
            Console.WriteLine(updatedstr);
            
        }
    }
}