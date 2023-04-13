using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Assignment_Week5
{
    public partial class FormAwal : Form
    {
        public FormAwal()
        {
            InitializeComponent();
        }

        string halo = "Welcome to Blink Shop";
        int counter = 0;
        int counter2 = 0;
        int blink = 0;
        string nama = "";
        private void timerKetik_Tick(object sender, EventArgs e)
        {
            if (counter < halo.Length)
            {
                labelHalo.Text += halo[counter];
                counter++;
            }
            if(nama!="" && counter2 < nama.Length && counter >= halo.Length)
            {
                labelNama.Text += nama[counter2];
                counter2++;
            }
            else if(nama != "" && counter2 >= nama.Length && counter >= halo.Length)
            {
                button1.Visible = true;
                button1.Focus();
            }
            
            
        }

        private void FormAwal_Load(object sender, EventArgs e)
        {
            labelHalo.Text = "";
            labelNama.Text = "";
            timerKetik.Start();
            timerBlink.Interval = 500;
            timerBlink.Start();
            labelNama.AutoSize = false;
            labelNama.Width = 200;
            labelNama.Height = 50;
            labelNama.Visible = false;
            button1.Visible = false;
            progressBarLoading.Visible = false;
            progressBarLoading.Maximum = 1000;
            progressBarLoading.Minimum = 0;
            progressBarLoading.Step = 10;
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    nama = "...";
                }
                else
                {
                    nama = textBox1.Text;
                }
                labelName.Visible=false;
                timerBlink.Stop();
                labelEnter.Visible = false;
                textBox1.Visible = false;
                labelNama.Visible = true;
                counter = 0;
                labelHalo.Text = "";
                timerKetik.Start();
            }
        }

        private void timerBlink_Tick(object sender, EventArgs e)
        {
            if (blink % 2 == 0)
            {
                labelEnter.Visible = false;
            }
            else
            {
                labelEnter.Visible = true;
            }
            blink++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBarLoading.Visible = true;
            timerProgress.Start();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                progressBarLoading.Visible = true;
                timerProgress.Start();

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (progressBarLoading.Value < progressBarLoading.Maximum)
            {
                progressBarLoading.Value += progressBarLoading.Step;
            }
            
            else if(progressBarLoading.Value >= progressBarLoading.Maximum)
            {
                timerProgress.Stop();
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Dispose();
            }
        }
    }
}
