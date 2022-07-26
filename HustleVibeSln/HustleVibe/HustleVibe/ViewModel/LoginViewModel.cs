using HustleVibe.Services;
using HustleVibe.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HustleVibe.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private string _Username;
        public string UserName
        {
            set
            {
                this._Username = value;
                OnPropertyChanged();

            }
            get
            {
                return this._Username;
            }
        }


        private string _Password;
        public string Password
        {
            set
            {
                this._Password = value;
                OnPropertyChanged();

            }
            get
            {
                return this._Password;
            }
        }

        private bool _IsBusy;
        public bool IsBusy
        {
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();

            }
            get
            {
                return this._IsBusy;
            }
        }

        private bool _Result;
        public bool Result
        {
            set
            {
                this._Result = value;
                OnPropertyChanged();

            }
            get
            {
                return this._Result;
            }
        }
        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }



        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());


        }

        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.RegisterUser(UserName,Password);
                if (Result)
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "Registered", "OK");
                }
                else
                    await Application.Current.MainPage.DisplayAlert("Error","User already exists","OK");

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally 
            {
                IsBusy=false;
            }
        }

        private async Task LoginCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var UserService= new UserService();
                Result = await UserService.LoginUser(UserName, Password);
                if (Result)
                {
                    Preferences.Set("Username", UserName);
                  //  await Application.Current.MainPage.Navigation.PushModalAsync(new ProductsView());
                }
                else 
                {
                    await Application.Current.MainPage.DisplayAlert("Error","Invalid Username or Password","OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
    
 
}



