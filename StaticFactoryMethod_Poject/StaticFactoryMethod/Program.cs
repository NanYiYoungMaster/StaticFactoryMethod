using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            double num_a = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入计算的方式：(+ - * /)");
            string operate = Console.ReadLine();
            Operation oper = OperationFactory.createOperate(operate);
            Console.WriteLine("请输入第二个数：");
            double num_b = double.Parse(Console.ReadLine());
            oper.NumA = num_a;
            oper.NumB = num_b;
            Console.WriteLine("计算结果为：{0}",oper.GetResult());
            Console.ReadLine();
        }
    }
}
