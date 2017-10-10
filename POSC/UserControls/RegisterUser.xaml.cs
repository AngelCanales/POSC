using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace POSC.UserControls
{
    /// <summary>
    /// Interaction logic for RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : UserControl 
    {
         public static readonly DependencyProperty SecurePasswordProperty = DependencyProperty.Register(
           "SecurePassword", typeof(SecureString), typeof(RegisterUser), new PropertyMetadata(default(SecureString)));

        public  string  passw { get; set; }
        public SecureString SecurePassword
        {
            get { return (SecureString)GetValue(SecurePasswordProperty); }
            set { SetValue(SecurePasswordProperty, value); }
        }
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var pass = sender as PasswordBox;
            SecurePassword = pass.SecurePassword;
            this.passw = pass.Password;
        }

       
    }
}
