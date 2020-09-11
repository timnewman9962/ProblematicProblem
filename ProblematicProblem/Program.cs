
using System;
using System.Threading;
using System.Collections.Generic;

//ProblematicProblem
namespace ProblematicProblem
{
    //Program class  
    class Program 
    {
        //Random rng;
        static bool cont = true;
        //static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" }

        static void Main(string[] args)
        {
            Random rng = new Random();
            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
            //Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ")
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            //bool cont = bool.Parse(Console.ReadLine());
            //cont = bool.Parse(Console.ReadLine());
            cont = Console.ReadLine().ToLower().Contains('y');

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            //int userAge = Console.ReadLine();
            int userAge = Int32.Parse( Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            //bool seeList = bool.Parse(Console.ReadLine());
            bool seeList = Console.ReadLine().ToLower().Contains('u');

            if (seeList)
            {
                foreach (string activity in activities)
                {
                    //Console.Write($"{activity} ");
                    Console.Write($"\"{activity}\" ");
                    //Thread.Sleep(250);
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                //bool addToList = bool.Parse(Console.ReadLine());
                bool addToList = Console.ReadLine().ToLower().Contains('y');
                Console.WriteLine();

                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();

                    activities.Add(userAddition);

                    //foreach (string activity activities)
                    foreach (string activity in activities)
                    {
                        //Console.Write($"{activity} ");
                        Console.Write($"\"{activity}\" ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    //string addToList = bool.Parse(Console.ReadLine());
                    addToList = Console.ReadLine().ToLower().Contains('y');
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

                //Console.WriteLine()
                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                //Console.WriteLine()
                Console.WriteLine();

                int randomNumber = rng.Next(activities.Count);

                //string randomActivity = activities[randomNumber]
                string randomActivity = activities[randomNumber];

                //if (userAge > 21 && randomActivity == "Wine Tasting")
                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                    //string randomNumber = rng.Next(activities.Count);
                    randomNumber = rng.Next(activities.Count);

                    //string randomActivity = activities[randomNumber];
                    randomActivity = activities[randomNumber];
                }

                //Console.Write($"Ah got it! {randomActivity}, your random activity is: {userName}! Is this ok or do you want to grab another activity? Keep/Redo: ")
                //Console.Write($"Ah got it! {randomActivity}, your random activity is: {userName}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                //ConsoleWriteLine();
                Console.WriteLine();
                //bool cont = bool.Parse(Console.ReadLine());
                cont = Console.ReadLine().ToLower().Contains('r');
            }
        }
    }
}
