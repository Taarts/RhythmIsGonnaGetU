using System;
// using System.Globalization;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RhythmIsGonnaGetU
{
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    Welcome to Miami Sound Machine!     ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }
        static bool PromptForBool(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            if (userInput == "y" || userInput == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                return 'N';
            }
        }


        static void Main(string[] args)
        {
            var context = new RhythmIsGonnaGetUContext();
            // Console.WriteLine($"{newBand}");
            var bandCount = context.Bands.Count();
            Console.WriteLine($"There are {bandCount} bands.");


            var keepGoing = true;

            DisplayGreeting();

            // While the user hasn't said QUIT yet
            while (keepGoing)
            {
                Console.WriteLine("Would you like to..? \n (A)dd a band:\n or (Q)uit: ");

                var choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "Q":
                        keepGoing = false;
                        break;
                    case "A":

                        var newBand = new Band();
                        {
                            // might have to add context here for "Add Band" to work in a method

                            newBand.Name = PromptForString("What is the name of the new band? ");
                            newBand.CountryOfOrigin = PromptForString("What is the country of origin? ");
                            newBand.NumberOfMembers = PromptForInteger("How many band members are there? ");
                            newBand.Website = PromptForString("what's the band web address? ");
                            newBand.Style = PromptForString("What music genre do they play? ");
                            newBand.IsSigned = PromptForBool("Are they signed to a record label? ");
                            newBand.ContactName = PromptForString("Who is the main contact? ");
                            newBand.ContactPhoneNumber = PromptForString("What is the contact phone number? ");

                            context.Bands.Add(newBand);
                            context.SaveChanges();
                        }
                        var newAlbum = new Album();
                        Console.WriteLine($"Would you like to..? Add an Albu(M) for this band: [Y/N]\n ");
                        var answer = Console.ReadLine();
                        if (var)
                            // return newBand;

                            break;
                }
            }
        }
    }
}