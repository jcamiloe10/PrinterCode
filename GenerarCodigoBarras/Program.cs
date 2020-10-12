using BarcodeLib;
using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Controls;

namespace GenerarCodigoBarras
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa = "FHH670";
           // string Contenido = placa;
            if (placa.Length != 6 )
            {
                Console.WriteLine("Debe entrar un numero de placa valido");
                return;
            }
            else
            {
               
                //Contenido = args[0];
                PdfWriter pdfwriter = new PdfWriter(@"C:\CapturarFotoWebCam\Codigo.pdf");
                PdfDocument pdf = new PdfDocument(pdfwriter);
                Document Documento = new Document(pdf, PageSize.LETTER);
                Documento.SetMargins(20, 20, 20, 20);

                Barcode Codigo = new Barcode();
                Codigo.IncludeLabel = true;
                Codigo.Alignment = AlignmentPositions.CENTER;
                Codigo.LabelFont = new Font(FontFamily.GenericMonospace, 14, FontStyle.Regular);

                System.Drawing.Image img = Codigo.Encode(TYPE.CODE128, placa, Color.Black, Color.White, 200, 100);
                //pictureBox.Image = img;

                Codigo.SaveImage(@"C:\CapturarFotoWebCam\" + placa + ".jpg", SaveTypes.JPG);

                System.Drawing.Image imgFinal = (System.Drawing.Image)Codigo.Encode(TYPE.CODE128, placa, Color.Black, Color.White, 200, 100);
                imgFinal.Save(@"C:\CapturarFotoWebCam\" + placa + ".png", ImageFormat.Png);

                imgFinal.Dispose();

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (sender, e) =>
                {
                    System.Drawing.Image i = System.Drawing.Image.FromFile(@"C:\CapturarFotoWebCam\" + placa + ".jpg");
                    System.Drawing.Point p = new System.Drawing.Point(100, 100);
                    e.Graphics.DrawImage(i, p);
                };
                pd.Print();



                var imagen = new iText.Layout.Element.Image(ImageDataFactory.Create(@"C:\CapturarFotoWebCam\" + placa + ".jpg"));

                var parrafo = new Paragraph().Add(imagen);
                Documento.Add(parrafo);
                //System.Drawing.Bitmap a = img as Bitmap;
                CreaTicket Ticket1 = new CreaTicket();
                Ticket1.ImpresionContinua(placa);
                //Ticket1.SendImageToPrinter(10, 10, "c", 90); //Codigo.Encode(TYPE.CODE128, placa, Color.Black, Color.White, 200, 100));

                //ImpresionReportePDF impresion = new ImpresionReportePDF();
                //impresion.SendToPrinter();
                ////impresion.PrintPDF(@"C:\CapturarFotoWebCam\",1, "Microsoft Print to PDF", "Codigo.pdf");
                ////impresion.ImprimirDocumentoSinAbrirlo(@"C:\CapturarFotoWebCam\Codigo.pdf");
                Documento.Close();
            }
        }

        private static void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
