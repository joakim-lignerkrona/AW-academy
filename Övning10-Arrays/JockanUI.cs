using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning10_Arrays {
    internal class JockanUI {
        public static void ShowList(string[] names) {
            foreach(string name in names) {
                Console.WriteLine(name);
            }

        }
        public static void showAnimation() {
            showAnimation(10);
        }

        public static void showAnimation(int Seconds) {
            var stop = DateTime.Now;
            stop = stop.AddSeconds(Seconds);
            var art = Art.Walking();
            int i = 0;
            Console.CursorVisible = false;
            Console.WindowHeight = 50;
            while(stop > DateTime.Now) {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Loading application...");
                Console.WriteLine(art[i++ % art.Length]);
                Thread.Sleep(100);
            }
            Console.CursorVisible = true;
            Console.Clear();
        }

        public static void WaitThenClear() {
            Console.ReadLine();
            Console.Clear();
        }

        public static void ShowMenu(string[] menuItems) {
            int i = 0;
            Console.WriteLine("{0,15} ---------------------------------", "");
            foreach(string item in menuItems) {
                PrintTableRow(++i, item);

            }
            Console.WriteLine("{0,15} ---------------------------------", "");

        }
        static void PrintTableRow(int numberInList, string arg) {
            Console.WriteLine("{0,15}| {1,4}.| {2,-25}|", "", numberInList, arg);
        }
        public static void PrintTableRow(int numberInList, string arg, string arg2) {

        }
    }
}
