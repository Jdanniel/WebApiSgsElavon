using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiSgsElavon.Dtos.BdModelosConectividades;
using WebApiSgsElavon.Dtos.CambioStatusAr;
using WebApiSgsElavon.Dtos.Causas;
using WebApiSgsElavon.Dtos.CausasCancelacion;
using WebApiSgsElavon.Dtos.CausasRechazos;
using WebApiSgsElavon.Dtos.Conectividades;
using WebApiSgsElavon.Dtos.Fallas;
using WebApiSgsElavon.Dtos.Marcas;
using WebApiSgsElavon.Dtos.Modelos;
using WebApiSgsElavon.Dtos.MovimientoInventarioServicioFallaDtos;
using WebApiSgsElavon.Dtos.Servicios;
using WebApiSgsElavon.Dtos.Softwares;
using WebApiSgsElavon.Dtos.Soluciones;
using WebApiSgsElavon.Dtos.StatusAr;
using WebApiSgsElavon.Dtos.Subrechazos;
using WebApiSgsElavon.Dtos.Unidades;
using WebApiSgsElavon.ModelsTest;
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
        public async Task<ActionResult<IEnumerable<ModelosDtos>>> getModelos()
        {
            try
            {
                IEnumerable<ModelosDtos> dtos = await _Catalogosservices.GetModelos();
                return Ok(dtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
        [HttpGet("marcas")]
        public async Task<IEnumerable<MarcasDtos>> getMarcas()
        {
            IEnumerable<MarcasDtos> dtos = await _Catalogosservices.GetMarcas();
            return dtos;
        }
        [HttpGet("servicios")]
        public async Task<IEnumerable<ServiciosDtos>> getServicios()
        {
            IEnumerable<ServiciosDtos> dtos = await _Catalogosservices.GetServicios();
            return dtos;
        }
        [HttpGet("conectividades")]
        public async Task<IEnumerable<ConectividadesDtos>> getConectividades()
        {
            IEnumerable<ConectividadesDtos> dtos = await _Catalogosservices.GetConectividades();
            return dtos;
        }
        [HttpGet("softwares")]
        public async Task<IEnumerable<SoftwaresDtos>> getSoftwares()
        {
            IEnumerable<SoftwaresDtos> dtos = await _Catalogosservices.GetSoftwares();
            return dtos;
        }
        [HttpGet("evidenceTypes")]
        public async Task<IEnumerable<CEvidenceTypes>> GetEvidenceTypes()
        {
            IEnumerable<CEvidenceTypes> evidences = await _Catalogosservices.GetEvidenceTypes();
            return evidences;
        }
        [HttpGet("unidades/{idusuario}")]
        public async Task<IEnumerable<UnidadesDtos>> GetUnidades(int idusuario)
        {
            IEnumerable<UnidadesDtos> dtos = await _Catalogosservices.GetUnidades(idusuario);

            if (dtos.Any())
            {
                return dtos;
            }
            return null;
        }
        [HttpGet("unidadesNegocio/{idusuario}")]
        public async Task<IEnumerable<UnidadesDtos>> GetUnidadesNegocio(int idusuario)
        {
            IEnumerable<UnidadesDtos> dtos = await _Catalogosservices.GetUnidadesNegocio(idusuario);
            if (dtos.Any())
            {
                return dtos;
            }
            return null;
        }
        [HttpGet("movinventariosf")]
        public async Task<IEnumerable<MovimientoInventarioServicioFallaDtos>> GetMovimientoInventarioServicioFallas()
        {
            IEnumerable<MovimientoInventarioServicioFallaDtos> dtos = await _Catalogosservices.GetMovimientoInventarioServicioFallas();
            return dtos;
        }
        [HttpGet("causas")]
        public async Task<IEnumerable<CausasDtos>> GetCausas()
        {
            IEnumerable<CausasDtos> dtos = await _Catalogosservices.GetCausas();
            return dtos;
        }
        [HttpGet("fallas")]
        public async Task<IEnumerable<FallasDtos>> GetFallas()
        {
            IEnumerable<FallasDtos> dtos = await _Catalogosservices.GetFallas();
            return dtos;
        }
        [HttpGet("cambiostatusar")]
        public async Task<ActionResult<IEnumerable<CambioStatusArDtos>>> GetCambioStatusArs()
        {
            IEnumerable<CambioStatusArDtos> dto = await _Catalogosservices.GetCambioStatusAr();
            if (dto.Any()) return Ok(dto);
            return NotFound();
        }
        [HttpGet("statusar")]
        public async Task<ActionResult<IEnumerable<StatusArDtos>>> GetStatusAr()
        {
            IEnumerable<StatusArDtos> lista = await _Catalogosservices.GetStatusAr();
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
        [HttpGet("subrechazos")]
        public async Task<ActionResult<IEnumerable<SubrechazosDtos>>> GetSubrechazos()
        {
            IEnumerable<SubrechazosDtos> dtos = await _Catalogosservices.GetSubrechazos();
            if (dtos.Any()) return Ok(dtos);
            return NotFound();
        }
        [HttpGet("causasrechazos")]
        public async Task<ActionResult<IEnumerable<CausasRechazosDtos>>> GetCausasRechazos()
        {
            IEnumerable<CausasRechazosDtos> lista = await _Catalogosservices.GetCausasrechazos();
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
        [HttpGet("modelosconectividad")]
        public async Task<ActionResult<BdModelosConectividadesDtos>> GetModelosConectividades()
        {
            IEnumerable<BdModelosConectividadesDtos> lista = await _Catalogosservices.GetModeloConectividad();
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
        [HttpGet("reglasmodelos")]
        public async Task<ActionResult<ReglasModelosDtos>> GetReglasModelos()
        {
            IEnumerable<ReglasModelosDtos> lista = await _Catalogosservices.GetReglasModelos();
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
        [HttpGet("causasCancelacion")]
        public async Task<ActionResult<CausasCancelacionDtos>> GetCausasCancelacion()
        {
            IEnumerable<CausasCancelacionDtos> lista = await _Catalogosservices.GetCausasCancelacion();
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
        [HttpGet("soluciones")]
        public async Task<ActionResult<SolucionesDtos>> GetSoluciones()
        {
            IEnumerable<SolucionesDtos> lista = await _Catalogosservices.GetSoluciones();
            if (lista.Any()) return Ok(lista);
            return NotFound();
        }
    }
}