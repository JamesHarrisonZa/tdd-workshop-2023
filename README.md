# TDD Workshop 2023

For Serko interns

## FizzBuzz Kata

1. Write a program that prints out the numbers from 1 to 100. (Console.WriteLine)

2. For multiples of three, print "Fizz" instead of the number.

3. For multiples of five, print "Buzz" instead of the number.

4. For multiples of both three and five, print "FizzBuzz" instead of the number.

> Hint: To make things easier to test. Separate the method doing the loop from 1-100 from the method which determines what to print.

## String Calculator

Write a simple calculator that can perform basic arithmetic operations on a string of numbers. Here is an outline of the requirements:

1. Create a class called "StringCalculator" with a method called "Add" that takes a string as an input.

2. The "Add" method should return 0 if the input string is empty.

3. If the input string contains a single number, the "Add" method should return that number.

4. If the input string contains multiple numbers, separated by a comma or newline, the "Add" method should return the sum of those numbers.

5. The "Add" method should handle negative numbers, and throw an exception if any negative numbers are found in the input string.

6. The "Add" method should ignore numbers greater than 1000.

7. The "Add" method should support custom delimiters, indicated by a "//" prefix before the numbers.

## Roman Numerals Kata

Write a program that can convert a given decimal number to its Roman numeral representation. Here is an outline of the requirements for the kata:

1. Create a class called "RomanNumeralConverter" with a method called "convert" that takes an integer as an input.

2. The "convert" method should return the Roman numeral representation of the input number.

3. Roman numerals use the following symbols: I, V, X, L, C, D and M, which represent the numbers 1, 5, 10, 50, 100, 500 and 1000 respectively.

4. In Roman numerals, a smaller numeral placed before a larger numeral means subtraction of the smaller numeral.

5. For example, IV represents 4, XL represents 40 and CM represents 900.

6. The program should handle numbers between 1 and 3999

7. The program should handle invalid input, such as negative numbers or numbers greater than 3999, and should return an appropriate error message.

## Bowling Game Kata

1. Create a class called "BowlingGame" with a method called "roll" that takes an integer as an input (representing the number of pins knocked down in a roll).

2. Create another method called "score" that calculates and returns the total score for the game.

3. The game consists of 10 frames. In each frame, the player has two rolls to knock down as many pins as possible.

4. If the player knocks down all 10 pins in the first roll of a frame, it's called a strike. The score for a strike is 10 plus the number of pins knocked down in the next two rolls.

5. If the player knocks down all 10 pins in the second roll of a frame, it's called a spare. The score for a spare is 10 plus the number of pins knocked down in the next roll.

6. If the player does not knock down all 10 pins in two rolls, the score for the frame is the total number of pins knocked down.

7. The game is over after the tenth frame, and the total score is the sum of the scores for all 10 frames.

8. The method roll should check if the input number exceeds the number of remaining pins, if so, it should throw an error

9. The method roll should check if the game is over, if so, it should throw an error

10. The method score should return -1 if the game is not over yet.