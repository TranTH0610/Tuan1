using System;
class Bai12
{
    public static void XuLy(string s)
    {
        Console.WriteLine("chuoi thuong: " + s.ToLower());
        Console.WriteLine("chuoi in hoa: " + s.ToUpper());
        string [] mangTu = s.Split(
            new char[] {' '},StringSplitOptions.RemoveEmptyEntries
        );
        Console.WriteLine("dem chuoi: " + mangTu.Length);
    }
}