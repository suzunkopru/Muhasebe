using Muhasebe.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Muhasebe.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MuhasebeController : AbpControllerBase
{
    protected MuhasebeController()
    {
        LocalizationResource = typeof(MuhasebeResource);
    }
}
