using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentGroup_BangLuongCong
{
    /// <summary>
    /// Interaction logic for StudentDetailWindow.xaml
    /// </summary>
    public partial class StudentDetailWindow : Window
    {
        public Student SelectedStudent { get; set; } = null;
        public StudentDetailWindow()
        {
            InitializeComponent();
        }

        private void StudentDetail_Loaded(object sender, RoutedEventArgs e)
        {
            StudentGroupService _groupS = new StudentGroupService();
            //đổ data vô combobox
            cbbGroupId.ItemsSource = _groupS.GetStudentGroupList();

            //chọn cột để hiển thị cho cbb
            cbbGroupId.DisplayMemberPath = "GroupName";
            cbbGroupId.SelectedValuePath = "Id";

            //Check mode edit or create
            if (SelectedStudent != null)
            {
                lblHeader.Content = "Update a Student";
                txtId.Text = SelectedStudent.Id.ToString();
                txtId.IsEnabled = false;
                txtFullname.Text = SelectedStudent.FullName;
                txtEmail.Text = SelectedStudent.Email;
                dtpDateOfBirth.Text = SelectedStudent.DateOfBirth.ToString();
                cbbGroupId.SelectedValue = SelectedStudent.GroupId.ToString();
            }
            else
            {
                lblHeader.Content = "Create a Student";
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Check Format Email
        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        //Check Fortmat FullName
        private bool IsValidFullName(string fullName)
        {
            if (fullName.Length < 5 || fullName.Length > 40)
            {
                return false;
            }
            var namePattern = @"^[A-Z][a-z]*(?:\s[A-Z][a-z]*)*$";
            return Regex.IsMatch(fullName, namePattern);
        }

        private bool CheckValidationStudent(Student s)
        {
            #region Check Email
            if (string.IsNullOrEmpty(s.Email))
            {
                System.Windows.MessageBox.Show("Email must be required", "Invalid Email", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (!IsValidEmail(s.Email))
            {
                System.Windows.MessageBox.Show("Invalid email format", "Invalid Email", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            #endregion

            #region Check FullName
            if (string.IsNullOrEmpty(s.FullName))
            {
                System.Windows.MessageBox.Show("FullName must be required", "Invalid FullName", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!IsValidFullName(s.FullName))
            {
                System.Windows.MessageBox.Show("Invalid FullName. It must be 5-40 characters long, each word must begin with a capital letter, and special characters are not allowed.", "Invalid FullName", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            #endregion

            #region Check DateOfBirth
            var dateCheck = new DateTime(2005, 1, 1);
            if (!s.DateOfBirth.HasValue)
            {
                System.Windows.MessageBox.Show("DateOfBirth must be required", "Invalid Date", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (s.DateOfBirth > dateCheck)
            {
                System.Windows.MessageBox.Show("DateOfBirth must be before 1/1/2005", "Invalid Date", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            #endregion

            return true;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cbbGroupId.SelectedValue == null || !int.TryParse(cbbGroupId.SelectedValue.ToString(), out int groupId))
            {
                System.Windows.MessageBox.Show("GroupId must be selected", "Invalid GroupId", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Student student = new Student()
            {
              Email = txtEmail.Text,
              FullName = txtFullname.Text,
              DateOfBirth = dtpDateOfBirth.SelectedDate,
              GroupId = int.Parse(cbbGroupId.SelectedValue.ToString()),
            };
            if (CheckValidationStudent(student))
            {
                StudentService service = new StudentService();
                if (SelectedStudent != null)
                {
                    student.Id = int.Parse(txtId.Text);
                    service.UpdateStudentFromUI(student);
                    System.Windows.MessageBox.Show("Update a student successfully...!", "Update Student", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    service.AddStudentFromUI(student);
                    System.Windows.MessageBox.Show("Create a new student successfully...!", "Create Student", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                this.Close();
            }

                
            
        }
    }
}
