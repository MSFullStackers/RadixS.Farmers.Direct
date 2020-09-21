using System;
using System.Collections.Generic;
using System.Text;
using RadixS.Farmers.Direct.Localization;
using Volo.Abp.Application.Services;

namespace RadixS.Farmers.Direct
{
    /* Inherit your application services from this class.
     */
    public abstract class DirectAppService : ApplicationService
    {
        protected DirectAppService()
        {
            LocalizationResource = typeof(DirectResource);
        }
    }
}
