using System;


namespace Shape
{

    public class Circle : Shape
    {


        public override double Area { get; set; }
        private double Radius { get; set; }

        public Circle(double Radius) 
        {
            shapeName = "Круг";
            this.Radius = Radius;
            this.Area = CalculateArea();
        }

        public override double CalculateArea()
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

