using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using XFListView.Models;

namespace XFListView.ViewModels
{

    [ImplementPropertyChanged]
    public class MainPageViewModel : INavigationAware
    {
        #region Repositories (遠端或本地資料存取)

        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        #region 基本型別與類別的 Property
        public MyTaskItem SelectedMyTaskItem { get; set; }
        #endregion

        #region 集合類別的 Property

        public ObservableCollection<MyTaskItem> MyTasks { get; set; } =
            new ObservableCollection<MyTaskItem>();
        #endregion

        #endregion

        #region Field 欄位

        #region ViewModel 內使用到的欄位
        #endregion

        #region 命令物件欄位

        public DelegateCommand ItemTappedCommand { get; set; }

        #endregion

        #region 注入物件欄位
        private readonly INavigationService _navigationService;
        #endregion

        #endregion

        #region Constructor 建構式
        public MainPageViewModel(INavigationService navigationService)
        {

            #region 相依性服務注入的物件

            _navigationService = navigationService;
            #endregion

            #region 頁面中綁定的命令
            ItemTappedCommand = new DelegateCommand(() =>
            {
                if (SelectedMyTaskItem.TaskName == "")
                {
                    var fooi = 0;
                }
            });
            #endregion

            #region 事件聚合器訂閱

            #endregion
        }

        #endregion

        #region Navigation Events (頁面導航事件)
        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            await ViewModelInit();
        }
        #endregion

        #region 設計時期或者執行時期的ViewModel初始化
        #endregion

        #region 相關事件
        #endregion

        #region 相關的Command定義
        #endregion

        #region 其他方法

        /// <summary>
        /// ViewModel 資料初始化
        /// </summary>
        /// <returns></returns>
        private async Task ViewModelInit()
        {
            MyTasks.Clear();
            for (int i = 0; i < 100; i++)
            {
                MyTasks.Add(new MyTaskItem
                {
                    TaskName = $"Name{i}",
                    Status = (i % 3) == 0 ? "OK" : "Ready",
                    date = DateTime.Now.AddDays(i)

                });
            }
            await Task.Delay(100);
        }
        #endregion

    }
}
