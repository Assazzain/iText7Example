using System;

namespace iText7Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate PDF Using iText7!");

            try
            {
                GeneratePdf generatePdf = new GeneratePdf();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
