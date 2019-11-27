using System;

namespace CSharp8
{
    #region Q01
    public class Panda
    {
        int count;
        public Panda() => count = 0;
        public void Increment() => ++count;
        public void PrintCount() => Console.WriteLine(count);
    }
    #endregion

    #region Q02
    #endregion

    class Program
    {
        static void Main(string[] args)
        {



            #region R01
            new Panda().Increment();
            new Panda().Increment();
            new Panda().PrintCount();
            #endregion



            #region Q02
            #endregion


            Console.ReadKey();
        }
    }
}
