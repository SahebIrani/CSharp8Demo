using System;
using System.Collections.Generic;

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator

namespace CSharp8
{
    public static class NullCoalescingAssignmentDemo
    {
        public static void Demo()
        {
            ListDemo example = new ListDemo();

            //if (example.LuckyNumbers == null) example.LuckyNumbers = new List<int>();

            example.LuckyNumbers ??= new List<int>();

            example.LuckyNumbers.Add(17);

            foreach (var item in example.LuckyNumbers) Console.WriteLine($"Lucky Number: { item }");
        }
    }

    public class ListDemo
    {
        public List<int> LuckyNumbers { get; set; }

        public ListDemo() => LuckyNumbers = new List<int> { 22 };
    }
}
