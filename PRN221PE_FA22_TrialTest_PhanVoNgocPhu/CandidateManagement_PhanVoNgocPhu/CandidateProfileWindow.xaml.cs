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
    /// Interaction logic for CandidateProfileWindow.xaml
    /// </summary>
    public partial class CandidateProfileWindow : Window
    {
        private readonly ICandidateProfileService _candidateProfileService;
        public CandidateProfileWindow()
        {
            InitializeComponent();
            _candidateProfileService = new CandidateProfileService();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void LoadInitData()
        {
            this.dgCandidateProfile.ItemsSource = _candidateProfileService.GetCandidateProfiles();
        }
        private void dgCandidateProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string id = ((TextBlock)RowColumn.Content).Text;
            CandidateProfile candidateProfile = _candidateProfileService.GetCandidateProfile(id);
            if (candidateProfile != null)
            {
                txtCandidateId.Text = candidateProfile.CandidateId.ToString();
                txtFullname.Text = candidateProfile.Fullname.ToString();
                txtCandidateDescription.Text = candidateProfile.ProfileShortDescription.ToString();
                dpBirthday.Text = candidateProfile.Birthday.ToString();
                txtImageURL.Text = candidateProfile.ProfileUrl.ToString();
                cbbJobPosting.Text = candidateProfile.Posting.ToString();
            }
        }

        private void dgCandidateProfile_Loaded(object sender, RoutedEventArgs e)
        {
            this.dgCandidateProfile.ItemsSource = _candidateProfileService.GetCandidateProfiles();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadInitData();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile profile = new CandidateProfile();
            profile.PostingId = cbbJobPosting.Text;
            profile.ProfileShortDescription = txtCandidateDescription.Text;
            profile.Fullname = txtFullname.Text;
            profile.CandidateId = txtCandidateId.Text;
            profile.ProfileUrl = txtImageURL.Text;
            profile.Birthday = DateTime.Parse(dpBirthday.Text);
            if (_candidateProfileService.AddCandidateProfile(profile))
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
            if (txtCandidateId.Text.Length > 0)
            {
                CandidateProfile candidateProfile = new CandidateProfile();
                candidateProfile.CandidateId = txtCandidateId.Text;
                candidateProfile.ProfileShortDescription = txtCandidateDescription.Text;
                candidateProfile.Fullname = txtFullname.Text;
                candidateProfile.Birthday = DateTime.Parse(dpBirthday.Text);
                candidateProfile.ProfileUrl = txtImageURL.Text;
                candidateProfile.Posting.JobPostingTitle = cbbJobPosting.Text;
                _candidateProfileService.UpdateCandidateProfile(candidateProfile);
                LoadInitData();
            }
            else
            {
                MessageBox.Show("You must select a Candidate Profile!");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (txtCandidateId.Text.Length > 0)
            {
                CandidateProfile candidateProfile = _candidateProfileService.GetCandidateProfile(txtCandidateId.Text);
                if (candidateProfile != null)
                {
                    _candidateProfileService.RemoveCandidateProfile(txtCandidateId.Text);
                    LoadInitData();
                }
            }
            else
            {
                MessageBox.Show("You must select a Candidate Profile!");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
