using System.Linq.Expressions;

namespace Constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            Console.WriteLine("Enter the width,length,height");
            for (int i = 0; i < array.Length; i++)
            { 
            array[i] = int.Parse(Console.ReadLine());
            }

            Block block= new Block(array);
            
            Console.WriteLine(block.GetWidth());
            Console.WriteLine(block.GetLength());
            Console.WriteLine(block.GetHeight());
            Console.WriteLine(block.GetVolume());
            Console.WriteLine(block.GetSurfaceArea());
        
        }
        
    }
}