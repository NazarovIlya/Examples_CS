// find maximum / array

Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
    int maxResult = arg1;
    if (arg2 > maxResult) maxResult = arg2;
    if (arg3 > maxResult) maxResult = arg3;
    return maxResult;
}
int[] array = { 1000, 254, 36, 48960, 532, 656, 7543, 800, 90 };
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(max);