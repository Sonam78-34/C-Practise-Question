namespace PrintFizzBuzz
{
    public class PrintAccordingNumber
    {

        public string PrintStringOrNumber(int number)
        {
            if(number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBizz";
            }
            else if(number%5==0) 
            {
                return "Bizz";

            }
            else if(number%3 ==0)
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}