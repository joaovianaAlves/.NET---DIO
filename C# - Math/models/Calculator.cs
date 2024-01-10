namespace CSharpMath.models
{
    public class Calculator
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Division(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multipy(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Power(int x, int y)
        {
            double result = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {result}");
        }
    }
}