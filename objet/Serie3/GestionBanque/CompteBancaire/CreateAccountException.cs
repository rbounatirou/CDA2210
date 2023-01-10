using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCompte
{
    public class CreateAccountException : Exception
    {
        public CreateAccountException(string? message) : base(message) { }
    }
}
