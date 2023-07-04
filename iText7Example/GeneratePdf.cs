using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Text;

namespace iText7Example
{
    public class GeneratePdf
    {
        public GeneratePdf()
        {
            Console.WriteLine("Start generating pdf....");

            try
            {
                string outputPath = @"F:\Belajar\iText7\iText7Example\GeneratedPdf\output.pdf";
                PdfWriter writer = new PdfWriter(outputPath);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                string text = "Hello, world!";
                Paragraph paragraph = new Paragraph(text);
                document.Add(paragraph);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generate pdf failed!!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
