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
    /// Interaction logic for StaffBusiness.xaml
    /// </summary>
    public partial class StaffBusiness : Window
    {
        public StaffBusiness()
        {
            InitializeComponent();
        }

        private void ListViewMenu_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            customerManagement.Visibility = Visibility.Hidden;
            roomManagement.Visibility = Visibility.Hidden;
            serviceManagement.Visibility = Visibility.Hidden;
            statistics.Visibility = Visibility.Hidden;

            switch(index)
            {
                case 0:
                    customerManagement.Visibility = Visibility.Visible;
                    break;
                case 1:
                    roomManagement.Visibility = Visibility.Visible;
                    break;
                case 2:
                    serviceManagement.Visibility = Visibility.Visible;
                    break;
                case 3:
                    statistics.Visibility = Visibility.Visible;
                    break;

            }
        }
        
    }
}
