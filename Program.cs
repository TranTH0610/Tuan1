using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
class Program
{
    static void Main(string[] arg)
    {
        float a,b,c;
        Console.WriteLine("nhap so thuc a: ");
        a=float.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("nhap so thuc b: ");
        b=float.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("nhap so thuc c: ");
        c=float.Parse(Console.ReadLine() ?? string.Empty);
        float max, min;
        Bai9.MaxMin( out max, out min, a, b, c);
        Console.WriteLine("So lon nhat: " + max);
        Console.WriteLine("So nho nhat: " + min);
    }
}