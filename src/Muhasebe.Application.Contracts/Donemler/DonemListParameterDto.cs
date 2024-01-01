using Muhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace Muhasebe.Donemler;

public class DonemListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public bool Durum { get; set; }
}