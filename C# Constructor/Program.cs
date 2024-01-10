using System.Globalization;
using CsharpConstructor.models;

string dataString = "2012-04-17 18:41";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Data convertida com sucesso, Data:{data}");
}
else
{
    Console.WriteLine($"{dataString} não e uma data valida");
}

Console.WriteLine(data);

// decimal valor = 1234.25M;

// Console.WriteLine($"{valor:C}");

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// string num1 = "10";
// string num2 = "20";

// string resultado = num1 + num2;

// Console.WriteLine(resultado);

// Pessoa p1 = new Pessoa("joao vitor", "viana alves", 19);
// Pessoa p2 = new Pessoa("Alexandre", "Junior", 23);

// Curso cursoIngles = new Curso();
// cursoIngles.nome = "Ingles";
// cursoIngles.Alunos = new List<Pessoa>();

// cursoIngles.AdicionarAluno(p1);
// cursoIngles.AdicionarAluno(p2);
// cursoIngles.ListarAlunos();
