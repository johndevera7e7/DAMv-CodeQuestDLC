# Test case 1: Normal Output with level 1

| # Instruction | # Iteration | Variables | | | | | | Condition | 
|---|---|---|---|---|---|---|---|---
|   |   | op | i | j | wizardname | totalLevel | maxLevel | 
| 1 |   | op | i | j | wizardname = Player | totalLevel = 1 | maxLevel | 
| 2 |   | op = 6 | i | j | wizardname = Player | totalLevel = 1 | maxLevel | Output = "There are your available attacks."
| 3 |   | op = 6 | i | j | wizardname = Player | totalLevel = 1 | maxLevel = 1 | totalLevel > 5 -> false
| 4 | 1 | op = 6 | i = 0 | j | wizardname = Player | totalLevel = 1 | maxLevel = 1 | i < maxLevel -> true
| 5 | 2 | op = 6 | i = 0 | j = 0 | wizardname = Player | totalLevel = 1 | maxLevel = 1 | j < maxLevel -> true / Output = "Level 1. Magic Spark 💫"
| 6 |   | op = 0 | i = 0 | j = 0 | wizardname = Player | totalLevel = 1 | maxLevel = 1 | op != 0 -> false / Output = Program Closed

# Test case 2: Normal Output with level 6

| # Instruction | # Iteration | Variables | | | | | | Condition | 
|---|---|---|---|---|---|---|---|---
|   |   | op | i | j | wizardname | totalLevel | maxLevel | 
| 1 |   | op | i | j | wizardname = Player | totalLevel = 6 | maxLevel | 
| 2 |   | op = 6 | i | j | wizardname = Player | totalLevel = 6 | maxLevel | Output = "There are your available attacks."
| 3 | 1 | op = 6 | i | j | wizardname = Player | totalLevel = 6 | maxLevel = 5 | totalLevel > 5 -> true
| 4 | 2 | op = 6 | i = 0 | j | wizardname = Player | totalLevel = 6 | maxLevel = 5 | i < maxLevel -> true
| 5 | 3 | op = 6 | i = 0 | j = 0 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 1. Magic Spark 💫"
| 6 | 4 | op = 6 | i = 1 | j = 1 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 2. Fireball 🔥"
| 7 | 5 | op = 6 | i = 1 | j = 2 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 2. Ice Ray 🥏"
| 8 | 6 | op = 6 | i = 1 | j = 3 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 2. Arcane Shield ⚕️"
| 9 | 7 | op = 6 | i = 2 | j = 4 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 3. Meteor ☄️"
| 10 | 8 | op = 6 | i = 2 | j = 5 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 3. Pure Energy Explosion 💥"
| 11 | 9 | op = 6 | i = 2 | j = 6 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 3. Minor Charm 🎭"
| 12 | 10 | op = 6 | i = 2 | j = 7 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 3. Air Strike 🍃"
| 13 | 11 | op = 6 | i = 3 | j = 8 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 4. Wave of Light ⚜️"
| 14 | 12 | op = 6 | i = 3 | j = 9 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 4. Storm of Wings 🐦"
| 15 | 13 | op = 6 | i = 4 | j = 10 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 5. Cataclysm 🌋"
| 16 | 14 | op = 6 | i = 4 | j = 11 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 5. Portal of Chaos 🌀"
| 17 | 15 | op = 6 | i = 4 | j = 12 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 5. Arcane Blood Pact 🩸"
| 18 | 16 | op = 6 | i = 4 | j = 13 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | j < attacks[i].length -> true / Output = "Level 5. Elemental Storm ⛈️"
| 19 |   | op = 0 | i = 4 | j = 13 | wizardname = Player | totalLevel = 6 | maxLevel = 5 | op != 0 -> false / Output = Program Closed
