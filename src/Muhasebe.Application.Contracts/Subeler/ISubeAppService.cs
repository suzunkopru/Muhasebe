using Muhasebe.Subeler;

namespace AbcYazilim.OnMuhasebe.Subeler;

public interface ISubeAppService : ICrudAppService<SelectSubeDto, ListSubeDto,
    SubeListParameterDto, CreateSubeDto, UpdateSubeDto, CodeParameterDto>
{
}