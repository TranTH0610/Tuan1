using System;
class Bai6
{
    public static int SolonNhat()
    {
        int max = 0;
        int a,b,c;
        Console.WriteLine("Nhap so nguyen a: ");
        a = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Nhap so nguyen b: ");
        b = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Nhap so nguyen c: ");
        c = int.Parse(Console.ReadLine() ?? string.Empty);
        if(a>max) max = a;
        if(b>a)  max = b;
        if (c>b)  max = c;
        return max;
    }
}