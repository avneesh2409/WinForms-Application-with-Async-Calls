using com.sun.org.apache.xerces.@internal.parsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiHelperLibrary;
using WindowsFormsApp1.Common;

namespace WindowsFormsApp1
{
    public partial class LoadMultipleApi : Form
    {
        public LoadMultipleApi()
        {
            InitializeComponent();
        }

        private void LoadApiButton_Click(object sender, EventArgs e)
        {
            LoadMultipleWebPage();
        }

        private async void LoadMultipleWebPage()
        {
            string[] webContents = await Task.WhenAll(ApiHelperLibrary.WebScrapingApiHelper.GetWebContent());
            RichTextBoxContainer.Font = SystemFonts.CaptionFont;
            foreach (var item in webContents)
            {
                RichTextBoxContainer.Text = HtmlParser.HtmlDomParser(item) + Environment.NewLine + Environment.NewLine;
            }  
           
        }
    }
}
