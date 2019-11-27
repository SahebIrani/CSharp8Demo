using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp8
{
    #region Question 01 ==> What is the output of the following code snippet?
    public class Question01
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

    #region Question 02 ==> What is the output of the following code snippet?
    public class Question02
    {
        public class Panda
        {
            static int count;
            public Panda() => count = 0; /*static*/  // access modifiers are not allowed on static constructors
            public void Increment() => ++count;
            public void PrintCount() => Console.WriteLine(count);
        }
    }
    #endregion

    #region Question 03 ==> Which of the following sentences are true about static methods?

    #endregion

    #region Question 04 ==> When should we implement IDisposable interface?
    #endregion

    #region Question 05 ==> Consider the following class:
    public class Question05
    {
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString() => $"{X}{Y}";
        }
    }
    #endregion

    #region Question 06 ==> What about this code?

    #endregion

    #region Question 04 ==>
    #endregion

    #region Question 04 ==>
    #endregion

    #region Question 04 ==>
    #endregion

    #region Question 04 ==>
    #endregion

    #region Question 04 ==>
    #endregion

    #region Question 04 ==>
    #endregion

    #region Question 04 ==>
    #endregion

    #region Question 04 ==>
    #endregion

    #region Question 04 ==>
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region Answer01
            new Question01.Panda().Increment();
            new Question01.Panda().Increment();
            new Question01.Panda().PrintCount();
            // 1 ==> 0 (◘)
            // 2 ==> 1
            // 3 ==> 2
            #endregion

            #region Answer02
            new Question02.Panda().Increment();
            new Question02.Panda().Increment();
            new Question02.Panda().PrintCount();
            // 1 ==> 0
            // 2 ==> 1
            // 3 ==> 2
            // 4 ==> it has a compilation error: static fields cannot be accessed inside instance methods. (◘)
            #endregion

            #region Answer03
            // 1 ==> Static methods have no direct access to instance members.
            // 2 ==> Instance methods have no direct access to static methods.
            // 3 ==> There is no need to create an instance of the object to call its static methods.
            // 4 ==> Static methods cannot use ◘this◘ keyword inside the method body.
            // 5 ==> Only Static methods can be called inside the class constructor.
            #endregion

            #region Answer04
            // 1 ==> When we want the memory of the object to be released automatically.
            // 2 ==> When we want our class to have a ◘Dispose()◘ method that we want to call as needed.
            // 3 ==> When our class uses some unmanaged resources that cannot be released automatically by CLR.
            // 4 ==> When our class uses some unmanaged resources and we want the ◘GC◘ to release them automatically.
            #endregion

            #region Answer05
            // and the following object:
            List<Question05.Point> list = new List<Question05.Point>
            {
                new Question05.Point{ X = 1 , Y = 1},
                new Question05.Point{ X = 11 , Y = 22},
            };
            // What is the output of the following code snippet?
            List<Question05.Point> list2 = list;
            list.Remove(list.Last());
            Console.WriteLine(list2.Count);

            // 1 ==> 0
            // 2 ==> 1 (◘)
            // 3 ==> 2
            #endregion

            #region Answer06
            // independent of the last code snippet?
            list2 = new List<Question05.Point>(list);
            list2[0].X = 50;
            list2[0].Y = 60;
            #endregion

            #region Answer03
            #endregion

            #region Answer03
            #endregion

            #region Answer03
            #endregion

            #region Answer03
            #endregion

            #region Answer03
            #endregion
            #region Answer03
            #endregion

            Console.ReadKey();
        }
    }
}
