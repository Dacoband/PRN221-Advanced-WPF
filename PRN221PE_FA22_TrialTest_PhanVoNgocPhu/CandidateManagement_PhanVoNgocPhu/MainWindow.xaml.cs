using Candidate_BussinessObjects.Models;
using Candidate_Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CandidateManagement_PhanVoNgocPhu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IHRAccountService iHRAccountService;
        public MainWindow()
        {
            InitializeComponent();
            iHRAccountService = new HRAccountService();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Hraccount hraccount = iHRAccountService.GetHraccount(txtEmail.Text);
            if (hraccount != null && txtPassword.Password.Equals(hraccount.Password) && hraccount.MemberRole == 1)
            {
                JobPostingWindow jbWindow = new JobPostingWindow();
                jbWindow.Show();
                this.Close();
            } else if (hraccount != null && txtPassword.Password.Equals(hraccount.Password) && hraccount.MemberRole == 2)
            {
                CandidateProfileWindow cpWindow = new CandidateProfileWindow();
                cpWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Fail!");
            }
        }
    }
}