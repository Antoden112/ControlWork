string[] array1 = new string[] {"1234", "12567", "2", "-2", ":)", "Russia",  "hello", "Kazan", "world", "computer", "DVA"};
string[] array2 = new string[array1.Length];
Console.Write ("Задан массив: ");
Console.Write ("[");
WriteArray (array1);
Console.Write ("]");
Console.WriteLine ();
Console.Write ("Из него выбраны элементы длинной не более 3 символов: ");
SecondArrayWithIF(array1, array2);
WriteArray (array2);

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void WriteArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

