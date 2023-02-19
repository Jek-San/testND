using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace TestND.ViewModels
{
    public class CoffeEquipmentViewModel : ViewModelBase
    {
        public ObservableCollection<string> Coffee { get; set; }
        public CoffeEquipmentViewModel() { 
			IncreaseCount = new Command(OnIncrease);
            CallServerCommand = new AsyncCommand(CallServer);
            Title = "Coffe Equipment";

        }

        public ICommand CallServerCommand { get;  }

        async Task CallServer()
        {
            Coffee.Add("Yes Pls");
            Coffee.Add("Sanger");
            Coffee.Add("Expresso");

        }
        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }
        int count = 0;

        public ICommand IncreaseCount { get; }


        string countDisplay = "Click Me";


        public string CountDisplay
        {
            get => countDisplay;
            set => SetProperty(ref countDisplay, value);
        }
    }
}
