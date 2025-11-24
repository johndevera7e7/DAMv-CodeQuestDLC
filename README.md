# Test case 1: Normal output

| # Instruction | # Iteration | Variables | | | | | Condition | 
|---|---|---|---|---|---|---|---|
| 1 | - | op = 0 | level = 0 | totalLevel = 0 | wizardname = "Ee" | title = "Elantrí" | 
| 2 | 1 | op = 1 | level = 4 | totalLevel = 4 | wizardname = "Ee" | title = "Elantrí" | op != 0 -> true Output = "After training for 5 hours, you gained 4 levels! You now have a power level of 4!"
| 3 | 2 | op = 1 | level = 3 | totalLevel = 7 | wizardname = "Ee" | title = "Elantrí" | Output = "After training for 6 hours, you gained 3 levels! You now have a power level of 7!"
| 4 | 3 | op = 1 | level = 5 | totalLevel = 12 | wizardname = "Ee" | title = "Elantrí" | Output = "After training for 18 hours, you gained 5 levels! You now have a power level of 12!"
| 5 | 4 | op = 1 | level = 9 | totalLevel = 21 | wizardname = "Ee" | title = "The Bugged" | Output = "After training for 2 hours, you gained 9 levels! You now have a power level of 21!"
| 6 | 5 | op = 1 | level = 9 | totalLevel = 30 | wizardname = "Ee" | title = "Nullpointer" | Output = "After training for 12 hours, you gained 9 levels! You now have a power level of 30!" "You are now Ee, The Bugged!"
| 7 | - | op = 0 | level = 9 | totalLevel = 30 | wizardname = "Ee" | title = "Nullpointer" | Output = Program closed

# Test case 2: Error output Format Exception

| # Instruction | # Iteration | Variables | | | | | Condition | 
|---|---|---|---|---|---|---|---|
| 1 | - | op = 0 | level = 0 | totalLevel = 0 | wizardname = "Ee" | title = "Elantrí" | 
| 2 | - | op = e | level = 0 | totalLevel = 0 | wizardname = "Ee" | title = "Elantrí" | Output = ""
