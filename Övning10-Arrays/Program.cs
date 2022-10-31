namespace Övning10_Arrays {
    internal class Program {
        static void Main(string[] args) {
            Console.Title = "Arrays and so on...";
            JockanUI.showAnimation();
            JockanUI.ShowMenu(new string[] { "Add Name", "Remove Name", "Bubble Sort", "Select Sort" });
            JockanUI.WaitThenClear();
            string[] names = { "eva", "adam" };
            names = AddName("jockan", names);
            RemoveName("eva", names);
            ListNames(names);
        }

        private static void ListNames(string[] names) {
            foreach(string name in names) {
                Console.WriteLine(name);
            }
        }

        private static void RemoveName(string nameToRemove, string[] names) {
            string[] newNames = new string[names.Length - 1];
            int placeInArray = -1;
            for(int i = 0; i < names.Length; i++) {
                if(nameToRemove == names[i]) {
                    placeInArray = i;
                }
            }
            if(placeInArray < 0)
                return;

            int newArrayIndex = 0;
            for(int i = 0; i < names.Length; i++) {
                if(i != placeInArray)
                    newNames[newArrayIndex++] = names[i];
            }
            names = newNames;
        }

        private static string[] AddName(string nameToAdd, string[] names) {
            string[] newName = new string[names.Length + 1];
            for(int i = 0; i < names.Length; i++) {
                newName[i] = names[i];
            }
            newName[^1] = nameToAdd;
            return newName;
        }

        private static void BubbleSortCharArray(string[] stringArray) {
            for(int j = 0; j < stringArray.Length; j++) {
                for(int i = 1; i < stringArray.Length; i++) {
                    string name1 = stringArray[i];
                    string name2 = stringArray[i - 1];
                    if(name1.CompareTo(name2) < name2.CompareTo(name1)) {
                        stringArray[i] = name2;
                        stringArray[i - 1] = name1;
                    }
                }
            }
        }

        private static void SortCharArray(string[] stringArray) {
            for(int i = 0; i < stringArray.Length; i++) {
                int lowest = i;
                for(int j = i + 1; j < stringArray.Length; j++) {
                    if(stringArray[lowest].CompareTo(stringArray[j]) > stringArray[j].CompareTo(stringArray[lowest])) {
                        lowest = j;
                    }

                }
                string higher = stringArray[i];
                stringArray[i] = stringArray[lowest];
                stringArray[lowest] = higher;

            }
        }


    }
}