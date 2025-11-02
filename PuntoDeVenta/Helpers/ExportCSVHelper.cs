using System.Data;
using System.Text;

namespace PuntoDeVenta.Helpers
{
    public static class ExportCsvHelper
    {

        public static bool ExportCsv(System.Data.DataTable dt, string worksheetName, string saveLocation)
        {
            DateTime datetime = DateTime.Now;
            string date = datetime.ToString("yyyy-MM-dd");

            if (!Directory.Exists(saveLocation))
            {
                Directory.CreateDirectory(saveLocation);
            }

            string path = Path.Combine(saveLocation,  date + "_" + worksheetName + ".csv");
            StringBuilder sb = new StringBuilder();

            try
            {
                IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().Select(column => '"' + column.ColumnName + '"');
                sb.AppendLine(string.Join(";", columnNames));

                foreach (DataRow row in dt.Rows)
                {
                    IEnumerable<string> fields = row.ItemArray.Select(field => '"' + field!.ToString() + '"');
                    sb.AppendLine(string.Join(";", fields));
                }

                File.WriteAllText(path, sb.ToString());

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
