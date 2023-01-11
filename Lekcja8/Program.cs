using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja8
{
    internal class Program
    {
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

        static void Main(string[] args)
        {
            void zadanie1()
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

            void zadanie2()
            {
                Console.ReadKey();
            }

            string z_adania;
            int a = 0;

            do
            {
                Console.Clear();
                Console.WriteLine($"{Environment.NewLine}Podaj nr. zadania od 1-2");
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
                    default:
                        Console.Clear();
                        Console.Write("Proszę o wybranie numeru zadania z zakresu 1 - 2");
                        Console.WriteLine();
                        break;
                }
                a++;
            } while (a <= 3);
        }
    }
}
