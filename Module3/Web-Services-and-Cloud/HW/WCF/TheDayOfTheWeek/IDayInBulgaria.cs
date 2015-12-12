namespace TheDayOfTheWeek
{
    using System;
    using System.ServiceModel;
    
    [ServiceContract]
    public interface IDayInBulgaria
    {
        [OperationContract]
        string DayOfWeek(DateTime date);
    }
}
