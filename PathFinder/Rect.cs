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
        private Pen pen = new Pen(Color.Black, 3);
        private Dictionary<string, SolidBrush> colors = new Dictionary<string,SolidBrush>();
        public bool hasValue = false;
        public int value;
     
        public string name
        {
            get;
            set;
        }

        public int getValue()
        {
            return value;
        }

        public void setValue(int v)
        {
            value = v;
            hasValue = true;
        }

        public Rect(Rectangle _r, string _name)
        {
            r = _r;
            name = _name;
            colors.Add("Terrain", new SolidBrush(Color.DarkCyan));
            colors.Add("Player", new SolidBrush(Color.LightYellow));
            colors.Add("Target", new SolidBrush(Color.Red));
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
    }
}
