﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MyPassword.Manager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyPassword.ViewModels
{
    public class SecureKeyViewModel:ViewModelBase
    {

        private string _SecureKey;

        public string SecureKey
        {
            get
            {
                if(_SecureKey == null)
                {
                    _SecureKey = "";
                }
                return _SecureKey;
            }
            set
            {
                _SecureKey = value;
                RaisePropertyChanged(nameof(SecureKey));
            }
        }

        private bool _HideSecureKey;

        public bool HideSecureKey
        {
            get
            {
                return _HideSecureKey;
            }
            set
            {
                _HideSecureKey = value;
                RaisePropertyChanged(nameof(HideSecureKey));
            }
        }

        readonly Action ActionSave;
        public SecureKeyViewModel(Action actionSave)
        {
            ActionSave = actionSave;
            HideSecureKey = true;
            SecureKey = SecureKeyManager.Instance.SecureKey;
            SaveCommand = new RelayCommand(()=>SaveExcute());
        }

        public ICommand SaveCommand { get; private set; }

        private void SaveExcute()
        {
            var oldKey = SecureKeyManager.Instance.SecureKey;
            if(!string.IsNullOrEmpty(SecureKey) && !oldKey.Equals(SecureKey))
            {
                SecureKeyManager.Instance.Save(SecureKey);
                ActionSave?.Invoke();
            }
        }


    }
}
