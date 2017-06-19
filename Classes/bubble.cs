using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion.Classes {
    class bubble {

        public int[] resultado;

        public bubble(int[] array) {
            int aux;
            for (int i = 0; i <= array.Length - 2; i++) { 
                for (int j = i + 1; j <= array.Length -1; j++) { 
                    if (array[i] > array[j]) { 

                        
                        aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;   
                    }
                }
            }
            for (int i = 0; i <= array.Length -1; i++) {
                resultado[i] = array[i];
            }
        }

   
    }
}
