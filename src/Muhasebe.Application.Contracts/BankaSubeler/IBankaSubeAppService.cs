namespace Muhasebe.BankaSubeler;

public interface IBankaSubeAppService : Services.ICrudAppService<SelectBankaSubeDto, ListBankaSubeDto,
    BankaSubeListParameterDto, CreateBankaSubeDto, 
    UpdateBankaSubeDto, BankaSubeCodeParameterDto>
{
}