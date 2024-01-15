namespace Muhasebe.Hizmetler;

public interface IHizmetAppService : Services.ICrudAppService<SelectHizmetDto, ListHizmetDto,
    HizmetListParameterDto, CreateHizmetDto, UpdateHizmetDto, CodeParameterDto>
{
}