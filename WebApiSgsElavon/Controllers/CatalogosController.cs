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
    public class CatalogosController : ControllerBase
    {
        private ICatalogosServices _Catalogosservices;

        public CatalogosController(ICatalogosServices _services)
        {
            _Catalogosservices = _services;
        }

        [HttpGet("modelos")]
        public async Task<ActionResult<IEnumerable<Modelos>>> getModelos()
        {
            try
            {
                return Ok(await _Catalogosservices.GetModelos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            
        }
        [HttpGet("marcas")]
        public async Task<IEnumerable<Marcas>> getMarcas()
        {
            return await _Catalogosservices.GetMarcas();
        }
        [HttpGet("servicios")]
        public async Task<IEnumerable<Servicios>> getServicios()
        {
            return await _Catalogosservices.GetServicios();
        }
        [HttpGet("conectividades")]
        public async Task<IEnumerable<Conectividades>> getConectividades()
        {
            return await _Catalogosservices.GetConectividades();
        }
        [HttpGet("softwares")]
        public async Task<IEnumerable<Software>> getSoftwares()
        {
            return await _Catalogosservices.GetSoftwares();
        }
        [HttpGet("unidades/{idusuario}")]
        public async Task<IEnumerable<Unidades>> GetUnidades(int idusuario)
        {
            return await _Catalogosservices.GetUnidades(idusuario);
        }
        [HttpGet("movinventariosf")]
        public async Task<IEnumerable<MovimientoInventarioServicioFalla>> GetMovimientoInventarioServicioFallas()
        {
            return await _Catalogosservices.GetMovimientoInventarioServicioFallas();
        }
        [HttpGet("causas")]
        public async Task<IEnumerable<Causas>> GetCausas()
        {
            return await _Catalogosservices.GetCausas();
        }
        [HttpGet("fallas")]
        public async Task<IEnumerable<Fallas>> GetFallas()
        {
            return await _Catalogosservices.GetFallas();
        }
        [HttpGet("cambiostatusar")]
        public async Task<ActionResult<IEnumerable<CambioStatusAr>>> GetCambioStatusArs()
        {
            var lista = await _Catalogosservices.GetCambioStatusAr();
            if(lista.Any()) return Ok(lista);
            return NotFound();
        }
        [HttpGet("statusar")]
        public async Task<ActionResult<IEnumerable<StatusAr>>> GetStatusAr()
        {
            var lista = await _Catalogosservices.GetStatusAr();
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
        [HttpGet("subrechazos")]
        public async Task<ActionResult<IEnumerable<Subrechazos>>> GetSubrechazos()
        {
            var lista = await _Catalogosservices.GetSubrechazos();
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
        [HttpGet("causasrechazos")]
        public async Task<ActionResult<IEnumerable<Causasrechazos>>> GetCausasRechazos()
        {
            var lista = await _Catalogosservices.GetCausasrechazos();
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
        [HttpGet("modelosconectividad")]
        public async Task<ActionResult<BdModelosConectividades>> GetModelosConectividades()
        {
            var lista = await _Catalogosservices.GetModeloConectividad();
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
    }
}