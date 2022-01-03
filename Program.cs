//Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
//Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
//рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



int[] FillArray(int N, int min, int max)  // создает N-элементный массив и заполняет случайными целыми числами из диапазона [min, max]. 
                                          //и возвращает созданный массив.
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)  // Выводит на экран  заданный  в качестве аргумента массив.
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();

}



int CountEvenNumbers(int[] arr) // считает и возвращает количество чётных чисел в заданном массиве
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}



int[] EvenNumbersFromArray(int[] arr)   // формирует новый массив из целых чётных чисел взятых из заданного массива. Возвращает новый массив.
{
    int[] newArray = new int[CountEvenNumbers(arr)];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            newArray[j] = arr[i];
            j++;
        }
    }
    return newArray;
}

int[] Array = FillArray(8, -100, 100);

PrintArray(Array);

int[] newArray = EvenNumbersFromArray(Array);

PrintArray(newArray);
