using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Collections.Generic;

class Bai15
{
    List<int> a = new List<int>();
    public void nhapmang()
    {
        int n;
        Console.WriteLine("nhap so phan tu: ");
        n = int.Parse(Console.ReadLine() ?? string.Empty);
        for(int i=0; i < n; i++)
        {
            a.Add(int.Parse(Console.ReadLine() ?? string.Empty));
        }
    }
    public void xuatmang()
    {
        for(int i=0; i<a.Count; i++)
        {
            Console.WriteLine(a[i] + " ");
        }
        Console.WriteLine("max cua mang: "+TimMax());
        Console.WriteLine("min cua mang: "+TimMin());
        int[] nguyenTo = MangNguyenTo();

        Console.Write("Mang so nguyen to: ");
        for(int i =0; i<nguyenTo.Length; i++)
        {
            Console.WriteLine(nguyenTo[i] + " ");
        }
        Console.WriteLine();
    }
    public int TimMax()
    {
        int max=a[0];
        for(int i=0; i<a.Count; i++)
        {
            if (a[i] > max)
            {
                max=a[i];
            }
        }
        return max;
    }
    public int TimMin()
    {
        int min=a[0];
        for(int i=0; i<a.Count; i++)
        {
            if (a[i] < min)
            {
                min=a[i];
            }
        }
        return min;
    }
    public bool SoNguyenTo(int n)
    {
        if(n<2) return false;
        if(n==2) return true;
        for(int i=2; i <= Math.Sqrt(n); i++)
        {
            if(n%i==0)
            return false;
        }
        return true;
    }
    public int [] MangNguyenTo()
    {
        List<int> Ketqua = new List<int>();
        for(int i=0; i < a.Count; i++)
        {
            if (SoNguyenTo(a[i]))
            {
                Ketqua.Add(a[i]);
            }
        }
        return Ketqua.ToArray();
    }
}