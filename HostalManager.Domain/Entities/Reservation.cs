using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalManager.Domain.Exceptions;

namespace HostalManager.Domain.Entities
{
    public class Reservation : AuditoryEntity
    {
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int NumberOfAdults { get; private set; }
        public int NumberOfChildren { get; private set; }
        public decimal TotalAmount { get; private set; }    
        public Guid RoomId { get; private set; }
        public Room Room { get; private set; }
        public Guid GuestId { get; private set; }
        public Guest Guest { get; private set; }
        public Guid HostelId { get; private set; }
        public Hostel Hostel { get; private set; }
        public ICollection<Payment> Payments { get; private set; } = new List<Payment>();
        private Reservation() { } // Private constructor for EF Core
        public Reservation(DateTime startDate, DateTime endDate, int numberOfAdults, int numberOfChildren, decimal totalAmount, Guid roomId, Guid guestId, Guid hostelId)
        {
            if (startDate >= endDate)
            {
                throw new ReservationException ("Start date must be before end date.");
            }
            if (numberOfAdults <=0)
            {
                throw new ReservationException ("A reservation must have at least one adult..");
            }
            if (numberOfChildren < 0)
            {
                throw new ReservationException("Number of children cannot be negative.");
            }
            if (totalAmount <=0)
            {
                throw new ReservationException("Total amount cannot be zero.");
            }
            if (roomId == Guid.Empty)
            {
                throw new ReservationException("Room ID cannot be empty.");
            }
            if (guestId == Guid.Empty)
            {
                throw new ReservationException("Guest ID cannot be empty.");
            }
            if (hostelId == Guid.Empty)
            {
                throw new ReservationException("Hostel ID cannot be empty.");
            }
            StartDate = startDate;
            EndDate = endDate;
            NumberOfAdults = numberOfAdults;
            NumberOfChildren = numberOfChildren;
            TotalAmount = totalAmount;
            RoomId = roomId;
            GuestId = guestId;
            HostelId = hostelId;
        }

    }
}
