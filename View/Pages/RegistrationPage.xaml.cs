using BeautySaloon.Models;
using BeautySaloon.Controllers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BeautySaloon.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Users newUser = new Users()
            {
                Idrole = 2,
                userName = NameTextBox.Text,
                userLastName = LastNameTextBox.Text,
                userOtherName = OtherNameTextBox.Text,
                userLogin = LoginTextBox.Text,
                userPassword = PasswordPasswordBox.Password
            };

            if (UsersController.AddUser(newUser))
            {
                MessageBox.Show("запись добавлена");
                NavigationService.Navigate(new AuthorizationPage());
            }

        }

        private void CaptchaButton_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            string capcha = "123456789ABCDEFGHIYKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            char[] code = capcha.ToCharArray();

            

            
        }

        private void CheckCaptchaButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
