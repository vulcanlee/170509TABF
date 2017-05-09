using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFPrism.ViewModels
{

    [ImplementPropertyChanged]
    public class MainPageViewModel :  INavigationAware
    {
        public string Title { get; set; }
        public string fooEntry { get; set; }
        public string fooLabel { get; set; }
        public DelegateCommand OKCommand { get; set; }
        public MainPageViewModel()
        {
            OKCommand = new DelegateCommand(() =>
            {
                fooLabel = "Hi Prism, " + fooEntry;
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
