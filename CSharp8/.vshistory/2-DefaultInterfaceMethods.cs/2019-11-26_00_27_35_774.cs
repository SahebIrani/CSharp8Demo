using System;

// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/default-interface-methods-versions

namespace CSharp8
{
    public interface IShoppingCart
    {
        private static string defaultName = "default";
        public static void SetDefaultName(string name) => defaultName = name;

        void CalculateSubTotal() =>
            Console.WriteLine(value: $"This is the { defaultName } " +
                $"IShoppingCart implementation of CalculateSubTotal");
        void CalculateTotal();
    }

    public interface ISubTotal
    {
        void CalculateSubTotal()
        {
            Console.WriteLine($"This is the default ISubTotal implementation of CalculateSubTotal");
        }
    }

    public class ShoppingCart : IShoppingCart, ISubTotal
    {
        public void CalculateTotal()
        {
            Console.WriteLine("This is CalculateTotal in the ShoppingCart class");
        }
    }

    public class BetterShoppingCart : IShoppingCart
    {
        public void CalculateSubTotal()
        {
            Console.WriteLine("This is the BetterShoppingCart implementation of CalculateSubTotal");
        }
        //public BetterShoppingCart()
        //{
        //    IShoppingCart.SetDefaultName("DefaultBetterShoppingCart");
        //}

        public void CalculateTotal()
        {
            Console.WriteLine("This is CalculateTotal in the BetterShoppingCart class");
        }
    }
}
