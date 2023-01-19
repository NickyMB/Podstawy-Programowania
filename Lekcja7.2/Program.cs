using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja7
{
    public static class Funkcje
    {
        static public int Sumuj(int x)//suma liczb
        {
            int suma = 0;
            for (int i = 0; i <= x; i++)
            {
                suma += i;
            }
            return suma;
        }
        static public int sumuj_rek(int n,int a)//suma liczb rekurencyjnie
        {
            if (n == 1)
                return a;
            else
            return sumuj_rek(n-1,a+1)+a;
        }
        static public long Silnia(long n)//silnia
        {
            if (n == 1)
            { 
                return 1;
            }
            else
            {
                return Silnia(n-1)*n;
            }
        }
        static public int potega(int x, int a,int z)//potengowanie liczb
        {
            if (a <= 1)
                return x;
            else
                return potega(x*z, a-1,z);
        }
        static public double pole(int x)//pole koła
        {
            double pi = 3.14;
            return x * x * pi;
        }
        static public int pole(int x,int z)//pole kwadratu
        {
            return x*z;
        }
        static public double dzielenie(double x, double y)//dzielenie liczb zmiennoprzecinkowo
        {
            return x/y;
        }
        static public double dzielenie(int x, int y, int z)//dzielenie liczb stałoprzecinkowo
        {
            return x/y;
        }
    }
    internal class Program
    {
        static long sumka(int n)
        {
            int i;
            long s = 0;
            for(i = 0; i <= n;i++)
            {
                s += i;
            }
            return s;
        }
        
        static void Main(string[] args)
        {

            void zadanie1()//Sumowanie liczb w klasie Funkcje
            {
                int pobrana1 = SprawdzenieLiczby("Podaj do której liczby chcesz zsumować liczby");
                for (int k=1;k<= pobrana1; k++)
                {
                    Console.WriteLine(sumka(k));
                }
            }

            void zadanie2()//Sumowanie liczb klasą statyczną i metodą statyczną
            {
                int pobrana1 = SprawdzenieLiczby("Podaj do której liczby chcesz zsumować liczby");
                Console.WriteLine(Funkcje.Sumuj(pobrana1));
            }

            void zadanie3()//rekurencyjne sumowanie,silnia,potęga
            {
                int pobrana1 = SprawdzenieLiczby("Podaj ile liczb zsumować");
                Console.WriteLine(Funkcje.sumuj_rek(pobrana1,1));
                int pobrana2 = SprawdzenieLiczby("Podaj z jaiej liczby obliczyć silnie");
                Console.WriteLine(Funkcje.Silnia(pobrana2));
                int pobrana3 = SprawdzenieLiczby("Podaj liczbę potengowaną");
                int pobrana4 = SprawdzenieLiczby("Podaj potęge");
                Console.WriteLine(Funkcje.potega(pobrana3, pobrana4, pobrana3));
            }
            void zadanie4()//obliczanie wyrazu ciągu Fibonacciego
            {
                int podana = SprawdzenieLiczby("Którą liczbę ciągy Fibonacciego chcesz wyświetlić");
                int n = 0;
                int funFib(int x, int suma, int prev, int next)
                {
                    if (x == 1)
                    {
                        n++;
                        return suma;
                    }
                    else
                    {
                        n++;
                        return funFib(x-1, suma=prev + next, prev=next, next=suma);
                    }
                }
                Console.WriteLine($"F({podana}) = {funFib(podana,0,0,1)}");
                Console.WriteLine($"Funkcja została wywołana {n} razy");
            }

            void zadanie5()//przeciążona funkcja pola koła/kwadratu
            {
                int pobrana1 = SprawdzenieLiczby("Podaj promień koła");
                Console.WriteLine(Funkcje.pole(pobrana1));
                int pobrana2 = SprawdzenieLiczby("Podaj bok a kwadratu");
                int pobrana3 = SprawdzenieLiczby("Podaj bok b kwadratu");
                Console.WriteLine(Funkcje.pole(pobrana2,pobrana3));
            }

            void zadanie6()//przeciążona funkcja zwracająca wartość dzielenia stało i zmienno przecinkowo
            {
                int pobrana1 = SprawdzenieLiczby("Podaj liczbe a");
                int pobrana2 = SprawdzenieLiczby("Podaj liczbe b");
                Console.WriteLine("Wynik z dzielenia zmiennorzecinkowo: ");
                Console.WriteLine(Funkcje.dzielenie(pobrana1, pobrana2));
                Console.WriteLine("Wynik z dzielenia stałorzecinkowo: ");
                Console.WriteLine(Funkcje.dzielenie(pobrana1, pobrana2,1));
            }

            void zadanie7()//zamiana liczv miejscami
            {
                Console.WriteLine("Nie mam pojęcia na ten moment");
            }

            void zadanie8()//zwracanie podwojonej wartości argumentu oraz zwiększanie o jeden.
            {
                double zwiekszanie(int x)
                {
                    return x * 2 + 1;
                }
                int pobrana1 = SprawdzenieLiczby("Podaj liczbe");
                Console.WriteLine(zwiekszanie(pobrana1));
            }

            int SprawdzenieLiczby(string text) //sprawdzenie czy użytkownik wpisał liczbę
            {
                int wprowadzona_li;
                string pobrana;
                do //pętla wykonująca się do momentu aż użytkownik wpisze liczbę
                {
                    Console.WriteLine(text);
                    pobrana = Console.ReadLine();
                } while (int.TryParse(pobrana, out wprowadzona_li) == false);
                return Convert.ToInt32(pobrana);
            }

            string z_adania;
            int a = 0;

            do
            {
                Console.WriteLine($"{Environment.NewLine}Podaj nr. zadania od 1-9");
                z_adania = Console.ReadLine();
                switch (z_adania)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie1();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie2();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie3();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie4();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie5();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie6();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie7();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie8();
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Proszę o wybranie numeru zadania z zakresu 1 - 9");
                        Console.WriteLine();
                        break;
                }
                a++;
            } while (a <= 12);

        }
    }
}
