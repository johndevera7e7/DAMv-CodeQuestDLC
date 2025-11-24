# Test case 1: Normal Output

| # instruction | # iteration | Variables | | | | | | | Condition 
|---|---|---|---|---|---|---|---|---|---
|               |             | op | scrollChosen | scroll1 | scroll2 | scroll3 | vowelCounter | forbiddenTruth | 
| 1    | -         | op=7 | scrollChosen=-1 | scroll1=false | scroll2=false | scroll3=false | vowelCounter=0 | forbiddenTruth="" | 
| 2    | -         | op=7 | scrollChosen=-1 | scroll1=false | scroll2=false | scroll3=false | vowelCounter=0 | forbiddenTruth="" | Display scrolls and decoding options 
| 3    | 1         | op=7 | scrollChosen=0 | scroll1=false | scroll2=false | scroll3=false | vowelCounter=0 | forbiddenTruth="" | User selects scroll 1 (Void elimination) 
| 3    | 1         | op=7 | scrollChosen=0 | scroll1=true | scroll2=false | scroll3=false | vowelCounter=0 | forbiddenTruth="" | Remove spaces from scroll 1 
| 3    | 2         | op=7 | scrollChosen=1 | scroll1=true | scroll2=false | scroll3=false | vowelCounter=0 | forbiddenTruth="" | User selects scroll 2 (Counter corrupted symbols) 
| 3    | 2         | op=7 | scrollChosen=1 | scroll1=true | scroll2=true | scroll3=false | vowelCounter=8 | forbiddenTruth="" | Count vowels in scroll 2 
| 3    | 3         | op=7 | scrollChosen=2 | scroll1=true | scroll2=true | scroll3=false | vowelCounter=8 | forbiddenTruth="" | User selects scroll 3 (Discover forbidden truth) 
| 3    | 3         | op=7 | scrollChosen=2 | scroll1=true | scroll2=true | scroll3=true | vowelCounter=8 | forbiddenTruth="5638" | Extract numbers from scroll 3 
| 4    | -         | op=7 | scrollChosen=2 | scroll1=true | scroll2=true | scroll3=true | vowelCounter=8 | forbiddenTruth="5638" | Output = "Congratulations! You decoded all the ancient scrolls!" 
| 4    | -         | op=0 | scrollChosen=2 | scroll1=true | scroll2=true | scroll3=true | vowelCounter=8 | forbiddenTruth="5638" | Output = Program Closed 

# Test case 2: Error Input

| # instruction | # iteration | Variables | | | | | | | Condition 
|---|---|---|---|---|---|---|---|---|---
|               |             | op | scrollChosen | scroll1 | scroll2 | scroll3 | vowelCounter | forbiddenTruth | 
| 1    |          | op=7 | scrollChosen=-1 | scroll1=false | scroll2=false | scroll3=false | vowelCounter=0 | forbiddenTruth="" | 
| 2    |          | op=7 | scrollChosen=-1 | scroll1=false | scroll2=false | scroll3=false | vowelCounter=0 | forbiddenTruth="" | Display scrolls and decoding options 
| 3    |          | op=7 | scrollChosen= er | scroll1=false | scroll2=false | scroll3=false | vowelCounter=0 | forbiddenTruth="" | Output = "That's not a scroll" 
| 4    |          | op=0 | scrollChosen= er | scroll1=false | scroll2=false | scroll3=false | vowelCounter=0 | forbiddenTruth="" | Output = Program Closed

