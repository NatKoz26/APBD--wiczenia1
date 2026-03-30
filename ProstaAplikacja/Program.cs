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

            
        }

        //funkcje sprawdzenia poprawności: nie chcemy cyfr w imieniu 
        static bool PoprawneImie(string imie)
        {
            foreach(char znak in imie)
            {
                if(char.IsDigit(znak))
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

                Console.WriteLine("Błąd: imię nie może zawierać cyfr. Spróbuj ponownie.\n");
            }
        }
    }

    
}