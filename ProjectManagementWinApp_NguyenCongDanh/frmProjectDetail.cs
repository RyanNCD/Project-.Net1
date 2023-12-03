using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementWinApp_NguyenCongDanh
{
    public partial class frmProjectDetail : Form
    {
        public frmProjectDetail()
        {
            InitializeComponent();
        }

        public IProjectRepository ProjectRepository { get; set; }
        public bool CreateOrUpdate { get; set; }
        public ProjectObject ProjectInf { get; set; }
        private void frmProjectDetail_Load(object sender, EventArgs e)
        {
            txtProjectIDDt.Enabled = !CreateOrUpdate;
            if (CreateOrUpdate == true)
            {
                txtProjectIDDt.Text = ProjectInf.ProjectID.ToString();
                txtProjectNameDt.Text = ProjectInf.ProjectName;
                txtEstimatedStartDateDt.Text = ProjectInf.EstimatedStartDate.ToString();
                txtEstimatedEndDateDt.Text = ProjectInf.EstimatedEndDate.ToString();
                txtProjectDescriptionDt.Text = ProjectInf.ProjectDescription;
                txtProjectAddressDt.Text = ProjectInf.ProjectAddress;
                txtProjectCityDt.Text = ProjectInf.ProjectCity;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                var proj = new ProjectObject
                {
                    ProjectID = txtProjectIDDt.Text,
                    ProjectName = txtProjectNameDt.Text,
                    EstimatedStartDate = txtEstimatedStartDateDt.Text,
                    EstimatedEndDate = txtEstimatedEndDateDt.Text,
                    ProjectDescription = txtProjectDescriptionDt.Text,
                    ProjectAddress = txtProjectAddressDt.Text,
                    ProjectCity = txtProjectCityDt.Text,
                };
                if (CreateOrUpdate == false)
                {
                    ProjectRepository.CreateProject(proj);
                }
                else
                {
                    ProjectRepository.UpdateProject(proj);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, CreateOrUpdate == false ? "Add a new project" : "Update a project");
            }
        }

        private void btCancel_Click(object sender, EventArgs e) => Close();
    }
}
