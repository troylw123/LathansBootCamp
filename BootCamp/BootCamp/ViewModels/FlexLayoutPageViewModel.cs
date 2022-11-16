using Prism.Navigation;

namespace BootCamp.ViewModels
{
    public class FlexLayoutPageViewModel : ViewModelBase
    {
        public FlexLayoutPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Flex Layout Page";

        }
    }
}
