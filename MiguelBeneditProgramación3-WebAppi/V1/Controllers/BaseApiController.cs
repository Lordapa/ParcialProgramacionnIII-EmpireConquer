using Microsoft.AspNetCore.Mvc;
using MiguelBeneditProgramación3_Core.Interfaces.Services;

namespace MiguelBeneditProgramación3_WebApplication.V1.Controllers
{
    public abstract class BaseApiController<T> : Controller where T : class
    {
        private readonly IBaseService _baseService;
        public BaseApiController(IBaseService baseService)
        {
            _baseService = baseService;
        }
    }
}
