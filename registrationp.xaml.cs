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

namespace E_Library
{
    /// <summary>
    /// Interaction logic for registrationp.xaml
    /// </summary>
    public partial class registrationp : Page
    {
        public registrationp()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, RoutedEventArgs e)
        {
            if(txtbox_name.Text !=null && txtbox_emailid.Text !=null && txtbox_number.Text !=null && txtbox_username.Text !=null && txtbox_pass.Password !=null && txtbox_cpass.Password != null && rdbtn1.IsChecked==true || rdbtn2.IsChecked==true)
            {
                signin osignin = new signin();
                osignin.ShowsNavigationUI= true;
            }
        }
    }
}
