using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSgsElavon.Entities;
using WebApiSgsElavon.Entities.Requests;
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

        [HttpGet("getOdtsTecnico/{idusuario}")]
        public async Task<ActionResult<IEnumerable<ODT>>> getOdts(int idusuario)
        {
            try
            {
                return Ok(await _odtService.getOdts(idusuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            
        }

        [HttpGet("getNewOdts/{idusuario}")]
        public async Task<ActionResult<string>> getNewOdts(int idusuario)
        {
            try
            {
                return Ok(await _odtService.GetNewOdts(idusuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut("UpdateStatusAr")]
        public async Task<ActionResult<int>> UpdateStatusAr(UpdateStatusBdArRequest model)
        {
            try
            {
                return Ok(await _odtService.UpdateStatusAr(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("AgregarComentario")]
        public ActionResult<int> AgregarComentario(AgregarComentarioRequest request)
        {
            try
            {
                return Ok(_odtService.AgregarComentario(request));
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("GetNuevasOdts")]
        public async Task<ActionResult<IEnumerable<ODT>>> GetNuevasOdts(GetNuevasOdts request)
        {
            var lista = await _odtService.GetNuevasOdts(request);
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
        
        [HttpGet("PRUEBA")]
        public async Task<ActionResult<IEnumerable<OdtEvent>>> Prueba()
        {
            return Ok(await _odtService.prueba2());
        }
    }
}