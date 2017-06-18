using System;
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
    }
    class Get_Forms1 {

        public List<Type> Formlist = new List<Type>();

        public Get_Forms1() {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetEntryAssembly();
            Type[] Types = myAssembly.GetTypes();
            Formlist.Clear();
            foreach (Type myType in Types) {
                if (myType.BaseType == null)
                    continue;
                if (myType.BaseType.FullName == "Gestion.Forms.StandardForm" || myType.BaseType.FullName == "System.Windows.Forms.Form")
                    Formlist.Add(myType);
            }
        }
    }
}
