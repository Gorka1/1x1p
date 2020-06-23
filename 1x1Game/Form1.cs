using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1x1Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Width = 100;
            this.Height = 100;
            base.OnLoad(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 500);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int currentx = this.Location.X;
            int currenty = this.Location.Y;
            int sizex = this.Size.Width;
            int sizey = this.Size.Height;

            if (e.KeyCode == Keys.Up)
            {
                this.Location = new Point(currentx, currenty - 2);
                this.Size = new System.Drawing.Size(sizex + 1, sizey + 1);
            }
            if (e.KeyCode == Keys.Down)
            {
                this.Location = new Point(currentx, currenty + 2);
                this.Size = new System.Drawing.Size(sizex + 1, sizey + 1);
            }
            if (e.KeyCode == Keys.Left)
            {
                this.Location = new Point(currentx - 2, currenty);
                this.Size = new System.Drawing.Size(sizex + 1, sizey + 1);
            }
            if (e.KeyCode == Keys.Right)
            {
                this.Location = new Point(currentx + 2, currenty);
                this.Size = new System.Drawing.Size(sizex + 1, sizey + 1);
            }

            if (this.Size.Height > 50)
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                //Button button1 = new Button();
            }
        }
    }
}
