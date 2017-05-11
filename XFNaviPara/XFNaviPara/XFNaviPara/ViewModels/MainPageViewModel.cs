using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFNaviPara.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {

        #region entry1
        private string _entry1;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string entry1
        {
            get { return this._entry1; }
            set { this.SetProperty(ref this._entry1, value); }
        }
        #endregion

        #region entry2
        private int _entry2;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public int entry2
        {
            get { return this._entry2; }
            set { this.SetProperty(ref this._entry2, value); }
        }
        #endregion

        #region entry3
        private int _entry3;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public int entry3
        {
            get { return this._entry3; }
            set { this.SetProperty(ref this._entry3, value); }
        }
        #endregion


        public DelegateCommand NextPageCommand { get; set; }


        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
        {

            _navigationService = navigationService;

            NextPageCommand = new DelegateCommand(() =>
            {
                // 使用 NavigationParameters
                var fooNaviPara = new NavigationParameters();
                fooNaviPara.Add("value1", entry2);
                fooNaviPara.Add("value2", entry3);

                // 使用 QueryString
                var fooQString = "?Name=" + entry1;
                // 開始導航與傳入引數
                _navigationService.
                NavigateAsync("NextPage"+ fooQString, fooNaviPara);
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
