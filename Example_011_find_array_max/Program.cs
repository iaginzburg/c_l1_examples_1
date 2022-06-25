int[] array = { 12, 0, 134, -10, -233, 12, 2, 201, 33 };

Console.WriteLine("введите значение элемента массива индекс которого необходимо найти");
int find = int.Parse(Console.ReadLine());

// int lenght = array.Length;
// Console.WriteLine(lenght);

int index = 0;
// int find = -233;

while (index < array.Length)
{
    if (array[index] == find)
    {
        Console.WriteLine("индекс искомого элемента массива " + index);// 
                                                                       //break;
    }
    index++;

}
