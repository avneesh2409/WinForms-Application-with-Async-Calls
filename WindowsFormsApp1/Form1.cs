using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\Users\Tft Bhopal\Desktop\testingInvoicePdf\invoice2.pdf");
            //string json = @"[
            //          'Small',
            //          'Medium',
            //          'Large'
            //        ]";
            string json = @"[{
  CPU: 'Intel',
  Drives: [
    'DVD read/writer',
    '500 gigabyte hard drive'
  ]
},{
  CPU: 'Sample1',
  Drives: [
    'DVD reader1',
    '500 megabytes'
  ]
}]";
            JToken a = JToken.Parse(json);
            
        }

        private void CreateCsvBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, Type> columns = new Dictionary<string, Type>
            {
                { "S.No",typeof(int) },
                { "Invoice Number",typeof(string)},
                { "Order Number", typeof(string)},
                { "Due Date",typeof(string)},
                { "Total Due", typeof(string)},
            };
            CreateCsvWithGivenColumns(columns);
        }
        private void CreateCsvWithGivenColumns(Dictionary<string,Type> columns) {
            DataTable dt = new DataTable("MyTable");
            foreach (KeyValuePair<string,Type> item in columns)
            {
                DataColumn dc = new DataColumn(item.Key, item.Value);
                dt.Columns.Add(dc);
            }
            //DataRow newRow1 = dt.NewRow();
            //newRow1["Extracted Data"] = "got the data";
            //dt.Rows.Add(newRow1);
            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            //foreach (DataRow row in dt.Rows)
            //{
            //    IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
            //    sb.AppendLine(string.Join(",", fields));
            //}

            File.WriteAllText(@"C:\Users\Tft Bhopal\Documents\TestingExcelActivity.csv", sb.ToString());
            //Console.WriteLine(dt.Rows.Count);
        }
    }
}
