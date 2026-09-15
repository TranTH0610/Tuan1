using System;
using System.Collections.Generic;
using System.Threading.Channels;
class Bai17
{
    int [,] A;
    int n,m;
    public Bai17(int n, int m)
    {
        this.n = n;
        this.m = m;
        A = new int[n,m];
    }
    public void TaoMang()
    {
        Random rd = new Random();
        for(int i= 0; i< n; i++)
        {
            for(int j =0; j<m; j++)
            {
                A[i,j]=rd.Next(10,101);
            }
        }
    }
    public int [] mangChan()
    {
        List<int> chan = new List<int>();
        for(int i=0; i<n; i++)
        {
            for(int j=0; j < m; j++)
            {
                if (A[i, j] % 2 == 0)
                {
                    chan.Add(A[i,j]);
                }
            }
        }
        return chan.ToArray();
    }
    public int [] mangLe()
    {
        List<int> Le = new List<int>();
        for(int i=0; i<n; i++)
        {
            for(int j=0; j < m; j++)
            {
                if (A[i, j] % 2 != 0)
                {
                    Le.Add(A[i,j]);
                }
            }
        }
        return Le.ToArray();
    }
    public void xuatmang()
    {
        for(int i =0; i < n; i++)
        {
            for(int j =0; j<m; j++)
            {
                Console.WriteLine(A[i,j]+" ");
            }
        }
        Console.WriteLine("-------------------------------------- ");
        int [] chan = mangChan();
         Console.WriteLine("Mang Chan:  ");
        for(int i =0; i < chan.Length; i++)
        {
        Console.WriteLine(chan[i]+" ");
        }
        Console.WriteLine("-------------------------------------- ");
        Console.WriteLine("Mang Le: ");
        int [] le = mangLe();
        for(int i =0; i < le.Length; i++)
        {
        Console.WriteLine(le[i]+" ");
        }

    }
}