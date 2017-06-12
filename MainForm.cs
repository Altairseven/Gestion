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


        private void MainForm_Load(object sender, EventArgs e) {
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


    }
}
