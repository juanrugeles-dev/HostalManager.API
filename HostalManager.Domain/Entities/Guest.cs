using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalManager.Domain.Enums;
using HostalManager.Domain.Exceptions;

namespace HostalManager.Domain.Entities
{
    public class Guest : AuditoryEntity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string DocumentNumber { get; private set; }
        public DocumentType DocumentType { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public  GenderEnum Gender { get; private set; }
        public ICollection<Reservation> Reservations { get; private set; } = new List<Reservation>();
        private Guest() { } // Private constructor for EF Core
        public Guest(string firstName, string lastName, string documentNumber, DocumentType documentType, string email, string phonenumber)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new GuestException("First name cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new GuestException("Last name cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(documentNumber))
            {
                throw new GuestException("Document number cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new GuestException("Email cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(phonenumber))
            {
                throw new GuestException("Phone number cannot be empty.");
            }
            FirstName = firstName;
            LastName = lastName;
            DocumentNumber = documentNumber;
            DocumentType = documentType;
            Email = email;
            PhoneNumber = phonenumber;
        }

    }
}
