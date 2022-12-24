int[] array = RandomSortedArray();
int l = 0;
int r = array.Length - 1;
int m = 0;
int count = 0;
Console.WriteLine("n:");
int n = int.Parse(Console.ReadLine());

while (array[m] != n)
{
    m = (l + r) / 2;

    if (n < array[m]) r = m - 1;

    else if (n > array[m]) l = m + 1;

    count++;
}
Console.WriteLine($"Element position: {m}, element value: {n}, amount of operations {count}");    
    

    static int[] RandomSortedArray()
{
    Console.Write("amount of elements:");
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];
    var rnd = new Random();

    for (int i = 0; i <= arr.Length - 1; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }

    for (int i = 0; i < arr.Length; i++)
    {
        for (int k = 0; k < arr.Length - 1 - i; k++)
        {
            if (arr[k] > arr[k + 1])
            {
                int swap = arr[k];
                arr[k] = arr[k + 1];
                arr[k + 1] = swap;
            }
        }
    }
    Console.WriteLine($"Array: {String.Join(", ", arr)}");
    return arr;
}
   