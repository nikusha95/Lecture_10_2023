int[] arr = { 1, 2, 6, 10, 12, 32, 32, 15, 32, 1, 1 };

int mx = arr.Max();

int[] counter = new int[mx + 1];

foreach (var i in arr)
{
    counter[i]++;
}

for (int i = 0; i < counter.Length; i++)
{
    if (counter[i] != 0)
    {
        Console.WriteLine($"element {i} occurence {counter[i]}");
    }
}