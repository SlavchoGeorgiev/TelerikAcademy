namespace MyClasses
{
    using System;

    public static class Calc3DSpace
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) +
                             (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) +
                             (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));
        }
    }
}
