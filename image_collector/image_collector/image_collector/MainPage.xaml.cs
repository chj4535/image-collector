using image_collector.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace image_collector
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainViewModel mainViewmodel = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainViewmodel;
        }
    }
}
