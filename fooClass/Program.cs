namespace fooClass
{
    using System;
    using System.Threading;

    public class Foo
    {
        private ManualResetEvent firstEvent = new ManualResetEvent(false);
        private ManualResetEvent secondEvent = new ManualResetEvent(false);

        public void first()
        {
            Console.WriteLine("first");
            firstEvent.Set(); 
        }

        public void second()
        {
            firstEvent.WaitOne(); 
            Console.WriteLine("second");
            secondEvent.Set(); 
        }

        public void third()
        {
            secondEvent.WaitOne(); 
            Console.WriteLine("third");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();

            Thread threadA = new Thread(new ThreadStart(foo.first));
            Thread threadB = new Thread(new ThreadStart(foo.second));
            Thread threadC = new Thread(new ThreadStart(foo.third));

            threadA.Start();
            threadB.Start();
            threadC.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
        }
    }

}