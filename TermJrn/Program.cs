namespace TermJrn
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "TermJournal",
                "notes.txt"
            );
            if (args.Length == 0)
            {
                Console.WriteLine("Please pass string '' to write note");
            }
            else
            {
                lib.FileOperations.SaveNotesToFile(filePath, args[0]);
                Console.WriteLine($"Noted { args[0] } to { filePath }");
            }
        }
    }
}
