using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WinLeven
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "explorer.exe";
            process1.StartInfo.Arguments = "shell:::{BB06C0E4-D293-4f75-8A90-CB05B6477EEE}";
            process1.Start();
            process1.WaitForExit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "explorer.exe";
            process1.StartInfo.Arguments = "shell:::{2559a1f8-21d7-11d4-bdaf-00c04f60b9f0}";
            process1.Start();
            process1.WaitForExit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("This will end your WinLeven session", "Closing", MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
                

                string command = "taskkill /im winleven.exe";
                Process.Start("cmd.exe", "/C " + command);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button1.BackColor = colorDialog1.Color;
            toolStrip1.BackColor = button1.BackColor;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            toolStrip1.Dock = DockStyle.Bottom;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            toolStrip1.Dock = DockStyle.Top;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            toolStrip1.Dock = DockStyle.Right;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            toolStrip1.Dock = DockStyle.Left;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            toolStripButton3.Visible = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            toolStripButton2.Visible = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            toolStripButton1.Visible = checkBox4.Checked;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "explorer.exe";
            process1.StartInfo.Arguments = "shell:::{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}";
            process1.Start();
            process1.WaitForExit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            toolStripButton4.Visible = checkBox1.Checked;
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true) { button2.Enabled = true; BackColor = Color.FromArgb(240, 240, 240); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) { button2.Enabled = false;  }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "explorer.exe";
            process1.StartInfo.Arguments = "%userprofile%/desktop";
            process1.Start();
            process1.WaitForExit();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            toolStripButton5.Visible = checkBox5.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
            button3.BackColor = colorDialog1.Color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            Opacity = (double)numericUpDown1.Value / 100;
        }
    }
}
