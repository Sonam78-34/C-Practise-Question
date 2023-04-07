namespace String_searching
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("length");
            int len= int.Parse(Console.ReadLine());
            Console.WriteLine("enter the string array");
            
            string[] str=new string[len];
            for(int i=0;i<len; i++)
            {
                str[i] = Console.ReadLine();
            }
            
            int flag = 0;
            for (int i = 0; i < (str.Length) - 1; i++)
            {
                string string2 = "";
                string string3 = "";
                char last = '\0';
                char first = '\0';
                string2 = str[i];
                string3 = str[i + 1];
                last = string2[(string2.Length) - 1];
                first = string3[0];
                Console.WriteLine(first);
                Console.WriteLine(last);
                if (last.Equals(first))
                {
                    flag = 0;
                }
                else
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}