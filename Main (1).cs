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
        private class get_forms {
            public List<Type> Formlist = new List<Type>();

            public get_forms() {
                System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetEntryAssembly();
                Type[] Types = myAssembly.GetTypes();
                Formlist.Clear();
                foreach (Type myType in Types) {
                    if (myType.BaseType == null)
                        continue;
                    if (myType.BaseType.FullName == "System.Windows.Forms.Form")
                        Formlist.Add(myType);
                }
            }
        }
        public Main(){
            InitializeComponent();
            MaximumSize = new Size(216, Screen.PrimaryScreen.Bounds.Height);
        }

        private void Main_Load(object sender, EventArgs e){
            get_forms forms = new get_forms();
            foreach (Type form in forms.Formlist) {
                if (form.Name != "Main") {
                    FormButton newbutton = new FormButton(form.Name, form);
                    newbutton.Width = TLYP.Width-7;
                    TLYP.Controls.Add(newbutton);
                }        
            }
        }
    }
}
