using System;
class bai1
{
    public static void HovaTen()
    {
        Console.WriteLine("Nhap Ho Ten: ");
        string Hoten = Console.ReadLine() ?? string.Empty;
        Console.WriteLine(Hoten);
    }
}