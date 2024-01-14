//-------Lists-------

List<string> stringList = ["SP", "BH", "MG"];

for (int counter = 0; counter < stringList.Count; counter++)
{
    Console.WriteLine($"Posição N°{counter}, Valor: {stringList[counter]}");
}

//-------Arrays-------

// int[] arrayInt = new int[3];
// arrayInt[0] = 72;
// arrayInt[1] = 23;
// arrayInt[2] = 69;

// int[] arrayInt2 = new int[arrayInt.Length * 2];
// Array.Copy(arrayInt, arrayInt2, arrayInt.Length);

// Array.Resize(ref arrayInt, arrayInt.Length * 2);

// arrayInt[3] = 81;
// arrayInt[4] = 31;
// arrayInt[5] = 64;

//Loop For
// Console.WriteLine("Loop For");
// for (int counter = 0; counter < arrayInt.Length; counter++)
// {
//     Console.WriteLine($"Posição N°{counter}, Valor: {arrayInt[counter]}");
// }

// //Loop Foreach
// Console.WriteLine("Loop Foreach");
// int counterForeach = 0;
// foreach (int number in arrayInt)
// {
//     Console.WriteLine($"Posição N°{counterForeach}, Valor: {number}");
//     counterForeach++;
// }