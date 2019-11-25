using System;

// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/default-interface-methods-versions

namespace CSharp8
{
    public interface IShoppingCart
    {
        private static string defaultName = "default";
        public static void SetDefaultName(string name) => defaultName = name;

        void CalculateTotal();

        void CalculateSubTotal() =>
            Console.WriteLine(value: $"This is the { defaultName } " +
                $"IShoppingCart implementation of CalculateSubTotal");
    }

    public interface ISubTotal
    {
        void CalculateSubTotal() =>
            Console.WriteLine($"This is the default ISubTotal implementation of CalculateSubTotal");
    }

    public class ShoppingCart : IShoppingCart, ISubTotal
    {
        public void CalculateTotal() =>
            Console.WriteLine("This is CalculateTotal in the ShoppingCart class");
    }

    public class BetterShoppingCart : IShoppingCart
    {
        public BetterShoppingCart() => IShoppingCart.SetDefaultName("DefaultBetterShoppingCart");

        public void CalculateSubTotal() =>
            Console.WriteLine("This is the BetterShoppingCart implementation of CalculateSubTotal");

        public void CalculateTotal() =>
            Console.WriteLine("This is CalculateTotal in the BetterShoppingCart class");
    }
}
