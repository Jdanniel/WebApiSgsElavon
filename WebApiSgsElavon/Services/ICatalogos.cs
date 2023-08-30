using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
//using WebApiSgsElavon.Model;
using WebApiSgsElavon.ModelsTest;

namespace WebApiSgsElavon.Services
{
    public interface ICatalogosServices
    {
        Task<IEnumerable<ModelosDtos>> GetModelos();
        Task<IEnumerable<MarcasDtos>> GetMarcas();
        Task<IEnumerable<ServiciosDtos>> GetServicios();
        Task<IEnumerable<ConectividadesDtos>> GetConectividades();
        Task<IEnumerable<SoftwaresDtos>> GetSoftwares();
        Task<IEnumerable<UnidadesDtos>> GetUnidades(int idusuario);
        Task<IEnumerable<UnidadesDtos>> GetUnidadesNegocio(int idusuario);
        Task<IEnumerable<MovimientoInventarioServicioFallaDtos>> GetMovimientoInventarioServicioFallas();
        Task<IEnumerable<CausasDtos>> GetCausas();
        Task<IEnumerable<FallasDtos>> GetFallas();
        Task<IEnumerable<StatusArDtos>> GetStatusAr();
        Task<IEnumerable<CambioStatusArDtos>> GetCambioStatusAr();
        Task<IEnumerable<SubrechazosDtos>> GetSubrechazos();
        Task<IEnumerable<CausasRechazosDtos>> GetCausasrechazos();
        Task<IEnumerable<BdModelosConectividadesDtos>> GetModeloConectividad();
        Task<IEnumerable<ReglasModelosDtos>> GetReglasModelos();
        Task<IEnumerable<CausasCancelacionDtos>> GetCausasCancelacion();
        Task<IEnumerable<SolucionesDtos>> GetSoluciones();
        Task<List<CEvidenceTypes>> GetEvidenceTypes();
    }

    public class CatalogosServices : ICatalogosServices
    {
        private readonly ELAVONTESTContext context;

        public CatalogosServices(ELAVONTESTContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<CambioStatusArDtos>> GetCambioStatusAr()
        {
            List<CambioStatusArDtos> cambio = await context
                .BdCambioStatusAr
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new CambioStatusArDtos
                {
                    IdCambioStatusAr = x.IdCambioStatusAr,
                    IdStatusArIni = x.IdStatusArIni.GetValueOrDefault(),
                    IdStatusArFin = x.IdStatusArFin.GetValueOrDefault()
                })
                .ToListAsync();
            return cambio;
        }

        public async Task<List<CEvidenceTypes>> GetEvidenceTypes()
        {
            List<CEvidenceTypes> evidences = await context
                .CEvidenceTypes
                .Where(x => x.Status == 1)
                .ToListAsync();
            return evidences;
        }

        public async Task<IEnumerable<CausasDtos>> GetCausas()
        {
            List<CausasDtos> causas = await context
                .CCausas
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new CausasDtos
                {
                    IdCausa = x.IdCausa,
                    DescCausa = x.DescCausa,
                    Descripcion = x.Descripcion
                })
                .ToListAsync();
            return causas;
        }

