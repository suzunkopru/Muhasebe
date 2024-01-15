namespace Muhasebe.Faturalar;
public interface IFaturaAppService : Services.ICrudAppService<SelectFaturaDto, ListFaturaDto,
    FaturaListParameterDto, CreateFaturaDto, UpdateFaturaDto, FaturaNoParameterDto>
{
}