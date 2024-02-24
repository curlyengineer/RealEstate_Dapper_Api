using Microsoft.AspNetCore.Mvc;
using System.Security.Permissions;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultFeatureCompanentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
