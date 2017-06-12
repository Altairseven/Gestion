using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class calculo_potencia : Form
    {
        public calculo_potencia()
        {
            InitializeComponent();
        }

        public bool ByMe() {
            return true;
        }

        private void calculo_potencia_Load(object sender, EventArgs e)
        {
            this.txt_base.maskedTextBox1.Mask = "99";
            this.txt_exp.maskedTextBox1.Mask = "99";
        }
        private void calculo_potencia_Close(object sender, EventArgs e)
        {
            this.Hide();
            Main a = new Main();
            this.Close();
        }


        private void btn_calc_Click(object sender, EventArgs e)
        {
            double bas = Convert.ToDouble(this.txt_base.maskedTextBox1.Text);
            int exp = Convert.ToInt32(this.txt_exp.maskedTextBox1.Text);
            double pot = bas;
            for (int i = 1; i < exp; i++)
            {
                pot = pot * bas;
            }
            this.txt_res.maskedTextBox1.Text = pot.ToString();
            
        }

        private void fib_bn_Click(object sender, EventArgs e)
        {
            int outParse;

            // Check if the point entered is numeric or not
            if (!Int32.TryParse(FibTB.maskedTextBox1.Text, out outParse)) {
                MessageBox.Show("Solo Se permiten Numeros Enteros.");
            }
            else {
                int x = Int32.Parse(FibTB.maskedTextBox1.Text);
                if (x < 0) {
                    MessageBox.Show("Ingrese un numero de valor positivo");
                }
                else {
                    int fib1 = 0;
                    int fib2 = 1;
                    int ac = fib2;
                    MessageBox.Show("0");
                    for (int i = 1; i < x; i++) {
                        ac = fib2 + fib1;
                        fib1 = fib2;
                        fib2 = ac;
                        MessageBox.Show(ac.ToString());
                    }
                }
            }
        }
    }
}
