﻿//Autore Malzone Pietro 3H 11/10/2023 Compiti  per prof Molara11/10/2023 Es3
namespace ConsoleAppCompitiEs3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ore1, minuti1, secondi1, ore2, minuti2, secondi2, secondidifferenza, ora, minuti, secondi, tempoinsec1, tempoinsec2;

            Console.WriteLine("Inserisca i dati del primo orario");
            Console.WriteLine("Ore -->");
            ore1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Minuti -->");

            minuti1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Secondi -->");
            secondi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisca i dati del  orario");
            Console.WriteLine("Ore -->");
            ore2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Minuti -->");
            minuti2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Secondi -->");
            secondi2 = int.Parse(Console.ReadLine());

            tempoinsec1 = ((ore1 * 3600) + secondi1 + (minuti1 * 60));
            tempoinsec2 = (ore2 * 3600) + secondi2 + (minuti2 * 60);


            secondidifferenza = tempoinsec1 > tempoinsec2 ? tempoinsec1 - tempoinsec2 : tempoinsec2 - tempoinsec1;//operatore ternario
            
            
            /*if (tempoinsec1 > tempoinsec2)
            {
                secondidifferenza = tempoinsec1 - tempoinsec2;

            }
            else secondidifferenza = tempoinsec2 - tempoinsec1;
            */



            //secondidifferenza = Math.Abs(tempoinsec1 - tempoinsec2); // valore assoluto della differenza
            
            
            secondi = secondidifferenza % 60;

            minuti = (secondidifferenza - secondi) / 60;

            ora = (secondidifferenza - secondi) / 3600;

            if (minuti % 60 == 0)
            {
                minuti = 0;
            }

            Console.WriteLine($"La differenza è di {ora} ore {minuti} minuti e {secondi} secondi");

            Console.WriteLine("\n Premere un tasto per terminare il programma");
            Console.ReadLine();
        }
    }
}