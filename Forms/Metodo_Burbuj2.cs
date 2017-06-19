using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion {
    public partial class Metodo_Burbuj2 : Gestion.Forms.OwnForm {
        public Metodo_Burbuj2() {
            InitializeComponent();
        }


        private void Metodo_Burbuja_Load(object sender, EventArgs e) {
            Random r = new Random();  //Genera un numero Random
            for (int i = 0; i < 20; i++) { // es i < 20, xq hace de 0 a 19, tambien podriamos poner i <=19.
                lstDesordenados.Items.Add(r.Next(1, 100)); //el .Next() de r, es para que cree otro numero random
                                                           // entre 1 y 100
            }
        }

        private void btnBurbuja_Click(object sender, EventArgs e) {

            //Lo siguiente es lo que hay que hacer previamente al metodo de burbuja en si:

            //Para que cada vez q se aprete, primero limpie el contenido actual de la segunda listbox.
            lstOrdenados.Items.Clear();

            int[] d = new int[20]; //Declaracion de array de 20 numeros int.
            int aux = 0; //Declaracion de una variable auxiliar.

            // Llenamos el Array con los elementos de la primer listbox.
            for (int i = 0; i < 19; i++) {
                d[i] = (int)lstDesordenados.Items[i];
            }

            Classes.bubble burb = new Classes.bubble(d);




            for (int i = 0; i < 19; i++) {
                string textito = i.ToString() + " - " + burb.resultado[i].ToString();

                lstOrdenados.Items.Add(textito);
            }
        }


    }
}
