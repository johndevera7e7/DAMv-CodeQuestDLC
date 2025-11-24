# Test case 1: Normal Output 

| # Instruction | # Iteration | Variables ||| Condition | 
|---|---|---|---|---|---
|   | - | op | i | wizardname |
| 1 | - | op | i | wizardname = Player |
| 2 | 1 | op = 4 | i = 1 | wizardname = Player | op != 0 -> true / inventory != null -> false Output = "Slot 1 is empty."
| 3 | 2 | op = 4 | i = 2 | wizardname = Player | inventory != null -> false Output = "Slot 2 is empty."
| 4 | 3 | op = 4 | i = 3 | wizardname = Player | inventory != null -> false Output = "Slot 3 is empty."
| 5 | 4 | op = 4 | i = 4 | wizardname = Player | inventory != null -> false Output = "Slot 4 is empty."
| 6 | 5 | op = 4 | i = 5 | wizardname = Player | inventory != null -> false Output = "Slot 5 is empty."
| 7 | - | op = 0 | i | wizardname = Player | op != 0 -> false / Output = Program Closed
