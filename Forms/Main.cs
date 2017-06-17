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
    public partial class Main : Form
    {
        public Main(){
            InitializeComponent();
        }

        public static string ConString;

        private void Main_Load(object sender, EventArgs e){
            comboBox1.Items.Add("LocalDB");
            comboBox1.Items.Add("LocalSQLServer");
            comboBox1.SelectedIndex = 1;

            Get_Forms forms = new Get_Forms();
            foreach (Type form in forms.Formlist) {
                if (form.Name != "Main") {
                    FormButton newbutton = new FormButton(form.Name, form);
                    newbutton.Width = TLYP.Width - 7;
                    TLYP.Controls.Add(newbutton);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == 0) { 
                connectionstring con = new connectionstring(false);
                ConString = con.ConSrt;
            }
            else {
                connectionstring con = new connectionstring(true);
                ConString = con.ConSrt;
            }
                

                
             
        }
    }
}
