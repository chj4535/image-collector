﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace image_collector.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _UserID;
        public string UserID
        {
            get
            {
                return _UserID;
            }

            set
            {
                if (_UserID == value) return;
                _UserID = value;
                OnPropertyChanged("UserID");
            }
        }

        private string _UserName;
        public string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                if (_UserName == value) return;
                _UserName = value;
                OnPropertyChanged("UserName");
            }
        }

        private string _Email;
        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                if (_Email == value) return;
                _Email = value;
                OnPropertyChanged("Email");
            }
        }

        private string _Telephone;
        public string Telephone
        {
            get
            {
                return _Telephone;
            }

            set
            {
                if (_Telephone == value) return;
                _Telephone = value;
                OnPropertyChanged("Telephone");
            }
        }

        private DateTime _RegistDate;
        public DateTime RegistDate
        {
            get
            {
                return _RegistDate;
            }

            set
            {
                if (_RegistDate == value) return;
                _RegistDate = value;
                OnPropertyChanged("RegistDate");
            }
        }

        public ICommand RegistCommand { get; private set; }
        public ICommand ModifyCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        public MainViewModel()
        {
            RegistCommand = new Command(Regist);
            ModifyCommand = new Command<string>(Modify);
            DeleteCommand = new Command(Delete);
            this.UserID = "Eddy.Kang";
            this.UserName = "강창훈";
            this.Email = "admin@signalsoft.co.kr";
            this.Telephone = "010-2760-5246";
            this.RegistDate = DateTime.Now;
        }

        private void Regist()
        {

        }

        private void Modify(string commandPrameter)
        {
            var test = commandPrameter;
        }

        private void Delete()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
