using Hotel_Management.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Hotel_Management.ViewModels.Main
{
    public class MainModelView: BaseViewModel
    {
        public ICommand loginCommand { get; set; }

        public MainModelView()
        {
            loginCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                //Receptionist recep = new Receptionist();
                //recep.ShowDialog();
                StaffBusiness tb = new StaffBusiness();
                tb.ShowDialog();
            });
        }
    }
}
