using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MelehovAG.Sprint0.Task0.V0.Lib
{
    public class DataService : ISprint6Task0V0
    {
        public double Calculate(int x)
        {
            double res = x;
            return Math.Round(res, 3);
        }
    }
}
