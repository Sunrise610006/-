
namespace 蘋果砸牛頓
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.apple = new 蘋果砸牛頓.PictureBoxEx();
            this.bird6 = new 蘋果砸牛頓.PictureBoxEx();
            this.bird5 = new 蘋果砸牛頓.PictureBoxEx();
            this.bird4 = new 蘋果砸牛頓.PictureBoxEx();
            this.bird3 = new 蘋果砸牛頓.PictureBoxEx();
            this.bird2 = new 蘋果砸牛頓.PictureBoxEx();
            this.bird1 = new 蘋果砸牛頓.PictureBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.left.Location = new System.Drawing.Point(512, 466);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(97, 41);
            this.left.TabIndex = 2;
            this.left.Text = "←(&A)";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.right.Location = new System.Drawing.Point(698, 466);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(90, 41);
            this.right.TabIndex = 3;
            this.right.Text = "→(&D)";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // down
            // 
            this.down.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.down.Location = new System.Drawing.Point(615, 466);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(77, 41);
            this.down.TabIndex = 6;
            this.down.Text = "↓(&S)";
            this.down.UseVisualStyleBackColor = true;
            // 
            // up
            // 
            this.up.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.up.Location = new System.Drawing.Point(599, 419);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(107, 41);
            this.up.TabIndex = 7;
            this.up.Text = "↑(&W)";
            this.up.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // apple
            // 
            this.apple.BackColor = System.Drawing.Color.Transparent;
            this.apple.Image = ((System.Drawing.Image)(resources.GetObject("apple.Image")));
            this.apple.Location = new System.Drawing.Point(348, 130);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(86, 83);
            this.apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.apple.TabIndex = 28;
            this.apple.TabStop = false;
            // 
            // bird6
            // 
            this.bird6.BackColor = System.Drawing.Color.Transparent;
            this.bird6.Image = ((System.Drawing.Image)(resources.GetObject("bird6.Image")));
            this.bird6.Location = new System.Drawing.Point(172, 551);
            this.bird6.Name = "bird6";
            this.bird6.Size = new System.Drawing.Size(100, 84);
            this.bird6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bird6.TabIndex = 34;
            this.bird6.TabStop = false;
            // 
            // bird5
            // 
            this.bird5.BackColor = System.Drawing.Color.Transparent;
            this.bird5.Image = ((System.Drawing.Image)(resources.GetObject("bird5.Image")));
            this.bird5.Location = new System.Drawing.Point(454, 551);
            this.bird5.Name = "bird5";
            this.bird5.Size = new System.Drawing.Size(117, 92);
            this.bird5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bird5.TabIndex = 33;
            this.bird5.TabStop = false;
            // 
            // bird4
            // 
            this.bird4.BackColor = System.Drawing.Color.Transparent;
            this.bird4.Image = ((System.Drawing.Image)(resources.GetObject("bird4.Image")));
            this.bird4.Location = new System.Drawing.Point(620, 551);
            this.bird4.Name = "bird4";
            this.bird4.Size = new System.Drawing.Size(72, 84);
            this.bird4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bird4.TabIndex = 32;
            this.bird4.TabStop = false;
            // 
            // bird3
            // 
            this.bird3.BackColor = System.Drawing.Color.Transparent;
            this.bird3.Image = ((System.Drawing.Image)(resources.GetObject("bird3.Image")));
            this.bird3.Location = new System.Drawing.Point(735, 551);
            this.bird3.Name = "bird3";
            this.bird3.Size = new System.Drawing.Size(91, 84);
            this.bird3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bird3.TabIndex = 31;
            this.bird3.TabStop = false;
            // 
            // bird2
            // 
            this.bird2.BackColor = System.Drawing.Color.Transparent;
            this.bird2.Image = ((System.Drawing.Image)(resources.GetObject("bird2.Image")));
            this.bird2.Location = new System.Drawing.Point(-4, 551);
            this.bird2.Name = "bird2";
            this.bird2.Size = new System.Drawing.Size(93, 58);
            this.bird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bird2.TabIndex = 30;
            this.bird2.TabStop = false;
            // 
            // bird1
            // 
            this.bird1.BackColor = System.Drawing.Color.Transparent;
            this.bird1.Image = ((System.Drawing.Image)(resources.GetObject("bird1.Image")));
            this.bird1.Location = new System.Drawing.Point(325, 551);
            this.bird1.Name = "bird1";
            this.bird1.Size = new System.Drawing.Size(77, 106);
            this.bird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bird1.TabIndex = 29;
            this.bird1.TabStop = false;
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(825, 564);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.up);
            this.Controls.Add(this.down);
            this.Controls.Add(this.bird6);
            this.Controls.Add(this.bird5);
            this.Controls.Add(this.bird4);
            this.Controls.Add(this.bird3);
            this.Controls.Add(this.bird2);
            this.Controls.Add(this.bird1);
            this.MaximumSize = new System.Drawing.Size(1161, 697);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "挑戰遊戲";
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Timer timer1;
        private PictureBoxEx apple;
        private PictureBoxEx bird1;
        private PictureBoxEx bird2;
        private PictureBoxEx bird3;
        private PictureBoxEx bird4;
        private PictureBoxEx bird5;
        private PictureBoxEx bird6;
    }
}