using ApiHelperLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ApiDemo : Form
    {
        public int MaximumNumberComic { get; set; }
        public int CurrentComicNumber { get; set; }
        public ApiDemo()
        {
            InitializeComponent();
            ApiHelper.InitializeApi();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (CurrentComicNumber > 1)
            {
                Prev.Enabled = true;
                CurrentComicNumber -= 1;
            }
            else
            {
                Prev.Enabled = false;
            }

            FetchImageAsync();
        }

        private void LoadImageAsync_Click(object sender, EventArgs e)
        {
            FetchImageAsync();
            LoadMultipleApi loadMultipleApi = new LoadMultipleApi();
            loadMultipleApi.Show();
        }

        private async void FetchImageAsync()
        {
            
            try
            {

                string url = "";
                if (CurrentComicNumber > 0)
                {
                    url = $"https://xkcd.com/{CurrentComicNumber}/info.0.json";
                }
                else
                {
                    url = "https://xkcd.com/info.0.json";
                }
                ModelLibrary.ComicModel comic = await ComicApiHelper.GetComic(url);
                if (CurrentComicNumber == 0)
                {
                    MaximumNumberComic = comic.num;
                    LoadImageAsync.Enabled = false;
                }
                ImageBox.LoadAsync(comic.img);
                Title.Text = comic.title;
                Transcript.Text = comic.transcript;
                if (CurrentComicNumber >= 1)
                {
                    Prev.Enabled = true;
                }
               if (CurrentComicNumber < MaximumNumberComic)
                {
                    Next.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured whicle fetching data from the url !!"+ex.Message);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (CurrentComicNumber < MaximumNumberComic)
            {
                Next.Enabled = true;
                CurrentComicNumber += 1;
            }
            else if (CurrentComicNumber == MaximumNumberComic) {
                Next.Enabled = false;
            }
            FetchImageAsync();
        }

        private void ApiDemo_Load(object sender, EventArgs e)
        {
            label1.Text = "Transcript";
            label2.Text = "Title";
            Next.Enabled = false;
            Prev.Enabled = false;
            MaximumNumberComic = 0;
            CurrentComicNumber = 0;
        }
    }
}
