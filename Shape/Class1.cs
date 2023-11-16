using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shape
{
    public abstract class Shape
    {
        public virtual string shape_name => "";

        public abstract double Area { get; set; }

        public virtual double GetArea()
        {
            return 0;
        }

        public class Triangle : Shape
        {
            public override string shape_name => "Треугольник";

            public override double Area { get; set; }

            double first_Side {  get; set; }
            double second_Side { get; set; }
            double third_Side { get; set; }

            public Triangle(double first_Side, double second_Side, double third_Side)
            {
                this.first_Side = first_Side;
                this.second_Side = second_Side;
                this.third_Side = third_Side;
                this.Area = GetArea();
            }

            public override double GetArea()
            {
                if (IsRectangular())
                    return CalculateRectTriangleArea();

                return CalculateTriangleArea();
            }

            double CalculateRectTriangleArea()
            {
                double Side1 = 1;
                double Side2 = 1;

                try
                {
                    if ((first_Side > second_Side) && (first_Side > third_Side))
                    {
                        Side1 = second_Side;
                        Side2 = third_Side;
                    }
                    else if ((second_Side > first_Side) && (second_Side > third_Side))
                    {
                        Side1 = first_Side;
                        Side2 = third_Side;
                    }
                    else if ((third_Side > first_Side) && (third_Side > second_Side))
                    {
                        Side1 = second_Side;
                        Side2 = first_Side;
                    }

                    return (Side1 * Side2) / 2;
                }
                catch (Exception)
                {

                    return -1;
                }

              
            }

            double CalculateTriangleArea()
            {
                try
                {
                    double Sp = (first_Side + second_Side + third_Side) / 2;

                    return Math.Sqrt(Sp * (Sp - first_Side) * (Sp - second_Side) * (Sp - third_Side));
                }
                catch (Exception)
                {

                    return -1;
                }
                
            }

            bool IsRectangular()
            {
                try
                {
                    if ((first_Side * 2) == ((second_Side * 2) + (third_Side * 2)))
                        return true;
                    if ((second_Side * 2) == ((first_Side * 2) + (third_Side * 2)))
                        return true;
                    if ((third_Side * 2) == ((first_Side * 2) + (second_Side * 2)))
                        return true;
                    return false;
                }
                catch (Exception)
                {

                    return false;
                }

               

            }


        }

        public class Circle : Shape
        {
            public override string shape_name => "Круг";

            public override double Area { get; set; }
            double Radius { get; set; }

            public Circle(double Radius) 
            {
                this.Radius = Radius;
                this.Area = GetArea();
            }

            public override double GetArea()
            {
                try
                {
                    return Math.PI * Math.Pow(this.Radius, 2);
                }
                catch (Exception)
                {

                    return -1;
                }
               
            }
        }
    }
}
