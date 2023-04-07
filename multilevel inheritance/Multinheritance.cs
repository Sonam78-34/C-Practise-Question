using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace multilevel_inheritance
{
    public class Animal
    {
        public String typeOfAnimal;
        public String color;
        public int age;

    }
    public class Dog : Animal
    {
         public int speed;
        public void  wark()
        {
            Console.WriteLine("The dog is warking");
        }
    }
    public class puppy : Dog
    {
        public void eating()
        {
            Console.WriteLine("The puppy is eating");
        }
    }

} 
