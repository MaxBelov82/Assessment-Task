// Написать программу,которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте исключительно массивами.

// ["hello", "2","world", ":-)"] -> ["2", ":-)"]

string[] StringArray1 = new string[] { "hello", "2", "world", ":-)" };
string[] StringArray2 = new string[StringArray1.Length];
void SecondArray(string[] StringArray1, string[] StringArray2)
{
    int count = 0;
    for (int i = 0; i < StringArray1.Length; i++)
    {
        if (StringArray1[i].Length <= 3)
        {
            StringArray2[count] = StringArray1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        {   
           if( i==0)
             Console.Write(array[i] + ","); 
             else   
                Console.Write(array[i]);
    }
    Console.Write("]");
}
SecondArray(StringArray1, StringArray2);
PrintArray(StringArray2);