using Muhasebe.Stoklar;

namespace AbcYazilim.OnMuhasebe.Stoklar;

public interface IStokAppService : ICrudAppService<SelectStokDto, ListStokDto,
    StokListParameterDto, CreateStokDto, UpdateStokDto, CodeParameterDto>
{
}