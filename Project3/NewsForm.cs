using Newtonsoft.Json.Linq;
using RESTutils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class NewsForm : Form
    {
        RESTaccess rest;
        News news = null;

        public NewsForm()
        {
            InitializeComponent();
            rest = new RESTaccess("http://ist.rit.edu/api");
            displayNews();
        }

        private News loadData()
        {
            if (news == null)
            {
                string jsonNews = rest.getRESTData("/news/");
                news = JToken.Parse(jsonNews).ToObject<News>();
            }

            return news;
        }

        private void displayNews()
        {
            string content = "";

            loadData();

            foreach (Year year in news.year)
            {
                content += "Date: " + year.date + "\n";
                content += "Title: " + year.title + "\n";
                content += "Description: " + year.description + "\n\n";
            }

            foreach (Older old in news.older)
            {
                content += "Date: " + old.date + "\n";
                content += "Title: " + old.title + "\n";
                content += "Description: " + old.description + "\n\n";
            }

            newsContent.Text = content;
        }

    }
}
