using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FaizullinDR.Sprint1.TaskReview.V19.Lib
{
    public class DataService : ISprint1Task7V19
    {
        public double Calculate(double x)
        {
            double z = x - ((7 * x * x) / (Math.Pow(x, 3))) + Math.Sin(x) + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5));
            z = Math.Round(z, 3);
            return z;
        }
    }
}
