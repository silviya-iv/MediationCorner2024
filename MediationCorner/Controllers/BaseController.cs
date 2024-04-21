using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MediationCorner.Controllers
{
    
    [Authorize]
    public class BaseController : Controller
    {

    }
}
