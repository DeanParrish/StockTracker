using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using StockTracker.Helpers.Objects;

namespace StockTracker.Helpers
{
    public class ExcelReader
    {
        public string path  { get; set; }
        public ExcelReader(string filePath)
        {
                path = filePath;
        }

        public string GetConnectionString()
        {
            Dictionary<string, string> props = new Dictionary<string, string>();

            // XLSX - Excel 2007, 2010, 2012, 2013
            props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
            props["Extended Properties"] = "Excel 12.0 XML";
            props["Data Source"] = path;

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> prop in props)
            {
                sb.Append(prop.Key);
                sb.Append('=');
                sb.Append(prop.Value);
                sb.Append(';');
            }

            return sb.ToString();
        }

        public DataSet GetStocks(string ticker, string country)
        {
            DataSet ds = new DataSet();
            string connectionString = GetConnectionString();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                Stock stock;
                cmd.Connection = conn;

                DataTable dtSheets = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                foreach (var dr in dtSheets.Rows)
                {
                    string sheetName =
                        "http://www.codeproject.com/Tips/705470/Read-and-Write-Excel-Documents-Using-OLEDB";

                }
                cmd.CommandText = "SELECT * FROM [Stocks] WHERE Ticker = " + ticker + " AND Country = " + country;
                DataTable dt = new DataTable();
                
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

                ds.Tables.Add(dt);

                cmd = null;
                conn.Close();
            }

            
        }
    }
}