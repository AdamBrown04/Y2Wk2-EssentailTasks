﻿using System;
using Y2Wk2_EssentailTasks;

Console.WriteLine("What program do you want to run? \n1)guest list \n2)English to French translator \n3)Compare lists \n4)Remove outside 3 numbers \n5)baby DVLA \n6)Social event vote");
int option = Convert.ToInt32(Console.ReadLine());

Console.Clear();

switch (option) 
{
    case 1:
        List<string> guestList = new List<string>();

        while (true)
        {
            Task.Delay(1500).Wait();
            Console.Clear();
            Console.WriteLine("What would you like to do? \n1)Display guest list \n2)Add names to list \n3)Remove names \n4)How many people are on the list \n5)End program");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if(userInput == 1)
            {
                foreach (string guest in guestList)
                {
                    Console.WriteLine($"{guest}");
                }
            }
            else if (userInput == 2)
            {
                Console.Write("Enter a name you want to add: ");
                string newGuest = Console.ReadLine();

                bool found = false;

                foreach(string name in guestList)
                {
                    if(name.ToLower() == newGuest.ToLower())
                    {
                        Console.WriteLine($"{newGuest} is already on the list");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    guestList.Add(newGuest);
                    Console.WriteLine($"{newGuest} was added to the list");
                }
            }
            else if (userInput == 3)
            {
                Console.Write("Enter a name you want to remove: ");
                string nameToRemove = Console.ReadLine();

                bool found = false;
                for(int i = 0; i < guestList.Count; i++)
                {
                    if (guestList[i].ToLower() == nameToRemove.ToLower())
                    {
                        guestList.RemoveAt(i);
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine($"{nameToRemove} was removed from the list");
                }
                else
                {
                    Console.WriteLine($"{nameToRemove} was not found in the list");
                }
            }
            else if(userInput == 4)
            {
                Console.WriteLine($"There are {guestList.Count} guests on the list");
            }
            else if(userInput == 5)
            {
                break;
            }

        }
        break;
    case 2:
        Dictionary<string, string> translator = new Dictionary<string, string>();
        translator.Add("hello", "bonjour");
        translator.Add("rain", "pluie");
        translator.Add("car", "voiture");
        translator.Add("fish", "poisson");

        Console.WriteLine("When you want the program to finish input 'end'");

        while (true)
        {
            Console.Write("What word would you like to traslate? ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "end")
            {
                break;
            }
            else
            {
                if (translator.ContainsKey(userInput))
                {
                    Console.WriteLine(translator[userInput]);
                }
                else
                {
                    Console.Write($"{userInput} is not currently in the dictionary, would you like to add a translation? Y/N ");
                    string addNewWord = Console.ReadLine().ToUpper();

                    if (addNewWord == "Y")
                    {
                        Console.Write($"Enter the translation of {userInput}: ");
                        translator.Add(userInput, Console.ReadLine().ToLower());
                    }
                }
            }

        }
        break;
    case 3:
        List<string> stringsA = new List<string>();
        List<string> stringsB = new List<string>();

        Console.WriteLine("Enter END when you want the data input to stop");

        Console.WriteLine("List 1:");

        while (true)
        {
            Console.Write("Enter anything: ");
            string inputA = Console.ReadLine();

            if (inputA.ToUpper() == "END")
            {
                break;
            }
            else
            {
                stringsA.Add(inputA);
            }
        }

        Console.WriteLine("List 2:");
        while (true)
        {
            Console.Write("Enter anything: ");
            string inputB = Console.ReadLine();

            if (inputB.ToUpper() == "END")
            {
                break;
            }
            else
            {
                stringsB.Add(inputB);
            }
        }

        bool identical = true;

        if(stringsA.Count == stringsB.Count)
        {
            for(int x = 0; x < stringsA.Count; x++)
            {
                if (stringsA[x] != stringsB[x])
                {
                    Console.WriteLine("Lists are not identical");
                    identical = false;
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Lists are not identical");
        }

        if (identical)
        {
            Console.WriteLine("The lists are identical");
        }

        break;
    case 4:
        List<int> numbers = new List<int>();

        Console.WriteLine("After a minimum of 7 entries, once you want to finish inputting numbers enter END");
        int numbersEntered = 0;

        while (true)
        {
            Console.Write("Enter a number: ");
            string inputedNumber = Console.ReadLine();

            if(numbersEntered < 7 && inputedNumber.ToUpper() == "END")
            {
                Console.WriteLine("You have not reached the minimum amount of inputs yet");
            }
            else if(inputedNumber.ToUpper() == "END")
            {
                break;
            }
            else
            {
                numbers.Add(Convert.ToInt32(inputedNumber));
                numbersEntered++;
            }
        }

        for(int x = 0; x < 3; x++)
        {
            int max = numbers.Max();
            int min = numbers.Min();

            numbers.Remove(max);
            numbers.Remove(min);
        }

        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }
        break;
        //unsure why program isn't working correctly
    case 5:
        Dictionary<string, Car> DVLAness = new Dictionary<string, Car>();

        Car car1 = new Car();
        car1.GetMake("Kia");
        car1.GetModel("Cee'd");
        car1.GetRegPlate("PK10 RBO");
        car1.GetYoM(2010);
        DVLAness.Add("PK10 RBO", car1);
        Car car2 = new Car();
        car1.GetMake("Ford");
        car1.GetModel("Mondeo");
        car1.GetRegPlate("AH14 CHU");
        car1.GetYoM(2014);
        DVLAness.Add("AH14 CHU", car2);
        Car car3 = new Car();
        car1.GetMake("Renault");
        car1.GetModel("Clio");
        car1.GetRegPlate("BA72 GTU");
        car1.GetYoM(2022);
        DVLAness.Add("BA72 GTU", car3);

        Console.Write("Enter number plate: ");
        string numPlate = Console.ReadLine();
        if (DVLAness.ContainsKey(numPlate))
        {
            Car carX = DVLAness[numPlate];
            carX.ViewMake();
            carX.ViewModel();
            carX.ViewRegPlate();
            carX.ViewYoM();
        }
        else
        {
            Console.WriteLine("That car does not exist");
        }
        break;
    case 6:
        Console.WriteLine("When you want the program to finish enter END");
        Dictionary<string, int> eventVote = new Dictionary<string, int>();

        while (true)
        {
            Console.Write("Enter an event you would like to do: ");
            string userInput = Console.ReadLine().ToUpper();

            if (userInput == "END")
            {
                break;
            }
            else if (eventVote.ContainsKey(userInput))
            {
                eventVote[userInput] += 1;
            }
            else if(eventVote.Count == 0 || !eventVote.ContainsKey(userInput))
            {
                eventVote.Add(userInput, 1);
            }
        }

        
        break;
}
