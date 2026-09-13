using System;
class Bai5
{
    public static void MENU()
    {
        int n;
        float x=0,y=0;
        do{
        Console.WriteLine("1.Nhap 2 so thuc x y");
        Console.WriteLine("2.Tinh x^y");
        Console.WriteLine("3.Tinh can bac 2 cua x,y");
        Console.WriteLine("4.Thoat");
        Console.WriteLine("Chon chuc nang: ");
        n = int.Parse(Console.ReadLine() ?? string.Empty);
        switch(n){
            case 1:
            {
                Console.WriteLine("Nhap so x: ");
                x = float.Parse(Console.ReadLine() ?? string.Empty);
                Console.WriteLine("Nhap so y: ");
                y = float.Parse(Console.ReadLine() ?? string.Empty);
            }
            break;
            case 2:
                {
                  float kq =(float)Math.Pow(x,y);
                  Console.WriteLine("ket qua: "+kq); 
                }
                break;
            case 3:
                {
                    float a = (float)Math.Sqrt(x);
                    float b = (float)Math.Sqrt(y);
                    Console.WriteLine("can bac 2 cua x: "+a);
                    Console.WriteLine("can bac 2 cua y: "+b);
                }
                break;
            case 4:
                {
                   Console.WriteLine("thoat menu"); 
                }
                break;
                default:
                Console.WriteLine("ban da nhap sai!");
                break;
        }
        }while (n != 4);
    }

}