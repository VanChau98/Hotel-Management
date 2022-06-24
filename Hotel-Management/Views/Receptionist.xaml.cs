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
    /// Interaction logic for Receptionist.xaml
    /// </summary>
    public partial class Receptionist : Window
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void ReceptionistMenu_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int index = ReceptionistMenu.SelectedIndex;
            bookingRoom.Visibility = Visibility.Hidden;
            searchingRoom.Visibility = Visibility.Hidden;
            searchingService.Visibility = Visibility.Hidden;

            switch(index)
            {
                case 0:
                    break;
                case 1:
                    bookingRoom.Visibility = Visibility.Visible;
                    break;
                case 2:
                    searchingRoom.Visibility = Visibility.Visible;
                    break;
                case 3:
                    searchingService.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
