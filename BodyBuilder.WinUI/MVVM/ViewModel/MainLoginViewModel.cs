using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.WinUI.Core;

namespace BodyBuilder.WinUI.MVVM.ViewModel
{
    class MainLoginViewModel:ObservableObject
    {

        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand RegisterViewCommand { get; set; }

        public LoginViewModel loginVM { get; set; }
        public RegisterViewModel registerVM { get; set; }

        private object _currenView;
        public object CurrentView
        {
            get { return _currenView;}
            set
            {
                _currenView = value;
                OnPropertyChanged();
            }
        }

        public MainLoginViewModel()
        {
            loginVM = new LoginViewModel();
            registerVM = new RegisterViewModel();

            CurrentView = loginVM;

            LoginViewCommand = new RelayCommand(o => { CurrentView = loginVM; });
            RegisterViewCommand = new RelayCommand(o => { CurrentView = registerVM; });
        }
    }
}
