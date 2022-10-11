string[] massStr = new string[5] {"hello", "world", "Big", "Dog", "777"};
string[] newStr = new string[massStr.Length];
void NewArrayStr(string[] massStr, string[] newStr)
{
    int count = 0;
    for (int i = 0; i < massStr.Length; i++)
    {
    if(massStr[i].Length <= 3)
        {
        newStr[count] = massStr[i];
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
}
NewArrayStr(massStr, newStr);
Console.WriteLine("Начальный массив:");
PrintArray(massStr);
Console.WriteLine();
Console.WriteLine("Новый массив:");
PrintArray(newStr);