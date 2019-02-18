using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemoryLeakDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SubPage3 : ContentPage
	{
		public SubPage3 ()
		{
			InitializeComponent ();

            MessagingCenter.Subscribe<string>(this, "UpdatePage3Label", (param) =>
            {
                Page3Label.Text = param;
            });
        }
    }
}