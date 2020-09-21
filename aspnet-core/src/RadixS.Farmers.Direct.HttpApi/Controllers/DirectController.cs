using RadixS.Farmers.Direct.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RadixS.Farmers.Direct.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DirectController : AbpController
    {
        protected DirectController()
        {
            LocalizationResource = typeof(DirectResource);
        }
    }
}