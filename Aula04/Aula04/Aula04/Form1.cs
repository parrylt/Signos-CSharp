using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = monthCalendar1.SelectionStart;
            maskedTextBox1.Text = data.ToShortDateString();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime data;
            double dia, mes;

            data = Convert.ToDateTime(maskedTextBox3.Text);
            dia = data.Day;
            mes = data.Month;

            if (dia >= 21 & mes == 03 || dia <= 20 & mes == 04)
            {
                pictureBox1.Image = Properties.Resources.Aries;
                label2.Text = "Áries";
            }

            else if (dia >= 21 & mes == 04 || dia <= 20 & mes == 05)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Touro";
            }


            else if (dia >= 21 & mes == 05 || dia <= 20 & mes == 06)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Gêmeos";
            }

            else if (dia >= 21 & mes == 06 || dia <= 21 & mes == 07)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Câncer";
            }

            else if (dia >= 22 & mes == 07 || dia <= 22 & mes == 08)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Leão";
            }

            else if (dia >= 23 & mes == 08 || dia <= 22 & mes == 09)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Virgem";
            }

            else if (dia >= 23 & mes == 09 || dia <= 22 & mes == 10)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Libra";
            }

            else if (dia >= 23 & mes == 10 || dia <= 21 & mes == 11)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Escorpião";
            }

            else if (dia >= 23 & mes == 10 || dia <= 21 & mes == 11)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Escorpião";
            }

            else if (dia >= 22 & mes == 11 || dia <= 21 & mes == 12)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Sagitário";
            }

            else if (dia >= 22 & mes == 12 || dia <= 20 & mes == 01)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Capricórnio";
            }

            else if (dia >= 21 & mes == 01 || dia <= 19 & mes == 02)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Aquário";
            }

            else if (dia >= 20 & mes == 02 || dia <= 20 & mes == 03)
            {
                pictureBox1.Image = Properties.Resources.Touro;
                label2.Text = "Peixes";
            }
        }

            private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox3.Text = null;
            pictureBox1.Image = null;
            label2.Text = null;
        }
    }
}
