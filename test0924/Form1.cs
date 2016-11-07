using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0924//猜數字0到10之間答案顯示左上角無法加密技和重新再玩一次
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int answer = 1;   //設定亂數值顯示在視窗上面
        private void Form1_Load(object sender, EventArgs e)
        {
            seettingAnswer();        //設定亂數值顯示在視窗上面
        }

        private void seettingAnswer()    //設定亂數值顯示在視窗上
        {
            Random obj = new Random();
            //answer = new Int32();
            answer = obj.Next(0,10);
            this.Text = answer.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int keyin = Convert.ToInt32(textBox1.Text);

            if (keyin > answer)
            {
                listBox1.Items.Add("低一點比較好");
            }
            else
            {
                if (keyin < answer)
                {
                    listBox1.Items.Add("高一點比較好");
                }
                else
                {
                    listBox1.Items.Add("正確");

                }
            }
        }
            
               
            
           
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

