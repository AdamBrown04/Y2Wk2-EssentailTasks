using System;

Console.WriteLine("What program do you want to run? \n1)guest list \n2)English to French translator");
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
}
