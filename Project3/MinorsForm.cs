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
    public partial class MinorsForm : Form
    {
        RESTaccess rest;
        Minors minors = null;

        public MinorsForm()
        {
            InitializeComponent();
            rest = new RESTaccess("http://ist.rit.edu/api");
            displayMinors();
            minorDescTitle.Text = "Description";
            coursesDescTitle.Text = "Courses";
            minorDesc.Text = "Click A Minor To Find Out More";
            courseList.Text = "Click A Minor To Find Out More";
        }

        private Minors loadData()
        {
            if (minors == null)
            {
                string jsonMinors = rest.getRESTData("/minors/");
                minors = JToken.Parse(jsonMinors).ToObject<Minors>();
            }

            return minors;
        }

        private void displayMinors()
        {
            Label[] labelArr = new Label[8] { minor1, minor2, minor3, minor4, minor5, minor6, minor7, minor8 };

            loadData();

            for (int i = 0; i < minors.UgMinors.Count; i++)
            {
                labelArr[i].Text = minors.UgMinors[i].title;
            }
        }

        private int getIndex(object sender)
        {
            Label labelName = (Label)sender;
            string number = labelName.Name.Substring(5);

            return Int32.Parse(number) - 1;
        }

        private void displayDescription(object sender)
        {
            minorDesc.Text = minors.UgMinors[getIndex(sender)].description;
        }

        private void displayCourses(object sender)
        {
            string list = "";

            foreach (string course in minors.UgMinors[getIndex(sender)].courses)
            {
                list += "- " + course + "\n";
            }

            courseList.Text = list;
        }

        private void minor1_Click(object sender, EventArgs e)
        {
            displayDescription(sender);
            displayCourses(sender);
        }

        private void minor2_Click(object sender, EventArgs e)
        {
            displayDescription(sender);
            displayCourses(sender);
        }

        private void minor3_Click(object sender, EventArgs e)
        {
            displayDescription(sender);
            displayCourses(sender);
        }

        private void minor4_Click(object sender, EventArgs e)
        {
            displayDescription(sender);
            displayCourses(sender);
        }

        private void minor5_Click(object sender, EventArgs e)
        {
            displayDescription(sender);
            displayCourses(sender);
        }

        private void minor6_Click(object sender, EventArgs e)
        {
            displayDescription(sender);
            displayCourses(sender);
        }

        private void minor7_Click(object sender, EventArgs e)
        {
            displayDescription(sender);
            displayCourses(sender);
        }

        private void minor8_Click(object sender, EventArgs e)
        {
            displayDescription(sender);
            displayCourses(sender);
        }
    }
}
