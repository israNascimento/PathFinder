using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathFinder
{
    class Player
    {
        World world;
        public int x;
        public int y;
        public List<Rect> rect = new List<Rect>();
        public List<Rect> trueRect = new List<Rect>();

        int valor = 500;
        int _valor = 500;
        static Player instance;
        Player()
        {
            x = 0;
            y = 0;
        }

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
        Calculator calc;

        public void SetPosition()
        {
            calc = new Calculator();
            world = World.Instance;
           // world._rect[x][y].name   = "Terrain";

            for (int i = rect.Count-1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (rect[j].value > rect[j + 1].value)
                    {
                        Rect highValue = rect[j];

                        rect[j] = rect[j + 1];
                        rect[j + 1] = highValue;
                    }
                }
            }


            for (int i = 0; i < rect.Count; i++)
            {
                world._rect[rect[i].x][rect[i].y].name = "Player";
                Console.WriteLine("--------" + rect[i].value + "------");
            }
 
            /*for (int i = 0; i <trueRect.Count; i++)
            {
                world._rect[trueRect[i].x][trueRect[i].y].name = "Player";
            }*/
        }

        public void _SetPosition(Rect r)
        {
                    x = r.x;
                    y = r.y;
                    rect.Add(r);
                           
            
          //  rect.Add(r);
        }
    }
}
