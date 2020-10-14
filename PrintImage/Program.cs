using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using BarcodeLib;

namespace PrintPage
{
    public class PrintCodeBar
    {
        static string plate;
        MemoryStream memoryStream;

        public PrintCodeBar()
        {
            GenerateCodeBar();
            Print();
        }

        private void Print()
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += Document_PrintPage;
            document.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["PrintName"];

            if (document.PrinterSettings.IsValid)
            {
                document.Print();
            }
            else
            {
                Console.WriteLine("Impresora no encontrada.");
            }
        }

        private void GenerateCodeBar()
        {
            memoryStream = new MemoryStream();
            Barcode barcode = new Barcode
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                LabelFont = new Font(FontFamily.GenericMonospace, 14, FontStyle.Regular)
            };

            barcode.Encode(TYPE.CODE128, plate, Color.Black, Color.White, 200, 100);

            barcode.SaveImage(memoryStream, SaveTypes.JPG);
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image image = Image.FromStream(memoryStream);
            Point point = new Point(0, 20);
            e.Graphics.DrawString(DateTime.Now.ToShortTimeString(), new Font("calibry", 10f), Brushes.Black, (float)0, 0f);
            e.Graphics.DrawImage(image, point);
        }

        public static void Main(string[] args)
        {
            plate = args[0];
            new PrintCodeBar();
        }
    }
}
