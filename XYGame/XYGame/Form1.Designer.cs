
namespace XYGame
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.XYValue = new System.Windows.Forms.Label();
            this.StartMove = new System.Windows.Forms.Button();
            this.MoveYBox = new System.Windows.Forms.TextBox();
            this.MoveXBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationRNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayerText = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Ground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SaveBar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.XYValue);
            this.panel1.Controls.Add(this.StartMove);
            this.panel1.Controls.Add(this.MoveYBox);
            this.panel1.Controls.Add(this.MoveXBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 103);
            this.panel1.TabIndex = 0;
            // 
            // SaveBar
            // 
            this.SaveBar.Location = new System.Drawing.Point(169, 8);
            this.SaveBar.Name = "SaveBar";
            this.SaveBar.Size = new System.Drawing.Size(142, 10);
            this.SaveBar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "minX : 12 / maxX : 280\r\nminY : 24 / maxY : 332\r\n";
            // 
            // XYValue
            // 
            this.XYValue.AutoSize = true;
            this.XYValue.Location = new System.Drawing.Point(197, 82);
            this.XYValue.Name = "XYValue";
            this.XYValue.Size = new System.Drawing.Size(77, 12);
            this.XYValue.TabIndex = 5;
            this.XYValue.Text = "X: 000 Y: 000";
            // 
            // StartMove
            // 
            this.StartMove.Enabled = false;
            this.StartMove.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartMove.Location = new System.Drawing.Point(169, 24);
            this.StartMove.Name = "StartMove";
            this.StartMove.Size = new System.Drawing.Size(142, 56);
            this.StartMove.TabIndex = 3;
            this.StartMove.Text = "시작!";
            this.StartMove.UseVisualStyleBackColor = true;
            this.StartMove.Click += new System.EventHandler(this.StartMove_Click);
            // 
            // MoveYBox
            // 
            this.MoveYBox.Location = new System.Drawing.Point(89, 26);
            this.MoveYBox.Name = "MoveYBox";
            this.MoveYBox.ReadOnly = true;
            this.MoveYBox.Size = new System.Drawing.Size(67, 21);
            this.MoveYBox.TabIndex = 2;
            this.MoveYBox.Text = "0";
            this.MoveYBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoveYBox.TextChanged += new System.EventHandler(this.MoveYBox_TextChanged);
            // 
            // MoveXBox
            // 
            this.MoveXBox.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.MoveXBox.Location = new System.Drawing.Point(12, 26);
            this.MoveXBox.Name = "MoveXBox";
            this.MoveXBox.ReadOnly = true;
            this.MoveXBox.Size = new System.Drawing.Size(71, 21);
            this.MoveXBox.TabIndex = 1;
            this.MoveXBox.Text = "0";
            this.MoveXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoveXBox.TextChanged += new System.EventHandler(this.MoveXBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(88, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set Y Pos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set X Pos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.startToolStripMenuItem,
            this.locationRNDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.infoToolStripMenuItem.Text = "info menu";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.howToPlayToolStripMenuItem.Text = "HowToPlay";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditToolStripMenuItem.Text = "Credit";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.startToolStripMenuItem.Text = "Game Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // locationRNDToolStripMenuItem
            // 
            this.locationRNDToolStripMenuItem.Name = "locationRNDToolStripMenuItem";
            this.locationRNDToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.locationRNDToolStripMenuItem.Text = "Location Random";
            this.locationRNDToolStripMenuItem.Click += new System.EventHandler(this.locationRNDToolStripMenuItem_Click);
            // 
            // PlayerText
            // 
            this.PlayerText.AutoSize = true;
            this.PlayerText.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlayerText.ForeColor = System.Drawing.Color.ForestGreen;
            this.PlayerText.Location = new System.Drawing.Point(124, 173);
            this.PlayerText.Name = "PlayerText";
            this.PlayerText.Size = new System.Drawing.Size(70, 12);
            this.PlayerText.TabIndex = 2;
            this.PlayerText.Tag = "Player";
            this.PlayerText.Text = "(PLAYER)";
            // 
            // Ground
            // 
            this.Ground.Controls.Add(this.PlayerText);
            this.Ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ground.Location = new System.Drawing.Point(0, 0);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(323, 450);
            this.Ground.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 9);
            this.label4.TabIndex = 7;
            this.label4.Text = "SkagoGames. made in Skago.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "XYPUT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Ground.ResumeLayout(false);
            this.Ground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartMove;
        private System.Windows.Forms.TextBox MoveYBox;
        private System.Windows.Forms.TextBox MoveXBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label PlayerText;
        private System.Windows.Forms.Label XYValue;
        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar SaveBar;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationRNDToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

