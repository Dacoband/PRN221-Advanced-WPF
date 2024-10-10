using Candidate_BussinessObjects.Models;
using Candidate_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CandidateManagement_PhanVoNgocPhu
{
    /// <summary>
    /// Interaction logic for JobPosting.xaml
    /// </summary>
    public partial class JobPostingWindow : Window
    {
        private readonly IJobPostingService _jobPostingService;
        public JobPostingWindow()
        {
            InitializeComponent();
            _jobPostingService = new JobPostingService();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            JobPosting job = new JobPosting();
            job.PostingId = txtPostingID.Text;
            job.Description = txtDescription.Text;
            job.JobPostingTitle = txtTitle.Text;
            job.PostedDate = DateTime.Parse(dpPostDate.Text);
            if (_jobPostingService.AddJobPosting(job))
            {
                LoadInitData();
                MessageBox.Show("Add Successfully!");
            }
            else
            {
                MessageBox.Show("Add Failed!");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (txtPostingID.Text.Length > 0)
            {
                JobPosting job = new JobPosting();
                job.PostingId = txtPostingID.Text;
                job.Description = txtDescription.Text;
                job.JobPostingTitle = txtTitle.Text;
                job.PostedDate = DateTime.Parse(dpPostDate.Text);
                _jobPostingService.UpdateJobPosting(job);
                LoadInitData();
            }
            else
            {
                MessageBox.Show("You must select a Job Posting!");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (txtPostingID.Text.Length > 0)
            {
                JobPosting posting = _jobPostingService.GetJobPosting(txtPostingID.Text);
                if (posting != null)
                {
                    _jobPostingService.RemoveJobPosting(txtPostingID.Text);
                    LoadInitData();
                }
            }
            else
            {
                MessageBox.Show("You must select a Job Posting!");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtPostingID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dgData_Loaded(object sender, RoutedEventArgs e)
        {
            this.dgData.ItemsSource = _jobPostingService.GetJobPostings();
        }
        private void LoadInitData()
        {
            this.dgData.ItemsSource = _jobPostingService.GetJobPostings();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadInitData();
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string id = ((TextBlock)RowColumn.Content).Text;
            JobPosting job = _jobPostingService.GetJobPosting(id);
            if (job != null)
            {
                txtPostingID.Text = job.PostingId.ToString();
                txtTitle.Text = job.JobPostingTitle.ToString();
                txtDescription.Text = job.Description.ToString();
                dpPostDate.Text = job.PostedDate.ToString();
            }
        }
    }
}
