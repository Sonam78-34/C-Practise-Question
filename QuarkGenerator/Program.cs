using System;

namespace QuarkGenerator
{


    public class Quark
    {
       
        public string Color { get; }
        public string Flavor { get; }
        public double BaryonNumber { get; } = 1.0 / 3.0;

        // Constructor
        public Quark(string color, string flavor)
        {
            if (IsValidColor(color) && IsValidFlavor(flavor))
            {
                Color = color;
                Flavor = flavor;
            }
           
        }

        // Public methods
        public void Interact(Quark others)
        {
            if (others != null)
            {
                string temp = Color;
                Color = others.Color;
                others.Color = temp;
            }
        }

        // Private methods
        private bool IsValidColor(string color)
        {
            return color == "red" || color == "green" || color == "blue";
        }

        private bool IsValidFlavor(string flavor)
        {
            return flavor == "up" || flavor == "down" || flavor == "strange" || flavor == "charm" || flavor == "top" || flavor == "bottom";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Quark quarkOne = new Quark("red", "up");
            Quark quarkTwo = new Quark("blue", "strange");

            Console.WriteLine("Before interaction:");
            Console.WriteLine("q1: color = {0}, flavor = {1}", quarkOne.Color, quarkOne.Flavor);
            Console.WriteLine("q2: color = {0}, flavor = {1}", quarkTwo.Color, quarkTwo.Flavor);

            quarkOne.Interact(quarkTwo);

            Console.WriteLine("After interaction:");
            Console.WriteLine("q1 color = {0}, flavor = {1}", quarkOne.Color, quarkOne.Flavor);
            Console.WriteLine("q2 color = {0}, flavor = {1}", quarkTwo.Color, quarkTwo.Flavor);
        }
    }
}