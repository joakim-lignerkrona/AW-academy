using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JockanUI {
    public class JUIMenu {
        public static void ShowBoxMenu(string[] menuItems) {
            ShowBoxMenu(menuItems, false);
        }
        public static void ShowBoxMenu(string[] menuItems, bool numbered) {
            int i = 0;
            Console.WriteLine("{0,15} -------------------------------{1}", "", numbered ? "--" : "");
            foreach(string item in menuItems) {
                PrintTableRow(++i, item, numbered);

            }
            Console.WriteLine("{0,15} -------------------------------{1}", "", numbered ? "--" : "");

        }
        static void PrintTableRow(int numberInList, string arg, bool numbered) {
            if(numbered) {
                Console.WriteLine("{0,15}| {1,4}. {2,-25}|", "", numberInList, arg);
            }
            else {
                Console.WriteLine("{0,15}| {0,4} {2,-25}|", "", numberInList, arg);
            }

        }
        public static void PrintTableRow(int numberInList, string arg, string arg2) {

        }
    }
}
