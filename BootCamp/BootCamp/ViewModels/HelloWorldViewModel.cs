using Prism.Commands;
using Prism.Navigation;

namespace BootCamp.ViewModels
{
    public class HelloWorldViewModel : ViewModelBase
    {
        private string _name;
        private string _message;
        private string _userInput;
        private bool _isEnabled;
        private string _colorInput;
        public string ColorInput
        {
            get { return _colorInput; }
            set { SetProperty(ref _colorInput, value); }
        }
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { SetProperty(ref _isEnabled, value); }
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
        public HelloWorldViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Hello World";
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Message = parameters.GetValue<string>("key_message");
            Name = parameters.GetValue<string>("key_name");
            UserInput = parameters.GetValue<string>("key_input");
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        private DelegateCommand _goBackCommand;
        public DelegateCommand GoBackCommand =>
            _goBackCommand ?? (_goBackCommand = new DelegateCommand(ExecuteGoBackCommand, CanExecuteGoBackCommand).ObservesProperty(() => IsEnabled));

        void ExecuteGoBackCommand()
        {
            //NavigationService.NavigateAsync("MainPage",
            //    new NavigationParameters() {
            //        { "key_message","snoopy is VERY cool" },
            //        { "key_name", "ghostbusters" },
            //    });

            NavigationService.GoBackAsync(new NavigationParameters() {
                    { "key_message","snoopy is VERY cool" },
                    { "key_name", "GHOSTBUSTERS" },
                    { "key_color", _colorInput },
                });
        }

        bool CanExecuteGoBackCommand()
        {
            return IsEnabled;
        }
    }
}
