using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_exam0211
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inch2cm_Click(object sender, EventArgs e)
        {
            if (float.TryParse(InchBox.Text, out float val))
                cmLabel.Text = (float.Parse(InchBox.Text) * 2.54).ToString();
            else
                cmLabel.Text = "ERROR";
        }

        private void InchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(".")))    //숫자와 백스페이스를 제외한 나머지를 바로 처리             
            {
                e.Handled = true;
            }


        }




        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void kgBox_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void kg2pound_Click(object sender, EventArgs e)
        {
            if (float.TryParse(kgBox.Text, out float val))
               poundLabel.Text = (float.Parse(kgBox.Text) * 2.20462262).ToString();
            else
                poundLabel.Text = "ERROR";
        }

        private void kgBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a=kgBox.Text;

            
            
            
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)|| e.KeyChar == Convert.ToChar(".")))    //숫자와 백스페이스를 제외한 나머지를 바로 처리             
            {
                e.Handled = true;  
            }
            if (e.KeyChar == '.')
            {
                if (a.Contains('.')) ///.이 있으면 실행
                {
                    e.Handled = true;
                }
            }

        }
    }
}
