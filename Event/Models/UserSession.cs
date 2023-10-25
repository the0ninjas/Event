using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public static class UserSession
    {
        public static User AuthenticatedUser { get; private set; }

        public static void AuthenticateUser(User user)
        {
            AuthenticatedUser = user;
        }
    }
}
