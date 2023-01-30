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
    /// Interaction logic for signin.xaml
    /// </summary>
    public partial class signin : Page
    {
        public signin()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtbox_txtpass.Text = txtbox_pass.Password;
            txtbox_pass.Visibility = Visibility.Hidden;
            txtbox_txtpass.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            txtbox_pass.Password = txtbox_txtpass.Text;
            txtbox_txtpass.Visibility = Visibility.Hidden;
            txtbox_pass.Visibility = Visibility.Visible;
        }

        private void btn_signip_Click(object sender, RoutedEventArgs e)
        {
            if(txtbox_username.Text == txtbox_pass.Password)
            {
                dashboard ds = new dashboard();
                ds.Show();
                
                
            }
            else
            {
                MessageBox.Show("Please enter correct email id or password");
            }
        }
    }
}
