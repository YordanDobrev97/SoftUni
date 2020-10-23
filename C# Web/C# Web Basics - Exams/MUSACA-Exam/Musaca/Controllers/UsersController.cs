using Musaca.Services;
using Musaca.ViewModels.Users;
using SUS.HTTP;
using SUS.MvcFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Musaca.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public HttpResponse Login()
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/Products/All");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Login(string username, string password)
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/Products/All");
            }

            var userId = this.usersService.GetUserId(username, password);

            if (userId == null)
            {
                return this.Error("Invalid username or password.");
            }

            this.SignIn(userId);
            return this.Redirect("/Products/All");
        }

        public HttpResponse Register()
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/Products/All");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Register(RegisterInputViewModel input)
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/Products/All");
            }

            if (string.IsNullOrEmpty(input.Username) 
                || input.Username.Length < 3 
                || input.Username.Length > 20)
            {
                return this.Error("Invalid username.");
            }

            if (string.IsNullOrEmpty(input.Password)
                || input.Password.Length < 6 
                || input.Password.Length > 20)
            {
                return this.Error("Invalid password.");
            }

            if (!this.usersService.IsUsernameAvailable(input.Username))
            {
                return this.Error("Taken username.");
            }

            if (!Regex.IsMatch(input.Username, @"^[a-zA-Z0-9\.]+$"))
            {
                return this.Error("Invalid username. Only alphanumeric characters are allowed.");
            }

            if (string.IsNullOrWhiteSpace(input.Email) || !new EmailAddressAttribute().IsValid(input.Email))
            {
                return this.Error("Invalid email.");
            }

            if (!this.usersService.IsEmailAvailable(input.Email))
            {
                return this.Error("Taken email.");
            }

            if (input.ConfirmPassword != input.Password)
            {
                return this.Error("Passwords not same.");
            }

            this.usersService.CreateUser(input.Username, input.Email, input.Password);

            return this.Redirect("/Users/Login");
        }

        public HttpResponse Logout()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            this.SignOut();
            return this.Redirect("/");
        }
    }
}
