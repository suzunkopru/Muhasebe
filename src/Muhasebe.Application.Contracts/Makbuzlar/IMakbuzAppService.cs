namespace Muhasebe.Makbuzlar;

public interface IMakbuzAppService : Services.ICrudAppService<SelectMakbuzDto, ListMakbuzDto,
    MakbuzListParameterDto, CreateMakbuzDto, UpdateMakbuzDto, MakbuzNoParameterDto>
{
}