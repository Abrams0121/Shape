using System;


namespace Shape
{

    public class Triangle : Shape
    {
        public override double Area { get; set; }

        private double firstSide {  get; set; }
        private double secondSide { get; set; }
        private double thirdSide { get; set; }

        public Triangle(double first_Side, double second_Side, double third_Side)
        {
            this.firstSide = first_Side;
            this.secondSide = second_Side;
            this.thirdSide = third_Side;
            this.Area = CalculateArea();
            shapeName = IsRectangular();
        }


        public override double CalculateArea()
        {
            try
            {
                double Sp = (firstSide + secondSide + thirdSide) / 2;

                return Math.Sqrt(Sp * (Sp - firstSide) * (Sp - secondSide) * (Sp - thirdSide));
            }
            catch (Exception)
            {

                return -1;
            }
                
        }

        string IsRectangular()
        {
            try
            {
                if ((firstSide * firstSide) == ((secondSide * secondSide) + (thirdSide * thirdSide)))
                    return "Прямоугольный треугольник";
                if ((secondSide * secondSide) == ((firstSide * firstSide) + (thirdSide * thirdSide)))
                    return "Прямоугольный треугольник";
                if ((thirdSide * thirdSide) == ((firstSide * firstSide) + (secondSide * secondSide)))
                    return "Прямоугольный треугольник";
                return "Треугольник";
            }
            catch (Exception)
            {
                return "Треугольник";
            }

               

        }


    }
}

