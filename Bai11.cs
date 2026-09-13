using System;
class Bai11
{
    public static string NghichDao(string s)
    {
        string ketqua ="";
        for(int i = s.Length-1;i>=0; i--)
        {
            ketqua += s[i];
        }
        return ketqua;
    }
}