using System;
class Bai7
{
    public static bool KiemtraNguyenTo( int n)
    {
        if(n<2) return false;
        if(n==2) return true;
        for(int i=2; i<=Math.Sqrt(n); i++)
        {
            if(n%i==0) return false;
        }
        return true;
    }
}