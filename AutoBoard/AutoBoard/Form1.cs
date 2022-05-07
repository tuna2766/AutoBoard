using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] time = new int[10];            //宣告時間陣列time

        string[] boardkey = new string[10];  //宣告字串陣列boardkey


        private void BoardKey1_TextChanged(object sender, EventArgs e)    //將輸入鍵儲存
        {
            boardkey[0] = BoardKey1.Text;
        }
        private void TimeCloser1_ValueChanged(object sender, EventArgs e) //將輸入時間儲存
        {
            time[0] = (int)TimeCloser1.Value;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) 
        {
            if (checkBox1.Checked == true)
            {
                timer1.Interval = 1000 * time[0];                         //延遲屬性設定(單位為毫秒)
                timer1.Enabled = true;                                    //計時器啟動
            }
            else
            {
                timer1.Enabled = false;                                   //計時器暫停
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        { 
            SendKeys.SendWait(boardkey[0]);                               //入鍵
        }
        //以上為第一個按鍵

        private void BoardKey2_TextChanged(object sender, EventArgs e)
        {
            boardkey[1] = BoardKey2.Text;
        }

        private void TimeCloser2_ValueChanged(object sender, EventArgs e)
        {
            time[1] = (int)TimeCloser2.Value;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                timer2.Interval = 1000 * time[1];                         //延遲屬性設定(單位為毫秒)
                timer2.Enabled = true;                                    //計時器啟動
            }
            else
            {
                timer2.Enabled = false;                                   //計時器暫停
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            SendKeys.SendWait(boardkey[1]);
        }
        //以上為第二個按鍵

        private void BoardKey3_TextChanged(object sender, EventArgs e)
        {
            boardkey[2] = BoardKey3.Text;
        }

        private void TimeCloser3_ValueChanged(object sender, EventArgs e)
        {
            time[2] = (int)TimeCloser3.Value;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                timer3.Interval = 1000 * time[2];                         //延遲屬性設定(單位為毫秒)
                timer3.Enabled = true;                                    //計時器啟動
            }
            else
            {
                timer3.Enabled = false;                                   //計時器暫停
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SendKeys.SendWait(boardkey[2]);
        }

        //以上為第三個按鍵

        private void BoardKey4_TextChanged(object sender, EventArgs e)
        {
            boardkey[3] = BoardKey4.Text;
        }

        private void TimeCloser4_ValueChanged(object sender, EventArgs e)
        {
            time[3] = (int)TimeCloser4.Value;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                timer4.Interval = 1000 * time[3];                         //延遲屬性設定(單位為毫秒)
                timer4.Enabled = true;                                    //計時器啟動
            }
            else
            {
                timer4.Enabled = false;                                   //計時器暫停
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            SendKeys.SendWait(boardkey[3]);
        }
        //以上為第四個按鍵

        private void BoardKey5_TextChanged(object sender, EventArgs e)
        {
            boardkey[4] = BoardKey5.Text;
        }

        private void TimeCloser5_ValueChanged(object sender, EventArgs e)
        {
            time[4] = (int)TimeCloser5.Value;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                timer5.Interval = 1000 * time[4];                         //延遲屬性設定(單位為毫秒)
                timer5.Enabled = true;                                    //計時器啟動
            }
            else
            {
                timer5.Enabled = false;                                   //計時器暫停
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            SendKeys.SendWait(boardkey[4]);
        }
        //以上為第五個按鍵
        private void BoardKey6_TextChanged(object sender, EventArgs e)
        {
            boardkey[5] = BoardKey6.Text;
        }

        private void TimeCloser6_ValueChanged(object sender, EventArgs e)
        {
            time[5] = (int)TimeCloser6.Value;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                timer6.Interval = 1000 * time[5];                         //延遲屬性設定(單位為毫秒)
                timer6.Enabled = true;                                    //計時器啟動
            }
            else
            {
                timer6.Enabled = false;                                   //計時器暫停
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            SendKeys.SendWait(boardkey[5]);
        }
        //以上為第六個按鍵
        
        private void BoardKey7_TextChanged(object sender, EventArgs e)
        {
            boardkey[6] = BoardKey7.Text;
        }
        private void TimeCloser7_ValueChanged(object sender, EventArgs e)
        {
            time[6] = (int)TimeCloser7.Value;
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                timer7.Interval = 1000 * time[6];                         //延遲屬性設定(單位為毫秒)
                timer7.Enabled = true;                                    //計時器啟動
            }
            else
            {
                timer7.Enabled = false;                                   //計時器暫停
            }
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            SendKeys.SendWait(boardkey[6]);
        }
        //以上為第七個按鍵
    }
}
