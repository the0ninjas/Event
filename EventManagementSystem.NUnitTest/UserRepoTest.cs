using NUnit.Framework;
using EventManagementSystem.Models;
using EventManagementSystem.Repository;
using System;
using System.Linq;
using EventManagementSystem.Utilities;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem.Repository
{
    [TestFixture]
    public class UserRepoTests
    {
        private DbContextOptions<ConnectionFactory> dbContextOptions;
        private ConnectionFactory context;

        [Test]
        public void CreateUser_ValidUser_ReturnsTrue()
        {
            // Arrange
            UserRepo userRepo = new UserRepo();

            User newUser = new User("John", "Doe", "password", "john@example.com", "1234567890", "Location");

            // Act
            bool result = userRepo.createUser(newUser);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CreateUser_InvalidUser_ReturnsFalse()
        {
            // Arrange
            UserRepo userRepo = new UserRepo();

            // Create a user with missing required fields
            User invalidUser = new User("John", "Doe", "password", null, "1234567890", "Location");

            // Act
            bool result = userRepo.createUser(invalidUser);

            // Assert
            Assert.IsFalse(result);
        }


        [Test]
        public void UserExists_NonExistingUser_ReturnsFalse()
        {
            // Arrange
            UserRepo userRepo = new UserRepo();

            // Act
            bool result = userRepo.userExists("nonexistent@example.com", context);

            // Assert
            Assert.IsFalse(result);
        }

        // Add similar tests for GetUserByEmail, UpdateUser, and DeleteUser
    }
}