using System;
class Bai2
{
     public static void NhapHoVaTen()
    {
        Console.WriteLine("Nhap Ten: ");
        string hoten = Console.ReadLine() ?? string.Empty;
        Console.WriteLine(" Chao " + hoten);
    }
}