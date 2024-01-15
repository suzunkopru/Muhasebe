namespace Muhasebe.Donemler;
public interface IDonemAppService : Services.ICrudAppService<SelectDonemDto, ListDonemDto,
    DonemListParameterDto, CreateDonemDto, UpdateDonemDto, CodeParameterDto>
{
}