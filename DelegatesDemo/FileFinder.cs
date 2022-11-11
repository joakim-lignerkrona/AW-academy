namespace DelegatesDemo
{
    internal static class FileFinder
    {

        public static void GetFiles(this string path, Func<string, bool> fileFilter)
        {
            // get textfiles from path and write to console
            Console.WriteLine("Searching for files in " + path);
            string[] filePaths = Directory.GetFiles(path);
            foreach(var file in filePaths)
            {
                if(fileFilter(file))
                {
                    Console.WriteLine(file);

                }

            }

        }
    }
}
