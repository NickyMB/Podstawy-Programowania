using System;

namespace HW
{
    class zad1
    {
        static void Main(string[] args)
        {
            //zdanie 1
            void zadanie1()
            {
                Console.WriteLine("Hello World! Jak masz na imie?");
                string imie;
                string wiek;
                int lat;
                imie = Console.ReadLine();
                Console.WriteLine("Witaj " + imie);
                Console.WriteLine("Ile masz lat");
                wiek = Console.ReadLine();
                lat = Convert.ToInt32(wiek);
                Console.WriteLine("Witaj " + imie + " masz " + lat + " lat ");
            }
            //zdanie 2
            void zadanie2()
            {
                float l1, l2, srednia;
                Console.WriteLine("Podaj pierwszą liczbę");
                l1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę");
                l2 = Convert.ToInt16(Console.ReadLine());
                srednia = (l1 + l2) / 2;
                Console.WriteLine("Średnia z liczb " + l1 + " i " + l2 + " = " + srednia);
            }
            //zadanie3 i zadanie4
            void zadanie3()
            {
                int[] array1 = new int[3];
                int a, b, c;
                Console.WriteLine("podaj liczbę a");
                a = Convert.ToInt32(Console.ReadLine());
                array1[0] = a;
                Console.WriteLine("podaj liczbę b");
                b = Convert.ToInt32(Console.ReadLine());
                array1[1] = b;
                Console.WriteLine("podaj liczbę c");
                c = Convert.ToInt32(Console.ReadLine());
                array1[2] = c;
                Array.Sort(array1);
                Console.WriteLine("Największą liczbą jest: " + array1[array1.Length - 1]);
            }
            //zadanie5
            void zadanie5()
            {
                int a, b, c;
                double delta, x1, x2;
                Console.WriteLine("podaj a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("podaj b");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("podaj c");
                c = Convert.ToInt32(Console.ReadLine());

                delta = Math.Pow(b, 2) - 4 * (a * c);

                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("Delta Wynosi " + delta + " Miejsca zerowe funkcji wynosza " + x1 + " oraz " + x2);
                }
                else if (delta < 0)
                {
                    Console.WriteLine("Delta Wynosi " + delta + " i nie ma miejsc zerowych ");
                }
                else if (delta == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine("Delta Wynosi " + delta + " i ma jeden pierwiastek " + x1);
                }
                else
                {
                    Console.WriteLine("BŁĄD");
                }

            }
            int z_adania, a;

            for (a = 0; a < 7; a++)
            {
                Console.WriteLine("Podaj nr. zadania");
                z_adania = Convert.ToInt32(Console.ReadLine());
                switch (z_adania)
                {
                    case 1:
                        zadanie1();
                        break;
                    case 2:
                        zadanie2();
                        break;
                    case 3:
                        zadanie3();
                        break;
                    case 4:
                        zadanie3();
                        break;
                    case 5:
                        zadanie5();
                        break;
                }
            }
        }
    }
}
