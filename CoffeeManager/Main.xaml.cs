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

namespace CoffeeManager
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            EmployeeManager em = new EmployeeManager();
            this.Hide();
            em.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Report rp = new Report();
            this.Hide();
            rp.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Close();
        }
    }
}
