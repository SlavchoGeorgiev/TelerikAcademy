namespace Teleimot.Services.Data
{
    using System.Linq;
    using Contracts;
    using Teleimot.Data.Models;
    using Teleimot.Data.Repositories;

    public class RealEstatesServices : IRealEstatesServices
    {
        private IRepository<RealEstate> realEstateRepository;

        public RealEstatesServices(IRepository<RealEstate> realEstateRepository)
        {
            this.realEstateRepository = realEstateRepository;
        }

        public IQueryable<RealEstate> GetById(int id)
        {
            return this.realEstateRepository
                .All()
                .Where(re => re.Id == id);
        }

        public IQueryable<RealEstate> GetList(int skip = 0, int take = 10)
        {
            return this.realEstateRepository
                .All()
                .OrderByDescending(re => re.CreatedOn)
                .Skip(skip)
                .Take(take);
        }

        public int Create(
            string title,
            string description,
            string address,
            string contact,
            int constructionYear,
            int? sellingPrice,
            int? rentingPrice,
            RealEstateType type,
            string userId)
        {
            RealEstate realEstate = new RealEstate()
            {
                Title = title,
                Description = description,
                Address = address,
                Contact = contact,
                ConstructionYear = constructionYear,
                SellingPrice = sellingPrice,
                RentingPrice = rentingPrice,
                RealEstateType = type,
                CanBeSold = sellingPrice == null ? false : true,
                CanBeRented = rentingPrice == null ? false : true,
                UserId = userId
            };

            this.realEstateRepository.Add(realEstate);
            this.realEstateRepository.SaveChanges();

            return realEstate.Id;
        }
    }
}
