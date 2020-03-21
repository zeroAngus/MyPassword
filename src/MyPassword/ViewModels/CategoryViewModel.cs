﻿using GalaSoft.MvvmLight.Command;
using MyPassword.Pages;
using MyPassword.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MyPassword.ViewModels
{

   
    public class CategoryViewModel:BaseViewModel
    {

        private ObservableCollection<CategoryItemViewModel> _CategoryItems;

        public ObservableCollection<CategoryItemViewModel> CategoryItems
        {
            get => _CategoryItems ?? (_CategoryItems = new ObservableCollection<CategoryItemViewModel>());
            set
            {
                _CategoryItems = value;
                RaisePropertyChanged(nameof(CategoryItems));
            }
        }


        public CategoryViewModel(ICategoryService categoryService)
        {
            foreach(var c in categoryService.Categories)
            {
                CategoryItems.Add(new CategoryItemViewModel
                {
                    Name = c.Name,
                    Icon = c.Icon,
                    Key = c.Key,
                    Count = 0,
                    ItemClickCommand = ItemClickCommand
                });
            }
        }

        private ICommand ItemClickCommand => new RelayCommand<CategoryItemViewModel>((c)=> {
            alertService.DisplayAlert("密钥", ""+c.Name, "确定");
        });

        public ICommand SearchCommand => new RelayCommand(() => {
            alertService.DisplayAlert("密钥","功能开发中...","确定");
        });
        public ICommand AddCommand => new RelayCommand(async () => {
            await NavigationService.PushAsync(new PasswordEditPage());
        });
    }
}
