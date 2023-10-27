using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public static class UserSession
    {
        public static User authenticatedUser;

        //a method to set or authenticate a user.
        public static void AuthenticateUser(User user)
        {
            authenticatedUser = user;
        }

        //a method to clear the user's authentication.
        public static void ClearAuthentication()
        {
            authenticatedUser = null;
        }

        //a method to check if a user is authenticated.
        public static bool IsAuthenticated
        {
            get { return authenticatedUser != null; }
        }

        //a method to get the authenticated user.
        public static User AuthenticatedUser
        {
            get { return authenticatedUser; }
        }
    }
}
