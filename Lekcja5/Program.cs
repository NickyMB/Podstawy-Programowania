using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja5
{
    internal class Program
    {
        //Autor Mikołaj Bacior
        static int wprowadzona_li;
        static string pobrana;
        static bool wynik = false;
        static void Main(string[] args)
        {
            void zadanie1()//dodawanie i wypisywanie elementów do/z tablicy
            {
                int i = 0;
                Console.WriteLine("Dodaj liczbę całkowitą do tablicy");
                Console.WriteLine();
                int wielkosc = SprawdzenieLiczby("Podaj wielkość tablicy");
                int[] t1 = new int[wielkosc];
                do 
                {
                    t1[i] = SprawdzenieLiczby($"Podaj {i}"); //sprawdzanie czy użytkownik wpisał liczbę
                    i++;
                }while (i < t1.Length);
                Console.Write("Tablica t1: ");
                foreach(int x in t1)
                {
                    Console.Write(" "+x);
                }
            }

            void zadanie2()//przepisanie dodatnich elementów z tablicy t1 do t2
            {
                int i = 0,j=0;
                Console.WriteLine("Dodaj liczbę całkowitą do tablicy");
                Console.WriteLine();
                int wielkosc = SprawdzenieLiczby("Podaj wielkość tablicy");
                int[] t1 = new int[wielkosc];
                int[] t2 = new int[t1.Length];
                do
                {
                    t1[i] = SprawdzenieLiczby($"Podaj {i}"); //sprawdzanie czy użytkownik wpisał liczbę
                    i++;
                } while (i < t1.Length);
                Console.Write("Tablica t1: ");
                foreach (int x in t1)
                {
                    Console.Write(" " + x);
                    if(x>=0)
                    {
                        t2[j] = x;
                    }
                    else
                    {
                        t2[j] = 0;
                    }
                    j++;
                }
                Console.WriteLine();
                Console.Write("Tablica t2: ");
                foreach (int y in t2)
                {
                    Console.Write(" " + y);
                }
            }

            void zadanie3()//przepisanie ujemnych elementów z tablicy t1 do t2
            {
                int i = 0, j = 0;
                Console.WriteLine("Dodaj liczbę całkowitą do tablicy");
                Console.WriteLine();
                int wielkosc = SprawdzenieLiczby("Podaj wielkość tablicy");
                int[] t1 = new int[wielkosc];
                int[] t2 = new int[t1.Length];
                do
                {
                    t1[i] = SprawdzenieLiczby($"Podaj {i}"); //sprawdzanie czy użytkownik wpisał liczbę
                    i++;
                } while (i < t1.Length);
                Console.Write("Tablica t1: ");
                foreach (int x in t1)
                {
                    Console.Write(" " + x);
                    if (x < 0)
                    {
                        t2[j] = x;
                    }
                    else
                    {
                        continue;
                    }
                    j++;
                }
                Console.WriteLine();
                Console.Write("Tablica t2: ");
                foreach (int y in t2)
                {
                    Console.Write(" " + y);
                }
            }

            void zadanie4()//obliczanie średniej wartości elementów
            {
                int i = 0;
                Console.WriteLine("Dodaj liczbę całkowitą do tablicy");
                Console.WriteLine();
                int wielkosc = SprawdzenieLiczby("Podaj wielkość tablicy");
                int[] t1 = new int[wielkosc];
                int[] t2 = new int[t1.Length];
                do
                {
                    t1[i] = SprawdzenieLiczby($"Podaj {i}"); //sprawdzanie czy użytkownik wpisał liczbę
                    i++;
                } while (i < t1.Length);
                /*foreach (int x in t1)
                {
                    average += x;
                }
                average = average / t1.Length;*/
                Console.Write($"Średnia wielkość liczb tablicy t1: {t1.Average()}");
            }

            void zadanie5()//wyświetalnie najmniejszej i największej liczby
            {
                int i = 0;
                Console.WriteLine("Dodaj liczbę całkowitą do tablicy");
                Console.WriteLine();
                int wielkosc = SprawdzenieLiczby("Podaj wielkość tablicy");
                int[] t1 = new int[wielkosc];
                do
                {
                    t1[i] = SprawdzenieLiczby($"Podaj {i}"); //sprawdzanie czy użytkownik wpisał liczbę
                    i++;
                } while (i < t1.Length);
                Console.WriteLine($"Najmniejsza liczba tablicy t1: {t1.Min()}");
                Console.WriteLine($"Największa liczba tablicy t1: {t1.Max()}");
            }

            void zadanie6()//obliczanie sumy przekątnej
            {
                Console.WriteLine("Dodaj liczbę całkowitą do tablicy");
                int suma = 0, suma2 = 0;

                int height = 3, width = height;
                int[,] dane = new int[height, width];
                for(int i = 0; i < height; i++)
                {
                    for(int j = 0; j < width; j++)
                    {
                        dane[i, j] = SprawdzenieLiczby($"Podaj {i}{j}"); //sprawdzanie czy użytkownik wpisał liczbę
                    }
                }
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write($" {dane[i, j]}");
                        if (i == j)
                        {
                            suma += dane[i, j];
                        }
                    }
                    Console.WriteLine();
                }
                int q = 0;
                for (int j = width - 1; j >= 0; j -= 1)
                {
                    suma2 += dane[q, j];
                    q++;
                }
                Console.WriteLine($"Suma przekątej tablcy: {suma+suma2}");
            }

            void zadanie7()//Obracanie tablicy
            {
                Console.WriteLine("Dodaj liczbę całkowitą do tablicy");
                int width = 3, height = 2;
                int[,] dane = new int[height, width]; // tablica t1
                int[,] dane_o;
                dane_o = new int[width, height]; //tablica t2 odwrócone zmiene width i height w celu zapewnienia że tablica jest obrócona
                for (int i = 0; i < height; i++) //przypisanie danych do tablicy t1
                {
                    for (int j = 0; j < width; j++)
                    {
                        dane[i, j] = SprawdzenieLiczby($"Podaj {i}{j}"); //sprawdzanie czy użytkownik wpisał liczbę
                    }
                }
                for (int i = 0; i < height; i++) // obracanie tablicy t1 i przypisanie do t2
                {
                    for (int j = 0; j < width; j++)
                    {
                        dane_o[j, i] = dane[i, j];
                    }
                }
                Console.WriteLine("Tablica t1:"); //wyświetlanie tablicy t1
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write($" {dane[i, j]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Tablica t2:"); //wyświetlanie tablicy t2
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Console.Write($" {dane_o[i, j]}");
                    }
                    Console.WriteLine();
                }
            }

            void zadanie8()//sortowanie tablicy nie sort
            {
                int[] liczby = { 79, 86, 97, 43, 64, 25, 12, 22, 11, 7, 23, 5 };
                int n = liczby.Length;
                Console.WriteLine("Przed sortowaniem: ");
                for (int i = 0; i < n; ++i)
                    Console.Write(liczby[i] + " ");

                for (int i = 0; i < n - 1; i++)
                { 
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (liczby[j] > liczby[j + 1])
                        {
                            int temp = liczby[j];
                            liczby[j] = liczby[j + 1];
                            liczby[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Po sortowaniu: ");
                for (int i = 0; i < n; ++i)
                    Console.Write(liczby[i] + " ");
            }

            int SprawdzenieLiczby(string text) //sprawdzenie czy użytkownik wpisał liczbę
            {
                do //pętla wykonująca się do momentu aż użytkownik wpisze liczbę
                {
                    wynik = false;
                    Console.WriteLine(text);
                    pobrana = Console.ReadLine();
                } while (int.TryParse(pobrana, out wprowadzona_li) == false);
                return Convert.ToInt32(pobrana);
            }

            string z_adania;
            int a = 0;

            do
            {
                Console.WriteLine($"{Environment.NewLine}Podaj nr. zadania od 1-8");
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
                        Console.Write("Proszę o wybranie numeru zadania z zakresu 1 - 8");
                        Console.WriteLine();
                        break;
                }
                a++;
            } while (a <= 12);
        }
    }
}