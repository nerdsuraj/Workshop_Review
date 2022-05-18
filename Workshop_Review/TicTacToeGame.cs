using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Review
{
     class TicTacToeGame
    {
        public static void Game()
        {
            char[] game = new char[10];
            game[0] = ' ';
            game[1] = ' ';
            game[2] = ' ';
            game[3] = ' ';
            game[4] = ' ';
            game[5] = ' ';
            game[6] = ' ';
            game[7] = ' ';
            game[8] = ' ';
            game[9] = ' ';

         // for print whatever your value you given to char[] in one way

            foreach (char c in game)
            {
                Console.WriteLine(c);
            }
            
            
        }
    }
}
