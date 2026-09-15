using System;
class Bai13
{
    string masv ="";
    string Hoten="";
    string diachi="";
    int nam;
    public void nhap()
    {
        Console.WriteLine("nhap ma so sinh vien: ");
        masv = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("nhap ho ten sinh vien: ");
        Hoten = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("nhap dia chi sinh vien: ");
        diachi = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("nhap sinh vien nam : ");
        nam = int.Parse(Console.ReadLine() ?? string.Empty);
    }
    public void xuat()
    {
        Console.WriteLine("Msv: "+masv);
        Console.WriteLine("Ho va ten: "+Hoten);
        Console.WriteLine("Dia chi: "+diachi);
        Console.WriteLine("Hoc nam: "+nam);
    }
}