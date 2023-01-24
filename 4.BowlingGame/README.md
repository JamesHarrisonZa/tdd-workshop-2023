# Bowling Game Kata

1. Create a class called "BowlingGame" with a method called "Roll" that takes an integer as an input (representing the number of pins knocked down in a roll).

2. Create another method called "Score" that calculates and returns the total score for the game.

3. The game consists of 10 frames. In each frame, the player has two rolls to knock down as many pins as possible.

4. If the player knocks down all 10 pins in the first roll of a frame, it's called a strike. The score for a strike is 10 plus the number of pins knocked down in the next two rolls.

5. If the player knocks down all 10 pins in the second roll of a frame, it's called a spare. The score for a spare is 10 plus the number of pins knocked down in the next roll.

6. If the player does not knock down all 10 pins in two rolls, the score for the frame is the total number of pins knocked down.

7. The game is over after the tenth frame, and the total score is the sum of the scores for all 10 frames.

8. The method roll should check if the input number exceeds the number of remaining pins, if so, it should throw an error

9. The method roll should check if the game is over, if so, it should throw an error

10. The method score should return -1 if the game is not over yet.