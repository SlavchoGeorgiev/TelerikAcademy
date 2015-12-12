namespace Teleimot.Web.Wcf.Users
{
    using Teleimot.Web.Wcf.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    
    public class Top : BaseService, ITop
    {
        public IEnumerable<ListedUserModel> GetAll(string page = "0")
        {
            return this.Users
                .All()
                .OrderByDescending(u => u.Rating)
                .Take(10)
                .Select(u => new ListedUserModel
                {
                    UserName = u.UserName,
                    Rating = u.Rating
                })
                .ToList();
        }
    }
}
