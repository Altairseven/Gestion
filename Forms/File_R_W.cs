using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Gestion.Forms {
    public partial class File_R_W : OwnForm {
        public File_R_W() {
            InitializeComponent();
        }

        private void read() {
            Assembly _assembly;
            StreamReader _textStreamReader;

            try {
                _assembly = Assembly.GetExecutingAssembly();
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Gestion.Data.Services.list"));
                //textBox1.Text = _textStreamReader.ReadToEnd();
                //_textStreamReader.ReadLine();
                string line;
                while ((line = _textStreamReader.ReadLine()) != null) {
                    listBox1.Items.Add(line);
                }
            }
            catch {
                MessageBox.Show("Error accessing resources!");
            }

        }

        private void File_R_W_Load(object sender, EventArgs e) {
            read();
        }
    }
}
