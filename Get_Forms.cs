﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion {
    class Get_Forms {
        
        public List<Type> Formlist = new List<Type>();

        public Get_Forms() {
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
}
