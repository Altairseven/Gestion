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
        private void Main_Load(object sender, EventArgs e){
            Get_Forms forms = new Get_Forms();
            foreach (Type form in forms.Formlist) {
                if (form.Name != "Main") {
                    FormButton newbutton = new FormButton(form.Name, form);
                    newbutton.Width = TLYP.Width - 7;
                    TLYP.Controls.Add(newbutton);
                }
            }


        }


    }
}
