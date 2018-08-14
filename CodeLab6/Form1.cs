using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab6
{
    public partial class Form1 : Form
    {
        // 돌크기, 눈금 사이즈, 흑점 사이즈,  c#은 펜과 브러쉬라는 함수가 내장되어 있음
        private int StoneSize = 18;

        private int LineSize = 20;
        private int PointSize = 8;
        private Pen pen;
        private Brush wBrush, bBrush;

        // false면 흑돌, true면 백돌
        private bool turn = false;

        private enum STONE
        { none, black, white };

        private STONE[,] Bored = new STONE[19, 19];

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            drawBoard();
        }

        private void drawBoard()
        {
            Graphics g = panel1.CreateGraphics();
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, 10, 10 + i * LineSize, 370, 10 + i * LineSize);
            }
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, 10 + i * LineSize, 10, 10 + i * LineSize, 10 + 18 * LineSize);
            }
            drawPoint(g);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            int x, y;
            x = e.X / LineSize;
            y = e.Y / LineSize;
            if (x < 0 || x >= 19 || y < 0 || y >= 19)
            {
                return;
            }
            drawStone(x, y);
        }

        private void drawStone(int x, int y)
        {
            Graphics g = panel1.CreateGraphics();
            if (Bored[x, y] == STONE.black || Bored[x, y] == STONE.white)
            {
                return;
            }
            Rectangle r = new Rectangle(10 + LineSize * x - StoneSize / 2, 10 + LineSize * y - StoneSize / 2, StoneSize, StoneSize);
            if (turn == false)
            {
                g.FillEllipse(bBrush, r);
                Bored[x, y] = STONE.black;
            }
            else
            {
                g.FillEllipse(wBrush, r);
                Bored[x, y] = STONE.white;
            }
            turn = !turn;
            checkOmok(x, y);
        }

        private void checkOmok(int x, int y)
        {
            if (checkLR(x, y) >= 5)
            {
                MessageBox.Show(Bored[x, y] + "wins");
            }
            if (checkUD(x, y) >= 5)
            {
                MessageBox.Show(Bored[x, y] + "wins");
            }
            if (checkSLASH(x, y) >= 5)
            {
                MessageBox.Show(Bored[x, y] + "wins");
            }
            if (checkBACKSLASH(x, y) >= 5)
            {
                MessageBox.Show(Bored[x, y] + "wins");
            }
        }

        private int checkLR(int x, int y)
        {
            int cnt = 1;
            for (int i = 1; i < 5; i++)
            {
                if (x + i <= 18 && Bored[x + i, y] == Bored[x, y])
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 5; i++)
            {
                if (x - i <= 18 && Bored[x - i, y] == Bored[x, y])
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            return cnt;
        }

        private int checkUD(int x, int y)
        {
            int cnt = 1;
            for (int i = 1; i < 5; i++)
            {
                if (y + i <= 18 && Bored[x, y + i] == Bored[x, y])
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 5; i++)
            {
                if (y - i <= 18 && Bored[x, y - i] == Bored[x, y])
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            return cnt;
        }

        private int checkSLASH(int x, int y)
        {
            int cnt = 1;
            for (int i = 1; i < 5; i++)
            {
                if (x + i <= 18 && y + i <= 18 && Bored[x + i, y + i] == Bored[x, y])
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 5; i++)
            {
                if (x - i <= 18 && y - i <= 18 && Bored[x - i, y - i] == Bored[x, y])
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            return cnt;
        }

        private int checkBACKSLASH(int x, int y)
        {
            int cnt = 1;
            for (int i = 1; i < 5; i++)
            {
                if (x - i <= 18 && y + i <= 18 && Bored[x - i, y + i] == Bored[x, y])
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 5; i++)
            {
                if (x + i <= 18 && y - i <= 18 && Bored[x + i, y - i] == Bored[x, y])
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            return cnt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void drawPoint(Graphics g)
        {
            for (int i = 3; i <= 15; i += 6)
            {
                for (int j = 3; j <= 15; j += 6)
                {
                    Rectangle r = new Rectangle(10 + LineSize * i - PointSize / 2, 10 + LineSize * j - PointSize / 2, PointSize, PointSize);
                    g.FillEllipse(bBrush, r);
                }
            }
        }
    }
}