namespace Muhasebe.Masraflar;

public interface IMasrafAppService : Services.ICrudAppService<SelectMasrafDto, ListMasrafDto,
    MasrafListParameterDto, CreateMasrafDto, UpdateMasrafDto, CodeParameterDto>
{
}