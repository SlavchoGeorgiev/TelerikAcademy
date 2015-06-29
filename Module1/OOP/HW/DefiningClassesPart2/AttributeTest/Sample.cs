namespace AttributeTest
{
    using System;
    using MyClasses;

    [Version(5, 1)]
    class Sample
    {
        static void Main()
        {
            var sampleType = typeof(Sample);
            Console.WriteLine(sampleType.GetCustomAttributes(false)[0]);
        }
    }
}
