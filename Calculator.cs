using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathFinder
{
    class Calculator
    {
        World world = World.Instance;
        Player player = Player.Instance;

        private List<Rect> r = new List<Rect>();
        Rect aux;
        public Calculator()
        {
           
        }

        public void Calculate()
        {
            //NÃO ME ORGULHO DISSO

            if (player.x + 1 < world._rect.Count && !world._rect[player.x+1][player.y].hasValue)
            {
                world._rect[player.x + 1][player.y].SetValue(Valor(player.x + 1, player.y) + 10);
                r.Add(world._rect[player.x + 1][player.y]);
            }

            if (player.y + 1 < world._rect.Count && !world._rect[player.x][player.y+1].hasValue)
            {
                world._rect[player.x][player.y + 1].SetValue(Valor(player.x, player.y + 1) + 10);
                r.Add(world._rect[player.x][player.y+1]);
            }

            if (player.y - 1 > 0 && !world._rect[player.x][player.y-1].hasValue)
            {
                world._rect[player.x][player.y - 1].SetValue(Valor(player.x, player.y - 1) + 10);
                r.Add(world._rect[player.x][player.y-1]);
            }

            if (player.x - 1 > 0 && !world._rect[player.x - 1][player.y].hasValue)
            {
                world._rect[player.x - 1][player.y].SetValue(Valor(player.x - 1, player.y) + 10);
                r.Add(world._rect[player.x-1][player.y]);
            }

            if (player.x - 1 > 0 && player.y - 1 > 0 && !world._rect[player.x - 1][player.y -1].hasValue)
            {
                world._rect[player.x - 1][player.y - 1].SetValue(Valor(player.x - 1, player.y - 1) + 14);
                r.Add(world._rect[player.x - 1][player.y-1]);
            }

            if (player.x - 1 > 0 && player.y + 1 < world._rect.Count && !world._rect[player.x - 1][player.y +1].hasValue)
            {
                world._rect[player.x - 1][player.y + 1].SetValue(Valor(player.x - 1, player.y + 1) + 14);
                r.Add(world._rect[player.x - 1][player.y+1]);
            }

            if (player.x + 1 < world._rect.Count && player.y - 1 > 0 && !world._rect[player.x + 1][player.y-1].hasValue)
            {
                world._rect[player.x + 1][player.y - 1].SetValue(Valor(player.x + 1, player.y - 1) + 14);
                r.Add(world._rect[player.x + 1][player.y - 1]);
            }

            if (player.x + 1 < world._rect.Count && player.y + 1 < world._rect.Count && !world._rect[player.x + 1][player.y+1].hasValue)
            {
                world._rect[player.x + 1][player.y + 1].SetValue(Valor(player.x + 1, player.y + 1) + 14);
                r.Add(world._rect[player.x + 1][player.y+1]);
            }

            int inicialValor = 8000;
            for (int i = 0; i < r.Count; i++)
            {
                if (r[i].value < inicialValor)
                {
                    inicialValor = r[i].value;
                    aux = r[i];
                }
            }
            Console.Write(aux.value);
            player._SetPosition(aux);
            r.Clear();

  
        }

        private int Valor(int _x, int _y)
        {
            int result = (Math.Abs((world.GetTargetX() - _x)) + Math.Abs((world.GetTargetY() - _y)))*10;
            return result;
        }
    }
}
