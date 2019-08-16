using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFactoryMethod
{
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = base.GetResult();
            result = NumA + NumB;
            return result;
        }
    }
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = base.GetResult();
            result = NumA - NumB;
            return result;
        }
    }
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = base.GetResult();
            result = NumA * NumB;
            return result;
        }
    }
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
           
            double result = base.GetResult();
            if (NumB == 0)
                throw new Exception("除数不能为0");
            result = NumA / NumB;
            return result;
        }
    }
}
