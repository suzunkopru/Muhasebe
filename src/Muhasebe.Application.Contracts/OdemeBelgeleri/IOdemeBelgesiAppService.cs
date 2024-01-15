using Muhasebe.MakbuzHareketler;
using Muhasebe.Makbuzlar;

namespace Muhasebe.OdemeBelgeleri;
public interface IOdemeBelgesiAppService : Services.ICrudAppService<SelectMakbuzHareketDto, ListOdemeBelgesiDto,
    OdemeBelgesiListParameterDto, MakbuzHareketDto, MakbuzHareketDto, MakbuzNoParameterDto>
{
}