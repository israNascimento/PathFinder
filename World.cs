using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PathFinder
{
    class World
    {
        public List<Rect> rect = new List<Rect>();
        public List<List<Rect>> _rect = new List<List<Rect>>();

        private bool isSet;
        Player player = Player.Instance;
        private static World instance;

        private int targetX, targetY;
        public static World Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new World();
                }

                return instance;
            }
        }

        World()
        {
        }



        public void Draw(Graphics g)
        {
            if (!isSet)
            {
                for (int i = 0; i < 10; i++)
                {
                    _rect.Add(new List<Rect>());
                    for (int j = 0; j < 10; j++)
                    {
                        Rectangle r = new Rectangle(i * 50, j * 50, 50, 50);
                   
                        _rect[i].Add(new Rect(r, "Terrain"));
                        _rect[i][j].x = i;
                        _rect[i][j].y = j;
                    }
                }
                targetX = 8;
                targetY = 3;
                SetName("Target", targetX, targetY);
                SetName("Wall", 4, 0);
                SetName("Wall", 4, 1);
                SetName("Wall", 4, 2);
                SetName("Wall", 4, 3);
                SetName("Wall", 4, 4);
                SetName("Wall", 4, 5);
                SetName("Wall", 4, 6);
                SetName("Wall", 4, 7);
                isSet = true;
            }
                        

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    _rect[i][j].Draw(g); 
                 
                }
            }
        }

        public int GetTargetX()
        {
            return targetX;
        }

        public int GetTargetY()
        {
            return targetY;
        }


        void SetName(string name, int x, int y)
        {
            _rect[x][y].name = name;
        }
    }
}
