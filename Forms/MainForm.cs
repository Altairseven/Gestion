using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Gestion {
    public partial class MainForm : Gestion.Forms.OwnForm {
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
        
        //Hace una lista de todos los forms en el proyecto, y dependiendo de su herencia
        // los acomoda en diferentes FlowLayoutPanels.

        private void setup_forms() {
            FlowLayoutPanel[] panels = new FlowLayoutPanel[3] { FLP1, FLP2, FLP3 };
            Get_Forms[] forms = new Get_Forms[3] {
                    new Get_Forms("Gestion.Forms.EnClasesForm"),
                    new Get_Forms("Gestion.Forms.OwnForm"),
                    new Get_Forms("System.Windows.Forms.Form")
            };

            for (int i = 0; i < forms.Length; i++) {
                foreach (Type form in forms[i].Formlist) {
                    if (forms[i].Exceptions_check(form) == false) {
                        FormButton newbutton = new FormButton(form.Name, form);
                        if (forms[i].Formlist.Count > 10)
                            newbutton.Width = panels[i].Width - 27;
                        else
                            newbutton.Width = panels[i].Width - 7;
                        panels[i].Controls.Add(newbutton);
                    }
                    
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
