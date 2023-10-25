using EventManagementSystem.Models;
using EventManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventManagementSystem.Repository
{
    public class UserRepo
    {

        private List<User> users = new List<User>();

        public static void AddUser(User user)
        {
            //try
            //{

            //    using (var context = new ConnectionFactory())
            //    {
            //        context.Users.Add(user);
            //        context.SaveChanges();
            //    }
            //}

            //catch (Exception ex)
            //{
            //    // Display an error message to prompt for correct input
            //    MessageBox.Show($"Sign-up failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public User GetUserById(int userId)
        {
            return null;
        }

        public void UpdateUser(User user)
        {

        }

        public void DeleteUser(int userId) 
        {
        
        }
         
        
        
        
    }
}
