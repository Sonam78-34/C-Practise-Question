namespace CustomizedGenericeClassNamedLoop
{
    public class Program
    {
         public static void Main(string[] args)
        {
            Loop<int> loop = new Loop<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("ShowFirst: " + loop.ShowFirst());

            Console.WriteLine("PopOut: " + loop.PopOut());

            loop.Add(6);

            Console.WriteLine("RotateRight:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(loop.ShowFirst());
                loop.RotateRight();
            }

            Console.WriteLine("RotateLeft:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(loop.ShowFirst());
                loop.RotateLeft();
            }

            Console.WriteLine("Loop with foreach:");
            foreach (int i in loop)
            {
                Console.WriteLine(i);
                if (i == 4)
                {
                    loop.PopOut();
                    loop.Add(7);
                }
            }
        }
    }
}