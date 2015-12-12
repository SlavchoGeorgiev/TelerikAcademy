namespace Teleimot.Web.Api.Models.Users
{
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mappings;

    public class UserDetailsResponseModel: IMapFrom<User>, IHaveCustomMappings
    {
        public string UserName { get; set; }

        public int RealEstates { get; set; }

        public int Comments { get; set; }

        public decimal Rating { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<User, UserDetailsResponseModel>()
                .ForMember(u => u.RealEstates, opts => opts.MapFrom(u => u.RealEstates.Count))
                .ForMember(u => u.Comments, opts => opts.MapFrom(u => u.Comments.Count));
        }
    }
}
