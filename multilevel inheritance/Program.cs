namespace multilevel_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            puppy smallDog= new puppy();
            smallDog.typeOfAnimal= "razo";
            smallDog.color = "brown";
            smallDog.speed = 123;
            smallDog.age = 2;
            smallDog.eating();
            smallDog.wark();
            Console.WriteLine(smallDog.speed);
        }
    }
}