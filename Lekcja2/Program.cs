using System;

namespace lekcja2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            void zadanie1()
            {
                //zadanie1
                double l1, l2;
                Console.WriteLine("/2^/3 czy /3^/2");
                l1 = Math.Pow(Math.Sqrt(2), Math.Sqrt(3));
                l2 = Math.Pow(Math.Sqrt(3), Math.Sqrt(2));
                if (l1 > l2)
                {
                    Console.WriteLine("Pierwsza liczba jest więsza");
                }
                else if (l1 < l2)
                {
                    Console.WriteLine("Druga liczba jest więsza");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            void zadanie2()
            {
                Console.WriteLine("Podaj rok do sprawdzenia");
                int rok = Convert.ToInt32(Console.ReadLine());
                if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
                {
                    Console.WriteLine("Rok " + rok + " jest przestępny");
                }
                else { Console.WriteLine("Rok " + rok + " nie jest przestępny"); }
            }

            void zadanie3()
            {
                int[] array1 = new int[3];
                int a, b, c;
                Console.WriteLine("Podaj liczbę");
                a = Convert.ToInt32(Console.ReadLine());
                array1[0] = a;
                Console.WriteLine("Podaj liczbę");
                b = Convert.ToInt32(Console.ReadLine());
                array1[1] = b;
                Console.WriteLine("Podaj liczbę");
                c = Convert.ToInt32(Console.ReadLine());
                array1[2] = c;
                Array.Sort(array1);
                if (a == b || b == c || c == a)
                {
                    Console.WriteLine("Wszystkie liczby są takie same, podaj inne");
                }
                else { Console.WriteLine("Środkową liczbą jest: " + array1[array1.Length - 2]); }
            }

            void zadanie4()
            {
                int[] array1 = new int[3];
                int a, b, c;
                Console.WriteLine("Podaj liczbę");
                a = Convert.ToInt32(Console.ReadLine());
                array1[0] = a;
                Console.WriteLine("Podaj liczbę");
                b = Convert.ToInt32(Console.ReadLine());
                array1[1] = b;
                Console.WriteLine("Podaj liczbę");
                c = Convert.ToInt32(Console.ReadLine());
                array1[2] = c;
                Console.WriteLine("Posortowane od najmniejszej");
                Array.Sort(array1);
                for (a = 0; a < array1.Length; a++)
                {
                    Console.WriteLine(array1[a]);
                }
            }

            void zadanie5()
            {
                char znak;
                int a, b, c=1;
                Console.WriteLine("Podaj pierwszą liczbę całkowitą dodatnią");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę całkowitą dodatnią");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Wybierz operacje");
                Console.WriteLine("'*' - mnozenie" + $"'/' - dzielenie ");
                Console.WriteLine("'+' - dodawanie" + $"'-' - odejmowanie ");
                Console.WriteLine("'^' - potegowanie" + $"'%' - dzielenie modulo ");

                znak = char.Parse(Console.ReadLine());

                switch (znak)
                {
                    case '*':
                        c = a * b;
                        Console.Write(a+" * "+b+" = "+c);
                        break;

                    case '/':
                        c = a / b;
                        Console.Write(a + " / " + b + " = " + c);
                        break;

                    case '+':
                        c = a + b;
                        Console.Write(a + " + " + b + " = " + c);
                        break;

                    case '-':
                        c = a - b;
                        Console.Write(a + " - " + b + " = " + c);
                        break;

                    case '^':
                        int d = a, e = b;
                        while (b != 0)
                        {
                            if ((b & 1) == 1)
                            {
                                c *= a;
                            }
                                a *= a;
                                b >>= 1;
                        }
                        Console.Write(d+" do potengi "+e+" = "+c);
                        break;
                    case '%':
                        c = a % b;
                        Console.Write(a+" modulo z "+b+" = "+c);
                        break;
                    default:
                        Console.WriteLine("Wprowadź poprawne dane");
                        zadanie5();
                        break;
                }
            }

            void zadanie6()
            {
                string liczba;
                int a,b,c,legth;
                Console.WriteLine("Podaj liczbę z zakresu 1-999");
                liczba = Console.ReadLine();
                legth = liczba.Length;
                switch (legth)
                {
                    case 1:
                        if(int.Parse(liczba) == 0)
                        {
                            Console.WriteLine("ERROR");
                            zadanie6();
                        }
                        else if((int.Parse(liczba) % 3 )== 0)
                        {
                            a = int.Parse(liczba)%3;
                            Console.WriteLine("Liczba " + liczba + " jest podzielna przez 3");
                        }
                        else { Console.WriteLine("Liczba " + liczba + " nie jest podzielna przez 3"); }
                        break;
                    case 2:
                        a = liczba[0];
                        b = liczba[1];
                        if((a+b)%3==0)
                        { 
                            Console.WriteLine("Liczba " + liczba + " jest podzielna przez 3");
                        }
                        else { Console.WriteLine("Liczba " + liczba + " nie jest podzielna przez 3"); }
                        break;
                    case 3:
                        a = liczba[0];
                        b = liczba[1];
                        c = liczba[2];
                        if ((a + b + c) % 3 == 0)
                        {
                            Console.WriteLine("Liczba " + liczba + " jest podzielna przez 3");
                        }
                        else { Console.WriteLine("Liczba " + liczba + " nie jest podzielna przez 3"); }
                        break;
                    default:
                        Console.Write("ERROR");
                        break;
                }
            }
            void zadanie7()
            {
                Console.WriteLine("Zgadnij liczbę z zakresu 1-20 podaną przez system");
                Random rand = new Random();
                int a=0, b=0,z;
                z = rand.Next(1,20);
                while (a!=z)
                {
                    //Console.WriteLine(z);
                    a = Convert.ToInt32(Console.ReadLine());
/*                    if(b !=0)
                    { 
                        Console.WriteLine("Podana liczba nie jest taka sama");
                    }*/
                    b++;
                    if(a<z)
                    {
                        Console.WriteLine("Liczba musi być większa");
                    }
                    if(a>z)
                    {
                        Console.WriteLine("Liczba musi być mniejsza");
                    }
                }
                Console.WriteLine("Odgadłeś za: {0} razem",b);
            }
            int z_adania, a;

            for (a = 0; a < 8; a++)
            {
                Console.WriteLine($"{Environment.NewLine}Podaj nr. zadania od 1-7");
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
                        zadanie4();
                        break;
                    case 5:
                        zadanie5();
                        break;
                    case 6:
                        zadanie6();
                        break;
                    case 7:
                        zadanie7();
                        break;
                    default:
                        Console.Write("Proszę o wybranie numeru zadania z zakresu 1 - 7");
                        break;
                }
            }
        }
    }
}