# Test case 1: Normal Output
| # Instruction | # Iteration | Variables | | | | | | Condition | 
|---|---|---|---|---|---|---|---|---|
|   |   | mineTries | foundCoin | x | y | coinX | coinY |  |
| 1 | - | mineTries=5 | foundCoin=false | - | - | coinX=2 | coinY=3 |   |
| 2 | - | mineTries=5 | foundCoin=false | - | - | coinX=2 | coinY=3 | Initialize grid, place coin at (2,3) |
| 3 | 1 | mineTries=5 | foundCoin=false | 1 | 1 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE |
| 3 | 2 | mineTries=4 | foundCoin=false | 0 | 2 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE |
| 3 | 3 | mineTries=3 | foundCoin=false | 3 | 4 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE |
| 3 | 4 | mineTries=3 | foundCoin=true | 2 | 3 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > FALSE |
| 4 | - | mineTries=3 | foundCoin=true | 2 | 3 | coinX=2 | coinY=3 | Output: "Congrats! You won [coins] bits!" |

# Test case 2: Error in Coordinates Input
| # Instruction | # Iteration | Variables | | | | | | Condition | 
|---|---|---|---|---|---|---|---|---|
|   |   | mineTries | foundCoin | x | y | coinX | coinY |  |
| 1 | - | mineTries=5 | foundCoin=false | - | - | coinX=2 | coinY=3 |   |
| 2 | - | mineTries=5 | foundCoin=false | - | - | coinX=2 | coinY=3 | Initialize grid, place coin at (2,3) |
| 3 | 1 | mineTries=5 | foundCoin=false | t | h | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE | Output = "Nope, not a valid coordinate."
| 3 | 2 | mineTries=4 | foundCoin=false | 4 | b | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE | Output = "Nope, not a valid coordinate."
| 3 | 3 | mineTries=3 | foundCoin=false | 3 | 4 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE |
| 3 | 4 | mineTries=2 | foundCoin=false | 6 | 7 | coinX=2 | coinY=3 | mineTries > 0 && !foundCoin > TRUE | Output = "Nope, not a valid coordinate."
| 4 | 5 | mineTries=1 | foundCoin=false | asf | sf | coinX=2 | coinY=3 | Output: "Congrats! You won [coins] bits!" | Output = "Nope, not a valid coordinate."
| 4 | 5 | mineTries=0 | foundCoin=false | asf | sf | coinX=2 | coinY=3 | Output: "Congrats! You won [coins] bits!" | Output = "Nope, not a valid coordinate."

