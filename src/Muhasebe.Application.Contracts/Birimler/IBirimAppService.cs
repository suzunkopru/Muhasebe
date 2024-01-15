namespace Muhasebe.Birimler;
public interface IBirimAppService : Services.ICrudAppService<SelectBirimDto, ListBirimDto,
    BirimListParameterDto, CreateBirimDto, UpdateBirimDto, CodeParameterDto>
{
}