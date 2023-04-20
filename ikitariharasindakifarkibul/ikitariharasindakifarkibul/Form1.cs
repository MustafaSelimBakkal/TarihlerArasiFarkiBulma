using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikitariharasindakifarkibul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan Fark = Convert.ToDateTime(dateTimePicker1.Text) - Convert.ToDateTime(dateTimePicker2.Value);
            int Fark1 = Convert.ToInt32(Fark.TotalDays);
            if ((Fark1 * (-1)) == Fark1) Fark1 -= 1;
            else Fark1 += 1;

            label1.Text = "Ay : " + Fark1 / 30 + "\nGün : " + Fark1.ToString() + "\nSaat : " + (Fark1 * 60).ToString() + "\nDakika : " + (Fark1 * 60) * 60;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Sonuç :";
        }
    }
}
