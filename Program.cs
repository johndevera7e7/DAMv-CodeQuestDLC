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

        //chapter/lootthemine
        const string WelcomeMine="Welcome to the mine, {0}! Insert your coordinates (0-4) to find some coins!";
        const string MineTries = "You have {0} tries left!";
        const string InsertCoordinatesY = "Insert a value for the coordinates Y (0-4): ";
        const string InsertCoordinatesX = "Insert a value for the coordinates X (0-4): ";
        const string InsertError = "Nope, not a valid coordinate.";
        const string MineDefeat = "Sorry, not your lucky day.";
        const string MineWin = "Congrats! You won {0} bits!";

        //chapter/showinventory
        const string emptySlot = "Slot {0} is empty.";

        //chapter/buyitems
        const string shopShowcase = "These are the items available";
        const string itemBought= "{0} has been bought";
        const string buyItem = "Would you like to buy an item? (1 = yes)";
        const string itemSlotBought = "There's no item available in that spot!";
        const string inputErrorShop = "Nope, that's not available or a good input.";
        const string buyItemSlot = "Which item? (Enter the item slot)";
        const string notEnoughMoney = "You're too broke for the {0}!";

        //chapter/showattacks
        const string availableAttacks = "There are your available attacks.";

        string[][] attacks = 
        {
            new[] {"Magic Spark 💫"},
            new[] {"Fireball 🔥", "Ice Ray 🥏", "Arcane Shield ⚕️"},
            new[] { "Meteor ☄️", "Pure Energy Explosion 💥", "Minor Charm 🎭", "Air Strike 🍃"},
            new[] { "Wave of Light ⚜️", "Storm of Wings 🐦"},
            new[] {"Cataclysm 🌋", "Portal of Chaos 🌀", "Arcane Blood Pact 🩸", "Elemental Storm ⛈️" },
        };
        int[] shopPrices = {30,10,50,40,20};
        string[] shopItem = {"Iron Dagger","Healing Potion","Ancient Key","Crossbow","Metal Shield"};
        string[] inventory = new string[5];
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

        string[,] mineShowInterface = {
            {"➖","➖","➖","➖","➖" },
            {"➖","➖","➖","➖","➖" },
            {"➖","➖","➖","➖","➖" },
            {"➖","➖","➖","➖","➖" },
            {"➖","➖","➖","➖","➖" }
        };
        int[,] mineCoin = new int [5,5];

        int op = 0, power = 0, totalPower = 0, level, totalLevel = 0, monsterindex, enemyhealth, attack, y,x,coinY,coinX,coinsGained = 5, mineTries = 5, totalCoins = 100,buyItemInput = 0, maxLevel;
        string wizardName, title = "Elantrí";
        bool foundCoin = false;

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
                    case 3:
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                mineShowInterface[i, j] = "➖";
                            }
                        }
                        Console.WriteLine(WelcomeMine,wizardName);
                        coinX = rnd.Next(0,5);
                        coinY = rnd.Next(0,5);
                        mineCoin[coinX,coinY] = 1;
                        mineTries = 5;
                        do
                        { 
                            Console.WriteLine(MineTries, mineTries);
                            for (int j = 0; j < 5; j++)
                            {
                                Console.WriteLine(mineShowInterface[0, j] + mineShowInterface[1, j] + mineShowInterface[2, j] + mineShowInterface[3, j] + mineShowInterface[4, j]);
                            }
                            Console.WriteLine(InsertCoordinatesY);
                            try
                            {
                                y = int.Parse(Console.ReadLine());
                                Console.WriteLine(InsertCoordinatesX);
                                x = int.Parse(Console.ReadLine());
                                if (mineCoin[x, y] == 1)
                                {
                                    mineShowInterface[x, y] = "💰";
                                    foundCoin = true;
                                    coinsGained = rnd.Next(5, 51);
                                }
                                else
                                {
                                    mineShowInterface[x, y] = "❌";
                                    mineTries--;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(InsertError);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(InsertError);
                            }

                        } while (mineTries > 0 && !foundCoin);
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine(mineShowInterface[0, j] + mineShowInterface[1, j] + mineShowInterface[2, j] + mineShowInterface[3, j] + mineShowInterface[4, j]);
                        }
                        if (foundCoin)
                        {
                            Console.WriteLine(MineWin,coinsGained);
                            totalCoins = totalCoins + coinsGained;
                        } else
                        {
                            Console.WriteLine(MineDefeat);
                        }
                        break;
                    case 4:
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            if (inventory[i] != null)
                            {
                                Console.WriteLine((i + 1) + ". " + inventory[i]);
                            } else
                            {
                                Console.WriteLine(emptySlot,(i + 1));
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine(shopShowcase);
                        Console.WriteLine("----------------------------------");
                        for (int i = 0; i < shopItem.Length; i++)
                        {
                            if (shopItem[i] != null)
                            {
                                Console.WriteLine((i + 1) + ". " + shopItem[i] + " | Price = " + shopPrices[i]);
                            }else
                            {
                                Console.WriteLine(emptySlot, (i+1));
                            }
                            
                        }
                        Console.WriteLine(buyItem);
                        try
                        {
                            buyItemInput = int.Parse(Console.ReadLine());
                            if (buyItemInput == 1)
                            {
                                Console.WriteLine(buyItemSlot);
                                try
                                {
                                    buyItemInput = int.Parse(Console.ReadLine()) - 1;
                                    if (totalCoins >= shopPrices[buyItemInput])
                                    {
                                        Console.WriteLine(itemBought, shopItem[buyItemInput]);
                                        totalCoins = totalCoins - shopPrices[buyItemInput];
                                        inventory[buyItemInput] = shopItem[buyItemInput];
                                        shopItem[buyItemInput] = null;
                                    } else if (totalCoins < shopPrices[buyItemInput])
                                    {
                                        Console.WriteLine(notEnoughMoney, shopItem[buyItemInput]);
                                    } else if (shopItem[buyItemInput] == null)
                                    {
                                        Console.WriteLine(itemSlotBought);
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine(inputErrorShop);
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(inputErrorShop);
                                }
                            } else
                            {
                                Console.WriteLine("Good bye!");
                            }
                            
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(inputErrorShop);
                        }
                        catch (Exception) 
                        {
                            Console.WriteLine(inputErrorShop);
                        }
                        break;
                    case 6:
                        Console.WriteLine(availableAttacks);
                        if (totalLevel > 5)
                        {
                            maxLevel = 5;
                        }
                        else
                        {
                            maxLevel = totalLevel;
                        }
                            for (int i = 0; i < maxLevel; i++)
                            {
                                for (int j = 0; j < attacks[i].Length; j++)
                                {
                                    Console.WriteLine("Level " + (i + 1) + ". " + attacks[i][j]);
                                }
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
