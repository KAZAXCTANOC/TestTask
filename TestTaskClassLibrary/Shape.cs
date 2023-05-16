using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskClassLibrary
{
    public abstract class Shape
    {
        protected abstract bool Validate(params double[] data);
        public abstract double GetArea();
    }
}
