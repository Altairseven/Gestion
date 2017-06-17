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
    public partial class ejemplo_separar_par_impar : Gestion.Forms.StandardForm {
        public ejemplo_separar_par_impar()
        {
            InitializeComponent();
        }

        public static bool ByMe {
            get {
                return false;
            }
            set {
            }
        }

        private void ejemplo_separar_par_impar_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 1; i <= 20; i++)
            {
                this.Lst_num.Items.Add(r.Next(1, 100));
            }
            this.Lst_num.SelectedIndex = 0;
        }

        private void bt_separar_Click(object sender, EventArgs e)
        {
            int aux;
            for (int i = 0; i < Lst_num.Items.Count - 1; i++)
            {
                aux = Convert.ToInt32(Lst_num.Items[i]);
                if (aux % 2 == 0)
                {
                    lst_p.Items.Add(aux.ToString());
                }
                else
                {
                    lst_i.Items.Add(aux.ToString());
                }
            }
        }
    }
}
