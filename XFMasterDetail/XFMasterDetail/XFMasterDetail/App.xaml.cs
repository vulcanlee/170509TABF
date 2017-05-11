using Prism.Unity;
using XFMasterDetail.Views;
using Xamarin.Forms;

namespace XFMasterDetail
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MDPage/NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
            //NavigationService.NavigateAsync("MDPage/NaviPage/P2Page");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<NextPage>();
            Container.RegisterTypeForNavigation<P1Page>();
            Container.RegisterTypeForNavigation<P2Page>();
            Container.RegisterTypeForNavigation<NaviPage>();
            Container.RegisterTypeForNavigation<MDPage>();
        }
    }
}
