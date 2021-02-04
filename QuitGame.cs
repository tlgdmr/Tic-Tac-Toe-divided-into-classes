﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class QuitGame
    {
        //Yes or No options will appear when the player want to exit.
        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Do you really want to exit ? y/Yes, n/No");
            string yesNo = Console.ReadLine().ToLower();

            if (yesNo == "y")
                Console.WriteLine("See You Again");

            if (yesNo == "n")
                Program.InitGame();

        }
    }
}
