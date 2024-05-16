using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public  class FiguraGeometrica
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public virtual double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
