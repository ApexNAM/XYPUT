using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace XYGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rndValue = new Random();

            for (int i = 0; i < 10; i++)
            {
                int rndX = rndValue.Next(12, 280);
                int rndY = rndValue.Next(24, 332);

                Trap.Location = new Point(rndX, rndY);
            }

            for (int i = 0; i < 10; i++)
            {
                int rndX = rndValue.Next(12, 280);
                int rndY = rndValue.Next(24, 332);

                PlayerText.Location = new Point(rndX, rndY);
            }
        }

 
        private void StartMove_Click(object sender, EventArgs e)
        {
            if (MoveXBox.Text != null && MoveYBox.Text != null)
            {
                int x = Convert.ToInt32(MoveXBox.Text);
                int y = Convert.ToInt32(MoveYBox.Text);

                if (x < 12 || x > 280 || y < 24 || y > 332)
                    MessageBox.Show("움직임에 실패했습니다..\n움직임 범위가 가능한 범위가 아닙니다.");
                else
                {
                    PlayerText.Location = new Point(x, y);

                    Random rndValue = new Random();


                    for (int i = 0; i < 10; i++)
                    {
                        int rndX = rndValue.Next(12, 280);
                        int rndY = rndValue.Next(24, 332);

                        Trap.Location = new Point(rndX, rndY);
                    }

                    int distX = Trap.Location.X - PlayerText.Location.X;
                    int distY = Trap.Location.Y - PlayerText.Location.Y;

                    double result = Math.Sqrt(distX * distX + distY * distY);
                    DistanceText.Text = "함정과 거리 : " + ((int)result).ToString();

                    if ((int)result <= 20)
                    {
                        MessageBox.Show("게임오버!");
                        Application.Exit();
                    }

                    XYValue.Text = "X : " + PlayerText.Location.X + " Y : " + PlayerText.Location.Y;

                    MoveXBox.Text = "0";
                    MoveYBox.Text = "0";
                }

            }
        }

        private void MoveXBox_TextChanged(object sender, EventArgs e)
        {
            int i;

            if (int.TryParse(MoveXBox.Text.Replace(",",""),out i))
            {
                MoveXBox.Text = i.ToString();
            }
            else
            {
                MoveXBox.Text = "0";
            }
        }

        private void MoveYBox_TextChanged(object sender, EventArgs e)
        {
            int i;

            if (int.TryParse(MoveYBox.Text.Replace(",", ""), out i))
            {
                MoveYBox.Text = i.ToString();
            }
            else
            {
                MoveYBox.Text = "0";
            }
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. X,Y값의 숫자를 입력하세요!\n2. 이동 버튼을 클릭!\n3. 함정과 가깝지 않게 플레이 반복!");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제작자 : 최예찬 (!CyberApex)\nSkagoGames 2022. made in Skago.");
        }
    }
}
