
namespace 蘋果砸牛頓
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.apple1 = new 蘋果砸牛頓.PictureBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // apple1
            // 
            this.apple1.BackColor = System.Drawing.Color.Transparent;
            this.apple1.Image = ((System.Drawing.Image)(resources.GetObject("apple1.Image")));
            this.apple1.Location = new System.Drawing.Point(212, 169);
            this.apple1.Margin = new System.Windows.Forms.Padding(0);
            this.apple1.Name = "apple1";
            this.apple1.Size = new System.Drawing.Size(92, 86);
            this.apple1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.apple1.TabIndex = 0;
            this.apple1.TabStop = false;
            this.apple1.Click += new System.EventHandler(this.apple1_Click);
            // 
            // Form5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 670);
            this.Controls.Add(this.apple1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(560, 1000);
            this.MinimumSize = new System.Drawing.Size(394, 700);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private PictureBoxEx apple1;
    }
}