using System;
class Bai8
{
    public static void HoanVi(ref int a, ref int b)
    {
        int temp =a;
        a=b;
        b=temp;
    }
}