using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    /// <summary>
    /// Base api controller
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public abstract class BaseApiController<T> : Controller where T : class
    {
        private readonly IBaseService _baseService;
        public BaseApiController(IBaseService baseService)
        {
            _baseService = baseService;
        }

        // <summary>
        // <Get an entity list>
        // </summary>
        // <returns>List of entities.</returns>
        [HttpGet(Name = "[controller]_[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public virtual async Task<ActionResult<IEnumerable<T>>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
