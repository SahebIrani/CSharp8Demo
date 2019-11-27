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

    #region Question 07 ==> What is the default access modifier for class members?

    #endregion

    #region Question 08 ==> What is the outcome of the following code?
    public interface Isecurable
    {
        string SecurityToken { get; }
    }
    public class Page : Isecurable
    {
        string Isecurable.SecurityToken => "DefaultPageSecurityToken";
    }
    public class MainPage /*: Isecurable*/
    {
        public void Show() { }
    }
    #endregion

    #region Question 09 ==> Which of the following are correct? (Any number of options can be selected)
    #endregion

    #region Question 10 ==> What is the output of the following code snippet?
    #endregion

    #region Question 11 ==> Which of the followings cannot be defined in an interface? (any number of options can be selected)
    public interface INotify
    {
        //private readonly int _myField = 1; //Interfaces cannot contain instance fields
        //public TestFlowwings() { } //Interfaces cannot contain instance constructors
        public int MyMethod() => 13;
        public int MyProperty { get; set; }
        event EventHandler Notify;
    }
    public class Test : INotify
    {
        public int MyProperty { get; set; }

        public event EventHandler Notify;

        public void NotifyNow() => OnNotify(new EventArgs());
        void OnNotify(EventArgs e) => Notify?.Invoke(this, e);
    }
    #endregion

    #region Question 12 ==> Which of the following sentences are correct about "var" keyword?
    #endregion

    #region Question 13 ==>  What is the output of the following code?
    class Employee
    {
        public string Name { get; set; }
    }
    #endregion

    #region Question 14 ==> Which of the following sentence are correct about delegates?
    #endregion

    #region Question 15 ==> What is the output of the following program?
    class GlobalVaraiable<T>
    {
        public static object Value { get; set; }
    }
    #endregion

    #region Question 16 ==> What is the output of the following code snippet?
    #endregion

    #region Question 17 ==> What is the output of the following code snippet?
    #endregion

    #region Question 18 ==> With which of the following modifiers, we can prevent a method from being overriding in C#?
    #endregion

    #region Question 19 ==> Having caught an Exception into variable ex, which of the following is the best way to re-throw ex without losing original call stack?
    #endregion

    #region Question 20 ==> Consider the following implementation of a class. which of the following statements are correct?
    class Animal
    {
        private static Animal instace;
        private Animal()
        {
        }
        public static Animal Instance
        {
            get
            {
                if (instace == null)
                {
                    instace = new Animal();
                }

                return instace;
            }
        }
    }
    #endregion

    #region Question 21 ==> Which of the following statements are correct about Operator Overloading in C#:
    #endregion

    #region Question 22 ==> Which of the following LINQ functions/keywords is essential when an Outer Join is intended?
    #endregion

    #region Question 23 ==> Is it possible to access and use function is unmanaged DLLS?
    #endregion

    #region Question 24 ==> Consider the following code:
    class Parent
    {
        public Parent()
        {
        }
    }
    class Child : Parent
    {
        public Child()
        {
        }
    }
    class GrandChild : Child
    {
        public GrandChild()
        {
        }
    }
    #endregion

    #region Question 25 ==>
    #endregion

    #region Question 26 ==>
    #endregion

    #region Question 27 ==>
    #endregion

    #region Question 28 ==>
    #endregion

    #region Question 29 ==>
    #endregion

    #region Question 30 ==>
    #endregion

    #region Question 31 ==>
    #endregion

    #region Question 32 ==>
    #endregion
    #region Question 33 ==>
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
            Console.WriteLine(list[0]);

            // 1 ==> (1,1)
            // 2 ==> (11,22)
            // 3 ==> (50,60) (◘)
            #endregion

            #region Answer07
            // 1 ==> private (◘)
            // 2 ==> public
            // 3 ==> internal
            // 4 ==> protected
            #endregion

            #region Answer08
            static void CheckSecurity(Isecurable securable) => Console.WriteLine(securable.SecurityToken); //#2
            var page = new MainPage();
            //CheckSecurity(page);
            // does not implement interface member 'Isecurable.SecurityToken'
            #endregion

            #region Answer09
            // 1 ==> Using an "out" keyword for a reference type method parameter is not allowed.
            // 2 ==> A "ref" method parameter acts both as input and output.
            // 3 ==> In order to call a method with "out" / "ref" parameters, one should explicity use respective keywords for passed parameters.
            // 4 ==> Using a "ref" keyword for a reference type method parameter actually doesn't make any change in behavior.
            // 5 ==> A local variable passed as "ref" parameter of a method has to be initialized before the method call.
            // 6 ==> A class Field can passed as an "out" parameter of a method call.
            // 7 ==> A class Property can be passed as a "ref" parameter of a method call.
            #endregion

            #region Answer10
            IEnumerable<int> items = Foo();
            Console.Write("C");
            foreach (var item in items) Console.Write(item);
            static IEnumerable<int> Foo()
            {
                Console.Write("A");
                yield return 1;
                Console.Write("B");
                yield return 2;
            }
            // 1 ==> ABC12
            // 2 ==> A1B2C
            // 3 ==> CAB12
            // 4 ==> CA1B2 (◘)
            #endregion

            #region Answer11
            // 1 ==> Property (◘)
            // 2 ==> Field
            // 3 ==> Method (◘)
            // 4 ==> Event (◘)
            // 5 ==> Constructor
            #endregion

            #region Answer12
            // 1 ==> "var" is used instead of "object" data type
            // 2 ==> Exact type of variables declared with "var" keyword are resolved at run-time
            // 3 ==> "var" keyword cannot be used in method parameters
            // 4 ==> "var" cannot be used as data type when defining properties of a class
            #endregion

            #region Answer13
            Employee emp = new Employee { Name = "Nader" };
            Change(emp);
            Console.WriteLine(emp.Name);
            static void Change(Employee emp) => emp = new Employee { Name = "Mohsen" };
            // 1 ==> "Mohsen"
            // 2 ==> "Nader"
            // 3 ==> "This code has error(s) and does not compile" (◘)
            #endregion

            #region Answer14
            // 1 ==> Every delegate has a invocation list
            // 2 ==> When a delegate is invoked all subscribed methods are called asynchronously
            // 3 ==> Events are based on delegates
            // 4 ==> Extension methods are based on delegates
            // 5 ==> Partial methods can always be used instead of delegates
            #endregion

            #region Answer15
            GlobalVaraiable<int>.Value = 100;
            GlobalVaraiable<string>.Value = 200;
            Console.WriteLine(GlobalVaraiable<int>.Value);
            Console.WriteLine(GlobalVaraiable<string>.Value);
            // 1 ==> 100,200 (◘)
            // 2 ==> 100,100
            // 3 ==> 200,200
            // 4 ==> Code does not compile!
            #endregion

            #region Answer16
            object obj = 12.6d;
            //Console.WriteLine(((int)obj).ToString());
            // InvalidCastException: Unable to cast object of type 'System.Double' to type 'System.Int32'
            // 1 ==> 12.6
            // 2 ==> 12
            // 3 ==> 13
            // 3 ==> This code will throw runtime exception (◘)
            #endregion

            #region Answer17
            try
            {
                throw new InvalidOperationException("Some Error");
                Console.WriteLine("It Works!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("ex is an InvalidOperationException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex also is an Exception");
            }
            finally
            {
                Console.WriteLine("Finally!");
            }
            // 1 ==>
            // It Works!
            // ex is an InvalidOperationException
            // ex also is an Exception
            // Finally!

            // 2 ==>
            // It Works!
            // ex is an InvalidOperationException
            // Finally!

            // 3 ==>
            // ex is an InvalidOperationException
            // ex also is an Exception
            // Finally!

            // 4 ==> (◘)
            // ex is an InvalidOperationException
            // Finally!

            // 5 ==>
            // It Works!
            // ex is an InvalidOperationException
            // ex also is an Exception

            #endregion

            #region Answer18
            // 1 ==> readonly
            // 1 ==> sealed
            // 1 ==> const
            // 1 ==> internal
            #endregion

            #region Answer19
            // 1 ==> throw;
            // 1 ==> re throw;
            // 1 ==> throw new ex();
            // 1 ==> throw mew Exception("My custom message",ex);
            // 1 ==> throw ex;
            #endregion

            #region Answer20
            // 1 ==> This is a class with Singleton pattern. (◘)
            // 2 ==> Constructors cannot be private
            // 3 ==> The access modifier of the class in internal.
            #endregion

            #region Answer21
            // 1 ==> It is not supported in C#.
            // 2 ==> It is only supported for reference types.
            // 3 ==> Operator overloading is supported via Extension Methods.
            // 4 ==> It is supported in C# via implementing a static operator function.
            #endregion

            #region Answer22
            // 1 ==> DefaultIfEmpty
            // 1 ==> Group ... into
            // 1 ==> Order By
            // 1 ==> Aggregate
            #endregion

            #region Answer23
            // 1 ==> Yes, using DllImportAttribute and static extern modifiers
            // 2 ==> Yes, using static classes and Reflection
            // 3 ==> Yes, using LINQ to object and extern keyword
            // 4 ==> No
            #endregion

            #region Answer24
            //Which od the following statements gets compiled without error(s)?

            // 1 ==>
            Parent p = new Parent();

            // 2 ==>
            Child c = new Child();

            // 3 ==>
            Parent p2;
            p = new GrandChild();
            Child c2 = (Child)p;
            #endregion

            #region Answer25

            #endregion

            #region Answer26

            #endregion

            #region Answer27

            #endregion

            #region Answer28

            #endregion

            #region Answer29

            #endregion

            #region Answer30

            #endregion

            #region Answer31

            #endregion

            Console.ReadKey();
        }
    }
}
