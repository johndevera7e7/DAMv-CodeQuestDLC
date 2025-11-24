# Test case 1: Normal Output
| # Instruction | # Iteration | Variables | | | | | | | | Condition | 
|---|---|---|---|---|---|---|---|---|---|---
|   |   | op | wizardname | mineTries | foundCoin | x | y | coinX | coinY |  |
| 1 |   | op | wizardname = "Player" | mineTries | foundCoin | x | y | coinX | coinY |  |
| 2 |   | op = 3 | wizardname = "Player" | mineTries | foundCoin | x | y | coinX | coinY |  | op != 0 -> true
| 3 | - | op = 3 | wizardname = "Player" | mineTries=5 | foundCoin=false | - | - | coinX=2 | coinY=3 |   |
| 4 | - | op = 3 | wizardname = "Player" | mineTries=5 | foundCoin=false | - | - | coinX=2 | coinY=3 | Initialize grid, place coin at (2,3) |
| 5 | 1 | op = 3 | wizardname = "Player" | mineTries=5 | foundCoin=false | 1 | 1 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE |
| 6 | 2 | op = 3 | wizardname = "Player" | mineTries=4 | foundCoin=false | 0 | 2 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE |
| 7 | 3 | op = 3 | wizardname = "Player" | mineTries=3 | foundCoin=false | 3 | 4 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE |
| 8 | 4 | op = 3 | wizardname = "Player" | mineTries=3 | foundCoin=true | 2 | 3 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > FALSE |
| 9 | - | op = 3 | wizardname = "Player" | mineTries=3 | foundCoin=true | 2 | 3 | coinX=2 | coinY=3 | Output: "Congrats! You won [coins] bits!" |
| 10 | - | op = 0 | wizardname = "Player" | mineTries=3 | foundCoin=true | 2 | 3 | coinX=2 | coinY=3 | Output: Program Closed |

# Test case 2: Error in Coordinates Input
| # Instruction | # Iteration | Variables | | | | | | | | Condition | 
|---|---|---|---|---|---|---|---|---|---|---
|   |   | op | wizardname | mineTries | foundCoin | x | y | coinX | coinY |  |
| 1 |   | op | wizardname = "Player" | mineTries | foundCoin | x | y | coinX | coinY |  |
| 2 |   | op = 3 | wizardname = "Player" | mineTries | foundCoin | x | y | coinX | coinY |  |
| 3 | - | op = 3 | wizardname = "Player" | mineTries=5 | foundCoin=false | - | - | coinX=2 | coinY=3 |   |
| 4 | - | op = 3 | wizardname = "Player" | mineTries=5 | foundCoin=false | - | - | coinX=2 | coinY=3 | Initialize grid, place coin at (2,3) |
| 5 | 1 | op = 3 | wizardname = "Player" | mineTries=5 | foundCoin=false | t | h | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE | Output = "Nope, not a valid coordinate."
| 6 | 2 | op = 3 | wizardname = "Player" | mineTries=4 | foundCoin=false | 4 | b | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE | Output = "Nope, not a valid coordinate."
| 7 | 3 | op = 3 | wizardname = "Player" | mineTries=3 | foundCoin=false | 3 | 4 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE |
| 8 | 4 | op = 3 | wizardname = "Player" | mineTries=2 | foundCoin=false | 6 | 7 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE | Output = "Nope, not a valid coordinate."
| 9 | 5 | op = 3 | wizardname = "Player" | mineTries=1 | foundCoin=false | asf | sf | coinX=2 | coinY=3 |  Output = "Nope, not a valid coordinate."
| 10 | 5 | op = 3 | wizardname = "Player" | mineTries=0 | foundCoin=false | asf | sf | coinX=2 | coinY=3 | Output = "Nope, not a valid coordinate."
| 11 | 5 | op = 0 | wizardname = "Player" | mineTries=0 | foundCoin=false | asf | sf | coinX=2 | coinY=3 | Output = Program Closed
