using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFactoryMethod
{
    public abstract class Operation
    {
        private double _NumA;
        private double _NumB;
        public double NumA
        {
            get { return _NumA; }
            set { _NumA = value; }
        }
        
        public double NumB
        {
            get { return _NumB; }
            set { _NumB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
