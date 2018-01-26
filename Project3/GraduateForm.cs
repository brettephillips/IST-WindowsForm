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
    public partial class GraduateForm : Form
    {
        RESTaccess rest;
        Degrees degrees = null;

        public GraduateForm()
        {
            InitializeComponent();
            rest = new RESTaccess("http://ist.rit.edu/api");
            displayMajors();
            concentrationTitle.Text = "Concentrations";
            concentrationList.Text = "Click The \"+\" To Find Out More";
        }

        private Degrees loadData()
        {
            if (degrees == null)
            {
                string jsonDegrees = rest.getRESTData("/degrees/");
                degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();
            }

            return degrees;
        }

        private void displayMajors()
        {
            Label[] labelArr = new Label[4] { gradTitle1, gradTitle2, gradTitle3, gradTitle4 };
            RichTextBox[] rtbArr = new RichTextBox[4] { gradDesc1, gradDesc2, gradDesc3, certificateList };

            loadData();

            for (int i = 0; i < degrees.graduate.Count; i++)
            {
                if(rtbArr[i] == rtbArr[3])
                {
                    labelArr[i].Text = degrees.graduate[i].degreeName;
                    displayCertificates();
                }
                else
                {
                    labelArr[i].Text = degrees.graduate[i].title;
                    rtbArr[i].Text = degrees.graduate[i].description;
                }
            }
        }

        private int getIndex(object sender)
        {
            PictureBox pbName = (PictureBox)sender;

            if (pbName.Name.Equals("istMore"))
            {
                return 0;
            }
            else if (pbName.Name.Equals("hciMore"))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void displayConcentrations(object sender)
        {
            string list = "";

            foreach (string concentration in degrees.graduate[getIndex(sender)].concentrations)
            {
                list += "- " + concentration + "\n";
            }

            concentrationList.Text = list;
        }

        private void displayCertificates()
        {
            string list = "";

            foreach (string certificate in degrees.graduate[3].availableCertificates)
            {
                list += "- " + certificate + "\n";
            }

            certificateList.Text = list;
        }

        private void istMore_Click(object sender, EventArgs e)
        {
            displayConcentrations(sender);
        }

        private void hciMore_Click(object sender, EventArgs e)
        {
            displayConcentrations(sender);
        }

        private void nsaMore_Click(object sender, EventArgs e)
        {
            displayConcentrations(sender);
        }
    }
}
