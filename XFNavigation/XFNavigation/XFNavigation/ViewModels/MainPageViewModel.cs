using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFNavigation.ViewModels
{

    [ImplementPropertyChanged]
    public class MainPageViewModel :  INavigationAware
    {
        public string Title { get; set; }
        public DelegateCommand NextPageCommand { get; set; }

        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;
            NextPageCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync("NextPage");
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
