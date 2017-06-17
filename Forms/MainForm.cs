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
    public partial class MainForm : Gestion.Forms.StandardForm {
        public MainForm() {
            InitializeComponent();
        }

        public static string ConString;
        connectionstring con = new connectionstring();

        private void MainForm_Load(object sender, EventArgs e) {
            toolStripComboBox1.Items.Add("LocalDB");
            toolStripComboBox1.Items.Add("LocalSQLServer");
            toolStripComboBox1.SelectedIndex = 1;
            this.MinimumSize = new Size(FLPMain.Size.Width + 20, FLPMain.Size.Height + menuStrip1.Size.Height + 50);
            constringinit();
            setup_forms();
        }

        private void setup_forms() {
            Get_Forms1 forms = new Get_Forms1();
            foreach (Type form in forms.Formlist) {
                if (form.Name != "MainForm" && form.Name != "StandardForm") {
                    FormButton newbutton = new FormButton(form.Name, form);
                    newbutton.Width = FLP1.Width - 7;
                    if (form.GetProperty("ByMe") == null)
                        FLP3.Controls.Add(newbutton);
                    else if ((bool)form.GetProperty("ByMe").GetValue(form, null) == true)
                        FLP2.Controls.Add(newbutton);
                    else
                        FLP1.Controls.Add(newbutton);

                }
            }
        }
        private void toolStripComboBox1_IndexChanged(object sender, EventArgs e) {
            constringinit();
        }

        private void constringinit() {
            if (toolStripComboBox1.Text == "LocalSQLServer") {
                ConString = con.ConSrt(true);
            }
            else if (toolStripComboBox1.Text == "LocalDB") {
                ConString = con.ConSrt(false);
            }
        }
    }
}
