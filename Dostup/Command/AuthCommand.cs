using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Dostup
{
    public class AuthCommand : ICommand
    {
        public AuthCommand(IAuth auth, DostupViewModel viewModel)
        {
            _auth = auth;
            _viewModel = viewModel;
        }

        private readonly IAuth _auth;
        private readonly DostupViewModel _viewModel;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            var passwordBox = parameter as PasswordBox;
            var password = passwordBox.Password;

            await _auth.Authorization(_viewModel.Login, password);
        }
    }
}