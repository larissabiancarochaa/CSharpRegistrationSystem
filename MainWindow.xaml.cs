using System.Windows;
using System.Windows.Controls;
using CrudCSharp.Data; 

namespace CrudCSharp
{
    public partial class MainWindow : Window
    {
        private DatabaseHelper _databaseHelper;

        public MainWindow()
        {
            InitializeComponent();
            UpdatePlaceholderVisibility();
            _databaseHelper = new DatabaseHelper(); 
        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdatePlaceholderVisibility();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            UpdatePlaceholderVisibility();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            UsernamePlaceholder.Visibility = UsernameTextBox.Text.Length == 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            UsernamePlaceholder.Visibility = UsernameTextBox.Text.Length == 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordPlaceholder.Visibility = PasswordBox.Password.Length == 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordPlaceholder.Visibility = PasswordBox.Password.Length == 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        private void UpdatePlaceholderVisibility()
        {
            UsernamePlaceholder.Visibility = string.IsNullOrEmpty(UsernameTextBox.Text) ? Visibility.Visible : Visibility.Collapsed;
            PasswordPlaceholder.Visibility = string.IsNullOrEmpty(PasswordBox.Password) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (_databaseHelper.ValidateUser(username, password))
            {
                MessageBox.Show("Login successful!", "Login Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                var successWindow = new SuccessWindow();
                successWindow.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            var registrationWindow = new UserRegistrationWindow();
            registrationWindow.ShowDialog();
        }
    }
}