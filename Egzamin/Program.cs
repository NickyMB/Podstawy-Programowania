using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        czlowiek admin = new czlowiek();
        admin.a = 1;
        admin.b = 2;
        admin.c = 3;
        Console.WriteLine(admin.licz(admin.a, admin.b, admin.c).ToString());
        Console.ReadLine();
    }
}

class czlowiek
{
    public int a, b, c;
    public int wiek;

    public int licz(int a, int b, int c)
    {
        double d = a - b;
        d = Math.Pow((d - c) / a, b);
        return Convert.ToInt16(d / 16);
    }
}

