using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp22
{
    class Singleton
    {
        private static Singleton instance;
        private List<string> logMessages;

        // Prywatny konstruktor zapobiegający tworzeniu instancji klasy z zewnątrz.
        private Singleton()
        {
            logMessages = new List<string>();
        }

        // Metoda do uzyskania instancji klasy (Singleton).
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Metoda do rejestrowania komunikatów.
        public void Log(string message)
        {
            logMessages.Add($"{DateTime.Now}: {message}");
        }

        // Metoda do pobierania dziennika zarejestrowanych komunikatów.
        public void PrintLog()
        {
            foreach (var message in logMessages)
            {
                Console.WriteLine(message);
            }
        }
 
    }
}
