using System;
class Bai4
{  public static bool SoNguyenTo(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
        public static int TinhHaiSoNguyen()
    {
        int kq = 0;
        Console.WriteLine("Nhap x: ");
        int x = int.Parse(Console.ReadLine() ?? string.Empty);
        // Bài 4
        if(!SoNguyenTo(x))
        {
            Console.WriteLine("x khong phai la so nguyen to");
            return kq;
        }
        Console.WriteLine("Nhap y: ");
        int y = int.Parse(Console.ReadLine() ?? string.Empty);
        if(!SoNguyenTo(y))
        {
            Console.WriteLine("y khong phai la so nguyen to");
            return kq;
        }
        if (SoNguyenTo(x) && SoNguyenTo(y))
        {
            kq = (int)Math.Pow(x, y);
        }
        return kq;
    }
}