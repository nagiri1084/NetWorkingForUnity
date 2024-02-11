using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    class GameLogic
    {
        /// <summary>Runs all game logic.</summary>
        public static void Update()
        {
            ThreadManager.UpdateMain();
        }
    }
}