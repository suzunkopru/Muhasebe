using AutoMapper;
using Muhasebe.Bankalar;
namespace Muhasebe;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {

        CreateMap<Banka, SelectBankaDto>().
            ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad)).
            ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad)).
            ReverseMap();
        CreateMap<Banka, ListBankaDto>().
            ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad)).
            ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad)).
            ReverseMap();
        CreateMap<Banka, CreateBankaDto>().ReverseMap();
        CreateMap<Banka, UpdateBankaDto>().ReverseMap();
    }
}
