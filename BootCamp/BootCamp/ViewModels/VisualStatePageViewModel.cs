using Prism.Navigation;

namespace BootCamp.ViewModels
{
    public class VisualStatePageViewModel : ViewModelBase
    {
        public VisualStatePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Visual State Page";
        }
    }
}
