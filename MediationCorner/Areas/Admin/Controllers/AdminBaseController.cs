using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static MediationCorner.Core.Constants.AdminConstants;

namespace MediationCorner.Areas.Admin.Controllers
{

    [Area(AdminAreaName)]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {

    }
}
