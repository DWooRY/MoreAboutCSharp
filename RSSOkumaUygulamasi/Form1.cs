using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSOkumaUygulamasi
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_url_Click(object sender, EventArgs e)
        {
            List<News> records = XMLReturn();
            lst_header.DataSource = records;
        }

        private List<News> XMLReturn()
        {
            List<News> newsSource = new List<News>(); 
            XDocument XMLSource = XDocument.Load(txt_url.Text);

            #region Kurs yazimi
            //List<XElement> Rows = XMLSource.Descendants("item").ToList();
            //foreach (XElement item in Rows)
            //{
            //    News temp = new News();
            //    temp.Header = item.Element("title").Value;
            //    temp.Link = item.Element("link").Value;
            //    temp.Details = item.Element("description").Value;
            //    newsSource.Add(temp);
            //}
            //return newsSource;
            #endregion

            newsSource = XMLSource.Descendants("item").Select(item => new News
            {
                Header = item.Element("title").Value,
                Link = item.Element("link").Value,
                Details = item.Element("description").Value
            }).ToList();

            return newsSource;

        }

        private void lst_header_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox chosenValue = (ListBox)sender;
            News chosenNews = (News)chosenValue.SelectedItem;
            web_Browser.DocumentText = chosenNews.Details;
        }

    }
}
