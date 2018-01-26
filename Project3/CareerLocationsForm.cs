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
    public partial class CareerLocationsForm : Form
    {
        RESTaccess rest;
        Employment employment = null;

        public CareerLocationsForm()
        {
            InitializeComponent();
            rest = new RESTaccess("http://ist.rit.edu/api");
            displayEmployerTable();
            displayCoopTable();
        }

        private Employment loadData()
        {
            if (employment == null)
            {
                // Get employment data
                string jsonEmployment = rest.getRESTData("/employment/");

                // Cast to the object
                employment = JToken.Parse(jsonEmployment).ToObject<Employment>();

            }

            return employment;
        }

        private void displayCoopTable()
        {
            loadData();
            coopTitle.Text = employment.coopTable.title;

            for (var i = 0; i < employment.coopTable.coopInformation.Count; i++)
            {
                CoopTable.Rows.Add();       // first add a row, then data

                CoopTable.Rows[i].Cells[0].Value = employment.coopTable.coopInformation[i].degree;
                CoopTable.Rows[i].Cells[1].Value = employment.coopTable.coopInformation[i].employer;
                CoopTable.Rows[i].Cells[2].Value = employment.coopTable.coopInformation[i].city;
                CoopTable.Rows[i].Cells[3].Value = employment.coopTable.coopInformation[i].term;
            } // end for
        } // end button load data grid

        private void displayEmployerTable()
        {
            loadData();
            employerTitle.Text = employment.employmentTable.title;

            for (var i = 0; i < employment.employmentTable.professionalEmploymentInformation.Count; i++)
            {
                EmployerTable.Rows.Add();       // first add a row, then data

                EmployerTable.Rows[i].Cells[0].Value = employment.employmentTable.professionalEmploymentInformation[i].degree;
                EmployerTable.Rows[i].Cells[1].Value = employment.employmentTable.professionalEmploymentInformation[i].employer;
                EmployerTable.Rows[i].Cells[2].Value = employment.employmentTable.professionalEmploymentInformation[i].city;
                EmployerTable.Rows[i].Cells[3].Value = employment.employmentTable.professionalEmploymentInformation[i].title;
                EmployerTable.Rows[i].Cells[4].Value = employment.employmentTable.professionalEmploymentInformation[i].startDate;
            } // end for
        } // end button load data grid

        private void map_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/api/map");
        }
    }
}
