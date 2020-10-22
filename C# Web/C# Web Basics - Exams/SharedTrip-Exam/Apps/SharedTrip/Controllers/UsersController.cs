using SharedTrip.Services;
using SharedTrip.ViewModels.Users;
using SUS.HTTP;
using SUS.MvcFramework;

namespace SharedTrip.Controllers
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
                return this.Redirect("/Trips/All");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Login(string username, string password)
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            var userId = this.usersService.GetUserId(username, password);

            if (userId == null)
            {
                return this.Error("Invalid username or password.");
            }

            this.SignIn(userId);
            return this.Redirect("/Trips/All");
        }

        public HttpResponse Register()
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/Trips/All");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Register(InputRegisterViewModel input)
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            if (string.IsNullOrWhiteSpace(input.Username) 
                || input.Username.Length < 5 
                || input.Username.Length > 20)
            {
                return this.Error("Invalid username.");
            }

            if (string.IsNullOrWhiteSpace(input.Password) 
                || input.Password.Length < 6 
                || input.Password.Length > 20)
            {
                return this.Error("Invalid password");
            }

            if (input.Password != input.ConfirmPassword)
            {
                return this.Error("No match passwords.");
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
