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
        private bool _GameEnded = false;
        Label[] enemies = new Label[3];

        public Form1()
        {
            InitializeComponent();

            // 적 업데이트
            Timer tmr = new Timer();
            tmr.Interval = 3000;   
            tmr.Tick += this.Tick;  
            tmr.Start();

            if (_GameEnded == false)
            {
                // 거리 업데이트
                Timer tmr2 = new Timer();
                tmr2.Interval = 50;   
                tmr2.Tick += DistanceUpdate;  
                tmr2.Start();

                // 세이브 바 업데이트
                Timer tmr3 = new Timer();
                tmr3.Interval = 1500;
                tmr3.Tick += this.SaveBarUpdate;
                tmr3.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                Label currentEnemy = new Label();

                enemies[i] = currentEnemy;
                this.Ground.Controls.Add(enemies[i]);

                enemies[i].ForeColor = Color.Red;
                enemies[i].Text = "(TRAP)";
            }
            Random rndValue = new Random();

            for (int i = 0; i < enemies.Length; i++)
            {
                int rndXE = rndValue.Next(12, 280);
                int rndEY = rndValue.Next(24, 332);

                enemies[i].Location = new Point(rndXE, rndEY);
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

                    XYValue.Text = "X :" + PlayerText.Location.X + " Y :" + PlayerText.Location.Y;

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


        private void Tick(object sender, EventArgs e)
        {
            Random rndValue = new Random();

            for (int i = 0; i < enemies.Length; i++)
            {
                int rndX = rndValue.Next(12, 280);
                int rndY = rndValue.Next(24, 332);

                enemies[i].Location = new Point(rndX, rndY);
            }
        }

        private void DistanceUpdate(object sender, EventArgs e)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                int distX = enemies[i].Location.X - PlayerText.Location.X;
                int distY = enemies[i].Location.Y - PlayerText.Location.Y;

                double result = Math.Sqrt(distX * distX + distY * distY);

                if ((int)result <= 30 && !_GameEnded)
                {
                    _GameEnded = true;

                    MessageBox.Show("유감스럽게도, 적에게 당하셨습니다.", "게임이 종료되었습니다!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void SaveBarUpdate(object sender, EventArgs e)
        {
            if (SaveBar.Value >= 100 && !_GameEnded)
            {
                SaveBar.Value = 100;
                _GameEnded = true;

                MessageBox.Show("축하합니다! 살아 남으셨습니다!", "게임이 종료되었습니다!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                SaveBar.Value += 1;
            }
        }
    }
}
