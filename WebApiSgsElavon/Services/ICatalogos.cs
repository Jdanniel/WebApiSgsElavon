using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSgsElavon.Data;
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
        Task<List<CevidenceType>> GetEvidenceTypes();
    }

    public class CatalogosServices : ICatalogosServices
    {
        private readonly GetnetContext context;

        public CatalogosServices(GetnetContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<CambioStatusArDtos>> GetCambioStatusAr()
        {
            List<CambioStatusArDtos> cambio = await context
                .BdCambioStatusArs
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new CambioStatusArDtos
                {
                    IdCambioStatusAr = x.IdCambioStatusAr,
                    IdStatusArIni = x.IdStatusArIni.GetValueOrDefault(),
                    IdStatusArFin = x.IdStatusArFin.GetValueOrDefault()
                })
                .AsNoTracking()
                .ToListAsync();
            return cambio;
        }

        public async Task<List<CevidenceType>> GetEvidenceTypes()
        {
            List<CevidenceType> evidences = await context
                .CevidenceTypes
                .Where(x => x.Status == 1)
                .AsNoTracking()
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
                .AsNoTracking()
                .ToListAsync();
            return causas;
        }

        public async Task<IEnumerable<ConectividadesDtos>> GetConectividades()
        {
            List<ConectividadesDtos> conectividades = await context
                .CConectividads
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new ConectividadesDtos
                { 
                    IdConectividad = x.IdConectividad, 
                    DescConectividad = x.DescConectividad, 
                    IsGprs = x.IsGprs.GetValueOrDefault() })
                .AsNoTracking()
                .ToListAsync();
            return conectividades;
        }

        public async Task<IEnumerable<FallasDtos>> GetFallas()
        {
            List<FallasDtos> fallas = await context
                .CFallas.Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new FallasDtos { IdFalla = x.IdFalla, DescFalla = x.DescFalla })
                .AsNoTracking()
                .ToListAsync();
            return fallas;
        }

        public async Task<IEnumerable<MarcasDtos>> GetMarcas()
        {
            List<MarcasDtos> marcas = await context
                .CMarcas.Where(x => x.Status == "ACTIVO")
                .Select(x => new MarcasDtos { IdMarca = x.IdMarca, DescMarca = x.DescMarca })
                .AsNoTracking()
                .ToListAsync();
            return marcas;
        }

        public async Task<IEnumerable<ModelosDtos>> GetModelos()
        {
            List<ModelosDtos> modelos = await context
                .CModelos
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new ModelosDtos { IdModelo = x.IdModelo, DescModelo = x.DescModelo, IdMarca = x.IdMarca.GetValueOrDefault(), IdAccess = x.IdAccess.GetValueOrDefault() })
                .AsNoTracking()
                .ToListAsync();
            return modelos;
        }

        public async Task<IEnumerable<MovimientoInventarioServicioFallaDtos>> GetMovimientoInventarioServicioFallas()
        {
            List<MovimientoInventarioServicioFallaDtos> movs = await context
                .BdValMovimientosInvServicioFallas
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new MovimientoInventarioServicioFallaDtos
                { 
                    IdValMovimientosInvServicioFalla = x.IdValMovimientosInvServicioFalla,
                    IdServicio = x.IdServicio.GetValueOrDefault(), 
                    IdFalla = x.IdFalla.GetValueOrDefault(), 
                    IdMovInventario = x.IdMovInventario.GetValueOrDefault(), 
                    Status = x.Status })
                .AsNoTracking()
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
                .CSoftwares
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new SoftwaresDtos { IdAplicativo = x.IdSoftware, DescAplicativo = x.DescSoftware })
                .AsNoTracking()
                .ToListAsync();
            return softwares;
        }

        public async Task<IEnumerable<StatusArDtos>> GetStatusAr()
        {
            List<StatusArDtos> status = await context
                .CStatusArs
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new StatusArDtos { IdStatusAr = x.IdStatusAr, DescStatusAr = x.DescStatusAr })
                .AsNoTracking()
                .ToListAsync();
            return status;
        }

        public async Task<IEnumerable<SubrechazosDtos>> GetSubrechazos()
        {
            List<SubrechazosDtos> subs = await context
                .CSubrechazos
                .Where(x => x.Status == "ACTIVO")
                .Select(X => new SubrechazosDtos { IdSubrechazo = X.IdSubrechazo, Subrechazo = X.Subrechazo, Id = X.Id.GetValueOrDefault(), IsProgramado = X.IsProgramado.GetValueOrDefault() })
                .AsNoTracking()
                .ToListAsync();
            return subs;
        }

        public async Task<IEnumerable<CausasRechazosDtos>> GetCausasrechazos()
        {
            List<CausasRechazosDtos> causas = await context
                .CCausasRechazos
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new CausasRechazosDtos { 
                    IdCausaRechazo = x.IdCausaRechazo, 
                    DescCausaRechazo = x.DescCausaRechazo.Replace("\r\n", string.Empty), 
                    IdTrechazo = x.IdTrechazo.GetValueOrDefault() })
                .AsNoTracking()
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
                    DescStatusUnidad = (context.CStatusUnidads.Where(s => s.IdStatusUnidad == x.IdStatusUnidad && s.Status == "ACTIVO").Select(s => s.DescStatusUnidad).FirstOrDefault()),
                    IdTipoResponsable = x.IdTipoResponsable.GetValueOrDefault(),
                    IdResponsable = x.IdResponsable.GetValueOrDefault()
                })
                .AsNoTracking()
                .ToListAsync();
            return unidades;
        }

        public async Task<IEnumerable<BdModelosConectividadesDtos>> GetModeloConectividad()
        {
            List<BdModelosConectividadesDtos> modelosConectividades = await context
                .BdModeloConectividads
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new BdModelosConectividadesDtos
                {
                    IdModeloConectividad = x.IdModeloConectividad,
                    IdModelo = x.IdModelo.GetValueOrDefault(),
                    IdConectividad = x.IdConectividad.GetValueOrDefault()
                })
                .AsNoTracking()
                .ToListAsync();
            return modelosConectividades;
        }

        public async Task<IEnumerable<UnidadesDtos>> GetUnidadesNegocio(int idusuario)
        {
            List<int> idstatusar = new List<int> { 6, 7, 8 };

            var PROVEEDOR = context
                .CUsuarios
                .Select(x => new CUsuario()
                {
                    IdProveedor = x.IdProveedor,
                    IdUsuario = x.IdUsuario
                })
                .Where(x => x.IdUsuario == idusuario).FirstOrDefault();

            List<int> negocios = await context
                .BdArs
                .Where(x => !idstatusar
                .Contains(x.IdStatusAr.GetValueOrDefault()) && x.IdTecnico == idusuario)
                .Select(x => x.IdNegocio.GetValueOrDefault())
                .ToListAsync();
            //var negocios = await context.BdAr.Where(x => x.IdTecnico == idusuario && !idstatusar.Contains(x.IdStatusAr)).Select(x => x.IdNegocio == null ? 0 : x.IdNegocio).ToListAsync();
            List<UnidadesDtos> unidadesNegocio = await context.BdUnidades
                .Where(x => x.IdStatusUnidad == 17 && x.IdSim == PROVEEDOR.IdProveedor && x.IdResponsable != null
                && x.IdTipoResponsable==4 && negocios.Contains(x.IdResponsable.GetValueOrDefault())).Select(x => new UnidadesDtos()
            {
                IdUnidad = x.IdUnidad,
                IdModelo = x.IdModelo,
                IdMarca = x.IdMarca,
                IdConectividad = x.IdConectividad.GetValueOrDefault(),
                IdAplicativo = x.IdAplicativo.GetValueOrDefault(),
                IdStatusUnidad = x.IdStatusUnidad,
                IsNueva = x.IsNueva,
                NoSerie = x.NoSerie.Trim(),
                DescStatusUnidad = (context.CStatusUnidads.Where(s => s.IdStatusUnidad == x.IdStatusUnidad && s.Status == "ACTIVO").Select(s => s.DescStatusUnidad).FirstOrDefault()),
                IdTipoResponsable = x.IdTipoResponsable.GetValueOrDefault(),
                IdResponsable = x.IdResponsable.GetValueOrDefault()
            })
                .AsNoTracking()
                .ToListAsync();
            return unidadesNegocio;
        }
        public async Task<IEnumerable<ReglasModelosDtos>> GetReglasModelos()
        {
            List<ReglasModelosDtos> reglas = await context.BdReglasModelos
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new ReglasModelosDtos
                {
                    IdRegla = x.IdReglas,
                    IdModelo = x.IdModelo.GetValueOrDefault(),
                    LetrasMin = x.LetrasMin.GetValueOrDefault(),
                    LetrasMax = x.LetrasMax.GetValueOrDefault(),
                    NumeroMin = x.NumeroMin.GetValueOrDefault(),
                    NumeroMax = x.NumeroMax.GetValueOrDefault(),
                    LongMin = x.LongMin.GetValueOrDefault(),
                    LongMax = x.LongMax.GetValueOrDefault()
                })
                .AsNoTracking()
                .ToListAsync();
            return reglas;
        }
        public async Task<IEnumerable<CausasCancelacionDtos>> GetCausasCancelacion()
        {
            return await context.CCausaCancelacions.Where(x => x.Status == "ACTIVO")
                .Select(x => new CausasCancelacionDtos()
                {
                    DescCausa = x.DescCausaCancelacion,
                    IdCausaCancelacion = x.IdCausaCancelacion,
                    IdTipoCancelado = x.IdTipoCancelado.GetValueOrDefault()
                })
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<SolucionesDtos>> GetSoluciones()
        {
            return await context.CSoluciones.Where(x => x.Status == "ACTIVO")
                .Select(x => new SolucionesDtos()
                {
                   IdSolucion = x.IdSolucion,
                   DescSolucion = x.DescSolucion,
                   
                })
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
