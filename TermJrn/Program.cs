namespace TermJrn
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please pass string '' to write note");
            }
            else
            {
                Console.WriteLine($"Noted { args[0] }");
            }
        }
    }
}
