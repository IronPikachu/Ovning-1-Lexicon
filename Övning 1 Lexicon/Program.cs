/* Uppgift 1: Vilka klasser bör ingå i programmet?
 *          En klass, som heter Personal eller liknande
 * Uppgift 2: Vilka attribut och metoder bör ingå i klassen?
 *          Attribut: namn(för- och efternamn separat), lön (per år), register (Personal[])
 *          Metoder: skriv ut (allas) namn och lön, lägg till personal i register
 * Uppgift 3: Skriv programmet
 */
using System;

namespace Övning_1_Lexicon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var vänlig lägg till personal, separera förnamn, efternamn och årslön med mellanslag.");
            Console.WriteLine("Avsluta med att skriva \"skriv ut\"");
            bool loop = true;
            
            while (loop)
            {
                string input = Console.ReadLine();
                string[] command = input.Split(' ');
                if(command.Length == 2) //Kolla om det är "skriv ut", annars skräp
                {
                    if(input.ToUpper() == "SKRIV UT") //Rätt, vi skriver personal och avslutar
                    {
                        loop = false;
                        Personal.SkrivUtPersonal();
                    }
                    else //Användaren skrev 2 ord istället för 3 eller "skriv ut"
                    {
                        Console.WriteLine("För få ord");
                    }
                }
                else if(command.Length == 3) //Försök göra en Personal
                {
                    if(int.TryParse(command[2], out int salary)) //Kolla om lönen är ett tal
                    {
                        //Lyckat! Vi kan lägga in en personal
                        _ = new Personal(command[0], command[1], salary); //VS visade mig _
                    }
                    else //Lönen var inget tal
                    {
                        Console.WriteLine("Årslön måste vara ett heltal!");
                    }
                }
                else //Användaren förstod inte...
                {
                    Console.WriteLine("Separera förnamn, efternamn och årslön med mellanslag.");
                }

            }
            
        }
    }
}
