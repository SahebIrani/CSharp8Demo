using System;

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
            // 1 ==>    0 (◘)
            // 2 ==>    1
            // 3 ==>    2
            #endregion

            #region Answer02
            new Question02.Panda().Increment();
            new Question02.Panda().Increment();
            new Question02.Panda().PrintCount();
            // 1 ==>    0
            // 2 ==>    1
            // 3 ==>    2
            // 4 ==>    it has a compilation error: static fields cannot be accessed inside instance methods. (◘)
            #endregion

            #region Answer03
            // 1 ==>    Static methods have no direct access to instance members.
            // 2 ==>    Instance methods have no direct access to static methods.
            // 3 ==>    There is no need to create an instance of the object to call its static methods.
            // 4 ==>    Static methods cannot use ◘this◘ keyword inside the method body.
            // 5 ==>    Only Static methods can be called inside the class constructor.
            #endregion

            #region Answer4

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

            #region Answer03
            #endregion
            #region Answer03
            #endregion

            Console.ReadKey();
        }
    }
}
