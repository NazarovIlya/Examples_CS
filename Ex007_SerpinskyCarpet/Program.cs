Console.Clear();

int xa = 1, ya = 30,
    xb = 1, yb = 1,
    xc = 100, yc = 30,
    xd = 100, yd = 1;
;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 4);
    if (what == 0)
    {
        x = (x + 2 * xa) / 3;
        y = (y + 2 * ya) / 3;
    }
    if (what == 1)
    {
        x = (x + 2 * xb) / 3;
        y = (y + 2 * yb) / 3;
    }
    if (what == 2)
    {
        x = (x + 2 * xc) / 3;
        y = (y + 2 * yc) / 3;
    }
    if (what == 3)
    {
        x = (x + 2 * xd) / 3;
        y = (y + 2 * yd) / 3;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}
Console.SetCursorPosition(xa, ya + 1);