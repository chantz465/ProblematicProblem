using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
            class Program
            {
                    //Random rng = new Random();
                    bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");


            bool cont;
            var input = Console.ReadLine().ToLower();

            if (input == "yes")
            {
                cont = true;
            }
            else
            { cont = false;}
                Console.WriteLine();
                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is your age? ");
                string userAge1 = Console.ReadLine();
                    int userAge = Int32.Parse(userAge1);
                Console.WriteLine();
                Console.Write("Would you like to see the current list of activities? yes/no: ");
            bool seeList; 
                var inputForList = Console.ReadLine().ToLower();
                if (inputForList == "yes")
                { seeList = true; }
                else
                { seeList = false;}
                if (seeList)
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList;
                var inputForAdd = Console.ReadLine().ToLower();
                if (inputForAdd == "yes")
                { addToList = true; }
                else
                { addToList = false; }

                Console.WriteLine();
                    while (addToList)
                    {
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();
                        activities.Add(userAddition);
                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add more? yes/no: ");
                        //addToList = bool.Parse(Console.ReadLine());
                    var inputForAdd2 = Console.ReadLine().ToLower();
                    if (inputForAdd2 == "yes")
                    { addToList = true; }
                    else
                    { addToList = false; }
                }
                }

                while (cont)
                {
                    Console.Write("Connecting to the database");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                Console.WriteLine();
                            Console.Write("Choosing your random activity");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                Console.WriteLine();
                            int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];
                            if (userAge > 21 && randomActivity == "Wine Tasting")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                        Console.WriteLine("Pick something else!");
                        activities.Remove(randomActivity);
                        randomNumber = rng.Next(activities.Count);
                        randomActivity = $"activities[randomNumber]";
                    }
                Console.Write($"Ah got it! {randomActivity}, your random activity is: {userName}! Is this ok or do you want to grab another activity? yes/no: ");
                            Console.WriteLine();
                     //cont = bool.Parse(Console.ReadLine());
                var inputForAdd3 = Console.ReadLine().ToLower();
                if (inputForAdd3 == "yes")
                { cont = true; }
                else
                { cont = false; }
            }
        }
    }
}