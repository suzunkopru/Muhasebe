namespace Muhasebe.Depolar;

public interface IDepoAppService : Services.ICrudAppService<SelectDepoDto, ListDepoDto,
    DepoListParameterDto, CreateDepoDto, UpdateDepoDto, DepoCodeParameterDto>
{
}