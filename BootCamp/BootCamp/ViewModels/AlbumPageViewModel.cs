using BootCamp.Models;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace BootCamp.ViewModels
{
    public class AlbumPageViewModel : ViewModelBase
    {
        private ObservableCollection<Album> _albums = new ObservableCollection<Album>();
        public ObservableCollection<Album> Albums { get { return _albums; } }
        public AlbumPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Album Page";



            _albums.Add(new Album { Artist = "Nirvana", Name = "Nevermind" });
            _albums.Add(new Album { Artist = "Green Day", Name = "Dookie" });
            _albums.Add(new Album { Artist = "The Offspring", Name = "Smash" });
            _albums.Add(new Album { Artist = "Bush", Name = "Sixteen Stone" });
            _albums.Add(new Album { Artist = "Oasis", Name = "Definitely Maybe" });
        }
    }
}
