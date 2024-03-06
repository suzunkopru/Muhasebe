using Volo.Abp;
namespace Muhasebe.Exceptions;
public class CannotBeDeletedException : BusinessException
{
    public CannotBeDeletedException() : base
                (MuhasebeDomainErrorCodes.CannotBeDeleted) { }
}
