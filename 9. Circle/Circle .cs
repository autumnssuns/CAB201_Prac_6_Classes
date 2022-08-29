using System;

namespace Circle
{
    /// <summary>
    /// A class for a circle. 
    /// </summary>
    class Circle
    {


        /// <summary>
        /// The circus's radius.
        /// </summary>
        private double radius;

        /// <summary>
        /// The circle’s area.
        /// </summary>
        private double area;

        /// <summary>
        /// The circle's diameter.
        /// </summary>
        private double diameter;

        /// <summary>
        /// The circle's radius.
        /// </summary>
        public double Radius
        {

            get
            {
                return radius;
            }
            set
            {
                radius = value;
                area = Math.PI * radius * radius;
                diameter = 2 * Math.PI * radius;
            }
        }

        /// <summary>
        /// The circle’s area.
        /// </summary>
        public double Area
        {
            get
            {
                return area;
            }
        }

        /// <summary>
        /// The circle's diameter.
        /// </summary>
        public double Diameter
        {
            get
            {
                return diameter;
            }
        }

        /// <summary>
        /// Constructs the circle model.
        /// </summary>
        /// <param name="myRadius">The circle's radius.</param>
        public Circle(double myRadius)
        {
            radius = myRadius;
            area = Math.PI * radius * radius;
            diameter = 2 * Math.PI * radius;
        }
    }
}