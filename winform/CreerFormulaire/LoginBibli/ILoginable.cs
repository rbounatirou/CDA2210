using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginBibli
{
    public interface ILoginable
    {
        public abstract void OnLogin(Login login);
    }
}
