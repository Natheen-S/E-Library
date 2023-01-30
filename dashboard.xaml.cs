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
using System.Windows.Shapes;

namespace E_Library
{
    /// <summary>
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class dashboard : Window
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton== MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(e.RightButton== MouseButtonState.Pressed)
            {
                Close();
            }
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Do you want to logout?","e-Library",MessageBoxButton.OKCancel,MessageBoxImage.Information);
           if(res == MessageBoxResult.OK)
            {
                
                
                this.Close();

            }
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl1.Width = 100;
            lbl1.Height = 150;
           
        }

        private void lbl1_MouseLeave(object sender, MouseEventArgs e)
        {
           
            lbl1.Width = 80;
            lbl1.Height = 120;
            
        }

        private void lbl2_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl2.Width = 80;
            lbl2.Height = 120;
        }

        private void lbl2_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl2.Width = 100;
            lbl2.Height = 150;
        }

        private void lbl3_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl3.Width = 80;
            lbl3.Height = 120;
        }

        private void lbl3_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl3.Width = 100;
            lbl3.Height = 150;
        }

        private void lbl4_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl4.Width = 100;
            lbl4.Height = 150;
        }

        private void lbl4_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl4.Width = 80;
            lbl4.Height = 120;
        }
    }
}
