using BattleCards.Services;
using SUS.HTTP;
using SUS.MvcFramework;

namespace BattleCards.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService userService;

        public UsersController(IUsersService userService)
        {
            this.userService = userService;
        }

        public HttpResponse Login()
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            return this.View();
        }

        [HttpPost("/Users/Login")]
        public HttpResponse Login(string username, string password)
        {
            var userId = this.userService.GetUserId(username, password);

            if (userId == null)
            {
                return this.Error("Invalid username or password.");
            }

            this.SignIn(userId);
            return this.Redirect("/Cards/All");
        }

        public HttpResponse Register()
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            return this.View();
        }

        [HttpPost("/Users/Register")]
        public HttpResponse Register(string username, string email, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 5 || username.Length > 20)
            {
                return this.Error("Invalid username.");
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6 || password.Length > 20)
            {
                return this.Error("Invalid password.");
            }

            if (!this.userService.IsEmailAvailable(email))
            {
                return this.Error("Taken email.");
            }

            if (!this.userService.IsUsernameAvailable(username))
            {
                return this.Error("Taken username.");
            }

            this.userService.CreateUser(username, email, password);
            return this.Redirect("/Users/Login");
        }

        public HttpResponse Logout()
        {
            if (this.IsUserSignedIn())
            {
                return this.Redirect("/");
            }

            this.SignOut();
            return this.Redirect("/");
        }
    }
}
