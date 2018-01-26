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
    public partial class AboutForm : Form
    {
        RESTaccess rest;
        About about = null;

        public AboutForm()
        {
            InitializeComponent();
            rest = new RESTaccess("http://ist.rit.edu/api");
            displayAboutInfo();
        }

        private About loadData()
        {
            if (about == null)
            {
                string jsonAbout = rest.getRESTData("/about/");
                about = JToken.Parse(jsonAbout).ToObject<About>();
            }

            return about;
        }

        private void displayAboutInfo()
        {
            loadData();

            aboutTitle.Text = about.title;
            aboutDescription.Text = about.description;
            aboutQuote.Text = "\"" + about.quote + "\"";
            quoteAuthor.Text = "- " + about.quoteAuthor;
        }
    }
}
