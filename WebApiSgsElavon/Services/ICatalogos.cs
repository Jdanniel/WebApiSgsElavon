using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSgsElavon.Entities;
using WebApiSgsElavon.ModelsTest;

namespace WebApiSgsElavon.Services
{
    public interface ICatalogosServices
    {
        Task<IEnumerable<Modelos>> GetModelos();
        Task<IEnumerable<Marcas>> GetMarcas();
        Task<IEnumerable<Servicios>> GetServicios();
        Task<IEnumerable<Conectividades>> GetConectividades();
        Task<IEnumerable<Software>> GetSoftwares();
        Task<IEnumerable<Unidades>> GetUnidades(int idusuario);
        Task<IEnumerable<Unidades>> GetUnidadesNegocio(int idusuario);
        Task<IEnumerable<MovimientoInventarioServicioFalla>> GetMovimientoInventarioServicioFallas();
        Task<IEnumerable<Causas>> GetCausas();
        Task<IEnumerable<Fallas>> GetFallas();
        Task<IEnumerable<StatusAr>> GetStatusAr();
        Task<IEnumerable<CambioStatusAr>> GetCambioStatusAr();
        Task<IEnumerable<Subrechazos>> GetSubrechazos();
        Task<IEnumerable<Causasrechazos>> GetCausasrechazos();
        Task<IEnumerable<BdModelosConectividades>> GetModeloConectividad();
        Task<IEnumerable<ReglasModelos>> GetReglasModelos();
    }

    public class CatalogosServices : ICatalogosServices
    {
        private readonly ELAVONTESTContext context;

        public CatalogosServices(ELAVONTESTContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<CambioStatusAr>> GetCambioStatusAr()
        {
            List<CambioStatusAr> cambio = await context
                .BdCambioStatusAr
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new CambioStatusAr { 
                    ID_CAMBIO_STATUS_AR = x.IdCambioStatusAr,
                    ID_STATUS_AR_INI = x.IdStatusArIni,
                    ID_STATUS_AR_FIN = x.IdStatusArFin
                })
                .ToListAsync();
            return cambio;
        }

        public async Task<IEnumerable<Causas>> GetCausas()
        {
            List<Causas> causas = await context
                .CCausas
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new Causas { 
                    ID_CAUSA = x.IdCausa,
                    DESC_CAUSA = x.DescCausa,
                    DESCRIPCION = x.Descripcion
                })
                .ToListAsync();
            return causas;
        }

