// Erstellt von Klaus Barth Rochol
using System;

namespace SchereSteinPapier
{
    class Program
    {
        static void Main(string[] args)
        {
            string nochmal;
            
            do
            {
                Console.WriteLine("Lass uns Schere, Stein, Papier spielen!");
                
                // Spielereingabe
                string spielerZug;
                do
                {
                    Console.WriteLine("Gib deinen Zug ein (stein, papier oder schere): ");
                    spielerZug = Console.ReadLine().ToLower();
                } 
                while (spielerZug != "stein" && spielerZug != "papier" && spielerZug != "schere");
                
                // Computerzug
                string[] zuege = { "stein", "papier", "schere" };
                string computerZug = zuege[new Random().Next(3)];
                Console.WriteLine("Computer hat " + computerZug + " gespielt");
                
                // Gewinner bestimmen
                if (spielerZug == computerZug)
                {
                    Console.WriteLine("Es ist unentschieden!");
                }
                else if ((spielerZug == "stein" && computerZug == "schere") ||
                         (spielerZug == "papier" && computerZug == "stein") ||
                         (spielerZug == "schere" && computerZug == "papier"))
                {
                    Console.WriteLine("Du gewinnst!");
                }
                else
                {
                    Console.WriteLine("Computer gewinnt!");
                }
                
                // Nochmal spielen?
                do
                {
                    Console.WriteLine("\nNochmal spielen? (ja/nein): ");
                    nochmal = Console.ReadLine().ToLower();
                    
                    if (nochmal != "ja" && nochmal != "nein")
                    {
                        Console.WriteLine("Ungueltige Eingabe! Bitte nur 'ja' oder 'nein' eingeben.");
                    }
                } 
                while (nochmal != "ja" && nochmal != "nein");
                
                Console.WriteLine();
                
            } while (nochmal == "ja");
            
            Console.WriteLine("Danke fuers Spielen!");
        }
    }
}