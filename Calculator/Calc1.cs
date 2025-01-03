using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator
    {
        Int32 Sum(Int32 x, Int32 y);
    }
    public class Calc1 : ICalculator
    {
        Int32 x, y;
        public Calc1()
        {
        }
        public Calc1(Int32 x, Int32 y)
        {
            this.x = x;
            this.y = y;
        }
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
