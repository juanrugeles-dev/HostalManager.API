using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalManager.Domain.Enums;
using HostalManager.Domain.Exceptions;

namespace HostalManager.Domain.Entities
{
    public class Payment : AuditoryEntity
    {
        public decimal amount { get; private set; }
        public PaymentType PaymentType { get; private set; }
        public PaymentStatus PaymentStatus { get; private set; }

        public DateTime PaymentDate { get; private set; }

        private Payment() { } // Private constructor for EF Core
        public Payment(decimal amountpara, PaymentType paymentType, PaymentStatus paymentStatus, DateTime paymentDate)
        {
            if (amount <= 0)
            {
                throw new PaymentException("Amount must be greater than zero.", nameof(amount));
            }

            if (paymentDate > DateTime.Now)
            {
                throw new PaymentException("Payment date cannot be in the future.", nameof(paymentDate));
            }
         
            amount = amountpara;
            PaymentType = paymentType;
            PaymentStatus = paymentStatus;
            PaymentDate = paymentDate;
        }

    }
}
