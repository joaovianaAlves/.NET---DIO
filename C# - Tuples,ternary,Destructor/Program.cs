using CSharpTuples;
using CSharpTuples.models;

int num = 20;
bool isOdd = false;

isOdd = num % 2 == 0;
string result = isOdd ? $"{num}:Even" : $"{num}:Odd";
Console.WriteLine(result);

// if (num % 2 == 0)
// {
//     Console.WriteLine($"O numero: {num} e par");
//     Console.Clear();
// }
// else
// {
//     Console.WriteLine($"O numero: {num} e impar");
// }

// Pessoa p1 = new Pessoa("João", "Vitor");

// (string name, string lastname) = p1;

// Console.WriteLine(name + lastname);

// ReadingFile file = new ReadingFile();
// //_ = DESCARTE DE INFOS
// var (sucess, lineFile, _) = file.ReadFile("file.txt");

// if (sucess)
// {
//     //Console.WriteLine($"File Lines: {linesQtd}\n");
//     foreach (string line in lineFile)
//     {
//         Console.WriteLine(line);
//     }
// }
// (int Id, string Name, string LastName, bool Alive) tupla = (1, "João", "Vitor", true);
// ValueTuple<int, string, string, bool> otherTupleType = (2, "Edna", "Viana", true);
// var tupleCreate = Tuple.Create(3, "Jose", "Antonio", true);

// Console.WriteLine("Normal tuple () = ()");
// Console.WriteLine($"Id: {tupla.Id}\n" +
//                   $"Name: {tupla.Name}\n" +
//                   $"LastName: {tupla.LastName}\n" +
//                   $"Alive: {tupla.Alive}\n");

// Console.WriteLine("ValueTuple<> = ()");
// Console.WriteLine($"Id: {otherTupleType.Item1}\n" +
//                   $"Name: {otherTupleType.Item2}\n" +
//                   $"LastName: {otherTupleType.Item3}\n" +
//                   $"Alive: {otherTupleType.Item4}\n");

// Console.WriteLine("Tuple.Create = ()");
// Console.WriteLine($"Id: {tupleCreate.Item1}\n" +
//                   $"Name: {tupleCreate.Item2}\n" +
//                   $"LastName: {tupleCreate.Item3}\n" +
//                   $"Alive: {tupleCreate.Item4}\n");