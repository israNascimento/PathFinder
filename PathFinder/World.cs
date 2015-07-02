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
        private List<List<int>> newPosition = new List<List<int>>();

        private static World instance;
        public  static World Instance
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
        private bool isSet;
        World()
        {
            isSet = false;
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
                    }
                }
                SetName("Player", 1, 1);
                SetName("Target", 5, 6);
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

        void SetName(string name, int x, int y)
        {
            _rect[x][y].name = name;
        }

        public void GetMin()
        {

        }
    }
}
