using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion {
    class connectionstring {

        public string ConSrt;

        string local = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Franco\GitHub\Gestion\Gestion\Gestion.mdf;Integrated Security = True";
        string Server = @"Data Source=FRANCO-NB\ALTAIRSQL;Initial Catalog=Gestion;Integrated Security=True";

        public connectionstring (bool connecttoserver) {
            if (connecttoserver == true)
                ConSrt = Server;
            else
                ConSrt = local;
        }
    }
}
