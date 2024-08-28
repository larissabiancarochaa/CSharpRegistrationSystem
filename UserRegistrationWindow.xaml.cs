using System;
using System.Windows;
using CrudCSharp.Data;

namespace CrudCSharp
{
    public partial class UserRegistrationWindow : Window
    {
        private DatabaseHelper _databaseHelper;

        public UserRegistrationWindow()
        {
            InitializeComponent();
            _databaseHelper = new DatabaseHelper();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            string confirmPassword = ConfirmPasswordBox.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Registration Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Registration Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                _databaseHelper.RegisterUser(username, password);
                MessageBox.Show("User registered successfully!", "Registration Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while registering the user: {ex.Message}", "Registration Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}