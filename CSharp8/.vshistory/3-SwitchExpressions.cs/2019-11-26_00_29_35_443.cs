using System;

namespace CSharp8
{
    public static class SwitchExpressions
    {
        public static double DoMath(double x, double y, MathType math)
        {
            double output = 0;

            output = math switch // Switch Expression
            {
                MathType.Add => x + y,
                MathType.Subtract => x - y,
                MathType.Multiply => x * y,
                MathType.Divide => x / y,
                _ => throw new Exception("Bad info passed in")
            };

            switch (math) // Switch Statement
            {
                case MathType.Add:
                    output = x + y;
                    break;
                case MathType.Subtract:
                    output = x - y;
                    break;
                case MathType.Multiply:
                    output = x * y;
                    break;
                case MathType.Divide:
                    output = x / y;
                    break;
                default:
                    throw new Exception("Bad info passed in");
            }

            return output;
        }
    }

    public enum MathType
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}
