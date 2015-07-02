using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathFinder
{
    class Player
    {
        private int x, y;

        private static Player instance;
        public static Player Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Player();
                }
                return instance;
            }
        }
   
        private Player()
        {
            x = 1;
            y = 1;
        }

        public void SetPos(int _x, int _y)
        {
            World.Instance._rect[_x][_y].name = "Player";
            World.Instance._rect[x][y].name   = "Terrain";

            x = _x;
            y = _y;
            Console.Write(World.Instance._rect[x][y].name);
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

    }
}
