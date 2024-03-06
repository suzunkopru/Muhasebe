using Volo.Abp;
namespace Muhasebe.Exceptions;
public class DuplicateCodeException: BusinessException
{
    public DuplicateCodeException(string kod) : base(MuhasebeDomainErrorCodes.DuplicateKod)
    => WithData("kod", kod);
}
