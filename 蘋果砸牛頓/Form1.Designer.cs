
namespace 蘋果砸牛頓
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start = new System.Windows.Forms.Button();
            this.rule_detail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.BackColor = System.Drawing.Color.MistyRose;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start.Location = new System.Drawing.Point(247, 525);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(156, 58);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // rule_detail
            // 
            this.rule_detail.AutoSize = true;
            this.rule_detail.BackColor = System.Drawing.Color.Transparent;
            this.rule_detail.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rule_detail.Location = new System.Drawing.Point(2, 477);
            this.rule_detail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rule_detail.Name = "rule_detail";
            this.rule_detail.Size = new System.Drawing.Size(192, 184);
            this.rule_detail.TabIndex = 2;
            this.rule_detail.Text = "1. 按下開始鍵後即可\r\n    開始遊戲\r\n2. 使用A、D鍵可左右\r\n    移動（A為左移、D\r\n    為右移）\r\n3. 在蘋果落下期間請閃\r\n    避" +
    "障礙物，並順利砸\r\n    到牛頓即可獲勝";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "遊戲規則";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rule_detail);
            this.Controls.Add(this.start);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(560, 1000);
            this.MinimumSize = new System.Drawing.Size(394, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "前言";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label rule_detail;
        private System.Windows.Forms.Label label1;
    }
}

