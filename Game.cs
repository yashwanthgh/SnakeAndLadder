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

        private static int[] snakeBite = new int[100];
        private static int[] ladderClimb = new int[100];

        // Player 1 and 2 start from position 0
        private int playerOne;
        private int playerTwo;

        private int playerNumber = 0;
        
        // The player rolls the die to get number 1 to 6
        public void play()
        {
            while (true)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);   
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
