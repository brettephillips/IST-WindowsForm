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
    public partial class UndergraduateForm : Form
    {
        RESTaccess rest;
        Degrees degrees = null;

        public UndergraduateForm()
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
            Label[] labelArr = new Label[3] { undergradTitle1, undergradTitle2, undergradTitle3 };
            RichTextBox[] rtbArr = new RichTextBox[3] { undergradDesc1, undergradDesc2, undergradDesc3 };

            loadData();

            for (int i = 0; i < degrees.undergraduate.Count; i++)
            {
                labelArr[i].Text = degrees.undergraduate[i].title;
                rtbArr[i].Text = degrees.undergraduate[i].description;
            }
        }

        private int getIndex(object sender)
        {
            PictureBox pbName = (PictureBox)sender;

            if (pbName.Name.Equals("wmcMore"))
            {
                return 0;
            }else if (pbName.Name.Equals("hccMore"))
            {
                return 1;
            }else
            {
                return 2;
            }
        }

        private void displayConcentrations(object sender)
        {
            string list = "";

            foreach (string concentration in degrees.undergraduate[getIndex(sender)].concentrations)
            {
                list += "- " + concentration + "\n";
            }

            concentrationList.Text = list;
        } 

        private void wmcMore_Click(object sender, EventArgs e)
        {
            displayConcentrations(sender);
        }

        private void hccMore_Click(object sender, EventArgs e)
        {
            displayConcentrations(sender);
        }

        private void citMore_Click(object sender, EventArgs e)
        {
            displayConcentrations(sender);
        }
    }
}
