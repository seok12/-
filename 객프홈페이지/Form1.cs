using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 객프홈페이지.ucPanel;

namespace 객프홈페이지
{
    public partial class Form1 : Form
    {
        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        
        private Point mousePoint;
        

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //지금 윈도우의 좌표저장
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }
        private void button2_Click(object sender, EventArgs e)

        {


            using (ucScreen1 fd = new ucScreen1())
            {
                fd.ShowDialog();

            }


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        

        
    }
}
