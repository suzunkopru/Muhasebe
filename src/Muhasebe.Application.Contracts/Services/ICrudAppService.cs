namespace Muhasebe.Services;
public interface ICrudAppService<TGetOutputDto, TGetListOutputDto, in TGetListInput,
    in TCreateInput, in TUpdateInput> :
    IReadOnlyAppService<TGetOutputDto, TGetListOutputDto, Guid, TGetListInput>,
    ICreateAppService<TGetOutputDto, TCreateInput>,
    IUpdateAppService<TGetOutputDto, Guid, TUpdateInput>
{
}
/// <summary>
/// ICrudAppService şablonu
/// </summary>
/// <typeparam name="TGetOutputDto">Select için (GetAsync)</typeparam>
/// <typeparam name="TGetListOutputDto">Listeler için (GetList Async)</typeparam>
/// <typeparam name="TGetListInput">Liste Parametreleri</typeparam>
/// <typeparam name="TCreateInput">Create Dto (CreateAsync)</typeparam>
/// <typeparam name="TUpdateInput">Update Dto (UpdateAsync)</typeparam>
/// <typeparam name="IDeleteAppService">DeleteAsync)</typeparam>
/// <typeparam name="TGetCodeInput">Artan Kod için</typeparam>
public interface ICrudAppService<TGetOutputDto, TGetListOutputDto, in TGetListInput,
    in TCreateInput, in TUpdateInput, in TGetCodeInput> :
    ICrudAppService<TGetOutputDto, TGetListOutputDto, TGetListInput,
        TCreateInput, TUpdateInput>,
    IDeleteAppService<Guid>,
    ICodeAppService<TGetCodeInput>
{
}