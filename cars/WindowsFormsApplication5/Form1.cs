using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        int x = 0;
        int i = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ansam" && textBox2.Text == "123") 
            {
                Form2 f = new Form2();
                this.Hide();
                f.Show();
            }
            else if
             (textBox1.Text =="sara"&& textBox2.Text =="123")
            { 
                Form2 f = new Form2();
                f.Show();
               //f.Enabled(true);

            }
            else 
            {
                MessageBox.Show("the name or pass error");
                    x++;
                    if(x == 3)
                    {
                        MessageBox.Show("wait to 10 second ");
                        textBox1.Enabled=false;
                        textBox2.Enabled=false;
                        label3.Visible=true;
                        timer1.Enabled=true;
                        if (i ==0){
                        }
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             i--;
            label4.Text = i.ToString();
            if (i == 0)
            {
                
                timer1.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                label4.Visible = false;
                timer1.Enabled = false;
                i = 10;
                x = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        }

        }
    

