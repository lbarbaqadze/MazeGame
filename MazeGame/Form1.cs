using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        private int speed = 15;
        private int x = 20, y = 30, n = 20, m = 20;
        public Form1()
        {
            InitializeComponent();
        }
        private void key_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Right:
                    x += speed;
                    break;
                case Keys.Left:
                    x -= speed;
                    break;
                case Keys.Up:
                    y -= speed;
                    break;
                case Keys.Down:
                    y += speed;
                    break;
            }
            this.Invalidate();
        }
        private void paint_Paint(object sender, PaintEventArgs e)
        {
            // e.Graphics.FillRectangle(Brushes.Black, x, y, n, m);
            e.Graphics.DrawImage(new Bitmap("icons8-exercise-100.png"), x, y, n, m);
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();


            if(label1.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label2.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label3.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label4.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label5.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label6.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label7.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label8.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label9.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label10.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label11.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label12.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label13.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label14.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label15.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label16.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label17.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label18.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label19.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label20.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label21.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label22.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label23.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label24.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label25.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label26.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label27.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label28.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label29.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label30.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label31.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label32.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label33.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if (label34.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f2.Show();
            }
            if(pictureBox1.Bounds.IntersectsWith(new Rectangle(x, y, n, m)))
            {
                f3.Show();
                
            }

        }
    }
}
