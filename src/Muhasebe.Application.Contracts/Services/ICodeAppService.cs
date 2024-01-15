namespace Muhasebe.Services;
public interface ICodeAppService<in TGetCodeInput> : IApplicationService
{
    Task<string> GetCodeAsync(TGetCodeInput input);
}