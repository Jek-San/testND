using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestND.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CoffeEquipmentPage : ContentPage
	{
		public CoffeEquipmentPage ()
		{
			InitializeComponent ();
			LabelCount.Text = "Hello From Code Behinds";
		}
		int count = 0;
        private void BtnClick_Clicked(object sender, EventArgs e)
        {
			count++;
			LabelCount.Text = $"You clicked {count} time(s)";
        }
    }
}