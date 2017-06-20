using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestion.Classes;

namespace Gestion.Components.Estadistica {
    public partial class E_panel1 : UserControl {
        public E_panel1() {
            InitializeComponent();
        }

        DataSet currentdata = new DataSet();
        Func_Estadistica est = new Func_Estadistica();

        void debugfill(DataTable cuadro) {
            DataRow _1 = cuadro.NewRow(); _1["(Xi)"] = 0; _1["(fi)"] = 2;
            DataRow _2 = cuadro.NewRow(); _2["(Xi)"] = 1; _2["(fi)"] = 4;
            DataRow _3 = cuadro.NewRow(); _3["(Xi)"] = 2; _3["(fi)"] = 21;
            DataRow _4 = cuadro.NewRow(); _4["(Xi)"] = 3; _4["(fi)"] = 15;
            DataRow _5 = cuadro.NewRow(); _5["(Xi)"] = 4; _5["(fi)"] = 6;
            DataRow _6 = cuadro.NewRow(); _6["(Xi)"] = 5; _6["(fi)"] = 1;
            DataRow _7 = cuadro.NewRow(); _7["(Xi)"] = 6; _7["(fi)"] = 1;
            cuadro.Rows.Add(_1); cuadro.Rows.Add(_2); cuadro.Rows.Add(_3);
            cuadro.Rows.Add(_4); cuadro.Rows.Add(_5); cuadro.Rows.Add(_6);
            cuadro.Rows.Add(_7);
        }

        private void E_panel1_Load(object sender, EventArgs e) {
            
            DataTable cuadro = new DataTable();
            currentdata.Tables.Add(cuadro);
            dataGridView1.DataSource = cuadro;
            cuadro.Columns.Add("(Xi)",typeof(Int32));
            cuadro.Columns.Add("(fi)", typeof(Int32));
            debugfill(cuadro);
            
        }

        private void button1_Click(object sender, EventArgs e) {
            DataTable Fi = est.Freq_Acum(((DataRowView)dataGridView1.Rows[0].DataBoundItem).DataView.Table);
            dataGridView1.DataSource = Fi;
        }
    }
}
