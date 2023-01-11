using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421Classes.Exceptions
{
    public class CreateDeException : Exception
    {
        public CreateDeException(string? message) : base(message) { }
    }
}
