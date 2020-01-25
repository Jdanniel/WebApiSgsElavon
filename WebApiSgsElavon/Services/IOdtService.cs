using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiSgsElavon.Entities;
using WebApiSgsElavon.Entities.Requests;
using WebApiSgsElavon.ModelsTest;

namespace WebApiSgsElavon.Services
{
    public interface IOdtService
    {
        totalODT totalODTS(int idusuario);
        Task<IEnumerable<ODT>> getOdts(int idusuario);
        Task<string> GetNewOdts(int idusuario);
        Task<int> UpdateStatusAr(UpdateStatusBdArRequest model);
        int AgregarComentario(AgregarComentarioRequest request);
        Task<IEnumerable<ODT>> GetNuevasOdts(GetNuevasOdts request);
        int AceptarRechazarOdt(AceptarRechazarOdtRequest request);
        Task<IEnumerable<OdtEvent2>> prueba2();
        string cierreInstalacion(CierreInstalacionRequest request);
        string CierreSustitucion(SustitucionesRequest request);
        string CierreSustitucionSim(SustitucionesSimRequest request);
        string CierreRetiro(CierresRetiroRequest request);
        string CierreSinMovInventario(CierreSinMovInventarioRequest request);
        bool CierreRechazo(CierreRechazoRequest request);
        Task<ODT> GetOdtbyId(int idAr);
    }

    public class OdtServices : IOdtService
    {
        private readonly ELAVONTESTContext _context;

        public OdtServices(ELAVONTESTContext context)
        {
            _context = context;
        }

