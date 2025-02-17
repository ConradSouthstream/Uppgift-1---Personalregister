﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Uppgift_1___Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<person> Personalregister = new List<person>();

            Start:
            Console.WriteLine("Vad vill du göra?\nSkriv r för registrering\nSkriv p för presentering av register\nSkriv u för att gå ut");
            string order = Console.ReadLine();

            if (order == "r")
            {
                Console.WriteLine("Namn?:");
                string Nmn = Console.ReadLine();
                Console.WriteLine("Lön?:");
                int lon = int.Parse(Console.ReadLine());
                Personalregister.Add(new person(Nmn, lon));
                goto Start;
            }
            if (order == "p")
            {
                /* För att vara riktigt ärligt har jag ingen aning om vad jag har gjort.
                 * Jag imiterade metoden du demonstrerade för att göra en lista,
                 * Och sedan när jag väl ska försöka presentera listan så har jag ingen riktig aning.
                 * 
                 * Sedan skapar det här programmet inget permanent register vilket skulle behövas.
                 * såväl som att den skulle modifiera det permanenta registret också.
                 * Så jag ger mig en halv poäng.
                 */                
                Personalregister.ForEach(Console.WriteLine);
                goto Start;
            }

            if (order == "u")
            {
                Console.WriteLine("Tack och Hej!");
            }
            else
            {
                Console.WriteLine("ogiltigt kommando!");
                goto Start;
            }
        }
    }

    internal class person
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public person(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}