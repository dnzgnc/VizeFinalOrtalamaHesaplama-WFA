using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalOrtalamaHesaplama_WForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int vize, final, ort;
            vize = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            ort = Convert.ToInt32(vize * 0.3 + final * 0.7);
            label5.Text = ort.ToString();
            if (ort < 60)
                label6.Text = "Kaldınız.";
            else
                label6.Text = "Geçtiniz.";

        }
    }
}
