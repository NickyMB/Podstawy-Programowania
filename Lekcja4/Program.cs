using System;
using System.Collections.Generic;
using System.Linq;

namespace Lekcja4
{
    internal class Program
    {
        static int wprowadzona_li;
        static bool wynik = false;
        static void Main(string[] args)
        {
            void zadanie1()//Program, gdzie użytkownik wybiera jeden z dwóch wariantów zatrudnienia
            {
                char znak;
                string pobrana;
                int podana;
                double poczontek = 0.45, next = 0, prev = 0, suma = 0;
                sprawdzenie:
                do //pętla wykonująca się do momentu aż użytkownik wpisze poprawny text
                {
                    Console.Clear();
                    Console.WriteLine("Który wariant wybierasz, a czy b (b to 50 zł / h)");
                    pobrana = Console.ReadLine();
                    wynik = SprawdzenieTekstu(pobrana);
                } while (wynik != false);
                znak = Convert.ToChar(pobrana);
                if(znak!='a' && znak!='b')
                {
                    goto sprawdzenie;
                }
                switch (znak)
                {
                    case 'a':
                        do //pętla wykonująca się do momentu aż użytkownik wpisze liczbę
                        {
                            Console.Clear();
                            Console.WriteLine("Ile godzin");
                            pobrana = Console.ReadLine();
                            wynik=SprawdzenieLiczby(pobrana);
                        } while (wynik == false);
                        podana = Convert.ToInt32(pobrana);
                        switch (podana)
                        {
                            case 1:
                                prev = poczontek;
                                Console.WriteLine($"Do zapłaty {poczontek}");
                                break;
                            default:
                                for (int i = 1; i <= podana; i++)
                                {
                                    next = poczontek * 2;
                                    prev = poczontek;
                                    poczontek = next;
                                }
                                Console.WriteLine($"Do zapłaty {prev}");
                                break;
                        }
                        break;
                    case 'b':
                        Console.WriteLine("Ile godzin");
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Ile godzin");
                            pobrana = Console.ReadLine();
                            wynik = SprawdzenieLiczby(pobrana);
                        } while (wynik == false);
                        podana = Convert.ToInt32(pobrana);
                        suma = 50 * podana;
                        Console.WriteLine($"Do zapłaty {suma}");
                        break;
                }
            }
            void zadanie2() //Wyświetlanie ile jest możliwości wypłacenia 10 zł w monetach 1,2,5 zł
            {
                int kwota = 10; //kwota początkowa
                int ilosc_z1 = kwota / 1; //Ile razy pętla ma się wykonać dla 1zł
                int ilosc_z2 = kwota / 2; //Ile razy pętla ma się wykonać dla 2zł
                int ilosc_z5 = kwota / 5; //Ile razy pętla ma się wykonać dla 5zł
                int i = 0;
                for (int z1 = 0; z1 <= ilosc_z1; z1++)
                {
                    for (int z2 = 0; z2 <= ilosc_z2; z2++)
                    {
                        for (int z5 = 0; z5 <= ilosc_z5; z5++)
                        {
                            if (z1 * 1 + z2 * 2 + z5 * 5 == kwota)
                            {
                                Console.WriteLine($"jeden złoty = {z1} dwa złote = {z2} pięć złoty = {z5}");
                                i++;
                            }
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"{kwota:c} można wypłacić na: {i} sposobów używając monet jednozłotowych lub dwuzłotowych lub pięciozłotowych");
            }
            void zadanie3() //Ustalanie ile monet aby było ich po równo aby otrzymać 1000zł
            {
                int kwota = 1000;
                Console.WriteLine($"ile ma być monet jednozłotowych, dwuzłotowych i pięciozłotowych, aby ich suma dała kwotę {kwota:c} ");
                int ilosc_z1 = kwota / 1; //Ile razy pętla ma się wykonać dla 1zł
                int ilosc_z2 = kwota / 2; //Ile razy pętla ma się wykonać dla 2zł
                int ilosc_z5 = kwota / 5; //Ile razy pętla ma się wykonać dla 5zł
                for (int z1 = 0; z1 <= ilosc_z1; z1++)
                {
                    for (int z2 = 0; z2 <= ilosc_z2; z2++)
                    {
                        for (int z5 = 0; z5 <= ilosc_z5; z5++)
                        {
                            if (z1 * 1 + z2 * 2 + z5 * 5 == kwota)
                            {
                                if (z1 == z2 & z1 == z5)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"jeden złoty = {z1} dwa złote = {z2} pięć złoty = {z5}");
                                }
                            }
                        }
                    }
                }
            }
            void zadanie4() //Rysowanie piramidy opadającej
            {
                Console.WriteLine("");
                int height = 5;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height - i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }
            }
            void zadanie5() //Rysowanie piramidy rosnącej
            {
                Console.WriteLine("");
                int height = 5;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height - i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int l = 0; l <= i; l++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");

                }
            }
            void zadanie6() //Rysowanie pustego kwadratu z gwiazdek o ilości wierszy 4
            {
                Console.WriteLine();
                for (int x = 1; x <= 4; x++)//pion
                {
                    for (int y = 1; y <= 4; y++)//poziom
                    {
                        if (y == 1 || y == 4)
                        {
                            Console.Write("*");
                        }
                        else if (x == 1 || x == 4)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            void zadanie7() //Rysowanie pustego kwadratu z gwiazdek o ilości wierszy podajej przez uzytkownika
            {
                string pobrana;
                int podana;
                do //pętla wykonująca się do momentu aż użytkownik wpisze liczbę
                {
                    Console.Clear();
                    Console.WriteLine("Podaj liczbę wierszy");
                    pobrana = Console.ReadLine();
                    wynik = SprawdzenieLiczby(pobrana);
                } while (wynik == false);
                podana = Convert.ToInt32(pobrana);
                Console.WriteLine();
                for (int x = 1; x <= podana; x++)//pion
                {
                    for (int y = 1; y <= podana; y++)//poziom
                    {
                        if (y == 1 || y == podana)
                        {
                            Console.Write("*");
                        }
                        else if (x == 1 || x == podana)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            void zadanie8() //Sprawdzanie czy pierwsza
            {
                string pobrana;
                int podana;
                do //pętla wykonująca się do momentu aż użytkownik wpisze liczbę
                {
                    Console.Clear();
                    Console.WriteLine("Podaj liczbę a ja sprawdzę czy jest liczbą pierwszą");
                    pobrana = Console.ReadLine();
                    wynik = SprawdzenieLiczby(pobrana);
                } while (wynik == false);
                podana = Convert.ToInt32(pobrana);
                if(podana <= 1)
                {
                    Console.WriteLine("Podana liczba nie jest liczbą pierwszą");
                }
                else
                {
                for(int i=2;i<=podana;i++)
                {
                    if(podana%i==0)
                    {
                        if (podana==i)
                        {
                            Console.WriteLine("Podana liczba jest liczbą pierwszą");
                        }
                        else
                        {
                            Console.WriteLine("Podana liczba nie jest liczbą pierwszą");
                            break;
                        }
                    }
                }
                }
                /*for (int x = 1; x <= podana; x++)
                {
                    test = podana % x;
                    if (test == 0)
                    {
                        sprawdzenie++;
                    }
                }
                switch (sprawdzenie)
                {
                    case 2:
                        Console.WriteLine("Podana liczba jest liczbą pierwszą");
                        break;
                    default:
                        Console.WriteLine("Podana liczba nie jest liczbą pierwszą");
                        break;
                }*/
            }
            void zadanie9() //Obliczanie sumy liczb dodatnich z przedziału
            {
                int range_a = -100, range_b = 100, suma = 0;
                Console.WriteLine($"Suma liczb dodatnich z zakresu {range_a} do {range_b} wynosi:");
                for (int i = range_a; i <= range_b; i++)
                {
                    if (i%2!=0)
                    {
                        continue;
                    }
                    else
                    {
                        suma += i;
                    }
                }
                Console.WriteLine(suma);
            }
            void zadanie10() //Wyświetlanie liczb doskonałych z przedziału
            {
                Console.WriteLine("Liczby doskonałe to:");
                int zakres_b = 10000, suma;
                List<int> liczby = new List<int>();
                for (int i = 1; i <= zakres_b; i++)
                {
                    for (int j = 1; j <= zakres_b; j++)
                    {
                        if (i % j == 0 && i != j)
                        {
                            liczby.Add(j);
                        }
                        else if (j == zakres_b)
                        {
                            suma = liczby.Sum();
                            if (suma == i)
                            {
                                Console.WriteLine(i);
                            }
                            liczby.Clear();
                        }
                    }
                }
            }
            void Extra() //zadanie extra
            {
                double x1, x2, x3, f1, f2, f3;
                x1 = -1;
                do
                {
                    x2 = x1 + 0.05;
                    x3 = x2 + 0.05;
                    f1 = x1 * x1 * x1 - 5 * x1 * x1 + 3 * x1 + 3;
                    f2 = x2 * x2 * x2 - 5 * x2 * x2 + 3 * x2 + 3;
                    f3 = x3 * x3 * x3 - 5 * x3 * x3 + 3 * x3 + 3;
                    x1 += 0.05;
                } while (f1 < f2 & f2 < f3 | f1 > f2 & f2 > f3);
                Console.WriteLine($"x= {x1} f(x)={f2}");
            }
            bool SprawdzenieLiczby(string liczba) //sprawdzenie czy użytkownik wpisał liczbę
            {
                return int.TryParse(liczba, out wprowadzona_li);
            }
            bool SprawdzenieTekstu(string text) //sprawdzenie czy użytkownik wpisał text
            {
                return string.IsNullOrEmpty(text);
            }

            string z_adania;
            int a=0;

            do
            {
                Console.WriteLine($"{Environment.NewLine}Podaj nr. zadania od 1-10 lub e jako zadanie Extra");
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
                    case "9":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie9();
                        break;
                    case "10":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie10();
                        break;
                    case "e":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        Extra();
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Proszę o wybranie numeru zadania z zakresu 1 - 10 lub e jako zadanie Extra");
                        Console.WriteLine();
                        break;
                }
                a++;
            } while (a <= 12);
            }
        }
}