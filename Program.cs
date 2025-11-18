using System;

public class Program
{
    public static void Main()
    {
        const string AnyKeyContinue = "Press enter to continue";
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string WelcomeMessage = "== Welcome, {0} the {1} with level {2} ==";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOption4 = "4. Show inventory";
        const string MenuOption5 = "5. Buy items";
        const string MenuOption6 = "6. Show attacks by LVL";
        const string MenuOption7 = "7. Decode ancient scrolls";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-7) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";
        const string PowerLevelMessage = "Day {0}: After training for {1} hours, you gained {2} levels! You now have a power level of {3}!";
        const string TrainingResult = "You are now: {0}, {1}!";

        int op = 0, level = 0, totalLevel = 0;
        string wizardName, title = "Elantrí";

        Random rnd = new Random();

        Console.WriteLine("What's your name, oh destined one?");
        wizardName = Console.ReadLine();
        wizardName = char.ToUpper(wizardName[0]) + wizardName.Substring(1);
         
        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(WelcomeMessage, wizardName, title, level);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOption4);
            Console.WriteLine(MenuOption5);
            Console.WriteLine(MenuOption6);
            Console.WriteLine(MenuOption7);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            try
            {
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        for (int i = 1; i < 6; i++)
                        {
                            level = rnd.Next(1, 10);
                            totalLevel = totalLevel + level;
                            Console.WriteLine(PowerLevelMessage, i, rnd.Next(1, 24), level, totalLevel);
                            Console.WriteLine(AnyKeyContinue);
                            Console.ReadLine();
                        }
                        switch (totalLevel)
                        {
                            case >= 40:
                                title = "The Gray";
                                Console.WriteLine(TrainingResult, wizardName, title);
                                Console.WriteLine("You reached the rank: Master of the Arcane!");
                                break;
                            case >= 35:
                                title = "of the embers";
                                Console.WriteLine(TrainingResult, wizardName, title);
                                Console.WriteLine("Woah! You can summon dragons without burning the lab!");
                                break;
                            case >= 30:
                                title = "Nullpointer";
                                Console.WriteLine(TrainingResult, wizardName, title);
                                Console.WriteLine("You're a magic wind summoner!");
                                break;
                            case >= 20:
                                title = "The Bugged";
                                Console.WriteLine(TrainingResult, wizardName, title);
                                Console.WriteLine("You still confuse the wand with a spoon.");
                                break;
                            case < 20:
                                Console.WriteLine(TrainingResult, wizardName, title);
                                Console.WriteLine("You suspended.");
                                break;
                        }
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
            }

        } while (op != 0);
    }
}
