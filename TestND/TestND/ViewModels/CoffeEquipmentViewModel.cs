using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestND.ViewModels
{
    public class CoffeEquipmentViewModel : BindableObject
    {
        public CoffeEquipmentViewModel() { 
			IncreaseCount = new Command(OnIncrease);

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
            get => countDisplay; set
            {
                if (value == countDisplay)
                {
                    return;
                }
                else
                {
                    countDisplay = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
