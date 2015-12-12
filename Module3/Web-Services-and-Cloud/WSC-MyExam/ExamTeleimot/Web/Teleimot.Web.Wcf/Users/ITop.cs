namespace Teleimot.Web.Wcf.Users
{
    using Teleimot.Web.Wcf.Models;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    [ServiceContract]
    public interface ITop
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "?page={page}", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ListedUserModel> GetAll(string page = "0");
    }
}
