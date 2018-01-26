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
    public partial class HomeForm : System.Windows.Forms.Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void undergraduatePnl_Click(object sender, EventArgs e)
        {
            UndergraduateForm undergraduateForm = new UndergraduateForm();
            undergraduateForm.Show();
        }

        private void graduatePnl_Click(object sender, EventArgs e)
        {
            GraduateForm graduateForm = new GraduateForm();
            graduateForm.Show();
        }

        private void MinorsPnl_Click(object sender, EventArgs e)
        {
            MinorsForm minorsform = new MinorsForm();
            minorsform.Show();
        }

        private void careerInfoPnl_Click(object sender, EventArgs e)
        {
            CareerInformationForm careerInfoForm = new CareerInformationForm();
            careerInfoForm.Show();
        }

        private void careerLocationsPnl_Click(object sender, EventArgs e)
        {
            CareerLocationsForm careerLocationsForm = new CareerLocationsForm();
            careerLocationsForm.Show();
        }

        private void currentStudentsPnl_Click(object sender, EventArgs e)
        {
            CurrentStudentsForm currentStudentsForm = new CurrentStudentsForm();
            currentStudentsForm.Show();
        }

        private void newsPnl_Click(object sender, EventArgs e)
        {
            NewsForm newsForm = new NewsForm();
            newsForm.Show();
        }

        private void contactFormPnl_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
        }

        private void peoplePnl_Click(object sender, EventArgs e)
        {
            PeopleForm peopleForm = new PeopleForm();
            peopleForm.Show();
        }

        private void researchByInterestAreaPnl_Click(object sender, EventArgs e)
        {
            ResearchForm researchForm = new ResearchForm();
            researchForm.Show();
        }

        private void aboutPnl_Click(object sender, EventArgs e)
        {

            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
