using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSgsElavon.Entities.Requests;
using WebApiSgsElavon.Services;

namespace WebApiSgsElavon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegociosController : ControllerBase
    {
        private INegocioService _negocioServices;

        public NegociosController(INegocioService negocioService)
        {
            _negocioServices = negocioService;
        }

        [HttpPut("UpdateCoordenadas")]
        public async Task<ActionResult<int>> UpdateCoordenadas(UpdateCoordenadasRequest request)
        {
            try
            {
                int r = await _negocioServices.UpdateCoordenadas(request);
                return Ok(r);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}