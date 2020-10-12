using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Drawing.Printing;
using System.Data;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Drawing.Imaging;

/// <summary>
/// Descripción breve de CreaTicket
/// </summary>

public class CreaTicket
{
    string ticket = "";
    string parte1, parte2;

    
    //string impresora = Procedimientos.ObtenerImpresoraPorDefecto();
     
    //"\\\\CESSRV30\\SONDA_FACTURACION"; // nombre exacto de la impresora como esta en el panel de control
     string impresora = "Microsoft Print To PDF"; // nombre exacto de la impresora como esta en el panel de control
                         

    int max, cort;
    public void LineasGuion()
    {
        // ticket = "----------------------------------------\n";   // agrega lineas separadoras -
        ticket = "======================================== \n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
    }
    public void LineasAsterisco()
    {
        ticket = "****************************************\n";   // agrega lineas separadoras *
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
    }
    public void LineasIgual()
    {
        ticket = "========================================\n";   // agrega lineas separadoras =
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
    }
    public void LineasTotales()
    {
        ticket = "                             -----------\n"; ;   // agrega lineas de total
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
    }
    public void LineasEspacios()
    {
        ticket = "                                        \n"; ;   // agrega lineas de total
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
    }
    public void EncabezadoVenta()
    {
        ticket = "Articulo         Can   P.Unit   Total  \n";   // agrega lineas de  encabezados
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void EncVenta(string part1)
    {
        ticket = part1;  // agrega lineas de  encabezados
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoIzquierda(string par1)                          // agrega texto a la izquierda
    {
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);        // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        ticket = parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoDerecha(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);           // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = 40 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
        for (int i = 0; i < max; i++)
        {
            ticket += " ";                          // agrega espacios para alinear a la derecha
        }
        ticket += parte1 + "\n";                    //Agrega el texto
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }

    public void TextoRegimen(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoRepreLegalEmpresa(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void Factura(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void FechaHora(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void DetalleArtitulos(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoTelefonoEmpresa(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoDireccionEmpresa(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoNitEmpresa(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoSoftware(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        //for (int i = 0; i < max; i++)                // **********
        //{
        //    ticket += " ";                           // Agrega espacios antes del texto a centrar
        //}                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoObservaciones(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        //for (int i = 0; i < max; i++)                // **********
        //{
        //    ticket += " ";                           // Agrega espacios antes del texto a centrar
        //}                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoDesarrollo(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        //for (int i = 0; i < max; i++)                // **********
        //{
        //    ticket += " ";                           // Agrega espacios antes del texto a centrar
        //}                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto

    }
    public void TextoNombreEmpresa(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoEncabezadoInformeDiario(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoVendedor(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoCentro(string par1)
    {
        ticket = "";
        max = par1.Length;
        if (max > 40)                                 // **********
        {
            cort = max - 40;
            parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
        }
        else { parte1 = par1; }                      // **********
        max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios antes del texto a centrar
        }                                            // **********
        ticket += parte1 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void TextoExtremos(string par1, string par2)
    {
        max = par1.Length;
        if (max > 18)                                 // **********
        {
            cort = max - 18;
            parte1 = par1.Remove(18, cort);          // si par1 es mayor que 18 lo corta
        }
        else { parte1 = par1; }                      // **********
        ticket = parte1;                             // agrega el primer parametro
        max = par2.Length;
        if (max > 18)                                 // **********
        {
            cort = max - 18;
            parte2 = par2.Remove(18, cort);          // si par2 es mayor que 18 lo corta
        }
        else { parte2 = par2; }
        max = 40 - (parte1.Length + parte2.Length);
        for (int i = 0; i < max; i++)                 // **********
        {
            ticket += " ";                            // Agrega espacios para poner par2 al final
        }                                             // **********
        ticket += parte2 + "\n";                     // agrega el segundo parametro al final
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void AgregaTotales(string par1, double total)
    {
        max = par1.Length;
        if (max > 25)                                 // **********
        {
            cort = max - 25;
            parte1 = par1.Remove(25, cort);          // si es mayor que 25 lo corta
        }
        else { parte1 = par1; }                      // **********
        ticket = parte1;
        parte2 = total.ToString("c");
        max = 40 - (parte1.Length + parte2.Length);
        for (int i = 0; i < max; i++)                // **********
        {
            ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
        }                                            // **********
        ticket += parte2 + "\n";
        RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
    }
    public void AgregaArticulo(string par1, int cant, int precio, int total)
    {
        if (cant.ToString().Length <= 3 && precio.ToString("c").Length <= 10 && total.ToString("c").Length <= 11) // valida que cant precio y total esten dentro de rango
        {
            max = par1.Length;
            if (max > 16)                                 // **********
            {
                cort = max - 16;
                parte1 = par1.Remove(16, cort);          // corta a 16 la descripcion del articulo
            }
            else { parte1 = par1; }                      // **********
            ticket = parte1;                             // agrega articulo
            //max = (3 - cant.ToString().Length) + (16 - parte1.Length);
            max = 2 + (16 - parte1.Length);
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios para poner el valor de cantidad
            }
            ticket += cant.ToString();                   // agrega cantidad
            max = 3 + (10 - precio.ToString("c").Length);
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios
            }                                            // **********
            ticket += "$ " + precio.ToString(); // agrega precio
            max = 3 + (10 - total.ToString("c").Length);
            for (int i = 0; i < max; i++)                // **********
            {
                ticket += " ";                           // Agrega espacios
            }                                            // **********
            ticket += "$ " + total.ToString() + "\n"; // agrega precio
            RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
        }
        else
        {
            //MessageBox.Show("Valores fuera de rango");
            //RawPrinterHelper.SendStringToPrinter(impresora, "Error, valor fuera de rango\n"); // imprime texto
        }
    }
    public void CortaTicket()
    {
        string corte = "\x1B" + "m";                  // caracteres de corte
        string avance = "\x1B" + "d" + "\x05";        // avanza 5 renglones
        RawPrinterHelper.SendStringToPrinter(impresora, avance); // avanza
        RawPrinterHelper.SendStringToPrinter(impresora, corte); // corta
    }
    public void AbreCajon()
    {
        string cajon0 = "\x1B" + "p" + "\x00" + "\x0F" + "\x96";                  // caracteres de apertura cajon 0
        string cajon1 = "\x1B" + "p" + "\x01" + "\x0F" + "\x96";                 // caracteres de apertura cajon 1
        string cajon2 = "27,112,48,55,121";
        RawPrinterHelper.SendStringToPrinter(impresora, cajon0); // abre cajon0
        RawPrinterHelper.SendStringToPrinter(impresora, cajon1); // abre cajon1
        RawPrinterHelper.SendStringToPrinter(impresora, cajon2); // abre cajon1
    }

    public void ImpresionContinua(string par1)
    {
        string texto = "", texto2 = "\r\n";

        texto =                  "     TICKET DE PARQUEADERO      ";
        texto = texto + texto2 + "   Servicio de paruqedero de prueba      ";
        texto = texto + texto2 + "--------------------------------";
        texto = texto + texto2 + par1;
        texto = texto + texto2 + "--------------------------------";
        texto = texto + texto2 + "Fecha: " + DateTime.Now.ToString();

        // String rootPath = Server.MapPath("~") + @"/img/logo.jpg"; 
        

         // SendImageToPrinter(50, 50, HttpContext.Current.Server.MapPath("~") + @"C:\CapturarFotoWebCam\Codigo.jpg");  
        //SendImageToPrinter(50, 50, System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + @"img\logo.JPG"); 
        //RawPrinterHelper.SendStringToPrinter("\\\\pc-1511\\EPSON", texto); // imprime texto
        RawPrinterHelper.SendStringToPrinter(impresora, texto); // imprime texto
        _ = SendImageToPrinter(50, 50, @"C:\CapturarFotoWebCam\" + par1 + ".png");
        string corte = "\x1B" + "m";                  // caracteres de corte
        string avance = "\x1B" + "d" + "\x05";        // avanza 5 renglones
        //RawPrinterHelper.SendStringToPrinter("\\\\pc-1511\\EPSON", avance); // avanza
        //RawPrinterHelper.SendStringToPrinter("\\\\pc-1511\\EPSON", corte); // corta
        //RawPrinterHelper.SendStringToPrinter(impresora, avance); // avanza
        //RawPrinterHelper.SendStringToPrinter(impresora, corte); // corta

    }

    private static string SendImageToPrinter(int top, int left, System.Drawing.Bitmap bitmap)
    {
        using (MemoryStream ms = new MemoryStream())
        using (BinaryWriter bw = new BinaryWriter(ms, Encoding.ASCII))
        {
            //we set p3 parameter, remember it is Width of Graphic in bytes,
            //so we divive the width of image and round up of it
            int P3 = (int)Math.Ceiling((double)bitmap.Width / 8);
            bw.Write(Encoding.ASCII.GetBytes(string.Format
            ("GW{0},{1},{2},{3},", top, left, P3, bitmap.Height)));
            //the width of matrix is rounded up multi of 8
            int canvasWidth = P3 * 8;
            //Now we convert image into 2 dimension binary matrix by 2 for loops below,
            //in the range of image, we get colour of pixel of image,
            //calculate the luminance in order to set value of 1 or 0
            //otherwise we set value to 1
            //Because P3 is set to byte (8 bits), so we gather 8 dots of this matrix,
            //convert into a byte then write it to memory by using shift left operator <<
            //e,g 1 << 7  ---> 10000000
            //    1 << 6  ---> 01000000
            //    1 << 3  ---> 00001000
            for (int y = 0; y < bitmap.Height; ++y)     //loop from top to bottom
            {
                for (int x = 0; x < canvasWidth; )       //from left to right
                {
                    byte abyte = 0;
                    for (int b = 0; b < 8; ++b, ++x)     //get 8 bits together and write to memory
                    {
                        int dot = 1;                     //set 1 for white,0 for black
                        //pixel still in width of bitmap,
                        //check luminance for white or black, out of bitmap set to white
                        if (x < bitmap.Width)
                        {
                            System.Drawing.Color color = bitmap.GetPixel(x, y);
                            int luminance = (int)((color.R * 0.3) + (color.G * 0.59) + (color.B * 0.11));
                            dot = luminance > 127 ? 1 : 0;
                        }
                        abyte |= (byte)(dot << (7 - b)); //shift left,
                        //then OR together to get 8 bits into a byte
                    }
                    bw.Write(abyte);
                }
            }
            bw.Write("\n");
            bw.Flush();
            //reset memory
            ms.Position = 0;
            //get encoding, I have no idea why encode page of 1252 works and fails for others
            return Encoding.GetEncoding(1252).GetString(ms.ToArray());
        }
    }


    private static System.Drawing.Bitmap RotateImg
(System.Drawing.Bitmap bmp, float angle)
    {
        angle = angle % 360;
        if (angle > 180) angle -= 360;
        float sin = (float)Math.Abs(Math.Sin(angle *
        Math.PI / 180.0)); // this function takes radians
        float cos = (float)Math.Abs(Math.Cos(angle * Math.PI / 180.0)); // this one too
        float newImgWidth = sin * bmp.Height + cos * bmp.Width;
        float newImgHeight = sin * bmp.Width + cos * bmp.Height;
        float originX = 0f;
        float originY = 0f;
        if (angle > 0)
        {
            if (angle <= 90)
                originX = sin * bmp.Height;
            else
            {
                originX = newImgWidth;
                originY = newImgHeight - sin * bmp.Width;
            }
        }
        else
        {
            if (angle >= -90)
                originY = sin * bmp.Width;
            else
            {
                originX = newImgWidth - sin * bmp.Height;
                originY = newImgHeight;
            }
        }
        System.Drawing.Bitmap newImg =
        new System.Drawing.Bitmap((int)newImgWidth, (int)newImgHeight);
        System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(newImg);
        g.Clear(System.Drawing.Color.White);
        g.TranslateTransform(originX, originY); // offset the origin to our calculated values
        g.RotateTransform(angle); // set up rotate
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
        g.DrawImageUnscaled(bmp, 0, 0); // draw the image at 0, 0
        g.Dispose();
        return newImg;
    }

    public static string SendImageToPrinter(int top, int left, string source, float angle)
    {
        System.Drawing.Bitmap bitmap = (System.Drawing.Bitmap)System.Drawing.Bitmap.FromFile(source);
        System.Drawing.Bitmap newbitmap = RotateImg(bitmap, angle);
        return SendImageToPrinter(top, left, newbitmap);
    }
    public static string SendImageToPrinter(int top, int left, string source)
    {
        System.Drawing.Bitmap bitmap = (System.Drawing.Bitmap)System.Drawing.Bitmap.FromFile(source);
        return SendImageToPrinter(top, left, bitmap);
    }


}

public class RawPrinterHelper
{
    // Structure and API declarions:
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class DOCINFOA
    {
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDocName;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pOutputFile;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDataType;
    }
    [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

    [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool ClosePrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

    [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool EndDocPrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool StartPagePrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool EndPagePrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

    // SendBytesToPrinter()
    // When the function is given a printer name and an unmanaged array
    // of bytes, the function sends those bytes to the print queue.
    // Returns true on success, false on failure.
    public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
    {
        Int32 dwError = 0, dwWritten = 0;
        IntPtr hPrinter = new IntPtr(0);
        DOCINFOA di = new DOCINFOA();
        bool bSuccess = false; // Assume failure unless you specifically succeed.

        di.pDocName = "My C#.NET RAW Document";
        di.pDataType = "RAW";

        // Open the printer.
        if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
        {
            // Start a document.
            if (StartDocPrinter(hPrinter, 1, di))
            {
                // Start a page.
                if (StartPagePrinter(hPrinter))
                {
                    // Write your bytes.
                    bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                    EndPagePrinter(hPrinter);
                }
                EndDocPrinter(hPrinter);
            }
            ClosePrinter(hPrinter);
        }
        // If you did not succeed, GetLastError may give more information
        // about why not.
        if (bSuccess == false)
        {
            dwError = Marshal.GetLastWin32Error();
        }
        return bSuccess;
    }

    public static bool SendStringToPrinter(string szPrinterName, string szString)
    {
        IntPtr pBytes;
        Int32 dwCount;
        // How many characters are in the string?
        dwCount = szString.Length;
        // Assume that the printer is expecting ANSI text, and then convert
        // the string to ANSI text.
        pBytes = Marshal.StringToCoTaskMemAnsi(szString);
        // Send the converted ANSI string to the printer.
        SendBytesToPrinter(szPrinterName, pBytes, dwCount);
        Marshal.FreeCoTaskMem(pBytes);
        return true;
    }

}