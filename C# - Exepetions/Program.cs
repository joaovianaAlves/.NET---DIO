
using CSharpExepetions.models;

Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

int count = 0;

foreach (int number in pilha)
{
    count++;
    Console.WriteLine($"N°{count}: {number}");
}

count = 0;
Console.WriteLine($"Removendo elemento: {pilha.Pop()}"); // LIFO = LAST IN FIRST OUT
pilha.Push(12);

foreach (int number in pilha)
{
    count++;
    Console.WriteLine($"N°{count}: {number}");
}

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(8);
// fila.Enqueue(10);

// int count = 0;

// foreach (int number in fila)
// {
//     count++;
//     Console.WriteLine($"N°{count}: {number}");
// }

// count = 0;
// Console.WriteLine($"Removendo elemento: {fila.Dequeue()}"); // FIFO = FIRST IN FIRST OUT
// fila.Enqueue(12);

// foreach (int number in fila)
// {
//     count++;
//     Console.WriteLine($"N°{count}: {number}");
// }

// new ExemploExcecao().Metodo1();

// try
// {
//     string[] linhas = File.ReadAllLines("Folders/filesReading.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não Encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Caminho do arquivo não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção generica: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Arquivo ok");
// }