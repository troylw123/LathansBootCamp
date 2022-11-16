using Prism.Navigation;

namespace BootCamp.ViewModels
{
    public class GridsPageViewModel : ViewModelBase
    {
        public GridsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Grids Page";

        }
    }
}
