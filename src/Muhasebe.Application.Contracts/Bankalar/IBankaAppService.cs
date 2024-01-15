namespace Muhasebe.Bankalar;
public interface IBankaAppService: Services.ICrudAppService<SelectBankaDto, ListBankaDto
    , BankaListParameterDto, CreateBankaDto, UpdateBankaDto, CodeParameterDto>
{
}
