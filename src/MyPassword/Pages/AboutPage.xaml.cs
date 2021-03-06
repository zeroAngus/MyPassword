﻿using MyPassword.Localization;
using MyPassword.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPassword.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : BaseContentPage
	{
        public AboutPage ()
		{
			InitializeComponent ();
            BindingContext = App.Locator.GetViewModel<AboutViewModel,string>("");
        }

        protected override void OnAppear()
        {
        }

        protected override void OnFirstAppear()
        {
        }
    }
}