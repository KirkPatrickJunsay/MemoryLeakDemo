﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemoryLeakDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SubPage2 : ContentPage
	{
		public SubPage2 ()
		{
			InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            MessagingCenter.Subscribe<string>(this, "UpdatePage2Label", (param) =>
            {
                Page2Label.Text = param;
            });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<string>(this, "UpdatePage2Label");
        }
    }
}