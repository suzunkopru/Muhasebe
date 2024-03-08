using AutoMapper;
using Muhasebe.Bankalar;
using Muhasebe.BankaSubeler;
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

        CreateMap<BankaSube, SelectBankaSubeDto>()
                .ForMember(x => x.BankaAdi, y => y.MapFrom(z => z.Banka.Ad))
                .ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad))
                .ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad))
                .ReverseMap();

        CreateMap<BankaSube, ListBankaSubeDto>()
            .ForMember(x => x.BankaAdi, y => y.MapFrom(z => z.Banka.Ad))
            .ForMember(x => x.OzelKod1Adi, y => y.MapFrom(z => z.OzelKod1.Ad))
            .ForMember(x => x.OzelKod2Adi, y => y.MapFrom(z => z.OzelKod2.Ad))
            .ReverseMap();

        CreateMap<CreateBankaSubeDto, BankaSube>().ReverseMap();
        CreateMap<UpdateBankaSubeDto, BankaSube>().ReverseMap();
        CreateMap<SelectBankaSubeDto, CreateBankaSubeDto>().ReverseMap();
        CreateMap<SelectBankaSubeDto, UpdateBankaSubeDto>().ReverseMap();
    }

}
