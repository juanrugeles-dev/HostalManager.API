using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalManager.Domain.Exceptions
{
    public class HostelException : DomainExceptions
    {
        public HostelException(string message) : base(message)
        {
        }
        public HostelException(string message, string v) 
            : base(message)
        {
        }
    }
}
