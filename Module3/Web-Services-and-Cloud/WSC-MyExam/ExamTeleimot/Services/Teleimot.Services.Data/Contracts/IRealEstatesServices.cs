namespace Teleimot.Services.Data.Contracts
{
    using System.Linq;
    using Teleimot.Data.Models;

    public interface IRealEstatesServices
    {
        int Create(
            string title,
            string description,
            string address,
            string contact,
            int constructionYear,
            int? sellingPrice,
            int? rentingPrice,
            RealEstateType type,
            string userId);

        IQueryable<RealEstate> GetById(int id);

        IQueryable<RealEstate> GetList(int skip = 0, int take = 10);
    }
}
