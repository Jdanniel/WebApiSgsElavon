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
            } catch (Exception ex)
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
        [HttpPut("AceptarRechazarOdt")]
        public async Task<ActionResult<ODT>> AceptarRechazarOdt(AceptarRechazarOdtRequest request)
        {
            var i =_odtService.AceptarRechazarOdt(request);
            if(i == 1)
            {
                ODT newOdt = await _odtService.GetOdtbyId(request.ID_AR);
                return Ok(newOdt);
            }
            else
            {
                //Para la siguiente version se debera realizar cambios para enviar un mensaje que ya fue reasignado o que ya no esta en el estatus correcto
                return BadRequest();
            }
        }
        [HttpPost("CierreSustitucion")]
        public async Task<ActionResult<ODT>> CierreSustitucion(SustitucionesRequest request)
        {
            var msg = await _odtService.CierreSustitucion(request);

            if (string.Equals(msg, "OK", StringComparison.InvariantCultureIgnoreCase))
            {
                ODT newOdt = await _odtService.GetOdtbyId(request.ID_AR);
                return Ok(newOdt);
            }
            else
            {
                return BadRequest(msg);
            }
        }
        [HttpPost("CierreSustitucionSim")]
        public async Task<ActionResult<ODT>> CierreSustitucionSim(SustitucionesSimRequest request)
        {
            var msg = await _odtService.CierreSustitucionSim(request);

            if (string.Equals(msg, "OK", StringComparison.InvariantCultureIgnoreCase))
            {
                ODT newOdt = await _odtService.GetOdtbyId(request.ID_AR);
                return Ok(newOdt);
            }
            else
            {
                return BadRequest(msg);
            }
        }
        [HttpPost("CierreInstalacion")]
        public async Task<ActionResult<ODT>> CierreInstalacion(CierreInstalacionRequest request)
        {
            var msg = await _odtService.cierreInstalacion(request);

            if (string.Equals(msg,"OK",StringComparison.InvariantCultureIgnoreCase))
            {
                ODT newOdt = await _odtService.GetOdtbyId(request.ID_AR);
                return Ok(newOdt);
            }
            else
            {
                return BadRequest(msg);
            }
        }
        [HttpPost("CierreInstalacionSim")]
        public async Task<ActionResult<ODT>> CierreInstalacionSim(CierreInstalacionSimRequest request)
        {
            var msg = await _odtService.cierreInstalacionSim(request);

            if (string.Equals(msg, "OK", StringComparison.InvariantCultureIgnoreCase))
            {
                ODT newOdt = await _odtService.GetOdtbyId(request.ID_AR);
                return Ok(newOdt);
            }
            else
            {
                return BadRequest(msg);
            }
        }
        [HttpPost("CierreRetiro")]
        public async Task<ActionResult<ODT>> CierreRetiro(CierresRetiroRequest request)
        {
            var msg = await _odtService.CierreRetiro(request);
            if (string.Equals(msg, "OK", StringComparison.InvariantCultureIgnoreCase))
            {
                ODT newOdt = await _odtService.GetOdtbyId(request.ID_AR);
                return Ok(newOdt);
            }
            else
            {
                return BadRequest(msg);
            }
        }
        [HttpPost("CierreRechazo")]
        public async Task<ActionResult<ODT>> CierreRechazo(CierreRechazoRequest request)
        {
            if (await _odtService.CierreRechazo(request))
            {
                ODT newOdt = await _odtService.GetOdtbyId(request.ID_AR);
                return Ok(newOdt);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost("CierreSinMovInventario")]
        public async Task<ActionResult<ODT>> CierreSinMovInventario(CierreSinMovInventarioRequest request)
        {
            var msg = await _odtService.CierreSinMovInventario(request);
            if (string.Equals(msg, "OK", StringComparison.InvariantCultureIgnoreCase))
            {
                ODT newOdt = await _odtService.GetOdtbyId(request.ID_AR);
                return Ok(newOdt);
            }
            else
            {
                return BadRequest(msg);
            }
        }
        [HttpGet("GetByIdar/{idAr}")]
        public async Task<ActionResult<ODT>> GetByIdar(int idAr)
        {
            var odt = await _odtService.GetOdtbyId(idAr);

            if(odt == null)
            {
                return NotFound();
            }
            return Ok(odt);

        }
        [HttpGet("PRUEBA")]
        public async Task<ActionResult<IEnumerable<OdtEvent>>> Prueba()
        {
            return Ok(await _odtService.prueba2());
        }
    }
}