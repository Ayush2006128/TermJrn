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
        public static string LoadNotesFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading notes: {ex.Message}");
                return string.Empty;
            }
        }
    }
}