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
    public partial class CurrentStudentsForm : Form
    {
        RESTaccess rest;
        Resources resources = null;

        public CurrentStudentsForm()
        {
            InitializeComponent();
            rest = new RESTaccess("http://ist.rit.edu/api");
            displayResources();
            resourceContent.Text = "Click A Resource To Find Out More";
        }

        private Resources loadData()
        {
            if (resources == null)
            {
                string jsonResources = rest.getRESTData("/resources/");
                resources = JToken.Parse(jsonResources).ToObject<Resources>();
            }

            return resources;
        }

        private void displayResources()
        {
            loadData();

            studyAbroadLbl.Text = resources.studyAbroad.title;
            advisingLbl.Text = resources.studentServices.title;
            tutorsAndLabInfoLbl.Text = resources.tutorsAndLabInformation.title;
            stdntAmbInfoAndAppLbl.Text = resources.studentAmbassadors.title;
            FormsLbl.Text = "Forms";
            coopEnrollmentLbl.Text = resources.coopEnrollment.title;
        }

        private void studyAbroadLbl_Click(object sender, EventArgs e)
        {
            string content = "";

            resourceTitle.Padding = new Padding(208, 0, 208, 0);
            resourceTitle.Text = studyAbroadLbl.Text;
       
            content += resources.studyAbroad.description + "\n\n";

            foreach (Place place in resources.studyAbroad.places)
            {
                content += place.nameOfPlace + ":\n\n" + place.description + "\n\n";
            }

            resourceContent.Text = content;
        }

        private void advisingLbl_Click(object sender, EventArgs e)
        {
            string content = "";

            resourceTitle.Padding = new Padding(235, 0, 235, 0);
            resourceTitle.Text = advisingLbl.Text;

            content += resources.studentServices.academicAdvisors.title + ":\n\n";
            content += resources.studentServices.academicAdvisors.description + "\n\n";

            content += resources.studentServices.professonalAdvisors.title + ":\n\n";
            foreach (AdvisorInformation advisor in resources.studentServices.professonalAdvisors.advisorInformation)
            {
                content += "Name: " + advisor.name + "\n";
                content += "Department: " + advisor.department + "\n";
                content += "Email: " + advisor.email + "\n\n";
            }

            content += resources.studentServices.facultyAdvisors.title + ":\n\n";
            content += resources.studentServices.facultyAdvisors.description + "\n\n";

            content += resources.studentServices.istMinorAdvising.title + ":\n\n";
            foreach (MinorAdvisorInformation advisor in resources.studentServices.istMinorAdvising.minorAdvisorInformation)
            {
                content += "Title: " + advisor.title + "\n";
                content += "Advisor: " + advisor.advisor + "\n";
                content += "Email: " + advisor.email + "\n\n";
            }

            resourceContent.Text = content;
        }

        private void tutorsAndLabInfoLbl_Click(object sender, EventArgs e)
        {
            string content = "";
            LinkLabel link = new LinkLabel();
            link.ForeColor = Color.White;
            link.Text = resources.tutorsAndLabInformation.tutoringLabHoursLink;

            resourceTitle.Padding = new Padding(154, 0, 154, 0);
            resourceTitle.Text = tutorsAndLabInfoLbl.Text;

            content += resources.tutorsAndLabInformation.description + "\n\n";
            content += "Link: " + link.Text;

            resourceContent.Text = content;
        }

        private void stdntAmbInfoAndAppLbl_Click(object sender, EventArgs e)
        {
            string content = "";
            //Image newImage = Image.FromFile(resources.studentAmbassadors.ambassadorsImageSource);
            LinkLabel link = new LinkLabel();
            link.ForeColor = Color.White;
            link.Text = resources.studentAmbassadors.applicationFormLink;

            resourceTitle.Padding = new Padding(21, 0, 21, 0);
            resourceTitle.Text = stdntAmbInfoAndAppLbl.Text;

            foreach (SubSectionContent subsection in resources.studentAmbassadors.subSectionContent)
            {
                content += subsection.title + ":\n\n";
                content += subsection.description + "\n\n";
            }

            content += "Application: " + link.Text + "\n\n";
            content += resources.studentAmbassadors.note;

            resourceContent.Text = content;
        }

        private void FormsLbl_Click(object sender, EventArgs e)
        {
            string content = "";

            resourceTitle.Padding = new Padding(246, 0, 246, 0);
            resourceTitle.Text = FormsLbl.Text;

            content += "Graduate Forms:\n\n";
            foreach (GraduateForms form in resources.forms.graduateForms)
            {
                content += "- " + form.formName + "\n";
            }

            content += "\n" + "Undergraduate Forms:\n\n";
            foreach (UndergraduateForms form in resources.forms.undergraduateForms)
            {
                content += "- " + form.formName + "\n";
            }

            resourceContent.Text = content;
        }

        private void coopEnrollmentLbl_Click(object sender, EventArgs e)
        {
            string content = "";
            LinkLabel link = new LinkLabel();
            link.ForeColor = Color.White;
            link.Text = resources.coopEnrollment.RITJobZoneGuidelink;

            resourceTitle.Padding = new Padding(186, 0, 186, 0);
            resourceTitle.Text = coopEnrollmentLbl.Text;

            foreach (EnrollmentInformationContent enrollmentInfo in resources.coopEnrollment.enrollmentInformationContent)
            {
                content += enrollmentInfo.title + ":\n\n";
                content += enrollmentInfo.description + "\n\n";
            }

            content += "Link: " + link.Text;

            resourceContent.Text = content;
        }
    }
}
