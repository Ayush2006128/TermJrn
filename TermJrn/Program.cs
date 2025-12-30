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
                if (args[0] == "read")
                {
                    string notes = lib.FileOperations.LoadNotesFromFile(filePath);
                    Console.WriteLine(notes);
                }
                else
                {
                    string note = args[0];
                    lib.FileOperations.SaveNotesToFile(filePath, note);
                }
            }
        }
    }
}
