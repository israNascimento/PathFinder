using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathFinder
{
    class Calc
    {
        private const int ADJACENT = 10;
        private const int DIAGONAL = 14;

        World world = World.Instance;
        Player player = Player.Instance;
        Rect up, down, left, right;

        private static Calc instance;
        public static Calc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calc();
                }
                return instance;
            }
        }
        public Calc()
        {
        }

        public void Find()
        {
            up = world._rect[player.GetX()][player.GetY() - 1];
            up.setValue(0);

            down = world._rect[player.GetX()][player.GetY() + 1];
            down.setValue(1);

            left = world._rect[player.GetX() - 1][player.GetY()];
            left.setValue(2);


            right = world._rect[player.GetX() + 1][player.GetY()];
            right.setValue(3);

            world.GetMin();
        }
    }
}
