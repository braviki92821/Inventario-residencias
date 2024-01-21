using Inventario_residencias.Repositorio;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System.Data;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class Opciones_Reporte : Form
    {
        private InventarioRepositorio inventarioRepositorio = new InventarioRepositorio();
        private ConexionMysql conexionMysql = new ConexionMysql(); 

        public Opciones_Reporte()
        {
            InitializeComponent();
            estadoInicial();
            cargarTableros();
        }

        private void rbtnGeneral_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
        }

        private void rbtnTablero_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = true;
        }

        private void estadoInicial()
        {
            if (rbtnGeneral.Checked)
            {
                panel2.Enabled = false;
            }
        }

        private void cargarTableros()
        {
            cbxTablero.DataSource = inventarioRepositorio.obtenerTableros();
        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {

            if (queryGeneral().Equals(""))
            {
                MessageBox.Show("Seleccione campos para el contenido");
                return;
            }

            string campos = queryGeneral();
            if (queryGeneral().EndsWith(','))
            {
                int t = queryGeneral().Length;
                campos = queryGeneral().Remove(t - 1);
            }
            string query = "SELECT " + campos + " FROM inventario";
            string[] colums = queryGeneral().Split(',');
            float[] tamanios = (float[])tamanos().Where(x => x != 0).ToArray();

            MySqlDataReader mReader = null;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf File |*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = conexionMysql.sqlConnection();
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
                mReader.Close();
                document.Add(tabla);
                document.Close();

                var titulo = new Paragraph("Reporte General de Inventario");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetBold();
                titulo.SetFontSize(16);

                PdfDocument pdfDocument = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter(new FileStream(sfd.FileName, FileMode.Create)));
                Document doc = new Document(pdfDocument);

                int numeros = pdfDocument.GetNumberOfPages();

                for (int i = 1; i <= numeros; i++)
                {
                    PdfPage pdfPage = pdfDocument.GetPage(i);

                    float y = (pdfDocument.GetPage(i).GetPageSize().GetTop() - 15);
                    doc.ShowTextAligned(titulo, 396, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                }
                doc.Close();
            }

        }

        private void btnReporteTablero_Click(object sender, EventArgs e)
        {

        }

        public string queryGeneral()
        {
            string query = "";
            if (chbxNumeroFG.Checked)
                query += "numeroFisico,";
            if (chbxDescripcionG.Checked)
                query += "descripcion,";
            if (chbxTablero.Checked)
                query += "tablero,";
            if (chbxColumnaG.Checked)
                query += "columna,";
            if (chbxFilaG.Checked)
                query += "fila,";
            if (chbxUbicacionG.Checked)
                query += "ubicacion,";
            if (chbxExistenciaG.Checked)
                query += "existencia,";
            if (chbxFechaG.Checked)
                query += "fechaCompra";

            return query;

        }

        public float[] tamanos()
        {
            float[] tamano = new float[8];
            if (chbxNumeroFG.Checked)
                tamano[0] = 2f;
            if (chbxDescripcionG.Checked)
                tamano[1] = 4f;
            if (chbxTablero.Checked)
                tamano[2] = 2f;
            if (chbxColumnaG.Checked)
                tamano[3] = 2f;
            if (chbxFilaG.Checked)
                tamano[4] = 2f;
            if (chbxUbicacionG.Checked)
                tamano[5] = 4f;
            if (chbxExistenciaG.Checked)
                tamano[6] = 2f;
            if (chbxFechaG.Checked)
                tamano[7] = 4f;
            return tamano;
        }
    }
}
