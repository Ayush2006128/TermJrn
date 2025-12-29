namespace TermJrn.lib
{
    using System;
    using System.IO;
    public static class FileOperations
    {
        public static void SaveNotesToFile(string filePath, string notes)
        {
            try
            {
                string? directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    _ = Directory.CreateDirectory(directory ?? "TermJournal");
                }
                File.WriteAllText(filePath, notes);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving notes: {ex.Message}");
            }
        }
    }
}