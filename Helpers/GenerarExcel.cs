using DocumentFormat.OpenXml.Spreadsheet;
using Inventario_residencias.Exceptions;
using MySql.Data.MySqlClient;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using System.Text;

namespace Inventario_residencias.Helpers
{
    public class GenerarExcel : ConexionMysql
    {
        public void CrearExcel()
        {
            string query = "SELECT i.numeroFisico, i.descripcion, t.tablero, i.columna, i.fila, i.ubicacion, i.imagen, i.existencia, i.fechaCompra " +
                           "FROM inventario i INNER JOIN tablero t ON t.tableroId = i.tablero";
            int columna = 4;
            MySqlDataReader mReader = null;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Xlsx File |*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SLDocument sl = new SLDocument();
                //sl.SetCellValue("A1", "INVENTARIO DE HERRAMIENTA ESPECIAL");
                //sl.SetCellValue("A2", "AGENCIA POZA RICA");

                //styles
                SLStyle sLStyle = new SLStyle();
                sLStyle.Font.FontName = "Calibri";
                sLStyle.Font.FontSize = 11;
                sLStyle.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
                sLStyle.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
                sLStyle.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
                sLStyle.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
                sLStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;
                sLStyle.Alignment.Vertical = VerticalAlignmentValues.Center;
               

                sl.SetCellStyle("A4", "H4", sLStyle);

                //header
                sl.SetCellValue("A4", "     NUMERO FISICO       ");
                sl.SetCellValue("B4", "        DESCRIPCION         ");
                sl.SetCellValue("C4", "        TABLERO       ");
                sl.SetCellValue("D4", "        COLUMNA        ");
                sl.SetCellValue("E4", "        FILA         ");
                sl.SetCellValue("F4", "        UBICACIÓN        ");
                sl.SetCellValue("G4", "        IMAGEN        ");
                sl.SetCellValue("H4", "        EXISTENCIA         ");
                sl.AutoFitColumn("A", "H");
                
                sl.SetRowHeight(columna, 40);
                try
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(query);
                    mySqlCommand.Connection = sqlConnection();
                    mReader = mySqlCommand.ExecuteReader();
                    while (mReader.Read())
                    {
                        byte[] imagen = (byte[])mReader.GetValue(6);
                        SLPicture pic = new SLPicture(imagen, DocumentFormat.OpenXml.Packaging.ImagePartType.Png);
                        pic.ResizeInPixels(50, 50);
                        pic.SetPosition(columna, 6);
                        sl.InsertPicture(pic);
                        columna++;
                        sl.AutoFitRow(columna);
                        sl.SetRowHeight(columna, 40);
                        sl.SetCellStyle("A" + columna, sLStyle);
                        sl.SetCellValue("A" + columna, mReader.GetString("numeroFisico"));
                        sl.SetCellStyle("B" + columna, sLStyle);
                        sl.SetCellValue("B" + columna, mReader.GetString("descripcion"));
                        sl.SetCellStyle("C" + columna, sLStyle);
                        sl.SetCellValue("C" + columna, mReader.GetString("tablero"));
                        sl.SetCellStyle("D" + columna, sLStyle);
                        sl.SetCellValue("D" + columna, mReader.GetString("columna"));
                        sl.SetCellStyle("E" + columna, sLStyle);
                        sl.SetCellValue("E" + columna, mReader.GetString("fila"));
                        sl.SetCellStyle("F" + columna, sLStyle);
                        sl.SetCellValue("F" + columna, mReader.GetString("ubicacion"));
                        sl.SetCellStyle("G" + columna, sLStyle);
                        sl.SetCellStyle("H" + columna, sLStyle);
                        sl.SetCellValue("H" + columna, mReader.GetBoolean("existencia"));

                    }
                    CloseCommand(mySqlCommand);
                    sl.SaveAs(sfd.FileName);
                    MessageBox.Show("Archivo Generado");
                }
                catch (IOException ex)
                {
                    throw new InventarioException(ex.Message);
                }
                finally
                {
                    CloseReader(mReader);
                    sqlConnection().Close();
                }
            }
        }

    }
}
