using Repositories.Entities;
using Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentGroup_BangLuongCong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentService _service = new StudentService();
        private Student _selected = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        public void FillDataGridView()
        {
            dtgStudentList.ItemsSource = null;
            dtgStudentList.ItemsSource = _service.GetStudentList();
        }

        private void StudentManagerWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataGridView();
        }

        private void dtgStudentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtgStudentList.SelectedItems.Count > 0)
            {
                Student _selected = dtgStudentList.SelectedItems[0] as Student;
                
                //Lưu thông tin đã chọn

            } else
            {
                _selected = null;
            }
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentDetailWindow f = new StudentDetailWindow();
            f.SelectedStudent = null;
            f.ShowDialog();
            FillDataGridView();
        }

        private void btnUpdateStudent_Click(object sender, RoutedEventArgs e)
        {
            _selected = dtgStudentList.SelectedItem as Student;
            if (_selected != null)
            {
                StudentDetailWindow f = new StudentDetailWindow();
                f.SelectedStudent = _selected;
                f.ShowDialog();
                FillDataGridView();
            } 
            else
            {
                System.Windows.MessageBox.Show("Please choose a student certain to update!", "Select one student", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            _selected = dtgStudentList.SelectedItem as Student;
            if (_selected == null)
            {
                System.Windows.MessageBox.Show("Please select a certain student to delete!", "Select one student", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            DialogResult answer = (DialogResult)System.Windows.MessageBox.Show("Do you really want to delete this student", "Confirm delete?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == System.Windows.Forms.DialogResult.No)
                return;

            _service.DeleteStudentFromUI(_selected);
            FillDataGridView();
            _selected = null;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFromYear.Text) && string.IsNullOrEmpty(txtToYear.Text))
            {
                return;
            }

            if (!int.TryParse(txtFromYear.Text, out int fromYear) || !int.TryParse(txtToYear.Text, out int toYear))
            {
                dtgStudentList.ItemsSource = null;
                return;
            }
            dtgStudentList.ItemsSource = null;
            dtgStudentList.ItemsSource = _service.GetSearchBirthDayStudents(fromYear, toYear);
            
            
        }
    }
}