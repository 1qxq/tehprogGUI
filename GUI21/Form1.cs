using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI21
{
    public partial class Identicalletters : Form
    {
        public Identicalletters()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            textBox1.Text = Properties.Settings.Default.str.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;


            str = this.textBox1.Text;

            string Out = Logic.LongStr(str);
            Properties.Settings.Default.str = str;
            Properties.Settings.Default.Save();



            label3.Text = Out;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }


}
    
