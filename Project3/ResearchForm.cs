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
    public partial class ResearchForm : Form
    {
        RESTaccess rest;
        Research research = null;

        public ResearchForm()
        {
            InitializeComponent();
            rest = new RESTaccess("http://ist.rit.edu/api");
            displayInterestAreas();
            citationTitle.Text = "Citations";
            citationContent.Text = "Click An Interest Area To Find Out More";
        }

        private Research loadData()
        {
            if (research == null)
            {
                string jsonResearch = rest.getRESTData("/research/");
                research = JToken.Parse(jsonResearch).ToObject<Research>();
            }

            return research;
        }
        private void displayInterestAreas()
        {
            Label[] labelArr = new Label[12] { area1, area2, area3, area4, area5, area6, area7, area8, area9, area10, area11, area12 };

            loadData();

            for (int i = 0; i < research.byInterestArea.Count; i++)
            {
                labelArr[i].Text = research.byInterestArea[i].areaName;
            }
        }

        private int getIndex(object sender)
        {
            Label labelName = (Label)sender;
            string number = labelName.Name.Substring(4);

            return Int32.Parse(number) - 1;
        }

        private void displayCitations(object sender)
        {
            citationContent.Text = "";

            foreach (string citation in research.byInterestArea[getIndex(sender)].citations)
            {
                citationContent.Text += citation + "\n\n";
            }
        }

        private void area1_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area2_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area3_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area4_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area5_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area6_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area7_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area8_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area9_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area10_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area11_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }

        private void area12_Click(object sender, EventArgs e)
        {
            displayCitations(sender);
        }
    }
}
