﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MyPassword.Models
{
    public class SettingItemModel
    {
        public string Icon { get; set; }
        public string Title { get; set; }

        public string Background { get; set; }

        public string Description { get; set; }
        public Type PageType { get; set; }
        public bool SecureProtect { get; set; }

        public ICommand TappedCommand { get; set; }
    }
}
