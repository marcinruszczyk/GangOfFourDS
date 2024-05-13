using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter1
{
    class Client
    {
        public void MakeRequest(ITarget target)
        {
            target.Request();
        }
    }
}
