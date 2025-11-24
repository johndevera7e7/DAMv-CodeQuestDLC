# Test case 1: Normal Output with 0 bits

| # instruction | # iteration | Variables | | | | | | | | Condition | 
|---|---|---|---|---|---|---|---|---|---|---
|   |   | op     | wizardName | totalCoins | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 1 |   | op     | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 2 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "These are the items available
| 4 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "----------------------------------"
| 5 | 1 | op = 5 | wizardName = "Player" | totalCoins = 0 | i = 0| buyItemInput | shopItem[i] = "Iron Dagger" | shopPrices[] | inventory[] | Output = "1. Iron Dagger / Price = 30"
| 6 | 2 | op = 5 | wizardName = "Player" | totalCoins = 0 | i = 1| buyItemInput | shopItem[i] ="Healing Potion" | shopPrices[] | inventory[] | Output = "2. Healing Potion / Price = 10"
| 7 | 3 | op = 5 | wizardName = "Player" | totalCoins = 0 | i = 2| buyItemInput | shopItem[i] ="Ancient Key" | shopPrices[] | inventory[] | Output = "3. Ancient Key / Price = 50"
| 8 | 4 | op = 5 | wizardName = "Player" | totalCoins = 0 | i = 3| buyItemInput | shopItem[i] ="Crossbow" | shopPrices[] | inventory[] | Output = "4. Crossbow / Price = 40"
| 9 | 5 | op = 5 | wizardName = "Player" | totalCoins = 0 | i = 4| buyItemInput | shopItem[i] ="Metal Shield" | shopPrices[] | inventory[] | Output = "5. Metal Shield / Price = 20"
| 10 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "You have 0 bits."
| 11 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "Would you like to buy an item? (1 = yes)"
| 12 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput = 1 | shopItem[] | shopPrices[] | inventory[] | Output = "Which item? (Enter the item slot)"
| 13 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput = 4 | shopItem[buyItemInput] = "Metal Shield" | shopPrices[buyItemInput] = 20 | inventory[] | totalCoins < shopPrices[buyItemInput] -> true / Output = "You're too broke for the Metal Shield"
| 14 |   | op = 0 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput = 4 | shopItem[buyItemInput] | shopPrices[buyItemInput] | inventory[] | op != 0 -> false / Output = Program Closed

# Test case 2: Normal Output with 50 bits

| # instruction | # iteration | Variables | | | | | | | | Condition | 
|---|---|----|---|---|---|---|---|---|---|---
|   |   | op | wizardName | totalCoins | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 1 |   | op | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 2 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "These are the items available
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "----------------------------------"
| 3 | 1 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 0| buyItemInput | shopItem[i] = "Iron Dagger" | shopPrices[] | inventory[] | Output = "1. Iron Dagger / Price = 30"
| 3 | 2 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 1| buyItemInput | shopItem[i] ="Healing Potion" | shopPrices[] | inventory[] | Output = "2. Healing Potion / Price = 10"
| 3 | 3 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 2| buyItemInput | shopItem[i] ="Ancient Key" | shopPrices[] | inventory[] | Output = "3. Ancient Key / Price = 50"
| 3 | 4 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 3| buyItemInput | shopItem[i] ="Crossbow" | shopPrices[] | inventory[] | Output = "4. Crossbow / Price = 40"
| 3 | 5 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 4| buyItemInput | shopItem[i] ="Metal Shield" | shopPrices[] | inventory[] | Output = "5. Metal Shield / Price = 20"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "You have 50 bits."
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "Would you like to buy an item? (1 = yes)"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput = 1 | shopItem[] | shopPrices[] | inventory[] | Output = "Which item? (Enter the item slot)"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 30 | i | buyItemInput = 4 | shopItem[buyItemInput] = null | shopPrices[buyItemInput] = null | inventory[buyItemInput] = "Metal Shield" | totalCoins >= shopPrices[buyItemInput] -> true / Output = "Metal Shield has been bought
| 3 |   | op = 0 | wizardName = "Player" | totalCoins = 30 | i | buyItemInput = 4 | shopItem[buyItemInput] = null | shopPrices[buyItemInput] = null | inventory[buyItemInput] = "Metal Shield" | op != 0 -> false / Output = Program Closed

# Test case 3: Error Format Exception

