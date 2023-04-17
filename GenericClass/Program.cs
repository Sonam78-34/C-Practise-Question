namespace GenericClass
{
    using System;

    public class MyGenericClass<T>
    {
        private T myVariable;

        public MyGenericClass(T variable)
        {
            myVariable = variable;
        }

        public T GetVariable()
        {
            return myVariable;
        }

        public void SetVariable(T variable)
        {
            myVariable = variable;
        }
    }

    public class Program
    {
        public static void Main()
        {
            MyGenericClass<int> myIntClass = new MyGenericClass<int>(42);
            Console.WriteLine("The IntClass variable value is " + myIntClass.GetVariable());

            MyGenericClass<string> myStringClass = new MyGenericClass<string>("Sia");
            Console.WriteLine("The string class variable value: " + myStringClass.GetVariable());

            
            myStringClass.SetVariable("Sonam ");
            Console.WriteLine("The string class  variable value: " + myStringClass.GetVariable());
        }
    }

}