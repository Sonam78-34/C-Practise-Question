namespace BaseballGameScore
{
    public class BaseBallScore
    {
        public static  int ScoreTrack(string[] acheivedScore)
        {
            Stack<int> stack = new Stack<int>();

            foreach (string IndiviualCharacter in acheivedScore)
            {
                if (IndiviualCharacter == "C")
                {
                    stack.Pop(); // Remove the previous score
                }
                else if (IndiviualCharacter == "D")
                {
                    stack.Push(2 * stack.Peek()); // Double the previous score
                }
                else if (IndiviualCharacter == "+")
                {
                    int prev1 = stack.Pop();
                    int prev2 = stack.Peek();
                    stack.Push(prev1);
                    stack.Push(prev1 + prev2); // Add the previous two scores
                }
                else
                {
                    stack.Push(int.Parse(IndiviualCharacter));

                }
            }
        

            int sum = 0;
            foreach (int score in stack) 
            {
                sum += score;
            }
            return sum;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of String");
            int number= int.Parse(Console.ReadLine());

            string[] acheivedScore = new string[number];

            Console.WriteLine("Enter the String");
            for(int  i=0; i<number; i++)
            {
                acheivedScore[i] = Console.ReadLine();
            }

            int totalScore = ScoreTrack(acheivedScore);
            Console.WriteLine(totalScore);
        }
    }
}