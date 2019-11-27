using System;

namespace CSharp8
{
    #region Q01
    //Question 01 ==> What is the output of the following code snippet?
    public class Question1
    {
        public class Panda
        {
            int count;
            public Panda() => count = 0;
            public void Increment() => ++count;
            public void PrintCount() => Console.WriteLine(count);
        }
    }
    #endregion

    #region Q02
    //Question 02 ==> What is the output of the following code snippet?
    public class Question2
    {
        public class Panda
        {
            static int count;
            static public Panda() => count = 0;
            public void Increment() => ++count;
            public void PrintCount() => Console.WriteLine(count);
        }
    }
    #endregion

    #region Q02
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region A01
            new Panda().Increment();
            new Panda().Increment();
            new Panda().PrintCount();
            //Answer 01 ==>
            //    1 ==> 0    (*)
            //    2 ==> 1
            //    3 ==> 2
            #endregion

            #region A02

            #endregion

            #region A02
            #endregion

            Console.ReadKey();
        }
    }
}
