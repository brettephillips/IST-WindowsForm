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
    public partial class PeopleForm : Form
    {
        RESTaccess rest;
        People people = null;

        public PeopleForm()
        {
            InitializeComponent();
            rest = new RESTaccess("http://ist.rit.edu/api");
            displayFaculty();
            displayStaff();
        }

        private People loadData()
        {
            if (people == null)
            {
                string jsonPeople = rest.getRESTData("/people/");
                people = JToken.Parse(jsonPeople).ToObject<People>();
            }

            return people;
        }

        private void displayFaculty()
        {
            string content = "";

            loadData();

            titleLbl.Text = people.title;

            foreach (Faculty person in people.faculty)
            {
                facultyList.Items.Add(person.name);
            }

            facultyList.Text = content;
        }

        private void displayStaff()
        {
            string content = "";

            loadData();

            foreach (Staff person in people.staff)
            {
                staffList.Items.Add(person.name);
            }

            staffList.Text = content;
        }

        private void facultyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string content = "";

            try
            {
                string currItem = facultyList.SelectedItem.ToString();
                int index = facultyList.FindString(currItem);

                content += people.faculty[index].name + "\n";
                content += "Title: " + people.faculty[index].title + "\n";
                content += "Email: " + people.faculty[index].email + "\n";
                content += "Phone: " + people.faculty[index].phone + "\n";
                content += "Office: " + people.faculty[index].office + "\n";
                content += "Interest Areas: " + people.faculty[index].interestArea + "\n";

                staffList.ClearSelected();
                personContent.Text = content;
            }
            catch (NullReferenceException E) { }
        }

        private void staffList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string content = "";

            try
            {
                string currItem = staffList.SelectedItem.ToString();
                int index = staffList.FindString(currItem);

                content += people.staff[index].name + "\n";
                content += "Title: " + people.staff[index].title + "\n";
                content += "Email: " + people.staff[index].email + "\n";
                content += "Phone: " + people.staff[index].phone + "\n";
                content += "Office: " + people.staff[index].office + "\n";
                content += "Interest Areas: " + people.staff[index].interestArea + "\n";

                facultyList.ClearSelected();
                personContent.Text = content;
            }
            catch (NullReferenceException E) { }
        }
    }
}
