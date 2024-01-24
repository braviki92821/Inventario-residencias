using Inventario_residencias.Interfaces;
using Inventario_residencias.Modelos;
using Inventario_residencias.Properties;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Imaging;

namespace Inventario_residencias.Repositorio
{
    public class ReporteRepositorio : ConexionMysql, IReporteRepositorio
    {

        public ReporteRepositorio()
        {
        }

        public void GenerarReporteGeneral(string[] colums, float[] tamanios, string campos)
        {
            string query = "SELECT " + campos + " FROM inventario";

            MySqlDataReader mReader = null;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf File |*.pdf";
      
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = sqlConnection();
                mReader = mySqlCommand.ExecuteReader();
                PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
                PdfDocument pdf = new PdfDocument(pdfWriter);
                PageSize tamañoH = new PageSize(792, 612);
                Document document = new Document(pdf, tamañoH);
                document.SetMargins(60, 20, 55, 20);

                PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (string columna in colums)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                }

                try
                {
                    while (mReader.Read())
                    {
                        if (colums.Contains("numeroFisico"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["numeroFisico"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("descripcion"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["descripcion"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("tablero"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["tablero"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("columna"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["columna"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("fila"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["fila"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("ubicacion"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["ubicacion"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("existencia"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["existencia"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("fechaCompra"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["fechaCompra"].ToString()).SetFont(fontContenido)));
                    }
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                finally
                {
                    CloseCommand(mySqlCommand);
                    sqlConnection().Close();
                    CloseReader(mReader);
                }

                document.Add(tabla);
                document.Close();

                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create(imagen())).SetWidth(50);
                var Ilogo = new Paragraph("").Add(logo);

                var titulo = new Paragraph("Reporte General de Inventario");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetBold();
                titulo.SetFontSize(16);

                var autor = new Paragraph("Reporte Generado por: " + Session.nombre);
                autor.SetTextAlignment(TextAlignment.CENTER);
                autor.SetFontSize(12);
  

                PdfDocument pdfDocument = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter(new FileStream(sfd.FileName, FileMode.Create)));
                Document doc = new Document(pdfDocument);

                int numeros = pdfDocument.GetNumberOfPages();

                for (int i = 1; i <= numeros; i++)
                {
                    float y = (pdfDocument.GetPage(i).GetPageSize().GetTop() - 15);
                    doc.ShowTextAligned(Ilogo, 40, y + 10, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(autor, 620, y - 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(titulo, 396, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(new Paragraph(String.Format("Pagina {0} de {1}", 1, numeros)),
                        pdfDocument.GetPage(i).GetPageSize().GetWidth() / 2,
                        pdfDocument.GetPage(i).GetPageSize().GetBottom() + 30, i,
                        TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                }
                doc.Close();
                MessageBox.Show("Reporte Generado Correctamente");
            }
        }

        public void GenerarReporteTablero(string[] colums, float[] tamanios, string campos, string tablero, string Letra)
        {
            string query = "SELECT " + campos + " FROM inventario WHERE tablero='" + tablero + "' ";

            MySqlDataReader mReader = null;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf File |*.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = sqlConnection();
                mReader = mySqlCommand.ExecuteReader();
                PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
                PdfDocument pdf = new PdfDocument(pdfWriter);
                PageSize tamañoH = new PageSize(792, 612);
                Document document = new Document(pdf, tamañoH);
                document.SetMargins(60, 20, 55, 20);

                PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
                tabla.SetWidth(UnitValue.CreatePercentValue(100));

                foreach (string columna in colums)
                {
                    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
                }

                try
                {
                    while (mReader.Read())
                    {
                        if (colums.Contains("numeroFisico"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["numeroFisico"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("descripcion"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["descripcion"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("tablero"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["tablero"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("columna"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["columna"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("fila"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["fila"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("ubicacion"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["ubicacion"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("existencia"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["existencia"].ToString()).SetFont(fontContenido)));
                        if (colums.Contains("fechaCompra"))
                            tabla.AddCell(new Cell().Add(new Paragraph(mReader["fechaCompra"].ToString()).SetFont(fontContenido)));
                    }
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    CloseCommand(mySqlCommand);
                    sqlConnection().Close();
                    CloseReader(mReader);              
                }

                document.Add(tabla);
                document.Close();

                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create(imagen())).SetWidth(50);
                var Ilogo = new Paragraph("").Add(logo);

                var titulo = new Paragraph("Reporte General de Tablero "+ Letra);
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetBold();
                titulo.SetFontSize(16);

                var autor = new Paragraph("Reporte Generado por: " + Session.nombre);
                autor.SetTextAlignment(TextAlignment.CENTER);
                autor.SetFontSize(12);

                PdfDocument pdfDocument = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter(new FileStream(sfd.FileName, FileMode.Create)));
                Document doc = new Document(pdfDocument);

                int numeros = pdfDocument.GetNumberOfPages();

                for (int i = 1; i <= numeros; i++)
                {
                    float y = (pdfDocument.GetPage(i).GetPageSize().GetTop() - 15);
                    doc.ShowTextAligned(Ilogo, 40, y + 10, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(autor, 620, y - 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(titulo, 396, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                    doc.ShowTextAligned(new Paragraph(String.Format("Pagina {0} de {1}", 1, numeros)),
                        pdfDocument.GetPage(i).GetPageSize().GetWidth() / 2,
                        pdfDocument.GetPage(i).GetPageSize().GetBottom() + 30, i,
                        TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                }
                doc.Close();
                MessageBox.Show("Reporte Generado Correctamente");
            }
        }

        public byte[] imagen()
        {
            byte[] bytesImagen = new System.Drawing.ImageConverter().ConvertTo(Resources.WVG, typeof(byte[])) as byte[];
            return bytesImagen;
        }
    }
}
