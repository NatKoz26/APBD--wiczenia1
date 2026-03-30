using System;
namespace ProstaAplikacja
{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("witaj!");
            
            //Pierwsza funkcjonalność


            string imie = PobierzISprawdzImie();
            Console.WriteLine($"Cześć, {imie}!");
            

            int[] liczby = { 2, 4, 6, 8 };

            double srednia = CalculateAverage(liczby);

            Console.WriteLine($"Średnia wynosi: {srednia}");
            int max = CalculateMax(liczby);

            Console.WriteLine($"Maksymalna wartość: {max}");

            PytanieOPomysly(imie);
            
        }

        //funkcje sprawdzenia poprawności: nie chcemy cyfr w imieniu 
        static bool PoprawneImie(string imie)
        {
            foreach(char znak in imie)
            {
                if(!char.IsLetter(znak) && znak != '-' && znak != '\'')
                {return false;}

            }
            return !string.IsNullOrWhiteSpace(imie);
        }
         static string PobierzISprawdzImie()
        {
            while (true)
            {
                Console.Write("Podaj swoje imię: ");
                string imie = Console.ReadLine();

                if (PoprawneImie(imie))
                {
                    return imie;
                }

                Console.WriteLine("Błąd: imię nie może zawierać cyfr,znaków specjalnych, ani być puste. Spróbuj ponownie.\n");
            }
        }
        //pytanie o pomysl na te aplikacje 
        static void PytanieOPomysly(string imie)
        {
            Console.WriteLine("Nie mam pojecia co moze robic ta aplikacja, podasz mi prosze pomysl?");
            string pomysl = Console.ReadLine();
            string sciezka = "pomysly.txt";
            string wpis = $"{DateTime.Now} | {imie}: {pomysl}";

             try
            {
                File.AppendAllText(sciezka, wpis + Environment.NewLine);
                Console.WriteLine("Zapisano pomysł do pliku!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas zapisu: " + ex.Message);
            }
            
        }
        static double CalculateAverage(int[] values)
        {
            if (values == null || values.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta.");

            int suma = 0;

             foreach (int v in values)
            {
                 suma += v;
             }

            return (double)suma / values.Length;
        }
        static int CalculateMax(int[] values)
        {
             if (values == null || values.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta.");

            int max = values[0];

            foreach (int v in values)
                {
                if (v > max)
                    {
                     max = v;
                    }
                }

                return max;
        }   
               static int CalculateMin(int[] values)
        {
            
            if (values == null || values.Length == 0)
                throw new ArgumentException("Tablica nie może być pusta.");

            int min = values[0];

            foreach (int v in values)
            {
                if (v < min)
                {
                    min = v;
                }
            }

            return min;
        }
    }

    }