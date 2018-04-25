// A ajouter pour chaque nouvelle vue 
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Test.View.Schedule.Calendar;
using Test.View.Schedule.Planning;

namespace Test
{
    public class MainWindowViewModel : ObservableObject
    {
        #region Fields

        private ICommand _changePageCommand;

        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;

        #endregion
        public MainWindowViewModel()
        {
            //A ajouter pour chaque nouvelle view

            PageViewModels.Add(new PlanningViewModel());
            PageViewModels.Add(new CalendarViewModel());


            CurrentPageViewModel = PageViewModels[1];

        }

        #region Properties / Commands

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return _changePageCommand;
            }
        }

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }

        }

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }


        #endregion

        // A ajouter pour chaque view appelée par un bouton
        #region Methods

  
        public IPageViewModel Planning
        {
            get
            {
                return PageViewModels[0];
            }
        }
        public IPageViewModel Calendar
        {
            get
            {
                return PageViewModels[1];
            }
        }

        #endregion
    }

}
