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

        //make a 2d array with indexes and values of a listbox
        private int[,] lstbox_to_array(ListBox lst) {
            int[,] array = new int[lst.Items.Count,2];
            for (int i = 0; i < lst.Items.Count; i++) {
                array[i,0] = i;
                array[i, 1] = Convert.ToInt32(lst.Items[i]);
            }
            return array;
        }
        private void button2_Click(object sender, EventArgs e) {
            textBox3.Text = "";
            int[,] arr = lstbox_to_array(listBox1);
            int[] sbounds = new int[2] { 0, listBox1.Items.Count}; //Stores the bounds of the search.
            int middle; //for storing midpoint of searchbounds
            int val; //for storing the value of midpoint 
            int querry; //Number searched.
            int resultindex = 0; //for storing the index of the result
            bool found = false; //inficates if the search has finished.

            if (int.TryParse(textBox2.Text, out querry) == false) {
                MessageBox.Show("Debe Ingresar un valor numerico");
            }
            else {
                while (found == false && sbounds[0] <= sbounds[1]) {
                    middle = (sbounds[0] + sbounds[1]) / 2;
                    val = arr[middle, 1];
                    if (val == querry) {
                        resultindex = middle;
                        found = true;
                    }
                    else if (val > querry)
                        sbounds[1] = middle - 1;
                    else
                        sbounds[0] = middle + 1;
                }
                if (found == false) {
                    MessageBox.Show("El numero Solicitado no esta en la lista!!");
                }
                else {
                    textBox3.Text = resultindex.ToString();
                    listBox1.SelectedIndex = resultindex;
                }
            }
        }
    }
}