        public totalODT totalODTS(int idusuario)
        {
            int tnuevas = _context.BdAr
                .Where(x => x.IdTecnico == idusuario && x.IdStatusAr == 3 && x.Status == "PROCESADO")
                .Count();
            return new totalODT
            {
                nuevas = tnuevas
            };
        }
        public async Task<IEnumerable<ODT>> getOdts(int idusuario)
        {

            List < ODT > odt = await _context.Query<ODT>().FromSql("SELECT ID_AR, BD_NEGOCIOS.ID_NEGOCIO, NO_AR AS NO_ODT, " +
                "BD_NEGOCIOS.DESC_NEGOCIO, " +
                "BD_NEGOCIOS.NO_AFILIACION, " +
                "BD_NEGOCIOS.ESTADO, " +
                "BD_NEGOCIOS.COLONIA, " +
                "BD_NEGOCIOS.POBLACION, " +
                "BD_NEGOCIOS.DIRECCION, " +
                "CONVERT(VARCHAR,FEC_GARANTIA,103) +' '+ CONVERT(VARCHAR,FEC_GARANTIA,108) AS FEC_GARANTIA, " +
                "CONVERT(VARCHAR,FEC_ATENCION,103) +' '+ CONVERT(VARCHAR,FEC_ATENCION,108) AS FEC_ATENCION, " +
                "BD_NEGOCIOS.LATITUD, " +
                "BD_NEGOCIOS.LONGITUD, " +
                "CONVERT(INT,DAY(FEC_ATENCION)) AS [DAYS], " +
                "CONVERT(INT,MONTH(FEC_ATENCION)) AS [MONTHS], " +
                "CONVERT(INT,YEAR(FEC_ATENCION)) AS [YEARS], " +
                "BD_AR.ID_TIPO_SERVICIO, " +
                "ROW_NUMBER() OVER(ORDER BY FEC_ATENCION ASC) AS NUMBER, " +
                "BD_AR.ID_STATUS_AR, " +
                "BD_AR.ID_SERVICIO, " +
                "BD_AR.ID_FALLA, " +
                "(SELECT DESC_STATUS_AR FROM C_STATUS_AR SS " +
                "WHERE SS.ID_STATUS_AR = BD_AR.ID_STATUS_AR) " +
                "AS DESC_STATUS_AR " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR IN(3,4,5,6,7,13,35) AND BD_AR.STATUS='PROCESADO'" +
                " ORDER BY BD_AR.FEC_ATENCION ASC", idusuario).ToListAsync();

            //var totalYears = odt.GroupBy(x => x.AA).Count();

            return odt;
        }
        public async Task<int> UpdateStatusAr(UpdateStatusBdArRequest model)
        {
            try
            {
                var ar = await _context.BdAr.Where(x => x.IdAr == model.ID_AR && x.IdStatusAr != model.ID_STATUS_AR_P).FirstOrDefaultAsync();
                
                if (ar == null) return 2;

                ar.IdStatusAr = model.ID_STATUS_AR_P;
                _context.SaveChanges();
                BdBitacoraAr bitacora = new BdBitacoraAr()
                {
                    IdAr = model.ID_AR,
                    IdStatusArIni = model.ID_STATUS_AR_A,
                    IdStatusArFin = model.ID_STATUS_AR_P,
                    Comentario = "Solicitud actualizada por aplicacion movil",
                    IsCambioValido = 1,
                    IsPda = 1,
                    IdUsuarioAlta = model.ID_USUARIO,
                    FecAlta = DateTime.Now
                };
                _context.BdBitacoraAr.Add(bitacora);
                _context.SaveChanges();
                return 1;
            }catch(SqlException ex)
            {
                return 0;
            }

        }
        public async Task<string> GetNewOdts(int idusuario)
        {
            List<ODT> odts = await _context.Query<ODT>().FromSql("SELECT ID_AR, BD_NEGOCIOS.ID_NEGOCIO, NO_AR AS NO_ODT, " +
                "BD_NEGOCIOS.DESC_NEGOCIO, " +
                "BD_NEGOCIOS.NO_AFILIACION, " +
                "BD_NEGOCIOS.ESTADO, " +
                "BD_NEGOCIOS.COLONIA, " +
                "BD_NEGOCIOS.POBLACION, " +
                "BD_NEGOCIOS.DIRECCION, " +
                "CONVERT(VARCHAR,FEC_GARANTIA,103) +' '+ CONVERT(VARCHAR,FEC_GARANTIA,108) AS FEC_GARANTIA, " +
                "CONVERT(VARCHAR,FEC_ATENCION,103) +' '+ CONVERT(VARCHAR,FEC_ATENCION,108) AS FEC_ATENCION, " +
                "BD_NEGOCIOS.LATITUD, " +
                "BD_NEGOCIOS.LONGITUD, " +
                "CONVERT(INT,DAY(FEC_ATENCION)) AS [DAYS], " +
                "CONVERT(INT,MONTH(FEC_ATENCION)) AS [MONTHS], " +
                "CONVERT(INT,YEAR(FEC_ATENCION)) AS [YEARS], " +
                "BD_AR.ID_TIPO_SERVICIO, " +
                "ROW_NUMBER() OVER(ORDER BY FEC_GARANTIA ASC) AS NUMBER " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR = 3 AND BD_AR.STATUS='PROCESADO'" +
                " ORDER BY BD_AR.FEC_ATENCION ASC", idusuario).ToListAsync();

            OdtEvent evento;
            var years = odts.GroupBy(x => new { x.YEARS}).Select(x => x.Key);

            foreach (var element in odts)
            {
                evento = new OdtEvent
                {
                    year = element.YEARS
                };
            }

            return "";

        }
        public int AgregarComentario(AgregarComentarioRequest request)
        {
            try
            {
                BdComentarioAr ar = new BdComentarioAr()
                {
                    IdAr = request.ID_AR,
                    DescComentarioAr = request.COMENTARIO,
                    IdUsuarioAlta = request.ID_USUARIO,
                    FecAlta = DateTime.Now
                };
                _context.BdComentarioAr.Add(ar);
                _context.SaveChanges();
                return 1;
            }
            catch (SqlException ex)
            {
                return 0;
            }

        }
        public async Task<IEnumerable<OdtEvent>> prueba()
        {
            List<OdtEvent> eventos = new List<OdtEvent>();

            List<ODT> odts = await _context.Query<ODT>().FromSql("SELECT ID_AR, BD_NEGOCIOS.ID_NEGOCIO, NO_AR AS NO_ODT, " +
                "BD_NEGOCIOS.DESC_NEGOCIO, " +
                "BD_NEGOCIOS.NO_AFILIACION, " +
                "BD_NEGOCIOS.ESTADO, " +
                "BD_NEGOCIOS.COLONIA, " +
                "BD_NEGOCIOS.POBLACION, " +
                "BD_NEGOCIOS.DIRECCION, " +
                "CONVERT(VARCHAR,FEC_GARANTIA,103) +' '+ CONVERT(VARCHAR,FEC_GARANTIA,108) AS FEC_GARANTIA, " +
                "CONVERT(VARCHAR,FEC_ATENCION,103) +' '+ CONVERT(VARCHAR,FEC_ATENCION,108) AS FEC_ATENCION, " +
                "BD_NEGOCIOS.LATITUD, " +
                "BD_NEGOCIOS.LONGITUD, " +
                "CONVERT(INT,DAY(FEC_GARANTIA)) AS [DAYS], " +
                "CONVERT(INT,MONTH(FEC_GARANTIA)) AS [MONTHS], " +
                "CONVERT(INT,YEAR(FEC_GARANTIA)) AS [YEARS], " +
                "BD_AR.ID_TIPO_SERVICIO, " +
                "ROW_NUMBER() OVER(ORDER BY FEC_GARANTIA ASC) AS NUMBER, " +
                "BD_AR.ID_STATUS_AR, " +
                "BD_AR.ID_SERVICIO, " +
                "BD_AR.ID_FALLA " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR IN(3,4,5,6,7,13) AND BD_AR.STATUS='PROCESADO'" +
                " ORDER BY BD_AR.FEC_GARANTIA ASC", 34).ToListAsync();

            var years = odts.GroupBy(x => new { x.YEARS }).Select(x => x.Key).ToList();
            var yMonth = odts.GroupBy(x => new { x.YEARS, x.MONTHS }).Select(x => x.Key).ToList();

            for (int i = 0; i < years.Count(); i++)
            {
                OdtEvent evento = new OdtEvent();
                evento.year = years[i].YEARS;
                eventos.Add(evento);
            }

            OdtEvent evento1 = new OdtEvent();
            evento1.year = 2020;
            eventos.Add(evento1);



            var totalA = eventos.Count();

            for (int i = 0; i < totalA; i++)
            {
                List<OdtGroup> groups = new List<OdtGroup>();

                for (int x = 0; x < yMonth.Count(); x++)
                {
                    List<OdtDetalle> detalles = new List<OdtDetalle>();

                    OdtGroup group = new OdtGroup();
                    group.month = yMonth[x].MONTHS;
                    groups.Add(group);
                    if(eventos[i].year == yMonth[x].YEARS)
                    {
                        eventos[i].odtGroup = groups;
                        
                        var o = odts.Where(a => a.YEARS == yMonth[x].YEARS && a.MONTHS == yMonth[x].MONTHS).ToList();
                        for (int y = 0; y < o.Count(); y++)
                        {
                            OdtDetalle detalle = new OdtDetalle();
                            detalle.AA = o[y].YEARS;
                            detalle.MES = o[y].MONTHS;
                            detalle.DIA = o[y].DAYS;
                            detalle.NO_ODT = o[y].NO_ODT;
                            detalle.NO_AFILIACION = o[y].NO_AFILIACION;
                            detalle.NEGOCIO = o[y].DESC_NEGOCIO;
                            detalle.ID_AR = o[y].ID_AR;
                            detalle.ESTADO = o[y].ESTADO;
                            detalles.Add(detalle);
                        }
                        eventos[i].odtGroup[x].odtDetalle = detalles;
                        
                    }
                }
            }

            return eventos;
        }
        public async Task<IEnumerable<OdtEvent2>> prueba2()
        {
            List<OdtEvent2> eventos = new List<OdtEvent2>();

            List<ODT> odts = await _context.Query<ODT>().FromSql("SELECT ID_AR, BD_NEGOCIOS.ID_NEGOCIO, NO_AR AS NO_ODT, " +
                "BD_NEGOCIOS.DESC_NEGOCIO, " +
                "BD_NEGOCIOS.NO_AFILIACION, " +
                "BD_NEGOCIOS.ESTADO, " +
                "BD_NEGOCIOS.COLONIA, " +
                "BD_NEGOCIOS.POBLACION, " +
                "BD_NEGOCIOS.DIRECCION, " +
                "CONVERT(VARCHAR,FEC_GARANTIA,103) +' '+ CONVERT(VARCHAR,FEC_GARANTIA,108) AS FEC_GARANTIA, " +
                "CONVERT(VARCHAR,FEC_ATENCION,103) +' '+ CONVERT(VARCHAR,FEC_ATENCION,108) AS FEC_ATENCION, " +
                "BD_NEGOCIOS.LATITUD, " +
                "BD_NEGOCIOS.LONGITUD, " +
                "CONVERT(INT,DAY(FEC_GARANTIA)) AS [DAYS], " +
                "CONVERT(INT,MONTH(FEC_GARANTIA)) AS [MONTHS], " +
                "CONVERT(INT,YEAR(FEC_GARANTIA)) AS [YEARS], " +
                "BD_AR.ID_TIPO_SERVICIO, " +
                "ROW_NUMBER() OVER(ORDER BY FEC_GARANTIA ASC) AS NUMBER, " +
                "BD_AR.ID_STATUS_AR, " +
                "BD_AR.ID_SERVICIO, " +
                "BD_AR.ID_FALLA " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR IN(3,4,5,6,7,13) AND BD_AR.STATUS='PROCESADO'" +
                " ORDER BY BD_AR.FEC_GARANTIA ASC", 34).ToListAsync();

            var years = odts.GroupBy(x => new { x.YEARS }).Select(x => x.Key).ToList();
            var yMonth = odts.GroupBy(x => new { x.YEARS, x.MONTHS }).Select(x => x.Key).ToList();

            for (int i = 0; i < years.Count(); i++)
            {
                OdtEvent2 evento = new OdtEvent2();
                evento.year = years[i].YEARS;
                for (int x = 0; x < yMonth.Count(); x++)
                {
                    //List<int> meses = new List<int>();
                    if(years[i].YEARS == yMonth[x].YEARS)
                    {
                        List<OdtDetalle2> detalles = new List<OdtDetalle2>();
                        //meses.Add(yMonth[x].MONTHS);
                        evento.month = yMonth[x].MONTHS;
                        var o = odts.Where(a => a.YEARS == yMonth[x].YEARS && a.MONTHS == yMonth[x].MONTHS).ToList();
                        for (int y = 0; y < o.Count(); y++)
                        {
                            OdtDetalle2 detalle = new OdtDetalle2();
                            detalle.AA = o[y].YEARS;
                            detalle.MES = o[y].MONTHS;
                            detalle.DIA = o[y].DAYS;
                            detalle.NO_ODT = o[y].NO_ODT;
                            detalle.NO_AFILIACION = o[y].NO_AFILIACION;
                            detalle.NEGOCIO = o[y].DESC_NEGOCIO;
                            detalle.ID_AR = o[y].ID_AR;
                            detalle.ESTADO = o[y].ESTADO;
                            detalles.Add(detalle);
                        }
                        evento.odtDetalle = detalles;
                    }
                    //evento.month = meses;
                }
                eventos.Add(evento);
            }
            return eventos;
        }
        public async Task<IEnumerable<ODT>> GetNuevasOdts(GetNuevasOdts request)
        {
            List<ODT> odts;
            var parametros = new []{
                new SqlParameter("@p0", System.Data.SqlDbType.Int){Value = request.ID_USUARIO},
                new SqlParameter("@p1", System.Data.SqlDbType.VarChar,50){ Value = request.FEC_UPDATE}
            };
            try {
                odts = await _context
                    .Query<ODT>()
                    .FromSql("SELECT ID_AR, BD_NEGOCIOS.ID_NEGOCIO, NO_AR AS NO_ODT, " +
                    "BD_NEGOCIOS.DESC_NEGOCIO, " +
                    "BD_NEGOCIOS.NO_AFILIACION, " +
                    "BD_NEGOCIOS.ESTADO, " +
                    "BD_NEGOCIOS.COLONIA, " +
                    "BD_NEGOCIOS.POBLACION, " +
                    "BD_NEGOCIOS.DIRECCION, " +
                    "CONVERT(VARCHAR,FEC_GARANTIA,103) +' '+ CONVERT(VARCHAR,FEC_GARANTIA,108) AS FEC_GARANTIA, " +
                    "CONVERT(VARCHAR,FEC_ATENCION,103) +' '+ CONVERT(VARCHAR,FEC_ATENCION,108) AS FEC_ATENCION, " +
                    "BD_NEGOCIOS.LATITUD, " +
                    "BD_NEGOCIOS.LONGITUD, " +
                    "CONVERT(INT,DAY(FEC_ATENCION)) AS [DAYS], " +
                    "CONVERT(INT,MONTH(FEC_ATENCION)) AS [MONTHS], " +
                    "CONVERT(INT,YEAR(FEC_ATENCION)) AS [YEARS], " +
                    "BD_AR.ID_TIPO_SERVICIO, " +
                    "ROW_NUMBER() OVER(ORDER BY FEC_GARANTIA ASC) AS NUMBER, " +
                    "BD_AR.ID_STATUS_AR, " +
                    "BD_AR.ID_SERVICIO, " +
                    "BD_AR.ID_FALLA, " +
                    "(SELECT DESC_STATUS_AR FROM C_STATUS_AR SS " +
                    "WHERE SS.ID_STATUS_AR = BD_AR.ID_STATUS_AR) " +
                    "AS DESC_STATUS_AR " +
                    "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                    "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                    "WHERE ID_TECNICO = @p0 " +
                    "AND ID_STATUS_AR IN(3,4,5,6,7,13,35) " +
                    "AND BD_AR.STATUS='PROCESADO' " +
                    "AND BD_AR.FEC_ALTA > @p1" +
                    " ORDER BY BD_AR.FEC_ATENCION ASC", parametros)
                    .ToListAsync();
                return odts;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }
        public bool CierreRechazo(CierreRechazoRequest request)
        {
            if(request != null)
            {
                int idAr = request.ID_AR;
                var odt = _context.BdAr.Where(x => x.IdAr == idAr).FirstOrDefault();
                int? idstatusini = odt.IdStatusAr;
                try
                {
                    BdBitacoraAr bitacora = new BdBitacoraAr()
                    {
                        IdAr = idAr,
                        IdStatusArIni = odt.IdStatusAr,
                        IdStatusArFin = 7,
                        Comentario = "Solicitud de Servicio Rechazada desde Aplicacion Movil",
                        IsPda = 0,
                        IdUsuarioAlta = request.ID_TECNICO,
                        FecAlta = DateTime.Now
                    };
                    _context.BdBitacoraAr.Add(bitacora);
                    _context.SaveChanges();

                    odt.FecCierre = Convert.ToDateTime(request.FEC_CIERRE);
                    odt.IdCausaRechazo = (_context.CCausasRechazo.Where(x => x.Status == "ACTIVO" && x.IdCliente == 4 && x.DescCausaRechazo == request.CAUSA_RECHAZO).Select(x => x.IdTrechazo).FirstOrDefault());
                    odt.CausaRechazo = (_context.CSubrechazo.Where(x => x.Status == "ACTIVO" && x.Subrechazo == request.SUBRECHAZO).Select(x => x.Id).FirstOrDefault()).ToString();
                    odt.IdSolucion = (_context.CSoluciones.Where(x => x.IdCliente == 4 && x.Status == "ACTIVO" && x.DescSolucion == request.TIPO_ATENCION).Select(x => x.IdSolucion).FirstOrDefault());
                    odt.IdTecnico = request.ID_TECNICO;
                    odt.Atiende = request.ATIENDE;
                    odt.DescripcionTrabajo = request.CONCLUSIONES;
                    odt.IdStatusAr = 7;
                    odt.CadenaCierre += "DESC. DEL TRABAJO: " + request.CONCLUSIONES 
                        + " FECHA: " + Convert.ToDateTime(request.FEC_CIERRE) 
                        + " CAUSA RECHAZO: " + request.CAUSA_RECHAZO 
                        + " SUBCATEGORIA CAUSA DE RECHAZO: " + request.SUBRECHAZO 
                        + " AUTORIZO RECHAZO: " + request.ATIENDE;
                    _context.SaveChanges();

                    insertBitacoraAr(request.ID_AR, request.ID_TECNICO, idstatusini, 7, "Rechazado Aplicación");

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public int AceptarRechazarOdt(AceptarRechazarOdtRequest request)
        {
            var odt = _context.BdAr.Where(x => x.IdAr == request.ID_AR).FirstOrDefault();
            int? idstatusini = odt.IdStatusAr;
            try
            {
                if (request.ID_STATUS_AR == 35)
                {
                    odt.IdStatusAr = 35;
                    insertBitacoraAr(request.ID_AR, request.ID_TECNICO, idstatusini, 35, "Aceptado por tecnico");
                    _context.SaveChanges();
                }
                else if (request.ID_STATUS_AR == 36)
                {
                    odt.IdStatusAr = 36;
                    odt.IdTecnico = 0;
                    insertBitacoraAr(request.ID_AR, request.ID_TECNICO, idstatusini, 36, "Rechazado por tecnico");
                    _context.SaveChanges();
                }
                return 1;
            }
            catch (SqlException ex)
            {
                return 0;
            }

        }
        public string CierreRetiro(CierresRetiroRequest request)
        {
            if(request != null)
            {
                try
                {
                    int ID_AR = request.ID_AR;
                    int ID_TECNICO = request.ID_TECNICO;
                    var bdar = _context.BdAr.Where(x => x.IdAr == ID_AR).FirstOrDefault();
                    int? idstatusini = bdar.IdStatusAr;
                    var bdunidadRetirada = _context.BdUnidades.Where(x => x.NoSerie == request.NO_SERIE.Trim()).FirstOrDefault();
                    int idconectividadretirada = _context.CConectividad.Where(x => x.DescConectividad == request.CONECTIVIDAD.Trim()).Select(x => x.IdConectividad).FirstOrDefault();
                    int isgprs = _context.CConectividad.Where(x => x.DescConectividad == request.CONECTIVIDAD.Trim()).Select(x => x.IsGprs == null ? 0 : 1).FirstOrDefault();
                    int idaplicativoretirada = _context.CSoftware.Where(x => x.DescSoftware == request.APLICATIVO.Trim()).Select(x => x.IdSoftware).FirstOrDefault();
                    int idmarcaretiro = _context.CMarcas.Where(x => x.DescMarca == request.MARCA.Trim()).Select(x => x.IdMarca).FirstOrDefault();
                    int idmodeloretiro = _context.CModelos.Where(x => x.DescModelo == request.MODELO.Trim()).Select(x => x.IdModelo).FirstOrDefault();
                    int? idstatusunidadiniretirar = null;
                    int idunidadretirar = 0;
                    /*Reglas de validacion por modelo*/
                    if (bdunidadRetirada == null)
                    {
                        var bdunidadretiradaUniverso = _context.BdUniversoUnidades.Where(x => x.NoSerie == request.NO_SERIE.Trim()).FirstOrDefault();
                        
                        if(bdunidadretiradaUniverso != null)
                        {
                            BdUnidades unidad = new BdUnidades()
                            {
                                NoSerie = request.NO_SERIE,
                                IdCliente = 4,
                                IdModelo = idmodeloretiro,
                                IdMarca = idmarcaretiro,
                                IdAplicativo = idaplicativoretirada,
                                IdConectividad = idconectividadretirada,
                                Status = "ACTIVO",
                                IdStatusUnidad = 30,
                                IdTipoResponsable = 2,
                                IdResponsable = request.ID_TECNICO
                            };
                            _context.BdUnidades.Add(unidad);
                            _context.SaveChanges();
                            idunidadretirar = unidad.IdUnidad;
                        }
                        else
                        {
                            return "El número de serie no existe en el sistema";
                        }
                    }
                    else
                    {
                        idstatusunidadiniretirar = bdunidadRetirada.IdStatusUnidad;
                        idunidadretirar = bdunidadRetirada.IdUnidad;

                        bdunidadRetirada.IdConectividad = idconectividadretirada;
                        bdunidadRetirada.IdAplicativo = idaplicativoretirada;
                        bdunidadRetirada.IdMarca = idmarcaretiro;
                        bdunidadRetirada.IdModelo = idmodeloretiro;
                        bdunidadRetirada.IdTipoResponsable = 2;
                        bdunidadRetirada.IdTipoResponsable = request.ID_TECNICO;
                        bdunidadRetirada.IdStatusUnidad = 30;
                        _context.SaveChanges();
                    }

                    BdBitacoraUnidad bitacoraUnidad = new BdBitacoraUnidad()
                    {
                        IdStatusUnidadIni = idstatusunidadiniretirar,
                        IdStatusUnidadFin = 15,
                        IdUnidad = idunidadretirar,
                        IdTipoResponsable = 2,
                        IdResponsable = ID_TECNICO,
                        IdUsuarioAlta = ID_TECNICO,
                        FecAlta = DateTime.Now
                    };
                    _context.BdBitacoraUnidad.Add(bitacoraUnidad);
                    _context.SaveChanges();

                    BdRetiros retiros = new BdRetiros()
                    {
                        IdAr = ID_AR,
                        IdTecnico = ID_TECNICO,
                        IdNegocio = bdar.IdNegocio,
                        IdUnidad = bdunidadRetirada.IdUnidad,
                        IsDaniada = 0,
                        IsNueva = 0,
                        IdUsuarioAlta = ID_TECNICO,
                        FecAlta = DateTime.Now
                    };
                    _context.BdRetiros.Add(retiros);
                    _context.SaveChanges();

                    if(isgprs == 1)
                    {
                        int idSim;

                        if (request.NO_SIM != null)
                        {
                            var simretiro = _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM && x.IdMarca == 10).FirstOrDefault();

                            if (simretiro == null)
                            {
                                var simretirouniverso = _context.BdUniversoSims.Where(x => x.Sim == request.NO_SIM).FirstOrDefault();
                                if(simretirouniverso!= null)
                                {
                                    BdUnidades sim = new BdUnidades()
                                    {
                                        IdCliente = 4,
                                        NoSerie = request.NO_SIM,
                                        IdStatusUnidad = 30,
                                        IdTipoResponsable = 2,
                                        IdResponsable = request.ID_TECNICO,
                                        Status = "ACTIVO"
                                    };
                                    _context.BdUnidades.Add(sim);
                                    _context.SaveChanges();
                                    idSim = sim.IdUnidad;
                                }
                                else
                                {
                                    return "El numero de sim no existe en el sistema";
                                }
                            }
                            else
                            {
                                simretiro.IdStatusUnidad = 30;
                                simretiro.IdTipoResponsable = 2;
                                simretiro.IdResponsable = request.ID_TECNICO;
                                _context.SaveChanges();
                                idSim = simretiro.IdUnidad;
                            }

                            BdRetiros retirosSim = new BdRetiros()
                            {
                                IdAr = ID_AR,
                                IdTecnico = ID_TECNICO,
                                IdNegocio = bdar.IdNegocio,
                                IdUnidad = idSim,
                                IsDaniada = 0,
                                IsNueva = 0,
                                IdUsuarioAlta = ID_TECNICO,
                                FecAlta = DateTime.Now
                            };
                            _context.BdRetiros.Add(retirosSim);
                            _context.SaveChanges();
                        }
                    }

                    bdar.Atiende = request.ATIENDE;
                    bdar.IdSolucion = 9;
                    bdar.IsExito = 1;
                    bdar.IsRetiro = 1;
                    bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                    bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                    bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                    bdar.NoEquipo = request.VERSION;
                    bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                    bdar.DigitoVerificador = request.DISCOVER.ToString();
                    bdar.Caja = request.CAJA.ToString();
                    bdar.DescripcionTrabajo = request.COMENTARIO;
                    bdar.FecCierre = Convert.ToDateTime(request.FECHA_CIERRE);
                    bdar.IdStatusAr = 6;
                    bdar.CadenaCierre = CrearCadenaCierre(
                    request.APLICATIVO,
                    request.VERSION,
                    request.CAJA,
                    request.ROLLOS,
                    request.BATERIA,
                    request.ELIMINADOR,
                    request.TAPA,
                    request.CABLE_AC,
                    false,
                    "",
                    "",
                    "",
                    request.COMENTARIO);
                    _context.SaveChanges();

                    insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Retiro Aplicación");

                    BdArAccesorios accesoriosRetirados = new BdArAccesorios()
                    {
                        IdAr = ID_AR,
                        Bateria = (request.BATERIA ? "SI" : "NO"),
                        Eliminador = (request.ELIMINADOR ? "SI" : "NO"),
                        Base = (request.BASE ? "SI" : "NO"),
                        Tapa = (request.TAPA ? "SI" : "NO"),
                        CableAc = (request.CABLE_AC ? "SI" : "NO")
                    };

                    _context.BdArAccesorios.Add(accesoriosRetirados);
                    _context.SaveChanges();
                    return "OK";
                }
                catch (Exception ex)
                {
                    return "db";
                }
            }
            else
            {
                return "El modelo no puede estar vacio";
            }
        }
        public string cierreInstalacion(CierreInstalacionRequest request)
        {
            if(request != null)
            {
                List<int> idstatusar = new List<int>() { 6,7};
                var valArs = _context.BdAr.Where(x => x.IdAr == request.ID_AR && idstatusar.Contains(x.IdStatusAr)).Count();
                if (valArs > 0) return "La Odt ya esta Cerrada o Rechazada";
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        int ID_AR = request.ID_AR;
                        int ID_TECNICO = request.ID_TECNICO;

                        var bdar = _context.BdAr.Where(x => x.IdAr == ID_AR).FirstOrDefault();

                        int? idstatusini = bdar.IdStatusAr;

                        int idnegocio = _context
                            .BdNegocios
                            .Where(x => x.NoAfiliacion == bdar.NoAfiliacion && x.Status == "ACTIVO" && x.IdCliente == 4)
                            .Select(x => x.IdNegocio)
                            .FirstOrDefault();

                        var bdunidad = _context.BdUnidades.Where(x => x.NoSerie == request.NO_SERIE.Trim()).FirstOrDefault();

                        int idstatusunidadInstalar = bdunidad.IdStatusUnidad;
                        int idunidadInstalar = bdunidad.IdUnidad;

                        BdInstalaciones instalaciones = new BdInstalaciones()
                        {
                            IdAr = ID_AR,
                            IdTecnico = ID_TECNICO,
                            IdNegocio = bdar.IdNegocio,
                            IdUnidad = bdunidad.IdUnidad,
                            IsNueva = 0,
                            IdClienteIni = 4,
                            IdUsuarioAlta = ID_TECNICO,
                            FecAlta = DateTime.Now,
                        };
                        _context.BdInstalaciones.Add(instalaciones);
                        _context.SaveChanges();

                        int idconectividadinstalada = _context
                            .CConectividad
                            .Where(x => x.DescConectividad == request.CONECTIVIDAD && x.IdCliente == 4)
                            .Select(x => x.IdConectividad)
                            .FirstOrDefault();

                        int idaplicativoinstalado = _context
                            .CSoftware
                            .Where(x => x.DescSoftware == request.APLICATIVO && x.IdCliente == 4)
                            .Select(x => x.IdSoftware)
                            .FirstOrDefault();

                        bdunidad.IdConectividad = idconectividadinstalada;
                        bdunidad.IdAplicativo = idaplicativoinstalado;
                        bdunidad.IdStatusUnidad = 17;
                        bdunidad.IdTipoResponsable = 4;
                        bdunidad.IdResponsable = idnegocio;
                        bdunidad.IdSim = bdar.IdProveedor;
                        _context.SaveChanges();

                        var isgprs = _context.CConectividad.Where(x => x.IdConectividad == idconectividadinstalada).Select(x => x.IsGprs == null ? 0 : x.IsGprs).FirstOrDefault();

                        BdBitacoraUnidad bitacoraUnidad = new BdBitacoraUnidad()
                        {
                            IdStatusUnidadIni = idstatusunidadInstalar,
                            IdStatusUnidadFin = 17,
                            IdUnidad = idunidadInstalar,
                            IdTipoResponsable = 4,
                            IdResponsable = idnegocio,
                            IdUsuarioAlta = ID_TECNICO,
                            FecAlta = DateTime.Now
                        };
                        _context.BdBitacoraUnidad.Add(bitacoraUnidad);
                        _context.SaveChanges();

                        if (isgprs == 1)
                        {
                            if(request.NO_SIM != null)
                            {
                                var sim = _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM.Trim()).FirstOrDefault();
                                if (sim != null)
                                {
                                    int idstatussimInstalar = sim.IdStatusUnidad;
                                    int idsimInstalar = sim.IdUnidad;

                                    BdInstalaciones instalacionesSim = new BdInstalaciones()
                                    {
                                        IdAr = ID_AR,
                                        IdTecnico = ID_TECNICO,
                                        IdNegocio = bdar.IdNegocio,
                                        IdUnidad = sim.IdUnidad,
                                        IsNueva = 0,
                                        IdClienteIni = 4,
                                        IdUsuarioAlta = ID_TECNICO,
                                        FecAlta = DateTime.Now,
                                    };
                                    _context.BdInstalaciones.Add(instalacionesSim);
                                    _context.SaveChanges();

                                    sim.IdStatusUnidad = 17;
                                    sim.IdTipoResponsable = 4;
                                    sim.IdResponsable = idnegocio;
                                    sim.IdSim = bdar.IdProveedor;
                                    _context.SaveChanges();

                                    BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                    {
                                        IdStatusUnidadIni = idstatussimInstalar,
                                        IdStatusUnidadFin = 17,
                                        IdUnidad = idsimInstalar,
                                        IdTipoResponsable = 4,
                                        IdResponsable = idnegocio,
                                        IdUsuarioAlta = ID_TECNICO,
                                        FecAlta = DateTime.Now
                                    };
                                    _context.BdBitacoraUnidad.Add(bitacoraSim);
                                    _context.SaveChanges();
                                }
                            }
                            else
                            {
                                return "ID SIM no puede estar vacio cuando la conectividad es IS_GPRS";
                            }
                        }

                        string notificado = request.NOTIFICADO ? "SI" : "NO";
                        string promociones = request.PROMOCIONES ? "SI" : "NO";
                        string descargarApp = request.DESCARGA_APP ? "SI" : "NO";

                        bdar.NoInventario = request.VERSION;
                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.IsInstalacion = 1;
                        bdar.IsExito = 1;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        bdar.DigitoVerificador = request.DISCOVER.ToString();
                        bdar.Caja = request.CAJA.ToString();
                        bdar.DescripcionTrabajo = request.COMENTARIO;
                        bdar.FecCierre = Convert.ToDateTime(request.FECHA_CIERRE);
                        bdar.MiComercio = "COMERCIO NOTIFICADO: "
                                            + notificado
                                            + " / PROMOCIONES: "
                                            + promociones
                                            + " / SE BAJO APP: "
                                            + descargarApp
                                            + " / "
                                            + request.TELEFONO_1
                                            + " / "
                                            + request.TELEFONO_2;
                        bdar.CadenaCierre = CrearCadenaCierre(
                            request.APLICATIVO, 
                            request.VERSION, 
                            request.CAJA, 
                            request.ROLLOS, 
                            request.BATERIA, 
                            request.ELIMINADOR, 
                            request.TAPA, 
                            request.CABLE_AC, 
                            request.IS_AMEX, 
                            request.ID_AMEX, 
                            request.AFILIACION_AMEX, 
                            request.CONCLUSIONES_AMEX, 
                            request.COMENTARIO);
                        bdar.TerminalAmex = (request.IS_AMEX ? 1 : 0);
                        bdar.IdStatusAr = 6;
                        _context.SaveChanges();

                        insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Instalación Aplicación");

                        BdArMiComercio micomercio = new BdArMiComercio()
                        {
                            IdAr = ID_AR,
                            Notificado = request.NOTIFICADO ? 1 : 0,
                            Promociones = request.PROMOCIONES ? 1 : 0,
                            DescargarApp = request.DESCARGA_APP ? 1 : 0,
                            Telefono1 = request.TELEFONO_1,
                            Telefono2 = request.TELEFONO_2,
                            FecAlta = DateTime.Now
                        };
                        _context.BdArMiComercio.Add(micomercio);
                        _context.SaveChanges();

                        BdArAccesorios accesoriosInstalados = new BdArAccesorios()
                        {
                            IdAr = ID_AR,
                            Bateria = (request.BATERIA ? "SI" : "NO"),
                            Eliminador = (request.ELIMINADOR ? "SI" : "NO"),
                            Base = (request.BASE ? "SI" : "NO"),
                            Tapa = (request.TAPA ? "SI" : "NO"),
                            CableAc = (request.CABLE_AC ? "SI" : "NO")
                        };

                        _context.BdArAccesorios.Add(accesoriosInstalados);
                        _context.SaveChanges();

                        if (request.IS_AMEX)
                        {
                            BdArTerminalAsociadaAmex terminal = new BdArTerminalAsociadaAmex()
                            {
                                IdAr = request.ID_AR,
                                IdTerminalAmex = request.ID_AMEX,
                                AfiliacionTerminalAmex = request.AFILIACION_AMEX,
                                IdUsuarioAlta = ID_TECNICO,
                                FecAlta = DateTime.Now
                            };
                            _context.BdArTerminalAsociadaAmex.Add(terminal);
                            _context.SaveChanges();
                        }
                        transaction.Commit();
                        return "OK";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return "DB: " + ex.ToString();
                    }
                }

            }
            else
            {
                return "El modelo no puede estar vacio";
            }
        }
        public string CierreSinMovInventario(CierreSinMovInventarioRequest request)
        {
            if(request != null)
            {
                var ID_AR = request.ID_AR;
                List<int> idstatusar = new List<int>() { 6, 7 };
                var valArs = _context.BdAr.Where(x => x.IdAr == ID_AR && idstatusar.Contains(x.IdStatusAr)).Count();
                if (valArs > 0) return "La Odt ya esta Cerrada o Rechazada";

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        var bdar = _context.BdAr.Where(x => x.IdAr == ID_AR).FirstOrDefault();
                        
                        int? idstatusini = bdar.IdStatusAr;

                        string notificado = request.NOTIFICADO ? "SI" : "NO";
                        string promociones = request.PROMOCIONES ? "SI" : "NO";
                        string descargarApp = request.DESCARGA_APP ? "SI" : "NO";

                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        bdar.DigitoVerificador = request.DISCOVER.ToString();
                        bdar.Caja = request.CAJA.ToString();
                        bdar.DescripcionTrabajo = request.COMENTARIO;
                        bdar.FecCierre = Convert.ToDateTime(request.FECHA_CIERRE);
                        bdar.MiComercio = "COMERCIO NOTIFICADO: "
                                            + notificado
                                            + " / PROMOCIONES: "
                                            + promociones
                                            + " / SE BAJO APP: "
                                            + descargarApp
                                            + " / "
                                            + request.TELEFONO_1
                                            + " / "
                                            + request.TELEFONO_2;
                        bdar.CadenaCierre = CrearCadenaCierre(
                            "",
                            "",
                            request.CAJA,
                            request.ROLLOS,
                            false,
                            false,
                            false,
                            false,
                            false,
                            "",
                            "",
                            "",
                            request.COMENTARIO);
                        bdar.IdStatusAr = 6;
                        _context.SaveChanges();

                        insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Sin Movimiento de Inventario Aplicación");

                        BdArMiComercio micomercio = new BdArMiComercio()
                        {
                            IdAr = ID_AR,
                            Notificado = request.NOTIFICADO ? 1 : 0,
                            Promociones = request.PROMOCIONES ? 1 : 0,
                            DescargarApp = request.DESCARGA_APP ? 1 : 0,
                            Telefono1 = request.TELEFONO_1,
                            Telefono2 = request.TELEFONO_2,
                            FecAlta = DateTime.Now
                        };
                        _context.BdArMiComercio.Add(micomercio);
                        _context.SaveChanges();
                        transaction.Commit();
                        return "OK";
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        return "DB: " + ex.ToString();
                    }
                }
            }
            else
            {
                return "El modelo no puede estar vacio";
            }

        }
        public string CierreSustitucion(SustitucionesRequest request)
        {
            if(request != null)
            {
                try
                {
                    /*INFORMACION DEL AR*/
                    int ID_AR = request.ID_AR;
                    int ID_TECNICO = request.ID_TECNICO;
                    var bdar = _context.BdAr.Where(x => x.IdAr == ID_AR).FirstOrDefault();
                    var idcausa = _context.CCausas.Where(x => x.DescCausa == request.DESC_CAUSA).Select(x => x.IdCausa).FirstOrDefault();
                    int? idstatusini = bdar.IdStatusAr;
                    int idnegocioar = _context
                        .BdNegocios
                        .Where(x => x.NoAfiliacion == bdar.NoAfiliacion)
                        .Select(x => x.IdNegocio)
                        .FirstOrDefault();

                    string notificado = request.NOTIFICADO ? "SI" : "NO";
                    string promociones = request.PROMOCIONES ? "SI" : "NO";
                    string descargarApp = request.DESCARGA_APP ? "SI" : "NO";

                    bdar.NoInventario = request.VERSION;
                    bdar.Atiende = request.ATIENDE;
                    bdar.IdSolucion = 9;
                    bdar.IdCausa = idcausa;
                    bdar.IsSustitucion = 1;
                    bdar.IsExito = 1;
                    bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                    bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                    bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                    bdar.NoEquipo = request.VERSION_RETIRO;
                    bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                    bdar.DigitoVerificador = request.DISCOVER.ToString();
                    bdar.Caja = request.CAJA.ToString();
                    bdar.DescripcionTrabajo = request.COMENTARIO;
                    bdar.FecCierre = Convert.ToDateTime(request.FECHA_CIERRE);
                    bdar.MiComercio = "COMERCIO NOTIFICADO: "
                                        + notificado
                                        + " / PROMOCIONES: "
                                        + promociones
                                        + " / SE BAJO APP: "
                                        + descargarApp
                                        + " / "
                                        + request.TELEFONO_1
                                        + " / "
                                        + request.TELEFONO_2;
                    bdar.CadenaCierre += CrearCadenaCierre(
                        request.APLICATIVO,
                        request.VERSION,
                        request.CAJA,
                        request.ROLLOS,
                        request.BATERIA,
                        request.ELIMINADOR,
                        request.TAPA,
                        request.CABLE_AC,
                        request.IS_AMEX,
                        request.ID_AMEX,
                        request.AFILIACION_AMEX,
                        request.CONCLUSIONES_AMEX,
                        request.COMENTARIO);
                    bdar.TerminalAmex = (request.IS_AMEX ? 1 : 0);
                    bdar.IdStatusAr = 6;
                    _context.SaveChanges();

                    insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Sustitucion Aplicación");

                    BdArMiComercio micomercio = new BdArMiComercio()
                    {
                        IdAr = ID_AR,
                        Notificado = request.NOTIFICADO ? 1 : 0,
                        Promociones = request.PROMOCIONES ? 1 : 0,
                        DescargarApp = request.DESCARGA_APP ? 1 : 0,
                        Telefono1 = request.TELEFONO_1,
                        Telefono2 = request.TELEFONO_2,
                        FecAlta = DateTime.Now
                    };
                    _context.BdArMiComercio.Add(micomercio);
                    _context.SaveChanges();

                    BdArAccesorios accesoriosInstalados = new BdArAccesorios()
                    {
                        IdAr = ID_AR,
                        Bateria = (request.BATERIA ? "SI" : "NO"),
                        Eliminador = (request.ELIMINADOR ? "SI" : "NO"),
                        Base = (request.BASE ? "SI" : "NO"),
                        Tapa = (request.TAPA ? "SI" : "NO"),
                        CableAc = (request.CABLE_AC ? "SI" : "NO")
                    };

                    _context.BdArAccesorios.Add(accesoriosInstalados);
                    _context.SaveChanges();

                    BdArAccesorios accesoriosRetirados = new BdArAccesorios()
                    {
                        IdAr = ID_AR,
                        Bateria = (request.BATERIA_RETIRO ? "SI" : "NO"),
                        Eliminador = (request.ELIMINADOR_RETIRO ? "SI" : "NO"),
                        Base = (request.BASE_RETIRO ? "SI" : "NO"),
                        Tapa = (request.TAPA_RETIRO ? "SI" : "NO"),
                        CableAc = (request.CABLE_AC_RETIRO ? "SI" : "NO")
                    };

                    _context.BdArAccesorios.Add(accesoriosRetirados);
                    _context.SaveChanges();

                    if (request.IS_AMEX)
                    {
                        BdArTerminalAsociadaAmex terminal = new BdArTerminalAsociadaAmex()
                        {
                            IdAr = ID_AR,
                            IdTerminalAmex = request.ID_AMEX,
                            AfiliacionTerminalAmex = request.AFILIACION_AMEX,
                            IdUsuarioAlta = ID_TECNICO,
                            FecAlta = DateTime.Now
                        };
                        _context.BdArTerminalAsociadaAmex.Add(terminal);
                        _context.SaveChanges();
                    }
                    /*FIN DE INFORMACION DE AR*/

                    /*INFORMACION UNIDAD INSTALADA*/
                    var bdunidad = _context
                        .BdUnidades
                        .Where(x => x.NoSerie == request.NO_SERIE.Trim())
                        .FirstOrDefault();
                    int idstatusunidadiniinstalada = bdunidad.IdStatusUnidad;

                    BdInstalaciones instalaciones = new BdInstalaciones()
                    {
                        IdAr = ID_AR,
                        IdTecnico = ID_TECNICO,
                        IdNegocio = idnegocioar,
                        IdUnidad = bdunidad.IdUnidad,
                        IsNueva = 0,
                        IdClienteIni = 4,
                        IdUsuarioAlta = ID_TECNICO,
                        FecAlta = DateTime.Now,
                    };
                    _context.BdInstalaciones.Add(instalaciones);
                    _context.SaveChanges();


                    int idconectividadinstalada = _context
                        .CConectividad
                        .Where(x => x.DescConectividad == request.CONECTIVIDAD)
                        .Select(x => x.IdConectividad)
                        .FirstOrDefault();
                    int idaplicativoinstalado = _context
                        .CSoftware
                        .Where(x => x.DescSoftware == request.APLICATIVO)
                        .Select(x => x.IdSoftware)
                        .FirstOrDefault();
                    bdunidad.IdConectividad = idconectividadinstalada;
                    bdunidad.IdAplicativo = idaplicativoinstalado;
                    bdunidad.IdStatusUnidad = 17;
                    bdunidad.IdTipoResponsable = 4;
                    bdunidad.IdResponsable = idnegocioar;
                    _context.SaveChanges();

                    BdBitacoraUnidad bitacoraunidadindstalada = new BdBitacoraUnidad()
                    {
                        IdUnidad = bdunidad.IdUnidad,
                        IdStatusUnidadIni = idstatusunidadiniinstalada,
                        IdStatusUnidadFin = 17,
                        IdResponsable = idnegocioar,
                        IdTipoResponsable = 4,
                        FecAlta = DateTime.Now,
                        IdUsuarioAlta = ID_TECNICO
                    };
                    _context.BdBitacoraUnidad.Add(bitacoraunidadindstalada);
                    _context.SaveChanges();

                    var isgprs = _context.CConectividad.Where(x => x.IdConectividad == idconectividadinstalada).Select(x => x.IsGprs == null ? 0 : x.IsGprs).FirstOrDefault();

                    if (isgprs == 1)
                    {
                        if (request.NO_SIM != null)
                        {
                            var sim = _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM.Trim()).FirstOrDefault();
                            if (sim != null)
                            {
                                int idstatussimInstalar = sim.IdStatusUnidad;
                                int idsimInstalar = sim.IdUnidad;

                                BdInstalaciones instalacionesSim = new BdInstalaciones()
                                {
                                    IdAr = ID_AR,
                                    IdTecnico = ID_TECNICO,
                                    IdNegocio = bdar.IdNegocio,
                                    IdUnidad = sim.IdUnidad,
                                    IsNueva = 0,
                                    IdClienteIni = 4,
                                    IdUsuarioAlta = ID_TECNICO,
                                    FecAlta = DateTime.Now,
                                };
                                _context.BdInstalaciones.Add(instalacionesSim);
                                _context.SaveChanges();

                                sim.IdStatusUnidad = 17;
                                sim.IdTipoResponsable = 4;
                                sim.IdResponsable = idnegocioar;
                                sim.IdSim = bdar.IdProveedor;
                                _context.SaveChanges();

                                BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                {
                                    IdStatusUnidadIni = idstatussimInstalar,
                                    IdStatusUnidadFin = 17,
                                    IdUnidad = idsimInstalar,
                                    IdTipoResponsable = 4,
                                    IdResponsable = idnegocioar,
                                    IdUsuarioAlta = ID_TECNICO,
                                    FecAlta = DateTime.Now
                                };
                                _context.BdBitacoraUnidad.Add(bitacoraSim);
                                _context.SaveChanges();
                            }
                        }
                        else
                        {
                            return "ID SIM no puede estar vacio cuando la conectividad es IS_GPRS";
                        }
                    }


                    /*FIN UNIDAD INSTALADA*/

                    /*INFORMACION UNIDAD RETIRADA*/
                    var bdunidadRetirada = _context
                        .BdUnidades
                        .Where(x => x.NoSerie == request.NO_SERIE_RETIRO.Trim())
                        .FirstOrDefault();
                    int idconectividadretirada = _context
                        .CConectividad
                        .Where(x => x.DescConectividad == request.CONECTIVIDAD_RETIRO.Trim())
                        .Select(x => x.IdConectividad)
                        .FirstOrDefault();
                    int idaplicativoretirada = _context
                        .CSoftware
                        .Where(x => x.DescSoftware == request.APLICATIVO_RETIRO.Trim())
                        .Select(x => x.IdSoftware)
                        .FirstOrDefault();
                    int idmarcaretiro = _context
                        .CMarcas
                        .Where(x => x.DescMarca == request.MARCA_RETIRO.Trim())
                        .Select(x => x.IdMarca)
                        .FirstOrDefault();
                    int idmodeloretiro = _context
                        .CModelos
                        .Where(x => x.DescModelo == request.MODELO_RETIRO.Trim())
                        .Select(x => x.IdModelo)
                        .FirstOrDefault();
                    
                    int idunidadRetirada = 0;
                    int? idstatusunidadretirada = null;

                    if (bdunidadRetirada == null)
                    {
                        var bdunidadretiradaUniverso = _context
                            .BdUniversoUnidades
                            .Where(x => x.NoSerie == request.NO_SERIE_RETIRO.Trim())
                            .FirstOrDefault();

                        if (bdunidadretiradaUniverso != null)
                        {
                            BdUnidades unidad = new BdUnidades()
                            {
                                NoSerie = request.NO_SERIE_RETIRO,
                                IdCliente = 4,
                                IdModelo = idmodeloretiro,
                                IdMarca = idmarcaretiro,
                                IdAplicativo = idaplicativoretirada,
                                IdConectividad = idconectividadretirada,
                                Status = "ACTIVO",
                                IdStatusUnidad = 30
                            };
                            _context.BdUnidades.Add(unidad);
                            _context.SaveChanges();

                            idunidadRetirada = unidad.IdUnidad;
                        }
                        else
                        {
                            return "El numero de sim instalado no existe en el sistema";
                        }
                    }
                    else
                    {
                        idunidadRetirada = bdunidadRetirada.IdUnidad;
                        idstatusunidadretirada = bdunidadRetirada.IdStatusUnidad;
                        /*
                        bdunidadRetirada.IdConectividad = idconectividadretirada;
                        bdunidadRetirada.IdAplicativo = idaplicativoretirada;
                        bdunidadRetirada.IdMarca = idmarcaretiro;
                        bdunidadRetirada.IdModelo = idmodeloretiro;*/
                        bdunidadRetirada.IdStatusUnidad = 30;
                        _context.SaveChanges();
                    }

                    BdRetiros retiros = new BdRetiros()
                    {
                        IdAr = ID_AR,
                        IdTecnico = ID_TECNICO,
                        IdNegocio = bdar.IdNegocio,
                        IdUnidad = idunidadRetirada == 0 ? bdunidadRetirada.IdUnidad : idunidadRetirada,
                        IsDaniada = 0,
                        IsNueva = 0,
                        IdUsuarioAlta = ID_TECNICO,
                        FecAlta = DateTime.Now
                    };
                    _context.BdRetiros.Add(retiros);
                    _context.SaveChanges();

                    BdBitacoraUnidad bitacoraunidadRetirada = new BdBitacoraUnidad()
                    {
                        IdUnidad = idunidadRetirada,
                        IdStatusUnidadIni = idstatusunidadretirada,
                        IdStatusUnidadFin = 15,
                        IdResponsable = ID_TECNICO,
                        IdTipoResponsable = 2,
                        FecAlta = DateTime.Now,
                        IdUsuarioAlta = ID_TECNICO
                    };
                    _context.BdBitacoraUnidad.Add(bitacoraunidadRetirada);
                    _context.SaveChanges();

                    int isgprsretiro = _context.CConectividad.Where(x => x.DescConectividad == request.CONECTIVIDAD_RETIRO.Trim()).Select(x => x.IsGprs == null ? 0 : 1).FirstOrDefault();

                    if (isgprs == 1)
                    {
                        if (request.NO_SIM_RETIRO != null)
                        {
                            int idSim;
                            var simretiro = _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM_RETIRO && x.IdMarca == 10).FirstOrDefault();
                      
                            if (simretiro == null)
                            {
                                var simretirouniverso = _context.BdUniversoSims.Where(x => x.Sim == request.NO_SIM_RETIRO).FirstOrDefault();
                                if (simretirouniverso != null)
                                {
                                    BdUnidades sim = new BdUnidades()
                                    {
                                        IdCliente = 4,
                                        NoSerie = request.NO_SIM_RETIRO,
                                        IdStatusUnidad = 30,
                                        Status = "ACTIVO"
                                    };
                                    _context.BdUnidades.Add(sim);
                                    _context.SaveChanges();
                                    idSim = sim.IdUnidad;
                                }
                                else
                                {
                                    return "El número de sim retirado no existe en el sistema";
                                }
                            }
                            else
                            {
                                simretiro.IdStatusUnidad = 30;
                                _context.SaveChanges();
                                idSim = simretiro.IdUnidad;
                            }
                            BdRetiros retirosSim = new BdRetiros()
                            {
                                IdAr = ID_AR,
                                IdTecnico = ID_TECNICO,
                                IdNegocio = bdar.IdNegocio,
                                IdUnidad = idSim,
                                IsDaniada = 0,
                                IsNueva = 0,
                                IdUsuarioAlta = ID_TECNICO,
                                FecAlta = DateTime.Now
                            };
                            _context.BdRetiros.Add(retirosSim);
                            _context.SaveChanges();
                        }
                    }

                    /*FIN DE INFORMACION UNIDAD RETIRADA*/

                    return "OK";
                }catch(Exception ex)
                {
                    return "db";
                }
            }
            else
            {
                return "El modelo no puede estar vacio";
            }
        }
        public string CierreSustitucionSim(SustitucionesSimRequest request)
        {
            if (request != null)
            {
                try
                {
                    /*INFORMACION DEL AR*/
                    int ID_AR = request.ID_AR;
                    int ID_TECNICO = request.ID_TECNICO;
                    var bdar = _context.BdAr.Where(x => x.IdAr == ID_AR).FirstOrDefault();
                    int? idstatusini = bdar.IdStatusAr;
                    int idnegocioar = _context
                        .BdNegocios
                        .Where(x => x.NoAfiliacion == bdar.NoAfiliacion)
                        .Select(x => x.IdNegocio)
                        .FirstOrDefault();

                    string notificado = request.NOTIFICADO ? "SI" : "NO";
                    string promociones = request.PROMOCIONES ? "SI" : "NO";
                    string descargarApp = request.DESCARGA_APP ? "SI" : "NO";

                    bdar.Atiende = request.ATIENDE;
                    bdar.IdSolucion = 9;
                    bdar.IsSustitucion = 1;
                    bdar.IsExito = 1;
                    bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                    bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                    bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                    bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                    bdar.DigitoVerificador = request.DISCOVER.ToString();
                    bdar.Caja = request.CAJA.ToString();
                    bdar.DescripcionTrabajo = request.COMENTARIO;
                    bdar.FecCierre = Convert.ToDateTime(request.FECHA_CIERRE);
                    bdar.MiComercio = "COMERCIO NOTIFICADO: "
                                        + notificado
                                        + " / PROMOCIONES: "
                                        + promociones
                                        + " / SE BAJO APP: "
                                        + descargarApp
                                        + " / "
                                        + request.TELEFONO_1
                                        + " / "
                                        + request.TELEFONO_2;
                    bdar.CadenaCierre = CrearCadenaCierre(
                        "",
                        "",
                        request.CAJA,
                        request.ROLLOS,
                        false,
                        false,
                        false,
                        false,
                        false,
                        "",
                        "",
                        "",
                        request.COMENTARIO);
                    bdar.IdStatusAr = 6;
                    _context.SaveChanges();

                    insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Sustitucion Aplicación");

                    BdArMiComercio micomercio = new BdArMiComercio()
                    {
                        IdAr = ID_AR,
                        Notificado = request.NOTIFICADO ? 1 : 0,
                        Promociones = request.PROMOCIONES ? 1 : 0,
                        DescargarApp = request.DESCARGA_APP ? 1 : 0,
                        Telefono1 = request.TELEFONO_1,
                        Telefono2 = request.TELEFONO_2,
                        FecAlta = DateTime.Now
                    };
                    _context.BdArMiComercio.Add(micomercio);
                    _context.SaveChanges();

                    /*FIN DE INFORMACION DE AR*/

                    /*INFORMACION SIM INSTALADO*/

                        if (request.NO_SIM != null)
                        {
                            var sim = _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM.Trim()).FirstOrDefault();
                            if (sim != null)
                            {
                                int idstatussimInstalar = sim.IdStatusUnidad;
                                int idsimInstalar = sim.IdUnidad;

                                BdInstalaciones instalacionesSim = new BdInstalaciones()
                                {
                                    IdAr = ID_AR,
                                    IdTecnico = ID_TECNICO,
                                    IdNegocio = bdar.IdNegocio,
                                    IdUnidad = sim.IdUnidad,
                                    IsNueva = 0,
                                    IdClienteIni = 4,
                                    IdUsuarioAlta = ID_TECNICO,
                                    FecAlta = DateTime.Now,
                                };
                                _context.BdInstalaciones.Add(instalacionesSim);
                                _context.SaveChanges();

                                sim.IdStatusUnidad = 17;
                                sim.IdTipoResponsable = 4;
                                sim.IdResponsable = idnegocioar;
                                sim.IdSim = bdar.IdProveedor;
                                _context.SaveChanges();

                                BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                {
                                    IdStatusUnidadIni = idstatussimInstalar,
                                    IdStatusUnidadFin = 17,
                                    IdUnidad = idsimInstalar,
                                    IdTipoResponsable = 4,
                                    IdResponsable = idnegocioar,
                                    IdUsuarioAlta = ID_TECNICO,
                                    FecAlta = DateTime.Now
                                };
                                _context.BdBitacoraUnidad.Add(bitacoraSim);
                                _context.SaveChanges();
                            }
                        }
                        else
                        {
                            return "ID SIM no puede estar vacio cuando la conectividad es IS_GPRS";
                        }



                    /*FIN UNIDAD INSTALADA*/

                    /*INFORMACION UNIDAD RETIRADA*/

                    if (request.NO_SIM_RETIRO != null)
                    {
                        int idSim;
                        var simretiro = _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM_RETIRO && x.IdMarca == 10).FirstOrDefault();

                        if (simretiro == null)
                        {
                            var simretirouniverso = _context.BdUniversoSims.Where(x => x.Sim == request.NO_SIM_RETIRO).FirstOrDefault();
                            if (simretirouniverso != null)
                            {
                                BdUnidades sim = new BdUnidades()
                                {
                                    IdCliente = 4,
                                    NoSerie = request.NO_SIM_RETIRO,
                                    IdStatusUnidad = 30,
                                    Status = "ACTIVO"
                                };
                                _context.BdUnidades.Add(sim);
                                _context.SaveChanges();
                                idSim = sim.IdUnidad;
                            }
                            else
                            {
                                return "El número de sim retirado no existe en el sistema";
                            }
                        }
                        else
                        {
                            simretiro.IdStatusUnidad = 30;
                            _context.SaveChanges();
                            idSim = simretiro.IdUnidad;
                        }
                        BdRetiros retirosSim = new BdRetiros()
                        {
                            IdAr = ID_AR,
                            IdTecnico = ID_TECNICO,
                            IdNegocio = bdar.IdNegocio,
                            IdUnidad = idSim,
                            IsDaniada = 0,
                            IsNueva = 0,
                            IdUsuarioAlta = ID_TECNICO,
                            FecAlta = DateTime.Now
                        };
                        _context.BdRetiros.Add(retirosSim);
                        _context.SaveChanges();
                    }

                    /*FIN DE INFORMACION UNIDAD RETIRADA*/

                    return "OK";
                }
                catch (Exception ex)
                {
                    return "db";
                }
            }
            else
            {
                return "El modelo no puede estar vacio";
            }
        }
        public int insertBitacoraAr(int idar, int idusuario, int? idstatusini, int idstatusfin, string msg)
        {
            try
            {
                BdBitacoraAr bitacora = new BdBitacoraAr()
                {
                    IdAr = idar,
                    IdStatusArIni = idstatusini,
                    IdStatusArFin = idstatusfin,
                    IsPda = 1,
                    Comentario = msg,
                    IdUsuarioAlta = idusuario,
                    FecAlta = DateTime.Now
                };
                _context.BdBitacoraAr.Add(bitacora);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }

        }
        public string CrearCadenaCierre(string aplicativo, string version, int caja, int rollos, bool bateria, bool eliminador, bool tapa, bool cableac, bool amex, string idamex, string afilamex, string conclusionesAmex, string comentario)
        {
            string ap = aplicativo == null ? "" : aplicativo;
            string ver = version == null ? "" : version;
            string ca = caja.ToString();
            string ro = rollos.ToString();
            string bat = bateria ? "SI" : "NO";
            string eli = eliminador ? "SI" : "NO";
            string ta = tapa ? "SI" : "NO";
            string cab = cableac ? "SI" : "NO";
            string am = amex ? "SI" : "NO";
            string id = idamex == null ? "" : idamex;
            string af = afilamex == null ? "" : afilamex;
            string camex = conclusionesAmex == null ? "" : conclusionesAmex;
            string con = comentario == null ? "" : comentario;

            return "APLICACION: " + ap 
                        + " VERSION: " + ver 
                        + " CAJA: " + ca 
                        + " ROLLOS INSTALADOS : " + ro 
                        + " BATERIA: " + bat
                        + " ELIMINADOR: " + eli
                        + " TAPA: " + ta
                        + " CABLE AC: " + cab
                        + " AMEX: " + am
                        + " ID AMEX: " + id
                        + " AFILIACION AMEX: " + af
                        + " CONCLUSION AMEX: " + camex
                        + " CONCLUSIONES: " + con;
        }
        public async Task<ODT> GetOdtbyId(int idAr)
        {
            var parametros = new[]{
                new SqlParameter("@p0", System.Data.SqlDbType.Int){Value = idAr}
            };
            var newodt = _context
                .Query<ODT>()
                .FromSql("SELECT ID_AR, BD_NEGOCIOS.ID_NEGOCIO, NO_AR AS NO_ODT, " +
                "BD_NEGOCIOS.DESC_NEGOCIO, " +
                "BD_NEGOCIOS.NO_AFILIACION, " +
                "BD_NEGOCIOS.ESTADO, " +
                "BD_NEGOCIOS.COLONIA, " +
                "BD_NEGOCIOS.POBLACION, " +
                "BD_NEGOCIOS.DIRECCION, " +
                "CONVERT(VARCHAR,FEC_GARANTIA,103) +' '+ CONVERT(VARCHAR,FEC_GARANTIA,108) AS FEC_GARANTIA, " +
                "CONVERT(VARCHAR,FEC_ATENCION,103) +' '+ CONVERT(VARCHAR,FEC_ATENCION,108) AS FEC_ATENCION, " +
                "BD_NEGOCIOS.LATITUD, " +
                "BD_NEGOCIOS.LONGITUD, " +
                "CONVERT(INT,DAY(FEC_ATENCION)) AS [DAYS], " +
                "CONVERT(INT,MONTH(FEC_ATENCION)) AS [MONTHS], " +
                "CONVERT(INT,YEAR(FEC_ATENCION)) AS [YEARS], " +
                "BD_AR.ID_TIPO_SERVICIO, " +
                "ROW_NUMBER() OVER(ORDER BY FEC_ATENCION ASC) AS NUMBER, " +
                "BD_AR.ID_STATUS_AR, " +
                "BD_AR.ID_SERVICIO, " +
                "BD_AR.ID_FALLA, " +
                "(SELECT DESC_STATUS_AR FROM C_STATUS_AR SS " +
                "WHERE SS.ID_STATUS_AR = BD_AR.ID_STATUS_AR) " +
                "AS DESC_STATUS_AR " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_AR = @p0 " +
                "AND BD_AR.STATUS='PROCESADO' ", parametros)
                .FirstOrDefault();
            return newodt;
        }
    }
}
