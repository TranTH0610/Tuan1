using System;
class Bai10
{
    public static bool KiemTraDoiXung(string s)
    {
        int dau = 0;
        int cuoi = s.Length-1;
        while (dau < cuoi)
        {
            if (s[dau] != s[cuoi])
            {
                return false;
            }
            dau++;
            cuoi--;
        }
        return true;
    }
}