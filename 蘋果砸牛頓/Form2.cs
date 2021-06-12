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
    public partial class Form2 : Form
    {
        int speed = 10;   //設定障礙物每毫秒移動量
        bool decision = false;   //蘋果是否接觸到障礙物
        public Form2()
        {
            InitializeComponent();
            timer1.Enabled = true;  //執行timer1
            timer1.Interval = 100;  //每100毫秒一輪
        }



        private void up_Click(object sender, EventArgs e)     //上鍵(W)
        {
            speed -= 1;     //障礙物每毫秒移動量下降
        }

        private void down_Click(object sender, EventArgs e)    //下鍵(S)
        {
            if (speed > 0)    //限制障礙物每毫秒移動量下限
            {
                speed += 1;     //障礙物每毫秒移動量增加
            }

        }

        private void left_Click(object sender, EventArgs e)     //左鍵(A)
        {
            if (apple.Location.X - 30 >= -43) this.apple.Location = new Point(apple.Location.X - 30, apple.Location.Y);     //蘋果向左移30
        }

        private void right_Click(object sender, EventArgs e)    //右鍵(D)
        {
            if (apple.Location.X + 30 <= 747) this.apple.Location = new Point(apple.Location.X + 30, apple.Location.Y);    //蘋果向右移30
        }

        int t = 0;  //timer1次數



        /*****障礙物移動*****/

        private void timer1_Tick(object sender, EventArgs e)
        {

            /*---bird1---*/

            Random r1 = new Random(Guid.NewGuid().GetHashCode());   //bird1隨機x軸
            if (bird1.Location.Y < -95) bird1.Location = new Point(r1.Next() % 1105 - 43, 620);    //碰頂移至底部
            else { bird1.Top -= speed; }    //bird1向上移動

            /*---bird2---*/

            if (t == 0 || t == 1) bird2.Location = new Point(-200, 620);    //不同時間出發
            Random r2 = new Random(Guid.NewGuid().GetHashCode());   //bird2隨機x軸
            if (bird2.Location.Y < -95) bird2.Location = new Point(r2.Next() % 1105 - 43, 620);    //碰頂移至底部
            else { bird2.Top -= speed; }    //bird2向上移動

            /*---bird3---*/

            if (t == 0 || t == 2) bird3.Location = new Point(-200, 620);    //不同時間出發
            Random r3 = new Random(Guid.NewGuid().GetHashCode());   //bird3隨機x軸
            if (bird3.Location.Y < -95) bird3.Location = new Point(r3.Next() % 1105 - 43, 620);    //碰頂移至底部
            else { bird3.Top -= speed + 3; }    //bird3向上移動

            /*---bird4---*/

            if (t == 0 || t == 3) bird4.Location = new Point(-200, 620);    //不同時間出發
            Random r4 = new Random(Guid.NewGuid().GetHashCode());   //bird4隨機x軸
            if (bird4.Location.Y < -95) bird4.Location = new Point(r4.Next() % 1105 - 43, 620);    //碰頂移至底部
            else { bird4.Top -= speed - 2; }      //bird4向上移動

            /*---bird5---*/

            if (t == 0 || t == 4) bird5.Location = new Point(-200, 620);    //不同時間出發
            Random r5 = new Random(Guid.NewGuid().GetHashCode());   //bird5隨機x軸
            if (bird5.Location.Y < -95) bird5.Location = new Point(r5.Next() % 1105 - 43, 620);    //碰頂移至底部
            else { bird5.Top -= speed - 1; }    //bird5向上移動

            /*---bird6---*/

            if (t == 0 || t == 5) bird6.Location = new Point(-200, 620);    //不同時間出發
            Random r6 = new Random(Guid.NewGuid().GetHashCode());   //bird6隨機x軸
            if (bird6.Location.Y < -95) bird6.Location = new Point(r6.Next() % 1105 - 43, 620);    //碰頂移至底部
            else { bird6.Top -= speed + 1; }    //bird6向上移動

            t++;    //時間經過1毫秒
            if (t % 10 == 0) speed++;   //速度增加


            /******通關******/

            if (t == 600)   //1分鐘停止
            {
                timer1.Enabled = false;     //停止timer1
                this.Close();   //關閉遊戲介面

                /*---顯示勝利畫面---*/

                Form5 f5;
                f5 = new Form5();
                f5.Visible = true;
            }


            /******失敗******/

            /*---達成失敗條件 -> 判定為true---*/
            if ((apple.Location.X >= bird1.Location.X - bird1.Width / 2 && apple.Location.X <= bird1.Location.X + bird1.Width / 2) && (apple.Location.Y <= bird1.Location.Y + bird1.Height / 2 && apple.Location.Y >= bird1.Location.Y - bird1.Height / 2)) decision = true;
            else if ((apple.Location.X >= bird2.Location.X - bird2.Width / 2 && apple.Location.X <= bird2.Location.X + bird2.Width / 2) && (apple.Location.Y <= bird2.Location.Y + bird2.Height / 2 && apple.Location.Y >= bird2.Location.Y - bird2.Height / 2)) decision = true;
            else if ((apple.Location.X >= bird3.Location.X - bird3.Width / 2 && apple.Location.X <= bird3.Location.X + bird3.Width / 2) && (apple.Location.Y <= bird3.Location.Y + bird3.Height / 2 && apple.Location.Y >= bird3.Location.Y - bird3.Height / 2)) decision = true;
            else if ((apple.Location.X >= bird4.Location.X - bird4.Width / 2 && apple.Location.X <= bird4.Location.X + bird4.Width / 2) && (apple.Location.Y <= bird4.Location.Y + bird4.Height / 2 && apple.Location.Y >= bird4.Location.Y - bird4.Height / 2)) decision = true;
            else if ((apple.Location.X >= bird5.Location.X - bird5.Width / 2 && apple.Location.X <= bird5.Location.X + bird5.Width / 2) && (apple.Location.Y <= bird5.Location.Y + bird5.Height / 2 && apple.Location.Y >= bird5.Location.Y - bird5.Height / 2)) decision = true;
            else if ((apple.Location.X >= bird6.Location.X - bird6.Width / 2 && apple.Location.X <= bird6.Location.Y + bird6.Width / 2) && (apple.Location.Y >= bird6.Location.Y - bird6.Height / 2)) decision = true;

            if (decision == true)   //判定失敗
            {
                timer1.Enabled = false;     //停止timer1
                this.Close();   //關閉遊戲介面

                /*---顯示失敗畫面---*/

                Form3 f3;
                f3 = new Form3();
                f3.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //這個不小心按到請忽略它~~
        }
    }

    /*****以下引用自：https://www.coder.work/article/1658860 *****/

    class PictureBoxEx : PictureBox
    {
        protected override void OnPaintBackground(PaintEventArgs e)     //調整picturebox背景、大小、位置
        {
            base.OnPaintBackground(e);
            for (int index = this.Parent.Controls.Count - 1; index > this.Parent.Controls.GetChildIndex(this); --index)
            {
                var ctl = this.Parent.Controls[index] as PictureBox;    //將圖片父容器的控制項集合設為Picturebox
                if (ctl == null) continue;
                var clip = ctl.RectangleToClient(this.RectangleToScreen(this.DisplayRectangle));    //取得大小
                clip.Intersect(ctl.DisplayRectangle);   //clip和ct1的交集部分取代本身
                if (clip.Width == 0 || clip.Height == 0) continue;
                var save = e.Graphics.Save();   //儲存目前狀態
                e.Graphics.TranslateTransform(ctl.Left - this.Left, ctl.Top - this.Top);    //放在原本位置
                
                /*---在重製的clip範圍內繪製原背景---*/

                using (var rgn = new Region(clip)) 
                {
                    e.Graphics.Clip = rgn;
                    InvokePaintBackground(ctl, e);
                    InvokePaint(ctl, e);
                }
                e.Graphics.Restore(save);
            }
        }

        protected override CreateParams CreateParams     //在工具箱自定義圖片背景透明的控制物件
        {
            get     //覆寫Control.CreateParams屬性為CreateParams
            {
                const int WS_EX_TRANSPARENT = 0x20;
                var cp = base.CreateParams;     //使cp傳回CreateParams屬性
                cp.ExStyle |= WS_EX_TRANSPARENT;    //指定視窗樣式值位元組合
                return cp;
            }
        }
    }

}