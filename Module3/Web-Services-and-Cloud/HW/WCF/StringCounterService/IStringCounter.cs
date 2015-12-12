namespace StringCounterService
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IStringCounter
    {

        [OperationContract]
        int GetCount(string search, string text);
        
    }
}
