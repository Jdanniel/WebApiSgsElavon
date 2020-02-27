using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApiSgsElavon.Entities;
using WebApiSgsElavon.Entities.Requests;
using WebApiSgsElavon.ModelsTest;
using WebApiSgsElavon.Utils;

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
        #region Cierre por rechazo
        public bool CierreRechazo(CierreRechazoRequest request)
        {
            //Validacion de modelo
            if(request != null)
            {
                try
                {
                    //Guarda informacion enviada en tabla
                    insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "Rechazo");
                    //Variables
                    int idAr = request.ID_AR;
                    var odt = _context.BdAr.Where(x => x.IdAr == idAr).FirstOrDefault();
                    int? idstatusini = odt.IdStatusAr;

                    //Actualizacion de Datos del servicio
                    odt.FecCierre = DateTime.ParseExact(request.FEC_CIERRE, "dd/MM/yyyy HH:mm:ss", null);
                    odt.IdCausaRechazo = (_context.CCausasRechazo.Where(x => x.Status == "ACTIVO" && x.IdCliente == 4 && EF.Functions.Like(x.DescCausaRechazo, "%"+request.CAUSA_RECHAZO+"%")).Select(x => x.IdTrechazo).FirstOrDefault());
                    //odt.IdCausaRechazo = (_context.CCausasRechazo.Where(x => x.Status == "ACTIVO" && x.IdCliente == 4 && x.DescCausaRechazo.TrimEnd() == request.CAUSA_RECHAZO.TrimEnd()).Select(x => x.IdTrechazo).FirstOrDefault());
                    odt.CausaRechazo = (_context.CSubrechazo.Where(x => x.Status == "ACTIVO" && EF.Functions.Like(x.Subrechazo, "%"+request.SUBRECHAZO+"%")).Select(x => x.Id).FirstOrDefault()).ToString();
                    odt.IdSolucion = (_context.CSoluciones.Where(x => x.IdCliente == 4 && x.Status == "ACTIVO" && x.DescSolucion.Trim() == request.TIPO_ATENCION.Trim()).Select(x => x.IdSolucion).FirstOrDefault());
                    odt.IdTecnico = request.ID_TECNICO;
                    odt.Atiende = request.ATIENDE;
                    odt.DescripcionTrabajo = request.CONCLUSIONES;
                    odt.IdStatusAr = 7;
                    _context.SaveChanges();

                    //Guardar Datos en bitacora del servicio
                    insertBitacoraAr(request.ID_AR, request.ID_TECNICO, idstatusini, 7, "Rechazado Aplicación");

                    return true;
                }
                catch (Exception ex)
                {
                    //Insertar datos en enviados en base
                    insertDataTable(ex.ToString(), request.ID_TECNICO, request.ID_AR, "Rechazo");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Aceptar o Rechazar Servicio
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
        #endregion
        #region Cierre Retiro
        public string CierreRetiro(CierresRetiroRequest request)
        {
            if(request != null)
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {

                        insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "CIERRE RETIRO");

                        #region Obtener datos del servicio y la unidad a retirar
                        var bdar = _context.BdAr.Where(x => x.IdAr == request.ID_AR).FirstOrDefault();

                        int ID_AR = request.ID_AR;
                        int ID_TECNICO = request.ID_TECNICO;


                        var bdunidadRetirada = _context.BdUnidades.Where(x => x.NoSerie == request.NO_SERIE.Trim()).FirstOrDefault();

                        int? idstatusini = bdar.IdStatusAr;
                        int idconectividadretirada = _context.CConectividad.Where(x => x.DescConectividad == request.CONECTIVIDAD.Trim()).Select(x => x.IdConectividad).FirstOrDefault();
                        int isgprs = _context.CConectividad.Where(x => x.DescConectividad == request.CONECTIVIDAD.Trim()).Select(x => x.IsGprs == null ? 0 : 1).FirstOrDefault();
                        int idaplicativoretirada = _context.CSoftware.Where(x => x.DescSoftware == request.APLICATIVO.Trim()).Select(x => x.IdSoftware).FirstOrDefault();
                        int idmarcaretiro = _context.CMarcas.Where(x => x.DescMarca == request.MARCA.Trim()).Select(x => x.IdMarca).FirstOrDefault();
                        int idmodeloretiro = _context.CModelos.Where(x => x.DescModelo == request.MODELO.Trim()).Select(x => x.IdModelo).FirstOrDefault();
                        int? idstatusunidadiniretirar = null;
                        int idunidadretirar = 0;

                        #endregion

                        #region Actualizacion o creacion de unidad
                        if (bdunidadRetirada == null || request.NO_SERIE.ToUpper().Trim() == "ILEGIBLE")
                        {
                            var bdunidadretiradaUniverso = _context.BdUniversoUnidades.Where(x => x.NoSerie == request.NO_SERIE.Trim()).FirstOrDefault();

                            if (bdunidadretiradaUniverso != null)
                            {
                                BdUnidades unidad = new BdUnidades()
                                {
                                    NoSerie = request.NO_SERIE,
                                    IdCliente = 4,
                                    IdProducto = 1,
                                    IdSim = bdar.IdProveedor,
                                    IdModelo = idmodeloretiro,
                                    IdMarca = idmarcaretiro,
                                    IdAplicativo = idaplicativoretirada,
                                    IdConectividad = idconectividadretirada,
                                    IdTipoResponsable = 2,
                                    IdResponsable = request.ID_TECNICO,
                                    IdStatusUnidad = 30,
                                    Status = "ACTIVO",
                                };
                                _context.BdUnidades.Add(unidad);
                                _context.SaveChanges();
                                idunidadretirar = unidad.IdUnidad;
                            }
                            else
                            {
                                if (request.NO_SERIE.ToUpper().Trim() == "ILEGIBLE")
                                {
                                    BdUnidades unidadNueva = new BdUnidades()
                                    {
                                        NoSerie = Randoms.AlphaNumeric(9) + "-" + Randoms.AlphaNumeric(1),
                                        IdCliente = 4,
                                        IdProducto = 1,
                                        IdSim = bdar.IdProveedor,
                                        IdModelo = idmodeloretiro,
                                        IdMarca = idmarcaretiro,
                                        IdAplicativo = idaplicativoretirada,
                                        IdConectividad = idconectividadretirada,
                                        IdTipoResponsable = 2,
                                        IdResponsable = request.ID_TECNICO,
                                        IdStatusUnidad = 30,
                                        Status = "ACTIVO",
                                    };
                                    _context.BdUnidades.Add(unidadNueva);
                                    _context.SaveChanges();
                                    idunidadretirar = unidadNueva.IdUnidad;
                                }
                                else
                                {
                                    return "El número de serie no existe en el sistema";
                                }
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
                            bdunidadRetirada.IdStatusUnidad = 30;
                            bdunidadRetirada.IdTipoResponsable = 2;
                            bdunidadRetirada.IdResponsable = request.ID_TECNICO;

                            _context.SaveChanges();
                        }
                        #endregion

                        #region Actualizacion de Bitacora de la Unidad BD_BITACORA_UNIDAD
                        if (request.NO_SERIE.ToUpper().Trim() == "ILEGIBLE")
                        {
                            BdBitacoraUnidad bitacoraUnidad = new BdBitacoraUnidad()
                            {
                                IdStatusUnidadIni = null,
                                IdStatusUnidadFin = 30,
                                IdUnidad = idunidadretirar,
                                IdTipoResponsable = 2,
                                IdResponsable = ID_TECNICO,
                                IdUsuarioAlta = ID_TECNICO,
                                FecAlta = DateTime.Now,
                                Comentario = "UNIDAD DADA DE ALTA AL NO EXISTIR EN BD_UNIDADES PERO SI EN UNIVERSO DE TPVS"
                            };
                            _context.BdBitacoraUnidad.Add(bitacoraUnidad);
                            _context.SaveChanges();
                        }
                        else
                        {
                            BdBitacoraUnidad bitacoraUnidad = new BdBitacoraUnidad()
                            {
                                IdStatusUnidadIni = idstatusunidadiniretirar,
                                IdStatusUnidadFin = 30,
                                IdUnidad = idunidadretirar,
                                IdTipoResponsable = 2,
                                IdResponsable = ID_TECNICO,
                                IdUsuarioAlta = ID_TECNICO,
                                FecAlta = DateTime.Now
                            };
                            _context.BdBitacoraUnidad.Add(bitacoraUnidad);
                            _context.SaveChanges();
                        }
                        #endregion

                        #region Ingreso de unidad retirada en BD_RETIROS
                        BdRetiros retiros = new BdRetiros()
                        {
                            IdAr = ID_AR,
                            IdTecnico = ID_TECNICO,
                            IdNegocio = bdar.IdNegocio,
                            IdUnidad = idunidadretirar,
                            IsDaniada = 0,
                            IsNueva = 0,
                            IdUsuarioAlta = ID_TECNICO,
                            FecAlta = DateTime.Now,
                            Tipo = "TPV"
                        };
                        _context.BdRetiros.Add(retiros);
                        _context.SaveChanges();
                        #endregion

                        #region Si la conectividad seleccionada cuenta con el campo IS_GPRS = 1 se actualizara o creara un nuevo registro en BD_UNIDADES
                        if (isgprs == 1)
                        {
                            int idSim;

                            if (request.NO_SIM != null)
                            {
                                var simretiro = _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM && x.IdMarca == 10).FirstOrDefault();

                                if (simretiro == null)
                                {
                                    var simretirouniverso = _context.BdUniversoSims.Where(x => x.Sim == request.NO_SIM).FirstOrDefault();
                                    if (simretirouniverso != null)
                                    {
                                        BdUnidades sim = new BdUnidades()
                                        {
                                            IdCliente = 4,
                                            NoSerie = request.NO_SIM,
                                            IdStatusUnidad = 15,
                                            IsNueva = 0,
                                            IdTipoResponsable = 2,
                                            IdResponsable = request.ID_TECNICO,
                                            IdSim = bdar.IdProveedor,
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
                                    simretiro.IdStatusUnidad = 15;
                                    simretiro.IsNueva = 0;
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
                                    FecAlta = DateTime.Now,
                                    Tipo = "SIM"
                                };
                                _context.BdRetiros.Add(retirosSim);
                                _context.SaveChanges();
                            }
                        }
                        #endregion

                        #region Actualizacion de la informacion del servicio BD_AR
                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.NoEquipo = request.VERSION;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        bdar.DigitoVerificador = request.DISCOVER.ToString();
                        bdar.Caja = request.CAJA.ToString();
                        bdar.DescripcionTrabajo = request.COMENTARIO;
                        bdar.FecCierre = DateTime.ParseExact(request.FECHA_CIERRE, "dd/MM/yyyy HH:mm:ss", null);
                        bdar.IdStatusAr = 6;
                        _context.SaveChanges();
                        #endregion

                        #region Ingreso en Bitacora del servicio BD_BITACORA_AR
                        insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Retiro Aplicación");
                        #endregion

                        #region Ingreso de informacion en BD_AR_ACCESORIOS
                        BdArAccesorios accesoriosRetirados = new BdArAccesorios()
                        {
                            IdAr = ID_AR,
                            Bateria = (request.BATERIA ? "SI" : "NO"),
                            Eliminador = (request.ELIMINADOR ? "SI" : "NO"),
                            Base = (request.BASE ? "SI" : "NO"),
                            Tapa = (request.TAPA ? "SI" : "NO"),
                            CableAc = (request.CABLE_AC ? "SI" : "NO"),
                            Movimiento = "RETIRO"

                        };

                        _context.BdArAccesorios.Add(accesoriosRetirados);
                        _context.SaveChanges();
                        #endregion
                        transaction.Commit();
                        return "OK";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return "db";
                    }
                }
            }
            else
            {
                return "El modelo no puede estar vacio";
            }
        }
        #endregion
        #region Cierre Instalacion
        public string cierreInstalacion(CierreInstalacionRequest request)
        {
            if (request != null)
            {
                insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "CIERRE INSTALACION");

                #region Validacion Si la Odt se encuentra cerrada o rechazada
                List<int> idstatusar = new List<int>() { 6, 7 };
                var valArs = _context.BdAr.Where(x => x.IdAr == request.ID_AR && idstatusar.Contains(x.IdStatusAr)).Count();
                if (valArs > 0) return "La Odt ya esta Cerrada o Rechazada";
                #endregion

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        #region Obtener informacion del Servicio y la unidad que se va instalar 
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

                        var isgprs = _context.CConectividad.Where(x => x.IdConectividad == idconectividadinstalada).Select(x => x.IsGprs == null ? 0 : x.IsGprs).FirstOrDefault();
                        
                        int idstatusunidadInstalar = bdunidad.IdStatusUnidad;
                        int idunidadInstalar = bdunidad.IdUnidad;
                        #endregion

                        #region Ingreso de informacion en  BD_INSTALACIONES
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
                        #endregion

                        #region Actualizacion de informacion de la unidad Instalada BD_UNIDADES
                        bdunidad.IdConectividad = idconectividadinstalada;
                        bdunidad.IdAplicativo = idaplicativoinstalado;
                        bdunidad.IdStatusUnidad = 17;
                        bdunidad.IdTipoResponsable = 4;
                        bdunidad.IdResponsable = idnegocio;
                        bdunidad.IdSim = bdar.IdProveedor;
                        _context.SaveChanges();
                        #endregion

                        #region Ingreso de informacion en la bitacora de la unidad BD_BITACORA_UNIDAD
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
                        #endregion

                        #region Si la conectividad seleccionada cuenta con el campo IS_GPRS = 1 se debe actualizar o crear el Sim en BD_UNIDADES
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
                        #endregion

                        #region Actualizacion de la informacion del servicio en BD_AR
                        string notificado = request.NOTIFICADO ? "SI" : "NO";
                        string promociones = request.PROMOCIONES ? "SI" : "NO";
                        string descargarApp = request.DESCARGA_APP ? "SI" : "NO";

                        bdar.NoInventario = request.VERSION;
                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        bdar.DigitoVerificador = request.DISCOVER.ToString();
                        bdar.Caja = request.CAJA.ToString();
                        bdar.DescripcionTrabajo = request.COMENTARIO;
                        bdar.FecCierre = DateTime.ParseExact(request.FECHA_CIERRE, "dd/MM/yyyy HH:mm:ss", null);
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
                        bdar.CadenaCierre += "APLICACION:" + request.APLICATIVO
                        + " VERSION: " + request.VERSION
                        + " CAJA: " + request.CAJA
                        + " ROLLOS INSTALADOS: " + request.ROLLOS
                        + " BATERIA: " + (request.BATERIA ? "SI" : "NO")
                        + " ELIMINADOR: " + (request.ELIMINADOR ? "SI" : "NO")
                        + " TAPA: " + (request.TAPA ? "SI" : "NO")
                        + " CABLE AC: " + (request.CABLE_AC ? "SI" : "NO")
                        + " AMEX: " + (request.IS_AMEX ? "SI" : "NO")
                        + " ID AMEX: " + request.ID_AMEX
                        + " AFILIACION AMEX: " + request.AFILIACION_AMEX
                        + " CONCLUSION AMEX: " + request.CONCLUSIONES_AMEX
                        + " CONCLUSIONES: " + request.COMENTARIO;
                        bdar.TerminalAmex = (request.IS_AMEX ? 1 : 0);
                        bdar.IdStatusAr = 6;
                        _context.SaveChanges();
                        #endregion

                        #region Ingreso de informacion en BD_BITACORA_AR
                        insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Instalación Aplicación");
                        #endregion

                        #region Ingreso de informacion en BD_AR_MI_COMERCIO
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
                        #endregion

                        #region Ingreso de nuevo registro en BD_AR_ACCESORIOS
                        BdArAccesorios accesoriosInstalados = new BdArAccesorios()
                        {
                            IdAr = ID_AR,
                            Bateria = (request.BATERIA ? "SI" : "NO"),
                            Eliminador = (request.ELIMINADOR ? "SI" : "NO"),
                            Base = (request.BASE ? "SI" : "NO"),
                            Tapa = (request.TAPA ? "SI" : "NO"),
                            CableAc = (request.CABLE_AC ? "SI" : "NO"),
                            Movimiento = "INSTALACION"
                        };

                        _context.BdArAccesorios.Add(accesoriosInstalados);
                        _context.SaveChanges();
                        #endregion

                        #region Si en la solicitud el campo IS_AMEX es verdadero se almacenara la informacion en BD_AR_TERMINAL_ASOCIADA_AMEX
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
                        #endregion
                        
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
        #endregion
        #region Cierre Sin Movimiento de Inventario
        public string CierreSinMovInventario(CierreSinMovInventarioRequest request)
        {
            if(request != null)
            {
                insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "CIERRE SIN MOVIMIENTO");
                
                #region Validacion del servicio no se encuentre rechazada o cerrada
                var ID_AR = request.ID_AR;
                List<int> idstatusar = new List<int>() { 6, 7 };
                var valArs = _context.BdAr.Where(x => x.IdAr == ID_AR && idstatusar.Contains(x.IdStatusAr)).Count();
                if (valArs > 0) return "La Odt ya esta Cerrada o Rechazada";
                #endregion

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        #region Actualizacion del servicio en BD_AR
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
                        bdar.FecCierre = DateTime.ParseExact(request.FECHA_CIERRE, "dd/MM/yyyy HH:mm:ss", null);
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
                        bdar.IdStatusAr = 6;
                        _context.SaveChanges();
                        #endregion

                        #region Ingreso de registro en BD_BITACORA_AE
                        insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Sin Movimiento de Inventario Aplicación");
                        #endregion

                        #region Ingreso de registro en BD_AR_MI_COMERCIO
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
                        #endregion
                        
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
        #endregion
        #region Cierre Sustitucion
        public string CierreSustitucion(SustitucionesRequest request)
        {
            if(request != null)
            {
                #region Validacion del servicio no se encuentre rechazada o cerrada
                List<int> idstatusar = new List<int>() { 6, 7 };
                var valArs = _context.BdAr.Where(x => x.IdAr == request.ID_AR && idstatusar.Contains(x.IdStatusAr)).Count();
                if (valArs > 0) return "La Odt ya esta Cerrada o Rechazada";
                #endregion

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "CIERRE SUSTITUCIONES");
                        #region Informacion del Servicio
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
                        #endregion
                        #region Actualizacion de la informacion del servcio en BD_AR
                        bdar.NoInventario = request.VERSION;
                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.NoEquipo = request.VERSION_RETIRO;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        bdar.DigitoVerificador = request.DISCOVER.ToString();
                        bdar.Caja = request.CAJA.ToString();
                        bdar.DescripcionTrabajo = request.COMENTARIO;
                        bdar.FecCierre = DateTime.ParseExact(request.FECHA_CIERRE, "dd/MM/yyyy HH:mm:ss", null);
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
                        bdar.CadenaCierre += "APLICACION:" + request.APLICATIVO
                            + " VERSION: " + request.VERSION
                            + " CAJA: " + request.CAJA
                            + " ROLLOS INSTALADOS: " + request.ROLLOS
                            + " BATERIA: " + (request.BATERIA ? "SI" : "NO")
                            + " ELIMINADOR: " + (request.ELIMINADOR ? "SI" : "NO")
                            + " TAPA: " + (request.TAPA ? "SI" : "NO")
                            + " CABLE AC: " + (request.CABLE_AC ? "SI" : "NO")
                            + " AMEX: " + (request.IS_AMEX ? "SI" : "NO")
                            + " ID AMEX: " + request.ID_AMEX
                            + " AFILIACION AMEX: " + request.AFILIACION_AMEX
                            + " CONCLUSION AMEX: " + request.CONCLUSIONES_AMEX
                            + " CONCLUSIONES: " + request.COMENTARIO;
                        bdar.TerminalAmex = (request.IS_AMEX ? 1 : 0);
                        bdar.IdStatusAr = 6;
                        _context.SaveChanges();
                        #endregion
                        #region Ingreso de registro en BD_BITACORA_AR
                        insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Sustitucion Aplicación");
                        #endregion
                        #region Ingreso de resitro en BD_AR_MI_COMERCIO
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
                        #endregion
                        #region Ingreso de informacion en BD_AR_ACCESORIOS de unidad Instalada
                        BdArAccesorios accesoriosInstalados = new BdArAccesorios()
                        {
                            IdAr = ID_AR,
                            Bateria = (request.BATERIA ? "SI" : "NO"),
                            Eliminador = (request.ELIMINADOR ? "SI" : "NO"),
                            Base = (request.BASE ? "SI" : "NO"),
                            Tapa = (request.TAPA ? "SI" : "NO"),
                            CableAc = (request.CABLE_AC ? "SI" : "NO"),
                            Movimiento = "INSTALACION"
                        };

                        _context.BdArAccesorios.Add(accesoriosInstalados);
                        _context.SaveChanges();
                        #endregion
                        #region Ingreso de informacion en BD_AR_ACCESORIOS de unidad Retirad
                        BdArAccesorios accesoriosRetirados = new BdArAccesorios()
                        {
                            IdAr = ID_AR,
                            Bateria = (request.BATERIA_RETIRO ? "SI" : "NO"),
                            Eliminador = (request.ELIMINADOR_RETIRO ? "SI" : "NO"),
                            Base = (request.BASE_RETIRO ? "SI" : "NO"),
                            Tapa = (request.TAPA_RETIRO ? "SI" : "NO"),
                            CableAc = (request.CABLE_AC_RETIRO ? "SI" : "NO"),
                            Movimiento = "RETIRO"
                        };

                        _context.BdArAccesorios.Add(accesoriosRetirados);
                        _context.SaveChanges();
                        #endregion
                        #region Si la solicitud viene con el campo IS_AMEX verdadero, se ingresaro un nuevo registro en BD_AR_TERMINAL_ASOCIADA_AMEX
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
                        #endregion
                        #region Informacion de la unidad instalada
                        var bdunidad = _context
                            .BdUnidades
                            .Where(x => x.NoSerie == request.NO_SERIE.Trim())
                            .FirstOrDefault();
                        int idstatusunidadiniinstalada = bdunidad.IdStatusUnidad;

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
                        #endregion
                        #region Ingreso de registro de unidad instalada en BD_INSTALACIONES
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
                            Tipo = "TPV"
                        };
                        _context.BdInstalaciones.Add(instalaciones);
                        _context.SaveChanges();
                        #endregion
                        #region Actualizacion de informacion de la unidad instalada en BD_UNIDADES
                        bdunidad.IdConectividad = idconectividadinstalada;
                        bdunidad.IdAplicativo = idaplicativoinstalado;
                        bdunidad.IdStatusUnidad = 17;
                        bdunidad.IdTipoResponsable = 4;
                        bdunidad.IdResponsable = idnegocioar;
                        _context.SaveChanges();
                        #endregion
                        #region Ingreso de registro en BD_BITACORA_UNIDAD de la unidad instalada
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
                        #endregion
                        #region Si la conectividad seleccionada en la instalacion es IS_GPRS = 1 se ingresara o actualizara el registro del sim en BD_UNIDADES
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
                        #endregion

                        #region Informacion de la unidad Retirada
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
                        #endregion

                        #region Ingreso o actualizacion de la unidad retirada, Si el numero de serie contiene el dato ILEGIBLE se creara un numero de serie aleatorio
                        if (bdunidadRetirada == null || request.NO_SERIE_RETIRO.ToUpper().Trim() == "ILEGIBLE")
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
                                    IdSim = bdar.IdProveedor,
                                    IdModelo = idmodeloretiro,
                                    IdMarca = idmarcaretiro,
                                    IdAplicativo = idaplicativoretirada,
                                    IdConectividad = idconectividadretirada,
                                    IdTipoResponsable = 2,
                                    IdResponsable = request.ID_TECNICO,
                                    IdProducto = 1,
                                    Status = "ACTIVO",
                                    IdStatusUnidad = 30
                                };
                                _context.BdUnidades.Add(unidad);
                                _context.SaveChanges();

                                idunidadRetirada = unidad.IdUnidad;
                            }
                            else
                            {
                                if (request.NO_SERIE_RETIRO.ToUpper().Trim() == "ILEGIBLE")
                                {
                                    BdUnidades unidadNueva = new BdUnidades()
                                    {
                                        NoSerie = Randoms.AlphaNumeric(9) + "-" + Randoms.AlphaNumeric(1),
                                        IdCliente = 4,
                                        IdProducto = 1,
                                        IdSim = bdar.IdProveedor,
                                        IdModelo = idmodeloretiro,
                                        IdMarca = idmarcaretiro,
                                        IdAplicativo = idaplicativoretirada,
                                        IdConectividad = idconectividadretirada,
                                        IdTipoResponsable = 2,
                                        IdResponsable = request.ID_TECNICO,
                                        Status = "ACTIVO",
                                        IdStatusUnidad = 30
                                    };
                                    _context.BdUnidades.Add(unidadNueva);
                                    _context.SaveChanges();
                                    idunidadRetirada = unidadNueva.IdUnidad;
                                    idstatusunidadretirada = null;
                                }
                                else
                                {
                                    return "El numero de serie retirado no existe en el sistema";
                                }
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
                            bdunidadRetirada.IdTipoResponsable = 2;
                            bdunidadRetirada.IdResponsable = request.ID_TECNICO;
                            bdunidadRetirada.IdStatusUnidad = 30;
                            _context.SaveChanges();
                        }
                        #endregion

                        #region Ingreso de registro de la unidad retirada en BD_RETIROS
                        BdRetiros retiros = new BdRetiros()
                        {
                            IdAr = ID_AR,
                            IdTecnico = ID_TECNICO,
                            IdNegocio = bdar.IdNegocio,
                            IdUnidad = idunidadRetirada == 0 ? bdunidadRetirada.IdUnidad : idunidadRetirada,
                            IsDaniada = 0,
                            IsNueva = 0,
                            IdUsuarioAlta = ID_TECNICO,
                            FecAlta = DateTime.Now,
                            Tipo = "TPV"
                        };
                        _context.BdRetiros.Add(retiros);
                        _context.SaveChanges();
                        #endregion

                        #region Si la unidad cuenta con el numero de serie = "ILEGIBLE" se agrega a la bitacora con un comentario distinto en BD_BITACORA_UNIDAD de lo contrario no lleva comenatrio
                        if (request.NO_SERIE.ToUpper().Trim() == "ILEGIBLE")
                        {
                            BdBitacoraUnidad bitacoraUnidad = new BdBitacoraUnidad()
                            {
                                IdStatusUnidadIni = null,
                                IdStatusUnidadFin = 30,
                                IdUnidad = idunidadRetirada,
                                IdTipoResponsable = 2,
                                IdResponsable = ID_TECNICO,
                                IdUsuarioAlta = ID_TECNICO,
                                FecAlta = DateTime.Now,
                                Comentario = "UNIDAD DADA DE ALTA AL NO EXISTIR EN BD_UNIDADES PERO SI EN UNIVERSO DE TPVS"
                            };
                            _context.BdBitacoraUnidad.Add(bitacoraUnidad);
                            _context.SaveChanges();
                        }
                        else
                        {
                            BdBitacoraUnidad bitacoraUnidad = new BdBitacoraUnidad()
                            {
                                IdStatusUnidadIni = idstatusunidadretirada,
                                IdStatusUnidadFin = 30,
                                IdUnidad = idunidadRetirada,
                                IdTipoResponsable = 2,
                                IdResponsable = ID_TECNICO,
                                IdUsuarioAlta = ID_TECNICO,
                                FecAlta = DateTime.Now
                            };
                            _context.BdBitacoraUnidad.Add(bitacoraUnidad);
                            _context.SaveChanges();
                        }
                        #endregion

                        #region Si la conectividad es IS_GPRS = 1 se ingresara el registro de un sim nuevo o se actualizara la informacion
                        int isgprsretiro = _context.CConectividad.Where(x => x.DescConectividad == request.CONECTIVIDAD_RETIRO.Trim()).Select(x => x.IsGprs == null ? 0 : 1).FirstOrDefault();

                        if (isgprsretiro == 1)
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
                                            IdStatusUnidad = 15,
                                            IsNueva = 0,
                                            IdTipoResponsable = 2,
                                            IdSim = bdar.IdProveedor,
                                            IdResponsable = request.ID_TECNICO,
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
                                    simretiro.IdStatusUnidad = 15;
                                    simretiro.IsNueva = 0;
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
                                    FecAlta = DateTime.Now,
                                    Tipo = "SIM"
                                };
                                _context.BdRetiros.Add(retirosSim);
                                _context.SaveChanges();
                            }
                        }
                        #endregion
                        transaction.Commit();
                        return "OK";
                    }
                    catch (Exception ex)
                    {
                        return "db";
                    }
                }
            }
            else
            {
                return "El modelo no puede estar vacio";
            }
        }
        #endregion
        #region Cierre Sustitucion de Sim
        public string CierreSustitucionSim(SustitucionesSimRequest request)
        {
            if (request != null)
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "CIERRE SUSTITUCION SIM");
                        #region Informacion del servicio
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
                        #endregion
                        #region Actualizacion del servicio en BD_AR
                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        bdar.DigitoVerificador = request.DISCOVER.ToString();
                        bdar.Caja = request.CAJA.ToString();
                        bdar.DescripcionTrabajo = request.COMENTARIO;
                        bdar.FecCierre = DateTime.ParseExact(request.FECHA_CIERRE, "dd/MM/yyyy HH:mm:ss", null);
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
                        bdar.IdStatusAr = 6;
                        _context.SaveChanges();
                        #endregion
                        #region Ingreso de registro en BD_BITACORA_AR
                        insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Sustitucion Aplicación");
                        #endregion
                        #region Ingreso de registro en BD_AR_MI_COMERCIO
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
                        #endregion
                        #region Ingreso o actualizacion de la informacion del sim en BD_UNIDADES y se agrega registro en BD_INSTALACIONES
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
                        #endregion

                        #region Ingreso o actualizacion de informacion del sim en BD_UNIDADES y se agrega un registro a BD_RETIROS
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
                                        IdProducto = 1,
                                        NoSerie = request.NO_SIM_RETIRO,
                                        IdTipoResponsable = 2,
                                        IdResponsable = request.ID_TECNICO,
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
                                simretiro.IdStatusUnidad = 15;
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
                        #endregion
                        transaction.Commit();
                        return "OK";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return "db";
                    }
                }

            }
            else
            {
                return "El modelo no puede estar vacio";
            }
        }
        #endregion
        #region Bitacora Ar
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
        #endregion
        #region Datos Aplicacion
        public void insertDataTable(string datos, int idusuario, int idar, string tipoCierre)
        {
            BdDatosCierreAplicacion cierre = new BdDatosCierreAplicacion()
            {
                Datos = datos,
                TipoCierre = tipoCierre,
                FechaCarga = DateTime.Now,
                IdUsuario = idusuario,
                IdAr = idar
            };
            _context.BdDatosCierreAplicacion.Add(cierre);
            _context.SaveChanges();
        }
        #endregion
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
