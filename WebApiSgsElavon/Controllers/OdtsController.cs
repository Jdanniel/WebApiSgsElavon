using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSgsElavon.Entities;
using WebApiSgsElavon.Services;

namespace WebApiSgsElavon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdtsController : ControllerBase
    {
        private IOdtService _odtService; 

        public OdtsController(IOdtService service)
        {
            this._odtService = service;
        }

        [HttpGet("getTotalOdts/{idusuario}")]
        public ActionResult<totalODT> getTotalOdts(int idusuario)
        {
            return _odtService.totalODTS(idusuario);
        }
    }
}