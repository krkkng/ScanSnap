using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"C:\My Documents"以下のファイルをすべて取得
            //ワイルドカード"*"は、すべてのファイルを意味する
            string[] files = System.IO.Directory.GetFiles(
                @"C:\Users\Owner\Pictures\", "*", System.IO.SearchOption.AllDirectories);

            string now = System.DateTime.Now.Ticks.ToString();
            try
            {
                System.IO.Directory.Move(@"C:\Users\Owner\Pictures\Scan", @"C:\Users\Owner\Pictures\Scan" + now);
                System.IO.Directory.CreateDirectory(@"C:\Users\Owner\Pictures\Scan");
            }
            catch
            {
                System.IO.Directory.CreateDirectory(@"C:\Users\Owner\Pictures\Scan");
            }
        }
    }
}