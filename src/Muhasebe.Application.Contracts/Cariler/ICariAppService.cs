namespace Muhasebe.Cariler;

public interface ICariAppService : Services.ICrudAppService<SelectCariDto, ListCariDto,
    CariListParameterDto, CreateCariDto, UpdateCariDto, CodeParameterDto>
{
}