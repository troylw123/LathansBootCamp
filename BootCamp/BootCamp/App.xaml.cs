using BootCamp.ViewModels;
using BootCamp.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;


namespace BootCamp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<HelloWorld, HelloWorldViewModel>();
            containerRegistry.RegisterForNavigation<AlbumPage, AlbumPageViewModel>();
            containerRegistry.RegisterForNavigation<GridsPage, GridsPageViewModel>();
            containerRegistry.RegisterForNavigation<FlexLayoutPage, FlexLayoutPageViewModel>();
            containerRegistry.RegisterForNavigation<VisualStatePage, VisualStatePageViewModel>();
        }
    }
}
