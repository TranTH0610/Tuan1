using System;
class Bai14
{
    string Ten="";
    double luong;
    int vang;
    public void nhap()
    {
        Console.WriteLine("nhap ho ten nhan vien: ");
        Ten = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("nhap so luong: ");
        luong = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("nhap so buoi vang: ");
        vang = int.Parse(Console.ReadLine() ?? string.Empty);
    }
    public double tinhluong()
    {
        return luong - vang*100000;
    }
    public void xuat()
    {
        Console.WriteLine("Ten: " + Ten);
        Console.WriteLine("Luong: " + tinhluong());
        Console.WriteLine("vang: "+ vang);

    }
}