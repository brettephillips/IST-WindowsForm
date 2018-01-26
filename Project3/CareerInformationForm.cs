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
    public partial class CareerInformationForm : Form
    {
        RESTaccess rest;
        Employment employment = null;

        public CareerInformationForm()
        {
            InitializeComponent();
            rest = new RESTaccess("http://ist.rit.edu/api");
            displayEmploymentInfo();
            displayStatistics();
        }

        private Employment loadData()
        {
            if (employment == null)
            {
                string jsonEmployment = rest.getRESTData("/employment/");
                employment = JToken.Parse(jsonEmployment).ToObject<Employment>();
            }

            return employment;
        }

        private void displayStatistics()
        {
            RichTextBox[] rtbArr = new RichTextBox[4] { statistic1, statistic2, statistic3, statistic4 };
            Label[] lblArr = new Label[4] { number1, number2, number3, number4 };

            string content = "";
            int counter = 0;

            loadData();

            foreach (Statistic stat in employment.degreeStatistics.statistics)
            {
                if (stat.value.Equals("35"))
                {
                    lblArr[counter].Text = stat.value + "%";
                }else
                {
                    lblArr[counter].Text = stat.value;
                }

                rtbArr[counter].Text = stat.description;
                rtbArr[counter].SelectionAlignment = HorizontalAlignment.Center;

                counter++;
            }
        }

        private void displayEmploymentInfo()
        {
            string content = "";

            loadData();

            foreach (Content info in employment.introduction.content)
            {
                content += info.title + ":\n\n";
                content += info.description + "\n\n";
            }

            careerContent.Text = content;
        }
    }
}
