namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path.GetFiles(p => p.EndsWith(".lnk"));
            path.GetFiles(IsTextFile);

            static bool IsTextFile(string path)
            {
                return path.EndsWith(".txt");
            }
        }
    }
}