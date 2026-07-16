using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalManager.Domain.Exceptions
{
    public class UserExectiion : DomainExceptions
    {
        public UserExectiion(string message) : base(message)
        {
        }
        public UserExectiion(string message, string v) 
            : base(message)
        {
        }
    {
    }
}
