using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 蘋果砸牛頓
{

    public partial class Form5 : Form
    {
        int s = 10;  //設定蘋果每毫秒移動量
        public Form5()
        {
            InitializeComponent();
            timer2.Enabled = true;  //執行timer2
            timer2.Interval = 100;  //每100毫秒一輪
        }

        private void apple1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            apple1.Top += s;
            if (apple1.Location.Y >= 326)
            {
                this.Hide();
                //砸到後開啟討戰成功介面
                timer2.Enabled = false;
                Form4 f4;
                f4 = new Form4();
                f4.Visible = true;     

            }
        }
    }
}
