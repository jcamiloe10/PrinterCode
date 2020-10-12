using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

//using Microsoft.Reporting.WinForms;
//using System.Windows.Forms;
//using System.ComponentModel;
//using System.IO;
//using System.Runtime;
//using System.Runtime.InteropServices;
//using System.Security;
//using static System.Net.Mime.MediaTypeNames;

namespace GenerarCodigoBarras
{
    class ImpresionReportePDF
    {
        //#region Atributos

        //private int m_currentPageIndex;
        //private IList<Stream> m_streams;

        //#endregion

        //#region Métodos privados

        //private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        //{
        //    string RutaReporte = Application.StartupPath;

        //    //Routine to provide to the report renderer, in order to save an image for each page of the report.
        //    Stream stream = new
        //        FileStream(RutaReporte + "\\rptTirilla.rdlc" + name
        //        + "." + fileNameExtension, FileMode.Create);
        //    //FileStream(@"C:\Users\OMM\Documents\Visual Studio 2010\Projects\SiGCS\SiAdrem\Facturas\rptTirilla.rdlc" + name
        //    //    + "." + fileNameExtension, FileMode.Create);
        //    m_streams.Add(stream);
        //    return stream;
        //}

        //private void Export(LocalReport report)
        //{
        //    ////Export the given report as an EMF (Enhanced Metafile) file.
        //    //string deviceInfo =
        //    //  "<DeviceInfo>" +
        //    //  "  <OutputFormat>EMF</OutputFormat>" +
        //    //  "  <PageWidth>3.14in</PageWidth>" +
        //    //  "  <PageHeight>6in</PageHeight>" +
        //    //  "  <MarginTop>0.25in</MarginTop>" +
        //    //  "  <MarginLeft>0in</MarginLeft>" +
        //    //  "  <MarginRight>0in</MarginRight>" +
        //    //  "  <MarginBottom>0in</MarginBottom>" +
        //    //  "</DeviceInfo>";
        //    //Warning[] warnings;
        //    //m_streams = new List<Stream>();
        //    //report.Render("Image", deviceInfo, CreateStream, out warnings);
        //    //foreach (Stream stream in m_streams)
        //    //{ stream.Position = 0; }

        //    //Export the given report as an EMF (Enhanced Metafile) file.
        //    string deviceInfo =
        //      "<DeviceInfo>" +
        //      "  <OutputFormat>PDF</OutputFormat>" +
        //      "  <PageWidth>3.14in</PageWidth>" +
        //      "  <PageHeight>6in</PageHeight>" +
        //      "  <MarginTop>0.25in</MarginTop>" +
        //      "  <MarginLeft>0in</MarginLeft>" +
        //      "  <MarginRight>0in</MarginRight>" +
        //      "  <MarginBottom>0in</MarginBottom>" +
        //      "</DeviceInfo>";
        //    Warning[] warnings;
        //    m_streams = new List<Stream>();
        //    report.Render("PDF", deviceInfo, CreateStream, out warnings);
        //    foreach (Stream stream in m_streams)
        //    { stream.Position = 0; }
        //}

        //private void PrintPage(object sender, PrintPageEventArgs ev)
        //{
        //    //Handler for PrintPageEvents EMF
        //    Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);
        //    ev.Graphics.DrawImage(pageImage, ev.PageBounds);
        //    m_currentPageIndex++;
        //    ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        //}

        //private void Print()
        //{
        //    //
        //    PrintDocument printDoc;

        //    string impresora = clsDatos.fnSedeActualImpresoraTirilla(Program.IdSede);

        //    //String printerName = ImpresoraPredeterminada();
        //    if (m_streams == null || m_streams.Count == 0)
        //    { return; }

        //    printDoc = new PrintDocument();
        //    printDoc.PrinterSettings.PrinterName = impresora;
        //    if (!printDoc.PrinterSettings.IsValid)
        //    {
        //        string msg = String.Format("No se pudo encontrar la impresora \"{0}\".", impresora);
        //        MessageBox.Show(msg, "Error de Impresion");
        //        return;
        //    }
        //    printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
        //    printDoc.Print();
        //}

        //private string ImpresoraPredeterminada()
        //{
        //    //

        //    for (Int32 i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
        //    {
        //        PrinterSettings a = new PrinterSettings();
        //        a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
        //        if (a.IsDefaultPrinter)
        //        { return PrinterSettings.InstalledPrinters[i].ToString(); }
        //    }
        //    return "";
        //}

        //#endregion

        //#region Métodos públicos

        //public void Imprimir(LocalReport argReporte)
        //{
        //    //
        //    Export(argReporte);
        //    m_currentPageIndex = 0;
        //    Print();
        //}

        //#endregion

        //#region Soporte para implementación de interfaces

        //#region IDisposable

        //public void Dispose()
        //{
        //    if (m_streams != null)
        //    {
        //        foreach (Stream stream in m_streams)
        //        { stream.Close(); }
        //        m_streams = null;
        //    }
        //}

