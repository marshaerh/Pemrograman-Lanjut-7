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

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(txtUsername.Text == "marsha" && txtPassword.Text == "marsha1")
            {
                Menu wObj = new Menu();
                wObj.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Maaf username atau password salah!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus(); 
            }
        }
    }
}
