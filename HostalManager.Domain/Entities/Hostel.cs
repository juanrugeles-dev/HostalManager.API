using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalManager.Domain.Exceptions;

namespace HostalManager.Domain.Entities
{
    public class Hostel : AuditoryEntity
    {
        public string Number { get; private set; }
        public ICollection<User> Users { get; private set; } = new List<User>();
        public ICollection<Room> Rooms { get; private set; } = new List<Room>();
        public ICollection<Reservation> Reservations { get; private set; } = new List<Reservation>();
    private Hostel() { } // Private constructor for EF Core
        public Hostel(string number)
        {
            if (string.IsNullOrWhiteSpace(Number))
            {
                throw new HostelException("Hostel number cannot be empty.");
            }

            Number = number;
        }
    }
}
