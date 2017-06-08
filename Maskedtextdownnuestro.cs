using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Maskedtextdownnuestro : UserControl
    {
        public Maskedtextdownnuestro()
        {
            InitializeComponent();
        }
       

        private void keydownevent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
                
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            this.maskedTextBox1.SelectionStart = 0;
            this.maskedTextBox1.SelectionLength = this.maskedTextBox1.Text.Length;
        }

    }
}
