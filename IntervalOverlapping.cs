namespace Overlapping
{
    public  class IntervalOverlapping
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of intervals");
            int NumberOfIntervals= int.Parse(Console.ReadLine());
           
            int[,] interval = new int[,] { { 1, 5 }, { 3, 8 }, { 10,12} };
            int[,] updatedInterval = new int[NumberOfIntervals,2];
            

            Console.WriteLine("Enter the interval start and end");

            for(int firstIterator = 0; firstIterator < NumberOfIntervals; firstIterator++)
            {
                for(int secondIterator = 0; secondIterator < 2; secondIterator++)
                {
                    interval[firstIterator,secondIterator] = int.Parse(Console.ReadLine());
                }
                
             }
         

           
           

            for (int firstIterator = 0; firstIterator < NumberOfIntervals-1; firstIterator++)
            {
                //int lastInteger = interval.GetLength(i)-1; 
                int nextInterval = firstIterator + 1;
                
                if (interval[firstIterator, 1] >= interval[nextInterval, 0])
                {
                     updatedInterval[firstIterator, 0] = interval[firstIterator, 0];
                     updatedInterval[firstIterator, 1] = interval[nextInterval, 1];
                }
                else
                {
                    updatedInterval[firstIterator, 0] = interval[nextInterval, 0];
                    updatedInterval[firstIterator, 1] = interval[nextInterval, 1];

                }
               // break;
                

            }
                Console.WriteLine("updated interval");
                for(int thirdIterator=0; thirdIterator< NumberOfIntervals;thirdIterator++)
                {
                    for(int iterator=0; iterator< 2; iterator++)
                    {
                    if (updatedInterval[thirdIterator,iterator]!=0)
                        Console.WriteLine(updatedInterval[thirdIterator,iterator]);
                    }
                }
            }

        }
    }
