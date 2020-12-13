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
            //JArray a = JArray.Parse(json);
            JToken a = JToken.Parse(json);
            //var data = JsonConvert.DeserializeObject<List<ParseDataClass>>(json);
            //List<ParseDataClass> data = JsonSerializer.Deserialize<List<ParseDataClass>>(json.ToString());
            //data.ForEach((l) => {
            //    l.cpu.ToUpper();
            //});
            DataTable dt = new DataTable("MyTable");
            DataColumn dc = new DataColumn("S.No",typeof(int));
            dc.AutoIncrement = true;
            dt.Columns.Add(dc);
            DataColumn dc1 = new DataColumn("Extracted Data", typeof(string));
            dt.Columns.Add(dc1);

            DataRow newRow = dt.NewRow();
            newRow["S.No"] = 1;
            newRow["Extracted Data"] = "got the data";
            dt.Rows.Add(newRow);

            DataRow newRow1 = dt.NewRow();
            newRow1["Extracted Data"] = "got the data";
            dt.Rows.Add(newRow1);
            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(@"C:\Users\Tft Bhopal\Documents\sample1.csv", sb.ToString());
            Console.WriteLine(dt.Rows.Count);
        }
    }
    class ParseDataClass
    {
        public string cpu { get; set; }
        public List<string> drives { get; set; }
    }
}
