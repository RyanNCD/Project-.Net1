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
    public partial class frmProjectManagement : Form
    {
        IProjectRepository repository = new ProjectRepository();
        BindingSource source;
        public frmProjectManagement()
        {
            InitializeComponent();
        }
        private void frmProjectManager_Load(object sender, EventArgs e)
        {
            btDelete.Enabled = false;
            dgvProjectList.CellDoubleClick += DgvProjectList_CellDoubleClick;
        }
        private void DgvProjectList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProjectDetail frmProjectDetail = new frmProjectDetail
            {
                Text = "Update project",
                CreateOrUpdate = true,
                ProjectInf = GetProjectObject(),
                ProjectRepository = repository
            };
            if (frmProjectDetail.ShowDialog() == DialogResult.OK)
            {
                ReadProjectList();
                source.Position = source.Count - 1;
            }



        }
        private void ClearText()
        {
            txtProjectID.Text = string.Empty;
            txtProjectName.Text = string.Empty;
            txtEstimatedStartDate.Text = string.Empty;
            txtEstimatedEndDate.Text = string.Empty;
            txtProjectDescription.Text = string.Empty;
            txtProjectAddress.Text = string.Empty;
            txtProjectCity.Text = string.Empty;
        }
        private ProjectObject GetProjectObject()
        {
            ProjectObject projectObject = null;
            try
            {
                projectObject = new ProjectObject
                {
                    ProjectID = txtProjectID.Text,
                    ProjectName = txtProjectName.Text,
                    EstimatedStartDate = txtEstimatedStartDate.Text,
                    EstimatedEndDate = txtEstimatedEndDate.Text,
                    ProjectDescription = txtProjectDescription.Text,
                    ProjectAddress = txtProjectAddress.Text,
                    ProjectCity = txtProjectCity.Text
                };
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Get project");
            }
            return projectObject;
        }
        public void ReadProjectList()
        {
            var project = repository.GetProjects();
            try
            {
                source = new BindingSource();
                source.DataSource = project;

                txtProjectID.DataBindings.Clear();
                txtProjectName.DataBindings.Clear();
                txtEstimatedStartDate.DataBindings.Clear();
                txtEstimatedEndDate.DataBindings.Clear();
                txtProjectDescription.DataBindings.Clear();
                txtProjectAddress.DataBindings.Clear();
                txtProjectCity.DataBindings.Clear();

                txtProjectID.DataBindings.Add("Text", source, "ProjectID");
                txtProjectName.DataBindings.Add("Text", source, "ProjectName");
                txtEstimatedStartDate.DataBindings.Add("Text", source, "EstimatedStartDate");
                txtEstimatedEndDate.DataBindings.Add("Text", source, "EstimatedEndDate");
                txtProjectDescription.DataBindings.Add("Text", source, "ProjectDescription");
                txtProjectAddress.DataBindings.Add("Text", source, "ProjectAddress");
                txtProjectCity.DataBindings.Add("Text", source, "ProjectCity");

                dgvProjectList.DataSource = null;
                dgvProjectList.DataSource = source;
                if (project.Count() == 0)
                {
                    ClearText();
                    btDelete.Enabled = false;
                }
                else
                {
                    btDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Read project list");
            }
        }
        private void btRead_Click(object sender, EventArgs e)
        {
            ReadProjectList();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            ClearText();
            frmProjectDetail frmProjectDetail = new frmProjectDetail
            {
                Text = "Create project",
                CreateOrUpdate = false,
                ProjectRepository = repository
            };
            if (frmProjectDetail.ShowDialog() == DialogResult.OK)
            {
                ReadProjectList();
                source.Position = source.Count - 1;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var project = GetProjectObject();
                repository.DeleteProject(project.ProjectID);
                ReadProjectList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a Project");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
