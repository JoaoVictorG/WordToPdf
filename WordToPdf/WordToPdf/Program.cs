using System;
using System.IO;
using SautinSoft;

namespace WordToPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            f.OpenPdf(@"C:\Users\joaov\Documents\TestePdf\Teste.pdf");

            f.WordOptions.Format = SautinSoft.PdfFocus.CWordOptions.eWordDocument.Docx;
            f.ToWord(@"C:\Users\joaov\Documents\TesteWord\Teste.docx");

        }
    }
}