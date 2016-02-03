using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasualRacer.Model
{
    internal class Game
    {
        public Player Player1 { get; set; }

        public Game()
        {
            Player1 = new Player();
        }


    }
}
