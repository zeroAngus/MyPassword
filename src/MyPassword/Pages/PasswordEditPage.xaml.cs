﻿using MyPassword.Dtos;
using MyPassword.Models;
using MyPassword.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPassword.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PasswordEditPage : BaseContentPage
	{
        PasswordEditViewModel viewModel;
		public PasswordEditPage() 
        {
            InitializeComponent();
            InitViewModel(null);
        }

        public PasswordEditPage(PwdDataDto data)
        {
            InitializeComponent();
            InitViewModel(data);
        }

        private void InitViewModel(PwdDataDto data)
        {
            viewModel = App.Locator.GetViewModel<PasswordEditViewModel, PwdDataDto>(data);
            BindingContext = viewModel;
        }

        protected override void OnAppear()
        {
        }

        protected override void OnFirstAppear()
        {
        }

        public override void OnPoppedOut()
        {
            Debug.WriteLine(string.Format("{0} is popped out", this.GetType().Name));
        }
    }
}