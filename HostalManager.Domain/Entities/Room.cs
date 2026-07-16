using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalManager.Domain.Enums;
using HostalManager.Domain.Exceptions;

namespace HostalManager.Domain.Entities
{
    public class Room : AuditoryEntity
    {
        public  string Number { get; private set; }
        public  int Capacity { get; private set; }
        public decimal PricePerNigth { get; private set; }
        public RoomStatus Status { get; private set; }
        public Guid HostelId { get; private set; }
        public Hostel Hostel { get; private set; }
        public ICollection<Reservation> Reservations { get; private set; } = new List<Reservation>();
       
        private Room() { } // Private constructor for EF Core
        public Room(string number, int capacity, decimal pricePerNight, RoomStatus status, Guid hostelId)
        {

            if (string.IsNullOrWhiteSpace(number))
            {
                throw new RoomException("Room number cannot be empty.");
            }

            if (capacity <= 0)
            {
                throw new RoomException("Room capacity must be greater than zero.");
            }

            if (pricePerNight <= 0)
            {
                throw new RoomException("Room price per night must be greater than zero.");
            }
            if (hostelId == Guid.Empty)
            {
                throw new RoomException("Hostel ID cannot be empty.");
            }

            Number = number;
            Capacity = capacity;
            PricePerNigth = pricePerNight;
            Status = status;
            HostelId = hostelId;


        }
    }
}
