using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja8
{
    //Autor: Mikołaj Bacior
    internal class Program
    {
        //zadanie 1
        static List<double> Oceny = new List<double>();
        static void DodajOcene(double x)
        {
            Oceny.Add(x);
            Oceny.Sort();
        }
        static void ObliczSrednia()
        {
            Oceny.Remove(Oceny.First());
            Oceny.Remove(Oceny.Last());
            Console.WriteLine($"Ocena średnia {Oceny.Average()}");
        }
        //zadanie 2
        static Stack<String> kolory = new Stack<String>();
        static Stack<String> kolory_TMP = new Stack<String>();
        static void dodajKolor(string x)
        {
            kolory.Push(x);
        }
        static void firstandlast()
        {
            int a= 0;
           foreach(string x in kolory) 
            { 
                if(a==0|a==kolory.Count)
                {
                    a++;
                    dodajdotmp(x);
                }
                    a++;
            }
        }
        static void dodajdotmp(string x)
        {
            kolory_TMP.Push(x);
        }
        static void wyswietlTMP()
        {
            foreach(string x in kolory_TMP)
            {
                Console.WriteLine(x);
            }
        }

        //zadanie 3
        static Queue<String> Przychodnia = new Queue<string>();
        static Queue<String> PrzychodniaTMP = new Queue<string>();
        static void WyswietlZawartosc()
        {
            Console.WriteLine($"Kolejka posiada {Przychodnia.Count} elementy");
            Console.WriteLine("Zawartość Kolejki:");
            foreach (Object obj in Przychodnia)
                Console.WriteLine($"{obj}");
        }
        static void DodajOsobe(String osoba)
        {
            Console.WriteLine($"Dodano do kolejki: {osoba}");
            Przychodnia.Enqueue(osoba);
        }
        static void KtoNastepnyWkolejce()
        {
            Console.WriteLine($"Następny w kolejce to: {Przychodnia.First()}");
        }
        static void NastepnyDoLekarzaPROSZE()
        {
            Console.WriteLine($"Do lekarza wszedł: {Przychodnia.First()}");
            Przychodnia = new Queue<string>(Przychodnia.Where(x => x != Przychodnia.First()));
        }
        static void OpuscKolejke(String osoba)
        {
            Console.WriteLine($"{osoba} opuściła koleję");
            Przychodnia = new Queue<string>(Przychodnia.Where(x => x != osoba));
        }

        //zadanie 4
        static Queue<int> Stos = new Queue<int>();
        static void WyswietlZawartoscStosu()
        {
            Console.WriteLine($"Na stosie jest {Stos.Count} banktonów");
            Stos = new Queue<int>(Stos.OrderBy(q => q));
            Console.WriteLine("Oto jego zawartość:");
            foreach (Object obj in Stos)
                Console.WriteLine($"{obj}");
        }
        static void DodajBanknot(int banknot)
        {
            int l = 0;
            Console.WriteLine($"Przyjęto nowy banknot do dodania {banknot} zł");
            foreach(int i in Stos)
            {
                if(i<banknot)
                {
                    l++;
                }
            }
            Console.WriteLine($"Na stosie jest {l} elementów");
            Console.WriteLine($"Dodano banknot {banknot} zł do stosu");
            Stos.Enqueue(banknot);
            WyswietlZawartoscStosu();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            void zadanie1()
            {
                double i;
                Console.WriteLine("- OBLICZANIE OCENY SEMESTRALNEJ.");
                Console.WriteLine("   (Wpisz min. 3 oceny)");
                do
                {
                    i = SprawdzenieLiczby("Wpisz ocenę cząstkową (lub 0 - aby zakonczyć)");
                    if(i==0)
                    {
                        break;
                    }
                    else if(i<0|i>6)
                    {
                        continue;
                    }
                    else
                    {
                        DodajOcene(i);
                    }

                }while(i!=0);
                ObliczSrednia();
                Console.ReadKey();
                
            }

            void zadanie2()
            {
                Console.WriteLine("Wpisz kilka kolorów od najbardziej ulubionegeo do najbrzydszego");
                string i;
                do
                {
                    Console.WriteLine("Wpisz kolor (lub ENTER  - aby zakończyć)");
                    i = Console.ReadLine();
                    if (i == "")
                        break;
                    else
                        dodajKolor(i);
                } while (true);
                firstandlast();
                wyswietlTMP();
                Console.ReadKey();
            }

            void zadanie3()
            {
                DodajOsobe("Andy");
                DodajOsobe("Kasia");
                DodajOsobe("Julka");
                DodajOsobe("Szymon");
                WyswietlZawartosc();
                Console.ReadKey();
                OpuscKolejke("Kasia");
                WyswietlZawartosc();
                Console.ReadKey();
                KtoNastepnyWkolejce();
                Console.ReadKey();
                NastepnyDoLekarzaPROSZE();
                WyswietlZawartosc();
                KtoNastepnyWkolejce();
                NastepnyDoLekarzaPROSZE();
                DodajOsobe("Werka");
                WyswietlZawartosc();
                NastepnyDoLekarzaPROSZE();
                NastepnyDoLekarzaPROSZE();
                Console.ReadKey();
                WyswietlZawartosc();
                Console.ReadKey();
            }

            void zadanie4()
            {
                DodajBanknot(50);
                DodajBanknot(100);
                DodajBanknot(10);
                DodajBanknot(20);
                DodajBanknot(200);
            }


            double SprawdzenieLiczby(string text) //sprawdzenie czy użytkownik wpisał liczbę
            {
                double wprowadzona_li;
                string pobrana;
                do //pętla wykonująca się do momentu aż użytkownik wpisze liczbę
                {
                    Console.WriteLine(text);
                    pobrana = Console.ReadLine();
                } while (double.TryParse(pobrana, out wprowadzona_li) == false);
                return Convert.ToInt32(pobrana);
            }

            string z_adania;
            int a = 0;

            do
            {
                Console.Clear();
                Console.WriteLine($"{Environment.NewLine}Podaj nr. zadania od 1-4");
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
                    default:
                        Console.Clear();
                        Console.Write("Proszę o wybranie numeru zadania z zakresu 1 - 4");
                        Console.WriteLine();
                        break;
                }
                a++;
            } while (a <= 3);
        }
    }
}
