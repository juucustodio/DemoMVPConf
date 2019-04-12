using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DemoMVPConf.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://mvpconf.com.br")));
        }

        public ICommand OpenWebCommand { get; }
    }
}