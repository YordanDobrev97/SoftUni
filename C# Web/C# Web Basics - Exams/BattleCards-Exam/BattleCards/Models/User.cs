using SUS.MvcFramework;
using System;
using System.Collections.Generic;

namespace BattleCards.Models
{
    public class User : IdentityUser<string>
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
            this.UserCards = new HashSet<UserCard>();
        }

        public ICollection<UserCard> UserCards { get; set; }
    }
}
