using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Gestion {
    public partial class Prueba_ado2 : Form {
        public Prueba_ado2() {
            InitializeComponent();
        }

        public SqlConnection co = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Franco\Google Drive\Documentos GDrive\Facultad\Programacion II\Gestion\Gestion\Gestion.mdf;Integrated Security = True");
        public DataTable ds = new DataTable();

        private void Prueba_ado2_Load(object sender, EventArgs e) {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes", co);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);

            da.Fill(ds);

            var b = ds.DefaultView;
            string aux;
            for (int i = 0; i < ds.Rows.Count; i++) // loop en el registro.
            {
                aux = b[i]["Rsocial"].ToString();

            }
            dataGridView1.DataSource = b;
        }
    }
}
