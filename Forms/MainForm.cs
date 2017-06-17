using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Gestion {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        public static string ConString;

        private void MainForm_Load(object sender, EventArgs e) {
            toolStripComboBox1.Items.Add("LocalDB");
            toolStripComboBox1.Items.Add("LocalSQLServer");
            toolStripComboBox1.SelectedIndex = 1;

            Get_Forms forms = new Get_Forms();
            foreach (Type form in forms.Formlist) {
                if (form.Name != "MainForm") {
                    FormButton newbutton = new FormButton(form.Name, form);
                    var asd = form.GetType().GetProperty("ByMe");
                    PropertyInfo test = form.GetProperty("ByMe", BindingFlags.Public | BindingFlags.Instance);
                    
                    
                    if (test == null) {
                        newbutton.Width = GBT3.Width - 7;
                        GBT3.Controls.Add(newbutton);
                    }
                    else {


                        MessageBox.Show(test.ToString() + form.Name);
                        var la = test.GetValue(form, null);

              
                            MessageBox.Show(la.ToString());
                        //bool lalala = (bool)test.GetValue(form, null);
                        //MessageBox.Show(lalala.ToString());

                    }





                    
                }
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e) {
            if (toolStripComboBox1.SelectedIndex == 0) {
                connectionstring con = new connectionstring(false);
                ConString = con.ConSrt;
            }
            else {
                connectionstring con = new connectionstring(true);
                ConString = con.ConSrt;
            }
        }

        private void GBT1_Paint(object sender, PaintEventArgs e) {

        }

        private void GBT2_Paint(object sender, PaintEventArgs e) {

        }
    }
}
