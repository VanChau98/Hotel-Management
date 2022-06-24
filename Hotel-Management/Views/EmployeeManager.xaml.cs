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

namespace Hotel_Management.Views
{
    /// <summary>
    /// Interaction logic for EmployeeManager.xaml
    /// </summary>
    public partial class EmployeeManager : Window
    {
        public EmployeeManager()
        {
            InitializeComponent();
        }

        private void ListViewMenu_SeletionChanged(object sender, RoutedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            employee.Visibility = Visibility.Hidden;

            switch(index)
            {
                case 0:
                    employee.Visibility = Visibility.Visible;
                    break;
                case 1:
                    break;
            }
        }
    }
}
