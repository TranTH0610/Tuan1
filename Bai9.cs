using System;
class Bai9
{
    public static void MaxMin( out float max, out float min,
        float a,float b, float c)
    {
        max =a;
        min =a;
        if(b>max) max=b;
        if(c>max) max=c;

        if(b<min) min =b;
        if(c<min) min =c;
    }
}