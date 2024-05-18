using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    abstract class Shape
    {
        protected IRender render;

        protected Shape(IRender render)
        {
            this.render = render;   
        }

        public abstract void Draw();
    }


}
