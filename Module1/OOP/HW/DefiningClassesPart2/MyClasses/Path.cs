namespace MyClasses
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> points = new List<Point3D>();

        public List<Point3D> Points 
        { 
            get
            {
                return this.points;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.Points.Add(point);
        }
    }
}
