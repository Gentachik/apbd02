
Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double Average(int[] arr)
{
    double averageValue = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        averageValue += arr[i];
    }
    return averageValue/arr.Length;
}

static int Max(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
            max = arr[i];
    }

    return max;
}