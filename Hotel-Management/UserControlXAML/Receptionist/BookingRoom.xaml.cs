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

namespace Hotel_Management.UserControlXAML.Receptionist
{
    /// <summary>
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class BookingRoom : UserControl
    {
        public BookingRoom()
        {
            InitializeComponent();
        }
        private void BookingRoomMenu_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int index = BookingRoomMenu.SelectedIndex;
            addService.Visibility = Visibility.Hidden;

            switch(index)
            {
                case 0:
                    addCustomer.Visibility = Visibility.Visible;
                    break;
                case 1:
                    addService.Visibility = Visibility.Visible;
                    break;
            }
        }

    }
}
