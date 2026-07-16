using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalManager.Domain.Exceptions
{
    public class RoomException : DomainExceptions
    {
        public RoomException(string message) : base(message)
        {
        }

        public RoomException(string message, string v) 
            : base(message)
        {
        }
    }
}
