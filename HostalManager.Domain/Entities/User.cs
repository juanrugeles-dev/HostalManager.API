using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalManager.Domain.Exceptions;

namespace HostalManager.Domain.Entities
{
    public class User : AuditoryEntity
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public Guid HostelId { get; set; }
        public Hostel Hostel { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        private User() { } // Private constructor for EF Core
        public User(string firstName, string lastName, string email, string password, Guid hostelId, Guid roleId)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new UserExectiion("First name cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new UserExectiion("Last name cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new UserExectiion("Email cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new UserExectiion("Password cannot be empty.");
            }
            if (hostelId == Guid.Empty)
            {
                throw new UserExectiion("Hostel ID cannot be empty.");
            }

            if (roleId == Guid.Empty)
            {
                throw new UserExectiion("Role ID cannot be empty.");
            }
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            HostelId = hostelId;
            RoleId = roleId;
        }
    }
}
