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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void complete_Click(object sender, EventArgs e)     //結束
        {
            System.Environment.Exit(0);     //強制關閉所有畫面
        }

        private void restart_Click(object sender, EventArgs e)      //重新開始
        {
            this.Close();   //關閉失敗畫面

            /*---顯示前言畫面---*/

            Form1 f1;
            f1 = new Form1();
            f1.Visible = true;
        }
    }
}
