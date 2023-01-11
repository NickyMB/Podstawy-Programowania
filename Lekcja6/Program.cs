using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lekcja6
{
    internal class Program
    {
        //Autor Mikołaj Bacior
        static void Main(string[] args)
        {
            void zadanie1() //szukanie imienia w tablicy
            {
                int height = 2, width = 2;
                string[,] dane;
                dane = new string[height, width];
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if(j==0)
                        {
                            Console.WriteLine();
                            Console.Write("Podaj Imię: ");
                            dane[i, j] = Console.ReadLine();
                        }
                        else if(j==1)
                        {
                            Console.WriteLine();
                            Console.Write("Podaj Nazwisko: ");
                            dane[i, j] = Console.ReadLine();
                        }
                    }
                }
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write($" {dane[i, j]}");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Sukanie imienia po nazwisku");
                Console.Write("Podaj nazwisko: ");
                bool brak = true;
                string nazwisko = Console.ReadLine();
                string imie;
                for (int i = 0; i < height; i++)
                {
                    if (dane[i, 1] == nazwisko)
                    {
                        imie = dane[i, 0];
                        Console.WriteLine($"Imię którego szukasz to {imie}");
                        brak = false;
                    }
                }
                if (brak)
                {
                    Console.WriteLine($"Nazwisko którego szukasz nie istnieje w bazie");
                }
            }

            void zadanie2() //sypisywanie znaków w osobnych linijkach
            {
                Console.WriteLine("Wprowadź przykładowy text:");
                string text = Console.ReadLine();
                for(int i = 0; i<=text.Length-1;i++)
                {
                    Console.WriteLine(text[i]);
                }
            }

            void zadanie3() //wyraz wspak
            {
                Console.WriteLine("Wprowadź przykładowy text:");
                string text = Console.ReadLine();
                string text_wspak="";
                for(int i = text.Length-1; i>= 0; i--)
                {
                    text_wspak = string.Concat(text_wspak, text[i]);
                }
                Console.WriteLine(text_wspak);
            }

            void zadanie4() //eliminacja spacji
            {
                Console.WriteLine("Wprowadź przykładowy text ze spacjami:");
                string text = Console.ReadLine();
                Console.WriteLine(text.Replace(" ",""));
            }

            void zadanie5() //liczenie słów w texcie
            {
                /*Console.WriteLine("Wprowadź przykładowy text:");
                string text = Console.ReadLine();
                int suma = 1;
                for (int i = 0; i<=text.Length-1;i++)
                {
                    if (text[i] == ' ')
                    {
                        suma++;
                    }
                }
                Console.WriteLine($"Text posiada {suma + 1} słów");*/

                Console.WriteLine("Wprowadź przykładowy text:");
                string text = Console.ReadLine();
                int suma_Wyrazow = 0,charCouter=0;
                while (charCouter < text.Length && char.IsWhiteSpace(text[charCouter]))
                {
                    charCouter++;
                }
                while (charCouter < text.Length)
                {
                    while (charCouter < text.Length && !char.IsWhiteSpace(text[charCouter]))
                    { 
                        charCouter++; 
                    }

                    suma_Wyrazow++;

                    while (charCouter < text.Length && char.IsWhiteSpace(text[charCouter]))
                    { 
                        charCouter++; 
                    }
                }
                    Console.WriteLine($"Text posiada {suma_Wyrazow} słów");
            }

            void zadanie6()//wyciananie i wklejanie imienia i tworzenie inicjałów
            {
                string ImieINazwisko = "Jan Kowalski";
                string drugie_imie = "Marcin";
                string del1Name="";
                string inicjaly = "";
                string lonczone = ImieINazwisko.Insert(ImieINazwisko.IndexOf(" "), " "+drugie_imie);
                for(int i = 0; i<= lonczone.Length-1; i++) 
                {
                    if (lonczone[i]==' ')
                    {
                        del1Name = lonczone.Remove(0, i+1);
                        break;
                    }
                }

                for (int i = 0; i <= del1Name.Length - 1; i++)
                {
                    if (del1Name[i] == ' ')
                    {
                        inicjaly = String.Concat(del1Name.Remove(1, del1Name.Length-1), del1Name[i+1]);
                        break;
                    }
                }
                Console.WriteLine($"Imie i Nazwisko: {lonczone}");
                Console.WriteLine($"Drugie Imie: {drugie_imie}");
                Console.WriteLine($"Drugie Imie i Nazwisko: {del1Name}");
                Console.WriteLine($"Inicjały z drugiego Imienia i Nazwiska: {inicjaly}");
            }
            
            void zadanie7()//wycinanie daty
            {
                string todate(string name)
                {
                    int j = 0;
                    string rok="", miesiac="", dzien="";
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (Char.IsLetter(name[i]) || (name[i] == '-') ||(name[i] == ' '))
                        {
                            continue;
                        }
                        else if (j >= 0 & j <= 3)
                        {
                            rok = String.Concat(rok, name[i]);
                            j++;
                        }
                        else if (j >= 4 & j <= 5)
                        {
                            miesiac = String.Concat(miesiac, name[i]);
                            j++;
                        }
                        else if (j >= 6 & j <= 7)
                        {
                            dzien = String.Concat(dzien, name[i]);
                            j++;
                        }
                    }
                    return String.Concat(dzien, "-", miesiac, "-", rok);
                }
                Console.WriteLine(todate("AA-1997-12-12-klej"));
                Console.WriteLine(todate("ZZZZZ-2004-11-23-farba"));
                Console.WriteLine(todate("BBBBBBB-2021-01-12-tapeta"));
            }

            void zadanie8()
            {
                string query = $"Cyryl Kwiecień {Environment.NewLine}ul. Mokra 1/9 {Environment.NewLine}Tychy 40-321";
                Console.WriteLine(query);
                Console.WriteLine("");
                string new_Query = query.Replace(Environment.NewLine, " ");
                Console.WriteLine(new_Query);

            }

            void zadanie9()
            {
                string text_1 = "Andrzej Andrzejewski";
                string text_2 = "AndRzej andrzejevski";
                string compared = "";
                if(text_1.Length >= text_2.Length)
                { 
                    for(int i = 0; i <= text_1.Length-1; i++)
                    {
                        if(i>=text_2.Length)
                        {
                            compared = String.Concat(compared, "?");
                        }
                        else
                        {
                            if (text_1[i] == text_2[i])
                            {
                                compared = String.Concat(compared, text_1[i]);
                            }
                            else
                            {
                                compared = String.Concat(compared, "?");
                            }
                        }
                    }
                }
                else if(text_1.Length < text_2.Length)
                { 
                    for(int i = 0; i <= text_2.Length-1; i++)
                    {
                        if (i >= text_1.Length)
                        {
                            compared = String.Concat(compared, "?");
                        }
                        else
                        {
                            if (text_1[i] == text_2[i])
                            {
                                compared = String.Concat(compared, text_1[i]);
                            }
                            else
                            {
                                compared = String.Concat(compared, "?");
                            }
                        }
                    }
                }
                else { Console.WriteLine("Error");}
                Console.WriteLine(compared);
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
                    case "9":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie9();
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
