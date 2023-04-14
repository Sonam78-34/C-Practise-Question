using System;
using PrintFizzBuzz;
using FluentAssertions;

namespace AssignmentTest
{
    public class PrintAccordingToNumber
    {
        PrintAccordingNumber num = new PrintAccordingNumber();
        [Fact]
        public void PrintFuzz()
        {
            string expectedString = "FuzzBuzz";
      
           num.PrintStringOrNumber(15).Should().Be(expectedString);
        }


        [Fact]
        public void PrintBuzz()
        {
            string expectedString = "Buzz";
            num.PrintStringOrNumber(10).Should().Be(expectedString);
        }

        [Fact]
        public void PrintFizz()
        {
            string expectedString = "Fuzz";
            num.PrintStringOrNumber(12).Should().Be(expectedString);
        }


        [Fact]
        public void PrintNumber()
        {
            string number = "7";
            num.PrintStringOrNumber(7).Should().Be(number);
        }
    }
}