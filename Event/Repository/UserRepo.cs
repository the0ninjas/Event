using EventManagementSystem.Models;
using EventManagementSystem.Utilities;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventManagementSystem.Repository
{
    public class UserRepo
    {

        private List<User> Users = new List<User>();


        public bool createUser(User user)
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                return true;
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        // Function to check if user exists
        public bool userExists(string email, ConnectionFactory context) 
        {
            if (context == null)
            {
                return false;
            }

            User user = context.Users.FirstOrDefault(u => u.email == email);
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User getUserByEmail(string email)
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    User user = Users.FirstOrDefault(u => u.email == email);
                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        public User updateUser(User updatedUser)
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    // Get user details from database
                    User existingUser = Users.FirstOrDefault(u => u.email == updatedUser.email);

                    if (existingUser != null)
                    {
                        // assign updated values to properties of user
                        existingUser.firstName = updatedUser.firstName;
                        existingUser.lastName = updatedUser.lastName;
                        existingUser.phoneNumber = updatedUser.phoneNumber;
                        existingUser.location = updatedUser.location;

                        context.SaveChanges();
                        return existingUser;
                    }
                    else
                    {
                        return null;
                    }
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null; 
            }
        }

        public bool deleteUser(string email) 
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    User userToDelete = Users.FirstOrDefault(u => u.email == email);

                    if (userToDelete != null)
                    {
                        context.Users.Remove(userToDelete);
                        context.SaveChanges();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}
