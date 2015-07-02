using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PathFinder
{
    class Rect
    {
        private Rectangle r;
        private Pen pen = new Pen(Color.Black, 2);
        private Dictionary<string, SolidBrush> colors = new Dictionary<string,SolidBrush>();

        public int value = 0;
        public int x;
        public int y;

        public bool hasValue;

        public string name
        {
            get;
            set;
        }

        public Rect(Rectangle _r, string _name)
        {
            r = _r;
            name = _name;
            colors.Add("Terrain", new SolidBrush(Color.DarkCyan));
            colors.Add("Player", new SolidBrush(Color.LightYellow));
            colors.Add("Target", new SolidBrush(Color.Red));
            colors.Add("Wall", new SolidBrush(Color.Yellow));
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, r);
            g.FillRectangle(colors[name], r);
        }

        public Rectangle GetRect()
        {
            return r;
        }

        public void SetValue(int _value)
        {
            if (!hasValue && !name.Equals("Wall"))
            {
                value = _value;
                hasValue = true;
            }

            if (name.Equals("Wall"))
            {
                value = 10000;
            }

        }
    }
}
