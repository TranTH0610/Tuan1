using System;
using System.Data;
class Bai16
{
    List<string> Hoten = new List<string>();
    public void nhapmanghoten()
    {
        int n;
        Console.WriteLine("nhap so ho ten: ");
        n = int.Parse(Console.ReadLine() ?? string.Empty);
        for(int i =0; i<n; i++)
        {
            Hoten.Add(Console.ReadLine()??string.Empty);
        }
    }
    public void sapxep()
    {
       for(int i=0; i < Hoten.Count-1; i++)
        {
            for(int j = i + 1; j < Hoten.Count; j++)
            {
                string ten1 = Hoten[i].Substring(Hoten[i].LastIndexOf(' ')+1);
                string ten2 = Hoten[j].Substring(Hoten[j].LastIndexOf(' ')+1);
                if(string.Compare(ten1,ten2) >0)
                {
                    string temp = Hoten[i];
                    Hoten[i] = Hoten[j];
                    Hoten[j] = temp;
                }
            }
        }
    }
    public void xuatmanghoten()
    {
        for(int i=0; i< Hoten.Count; i++)
        {
            Console.WriteLine(Hoten[i]);
        }
    }
}