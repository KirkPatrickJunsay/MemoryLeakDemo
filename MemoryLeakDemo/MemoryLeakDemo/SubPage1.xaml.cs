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
	public partial class SubPage1 : ContentPage
	{
		public SubPage1 ()
		{
			InitializeComponent ();

            MessagingCenter.Subscribe<string>(this, "UpdatePage1Label", (param) =>
            {
                Page1Label.Text = param;
            });
        }
    }
}