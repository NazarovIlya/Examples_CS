// Maximum around nine

Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
    int maxResult = arg1;
    if (arg2 > maxResult) maxResult = arg2;
    if (arg3 > maxResult) maxResult = arg3;
    return maxResult;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 1223;
int b2 = 232;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));
Console.WriteLine(max);