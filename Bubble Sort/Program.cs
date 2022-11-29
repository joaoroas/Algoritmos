int[] nums = new int[15]
{
    3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48
};


Console.WriteLine("Array desordenado");
ImprimirArray(nums);

Console.WriteLine("Array ordenado com bubble sort");
OdernarArrayBubbleSort(ref nums);
ImprimirArray(nums);

static void OdernarArrayBubbleSort(ref int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }

    }

}

static void ImprimirArray(int[] nums)
{
    for (var i = 0; i < nums.Length; i++)
    {
        Console.Write($"{nums[i]}, ");

    }
    Console.WriteLine();

}