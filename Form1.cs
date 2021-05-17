using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting
{
    public partial class Shooting : Form
    {
        public Shooting()
        {
            InitializeComponent();
        }
        int Rad = 0;
        int num = 0, done, miss, hit;
        int x = 0, y = 0;
        bool Hit = false;
        int lastX, lastY;
        private void Shooting_Load(object sender, EventArgs e)
        {
            buttonShoot.Enabled = false;
            buttonStop.Enabled = false;
            textBoxX.Enabled = false;
            textBoxY.Enabled = false;
            textBoxRad.Text = Rad.ToString();
            textBoxNum.Text = num.ToString();
            textBoxX.Text = x.ToString();
            textBoxY.Text = y.ToString();
        }
        private void checkNumber(object sender, CancelEventArgs e, ref int a, bool isSigned)
        {
            try
            {
                if (isSigned)
                    a = int.Parse((sender as TextBox).Text);
                else
                    a = (int)uint.Parse((sender as TextBox).Text);
                errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(sender as TextBox, ex.Message);
                e.Cancel = true;
                (sender as TextBox).Text = "";
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (num == 0)
                MessageBox.Show("У вас нет выстрелов!");
            else
            {
                buttonShoot.Enabled = true;
                buttonStop.Enabled = true;
                textBoxX.Enabled = true;
                textBoxY.Enabled = true;
                labelDone1.Text = done.ToString();
                labelRem1.Text = textBoxNum.Text;
                labelHit1.Text = hit.ToString();
                labelMiss1.Text = miss.ToString();
                textBoxNum.Enabled = false;
                textBoxRad.Enabled = false;
                buttonStart.Enabled = false;
            }
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            if (num == 0)
                MessageBox.Show("Выстрелы закончились!");
            else
            {
                num--;
                done++;
                labelDone1.Text = done.ToString();
                labelRem1.Text = num.ToString();
                if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(Rad, 2) & x > 0) | (x <= 0 & y <= Rad & x + y >= 0) | (x <= 0 & y >= -Rad & y - x <= 0))
                {
                    hit++;
                    labelHit1.Text = hit.ToString();
                }
                else
                {
                    miss++;
                    labelMiss1.Text = miss.ToString();
                }
                if (Math.Abs(x) > pictureBox1.Width / 2 | Math.Abs(y) > pictureBox1.Height / 2)
                    MessageBox.Show("Стреляем по воронам? Обратите внимание на размеры поля!");
                lastX = x;
                lastY = y;
                Hit = true;
                Invalidate();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonShoot.Enabled = false;
            buttonStop.Enabled = false;
            textBoxX.Enabled = false;
            textBoxY.Enabled = false;
            textBoxNum.Enabled = true;
            textBoxRad.Enabled = true;
            buttonStart.Enabled = true;
            done = miss = hit = num = 0;
            Hit = false;
            textBoxNum.Focus();
        }

        private void textBoxX_Validating(object sender, CancelEventArgs e)
        {
            checkNumber(sender, e, ref x, true);
        }
        private void textBoxY_Validating(object sender, CancelEventArgs e)
        {
            checkNumber(sender, e, ref y, true);
        }
        private void textBoxRad_Validating(object sender, CancelEventArgs e)
        { 
            checkNumber(sender, e, ref Rad, false);
            if (Rad > pictureBox1.Width / 2)
                MessageBox.Show("Мишень вышла за пределы поля! Можете продолжить или уменьшить радиус.");
        }
        private void textBoxNum_Validating(object sender, CancelEventArgs e)
        {
            checkNumber(sender, e, ref num, false);
        }

        Bitmap MyBitmap;
        Graphics gr;
        protected override void OnPaint(PaintEventArgs e)
        {
            MyBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gr = Graphics.FromImage(MyBitmap);
            base.OnPaint(e);
            DrawTarget(gr);
            if (Hit)
            {
                DrawHit(gr);
            }
            pictureBox1.Image = MyBitmap;
        }
        private void DrawHit(Graphics g)
        {
            int H = pictureBox1.Height;
            int W = pictureBox1.Width;
            SolidBrush brush = new SolidBrush(Color.PaleVioletRed);
            Pen pen = new Pen(brush);
            g.DrawEllipse(pen, lastX - 3 + W / 2, H / 2 - lastY - 3, 6, 6);
            g.FillEllipse(brush, lastX - 3 + W / 2, H / 2 - lastY - 3, 6, 6);
            g.DrawEllipse(pen, lastX - 6 + W / 2, H / 2 - lastY - 6, 12, 12);
        }
        private void DrawTarget(Graphics g)
        {
            g.Clear(Color.White);
            int H = pictureBox1.Height;
            int W = pictureBox1.Width;
            Point O = new Point(W / 2, H / 2);
            Point O1 = new Point(W / 2 - 1, H / 2);
            Point A = new Point(W / 2, 0);
            Point B = new Point(W / 2, H);
            Point C = new Point(0, H / 2);
            Point D = new Point(W, H / 2);
            Point E = new Point(W / 2, H / 2 - Rad);
            Point F = new Point(W / 2 - Rad, H / 2 - Rad);
            Point G = new Point(W / 2, H / 2 + Rad);
            Point I = new Point(W / 2 - Rad, H / 2 + Rad);
            Point[] tr1 = new Point[3];
            tr1[0] = E; tr1[1] = F; tr1[2] = O;
            Point[] tr2 = new Point[3];
            tr2[0] = G; tr2[1] = I; tr2[2] = O;
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);
            g.DrawLine(pen, A, B);
            g.DrawLine(pen, O, D);
            brush.Color = Color.Aqua;
            pen.Color = Color.Aqua;
            g.DrawEllipse(pen, O.X - Rad, O.Y - Rad, 2 * Rad, 2 * Rad);
            g.FillEllipse(brush, O.X - Rad, O.Y - Rad, 2 * Rad, 2 * Rad);
            brush.Color = Color.White;
            g.FillRectangle(brush, O.X - Rad, O.Y - Rad, Rad, 2 * Rad);
            brush.Color = Color.Aqua;
            g.FillPolygon(brush, tr1);
            g.FillPolygon(brush, tr2);
            pen.Color = Color.Black;
            g.DrawLine(pen, C, O1);
            brush.Dispose();
            pen.Dispose();
        }
    }
}
