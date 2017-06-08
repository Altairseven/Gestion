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
        public Main()
        {
            InitializeComponent();
        }

        public class getforms
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetEntryAssembly();
            Type[] Types;
            public List<Type> tipo;

            public getforms() {
                Types = myAssembly.GetTypes();
                tipo = new List<Type>();
                foreach (Type myType in Types)
                {
                    if (myType.BaseType == null)
                        continue;
                    if (myType.BaseType.FullName == "System.Windows.Forms.Form")
                    {
                        tipo.Add(myType);
                    }

                }

            }
        }
            private void Main_Load(object sender, EventArgs e){
            getforms forms = new getforms(); 
            List<Button> buttons = new List<Button>();
            TableLayoutPanel tbly = new TableLayoutPanel();
            Controls.Add(tbly);
            tbly.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
            tbly.Width = Width;
            tbly.Height = this.Height - 10;
            
            tbly.ColumnCount = 1;
            tbly.Location = new Point((this.Width - tbly.Width) / 2, 10);
            //tbly.BackColor = Color.Cyan;

            
            int xform = forms.tipo.Count;
            for (int i = 0; i < forms.tipo.Count; i++) {
                if (forms.tipo[i].ToString() != "Gestion.Main") {
                    FormButton newButton = new FormButton(forms.tipo[i].ToString(), forms.tipo[i]);
                    newButton.Width = tbly.Width - 20;
                    newButton.button1.Width = tbly.Width - 20;
                    tbly.Controls.Add(newButton);
                }

            }


        }


    }
}
