using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_Osennikov.Classes;
using TaskManager_Osennikov.View;

namespace TaskManager_Osennikov.ViewModels
{
    public class VM_Pages : Notification
    {
        public VM_Tasks vm_Tasks = new VM_Tasks();

        public VM_Pages()
        {
            MainWindow.init.frame.Navigate(new Main(vm_Tasks));
        }

        public RelayCommand OnClose
        {
            get
            {
                return new RelayCommand(obj =>
                MainWindow.init.Close());
            }
        }
    }
}