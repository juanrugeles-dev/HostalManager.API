using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalManager.Domain.Exceptions
{
    public class ReservationException : DomainExceptions
    {
        public ReservationException(string message) : base(message)
        {
        }
        public ReservationException(string message, string v) 
            : base(message)
        {
        }
    {
    }
}
