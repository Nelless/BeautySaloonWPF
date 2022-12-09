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
using BeautySaloon.Controllers;

namespace BeautySaloon.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
          this.NavigationService.Navigate(new RegistrationPage());
        }

        private void SignInbutton_Click(object sender, RoutedEventArgs e)
        {
            if(UsersController.Auth(LoginTextBox.Text, PasswordPasswordBox.Password))
            {
                this.NavigationService.Navigate(new CategoryPage());
            }
            else
            {
                this.NavigationService.Navigate(new RegistrationPage());
            }
        }
    }
}
