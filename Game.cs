using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Game
    {
        private const int finalScore = 100;

        // game board
        private static int[] snakeBite = new int[100];
        private static int[] ladderClimb = new int[100];

        // Player 1 and 2 start from position 0
        private int playerOne;
        private int playerTwo;

        // Player 1 and 2 changes here 
        private int playerNumber = 0;

        // Dice face
        private int dice;
        
        // The player rolls the die to get number 1 to 6
        public void play()
        {
            while (true)
            {
                Random diceRoll = new Random();
                dice = diceRoll.Next(1, 7);   
            }
        }

        // No play or Ladder or Snake
        private void playNoPlay()
        {
            Random playNoPlayRandom = new Random();
            int playNoPlayDice = playNoPlayRandom.Next(0, 3);

            // for no play
            if(playNoPlayDice == 0)
            {
                if (playerNumber == 0)
                {
                    this.playerOne = playerOne + 0;
                }
                else
                {
                    this.playerTwo = playerTwo + 0;
                }
               
            // for ladder
            } else if (playNoPlayDice == 1)
            {
                if (playerNumber == 0)
                {
                    this.playerOne = playerOne + dice;
                }
                else
                {
                    this.playerTwo = playerTwo + dice;
                }
            // for snake
            } else
            {
                if (playerNumber == 0)
                {
                    this.playerOne = playerOne - dice;
                }
                else
                {
                    this.playerTwo = playerTwo - dice;
                }
            }
        }


        private Game() { board(); }
        private void board()
        {
            for (int i = 0; i < 100; i++)
            {
                snakeBite[i] = i + 1;
                ladderClimb[i] = i + 1;
            }

            snakeBite[17 - 1] = 7; snakeBite[54 - 1] = 34; snakeBite[62 - 1] = 19;
            snakeBite[93 - 1] = 73; snakeBite[95 - 1] = 75; snakeBite[98 - 1] = 79;

            ladderClimb[4 - 1] = 14; ladderClimb[9 - 1] = 31; ladderClimb[21 - 1] = 42;
            ladderClimb[28 - 1] = 84; ladderClimb[51 - 1] = 67; ladderClimb[71 - 1] = 91;
            ladderClimb[80 - 1] = 99;
        }
    }
}
