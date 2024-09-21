using Candidate_BusinessObjects.Models;
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

namespace CandidateManagement_HuynhThienNhan
{
    /// <summary>
    /// Interaction logic for CandidateProfileMange.xaml
    /// </summary>
    public partial class CandidateProfileMange : Window
    {
        private ICandidateProfileService candidateProfileService;
        public CandidateProfileMange()
        {
            InitializeComponent();
            candidateProfileService = new CandidateProfileService();
            LoadJobPostings();
            LoadCandidateProfiles();
        }
        private void LoadJobPostings()
        {
            // Assuming you have a method to fetch job postings
            List<JobPosting> jobPostings = new JobPostingService().GetJobPostings();
            cbbJobPosting.ItemsSource = jobPostings;
            cbbJobPosting.DisplayMemberPath = "JobPostingTitle";
            cbbJobPosting.SelectedValuePath = "PostingId";
        }

        private void LoadCandidateProfiles()
        {
            dgCandidateProfile.ItemsSource = candidateProfileService.GetCandidateProfiles();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidateProfile = new CandidateProfile
            {
                CandidateId = txtCandidateId.Text,
                Fullname = txtFullname.Text,
                Birthday = dpBirthday.SelectedDate,
                ProfileShortDescription = txtCandidateDescription.Text,
                ProfileUrl = txtImageURL.Text,
                PostingId = cbbJobPosting.SelectedValue?.ToString()
            };

            bool isSuccess = candidateProfileService.AddCandidateProfile(candidateProfile);
            if (isSuccess)
            {
                MessageBox.Show("Candidate profile added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearForm();
                LoadCandidateProfiles();
            }
            else
            {
                MessageBox.Show("Failed to add candidate profile.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidateProfile = candidateProfileService.GetCandidateProfile(txtCandidateId.Text);
            if (candidateProfile != null)
            {
                candidateProfile.Fullname = txtFullname.Text;
                candidateProfile.Birthday = dpBirthday.SelectedDate;
                candidateProfile.ProfileShortDescription = txtCandidateDescription.Text;
                candidateProfile.ProfileUrl = txtImageURL.Text;
                candidateProfile.PostingId = cbbJobPosting.SelectedValue?.ToString();

                bool isSuccess = candidateProfileService.UpdateCandidateProfile(candidateProfile);
                if (isSuccess)
                {
                    MessageBox.Show("Candidate profile updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClearForm();
                    LoadCandidateProfiles();
                }
                else
                {
                    MessageBox.Show("Failed to update candidate profile.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Candidate profile not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string candidateId = txtCandidateId.Text;
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this candidate profile?",
                                                      "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                bool isSuccess = candidateProfileService.RemoveCandidateProfile(candidateId);
                if (isSuccess)
                {
                    MessageBox.Show("Candidate profile deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClearForm();
                    LoadCandidateProfiles();
                }
                else
                {
                    MessageBox.Show("Failed to delete candidate profile.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtCandidateId.Text = string.Empty;
            txtFullname.Text = string.Empty;
            dpBirthday.SelectedDate = null;
            txtImageURL.Text = string.Empty;
            txtCandidateDescription.Text = string.Empty;
            cbbJobPosting.SelectedIndex = -1;
        }

        private void dgCandidateProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgCandidateProfile.SelectedItem != null)
            {
                CandidateProfile selectedProfile = (CandidateProfile)dgCandidateProfile.SelectedItem;

                txtCandidateId.Text = selectedProfile.CandidateId;
                txtFullname.Text = selectedProfile.Fullname;
                dpBirthday.SelectedDate = selectedProfile.Birthday;
                txtImageURL.Text = selectedProfile.ProfileUrl;
                txtCandidateDescription.Text = selectedProfile.ProfileShortDescription;
                cbbJobPosting.SelectedValue = selectedProfile.PostingId;
            }
        }
    }
}
