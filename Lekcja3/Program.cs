using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void zadanie1()
            {
                List<int> liczby = new List<int>();
                int podana, sum = 0, i = 0;
                while (sum <= 100)
                {
                    Console.WriteLine("Podaj liczbę");
                    podana = Convert.ToInt32(Console.ReadLine());
                    liczby.Add(podana);
                    i++;
                    sum = liczby.Sum();
                }
                Console.WriteLine("Suma wynosi: " + sum + " Dodałeś " + i + " liczb");
            }

            void zadanie2()
            {
                List<int> liczby = new List<int>();
                int podana = 0,suma = 0,i = 1;
                Console.WriteLine("Podaj ile liczb ma zostać zsumowanych");
                podana = Convert.ToInt32(Console.ReadLine());
                while (i<=podana)
                {
                    liczby.Add(i);
                    Console.WriteLine("i= " + i +"s= "+ suma);
                    suma = liczby.Sum();
                    Console.WriteLine(i);
                    i++;
                }
                Console.WriteLine("Suma = " + suma);
            }
            
            void zadanie3()
            {
                List<int> liczby = new List<int>();
                int podana = 0, suma = 0, i = 1;
                Console.WriteLine("Podaj liczbę");
                podana = Convert.ToInt32(Console.ReadLine());
                while (suma <= podana)
                {
                    i++;
                    liczby.Add(i);

                    suma = liczby.Sum();
                }
                Console.WriteLine("Aby uzyskać liczbę " + podana + " albo większą należy dodać " + i + " liczb poczynając od 1");
            }

            void zadanie4()
            {
                double ilosc = 100;
                double suma = 0, n = 0, x = 1 - 2;
                for(int j = 0; j <= ilosc; j++)
                {
                    n = Math.Pow(x, j) / (2 * j + 1);
                    suma += n;
                }
                suma *= 4;
                Console.WriteLine(suma);
            }

            void zadanie5()
            {
                double K = 10000; //Kwota początkowa
                double n = 12; // Liczba lat 
                double op = 0.05; // Oprocentowanie
                double Kn = K;
                double tymczasowa = 0;

                for (int i = 1; i <= n; i++)
                {
                    tymczasowa = Kn * (op / n);
                    Kn += tymczasowa;
                }
                Kn = Math.Round(Kn,2);
                Console.WriteLine($"Razem {Kn:c}");
            }

            void zadanie6()
            {
                Console.WriteLine("Którą liczbę ciągy Fibonacciego chcesz wyświetlić");
                int podana = Convert.ToInt32(Console.ReadLine());
                int prev = 0, next = 1, suma = 0;
                List<int> fibonacci = new List<int>();
                for ( int i = 1; i < podana; i++)
                {
                    suma = prev + next;
                    prev = next;
                    next = suma;
                    fibonacci.Add(suma);
                }
                int res = fibonacci.Last();
                Console.WriteLine($"F({podana}) = {res}");
            }

            void zadanie7()
            {
                Console.WriteLine("Podaj a");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj b");
                int b = Convert.ToInt32(Console.ReadLine());
                int suma = 1, i=0;
                while(i <b)
                {
                    suma *= c;
                    i++;
                }
                Console.WriteLine(suma);
            }

            void zadanie8()
            {
                double podana;
                do
                {
                    Console.WriteLine("Podaj liczbę 2<|x|<3");
                    podana = Convert.ToDouble(Console.ReadLine());
                } while (podana <= 2 || podana >= 3);

            }

            void zadanie9()
            {
                int podana, i = 0, test ;
                Console.WriteLine("Podaj liczbę całkowitą");
                podana = Convert.ToInt32(Console.ReadLine());
                do
                {
                    i++;
                    test = podana % i;
                    switch(test)
                    {
                        case 0:
                            Console.WriteLine(i);
                            break;
                        case 1:
                            break;
                    }
                } while (i!=podana);
            }

            void zadanie10()
            {
                Console.WriteLine("Zgadnij liczbę z zakresu 1-1000 podaną przez system");
                Random rand = new Random();
                int c = 0, b = 0, z;
                z = rand.Next(1, 1000);
                do
                {
                    c = Convert.ToInt32(Console.ReadLine());
                    b++;
                    if (c < z)
                    {
                        Console.WriteLine("Liczba musi być większa");
                    }
                    if (c > z)
                    {
                        Console.WriteLine("Liczba musi być mniejsza");
                    }
                } while (c != z);
                Console.WriteLine("Odgadłeś za: {0} razem", b);
            }
            int z_adania, a;

            for (a = 0; a < 11; a++)
            {
                Console.WriteLine($"{Environment.NewLine}Podaj nr. zadania od 1-10");
                z_adania = Convert.ToInt32(Console.ReadLine());
                switch (z_adania)
                {
                    case 1:
                        Console.Clear();
                        zadanie1();
                        break;
                    case 2:
                        Console.Clear();
                        zadanie2();
                        break;
                    case 3:
                        Console.Clear();
                        zadanie3();
                        break;
                    case 4:
                        Console.Clear();
                        zadanie4();
                        break;
                    case 5:
                        Console.Clear();
                        zadanie5();
                        break;
                    case 6:
                        Console.Clear();
                        zadanie6();
                        break;
                    case 7:
                        Console.Clear();
                        zadanie7();
                        break;
                    case 8:
                        Console.Clear();
                        zadanie8();
                        break;
                    case 9:
                        Console.Clear();
                        zadanie9();
                        break;
                    case 10:
                        Console.Clear();
                        zadanie10();
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Proszę o wybranie numeru zadania z zakresu 1 - 10");
                        break;
                }
            }
        }
    }
}
