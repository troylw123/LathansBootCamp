using Prism.Commands;
using Prism.Navigation;
using System.ComponentModel;

namespace BootCamp.ViewModels
{
    [DesignTimeVisible(false)]
    public class MainPageViewModel : ViewModelBase
    {

        private DelegateCommand _goCommand;
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
