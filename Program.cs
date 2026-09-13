using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
class Program
{
    static void Main(string[] arg)
    {
      Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine() ?? string.Empty;

        Bai12.XuLy(s);
    }
}