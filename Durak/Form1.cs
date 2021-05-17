using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak
{
    public partial class Form1 : Form
    {
        string cheat;
        public Form1()
        {
            InitializeComponent();
        }

        private void borders() 
        {
            Point m = PointToClient(Cursor.Position);
            Point degr = buttonNo.Location;
            Point l = label1.Location;
            Point Yes = buttonYes.Location;
            Point TB = textBox1.Location;
            int x = degr.X;
            int y = degr.Y;
            
        }
        private void buttonNo_MouseMove(object sender, MouseEventArgs e)
        {
            if (cheat != "Пузырек") {
                Point m = PointToClient(Cursor.Position);
                Point degr = buttonNo.Location;
                Point l = label1.Location;
                Point Yes = buttonYes.Location;
                Point TB = textBox1.Location;
                int x = degr.X;
                int y = degr.Y;
                if (m.X < degr.X + 10)
                {
                    x += 10;
                }
                if (m.Y < degr.Y + 10)
                {
                    y += 10;
                }
                if (m.X > degr.X +buttonNo.Width - 10)
                {
                    x -= 10;
                }
                if (m.Y > degr.Y + buttonNo.Height - 10)
                {
                    y -= 10;
                }
                if (x < 15)
                {
                    x += 50;
                }
                if (x + buttonNo.Width > Width - 25)
                {
                    x -= 50;
                }
                if (y < 25)
                {
                    y += 50;
                }
                if (y + buttonNo.Height > Height - 35)
                {
                    y -= 50;
                }
                if ((x >= l.X - buttonNo.Width && x <= (l.X + label1.Width)) && (y >= l.Y - buttonNo.Width && y <= (l.Y + label1.Height)))
                {
                    x = Width - 400;
                    y = Height - 200;
                }
                if ((x >= Yes.X - buttonNo.Width && x <= (Yes.X + buttonYes.Width)) && (y >= Yes.Y - buttonNo.Height && y <= (Yes.Y + buttonYes.Height)))
                {
                    x = Width - 400;
                    y = Height - 200;
                }
                if ((x >= TB.X - buttonNo.Width && x <= (TB.X + textBox1.Width)) && (y >= TB.Y - buttonNo.Height && y <= (TB.Y + textBox1.Height)))
                {
                    x = Width - 400;
                    y = Height - 200;
                }
                buttonNo.Location = new Point(x, y);
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы дурак!", "Поздравляем");
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты не дурак!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cheat = textBox1.Text;
        }

        private void buttonNo_MouseUp(object sender, MouseEventArgs e)
        {
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (cheat != "Пузырек")
            {
                Point m = PointToClient(Cursor.Position);
                Point degr = buttonNo.Location;
                Point l = label1.Location;
                Point Yes = buttonYes.Location;
                Point TB = textBox1.Location;
                if (m.X >= degr.X && m.X <= degr.X + buttonNo.Width && m.Y >= degr.Y && m.Y <= degr.Y + buttonNo.Height)
                {
                    int x = degr.X + buttonNo.Width;
                    int y = degr.Y + buttonNo.Height;
                    if (x < 15)
                    {
                        x += 100;
                    }
                    if (x + buttonNo.Width > Width - 25)
                    {
                        x -= 100;
                    }
                    if (y < 25)
                    {
                        y += 40;
                    }
                    if (y + buttonNo.Height > Height - 25)
                    {
                        y -= 40;
                    }
                    if ((x >= l.X - buttonNo.Width && x <= (l.X + label1.Width)) && (y >= l.Y - buttonNo.Width && y <= (l.Y + label1.Height)))
                    {
                        x = Width - 400;
                        y = Height - 200;
                    }
                    if ((x >= Yes.X - buttonNo.Width && x <= (Yes.X + buttonYes.Width)) && (y >= Yes.Y - buttonNo.Height && y <= (Yes.Y + buttonYes.Height)))
                    {
                        x = Width - 400;
                        y = Height - 200;
                    }
                    if ((x >= TB.X - buttonNo.Width && x <= (TB.X + textBox1.Width)) && (y >= TB.Y - buttonNo.Height && y <= (TB.Y + textBox1.Height)))
                    {
                        x = Width - 400;
                        y = Height - 200;
                    }
                    buttonNo.Location = new Point(x, y);
                }
            }
        }

        private void buttonNo_MouseHover(object sender, EventArgs e)
        {
            if (cheat != "Пузырек")
            {
                Point m = PointToClient(Cursor.Position);
                Point degr = buttonNo.Location;
                Point l = label1.Location;
                Point Yes = buttonYes.Location;
                Point TB = textBox1.Location;
                if (m.X >= degr.X && m.X <= degr.X + buttonNo.Width && m.Y >= degr.Y && m.Y <= degr.Y + buttonNo.Height)
                {
                    int x = degr.X + buttonNo.Width;
                    int y = degr.Y + buttonNo.Height;
                    if (x < 15)
                    {
                        x += 100;
                    }
                    if (x + buttonNo.Width > Width - 25)
                    {
                        x -= 100;
                    }
                    if (y < 25)
                    {
                        y += 40;
                    }
                    if (y + buttonNo.Height > Height - 25)
                    {
                        y -= 40;
                    }
                    if ((x >= l.X - buttonNo.Width && x <= (l.X + label1.Width)) && (y >= l.Y - buttonNo.Width && y <= (l.Y + label1.Height)))
                    {
                        x = Width - 400;
                        y = Height - 200;
                    }
                    if ((x >= Yes.X - buttonNo.Width && x <= (Yes.X + buttonYes.Width)) && (y >= Yes.Y - buttonNo.Height && y <= (Yes.Y + buttonYes.Height)))
                    {
                        x = Width - 400;
                        y = Height - 200;
                    }
                    if ((x >= TB.X - buttonNo.Width && x <= (TB.X + textBox1.Width)) && (y >= TB.Y - buttonNo.Height && y <= (TB.Y + textBox1.Height)))
                    {
                        x = Width - 400;
                        y = Height - 200;
                    }
                    buttonNo.Location = new Point(x, y);
                }
            }
        }
    }
}
