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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.Hide();    //關閉前言畫面

            /*---開啟遊戲介面---*/

            Form2 f2;
            f2 = new Form2();
            f2.Visible = true;
            
        }
    }
}
