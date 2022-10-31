using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JockanUI {
    public class JUIGenerics {
        public static void ShowList(string[] values) {
            ShowList(values, false);
        }
        public static void ShowList(string[] values, bool numbered) {
            for(int i = 0; i < values.Length; i++) {
                if(numbered) {
                    Console.Write($"{i + 1}. ");
                }
                Console.WriteLine(values[i]);
            }

        }
    }
}
