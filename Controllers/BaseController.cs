using EnqueteApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EnqueteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseController : ControllerBase 
    {
        public readonly IEnqueteService EnqueteService;

        protected BaseController(IEnqueteService enqueteService)
        {
            EnqueteService = enqueteService;
        }
    }
}
