using System;
using System.Collections.Generic;

//using System.Reflection; //Descomentar esto me permitira abreviar en la linea 11 y 22, Poniendo solamemente
//Assembly, en vez de System.Reflection.Assembly

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

        public Get_Forms(string target) {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetEntryAssembly();
            Type[] Types = myAssembly.GetTypes();
            Formlist.Clear();
            foreach (Type myType in Types) {
                if (myType.BaseType == null)
                    continue;
                if (myType.BaseType.FullName == target)
                    Formlist.Add(myType);
            }
        }

        public List<string> Exceptions() {
            List<string> exceptions = new List<string>();
                exceptions.Add("MainForm");
                exceptions.Add("EnClasesForm");
                exceptions.Add("OwnForm");
                exceptions.Add("MainForm");
            return exceptions;
        }

        public bool Exceptions_check(Type formToCheck) {
            foreach (string name in Exceptions()) {
                if (formToCheck.Name == name)
                    return true;
            }
            return false;
        }
    }
}
