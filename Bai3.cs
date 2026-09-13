using System;
class Bai3
{
    public static int TinhHaiSoNguyen()
    {
        int kq = 0;
        Console.WriteLine("Nhap x: ");
        int x = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Nhap y: ");
        int y = int.Parse(Console.ReadLine() ?? string.Empty);
        kq = (int)Math.Pow(x, y);
        return kq;
    }
}