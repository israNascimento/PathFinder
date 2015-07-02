using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathFinder
{
    public partial class Game : Form
    {
        public static int screenWidth;
        public static int screenHeight;
        World world;
        Player player;
        Calculator calc;

        public Game()
        {
            InitializeComponent();
            CenterToParent();

            screenWidth = Width;
            screenHeight = Height;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Start();
            timer.Tick += new EventHandler(UpdateGame);

            Paint += new PaintEventHandler(DrawGame);
            world = World.Instance;
            player = Player.Instance;
            calc = new Calculator();
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void DrawGame(object sender, PaintEventArgs PaintNow)
        {
            world.Draw(PaintNow.Graphics);
        }





        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            while (world._rect[player.x][player.y].name != "Target")
            {
                calc.Calculate();
            }
                player.SetPosition();
        }
        private void OnKeyUpHandler(object sender, KeyEventArgs e)
        {
            //        sceneManager.CurrScene.GetKeyUpPressed(e);
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