        //#endregion

        //#endregion

        #region ggfhgf
        //public void RenderReport(LocalReport Reporte)
        //{
        //    try
        //    {
        //        string RutaReporte = Application.StartupPath;
        //        //LocalReport localReport = new LocalReport();
        //        //localReport.ReportPath = Server.MapPath(pathReporte);
        //        //ReportDataSource rdsCabecera = new ReportDataSource("DataSet1", datos);
        //        //localReport.DataSources.Add(rdsCabecera);
        //        string reportType = "PDF";
        //        string mimeType;
        //        string encoding;
        //        string fileNameExtension;
        //        Warning[] warnings;
        //        string[] streams;
        //        byte[] renderedBytes;

        //        //Render 
        //        renderedBytes = Reporte.Render(
        //        reportType,
        //        //deviceInfo,
        //        null,
        //        out mimeType,
        //        out encoding,
        //        out fileNameExtension,
        //        out streams,
        //        out warnings);


        //        String filePath = RutaReporte + "\\Pedido.pdf";
        //        FileStream fs = new FileStream(filePath, FileMode.Create);
        //        fs.Write(renderedBytes, 0, renderedBytes.Length);
        //        fs.Close();
        //        ImprimirDocumentoSinAbrirlo(filePath);

        //        //lblReporte.Text = "<object id=\"objPdf\" type=\"application/pdf\"  data=\"" 
        //        //         + nombre + "\" style=\"width: 980px; height: 100%;\" >  ERROR (no 
        //        //         puede mostrarse el objeto)</object>";
        //    }
        //    catch (Exception ex)
        //    {
        //        //lblReporte.Text = ex.Message;
        //    }
        //}

        #endregion

        public void SendToPrinter()
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";                          // Seleccionar el programa para imprimir PDF por defecto
            info.FileName = @"C:\CapturarFotoWebCam\Codigo.pdf";         // Ruta hacia el fichero que quieres imprimir
            /*info.FileName = @"C:\Firmador\1.pdf";*/         // Ruta hacia el fichero que quieres imprimir
            info.CreateNoWindow = true;                   // Hacerlo sin mostrar ventana
            info.WindowStyle = ProcessWindowStyle.Hidden; // Y de forma oculta

            Process p = new Process();
            p.StartInfo = info;
            p.Start();  // Lanza el proceso

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000);          // Espera 3 segundos
            if (false == p.CloseMainWindow())
                p.Kill();                                  // Y cierra el programa de imprimir PDF's
        }

        //public void ImprimirDocumentoSinAbrirlo(string RutaPDF)
        //{
        //    var impresora = new PrinterSettings();
        //    //impresora.PrinterName = printDialog.PrintQueue.FullName;
        //    impresora.PrinterName = "Microsoft Print to PDF";
        //    Process p = new Process();
        //    p.StartInfo = new ProcessStartInfo()
        //    {
        //        CreateNoWindow = true,
        //        Verb = "PrintTo",
        //        FileName = RutaPDF,
        //        //FileName = boArchivo.UrlLocal,//put the correct path here,
        //        Arguments = impresora.PrinterName,
        //        WindowStyle = ProcessWindowStyle.Hidden
        //    };
        //    p.Start();
        //    p.Close();




            //string impresora = clsDatos.fnSedeActualImpresoraTirilla(Program.IdSede);
            //string impresora = "Microsoft Print to PDF";




            //using (StreamReader streamToPrint = new StreamReader(RutaPDF))
            //{
            //    PrintDocument pd = new PrintDocument();
            //    pd.PrinterSettings.PrinterName = impresora;
            //    pd.Print();
            //    streamToPrint.Close();
            //}

            //Process proc = new Process();
            //proc.StartInfo.FileName = RutaPDF;
            //proc.Start();
            //proc.Close();

        }

    //    public bool PrintPDF(string ghostScriptPath, int numberOfCopies, string printerName, string pdfFileName)
    //    {
    //        ProcessStartInfo startInfo = new ProcessStartInfo();
    //        startInfo.Arguments = " -dPrinted -dBATCH -dNOPAUSE -dNOSAFER -q -dNumCopies=" + Convert.ToString(numberOfCopies) + " -sDEVICE=ljet4 -sOutputFile=\"\\\\spool\\" + printerName + "\" \"" + pdfFileName + "\" ";
    //        startInfo.FileName = ghostScriptPath;
    //        startInfo.UseShellExecute = false;

    //        startInfo.RedirectStandardError = true;
    //        startInfo.RedirectStandardOutput = true;

    //        Process process = Process.Start(startInfo);

    //        Console.WriteLine(process.StandardError.ReadToEnd() + process.StandardOutput.ReadToEnd());

    //        process.WaitForExit(30000);
    //        if (process.HasExited == false) process.Kill();


    //        return process.ExitCode == 0;
    //    }
    //}
}
