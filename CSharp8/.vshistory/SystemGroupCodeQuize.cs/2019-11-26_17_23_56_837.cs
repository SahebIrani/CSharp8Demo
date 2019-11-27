using System;

namespace CSharp8
{
    public class Panda
    {
        int count;
        public Panda() => count = 0;
        public void Increment() => ++count;
        public void PrintCount() => Console.WriteLine(count);
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Panda().Increment();
            new Panda().Increment();
            new Panda().PrintCount();


            Console.ReadKey();
        }
    }
}
