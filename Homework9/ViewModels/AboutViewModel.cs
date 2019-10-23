using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Homework9.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Contacts";

        }

        public ICommand OpenMain{ get; }
    }
}