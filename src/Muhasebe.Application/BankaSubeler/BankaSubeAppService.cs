using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace Muhasebe.BankaSubeler;
public class BankaSubeAppService : MuhasebeAppService, IBankaSubeAppService
{
    private readonly IBankaSubeRepository _bankaSubeRepository;
    private readonly BankaSubeManager _bankaSubeManager;
    public BankaSubeAppService(IBankaSubeRepository bankaSubeRepository, 
        BankaSubeManager bankaSubeManager)
    {
        _bankaSubeRepository = bankaSubeRepository;
        _bankaSubeManager = bankaSubeManager;
    }
    public virtual async Task<SelectBankaSubeDto> GetAsync(Guid id)
    {
        var entity = await _bankaSubeRepository.GetAsync(id, x => x.Id == id,
            x => x.Banka, x => x.OzelKod1, x => x.OzelKod2);
        return ObjMap(entity);
    }

    private SelectBankaSubeDto ObjMap(BankaSube entity)
    {
        return ObjectMapper.Map<BankaSube, SelectBankaSubeDto>(entity);
    }
    private PagedResultDto<ListBankaSubeDto> ObjMap(List<BankaSube> entities, int totalCount) => new PagedResultDto<ListBankaSubeDto>(
            totalCount,
            ObjectMapper.Map<List<BankaSube>, List<ListBankaSubeDto>>(entities));

    public virtual async Task<PagedResultDto<ListBankaSubeDto>>
        GetListAsync(BankaSubeListParameterDto input)
    {
        var entities = await _bankaSubeRepository.GetPagedListAsync(input.SkipCount,
            input.MaxResultCount,
            x => x.BankaId == input.BankaId && x.Durum == input.Durum,
            x => x.Kod, x => x.OzelKod1, x => x.OzelKod2);
        var totalCount = await _bankaSubeRepository.CountAsync(
            x => x.BankaId == input.BankaId && x.Durum == input.Durum);
        return ObjMap(entities, totalCount);
    }
    public virtual async Task<SelectBankaSubeDto> CreateAsync(CreateBankaSubeDto input)
    {
        await _bankaSubeManager.CheckCreateAsync(input.Kod, input.BankaId, 
            input.OzelKod1Id, input.OzelKod2Id);
        var entity = ObjectMapper.Map<CreateBankaSubeDto, BankaSube>(input);
        await _bankaSubeRepository.InsertAsync(entity);
        return ObjectMapper.Map<BankaSube, SelectBankaSubeDto>(entity);
    }
    public virtual async Task<SelectBankaSubeDto> UpdateAsync(Guid id, UpdateBankaSubeDto input)
    {
        var entity = await _bankaSubeRepository.GetAsync(id, x => x.Id == id);
        await _bankaSubeManager.CheckUpdateAsync(id, input.Kod, entity,
            input.OzelKod1Id, input.OzelKod2Id);
        var mappedEntity = ObjectMapper.Map(input, entity);
        await _bankaSubeRepository.UpdateAsync(mappedEntity);
        return ObjectMapper.Map<BankaSube, SelectBankaSubeDto>(mappedEntity);
    }
    public virtual async Task DeleteAsync(Guid id)
    {
        await _bankaSubeManager.CheckDeleteAsync(id);
        await _bankaSubeRepository.DeleteAsync(id);
    }
    public virtual async Task<string> GetCodeAsync(BankaSubeCodeParameterDto input)
    {
        return await _bankaSubeRepository.GetCodeAsync(x=> x.Kod,
            x=>x.BankaId == input.BankaId && x.Durum == input.Durum);
    }
}