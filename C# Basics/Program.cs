using Teste.models;
//---------Switch case---------

// Console.WriteLine("Digite uma letra dentre A-E");
// string letra = Console.ReadLine().ToLower();

// switch (letra)
// {
//     case "a":
//         Console.WriteLine("Vogal");
//         break;
//     case "b":
//     case "c":
//     case "d":
//         Console.WriteLine("Consoante");
//         break;
//     case "e":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Digite uma letra");
//         break;
// }

//---------If else---------

// int saldo = 2;
// int preco = 5;
// int qtdProduto = 1;

// if (qtdProduto == 0) // 1° Verificacao
// {
//     Console.WriteLine("Produto sem estoque");
// }
// else if (saldo >= preco) // 2° Verificacao
// {
//     Console.WriteLine("Venda realizada.");
// }
// else // 3° Verificacao
// {
//     Console.WriteLine("Saldo insuficiente");
// }

// Console.WriteLine($"Saldo atual: {saldo}, Preco do produto: {preco}, Quantidade Disponivel: {qtdProduto}");

//---------Operators Priority---------

// int a = 4 / 2 + 2; //A prioridade sera sempre divisao ou multiplicao
// int b = 4 / (2 + 2); //A prioridade sera a soma pois definimos a prioridade de execucao com "()"

// Console.WriteLine(a);
// Console.WriteLine(b);

//---------Cast---------

//Forma 1: Convert

// int a = Convert.ToInt32("5");
// int b = Convert.ToInt32(null); //Convert converte tipo null para 0
// double c = Convert.ToInt32(13.4);

// //Forma 2: Parse

// int f = int.Parse("5");
// int c1 = int.Parse(null); //Parse não converte tipo null
// decimal g = decimal.ToInt32(15.2M);

// //Forma 3: ToString

// int inteiro = 5;
// string texto = inteiro.ToString() + " I am a string now"; //ToString convert para string

// Console.WriteLine(texto);

//---------Operators---------

// int a = 20;
// int b = 10;

// int c = a + b;

// c += 5;
// //35
// c -= 10;
// //25
// Console.WriteLine(c);

//---------Atributtes---------

// DateTime dataAtual = DateTime.Now;

// string name = "joao";
// name = "João Vitor";

// double height = 1.71;
// decimal networth = 2.20M;
// bool marrige = true;

// Console.WriteLine(dataAtual);
// Console.WriteLine($"Nome: {name}.");
// Console.WriteLine($"Altura: {height}.");
// Console.WriteLine($"Renda: {networth}k.");
// Console.WriteLine($"Casado: {marrige}");

// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "João";
// pessoa.Idade = 19;
// pessoa.Apresentar();
