using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    class Circle : Shape
    {
        private float radius;

        public Circle(float radius, IRender render) : base(render)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            render.RenderCircle(radius);
        }



    }
}
