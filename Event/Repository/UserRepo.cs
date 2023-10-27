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
                    User newUser = user;

                    context.Users.Add(newUser);
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

        public User getUserByEmail(string email)
        {
            try
            {
                User user = Users.Find(u => u.email == email);
                return user;
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

                    User existingUser = Users.Find(u => u.email == updatedUser.email);

                    if (existingUser != null)
                    {
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
                    User userToDelete = Users.Find(u => u.email == email);

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
