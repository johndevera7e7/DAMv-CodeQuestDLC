using System;


public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        //Menu strings
        const string AnyKeyContinue = "Press enter to continue";
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string WelcomeMessage = "== Welcome, {0} the {1} with power {2} and level {3}==";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOption4 = "4. Show inventory";
        const string MenuOption5 = "5. Buy items";
        const string MenuOption6 = "6. Show attacks by LVL";
        const string MenuOption7 = "7. Decode ancient scrolls";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-7) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 7.";

        //chapter/trainwizard strings
        const string PowerMessage = "Day {0}: After training for {1} hours, you gained {2} power points! You now have a power of {3}!";
        const string TrainingResult = "You are now: {0}, {1}!";

        //chapter/increaselevel
        const string MonsterAppear = "Oh no, you encountered the {0}, it has {1} points of health!";
        const string MonsterHealth = "You did {0} points of damage, now the {1} has {2} health points left!";
        const string MonsterDefeat = "Congratulations! You defeated the {0}!";
        const string MonsterAttack = "Press enter to attack!";
        const string MonsterLevelUp = "You gained {0} levels, now you are level {1}!";

        string[] monsters = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🦠", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem", "Lost Necromancer ☠️", "Ancient Dragon 🐉" };
        int[] monsterHp = { 3, 5, 10, 11, 18, 15, 20, 50 };
        string[] monsterDiceArt =
        {"",
            @" 
               ________
              /       /|   
             /_______/ |
             |       | |
             |   o   | /
             |       |/ 
             '-------'
            ",
            @" 
               ________
              /       /|   
             /_______/ |
             |     o | |
             |       | /
             | o     |/ 
             '-------'
            ",
            @" 
               ________
              /       /|   
             /_______/ |
             |     o | |
             |   o   | /
             | o     |/ 
             '-------'
            ",
            @" 
               ________
              /       /|   
             /_______/ |
             | o   o | |
             |       | /
             | o   o |/ 
             '-------'
            ",
            @" 
               ________
              /       /|   
             /_______/ |
             | o   o | |
             |   o   | /
             | o   o |/ 
             '-------'
            ",
            @" 
               ________
              /       /|   
             /_______/ |
             | o   o | |
             | o   o | /
             | o   o |/ 
             '-------'
            "
        };

        int op = 0, power = 0, totalPower = 0, level, totalLevel = 0, monsterindex, enemyhealth, attack;
        string wizardName, title = "Elantrí";

        Random rnd = new Random();

        Console.WriteLine("What's your name, oh destined one?");
        wizardName = Console.ReadLine();
        wizardName = char.ToUpper(wizardName[0]) + wizardName.Substring(1);

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(WelcomeMessage, wizardName, title, totalPower,totalLevel);
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
                            power = rnd.Next(1, 10);
                            totalPower = totalPower + power;
                            Console.WriteLine(PowerMessage, i, rnd.Next(1, 24), power, totalPower);
                            Console.WriteLine(AnyKeyContinue);
                            Console.ReadLine();
                        }
                        switch (totalPower)
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
                    case 2:
                        monsterindex = rnd.Next(monsters.Length);
                        enemyhealth = monsterHp[monsterindex];
                        Console.WriteLine(MonsterAppear, monsters[monsterindex], monsterHp[monsterindex]);
                        do
                        {
                            Console.WriteLine(MonsterAttack);
                            Console.ReadLine();
                            attack = rnd.Next(1, 7);
                            enemyhealth = enemyhealth - attack;
                            Console.WriteLine(monsterDiceArt[attack]);
                            Console.WriteLine(MonsterHealth, attack, monsters[monsterindex], enemyhealth);
                        } while (enemyhealth > 0);
                        level = rnd.Next(6);
                        totalLevel = totalLevel + level;
                        Console.WriteLine(MonsterDefeat, monsters[monsterindex]);
                        Console.WriteLine(MonsterLevelUp, level, totalLevel);
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
