using QRBankPay.Resx;
using QRBankPay.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QRBankPay.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;
        private bool _showMessage;
        private string _welcomeMessage;
        private string _colorTextMessage;
        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool ShowMessage
        {
            get => _showMessage;
            set
            {
                if (_showMessage != value)
                {
                    _showMessage = value;
                    OnPropertyChanged();
                }
            }
        }
        public string WelcomeMessage
        {
            get => _welcomeMessage;
            set
            {
                if (_welcomeMessage != value)
                {
                    _welcomeMessage = value;
                    OnPropertyChanged();
                }
            }
        }
        public string ColorTextMessage
        {
            get => _colorTextMessage;
            set
            {
                if (_colorTextMessage != value)
                {
                    _colorTextMessage = value;
                    OnPropertyChanged();
                }
            }
        }
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            if (ValidateFiels())
            {
                ColorTextMessage = "#7d44d0";
                ShowMessage = true;
                WelcomeMessage = "Welcome";

                await Shell.Current.GoToAsync($"//{nameof(ClientsPage)}");
            }
            else
            {
                ColorTextMessage = "#d55880";
                ShowMessage = true;
                WelcomeMessage = "Invalid User";
                await Application.Current.MainPage.DisplayAlert(AppResources.LoginPageInvalidLoginTitle, AppResources.LoginPageInvalidLoginMessage, AppResources.OkText);
            }
        }

        private bool ValidateFiels()
        {
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
