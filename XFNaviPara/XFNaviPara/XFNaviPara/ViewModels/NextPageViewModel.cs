using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace XFNaviPara.ViewModels
{
    public class NextPageViewModel : BindableBase, INavigationAware
    {


        #region label1
        private string _label1;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public string label1
        {
            get { return this._label1; }
            set { this.SetProperty(ref this._label1, value); }
        }
        #endregion

        #region labe2
        private int _label2;
        /// <summary>
        /// PropertyDescription
        /// </summary>
        public int label2
        {
            get { return this._label2; }
            set { this.SetProperty(ref this._label2, value); }
        }
        #endregion

        public NextPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if(parameters.ContainsKey("Name"))
            {
                label1 = parameters["Name"] as string;
            }
            int v1=0,v2=0;
            if (parameters.ContainsKey("value1"))
            {
                v1 = (int)parameters["value1"];
            }
            if (parameters.ContainsKey("value2"))
            {
                v2 = (int)parameters["value2"];
            }
            label2 = v1 + v2;
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
