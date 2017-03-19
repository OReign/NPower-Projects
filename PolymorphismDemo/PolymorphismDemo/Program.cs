using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Performing a class drawing tasks");
        }
    }
}
