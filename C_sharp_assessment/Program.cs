// Написать программу,которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте исключительно массивами.

// // ["hello", "2","world", ":-)"] -> ["2", ":-)"]

string[] StringArray1 = new string[5];
string [] StringArray2 = new string[StringArray1.Length];
void SecondArray(string[] StringArray1, string[] StringArray2)
{
    int count =0 ;
for (int i = 0; i < StringArray1.Length; i++)
{
    if (StringArray1.Length <= 3)
    {
      StringArray2[count] = StringArray1[i];
      count++;
      }
   }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(StringArray1, StringArray2);
PrintArray(StringArray2);