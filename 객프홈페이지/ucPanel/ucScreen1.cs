using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 객프홈페이지.ucPanel
{
    public partial class ucScreen1 : Form
    {
        public ucScreen1()
        {
            InitializeComponent();
        }
        ucPanel.ucScreen2 ucSc2 = new ucPanel.ucScreen2();
        ucPanel.ucScreen3 ucSc3 = new ucPanel.ucScreen3();
        ucPanel.ucScreen4 ucSc4 = new ucPanel.ucScreen4();
        ucPanel.ucScreen5 ucSc5 = new ucPanel.ucScreen5();
        ucPanel.ucScreen6 ucSc6 = new ucPanel.ucScreen6();
        private void ucScreen1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("환영합니다");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //예약하기
            panel2.Controls.Clear();
            panel2.Controls.Add(ucSc5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //메뉴
            panel2.Controls.Clear();
            panel2.Controls.Add(ucSc2 );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //내정보
            panel2.Controls.Clear();
            panel2.Controls.Add(ucSc4);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //ucScreenpanel
            
            
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(ucSc3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(ucSc6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
