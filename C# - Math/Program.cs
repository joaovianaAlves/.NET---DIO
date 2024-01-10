using CSharpMath.models;

Calculator calc = new Calculator();

Console.WriteLine("Digite um valor para X");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor para Y");
int y = int.Parse(Console.ReadLine());

calc.Subtract(x, y);
calc.Multipy(x, y);
calc.Division(x, y);
calc.Sum(x, y);
calc.Power(x, y);