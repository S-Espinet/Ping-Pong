# Ping Pong

### Fizz Buzz by any other name smells just as sweet

## Specs

| Test | Code | Expected Return Value |
| ---- | ---- | --------------------- |
| It should return an error message if input value is 0 or less                                                                                    | beebBoop('-1')    | ["Please input a valid number."] |
| It should return an error message if input is not a valid positive integer                                                                       | beepBoop('123.1') | ["Please input a valid number."] |
| Always return an array with a length that is equal to the value inputted plus one, and containing values from 0 to our inputted value. | beepBoop(5)       | [0, 1, 2, 3, 4, 5] |
| If any iterated value contains 3 then insert the phrase 'Won't you be my neighbor?' into the array at that spot.                      | beepBoop(5)       | [0, 1, 2, 'Won't you be my neighbor?', 4, 5] |
| If any iterated value contains 2 and does not contain 3 then insert the phrase 'Boop!' into the array at that spot.                   | beepBoop(5)       | [0, 1, 'Boop!', 'Won't you be my neighbor?', 4, 5] |
| If any iterated value contains 1 and does not contain 2 or 3 then insert the phrase 'Beep!' into the array at that spot.              | beepBoop(5)       | [0, 'Beep!', 'Boop!', 'Won't you be my neighbor?', 4, 5] |

Test(1): "It should return an error if a non-number is inputted."
Code: beepBoop("A");
Expected Output: [Please enter a valid number.]

Test(2): "It should return 0 when 0 is inputted."
Code: beepBoop(0);
Expected Output: ["0"]

Test(3): "It should return an array which consists of a number of elements equal to the inputted number + 1."
Code: let roboger = [];
roboger = beepBoop("5");
roboger.length;
Expected Output: 6

Test(4): "It should return "Beep!", "Boop!", and "Won't you be my neighbor?" in place of "1", "2", and "3".
Code: beepBoop("3") Expected Output: ["0", "Beep!", "Boop", "Won't you be my neighbor?"]

Test(5): "It should return 'Won't you be my neighbor?' at position 32."
Code: beepBoop("32")[32] Expected Output: "Won't you be my neighbor?"

Test(6): "It should return 'Boop!' at position 21 if beepBoop is called with <= 31."
Code: beepBoop("21")[21] Expected Output: "Boop!"

Test(7): "It should return 'Won't you be my neighbor?' at position 13 if beepBoop is called with <= 20."
Code: beepBoop("13")[13] Expected Output: "Won't you be my neighbor?"