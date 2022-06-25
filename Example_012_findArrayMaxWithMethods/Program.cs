void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);

        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
    Console.WriteLine();
}

int FindIndexOfElement(int[] collect, int find)
{
    int index = 0;
    while (index < collect.Length)
    {
        if (collect[index] == find)
        {
            Console.WriteLine("индекс искомого элемента массива " + index);
            break;
        }
        index++;
    }
    if (index == collect.Length)
    {
        Console.WriteLine("в массиве отсутствует элемент с заданным значением ");
        return -1;
    }
;
    return index;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
// FindIndexOfElement(array, 37);
Console.WriteLine(FindIndexOfElement(array, 37));
