using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitorex2
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
