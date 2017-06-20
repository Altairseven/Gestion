using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Gestion.Classes {
    class Func_Estadistica {

        public DataTable Freq_Acum(DataTable tabla) {
            int ac = 0;

            if (tabla.Columns.Contains("Fi") == false) {
                tabla.Columns.Add("Fi", typeof(Int32));
            }                
            for (int i = 0; i < tabla.Rows.Count; i++) {
                ac += tabla.Rows[i].Field<int>("(fi)");
                tabla.Rows[i]["Fi"] = ac;
            }
            return tabla;
        }


    }
}
