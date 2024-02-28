using AutoMapper;
using Muhasebe.Bankalar;
namespace Muhasebe;
public class MuhasebeApplicationAutoMapperProfile : Profile
{
    public MuhasebeApplicationAutoMapperProfile()
    {
        CreateMap<Banka, SelectBankaDto>().
            ForMember(SelectBanka => SelectBanka.OzelKod1Adi,
            BankaSelectBanka => BankaSelectBanka.
            MapFrom(Banka => Banka.OzelKod1.Ad)).
            ForMember(SelectBanka => SelectBanka.OzelKod2Adi,
            BankaSelectBanka => BankaSelectBanka.
            MapFrom(Banka => Banka.OzelKod2.Ad)).ReverseMap();
        CreateMap<Banka, ListBankaDto>().
            ForMember(ListBanka => ListBanka.OzelKod1Adi,
            BankaListBanka => BankaListBanka.
            MapFrom(Banka => Banka.OzelKod1.Ad)).
            ForMember(ListBanka => ListBanka.OzelKod2Adi,
            BankaistBanka => BankaistBanka.
            MapFrom(Banka => Banka.OzelKod2.Ad)).ReverseMap();
        CreateMap<Banka, CreateBankaDto>().ReverseMap();
        CreateMap<Banka, UpdateBankaDto>().ReverseMap();
    }
}
