using Prism.Commands;
using Prism.Navigation;

namespace BootCamp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand _goAlbumsCommand;
        private DelegateCommand _goCommand;
        private DelegateCommand _goGridsCommand;
        private DelegateCommand _goFlexCommand;
        private DelegateCommand _goVSGCommand;
        private string _name;
        private string _message;
        private string _userInput;
        private string _colorInput;


        public string ColorInput
        {
            get { return _colorInput; }
            set { SetProperty(ref _colorInput, value); }
        }

        public string UserInput
        {
            get { return _userInput; }
            set { SetProperty(ref _userInput, value); }
        }

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }


        public DelegateCommand GoCommand =>
            _goCommand ?? (_goCommand = new DelegateCommand(ExecuteGoCommand, CanExecuteGoCommand));

        public DelegateCommand GoAlbumsCommand =>
            _goAlbumsCommand ?? (_goAlbumsCommand = new DelegateCommand(ExecuteGoAlbumsCommand, CanExecuteGoAlbumsCommand));
        public DelegateCommand GoGridsCommand =>
            _goGridsCommand ?? (_goGridsCommand = new DelegateCommand(ExecuteGoGridsCommand, CanExecuteGoGridsCommand));

        public DelegateCommand GoFlexCommand =>
            _goFlexCommand ?? (_goFlexCommand = new DelegateCommand(ExecuteGoFlexCommand, CanExecuteGoFlexCommand));

        public DelegateCommand GoVSGCommand =>
            _goVSGCommand ?? (_goVSGCommand = new DelegateCommand(ExecuteGoVSGCommand, CanExecuteGoVSGCommand));

        private bool CanExecuteGoVSGCommand()
        {
            return true;
        }

        private void ExecuteGoVSGCommand()
        {
            NavigationService.NavigateAsync("VisualStatePage");
        }

        private bool CanExecuteGoFlexCommand()
        {
            return true;
        }

        private void ExecuteGoFlexCommand()
        {
            NavigationService.NavigateAsync("FlexLayoutPage");
        }

        private void ExecuteGoGridsCommand()
        {
            NavigationService.NavigateAsync("GridsPage");
        }

        private bool CanExecuteGoGridsCommand()
        {
            return true;
        }

        private bool CanExecuteGoAlbumsCommand()
        {
            return true;
        }

        private void ExecuteGoAlbumsCommand()
        {
            NavigationService.NavigateAsync("AlbumPage");
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

        }

        void ExecuteGoCommand()
        {
            NavigationService.NavigateAsync("HelloWorld",
                new NavigationParameters() {
                    { "key_message","snoopy is cool" },
                    { "key_name", "ghostbusters" },
                    { "key_input", _userInput },
                });
        }

        bool CanExecuteGoCommand()
        {
            return true;
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Message = parameters.GetValue<string>("key_message");
            Name = parameters.GetValue<string>("key_name");
            //UserInput = "";
            ColorInput = parameters.GetValue<string>("key_color");

        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }
    }
}
