using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shape
{
    public abstract  class Shape
    {
        public string shapeName;

        public abstract double Area { get; set; }

        public abstract double CalculateArea();
    }
}
