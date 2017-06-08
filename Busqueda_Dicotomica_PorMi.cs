using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion {
    public partial class Busqueda_Dicotomica_PorMi : Form {
        public Busqueda_Dicotomica_PorMi() {
            InitializeComponent();
        }

        private void Busqueda_Dicotomica_PorMi_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            int cantidad;
            if (int.TryParse(textBox1.Text, out cantidad) == false)
                MessageBox.Show("Ingrese un numero de elementos");
            else {
                Random R = new Random();
                int[] d = new int[cantidad];
                for (int i = 0; i < cantidad; i++) {
                    d[i] = R.Next(1, 100);
                }
                int aux;
                for (int i = 0; i <= cantidad -2; i++) { // el primero va a ir desde 0 a 18, osea el anteultimo numero.
                    for (int j = i + 1; j <= cantidad -1; j++) { // el segundo va a ir de 1 a 19, osea del segundo al ultimo.
                        if (d[i] > d[j]) { //si el valor del primer index es mayor que el del segundo. 

                            //intercambio los valores:

                            aux = d[i];   // Guardas el primero en aux,  
                            d[i] = d[j];  // Asignas el segundo en el primero  
                            d[j] = aux;   // guardas el aux en el segundo.  
                        }
                    }
                }
                foreach (int number in d) {
                    listBox1.Items.Add(number.ToString());
                }

            }
            
            
        }

        private void button2_Click(object sender, EventArgs e) {
            textBox3.Text = "";

            int querry;
            bool found = false;
            int start = 0;
            int end;
            int mid = 0;
            int bus = 0;
            int ResIndex = 0;
            int temp;
            if (int.TryParse(textBox2.Text, out querry) == false)
                MessageBox.Show("Ingrese un numero a buscar");
            else {
                end = listBox1.Items.Count;
                while (start < end && found == false) {
                    mid = (start + end) / 2;
                    bus = Convert.ToInt32(listBox1.Items[mid]);

                    //MessageBox.Show(bus.ToString());
                    if (bus == querry) {
                        found = true;
                        ResIndex = mid;
                    }
                    else {
                        if (querry < bus) { //if dado vuelta para que sea mas claro
                            end = mid - 1;
                        }
                        else {
                            start = mid + 1;
                        }
                    }
                }
                if (found == false) {
                    MessageBox.Show("El numero Solicitado no esta en la lista!!");
                }
                else {
                    this.textBox3.Text = ResIndex.ToString();
                    this.listBox1.SelectedIndex = ResIndex;
                }


            }
        }
    }
}
