using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalManager.Domain.Exceptions
{
    public class GuestException : DomainExceptions
            {
        public GuestException(string message) : base(message)
        {
        }
        public GuestException(string message, string v) 
            : base(message)
        {
        }
    {
    }
}
