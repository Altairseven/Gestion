using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion {
    public partial class linq_test : Form {
        public linq_test() {
            InitializeComponent();
        }

        DataClasses1DataContext db;

        private void linq_test_Load(object sender, EventArgs e) {
            db = new DataClasses1DataContext(@"Data Source=FRANCO-NB\ALTAIRSQL;Initial Catalog=Gestion;Integrated Security=True");
            dataGridView1.DataSource = db.clientes;

        }

        private void button1_Click(object sender, EventArgs e) {
            var querry = from c in db.clientes
                         where c.numclie == 2106
                         select c.nombre;

            MessageBox.Show(querry.Single().ToString());

        }

        private void button2_Click(object sender, EventArgs e) {
            var querry = from c in db.clientes
                         where c.numclie == 2106
                         select new {
                             id = c.numclie,
                             nombre = c.nombre,
                             cred = c.limitecredito
                         };

            MessageBox.Show("");
        }

        private void insBT_Click(object sender, EventArgs e) {
            int newid;
            int newlc;
            if (int.TryParse(textBox1.Text, out newid) && int.TryParse(textBox3.Text, out newlc)) {
                cliente newclient = new cliente();

                    newclient.numclie = newid;
                    newclient.nombre = textBox2.Text.Trim();
                    newclient.limitecredito = newlc;

                db.clientes.InsertOnSubmit(newclient);

                db.SubmitChanges();

                

            }
            else {
                MessageBox.Show("pone numeros en el id y limite de credito");
            }
            dataGridView1.DataSource = db.clientes;
            


        }

        private void updBT_Click(object sender, EventArgs e) {

        }

        private void delBT_Click(object sender, EventArgs e) {

        }
    }
}