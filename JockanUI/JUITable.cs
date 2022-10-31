namespace JockanUI {
    public class JUITable {
        public static void ShowTable(string[] menuItems) {
            int i = 0;
            Console.WriteLine("{0,15} ---------------------------------", "");
            foreach(string item in menuItems) {
                if(item != null)
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