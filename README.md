# Test case 1: Normal output

| # Instruction | # Iteration | Variables | | | | | | | Condition | 
|---|---|---|---|---|---|---|---|---|---|
| 1 | - | op = 0 | wizardname = "" | attack | monsterindex | enemyhealth | totalLevel | level |
| 2 | - | op = 0 | wizardname = "Ee" | attack | monsterindex | enemyhealth | totalLevel | level |
| 3 | 1 | op = 2 | wizardname = "Ee" | attack | monsterindex = 2 | enemyhealth = 10 | totalLevel | level | op != 0 -> true / enemyhealth > 0 -> true
| 4 | 2 | op = 2 | wizardname = "Ee" | attack = 4 | monsterindex = 2 | enemyhealth = 6 | totalLevel | level | enemyhealth > 0 -> true
| 5 | 3 | op = 2 | wizardname = "Ee" | attack = 2 | monsterindex = 2 | enemyhealth = 4 | totalLevel | level | enemyhealth > 0 -> true
| 6 | 4 | op = 2 | wizardname = "Ee" | attack = 6 | monsterindex = 2 | enemyhealth = 0 | totalLevel | level |  enemyhealth > 0 -> false
| 7 | - | op = 2 | wizardname = "Ee" | attack = 6 | monsterindex = 2 | enemyhealth = 0 | totalLevel = 4| level = 4 |
| 8 | - | op = 0 | wizardname = "Ee" | attack = 6 | monsterindex = 2 | enemyhealth = 0 | totalLevel = 4| level = 4 | Output = Program closed
