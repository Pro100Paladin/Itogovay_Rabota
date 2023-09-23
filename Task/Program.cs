Console.Clear();

Console.Write("введите кол-во элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine()!);
string[] array1 = new string[elementsCount];
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = Convert.ToString(Console.ReadLine()!);
}
string[] array2 = new string[array1.Length];
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
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);
