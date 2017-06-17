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
    public partial class MaskedTB_Ejemplo : Form
    {
        public MaskedTB_Ejemplo()
        {
            InitializeComponent();
        }

        private void MaskedTB_Ejemplo_Load(object sender, EventArgs e)
        {
            Tools T = new Tools();
            this.tb1.maskedTextBox1.Mask = ">" + T.replicate("A", 10);
            //Importante, si en el designer del control, no hacemos que lo cree como publico, cagamos
            // es decir, hay q ir a contro.designer.cs, y buscar inizialice control, y cambiar la creacion del control
            // de privado a publico

         }
    }
}
