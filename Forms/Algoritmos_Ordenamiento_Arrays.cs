using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion.Forms {
    public partial class Algoritmos_Ordenamiento_Arrays : OwnForm {
        public Algoritmos_Ordenamiento_Arrays() {
            InitializeComponent();
        }

        private void Algoritmos_Ordenamiento_Arrays_Load(object sender, EventArgs e) {
            On_tab_change();
        }

        private void Random_gen(ListBox list, int count, int from, int to) {
            list.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < count; i++) {
                listBox1.Items.Add(r.Next(from, to));
            }
        }
        private void On_tab_change() {
            if (tabControl1.SelectedIndex == 0) {
                Random_gen(listBox1, 20, 1, 100);
                listBox2.Items.Clear();
            }
        }
        private void TabControl1_Selected(object sender, TabControlEventArgs e) {
            On_tab_change();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (listBox1.Items.Count != 0) {
                listBox2.Items.Clear();
                int[] arr = new int[listBox1.Items.Count];
                for (int i = 0; i < arr.Length; i++) {
                    arr[i] = (int)listBox1.Items[i];
                }
                //QuickSort(arr, 0, arr.Length -1);
                QuickSort(arr);
                foreach (int a in arr)
                    listBox2.Items.Add(a.ToString());
            }

        }
        static void QuickSort(int[] a) {
            QuickSort(a, 0, a.Length - 1);
        }

        public static void QuickSort(int[] elements, int left, int right) {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];
            while (i <= j) {
                while (elements[i].CompareTo(pivot) < 0)
                    i++;
                while (elements[j].CompareTo(pivot) > 0) 
                    j--;
                if (i <= j) {
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
                    i++;
                    j--;
                }
            }
            if (left < j) 
                QuickSort(elements, left, j);
            if (i < right)
                QuickSort(elements, i, right);
        }

    }
}
