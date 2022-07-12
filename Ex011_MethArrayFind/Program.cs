
int[] array = { 100, 265, 300, 14, 54, 664, 75, 80, 90 };

int n = array.Length;
int find = 664;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        // break;
    }
    index++;
}
