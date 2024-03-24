using ConsoleApp22;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Pobieranie instancji loggera.
        Singleton logger = Singleton.GetInstance();

        // Rejestrowanie kilku komunikatów.
        logger.Log("Uruchomienie programu.");
        Thread.Sleep(2000);
        logger.Log("Załadowanie komponentów.");

        Menu();

        void Menu()
        {
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1 - Otwórz dziennik aplikacji");
            Console.WriteLine("2 - Zakończ działanie aplikacji");
            string wybor = Console.ReadLine();
            switch (wybor)
            {
                case "1":
                    logger.Log("Wyświetlenie dziennika programu");
                    logger.PrintLog();
                    Menu();
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Nieprawidłowy wybór!!!!");
                    Menu();
                    break;
            }
        }     
    }
}