        public async Task<IEnumerable<ConectividadesDtos>> GetConectividades()
        {
            List<ConectividadesDtos> conectividades = await context
                .CConectividad
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new ConectividadesDtos
                { 
                    IdConectividad = x.IdConectividad, 
                    DescConectividad = x.DescConectividad, 
                    IsGprs = x.IsGprs == null ? 0 : x.IsGprs })
                .ToListAsync();
            return conectividades;
        }

        public async Task<IEnumerable<FallasDtos>> GetFallas()
        {
            List<FallasDtos> fallas = await context
                .CFallas.Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new FallasDtos { IdFalla = x.IdFalla, DescFalla = x.DescFalla })
                .ToListAsync();
            return fallas;
        }

        public async Task<IEnumerable<MarcasDtos>> GetMarcas()
        {
            List<MarcasDtos> marcas = await context
                .CMarcas.Where(x => x.Status == "ACTIVO")
                .Select(x => new MarcasDtos { IdMarca = x.IdMarca, DescMarca = x.DescMarca })
                .ToListAsync();
            return marcas;
        }

        public async Task<IEnumerable<ModelosDtos>> GetModelos()
        {
            List<ModelosDtos> modelos = await context
                .CModelos
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new ModelosDtos { IdModelo = x.IdModelo, DescModelo = x.DescModelo, IdMarca = x.IdMarca, IdAccess = x.IdAccess })
                .ToListAsync();
            return modelos;
        }

        public async Task<IEnumerable<MovimientoInventarioServicioFallaDtos>> GetMovimientoInventarioServicioFallas()
        {
            List<MovimientoInventarioServicioFallaDtos> movs = await context
                .BdValMovimientosInvServicioFalla
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new MovimientoInventarioServicioFallaDtos
                { 
                    IdValMovimientosInvServicioFalla = x.IdValMovimientosInvServicioFalla,
                    IdServicio = x.IdServicio.GetValueOrDefault(), 
                    IdFalla = x.IdFalla.GetValueOrDefault(), 
                    IdMovInventario = x.IdMovInventario.GetValueOrDefault(), 
                    Status = x.Status })
                .ToListAsync();
            return movs;
        }

        public async Task<IEnumerable<ServiciosDtos>> GetServicios()
        {
            List<ServiciosDtos> servicios = await context
                .CServicios
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new ServiciosDtos { IdServicio = x.IdServicio, DescServicio = x.DescServicio, IdARNeedNOcheckup = x.IdArneedNocheckup.GetValueOrDefault() })
                .ToListAsync();
            return servicios;
        }

        public async Task<IEnumerable<SoftwaresDtos>> GetSoftwares()
        {
            List<SoftwaresDtos> softwares = await context
                .CSoftware
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new SoftwaresDtos { IdAplicativo = x.IdSoftware, DescAplicativo = x.DescSoftware })
                .ToListAsync();
            return softwares;
        }

        public async Task<IEnumerable<StatusArDtos>> GetStatusAr()
        {
            List<StatusArDtos> status = await context
                .CStatusAr
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new StatusArDtos { IdStatusAr = x.IdStatusAr, DescStatusAr = x.DescStatusAr })
                .ToListAsync();
            return status;
        }

        public async Task<IEnumerable<SubrechazosDtos>> GetSubrechazos()
        {
            List<SubrechazosDtos> subs = await context
                .CSubrechazo
                .Where(x => x.Status == "ACTIVO")
                .Select(X => new SubrechazosDtos { IdSubrechazo = X.IdSubrechazo, Subrechazo = X.Subrechazo, Id = X.Id, IsProgramado = X.IsProgramado.GetValueOrDefault() })
                .ToListAsync();
            return subs;
        }

        public async Task<IEnumerable<CausasRechazosDtos>> GetCausasrechazos()
        {
            List<CausasRechazosDtos> causas = await context
                .CCausasRechazo
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new CausasRechazosDtos { 
                    IdCausaRechazo = x.IdCausaRechazo, 
                    DescCausaRechazo = x.DescCausaRechazo.Replace("\r\n", string.Empty), 
                    IdTrechazo = x.IdTrechazo })
                .ToListAsync();
            return causas;
        }

        public async Task<IEnumerable<UnidadesDtos>> GetUnidades(int idusuario)
        {
            List<int> status = new List<int>();
            status.Add(46);
            status.Add(15);
            var usuario = context.CUsuarios.Where(x => x.IdUsuario == idusuario).FirstOrDefault();
            List<UnidadesDtos> unidades = await context
                .BdUnidades
                .Where(x => status.Contains(x.IdStatusUnidad) && x.Status == "ACTIVO" && x.IdCliente == 4 && x.IdSim == usuario.IdProveedor)
                .Select(x => new UnidadesDtos() {
                    IdUnidad = x.IdUnidad,
                    IdAplicativo = x.IdAplicativo.GetValueOrDefault(),
                    IdConectividad = x.IdConectividad.GetValueOrDefault(),
                    IdMarca = x.IdMarca,
                    IdModelo = x.IdModelo,
                    NoSerie = x.NoSerie.Trim(),
                    IdStatusUnidad = x.IdStatusUnidad,
                    IsNueva = x.IsNueva,
                    DescStatusUnidad = (context.CStatusUnidad.Where(s => s.IdStatusUnidad == x.IdStatusUnidad && s.Status == "ACTIVO").Select(s => s.DescStatusUnidad).FirstOrDefault()),
                    IdTipoResponsable = x.IdTipoResponsable,
                    IdResponsable = x.IdResponsable
                })
                .ToListAsync();
            return unidades;
        }

        public async Task<IEnumerable<BdModelosConectividadesDtos>> GetModeloConectividad()
        {
            List<BdModelosConectividadesDtos> modelosConectividades = await context
                .BdModeloConectividad
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new BdModelosConectividadesDtos
                {
                    IdModeloConectividad = x.IdModeloConectividad,
                    IdModelo = x.IdModelo,
                    IdConectividad = x.IdConectividad
                })
                .ToListAsync();
            return modelosConectividades;
        }

        public async Task<IEnumerable<UnidadesDtos>> GetUnidadesNegocio(int idusuario)
        {
            List<int> idstatusar = new List<int> { 6, 7, 8 };
            var PROVEEDOR = context.CUsuarios.Where(x => x.IdUsuario == idusuario).FirstOrDefault();
            List<int> negocios = await context.BdAr.Where(x => !idstatusar.Contains(x.IdStatusAr) && x.IdTecnico == idusuario).Select(x => x.IdNegocio == null ? 0 : x.IdNegocio).ToListAsync();
            //var negocios = await context.BdAr.Where(x => x.IdTecnico == idusuario && !idstatusar.Contains(x.IdStatusAr)).Select(x => x.IdNegocio == null ? 0 : x.IdNegocio).ToListAsync();
            List<UnidadesDtos> unidadesNegocio = await context.BdUnidades
                .Where(x => x.IdStatusUnidad == 17 && x.IdSim == PROVEEDOR.IdProveedor && x.IdResponsable != null
                && x.IdTipoResponsable==4 && negocios.Contains(x.IdResponsable)).Select(x => new UnidadesDtos()
            {
                IdUnidad = x.IdUnidad,
                IdModelo = x.IdModelo,
                IdMarca = x.IdMarca,
                IdConectividad = x.IdConectividad.GetValueOrDefault(),
                IdAplicativo = x.IdAplicativo.GetValueOrDefault(),
                IdStatusUnidad = x.IdStatusUnidad,
                IsNueva = x.IsNueva,
                NoSerie = x.NoSerie.Trim(),
                DescStatusUnidad = (context.CStatusUnidad.Where(s => s.IdStatusUnidad == x.IdStatusUnidad && s.Status == "ACTIVO").Select(s => s.DescStatusUnidad).FirstOrDefault()),
                IdTipoResponsable = x.IdTipoResponsable,
                IdResponsable = x.IdResponsable
            }).ToListAsync();
            return unidadesNegocio;
        }
        public async Task<IEnumerable<ReglasModelosDtos>> GetReglasModelos()
        {
            List<ReglasModelosDtos> reglas = await context.BdReglasModelos
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new ReglasModelosDtos
                {
                    IdRegla = x.IdReglas,
                    IdModelo = x.IdModelo,
                    LetrasMin = x.LetrasMin,
                    LetrasMax = x.LetrasMax,
                    NumeroMin = x.NumeroMin,
                    NumeroMax = x.NumeroMax,
                    LongMin = x.LongMin,
                    LongMax = x.LongMax
                }).ToListAsync();
            return reglas;
        }
        public async Task<IEnumerable<CausasCancelacionDtos>> GetCausasCancelacion()
        {
            return await context.CCausaCancelacion.Where(x => x.Status == "ACTIVO")
                .Select(x => new CausasCancelacionDtos()
                {
                    DescCausa = x.DescCausaCancelacion,
                    IdCausaCancelacion = x.IdCausaCancelacion,
                    IdTipoCancelado = x.IdTipoCancelado.GetValueOrDefault()
                }).ToListAsync();
        }

        public async Task<IEnumerable<SolucionesDtos>> GetSoluciones()
        {
            return await context.CSoluciones.Where(x => x.Status == "ACTIVO")
                .Select(x => new SolucionesDtos()
                {
                   IdSolucion = x.IdSolucion,
                   DescSolucion = x.DescSolucion,
                   
                }).ToListAsync();
        }
    }
}
