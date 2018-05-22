﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyPassword.Pages
{
	public abstract class BaseContentPage : ContentPage
	{
        private bool IsFirstAppear;

        public BaseContentPage()
        {
            IsFirstAppear = true;
            this.Appearing += BaseContentPage_Appearing;
        }


        private void BaseContentPage_Appearing(object sender, EventArgs e)
        {
            if (IsFirstAppear)
            {
                OnFirstAppear();
                IsFirstAppear = false;
            }
            else
            {
                OnAppear();
            }
        }

        #region abstract method

        protected abstract void OnFirstAppear();

        protected abstract void OnAppear();

        #endregion
    }
}