using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using BarcodeLib;

namespace PrintPage
{
    public class PrintCodeBar
    {
        static string plate;

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
            Barcode barcode = new Barcode
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                LabelFont = new Font(FontFamily.GenericMonospace, 14, FontStyle.Regular)
            };

            barcode.Encode(TYPE.CODE128, plate, Color.Black, Color.White, 200, 100);

            barcode.SaveImage(@"C:\CapturarFotoWebCam\" + plate + ".jpg", SaveTypes.JPG);
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image image = Image.FromFile(@"C:\CapturarFotoWebCam\" + plate + ".jpg");
            Point point = new Point(100, 100);
            e.Graphics.DrawImage(image, point);
        }


        public static void Main(string[] args)
        {
            plate = args[0];
            new PrintCodeBar();
        }
    }
}
