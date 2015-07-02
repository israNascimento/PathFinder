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
        Player p;
        Calc calc;
        int a;
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
            p = Player.Instance;
            calc = Calc.Instance;
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
            calc.Find();
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
