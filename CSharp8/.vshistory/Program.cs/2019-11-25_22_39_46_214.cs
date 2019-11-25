//using System;

// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8

using System;

namespace CSharp8
{
    class GlobalVariable<T>
    {
        public static object Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ISubTotal cart2 = new ShoppingCart();

            //cart2.CalculateSubTotal();

            //Console.WriteLine();

            //BetterShoppingCart cart = new BetterShoppingCart();

            //cart.CalculateSubTotal();

            //Console.WriteLine();

            //IndicesAndRangesDemo.Demo();

            //NullCoalescingAssignmentDemo.Demo();

            //◘◘◘◘

            GlobalVariable<int>.Value = 100;
            GlobalVariable<string>.Value = 200;

            Console.WriteLine(GlobalVariable<int>.Value);
            Console.WriteLine(GlobalVariable<string>.Value);




            Console.ReadLine();
        }
    }
}
