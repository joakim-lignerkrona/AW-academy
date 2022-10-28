namespace ArrayCodealong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = new char[5];
            charArray[4] = 'a';
            charArray[1] = 'b';
            charArray[2] = 'c';
            charArray[3] = 'd';
            charArray[0] = 'e';


            PrintCharArray(charArray);
            SortCharArray(charArray);
            PrintCharArray(charArray);

        }

        private static void BubbleSortCharArray(char[] charArray)
        {
            for (int j = 0; j < charArray.Length; j++)
            {
                for (int i = 1; i < charArray.Length; i++)
                {
                    char name1 = charArray[i];
                    char name2 = charArray[i - 1];
                    if (name1.CompareTo(name2) < name2.CompareTo(name1))
                    {
                        charArray[i] = name2;
                        charArray[i - 1] = name1;
                    }
                }
            }
        }

        private static void SortCharArray(char[] charArray)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                int lowest = i;
                for (int j = i + 1; j < charArray.Length; j++)
                {
                    if (charArray[lowest].CompareTo(charArray[j]) > charArray[j].CompareTo(charArray[lowest]))
                    {
                        lowest = j;
                    }

                }
                char higher = charArray[i];
                charArray[i] = charArray[lowest];
                charArray[lowest] = higher;

            }
        }

        private static void PrintCharArray(char[] charArray)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write(charArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------");
        }
    }
}