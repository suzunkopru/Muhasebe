using System;
using System.Collections.Generic;
using System.Text;
using Muhasebe.Localization;
using Volo.Abp.Application.Services;

namespace Muhasebe;

/* Inherit your application services from this class.
 */
public abstract class MuhasebeAppService : ApplicationService
{
    protected MuhasebeAppService()
    {
        LocalizationResource = typeof(MuhasebeResource);
    }
}
