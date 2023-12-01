// Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}
PrintArray(array);

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int lastPosition = array.Length - i -1;
        int temporary = array[i];
        array[i] = array[lastPosition];
        array[lastPosition] = temporary;
    }
}

ReverseArray(array);
PrintArray(array);