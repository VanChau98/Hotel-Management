using ManagementHotel.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ManagementHotel.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        public ICommand loginCommand { get; set; }

        public MainViewModel()
        {
            loginCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                //ReceptionistWindow rw = new ReceptionistWindow();
                //rw.ShowDialog();
                ManagerWindow mw = new ManagerWindow();
                mw.ShowDialog();
            });
        }

       
    }
}
