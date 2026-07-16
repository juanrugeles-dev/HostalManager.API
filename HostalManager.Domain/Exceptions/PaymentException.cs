using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalManager.Domain.Exceptions
{
    public class PaymentException :DomainExceptions
    {
        public PaymentException(string message) : base(message)
        {
        }
        public PaymentException(string message, string v) 
            : base(message)
        {
        }
    }
}