        public async Task<IEnumerable<Conectividades>> GetConectividades()
        {
            List<Conectividades> conectividades = await context
                .CConectividad
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new Conectividades { ID_CONECTIVIDAD = x.IdConectividad, DESC_CONECTIVIDAD = x.DescConectividad, IS_GPRS = x.IsGprs == null ? 0 : x.IsGprs})
                .ToListAsync();
            return conectividades;
        }

        public async Task<IEnumerable<Fallas>> GetFallas()
        {
            List<Fallas> fallas = await context
                .CFallas.Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new Fallas { ID_FALLA = x.IdFalla, DESC_FALLA = x.DescFalla })
                .ToListAsync();
            return fallas;
        }

        public async Task<IEnumerable<Marcas>> GetMarcas()
        {
            List<Marcas> marcas = await context
                .CMarcas.Where(x => x.Status == "ACTIVO")
                .Select(x => new Marcas { ID_MARCA = x.IdMarca, DESC_MARCA = x.DescMarca})
                .ToListAsync();
            return marcas;
        }

        public async Task<IEnumerable<Modelos>> GetModelos()
        {
            List<Modelos> modelos = await context
                .CModelos
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new Modelos { ID_MODELO = x.IdModelo, DESC_MODELO = x.DescModelo, ID_MARCA = x.IdMarca })
                .ToListAsync();
            return modelos;
        }

        public async Task<IEnumerable<MovimientoInventarioServicioFalla>> GetMovimientoInventarioServicioFallas()
        {
            List<MovimientoInventarioServicioFalla> movs = await context
                .BdValMovimientosInvServicioFalla
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new MovimientoInventarioServicioFalla { ID_VAL_MOVIMIENTOS_INV_SERVICIO_FALLA = x.IdValMovimientosInvServicioFalla, ID_SERVICIO = x.IdServicio, ID_FALLA = x.IdFalla, ID_MOV_INVENTARIO = x.IdMovInventario, STATUS = x.Status})
                .ToListAsync();
            return movs;
        }

        public async Task<IEnumerable<Servicios>> GetServicios()
        {
            List<Servicios> servicios = await context
                .CServicios
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new Servicios { ID_SERVICIO = x.IdServicio, DESC_SERVICIO = x.DescServicio })
                .ToListAsync();
            return servicios;
        }

        public async Task<IEnumerable<Software>> GetSoftwares()
        {
            List<Software> softwares = await context
                .CSoftware
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new Software { ID_APLICATIVO = x.IdSoftware, DESC_APLICATIVO = x.DescSoftware })
                .ToListAsync();
            return softwares;
        }

        public async Task<IEnumerable<StatusAr>> GetStatusAr()
        {
            List<StatusAr> status = await context
                .CStatusAr
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new StatusAr { ID_STATUS_AR = x.IdStatusAr, DESC_STATUS_AR = x.DescStatusAr })
                .ToListAsync();
            return status;
        }

        public async Task<IEnumerable<Subrechazos>> GetSubrechazos()
        {
            List<Subrechazos> subs = await context
                .CSubrechazo
                .Where(x => x.Status == "ACTIVO")
                .Select(X => new Subrechazos { ID_SUBRECHAZO = X.IdSubrechazo, SUBRECHAZO = X.Subrechazo, ID = X.Id })
                .ToListAsync();
            return subs;
        }
       
        public async Task<IEnumerable<Causasrechazos>> GetCausasrechazos()
        {
            List<Causasrechazos> causas = await context
                .CCausasRechazo
                .Where(x => x.Status == "ACTIVO" && x.IdCliente == 4)
                .Select(x => new Causasrechazos { ID_CAUSA_RECHAZO = x.IdCausaRechazo, DESC_CAUSA_RECHAZO = x.DescCausaRechazo.Replace("\r\n", string.Empty), ID_TRECHAZO = x.IdTrechazo })
                .ToListAsync();
            return causas;
        }

        public async Task<IEnumerable<Unidades>> GetUnidades(int idusuario)
        {
            List<int> status = new List<int>();
            status.Add(13);
            status.Add(15);
            List<Unidades> unidades = await context
                .BdUnidades
                .Where(x => status.Contains(x.IdStatusUnidad) && x.Status == "ACTIVO" && x.IdResponsable == idusuario && x.IdTipoResponsable == 2 && x.IdCliente == 4)
                .Select(x => new Unidades { 
                    ID_UNIDAD = x.IdUnidad, 
                    ID_APLICATIVO = x.IdAplicativo, 
                    ID_CONECTIVIDAD = x.IdConectividad, 
                    ID_MARCA = x.IdMarca, 
                    ID_MODELO = x.IdModelo, 
                    NO_SERIE = x.NoSerie.Trim(),
                    ID_STATUS_UNIDAD = x.IdStatusUnidad,
                    IS_NUEVA = x.IsNueva,
                    DESC_STATUS_UNIDAD = (context.CStatusUnidad.Where(s => s.IdStatusUnidad == x.IdStatusUnidad && s.Status == "ACTIVO").Select(s => s.DescStatusUnidad).FirstOrDefault()),
                    ID_TIPO_RESPONSABLE = x.IdTipoResponsable,
                    ID_RESPONSABLE = x.IdResponsable
                })
                .ToListAsync();
            return unidades;
        }

        public async Task<IEnumerable<BdModelosConectividades>> GetModeloConectividad()
        {
            List<BdModelosConectividades> modelosConectividades = await context
                .BdModeloConectividad
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new BdModelosConectividades
                {
                    ID_MODELO_CONECTIVIDAD = x.IdModeloConectividad,
                    ID_MODELO = x.IdModelo,
                    ID_CONECTIVIDAD = x.IdConectividad
                })
                .ToListAsync();
            return modelosConectividades;
        }

        public async Task<IEnumerable<Unidades>> GetUnidadesNegocio(int idusuario)
        {
            List<int> idstatusar = new List<int> { 6, 7, 8 };
            var negocios = await context.BdAr.Where(x => x.IdTecnico == idusuario && !idstatusar.Contains(x.IdStatusAr)).Select(x => x.IdNegocio == null ? 0 : x.IdNegocio).ToListAsync();
            List<Unidades> unidadesNegocio = await context.BdUnidades.Where(x => x.IdTipoResponsable == 4 && x.IdStatusUnidad == 17 && negocios.Contains(x.IdResponsable)).Select(x => new Unidades 
            {
                ID_UNIDAD = x.IdUnidad,
                ID_MODELO = x.IdModelo,
                ID_MARCA = x.IdMarca,
                ID_CONECTIVIDAD = x.IdConectividad,
                ID_APLICATIVO = x.IdAplicativo,
                ID_STATUS_UNIDAD = x.IdStatusUnidad,
                IS_NUEVA = x.IsNueva,
                NO_SERIE = x.NoSerie,
                DESC_STATUS_UNIDAD = (context.CStatusUnidad.Where(s => s.IdStatusUnidad == x.IdStatusUnidad && s.Status == "ACTIVO").Select(s => s.DescStatusUnidad).FirstOrDefault()),
                ID_TIPO_RESPONSABLE = x.IdTipoResponsable,
                ID_RESPONSABLE = x.IdResponsable
            }).ToListAsync();
            return unidadesNegocio;
        }
        public async Task<IEnumerable<ReglasModelos>> GetReglasModelos()
        {
            List<ReglasModelos> reglas = await context.BdReglasModelos
                .Where(x => x.Status == "ACTIVO")
                .Select(x => new ReglasModelos { 
                    ID_REGLAS = x.IdReglas,
                    ID_MODELO = x.IdModelo,
                    LETRAS_MIN = x.LetrasMin,
                    LETRAS_MAX = x.LetrasMax,
                    NUMERO_MIN = x.NumeroMin,
                    NUMERO_MAX = x.NumeroMax,
                    LONG_MIN = x.LongMin,
                    LONG_MAX = x.LongMax
                }).ToListAsync();
            return reglas;
        }
    }
}
