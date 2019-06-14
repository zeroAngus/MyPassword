﻿using MyPassword.Models;
using MyPassword.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPassword.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingPage : BaseContentPage
	{
        SettingViewModel viewModel;
		public SettingPage () : base()
        {
            InitializeComponent();
            viewModel = new SettingViewModel();
            BindingContext = viewModel;
            SetTabBarVisible(true);
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
        }

        protected override void OnFirstAppear()
        {
        }

        protected override void OnAppear()
        {
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            if(e.Item is SettingItemModel)
            {
                var item = e.Item as SettingItemModel;
                if(item.SecureProtect)
                {
                    await Navigation.PushModalAsync(new GuestureVerifyPage(() =>
                    {
                        PushPage(item);
                        Navigation.PopModalAsync();
                    },true),true);
                }
                else
                {
                    PushPage(item);
                }
                
            }
            await Task.Delay(1000);
            ((ListView)sender).SelectedItem = null;
        }

        private void PushPage(SettingItemModel item)
        {
            var paramTpyes = new Type[0];
            var constructor = item.PageType.GetConstructor(paramTpyes);
            if (constructor != null)
            {
                var page = constructor.Invoke(null) as Page;
                Navigation.PushAsync(page);
            }
        }
    }
}