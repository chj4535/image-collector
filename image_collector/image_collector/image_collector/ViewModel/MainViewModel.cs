using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using image_collector.Model;
using System.Collections.ObjectModel;

namespace image_collector.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        MainModel mainModel = new MainModel();
        private string _url;
        public string url
        {
            get
            {
                return _url;
            }

            set
            {
                if (_url == value) return;
                _url = value;
                OnPropertyChanged("url");
            }
        }

        private string _data;
        public string data
        {
            get
            {
                return _data;
            }

            set
            {
                if (_data == value) return;
                _data = value;
                OnPropertyChanged("data");
            }
        }

        public ObservableCollection<string> imgList { get; set; }

        public ICommand ChangeUrlCommand { get; private set; }

        public MainViewModel()
        {
            imgList = new ObservableCollection<string>();
            ChangeUrlCommand = new Command<string>(ChangeUrl);
        }

        private void ChangeUrl(string commandPrameter)
        {
            this.imgList = mainModel.CrawlingUrl(commandPrameter);
            OnPropertyChanged("imgList");
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
