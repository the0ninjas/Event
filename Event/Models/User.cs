using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string location { get; set; }


        public User(string firstName, string lastName, string password, string email, string phoneNumber, string location)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.location = location;
        }
    }
}

