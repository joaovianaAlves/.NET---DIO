using CSharpEspecialTypes.models;
using Newtonsoft.Json;

int num = 20;
bool par = false;

par = num.EhPar();

string result = $"{num} e {(par ? "par" : "impar")}";
Console.WriteLine(result);
// Array<int> arrayInteiro = new Array<int>();

// arrayInteiro.AdicionarElementoArray(30);
// arrayInteiro.AdicionarElementoArray(20);

// Console.WriteLine(arrayInteiro[0]);

// Array<string> arrayString = new Array<string>();

// arrayString.AdicionarElementoArray("Teste");
// arrayString.AdicionarElementoArray("Teste2");

// Console.WriteLine(arrayString[0]);

// dynamic tipoDinamica = 4;
// dynamic tipoDinamica2 = true;
// dynamic tipoDinamica3 = "string";

// Console.WriteLine($"Tipo da variavel: {tipoDinamica.GetType()}, Valor:{tipoDinamica}");
// Console.WriteLine($"Tipo da variavel: {tipoDinamica2.GetType()}, Valor:{tipoDinamica2}");
// Console.WriteLine($"Tipo da variavel: {tipoDinamica3.GetType()}, Valor:{tipoDinamica3}");

// string conteudoJson = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoJson);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach (var item in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {item.Produto}, Preço: {item.Preco}");
// }

// var tipoAnonimo = new { Nome = "João", Sobrenome = "Viana", Altura = 1.80 };

// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Nome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Nome: {tipoAnonimo.Altura}");

// string conteudoJson = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoJson);

// foreach (Venda venda in listaVenda)
// {
//     var desconto = venda.Desconto ?? 0m; // ?? = Operador de União Nula: Retorna o valor à esquerda, se não for nulo; caso contrário, retorna o valor à direita.
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}," +
//                       $"Data: {venda.DataVenda}, Desconto: {desconto}%");
//}

// DateTime dataVenda = DateTime.Now;
// List<Venda> listaVenda = new List<Venda>();

// Venda v1 = new Venda(1, "Material", 25.00M, dataVenda);
// Venda v2 = new Venda(2, "Material", 50.00M, dataVenda);

// listaVenda.Add(v1);
// listaVenda.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);