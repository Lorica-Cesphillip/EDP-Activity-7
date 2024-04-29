using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Runtime.InteropServices;
using System.IO;

namespace PNR_Train_Management_System
{
    internal class ReportGeneration
    {
        public ReportGeneration() { }
        public bool GenerateReport(DataGridView data, string templatePath, string newfilepath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using(ExcelPackage package = new ExcelPackage(templatePath))
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets["Rolling Stock Count"];
                if(sheet == null)
                {
                    return false;
                }

                // Populate unique RollingStockType values in Column A, starting at Row 6
                var uniqueRollingStockTypes = GetUniqueRollingStockTypes(data);
                for (int i = 0; i < uniqueRollingStockTypes.Count; i++)
                {
                    sheet.Cells[i * 2 + 6, 1].Value = uniqueRollingStockTypes[i];
                }

                // Populate data based on RollingStockType
                int dataIndex = 0;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string rollingStockType = data.Rows[i].Cells[0].Value?.ToString();
                    int dataRowIndex = uniqueRollingStockTypes.IndexOf(rollingStockType);

                    if (dataRowIndex != -1 && data.Rows[i].Cells[1].Value != null && data.Rows[i].Cells[2].Value != null && data.Rows[i].Cells[3].Value != null && data.Rows[i].Cells[4].Value != null)
                    {
                        sheet.Cells[dataRowIndex * 2 + 7 + dataIndex, 2].Value = data.Rows[i].Cells[1].Value.ToString(); // RollingStock
                        sheet.Cells[dataRowIndex * 2 + 7 + dataIndex, 3].Value = data.Rows[i].Cells[2].Value.ToString(); // InServiceCnt
                        sheet.Cells[dataRowIndex * 2 + 7 + dataIndex, 4].Value = data.Rows[i].Cells[3].Value.ToString(); // Idle
                        sheet.Cells[dataRowIndex * 2 + 7 + dataIndex, 5].Value = data.Rows[i].Cells[4].Value.ToString(); // UnderMaintenance

                        dataIndex++;
                    }
                }
                // Save changes to the Excel file
                package.SaveAs(new FileInfo(newfilepath));
                return true;
            }
        }

        private List<string> GetUniqueRollingStockTypes(DataGridView data)
        {
            List<string> uniqueTypes = new List<string>();

            foreach (DataGridViewRow row in data.Rows)
            {
                string type = row.Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(type) && !uniqueTypes.Contains(type))
                {
                    uniqueTypes.Add(type);
                }
            }

            return uniqueTypes;
        }

    }
}
