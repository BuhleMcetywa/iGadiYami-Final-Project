using CommunityToolkit.Mvvm.Input;
using IGadiYami.Interface;
using IGadiYami.Models;
using IGadiYami.Services;
using IGadiYami.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.ViewModels
{
    public partial class SignUpPageViewModel : BaseViewModel
    {
        private IService _service;
        private UserDatabase _userDatabase;

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        
        private bool isNameValid;

        public bool IsNameValid
        {
            get { return isNameValid; }
            set
            {
                isNameValid = value;
                OnPropertyChanged();
            }

        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        private bool isSurnameValid;
        public bool IsSurnameValid
        {
            get { return isSurnameValid; }
            set
            {
                isSurnameValid = value;
                OnPropertyChanged();
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private bool isEmailValid;
        public bool IsEmailValid
        {
            get { return isEmailValid; }
            set
            {
                isEmailValid = value;
                OnPropertyChanged();
            }
        }

        private string _confirmPassword;

        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                _confirmPassword = value;
                OnPropertyChanged();
            }
        }

        private bool isConfirmPasswordValid;
        public bool IsConfirmPasswordValid
        {
            get { return isConfirmPasswordValid; }
            set
            {
                isConfirmPasswordValid = value;
                OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        private bool isPasswordValid;
        public bool IsPasswordValid
        {
            get { return isPasswordValid; }
            set
            {
                isPasswordValid = value;
                OnPropertyChanged();
            }
        }

        // Entry Component Properties
        private string _username;
        public string UserNameEntry
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged(); }
        }
        private string _usersurname;
        public string UserSurnameEntry
        {
            get { return _usersurname; }
            set { _usersurname = value; OnPropertyChanged(); }
        }
        private string _useremail;
        public string UserEmailEntry
        {
            get { return _useremail; }
            set { _useremail = value; OnPropertyChanged(); }
        }
        // private string _userphonenumber;
        /* public string UserPhoneNumber
        {
            get { return _userphonenumber; }
            set { _userphonenumber = value; }
        } */
        private string _userpassword;
        public string UserPasswordEntry
        {
            get { return _userpassword; }
            set { _userpassword = value; OnPropertyChanged(); }
        }



        public SignUpPageViewModel(IService Service, UserDatabase userDatabase)
        {
            _service = Service;
            _userDatabase = userDatabase;
        }
       /*public SignUpPageViewModel()
        {
           // _service = Service;
           _userDatabase = new UserDatabase();
        }*/
        

        [RelayCommand]
        public void Save()
        {
            if (IsConfirmPasswordValid && IsEmailValid && IsNameValid && IsPasswordValid && IsSurnameValid)
            {
                var signup = new UserDetails()
                {
                    Name = this.Name,
                    Surname = this.Surname,
                    Email = this.Email,
                    Password = this.Password,
                    ConfirmPassword = this.ConfirmPassword
                };
                _service.Save(signup);
            }
        }

        [RelayCommand]
        public async void CreateUserAsync()
        {
            // Add User to database
            string name = UserNameEntry;
            string surname = UserSurnameEntry;
            string email = UserEmailEntry;
            string password = UserPasswordEntry;
            _userDatabase.CreateUser(name, surname, email, password);
            UserNameEntry = "";
            UserSurnameEntry = "";
            UserEmailEntry = "";
            UserPasswordEntry = "";
            // await App.Current.MainPage.Navigation.PushAsync(new StartGardeningPage(new StartGardeningPageViewModel()));
            await Shell.Current.GoToAsync("startgardening");
        }

        [RelayCommand]
        public async Task CreateAccountAsync()
        {
            await Shell.Current.GoToAsync("createaccount");
        }

        [RelayCommand]
        public void LoadUser()
        {
            // Loading user based on id
            UserData user = _userDatabase.GetUserById(2);
            if (user != null)
            {              
                UserNameEntry = user.UserName;
                UserSurnameEntry = user.UserSurname;
                UserEmailEntry = user.UserEmail;
                UserPasswordEntry = user.UserPassword;
            }
        }

        [RelayCommand]
        public async void HaveAccount()
        {
            // Navigation
            await Shell.Current.GoToAsync("loginpage");
        }
    }
}
