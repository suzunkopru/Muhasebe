using Muhasebe.CommonDtos;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;


namespace Muhasebe.Bankalar;
public class BankaAppService : MuhasebeAppService, IBankaAppService
{
    private readonly IBankaRepository _bankaRepository;

    public BankaAppService(IBankaRepository bankaRepository)
    {
        _bankaRepository = bankaRepository;
    }

    public Task<SelectBankaDto> GetAsync(Guid id) => throw new NotImplementedException();
    public Task<PagedResultDto<ListBankaDto>> GetListAsync(BankaListParameterDto input) => throw new NotImplementedException();
    public async Task<SelectBankaDto> CreateAsync(CreateBankaDto input)
    {
        var entity = ObjectMapper.Map<CreateBankaDto, Banka>(input);
        await _bankaRepository.InsertAsync(entity);
        return ObjectMapper.Map<Banka, SelectBankaDto>(entity);
    }
    public Task<SelectBankaDto> UpdateAsync(Guid id, UpdateBankaDto input) => throw new NotImplementedException();
    public Task DeleteAsync(Guid id) => throw new NotImplementedException();
    public Task<string> GetCodeAsync(CodeParameterDto input) => throw new NotImplementedException();
}