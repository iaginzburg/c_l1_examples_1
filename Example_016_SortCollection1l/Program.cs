 int[] arr = {1, 2, 4, 10, 9, 7, 3, 5, 2};
// Console.WriteLine(arr.Length);

void PrintArray ( int[] array){
int count = array.Length;
for (int i = 0; i < count; i++){
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

PrintArray(arr);

void SelectionSortMinToMax (int[] array){
    int minPosition;
for (int i = 0; i < array.Length-1; i++){
    minPosition = i;
    for (int j = i+1; j < array.Length; j++)
    {
        if (array[j]< array[minPosition ]) minPosition = j;
    }
    int temporary = array[i];
    array [i] = array[minPosition];
    array[minPosition] = temporary;

}
}
// SelectionSortMinToMax(arr);
// PrintArray(arr);

void SelectionSortMaxToMin (int[] array){
    int maxPosition;
for (int i = 0; i < array.Length-1; i++){
    maxPosition = i;
    for (int j = i+1; j < array.Length; j++)
    {
        if (array[j] > array[maxPosition]) maxPosition = j;
    }
    int temporary = array[i];
    array [i] = array[maxPosition];
    array[maxPosition] = temporary;

}
}

SelectionSortMaxToMin(arr);
PrintArray(arr);
SelectionSortMinToMax(arr);
PrintArray(arr);