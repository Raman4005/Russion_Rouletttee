using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRouletteAssignment
{
    public class Game
    {
        public int bulletLoad = 0;
        public int bulletsLeft = 6;
        public int bulletcount = 0;
        public int score = 0;
        public int aimAwayChances = 0;
        public int round = 1;

        Random rnd = new Random();
        public void load()
        {
            bulletLoad = rnd.Next(1, 7);
            aimAwayChances = 2;
        }

    }
}
