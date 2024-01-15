namespace Muhasebe.Parametreler;

public interface IFirmaParametreAppService : Services.ICrudAppService<SelectFirmaParametreDto,
    SelectFirmaParametreDto, FirmaParametreListParameterDto, CreateFirmaParametreDto,
    UpdateFirmaParametreDto>
{
    Task<bool> UserAnyAsync(Guid userId);
}