| # instruction | # iteration | Variables | | | | | | | | Condition | 
|---|---|----|---|---|---|---|---|---|---|---
|   |   | op | wizardName | totalCoins | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 1 |   | op | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 2 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "These are the items available
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "----------------------------------"
| 3 | 1 | op = 5 | wizardName = "Player" | totalCoins = 0 | i = 0| buyItemInput | shopItem[i] = "Iron Dagger" | shopPrices[] | inventory[] | Output = "1. Iron Dagger / Price = 30"
| 3 | 2 | op = 5 | wizardName = "Player" | totalCoins = 0 | i = 1| buyItemInput | shopItem[i] ="Healing Potion" | shopPrices[] | inventory[] | Output = "2. Healing Potion / Price = 10"
| 3 | 3 | op = 5 | wizardName = "Player" | totalCoins = 0 | i = 2| buyItemInput | shopItem[i] ="Ancient Key" | shopPrices[] | inventory[] | Output = "3. Ancient Key / Price = 50"
| 3 | 4 | op = 5 | wizardName = "Player" | totalCoins = 0 | i = 3| buyItemInput | shopItem[i] ="Crossbow" | shopPrices[] | inventory[] | Output = "4. Crossbow / Price = 40"
| 3 | 5 | op = 5 | wizardName = "Player" | totalCoins = 0 | i = 4| buyItemInput | shopItem[i] ="Metal Shield" | shopPrices[] | inventory[] | Output = "5. Metal Shield / Price = 20"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "You have 0 bits."
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "Would you like to buy an item? (1 = yes)"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput = er | shopItem[] | shopPrices[] | inventory[] | Output = "Nope, that's not available or a good input"
| 3 |   | op = 0 | wizardName = "Player" | totalCoins = 0 | i | buyItemInput = er | shopItem[] | shopPrices[] | inventory[] | op != 0 -> false / Output = Program Closed

# Test case 4: Buying an already bought item

| # instruction | # iteration | Variables | | | | | | | | Condition | 
|---|---|----|---|---|---|---|---|---|---|---
|   |   | op | wizardName | totalCoins | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 1 |   | op | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 2 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "These are the items available
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "----------------------------------"
| 3 | 1 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 0| buyItemInput | shopItem[i] = "Iron Dagger" | shopPrices[] | inventory[] | Output = "1. Iron Dagger / Price = 30"
| 3 | 2 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 1| buyItemInput | shopItem[i] ="Healing Potion" | shopPrices[] | inventory[] | Output = "2. Healing Potion / Price = 10"
| 3 | 3 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 2| buyItemInput | shopItem[i] ="Ancient Key" | shopPrices[] | inventory[] | Output = "3. Ancient Key / Price = 50"
| 3 | 4 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 3| buyItemInput | shopItem[i] ="Crossbow" | shopPrices[] | inventory[] | Output = "4. Crossbow / Price = 40"
| 3 | 5 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 4| buyItemInput | shopItem[i] ="Metal Shield" | shopPrices[] | inventory[] | Output = "5. Metal Shield / Price = 20"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "You have 50 bits."
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "Would you like to buy an item? (1 = yes)"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput = 1 | shopItem[] | shopPrices[] | inventory[] | Output = "Which item? (Enter the item slot)"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 30 | i | buyItemInput = 4 | shopItem[buyItemInput] = null | shopPrices[buyItemInput] = null | inventory[buyItemInput] = "Metal Shield" | totalCoins >= shopPrices[buyItemInput] -> true / Output = "Metal Shield has been bought
| 2 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | 
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "These are the items available
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "----------------------------------"
| 3 | 1 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 0| buyItemInput | shopItem[i] = "Iron Dagger" | shopPrices[] | inventory[] | Output = "1. Iron Dagger / Price = 30"
| 3 | 2 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 1| buyItemInput | shopItem[i] ="Healing Potion" | shopPrices[] | inventory[] | Output = "2. Healing Potion / Price = 10"
| 3 | 3 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 2| buyItemInput | shopItem[i] ="Ancient Key" | shopPrices[] | inventory[] | Output = "3. Ancient Key / Price = 50"
| 3 | 4 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 3| buyItemInput | shopItem[i] ="Crossbow" | shopPrices[] | inventory[] | Output = "4. Crossbow / Price = 40"
| 3 | 5 | op = 5 | wizardName = "Player" | totalCoins = 50 | i = 4| buyItemInput | shopItem[i] ="Metal Shield" | shopPrices[] | inventory[] | Output = "Slot 5 is empty"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "You have 30 bits."
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput | shopItem[] | shopPrices[] | inventory[] | Output = "Would you like to buy an item? (1 = yes)"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 50 | i | buyItemInput = 1 | shopItem[] | shopPrices[] | inventory[] | Output = "Which item? (Enter the item slot)"
| 3 |   | op = 5 | wizardName = "Player" | totalCoins = 30 | i | buyItemInput = 4 | shopItem[buyItemInput] = null | shopPrices[buyItemInput] = null | inventory[buyItemInput] = "Metal Shield" | shopItem[buyItemInput] == null -> true / Output = "There's no item available at that spot!"
| 3 |   | op = 0 | wizardName = "Player" | totalCoins = 30 | i | buyItemInput = 4 | shopItem[buyItemInput] = null | shopPrices[buyItemInput] = null | inventory[buyItemInput] = "Metal Shield" | op != 0 -> false / Output = Program Closed
