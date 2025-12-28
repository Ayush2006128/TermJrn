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
                File.WriteAllText(filePath, notes);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving notes: {ex.Message}");
            }
        }
    }
}