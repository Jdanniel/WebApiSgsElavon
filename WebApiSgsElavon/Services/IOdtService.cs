﻿using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebApiSgsElavon.Entities;
using WebApiSgsElavon.Entities.Requests;
//using WebApiSgsElavon.Model;
using WebApiSgsElavon.ModelsTest;
using WebApiSgsElavon.Utils;
//31/072020 SE AGREGA A LOS CIERRES TANTO PARA UNIDADES COMO SIMS REGISTRAR EL ID_PROVEEDOR EN EL CAMPO DE BD_UNIDADES.ID_SIM
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
        Task<int> AceptarRechazarOdt(AceptarRechazarOdtRequest request);
        Task<IEnumerable<OdtEvent2>> prueba2();
        Task<string> cierreInstalacion(CierreInstalacionRequest request);
        Task<string> cierreInstalacionSim(CierreInstalacionSimRequest request);
        Task<string> CierreSustitucion(SustitucionesRequest request);
        Task<string> CierreSustitucionSim(SustitucionesSimRequest request);
        Task<string> CierreRetiro(CierresRetiroRequest request);
        Task<string> CierreSinMovInventario(CierreSinMovInventarioRequest request);
        Task<string> CierreRechazo(CierreRechazoRequest request);
        Task<string> Cancelacion(CancelacionRequest request);
        Task<ODT> GetOdtbyId(int idAr);
    }

    public class OdtServices : IOdtService
    {
        private readonly ELAVONTESTContext _context;
        private readonly IHttpClientFactory _client;

        public OdtServices(ELAVONTESTContext context, IHttpClientFactory httpClient)
        {
            _context = context;
            _client = httpClient;
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

            List<ODT> odt = await _context.Query<ODT>().FromSql("SELECT ID_AR, " +
                "BD_NEGOCIOS.ID_NEGOCIO, " +
                "NO_AR AS NO_ODT, " +
                "BD_NEGOCIOS.DESC_NEGOCIO, " +
                "BD_NEGOCIOS.NO_AFILIACION, " +
                "BD_NEGOCIOS.ESTADO, " +
                "BD_NEGOCIOS.COLONIA, " +
                "BD_NEGOCIOS.POBLACION, " +
                "BD_NEGOCIOS.DIRECCION, " +
                "CONVERT(VARCHAR,FEC_GARANTIA,103) +' '+ CONVERT(VARCHAR,FEC_GARANTIA,108) AS FEC_GARANTIA, " +
                "CONVERT(VARCHAR,FEC_ATENCION,103) +' '+ CONVERT(VARCHAR,FEC_ATENCION,108) AS FEC_ATENCION, " +
                "CONVERT(VARCHAR,FEC_CIERRE,103) AS FEC_CIERRE, " +
                "CONVERT(VARCHAR,BD_AR.FEC_ALTA,103) +' '+ CONVERT(VARCHAR,BD_AR.FEC_ALTA,108) AS FEC_ALTA, " +
                "NULL AS LATITUD, " +
                "NULL AS LONGITUD, " +
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
                "AS DESC_STATUS_AR, " +
                "(SELECT COUNT(*) FROM BD_AR_ARCHIVOS_VARIOS WHERE BD_AR_ARCHIVOS_VARIOS.ID_AR = BD_AR.ID_AR) AS ARCHIVOS, " +
                " REPLACE(BD_AR.BITACORA, '''','') AS BITACORA, " +
                " BD_AR.TELEFONO " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR IN(3,4,5,6,7,13,35) AND BD_AR.STATUS='PROCESADO' " +
                "AND BD_AR.FEC_ATENCION IS NOT NULL AND BD_AR.FEC_GARANTIA IS NOT NULL" +
                " ORDER BY BD_AR.FEC_ATENCION ASC", idusuario).ToListAsync();

            //var totalYears = odt.GroupBy(x => x.AA).Count();

            return odt;
        }
        public async Task<int> UpdateStatusAr(UpdateStatusBdArRequest model)
        {
            try
            {
                if (!validaAsignacion(model.ID_AR, model.ID_USUARIO))
                {
                    insertDataTable("El servicio fue reasignado", model.ID_USUARIO, model.ID_AR, "Retiro");
                    return 3;
                }
                if (validaStatusAr(model.ID_AR))
                {
                    insertDataTable("El servicio se encuentra  en estatus 6,7,8", model.ID_USUARIO, model.ID_AR, "Retiro");
                    return 4;
                }

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
            }
            catch (SqlException ex)
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
                "NULL AS LATITUD, " +
                "NULL AS LONGITUD, " +
                "CONVERT(INT,DAY(FEC_ATENCION)) AS [DAYS], " +
                "CONVERT(INT,MONTH(FEC_ATENCION)) AS [MONTHS], " +
                "CONVERT(INT,YEAR(FEC_ATENCION)) AS [YEARS], " +
                "BD_AR.ID_TIPO_SERVICIO, " +
                "ROW_NUMBER() OVER(ORDER BY FEC_GARANTIA ASC) AS NUMBER " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR = 3 AND BD_AR.STATUS='PROCESADO' " +
                "AND BD_AR.FEC_ATENCION IS NOT NULL " +
                " ORDER BY BD_AR.FEC_ATENCION ASC", idusuario).ToListAsync();

            OdtEvent evento;
            var years = odts.GroupBy(x => new { x.YEARS }).Select(x => x.Key);

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
                "NULL AS LATITUD, " +
                "NULL AS LONGITUD, " +
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
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR IN(3,4,5,6,7,13) AND BD_AR.STATUS='PROCESADO' " +
                "AND BD_AR.FEC_ATENCION IS NOT NULL " +
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
                    if (eventos[i].year == yMonth[x].YEARS)
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
                "NULL AS LATITUD, " +
                "NULL AS LONGITUD, " +
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
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR IN(3,4,5,6,7,13) AND BD_AR.STATUS='PROCESADO' " +
                "AND BD_AR.FEC_ATENCION IS NOT NULL " +
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
                    if (years[i].YEARS == yMonth[x].YEARS)
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
            var parametros = new[]{
                new SqlParameter("@p0", System.Data.SqlDbType.Int){Value = request.ID_USUARIO},
                new SqlParameter("@p1", System.Data.SqlDbType.VarChar,50){ Value = request.FEC_UPDATE}
            };
            try
            {
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
                    "CONVERT(VARCHAR,BD_AR.FEC_ALTA,103) +' '+ CONVERT(VARCHAR,BD_AR.FEC_ALTA,108) AS FEC_ALTA, " +
                    "CONVERT(VARCHAR,FEC_CIERRE,103) AS FEC_CIERRE, " +
                    "NULL AS LATITUD, " +
                    "NULL AS LONGITUD, " +
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
                    "AS DESC_STATUS_AR, " +
                    "(SELECT COUNT(*) FROM BD_AR_ARCHIVOS_VARIOS WHERE BD_AR_ARCHIVOS_VARIOS.ID_AR = BD_AR.ID_AR) AS ARCHIVOS, " +
                    "REPLACE(BD_AR.BITACORA, '''','') AS BITACORA, " +
                    "BD_AR.TELEFONO " +
                    "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                    "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                    "WHERE ID_TECNICO = @p0 " +
                    "AND ID_STATUS_AR IN(3,4,5,6,7,13,35) " +
                    "AND BD_AR.FEC_ATENCION IS NOT NULL " +
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
        public async Task<string> Cancelacion(CancelacionRequest request)
        {
            if(request != null)
            {
                await insertDataTable(request.ToJson().ToString(), request.IdUsuario, request.IdAr, "CANCELACION SERVICIO APP");

                if (!validaAsignacion(request.IdAr, request.IdUsuario))
                {
                    await insertDataTable("El servicio fue reasignado", request.IdUsuario, request.IdAr, "ERROR- CANCELACION");
                    return "El servicio fue reasignado a otro tecnico";
                }
                if (validaStatusAr(request.IdAr))
                {
                    await insertDataTable("La Odt ya esta Cerrada o Rechazada", request.IdUsuario, request.IdAr, "ERROR -CANCELACION");
                    return "La Odt ya esta Cerrada o Rechazada";
                }
                if (String.IsNullOrEmpty(request.Comentario.Trim()))
                {
                    await insertDataTable("El campo comentario esta vacio", request.IdUsuario, request.IdAr, "ERROR -CANCELACION");
                    return "El campo comentario esta vacio";
                }
                if (String.IsNullOrEmpty(request.DescCausa.Trim()))
                {
                    await insertDataTable("El campo Causa esta vacio", request.IdUsuario, request.IdAr, "ERROR -CANCELACION");
                    return "El campo Causa esta vacio";
                }
                if (String.IsNullOrEmpty(request.Fecha.Trim()))
                {
                    await insertDataTable("El campo Fecha esta vacio", request.IdUsuario, request.IdAr, "ERROR -CANCELACION");
                    return "El campo Fecha esta vacio";
                }
                if (request.IdAr == null || request.IdAr == 0)
                {
                    await insertDataTable("El campo ID_AR esta vacio", request.IdUsuario, request.IdAr, "ERROR -CANCELACION");
                    return "El campo ID_AR esta vacio";
                }
                if (request.IdUsuario == null || request.IdUsuario == 0)
                {
                    await insertDataTable("El campo ID_USUARIO esta vacio", request.IdUsuario, request.IdAr, "ERROR -CANCELACION");
                    return "El campo ID_USUARIO esta vacio";
                }

                CCausaCancelacion causa = await _context.CCausaCancelacion.FirstOrDefaultAsync(x => Regex.Replace(x.DescCausaCancelacion.ToUpper(), @"\t|\n|\r", "") == Regex.Replace(request.DescCausa.ToUpper(), @"\t|\n|\r", "") && x.Status == "ACTIVO");
                CUsuarios usuario = await _context.CUsuarios.FirstOrDefaultAsync(x => x.IdUsuario == request.IdUsuario && x.Status == "ACTIVO");
                BdAr ar = await _context.BdAr.FirstOrDefaultAsync(x => x.IdAr == request.IdAr && x.Status == "PROCESADO");

                if (causa == null)
                {
                    await insertDataTable($"La causa '{request.DescCausa}' no existe en la base de Getnet", request.IdUsuario, request.IdAr, "ERROR -CANCELACION");
                    return $"La causa '{request.DescCausa}' no existe en la base de Getnet";
                }

                if (usuario == null)
                {
                    await insertDataTable($"El usuario no existe en la base de Getnet", request.IdUsuario, request.IdAr, "ERROR -CANCELACION");
                    return "El usuario no existe en la base de Getnet";
                }
                if(ar == null)
                {
                    await insertDataTable($"La ODT no existe en la base de Getnet", request.IdUsuario, request.IdAr, "ERROR -CANCELACION");
                    return $"La ODT no existe en la base de Getnet";
                }
                
                DateTime valFecha;
                
                if(!DateTime.TryParseExact(request.Fecha,"yyyy-MM-dd HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None,
                             out valFecha))
                {
                    await insertDataTable($"El fomato de la fecha es incorrecto " + request.Fecha, request.IdUsuario, request.IdAr, "ERROR -CANCELACION");
                    return $"El fomato de la fecha es incorrecto " + request.Fecha;
                }
                BdBitacoraAr bitacora = new BdBitacoraAr()
                {
                    IdStatusArIni = ar.IdStatusAr,
                    IdStatusArFin = 8,
                    IdAr = ar.IdAr,
                    FecAlta = DateTime.Now,
                    IsPda = 0,
                    Comentario = "Cancelacion Proveedor - APP",
                    IdUsuarioAlta = usuario.IdUsuario,
                };
                await _context.BdBitacoraAr.AddAsync(bitacora);
                await _context.SaveChangesAsync();

                BdArCausasCancelacion bdArCausasCancelacion = new BdArCausasCancelacion()
                {
                    IdAr = ar.IdAr,
                    IdCausaCancelacion = causa.IdTipoCancelado
                };
                await _context.BdArCausasCancelacion.AddAsync(bdArCausasCancelacion);
                await _context.SaveChangesAsync();

                ar.IdStatusAr = 8;
                ar.IdTecnico = usuario.IdUsuario;
                ar.DescripcionTrabajo = request.Comentario;
                ar.FecCierre = valFecha;
                _context.BdAr.Update(ar);
                await _context.SaveChangesAsync();
                return "OK";

            }
            else
            {
                return "El modelo no puede estar vacio";
            }
        }
        #region Cierre por rechazo
        public async Task<string> CierreRechazo(CierreRechazoRequest request)
        {
            //Validacion de modelo
            if (request != null)
            {
                if (!validaAsignacion(request.ID_AR, request.ID_TECNICO))
                {
                    await insertDataTable("El servicio fue reasignado", request.ID_TECNICO, request.ID_AR, "Rechazo");
                    return "El servicio fue reasignado";
                }
                if (validaStatusAr(request.ID_AR))
                {
                    await insertDataTable("El servicio se encuentra  en estatus 6,7,8", request.ID_TECNICO, request.ID_AR, "Rechazo");
                    return "El servicio se encuentra en estatus 6,7,8,31";
                }
                if (!validaFecCierre(request.FEC_CIERRE))
                {
                    await insertDataTable("La fecha de cierre no puede ser mayor a la fecha actual.", request.ID_TECNICO, request.ID_AR, "Rechazo");
                    return "La fecha de cierre no puede ser mayor a la fecha actual.";
                }
                if (string.IsNullOrEmpty(request.CONCLUSIONES))
                {
                    await insertDataTable($"El campo CONCLUSIONES no puede estar vacio", request.ID_TECNICO, request.ID_AR, "Rechazo");
                    return "El campo CONCLUSIONES no puede estar vacio";
                }
                else
                {
                    if (request.CONCLUSIONES.Trim().Length < 20)
                    {
                        await insertDataTable($"El campo CONCLUSIONES debe contar con un minimo de 20 caracteres", request.ID_TECNICO, request.ID_AR, "Rechazo");
                        return "El campo CONCLUSIONES debe contar con un minimo de 20 caracteres";
                    }
                }
                try
                {
                    await insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "Rechazo");

                    int idAr = request.ID_AR;

                    CSubrechazo subrechazo = await _context.CSubrechazo.Where(x => x.Status == "ACTIVO" && EF.Functions.Like(x.Subrechazo, "%" + request.SUBRECHAZO + "%")).FirstOrDefaultAsync();
                    CCausasRechazo causaRechazo = await _context.CCausasRechazo.Where(x => x.Status == "ACTIVO" && x.IdCliente == 4 && EF.Functions.Like(x.DescCausaRechazo, "%" + request.CAUSA_RECHAZO + "%")).FirstOrDefaultAsync();
                    BdAr odt = await _context.BdAr.Where(x => x.IdAr == idAr).FirstOrDefaultAsync();
                    CSoluciones solucion = await _context.CSoluciones.Where(x => x.IdCliente == 4 && x.Status == "ACTIVO" && x.DescSolucion.Trim() == request.TIPO_ATENCION.Trim()).FirstOrDefaultAsync();

                    BdBitacoraAr StatusFinBitacora = await _context.BdBitacoraAr.FirstOrDefaultAsync(x => x.IdStatusArFin == 31 && x.IdAr == idAr);

                    SqlParameter[] @param = new SqlParameter[]
                    {
                        new SqlParameter()
                        {
                            ParameterName = "@ID_AR",
                            SqlDbType = System.Data.SqlDbType.Int,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = request.ID_AR
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@FECHA",
                            SqlDbType = System.Data.SqlDbType.VarChar,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = request.FEC_CIERRE
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@CAUSA",
                            SqlDbType = System.Data.SqlDbType.Int,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = causaRechazo.IdTrechazo
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@SUBRECHAZO",
                            SqlDbType = System.Data.SqlDbType.Int,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = subrechazo.Id
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@TIPO_ATENCION",
                            SqlDbType = System.Data.SqlDbType.Int,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = solucion.IdSolucion
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@TECNICO",
                            SqlDbType = System.Data.SqlDbType.Int,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = request.ID_TECNICO
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@ATIENDE",
                            SqlDbType = System.Data.SqlDbType.VarChar,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = request.ATIENDE
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@CONCLUSIONES",
                            SqlDbType = System.Data.SqlDbType.VarChar,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = request.CONCLUSIONES
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@ID_USUARIO",
                            SqlDbType = System.Data.SqlDbType.Int,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = request.ID_TECNICO
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@FECHA_PROGRAMADO",
                            SqlDbType = System.Data.SqlDbType.VarChar,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = request.FEC_PROGRAMADO ?? ""
                        }
                    };

                    int res = await _context.Database.ExecuteSqlCommandAsync("EXEC SP_OPCIONES_REINGENIERIA_RECHAZO  @ID_AR,@FECHA,@CAUSA,@SUBRECHAZO,@TIPO_ATENCION,@TECNICO,@ATIENDE,@CONCLUSIONES,@ID_USUARIO, @FECHA_PROGRAMADO", param);

                    return "Ok";
                }
                catch (Exception ex)
                {
                    //Insertar datos en enviados en base
                    await insertDataTable(ex.ToString(), request.ID_TECNICO, request.ID_AR, "Rechazo");
                    return "Ocurrio un error intentalo mas tarde";
                }
            }
            else
            {
                return "La solicitud no puede estar vacio";
            }
        }
        #endregion
        #region Aceptar o Rechazar Servicio
        public async Task<int> AceptarRechazarOdt(AceptarRechazarOdtRequest request)
        {
            try
            {
                //var ii = _context.BdAr.Where(x => x.IdAr == request.ID_AR).Select(x => x.FolioTelecarga).FirstOrDefaultAsync();
                if (!validaAsignacion(request.ID_AR, request.ID_TECNICO))
                {
                    await insertDataTable("El servicio fue reasignado", request.ID_TECNICO, request.ID_AR, "Aceptar/Rechazar");
                    return 2;
                }
                if (validaStatusAr(request.ID_AR))
                {
                    await insertDataTable("El servicio se encuentra  en estatus 6,7,8", request.ID_TECNICO, request.ID_AR, "Aceptar/Rechazar");
                    return 3;
                }
                var odt = await _context.BdAr.Where(x => x.IdAr == request.ID_AR).FirstOrDefaultAsync();
                var idstatusini = odt.IdStatusAr;
                if (request.ID_STATUS_AR == 35)
                {
                    odt.IdStatusAr = 35;
                    await insertBitacoraAr(request.ID_AR, request.ID_TECNICO, idstatusini, 35, "Aceptado por tecnico");
                    await _context.SaveChangesAsync();
                }
                else if (request.ID_STATUS_AR == 36)
                {
                    odt.IdStatusAr = 36;
                    odt.IdTecnico = 0;
                    await insertBitacoraAr(request.ID_AR, request.ID_TECNICO, idstatusini, 36, "Rechazado por tecnico");
                    await _context.SaveChangesAsync();
                }
                return 1;
            }
            catch (SqlException ex)
            {
                return 4;
            }

        }
        #endregion
        #region Cierre Retiro
        public async Task<string> CierreRetiro(CierresRetiroRequest request)
        {
            if (request != null)
            {
                await insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "CIERRE RETIRO(1)");

                if (!validaAsignacion(request.ID_AR, request.ID_TECNICO))
                {
                    await insertDataTable("El servicio fue reasignado", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                    return "El servicio fue reasignado a otro tecnico";
                }
                if (validaStatusAr(request.ID_AR))
                {
                    await insertDataTable("El servicio se encuentra  en estatus 6,7,8", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                    return "La Odt ya esta Cerrada o Rechazada";
                }
                if (!validaFecCierre(request.FECHA_CIERRE))
                {
                    await insertDataTable("La FECHA DE CIERRE no puede ser mayor a la fecha actual.", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                    return "La FECHA DE CIERRE no puede ser mayor a la fecha actual.";
                }
                if (string.IsNullOrEmpty(request.COMENTARIO))
                {
                    await insertDataTable($"El campo COMENTARIO no puede estar vacio", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                    return $"El campo COMENTARIO no puede estar vacio";
                }
                else
                {
                    if (request.COMENTARIO.Trim().Length < 20)
                    {
                        await insertDataTable($"El campo COMENTARIO debe contar con un minimo de 20 caracteres", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                        return $"El campo COMENTARIO debe contar con un minimo de 20 caracteres";
                    }
                }
                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        #region Obtener datos del servicio y la unidad a retirar
                        var bdar = await _context.BdAr.Where(x => x.IdAr == request.ID_AR).FirstOrDefaultAsync();

                        int ID_AR = request.ID_AR;
                        int ID_TECNICO = request.ID_TECNICO;


                        var bdunidadRetirada = await _context.BdUnidades.Where(x => x.NoSerie == request.NO_SERIE.Trim()).FirstOrDefaultAsync();

                        if (bdunidadRetirada != null && bdunidadRetirada.IdStatusUnidad != 17)
                        {
                            transaction.Rollback();
                            await insertDataTable($"El numero de serie `{bdunidadRetirada.NoSerie}` no se encuentra en estatus correcto para retirar", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                            return $"El numero de serie `{bdunidadRetirada.NoSerie}` no se encuentra en estatus correcto para retirar";
                        }

                        int? idstatusini = bdar.IdStatusAr;
                        int idconectividadretirada = await _context.CConectividad.Where(x => x.DescConectividad == request.CONECTIVIDAD.Trim()).Select(x => x.IdConectividad).FirstOrDefaultAsync();
                        int isgprs = await _context.CConectividad.Where(x => x.DescConectividad == request.CONECTIVIDAD.Trim()).Select(x => x.IsGprs == null ? 0 : 1).FirstOrDefaultAsync();
                        int idaplicativoretirada = await _context.CSoftware.Where(x => x.DescSoftware == request.APLICATIVO.Trim()).Select(x => x.IdSoftware).FirstOrDefaultAsync();
                        int idmarcaretiro = await _context.CMarcas.Where(x => x.DescMarca == request.MARCA.Trim()).Select(x => x.IdMarca).FirstOrDefaultAsync();
                        int idmodeloretiro = await _context.CModelos.Where(x => x.DescModelo == request.MODELO.Trim()).Select(x => x.IdModelo).FirstOrDefaultAsync();
                        int? idstatusunidadiniretirar = null;
                        int idunidadretirar = 0;

                        #endregion
                        /*
                        BdModeloConectividad modeloConectividad = await _context.BdModeloConectividad.Where(x => x.IdModelo == idmodeloretiro && x.IdConectividad == idconectividadretirada).FirstOrDefaultAsync();

                        if (modeloConectividad == null)
                        {
                            await insertDataTable($"La conectividad no esta relacionada con el modelo", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                            return $"La conectividad no esta relacionada con el modelo";
                        }

                        BdModeloSoftware modeloSoftware = await _context.BdModeloSoftware.Where(x => x.IdModelo == idmodeloretiro && x.IdSoftware == idaplicativoretirada).FirstOrDefaultAsync();

                        if (modeloSoftware == null)
                        {
                            await insertDataTable($"El aplicativo no esta relacionada con el modelo", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                            return $"El aplicativo no esta relacionada con el modelo";
                        }*/

                        #region Actualizacion o creacion de unidad
                        if (bdunidadRetirada == null || request.NO_SERIE.ToUpper().Trim() == "ILEGIBLE")
                        {
                            var bdunidadretiradaUniverso = await _context.BdUniversoUnidades.Where(x => x.NoSerie == request.NO_SERIE.Trim()).FirstOrDefaultAsync();

                            if (bdunidadretiradaUniverso != null && request.NO_SERIE.ToUpper().Trim() != "ILEGIBLE")
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
                                    FecAlta = DateTime.Now
                                };
                                _context.BdUnidades.Add(unidad);
                                await _context.SaveChangesAsync();
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
                                        FecAlta = DateTime.Now
                                    };
                                    _context.BdUnidades.Add(unidadNueva);
                                    await _context.SaveChangesAsync();
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
                            bdunidadRetirada.IdSim = bdar.IdProveedor;

                            await _context.SaveChangesAsync();
                        }
                        #endregion

                        #region Actualizacion de Bitacora de la Unidad BD_BITACORA_UNIDAD
                        if (bdunidadRetirada == null)
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
                            await _context.SaveChangesAsync();
                        }
                        else if (request.NO_SERIE.ToUpper().Trim() == "ILEGIBLE")
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
                                Comentario = "UNIDAD AUTOGENERADA POR EL SISTEMA"
                            };
                            _context.BdBitacoraUnidad.Add(bitacoraUnidad);
                            await _context.SaveChangesAsync();
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
                            await _context.SaveChangesAsync();
                        }
                        #endregion

                        #region Ingreso de unidad retirada en BD_RETIROS
                        await insertarBdRetiros(ID_AR, ID_TECNICO, bdar.IdNegocio, idunidadretirar, "TPV", idconectividadretirada, idaplicativoretirada);
                        #endregion

                        #region Si la conectividad seleccionada cuenta con el campo IS_GPRS = 1 se actualizara o creara un nuevo registro en BD_UNIDADES
                        if (isgprs == 1)
                        {
                            int idSim;
                            int idstatusanteriorSim = 0;

                            if (!String.IsNullOrEmpty(request.NO_SIM))
                            {
                                var simretiro = await _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM && x.IdMarca == 10).FirstOrDefaultAsync();

                                if (simretiro == null)
                                {
                                    var simretirouniverso = await _context.BdUniversoSims.Where(x => x.Sim == request.NO_SIM).FirstOrDefaultAsync();

                                    if (simretirouniverso != null)
                                    {
                                        var idmodelossim = await GetCarrier(simretirouniverso.Sim.Trim());

                                        BdUnidades sim = new BdUnidades()
                                        {
                                            IdCliente = 4,
                                            NoSerie = request.NO_SIM,
                                            IdMarca = 10,
                                            IdProducto = 1,
                                            IdStatusUnidad = 15,
                                            IsNueva = 0,
                                            IdTipoResponsable = 2,
                                            IdModelo = idmodelossim,
                                            IdResponsable = request.ID_TECNICO,
                                            IdSim = bdar.IdProveedor,
                                            FecAlta = DateTime.Now,
                                            Status = "ACTIVO"
                                        };
                                        _context.BdUnidades.Add(sim);
                                        await _context.SaveChangesAsync();
                                        idSim = sim.IdUnidad;
                                    }
                                    else
                                    {
                                        return "El numero de sim no existe en el sistema";
                                    }
                                }
                                else
                                {

                                    if (simretiro.IdStatusUnidad != 17)
                                    {
                                        transaction.Rollback();
                                        await insertDataTable($"El numero de sim `{simretiro.NoSerie}` no se encuentra en estatus correcto para retirar", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                                        return $"El numero de sim `{simretiro.NoSerie}` no se encuentra en estatus correcto para retirar";
                                    }

                                    var idmodelossim = await GetCarrier(simretiro.NoSerie.Trim());
                                    idstatusanteriorSim = simretiro.IdStatusUnidad;
                                    simretiro.IdStatusUnidad = 15;
                                    simretiro.IsNueva = 0;
                                    simretiro.IdTipoResponsable = 2;
                                    simretiro.IdResponsable = request.ID_TECNICO;
                                    simretiro.IdSim = bdar.IdProveedor;
                                    simretiro.IdModelo = idmodelossim;
                                    await _context.SaveChangesAsync();
                                    idSim = simretiro.IdUnidad;
                                }
                                await insertarBdRetiros(ID_AR, ID_TECNICO, bdar.IdNegocio, idSim, "SIM",0,0);
                                #region Bitacora del Sim
                                if (simretiro == null)
                                {
                                    BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                    {
                                        IdStatusUnidadIni = null,
                                        IdStatusUnidadFin = 15,
                                        IdUnidad = idSim,
                                        IdTipoResponsable = 2,
                                        IdResponsable = ID_TECNICO,
                                        IdUsuarioAlta = ID_TECNICO,
                                        FecAlta = DateTime.Now,
                                        Comentario = "SIM DADO DE ALTA AL NO EXISTIR EN BD_UNIDADES PERO SI EN UNIVERSO DE SIMS"
                                    };
                                    _context.BdBitacoraUnidad.Add(bitacoraSim);
                                    await _context.SaveChangesAsync();
                                }
                                else
                                {
                                    BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                    {
                                        IdStatusUnidadIni = idstatusanteriorSim,
                                        IdStatusUnidadFin = 15,
                                        IdUnidad = idSim,
                                        IdTipoResponsable = 2,
                                        IdResponsable = ID_TECNICO,
                                        IdUsuarioAlta = ID_TECNICO,
                                        FecAlta = DateTime.Now
                                    };
                                    _context.BdBitacoraUnidad.Add(bitacoraSim);
                                    _context.SaveChanges();
                                }
                                #endregion
                            }
                        }
                        #endregion

                        #region Actualizacion de la informacion del servicio BD_AR
                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.IsRetiro = 1;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.NoEquipo = request.VERSION;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        //bdar.NoInventarioFalla = request.GETNET.ToString(); //30/04/2020 SE QUITA CAMPO DE DISCOVER QUE SE ALMACENABA EN DIGITO_VERIFICADOR
                        bdar.Caja = request.CAJA.ToString();
                        bdar.DescripcionTrabajo = request.COMENTARIO;
                        bdar.FecCierre = DateTime.ParseExact(request.FECHA_CIERRE, "dd/MM/yyyy HH:mm:ss", null);
                        bdar.IdStatusAr = 6;
                        bdar.CadenaCierre += "APLICACION:" + request.APLICATIVO
                        + " VERSION: " + request.VERSION
                        + " CAJA: " + request.CAJA
                        + " ROLLOS INSTALADOS: " + request.ROLLOS
                        + " BATERIA: " + (request.BATERIA ? "SI" : "NO")
                        + " ELIMINADOR: " + (request.ELIMINADOR ? "SI" : "NO")
                        + " TAPA: " + (request.TAPA ? "SI" : "NO")
                        + " CABLE AC: " + (request.CABLE_AC ? "SI" : "NO")
                        + " AMEX: "
                        + " ID AMEX: "
                        + " AFILIACION AMEX: "
                        + " CONCLUSION AMEX: "
                        + " CONCLUSIONES: " + request.COMENTARIO;
                        await _context.SaveChangesAsync();
                        #endregion

                        await UpdateSpecialProjects(bdar.NoAfiliacion.Trim(), bdar.IdServicio.GetValueOrDefault(), bdar.IdFalla.GetValueOrDefault());

                        #region Ingreso en Bitacora del servicio BD_BITACORA_AR
                        await insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Retiro Aplicación");
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
                        await _context.SaveChangesAsync();
                        await insertDataTable(request.ToJson(), request.ID_TECNICO, request.ID_AR, "CORRECTO - RETIRO");
                        #endregion
                        transaction.Commit();


                        var requestHttp = new HttpRequestMessage(HttpMethod.Post, "https://smc.microformas.com.mx/SgsSalesforce/api/SalesForce/SendCierre");
                        requestHttp.Content = new StringContent(JsonConvert.SerializeObject(new { idAr = request.ID_AR, idUsuario = request.ID_TECNICO })
                            , Encoding.UTF8
                            , "application/json");
                        var client = _client.CreateClient();
                        await client.SendAsync(requestHttp);

                        return "OK";
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        await insertDataTable(ex.ToString(), request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
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
        public async Task<string> cierreInstalacion(CierreInstalacionRequest request)
        {
            if (request != null)
            {
                await insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "CIERRE INSTALACION (1)");

                #region Validacion Si la Odt se encuentra cerrada o rechazada

                if (!validaAsignacion(request.ID_AR, request.ID_TECNICO))
                {
                    await insertDataTable("El servicio fue reasignado", request.ID_TECNICO, request.ID_AR, "ERROR- Instalacion");
                    return "El servicio fue reasignado a otro tecnico";
                }
                if (validaStatusAr(request.ID_AR))
                {
                    await insertDataTable("La Odt ya esta Cerrada o Rechazada", request.ID_TECNICO, request.ID_AR, "ERROR -Instalacion");
                    return "La Odt ya esta Cerrada o Rechazada";
                }
                if (!validaFecCierre(request.FECHA_CIERRE))
                {
                    await insertDataTable("La fecha de cierre no puede ser mayor a la fecha actual.", request.ID_TECNICO, request.ID_AR, "ERROR - Instalacion");
                    return "La FECHA DE CIERRE no puede ser mayor a la fecha actual.";
                }
                if (!await ValidateInstalledSeries(request.NO_SERIE))
                {
                    await insertDataTable($"La SERIE a Instalar '{request.NO_SERIE}' se encuentra en un estatus incorrecto", request.ID_TECNICO, request.ID_AR, "ERROR - Instalacion");
                    return $"La SERIE a Instalar '{request.NO_SERIE}' se encuentra en un estatus incorrecto";
                }
                if (string.IsNullOrEmpty(request.COMENTARIO))
                {
                    await insertDataTable($"El campo COMENTARIO no puede estar vacio", request.ID_TECNICO, request.ID_AR, "ERROR - INSTALACION");
                    return $"El campo COMENTARIO no puede estar vacio";
                }
                else
                {
                    if (request.COMENTARIO.Trim().Length < 20)
                    {
                        await insertDataTable($"El campo COMENTARIO debe contar con un minimo de 20 caracteres", request.ID_TECNICO, request.ID_AR, "ERROR - INSTALACION");
                        return $"El campo COMENTARIO debe contar con un minimo de 20 caracteres";
                    }
                }
                #endregion

                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        #region Obtener informacion del Servicio y la unidad que se va instalar 
                        int ID_AR = request.ID_AR;
                        int ID_TECNICO = request.ID_TECNICO;

                        var bdar = await _context.BdAr.Where(x => x.IdAr == ID_AR).FirstOrDefaultAsync();

                        int? idstatusini = bdar.IdStatusAr;

                        int idnegocio = await _context
                            .BdNegocios
                            .Where(x => x.NoAfiliacion == bdar.NoAfiliacion && x.Status == "ACTIVO" && x.IdCliente == 4)
                            .Select(x => x.IdNegocio)
                            .FirstOrDefaultAsync();

                        var bdunidad = await _context.BdUnidades.Where(x => x.NoSerie == request.NO_SERIE.Trim()).FirstOrDefaultAsync();

                        int idconectividadinstalada = await _context
                            .CConectividad
                            .Where(x => x.DescConectividad == request.CONECTIVIDAD && x.IdCliente == 4 && x.Status == "ACTIVO")
                            .Select(x => x.IdConectividad)
                            .FirstOrDefaultAsync();

                        int idaplicativoinstalado = await _context
                            .CSoftware
                            .Where(x => x.DescSoftware == request.APLICATIVO && x.IdCliente == 4 && x.Status == "ACTIVO")
                            .Select(x => x.IdSoftware)
                            .FirstOrDefaultAsync();

                        var isgprs = await _context.CConectividad.Where(x => x.IdConectividad == idconectividadinstalada).Select(x => x.IsGprs == null ? 0 : x.IsGprs).FirstOrDefaultAsync();

                        int idstatusunidadInstalar = bdunidad.IdStatusUnidad;
                        int idunidadInstalar = bdunidad.IdUnidad;
                        #endregion

                        BdModeloConectividad modeloConectividad = await _context.BdModeloConectividad.Where(x => x.IdModelo == bdunidad.IdModelo && x.IdConectividad == idconectividadinstalada).FirstOrDefaultAsync();

                        if (modeloConectividad == null)
                        {
                            await insertDataTable($"La conectividad no esta relacionada con el modelo", request.ID_TECNICO, request.ID_AR, "ERROR - INSTALACION");
                            return $"La conectividad no esta relacionada con el modelo";
                        }

                        BdModeloSoftware modeloSoftware = await _context.BdModeloSoftware.Where(x => x.IdModelo == bdunidad.IdModelo && x.IdSoftware == idaplicativoinstalado).FirstOrDefaultAsync();

                        if (modeloSoftware == null)
                        {
                            await insertDataTable($"El aplicativo no esta relacionada con el modelo", request.ID_TECNICO, request.ID_AR, "ERROR - INSTALACION");
                            return $"El aplicativo no esta relacionada con el modelo";
                        }

                        CModelos modelos = await _context.CModelos.Where(x => x.Status == "ACTIVO" && x.IdModelo == bdunidad.IdModelo).FirstOrDefaultAsync();

                        #region Ingreso de informacion en  BD_INSTALACIONES
                        await insertarBdinstalacion(ID_AR, ID_TECNICO, bdar.IdNegocio, bdunidad.IdUnidad, "TPV",idconectividadinstalada,idaplicativoinstalado);
                        #endregion

                        #region Actualizacion de informacion de la unidad Instalada BD_UNIDADES
                        bdunidad.IdConectividad = idconectividadinstalada;
                        bdunidad.IdAplicativo = idaplicativoinstalado;
                        bdunidad.IdStatusUnidad = 17;
                        bdunidad.IdTipoResponsable = 4;
                        bdunidad.IdResponsable = idnegocio;
                        bdunidad.IdSim = bdar.IdProveedor;
                        bdunidad.FolioTelmex = request.GETNET.ToString(); //30/04/2020 SE QUITA CAMPO DE DISCOVER QUE SE ALMACENABA EN DIGITO_VERIFICADOR
                        await _context.SaveChangesAsync();
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
                        await _context.SaveChangesAsync();
                        #endregion

                        #region Si la conectividad seleccionada cuenta con el campo IS_GPRS = 1 se debe actualizar o crear el Sim en BD_UNIDADES
                        if(modelos.IdAccess == 1 && isgprs != 1)
                        {
                            if (!String.IsNullOrEmpty(request.NO_SIM))
                            {
                                var sim = await _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM.Trim()).FirstOrDefaultAsync();

                                if (sim != null)
                                {
                                    var idmodelosim = await GetCarrier(sim.NoSerie.Trim());
                                    if (sim.IdStatusUnidad == 15)
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
                                            Tipo = "SIM",
                                            IdConectividad = 0,
                                            IdAplicativo = 0
                                        };
                                        _context.BdInstalaciones.Add(instalacionesSim);
                                        await _context.SaveChangesAsync();

                                        sim.IdStatusUnidad = 17;
                                        sim.IdTipoResponsable = 4;
                                        sim.IdResponsable = idnegocio;
                                        sim.IdSim = bdar.IdProveedor;
                                        sim.IdModelo = idmodelosim;
                                        await _context.SaveChangesAsync();

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
                                        await _context.SaveChangesAsync();
                                    }
                                    else
                                    {
                                        await insertDataTable($"El Sim a Instalar '{request.NO_SIM}' se encuentra en un estatus incorrecto", request.ID_TECNICO, request.ID_AR, "ERROR SUSTITUCIONES");
                                        return $"La Sim a Instalar '{request.NO_SIM}' se encuentra en un estatus incorrecto";
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (isgprs == 1)
                            {
                                if (!String.IsNullOrEmpty(request.NO_SIM))
                                {
                                    var sim = await _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM.Trim()).FirstOrDefaultAsync();

                                    if (sim != null)
                                    {
                                        var idmodelosim = await GetCarrier(sim.NoSerie.Trim());
                                        if (sim.IdStatusUnidad == 15)
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
                                                Tipo = "SIM",
                                                IdConectividad = 0,
                                                IdAplicativo = 0
                                            };
                                            _context.BdInstalaciones.Add(instalacionesSim);
                                            await _context.SaveChangesAsync();

                                            sim.IdStatusUnidad = 17;
                                            sim.IdTipoResponsable = 4;
                                            sim.IdResponsable = idnegocio;
                                            sim.IdSim = bdar.IdProveedor;
                                            sim.IdModelo = idmodelosim;
                                            await _context.SaveChangesAsync();

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
                                            await _context.SaveChangesAsync();
                                        }
                                        else
                                        {
                                            return "El SIM no esta en el estatus correcto";
                                        }
                                    }
                                }
                                else
                                {
                                    return "ID SIM no puede estar vacio cuando la conectividad es IS_GPRS";
                                }
                            }
                        }

                        #endregion

                        #region Actualizacion de la informacion del servicio en BD_AR
                        string notificado = request.NOTIFICADO ? "SI" : "NO";
                        string promociones = request.PROMOCIONES ? "SI" : "NO";
                        string descargarApp = request.DESCARGA_APP ? "SI" : "NO";
                        string getnet = request.GETNET == 1 ? "SI" : "NO";

                        bdar.NoInventario = request.VERSION;
                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.IsInstalacion = 1;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        bdar.NoInventarioFalla = getnet; //30/04/2020 SE QUITA CAMPO DE DISCOVER QUE SE ALMACENABA EN DIGITO_VERIFICADOR
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
                        await _context.SaveChangesAsync();
                        #endregion

                        await UpdateSpecialProjects(bdar.NoAfiliacion.Trim(), bdar.IdServicio.GetValueOrDefault(), bdar.IdFalla.GetValueOrDefault());

                        #region Ingreso de informacion en BD_BITACORA_AR
                        await insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Instalación Aplicación");
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
                        await _context.SaveChangesAsync();
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
                        await _context.SaveChangesAsync();
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
                            await _context.SaveChangesAsync();
                        }
                        #endregion
                        await insertDataTable(request.ToJson(), request.ID_TECNICO, request.ID_AR, "INSTALACION CORRECTA");
                        transaction.Commit();

                        var requestHttp = new HttpRequestMessage(HttpMethod.Post, "https://smc.microformas.com.mx/SgsSalesforce/api/SalesForce/SendCierre");
                        requestHttp.Content = new StringContent(JsonConvert.SerializeObject(new { idAr = request.ID_AR, idUsuario = request.ID_TECNICO })
                            , Encoding.UTF8
                            , "application/json");
                        var client = _client.CreateClient();
                        await client.SendAsync(requestHttp);
                        return "OK";
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        await insertDataTable(ex.ToString(), request.ID_TECNICO, request.ID_AR, "ERROR - INSTALACION");
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
        #region Cierre Instalacion Sim
        public async Task<string> cierreInstalacionSim(CierreInstalacionSimRequest request)
        {
            if (request != null)
            {
                await insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "CIERRE INSTALACION");

                #region Validacion Si la Odt se encuentra cerrada o rechazada
                if (!validaAsignacion(request.ID_AR, request.ID_TECNICO))
                {
                    return "El servicio fue reasignado a otro tecnico";
                }
                if (validaStatusAr(request.ID_AR))
                {
                    await insertDataTable($"La Odt ya esta Cerrada o Rechazada", request.ID_TECNICO, request.ID_AR, "ERROR - INSTALACION SIM");
                    return "La Odt ya esta Cerrada o Rechazada";
                }
                if (!validaFecCierre(request.FECHA_CIERRE))
                {
                    await insertDataTable($"La FECHA DE CIERRE no puede ser mayor a la actual", request.ID_TECNICO, request.ID_AR, "ERROR - INSTALACION SIM");
                    return "La FECHA DE CIERRE no puede ser mayor a la actual";
                }
                if (string.IsNullOrEmpty(request.COMENTARIO))
                {
                    await insertDataTable($"El campo COMENTARIO no puede estar vacio", request.ID_TECNICO, request.ID_AR, "ERROR - INSTALACION SIM");
                    return $"El campo COMENTARIO no puede estar vacio";
                }
                else
                {
                    if (request.COMENTARIO.Trim().Length < 20)
                    {
                        await insertDataTable($"El campo COMENTARIO debe contar con un minimo de 20 caracteres", request.ID_TECNICO, request.ID_AR, "ERROR - INSTALACION SIM");
                        return $"El campo COMENTARIO debe contar con un minimo de 20 caracteres";
                    }
                }
                #endregion

                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        #region Obtener informacion del Servicio
                        int ID_AR = request.ID_AR;
                        int ID_TECNICO = request.ID_TECNICO;

                        var bdar = await _context.BdAr.Where(x => x.IdAr == ID_AR).FirstOrDefaultAsync();

                        int? idstatusini = bdar.IdStatusAr;

                        int idnegocio = await _context
                            .BdNegocios
                            .Where(x => x.NoAfiliacion == bdar.NoAfiliacion && x.Status == "ACTIVO" && x.IdCliente == 4)
                            .Select(x => x.IdNegocio)
                            .FirstOrDefaultAsync();

                        #endregion

                        #region Se valida que exista el sim y se agrega registro en BD_UNIDADES

                        if (!String.IsNullOrEmpty(request.NO_SIM))
                        {
                            var sim = await _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM.Trim()).FirstOrDefaultAsync();
                            if (sim != null)
                            {
                                int idstatussimInstalar = sim.IdStatusUnidad;
                                int idsimInstalar = sim.IdUnidad;
                                var idmodelosim = await GetCarrier(sim.NoSerie.Trim());

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
                                    Tipo = "SIM",
                                    IdConectividad = 0,
                                    IdAplicativo = 0
                                };
                                _context.BdInstalaciones.Add(instalacionesSim);
                                await _context.SaveChangesAsync();

                                sim.IdStatusUnidad = 17;
                                sim.IdTipoResponsable = 4;
                                sim.IdResponsable = idnegocio;
                                sim.IdSim = bdar.IdProveedor;
                                sim.IdModelo = idmodelosim;
                                await _context.SaveChangesAsync();

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
                                await _context.SaveChangesAsync();
                            }
                        }
                        else
                        {
                            return "ID SIM no puede estar vacio cuando la conectividad es IS_GPRS";
                        }

                        #endregion

                        #region Actualizacion de la informacion del servicio en BD_AR
                        string notificado = request.NOTIFICADO ? "SI" : "NO";
                        string promociones = request.PROMOCIONES ? "SI" : "NO";
                        string descargarApp = request.DESCARGA_APP ? "SI" : "NO";
                        string getnet = request.GETNET == 1 ? "SI" : "NO";

                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.IsInstalacion = 1;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        //bdar.DigitoVerificador = request.DISCOVER.ToString();
                        bdar.NoInventarioFalla = getnet; //30/04/2020 SE QUITA CAMPO DE DISCOVER QUE SE ALMACENABA EN DIGITO_VERIFICADOR
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
                        bdar.CadenaCierre += "APLICACION:"
                        + " VERSION: "
                        + " CAJA: " + request.CAJA
                        + " ROLLOS INSTALADOS: " + request.ROLLOS
                        + " BATERIA: "
                        + " ELIMINADOR: "
                        + " TAPA: "
                        + " CABLE AC: "
                        + " AMEX: "
                        + " ID AMEX: "
                        + " AFILIACION AMEX: "
                        + " CONCLUSION AMEX: "
                        + " CONCLUSIONES: " + request.COMENTARIO;
                        bdar.IdStatusAr = 6;
                        await _context.SaveChangesAsync();
                        #endregion

                        await UpdateSpecialProjects(bdar.NoAfiliacion.Trim(), bdar.IdServicio.GetValueOrDefault(), bdar.IdFalla.GetValueOrDefault());

                        #region Ingreso de informacion en BD_BITACORA_AR
                        await insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Instalación Aplicación");
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
                        await _context.SaveChangesAsync();
                        #endregion

                        transaction.Commit();

                        var requestHttp = new HttpRequestMessage(HttpMethod.Post, "https://smc.microformas.com.mx/SgsSalesforce/api/SalesForce/SendCierre");
                        requestHttp.Content = new StringContent(JsonConvert.SerializeObject(new { idAr = 10794, idUsuario = 300 })
                            , Encoding.UTF8
                            , "application/json");
                        var client = _client.CreateClient();
                        await client.SendAsync(requestHttp);
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
        public async Task<string> CierreSinMovInventario(CierreSinMovInventarioRequest request)
        {
            if (request != null)
            {
                await insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "CIERRE SIN MOVIMIENTO");

                #region Validacion del servicio no se encuentre rechazada o cerrada
                if (!validaAsignacion(request.ID_AR, request.ID_TECNICO))
                {
                    await insertDataTable("El servicio fue reasignado", request.ID_TECNICO, request.ID_AR, "ERROR - SIN MOVIMIENTO");
                    return "El servicio fue reasignado a otro tecnico";
                }
                if (validaStatusAr(request.ID_AR))
                {
                    await insertDataTable("El servicio se encuentra  en estatus 6,7,8", request.ID_TECNICO, request.ID_AR, "ERROR - SIN MOVIMIENTO");
                    return "La Odt ya esta Cerrada o Rechazada";
                }
                if (!validaFecCierre(request.FECHA_CIERRE))
                {
                    await insertDataTable("La FECHA DE CIERRE no puede ser mayor a la actual", request.ID_TECNICO, request.ID_AR, "ERROR - SIN MOVIMIENTO");
                    return "La FECHA DE CIERRE no puede ser mayor a la actual";
                }
                if (string.IsNullOrEmpty(request.COMENTARIO))
                {
                    await insertDataTable($"El campo COMENTARIO no puede estar vacio", request.ID_TECNICO, request.ID_AR, "ERROR - SIN MOVIMIENTO");
                    return $"El campo COMENTARIO no puede estar vacio";
                }
                else
                {
                    if (request.COMENTARIO.Trim().Length < 20)
                    {
                        await insertDataTable($"El campo COMENTARIO debe contar con un minimo de 20 caracteres", request.ID_TECNICO, request.ID_AR, "ERROR - SIN MOVIMIENTO");
                        return $"El campo COMENTARIO debe contar con un minimo de 20 caracteres";
                    }
                }
                #endregion

                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        #region Actualizacion del servicio en BD_AR
                        var bdar = await _context.BdAr.Where(x => x.IdAr == request.ID_AR).FirstOrDefaultAsync();

                        int? idstatusini = bdar.IdStatusAr;

                        string notificado = request.NOTIFICADO ? "SI" : "NO";
                        string promociones = request.PROMOCIONES ? "SI" : "NO";
                        string descargarApp = request.DESCARGA_APP ? "SI" : "NO";
                        string getnet = request.GETNET == 1 ? "SI" : "NO";

                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.IsInstalacion = 0;
                        bdar.IsRetiro = 0;
                        bdar.IsSustitucion = 0;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        bdar.NoInventarioFalla = getnet; //30/04/2020 SE QUITA CAMPO DE DISCOVER QUE SE ALMACENABA EN DIGITO_VERIFICADOR
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
                        await _context.SaveChangesAsync();
                        #endregion

                        await UpdateSpecialProjects(bdar.NoAfiliacion.Trim(), bdar.IdServicio.GetValueOrDefault(), bdar.IdFalla.GetValueOrDefault());

                        #region Ingreso de registro en BD_BITACORA_AE
                        await insertBitacoraAr(request.ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Sin Movimiento de Inventario Aplicación");
                        #endregion

                        #region Ingreso de registro en BD_AR_MI_COMERCIO
                        BdArMiComercio micomercio = new BdArMiComercio()
                        {
                            IdAr = request.ID_AR,
                            Notificado = request.NOTIFICADO ? 1 : 0,
                            Promociones = request.PROMOCIONES ? 1 : 0,
                            DescargarApp = request.DESCARGA_APP ? 1 : 0,
                            Telefono1 = request.TELEFONO_1,
                            Telefono2 = request.TELEFONO_2,
                            FecAlta = DateTime.Now
                        };
                        _context.BdArMiComercio.Add(micomercio);
                        await _context.SaveChangesAsync();
                        #endregion

                        await insertDataTable(request.ToJson(), request.ID_TECNICO, request.ID_AR, "CORRECTO - SIN MOVIMIENTO");

                        transaction.Commit();

                        var requestHttp = new HttpRequestMessage(HttpMethod.Post, "https://smc.microformas.com.mx/SgsSalesforce/api/SalesForce/SendCierre");
                        requestHttp.Content = new StringContent(JsonConvert.SerializeObject(new { idAr = request.ID_AR, idUsuario = request.ID_TECNICO })
                            , Encoding.UTF8
                            , "application/json");
                        var client = _client.CreateClient();
                        await client.SendAsync(requestHttp);

                        return "OK";
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        await insertDataTable(ex.ToString(), request.ID_TECNICO, request.ID_AR, "CORRECTO - SIN MOVIMIENTO");
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
        public async Task<string> CierreSustitucion(SustitucionesRequest request)
        {
            if (request != null)
            {
                await insertDataTable(request.ToJson(), request.ID_TECNICO, request.ID_AR, "CIERRE SUSTITUCIONES(1)");

                #region Validacion del servicio no se encuentre rechazada o cerrada
                if (!validaAsignacion(request.ID_AR, request.ID_TECNICO))
                {
                    await insertDataTable("El servicio fue reasignado", request.ID_TECNICO, request.ID_AR, "ERROR SUSTITUCIONES");
                    return "El servicio fue reasignado a otro tecnico";
                }
                if (validaStatusAr(request.ID_AR))
                {
                    await insertDataTable("El servicio se encuentra  en estatus 6,7,8", request.ID_TECNICO, request.ID_AR, "ERROR SUSTITUCIONES");
                    return "La Odt ya esta Cerrada o Rechazada";
                }
                if (!validaFecCierre(request.FECHA_CIERRE))
                {
                    await insertDataTable("La FECHA DE CIERRE no puede ser mayor a la actual", request.ID_TECNICO, request.ID_AR, "ERROR SUSTITUCIONES");
                    return "La FECHA DE CIERRE no puede ser mayor a la actual";
                }
                if (!await ValidateInstalledSeries(request.NO_SERIE))
                {
                    await insertDataTable($"La SERIE a Instalar '{request.NO_SERIE}' se encuentra en un estatus incorrecto", request.ID_TECNICO, request.ID_AR, "ERROR SUSTITUCIONES");
                    return $"La SERIE a Instalar '{request.NO_SERIE}' se encuentra en un estatus incorrecto";
                }
                if(!String.IsNullOrEmpty(request.NO_SIM_RETIRO)&& !await ValidateSimRetiro(request.NO_SIM_RETIRO))
                {
                    await insertDataTable($"El Sim a Retirar '{request.NO_SIM_RETIRO}' se encuentra en un estatus incorrecto", request.ID_TECNICO, request.ID_AR, "ERROR SUSTITUCIONES");
                    return $"El Sim a Retirar '{request.NO_SIM_RETIRO}' se encuentra en un estatus incorrecto";
                }
                if (string.IsNullOrEmpty(request.COMENTARIO))
                {
                    await insertDataTable($"El campo COMENTARIO no puede estar vacio", request.ID_TECNICO, request.ID_AR, "ERROR SUSTITUCIONES");
                    return $"El campo COMENTARIO no puede estar vacio";
                }
                else
                {
                    if (request.COMENTARIO.Trim().Length < 20)
                    {
                        await insertDataTable($"El campo COMENTARIO debe contar con un minimo de 20 caracteres", request.ID_TECNICO, request.ID_AR, "ERROR SUSTITUCIONES");
                        return $"El campo COMENTARIO debe contar con un minimo de 20 caracteres";
                    }
                }
                #endregion

                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        
                        #region Informacion del Servicio
                        int ID_AR = request.ID_AR;
                        int ID_TECNICO = request.ID_TECNICO;
                        int idcausa = await _context.CCausas.Where(x => x.DescCausa == request.DESC_CAUSA && x.IdCliente == 4 && x.Status == "ACTIVO").Select(x => x.IdCausa).FirstOrDefaultAsync();
                        var bdar = await _context.BdAr.Where(x => x.IdAr == ID_AR && x.Status == "PROCESADO").FirstOrDefaultAsync();
                        int? idstatusini = bdar.IdStatusAr;
                        int idnegocioar = await _context
                            .BdNegocios
                            .Where(x => x.NoAfiliacion == bdar.NoAfiliacion)
                            .Select(x => x.IdNegocio)
                            .FirstOrDefaultAsync();

                        string notificado = request.NOTIFICADO ? "SI" : "NO";
                        string promociones = request.PROMOCIONES ? "SI" : "NO";
                        string descargarApp = request.DESCARGA_APP ? "SI" : "NO";
                        string getnet = request.GETNET == 1 ? "SI" : "NO";
                        #endregion
                        #region Actualizacion de la informacion del servcio en BD_AR
                        bdar.NoInventario = request.VERSION;
                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.IsSustitucion = 1;
                        bdar.IdCausa = idcausa;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.NoEquipo = request.VERSION_RETIRO;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        bdar.NoInventarioFalla = getnet; //30/04/2020 SE QUITA CAMPO DE DISCOVER QUE SE ALMACENABA EN DIGITO_VERIFICADOR
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
                        await _context.SaveChangesAsync();
                        #endregion
                        await UpdateSpecialProjects(bdar.NoAfiliacion.Trim(), bdar.IdServicio.GetValueOrDefault(), bdar.IdFalla.GetValueOrDefault());
                        #region Ingreso de registro en BD_BITACORA_AR
                        await insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Sustitucion Aplicación");
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
                        await _context.SaveChangesAsync();
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
                        await _context.SaveChangesAsync();
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
                        await _context.SaveChangesAsync();
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
                            await _context.SaveChangesAsync();
                        }
                        #endregion
                        #region Informacion de la unidad instalada
                        var bdunidad = await _context
                            .BdUnidades
                            .Where(x => x.NoSerie == request.NO_SERIE.Trim())
                            .FirstOrDefaultAsync();
                        int idstatusunidadiniinstalada = bdunidad.IdStatusUnidad;

                        int idconectividadinstalada = await _context
                            .CConectividad
                            .Where(x => x.DescConectividad == request.CONECTIVIDAD && x.Status == "ACTIVO" && x.IdCliente == 4)
                            .Select(x => x.IdConectividad)
                            .FirstOrDefaultAsync();

                        int idaplicativoinstalado = await _context
                            .CSoftware
                            .Where(x => x.DescSoftware == request.APLICATIVO && x.Status == "ACTIVO" && x.IdCliente == 4)
                            .Select(x => x.IdSoftware)
                            .FirstOrDefaultAsync();

                        int idAccess = await _context.CModelos.Where(x => x.IdModelo == bdunidad.IdModelo).Select(x => x.IdAccess.GetValueOrDefault()).FirstOrDefaultAsync();

                        BdModeloConectividad modeloConectividad = await _context.BdModeloConectividad.Where(x => x.IdModelo == bdunidad.IdModelo && x.IdConectividad == idconectividadinstalada).FirstOrDefaultAsync();

                        if (modeloConectividad == null)
                        {
                            await insertDataTable($"La conectividad no esta relacionada con el modelo", request.ID_TECNICO, request.ID_AR, "ERROR - SUSTITUCION");
                            return $"La conectividad no esta relacionada con el modelo";
                        }

                        BdModeloSoftware modeloSoftware = await _context.BdModeloSoftware.Where(x => x.IdModelo == bdunidad.IdModelo && x.IdSoftware == idaplicativoinstalado).FirstOrDefaultAsync();

                        if (modeloSoftware == null)
                        {
                            await insertDataTable($"El aplicativo no esta relacionada con el modelo", request.ID_TECNICO, request.ID_AR, "ERROR - SUSTITUCION");
                            return $"El aplicativo no esta relacionada con el modelo";
                        }

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
                            Tipo = "TPV",
                            IdConectividad = idconectividadinstalada,
                            IdAplicativo = idaplicativoinstalado
                        };
                        _context.BdInstalaciones.Add(instalaciones);
                        await _context.SaveChangesAsync();
                        #endregion

                        #region Actualizacion de informacion de la unidad instalada en BD_UNIDADES
                        bdunidad.IdConectividad = idconectividadinstalada;
                        bdunidad.IdAplicativo = idaplicativoinstalado;
                        bdunidad.IdStatusUnidad = 17;
                        bdunidad.IdTipoResponsable = 4;
                        bdunidad.IdResponsable = idnegocioar;
                        bdunidad.IdSim = bdar.IdProveedor;
                        bdunidad.FolioTelmex = request.GETNET.ToString(); //30/04/2020 SE QUITA CAMPO DE DISCOVER QUE SE ALMACENABA EN DIGITO_VERIFICADOR
                        await _context.SaveChangesAsync();
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
                        await _context.SaveChangesAsync();
                        #endregion
                        #region Si la conectividad seleccionada en la instalacion es IS_GPRS = 1 se ingresara o actualizara el registro del sim en BD_UNIDADES
                        var isgprs = await _context.CConectividad.Where(x => x.IdConectividad == idconectividadinstalada).Select(x => x.IsGprs == null ? 0 : x.IsGprs).FirstOrDefaultAsync();

                        if ((isgprs == 1) || (isgprs != 1 && idAccess == 1))
                        {
                            if (!String.IsNullOrEmpty(request.NO_SIM))
                            {
                                var sim = await _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM.Trim()).FirstOrDefaultAsync();
                                if (sim != null)
                                {
                                    int idstatussimInstalar = sim.IdStatusUnidad;
                                    int idsimInstalar = sim.IdUnidad;
                                    var idmodelosim = await GetCarrier(sim.NoSerie.Trim());

                                    if (sim.IdStatusUnidad == 15)
                                    {

                                        sim.IdStatusUnidad = 17;
                                        sim.IdTipoResponsable = 4;
                                        sim.IdResponsable = idnegocioar;
                                        sim.IdSim = bdar.IdProveedor;
                                        sim.IdModelo = idmodelosim;
                                        await _context.SaveChangesAsync();

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
                                        await _context.SaveChangesAsync();

                                        #region Ingresar informacion en BD_INSTALACIONES PARA EL SIM
                                        await insertarBdinstalacion(ID_AR, ID_TECNICO, bdar.IdNegocio, idsimInstalar, "SIM",0,0);
                                        #endregion
                                    }
                                    else
                                    {
                                        //23/11/2023 Se retira proceso para solo regresar mensaje de error
                                        ////09/07/2020
                                        //sim.IdTipoResponsable = 4;
                                        //sim.IdResponsable = idnegocioar;
                                        //sim.IdSim = bdar.IdProveedor;
                                        //sim.IdModelo = idmodelosim;
                                        //await _context.SaveChangesAsync();

                                        //BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                        //{
                                        //    IdStatusUnidadIni = idstatussimInstalar,
                                        //    IdStatusUnidadFin = 17,
                                        //    IdUnidad = idsimInstalar,
                                        //    IdTipoResponsable = 4,
                                        //    IdResponsable = idnegocioar,
                                        //    IdUsuarioAlta = ID_TECNICO,
                                        //    FecAlta = DateTime.Now
                                        //};
                                        //_context.BdBitacoraUnidad.Add(bitacoraSim);
                                        //await _context.SaveChangesAsync();

                                        //#region Ingresar informacion en BD_INSTALACIONES PARA EL SIM
                                        //await insertarBdinstalacion(ID_AR, ID_TECNICO, bdar.IdNegocio, idsimInstalar, "SIM",0,0);
                                        //#endregion

                                        await insertDataTable($"El Sim a Instalar '{request.NO_SIM}' se encuentra en un estatus incorrecto", request.ID_TECNICO, request.ID_AR, "ERROR SUSTITUCIONES");
                                        return $"La Sim a Instalar '{request.NO_SIM}' se encuentra en un estatus incorrecto";
                                    }
                                }
                                else
                                {
                                    BdUniversoSims universoSims = await _context.BdUniversoSims.Where(x => x.Sim == request.NO_SIM.Trim()).FirstOrDefaultAsync();
                                    if (universoSims != null)
                                    {
                                        var idmodelosim = await GetCarrier(universoSims.Sim.Trim());
                                        BdUnidades simnuevo = new BdUnidades()
                                        {
                                            IdCliente = 4,
                                            NoSerie = request.NO_SIM.Trim(),
                                            IdMarca = 10,
                                            IdProducto = 1,
                                            IdStatusUnidad = 17,
                                            IsNueva = 0,
                                            IdTipoResponsable = 4,
                                            IdResponsable = bdar.IdNegocio,
                                            IdSim = bdar.IdProveedor,
                                            IdModelo = idmodelosim,
                                            FecAlta = DateTime.Now,
                                            Status = "ACTIVO"
                                        };
                                        _context.BdUnidades.Add(simnuevo);
                                        await _context.SaveChangesAsync();


                                        BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                        {
                                            IdStatusUnidadIni = null,
                                            IdStatusUnidadFin = 17,
                                            IdUnidad = simnuevo.IdUnidad,
                                            IdTipoResponsable = 4,
                                            IdResponsable = bdar.IdNegocio,
                                            IdUsuarioAlta = ID_TECNICO,
                                            FecAlta = DateTime.Now,
                                            Comentario = "SIM DADO DE ALTA AL NO EXISTIR EN BD_UNIDADES PERO SI EN UNIVERSO DE SIMS"
                                        };
                                        _context.BdBitacoraUnidad.Add(bitacoraSim);
                                        await _context.SaveChangesAsync();

                                        #region Ingresar informacion en BD_INSTALACIONES PARA EL SIM
                                        await insertarBdinstalacion(ID_AR, ID_TECNICO, bdar.IdNegocio, simnuevo.IdUnidad, "SIM",0,0);
                                        #endregion
                                    }
                                    else
                                    {
                                        return "El SIM agregado no existe en la base GETNET";
                                    }
                                }
                            }
                            else
                            {
                                if(isgprs == 1)
                                {
                                    return "NO SIM no puede estar vacio cuando la conectividad es GRPS";
                                }
                            }
                        }
                        #endregion

                        #region Informacion de la unidad Retirada
                        var bdunidadRetirada = await _context
                            .BdUnidades
                            .Where(x => x.NoSerie == request.NO_SERIE_RETIRO.Trim())
                            .FirstOrDefaultAsync();
                        
                        if (bdunidadRetirada != null && bdunidadRetirada.IdStatusUnidad != 17)
                        {
                            transaction.Rollback();
                            await insertDataTable($"El numero de serie `{bdunidadRetirada.NoSerie}` no se encuentra en estatus correcto para retirar", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                            return $"El numero de serie `{bdunidadRetirada.NoSerie}` no se encuentra en estatus correcto para retirar";
                        }

                        int idconectividadretirada = await _context
                            .CConectividad
                            .Where(x => x.DescConectividad == request.CONECTIVIDAD_RETIRO.Trim() && x.Status == "ACTIVO" && x.IdCliente == 4)
                            .Select(x => x.IdConectividad)
                            .FirstOrDefaultAsync();
                        int idaplicativoretirada = await _context
                            .CSoftware
                            .Where(x => x.DescSoftware == request.APLICATIVO_RETIRO.Trim() && x.Status == "ACTIVO" && x.IdCliente == 4)
                            .Select(x => x.IdSoftware)
                            .FirstOrDefaultAsync();
                        int idmarcaretiro = await _context
                            .CMarcas
                            .Where(x => x.DescMarca == request.MARCA_RETIRO.Trim() && x.Status == "ACTIVO")
                            .Select(x => x.IdMarca)
                            .FirstOrDefaultAsync();
                        int idmodeloretiro = await _context
                            .CModelos
                            .Where(x => x.DescModelo == request.MODELO_RETIRO.Trim() && x.Status == "ACTIVO")
                            .Select(x => x.IdModelo)
                            .FirstOrDefaultAsync();

                        int idunidadRetirada = 0;
                        int? idstatusunidadretirada = null;
                        #endregion
                        /*
                        BdModeloConectividad modeloConectividadR = await _context.BdModeloConectividad.Where(x => x.IdModelo == idmodeloretiro && x.IdConectividad == idconectividadretirada).FirstOrDefaultAsync();

                        if (modeloConectividadR == null)
                        {
                            await insertDataTable($"La conectividad no esta relacionada con el modelo", request.ID_TECNICO, request.ID_AR, "ERROR - SUSTITUCION");
                            return $"La conectividad no esta relacionada con el modelo";
                        }

                        BdModeloSoftware modeloSoftwareR = await _context.BdModeloSoftware.Where(x => x.IdModelo == idmodeloretiro && x.IdSoftware == idaplicativoretirada).FirstOrDefaultAsync();

                        if (modeloSoftwareR == null)
                        {
                            await insertDataTable($"El aplicativo no esta relacionada con el modelo", request.ID_TECNICO, request.ID_AR, "ERROR - SUSTITUCION");
                            return $"El aplicativo no esta relacionada con el modelo";
                        }*/

                        #region Ingreso o actualizacion de la unidad retirada, Si el numero de serie contiene el dato ILEGIBLE se creara un numero de serie aleatorio
                        if (bdunidadRetirada == null || request.NO_SERIE_RETIRO.ToUpper().Trim() == "ILEGIBLE")
                        {
                            var bdunidadretiradaUniverso = await _context
                                .BdUniversoUnidades
                                .Where(x => x.NoSerie == request.NO_SERIE_RETIRO.Trim())
                                .FirstOrDefaultAsync();

                            if (bdunidadretiradaUniverso != null && request.NO_SERIE_RETIRO.ToUpper().Trim() != "ILEGIBLE")
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
                                    IdStatusUnidad = 30,
                                    FecAlta = DateTime.Now
                                };
                                _context.BdUnidades.Add(unidad);
                                await _context.SaveChangesAsync();

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
                                        IdStatusUnidad = 30,
                                        FecAlta = DateTime.Now
                                    };
                                    _context.BdUnidades.Add(unidadNueva);
                                    await _context.SaveChangesAsync();
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
                            bdunidadRetirada.IdSim = bdar.IdProveedor;
                            await _context.SaveChangesAsync();
                        }
                        #endregion

                        #region Ingreso de registro de la unidad retirada en BD_RETIROS
                        await insertarBdRetiros(ID_AR, ID_TECNICO, bdar.IdNegocio, idunidadRetirada == 0 ? bdunidadRetirada.IdUnidad : idunidadRetirada, "TPV", idconectividadretirada, idaplicativoretirada);
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
                            await _context.SaveChangesAsync();
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
                            await _context.SaveChangesAsync();
                        }
                        #endregion

                        #region Si la conectividad es IS_GPRS = 1 se ingresara el registro de un sim nuevo o se actualizara la informacion
                        int isgprsretiro = await _context.CConectividad.Where(x => x.DescConectividad == request.CONECTIVIDAD_RETIRO.Trim()).Select(x => x.IsGprs == null ? 0 : 1).FirstOrDefaultAsync();
                        int idstatusanteriorSim = 0;
                        if (isgprsretiro == 1)
                        {
                            if (request.IS_INSTALACION_SIM || (!request.IS_INSTALACION_SIM && isgprs == 1) || (!request.IS_INSTALACION_SIM && isgprs != 1))
                            {
                                if (!String.IsNullOrEmpty(request.NO_SIM_RETIRO))
                                {
                                    int idSim;
                                    var simretiro = await _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM_RETIRO && x.IdMarca == 10).FirstOrDefaultAsync();

                                    if (simretiro == null)
                                    {
                                        var simretirouniverso = await _context.BdUniversoSims.Where(x => x.Sim == request.NO_SIM_RETIRO).FirstOrDefaultAsync();
                                        if (simretirouniverso != null)
                                        {

                                            //02/11/2020 SE AGREGA CORRECCION PARA TOMAR EL NUMERO DE SERIE QUE ESTA EN BD_UNIVERSO_SIM YA QUE QUE ESTABA TOMANDO EL QUE OBTINENE DE BD_UNIDADES Y REGRESA NULL LO QUE PROVOCA QUE FALLE LA APLICACION
                                            var idmodelosim = await GetCarrier(simretirouniverso.Sim.Trim());
                                            //var idcarrier = await _context.CModelos.Where(x => x.DescModelo == simretirouniverso.Carrier.TrimEnd() && x.Status == "ACTIVO").Select(x => x.IdModelo).FirstOrDefaultAsync();

                                            BdUnidades sim = new BdUnidades()
                                            {
                                                IdCliente = 4,
                                                NoSerie = request.NO_SIM_RETIRO,
                                                IdStatusUnidad = 15,
                                                IsNueva = 0,
                                                IdTipoResponsable = 2,
                                                IdMarca = 10,
                                                IdProducto = 1,
                                                IdModelo = idmodelosim,
                                                IdSim = bdar.IdProveedor,
                                                IdResponsable = request.ID_TECNICO,
                                                FecAlta = DateTime.Now,
                                                Status = "ACTIVO"
                                            };
                                            _context.BdUnidades.Add(sim);
                                            await _context.SaveChangesAsync();
                                            idSim = sim.IdUnidad;
                                        }
                                        else
                                        {
                                            return "El número de sim retirado no existe en el sistema";
                                        }
                                    }
                                    else
                                    {

                                        if (simretiro.IdStatusUnidad != 17)
                                        {
                                            transaction.Rollback();
                                            await insertDataTable($"El numero de sim `{simretiro.NoSerie}` no se encuentra en estatus correcto para retirar", request.ID_TECNICO, request.ID_AR, "ERROR - RETIRO");
                                            return $"El numero de sim `{simretiro.NoSerie}` no se encuentra en estatus correcto para retirar";
                                        }

                                        var idmodelosim = await GetCarrier(simretiro.NoSerie.Trim());
                                        idstatusanteriorSim = simretiro.IdStatusUnidad;
                                        simretiro.IdStatusUnidad = 15;
                                        simretiro.IsNueva = 0;
                                        simretiro.IdTipoResponsable = 2;
                                        simretiro.IdResponsable = request.ID_TECNICO;
                                        simretiro.IdSim = bdar.IdProveedor;
                                        simretiro.IdModelo = idmodelosim;
                                        await _context.SaveChangesAsync();
                                        idSim = simretiro.IdUnidad;
                                    }
                                    await insertarBdRetiros(ID_AR, ID_TECNICO, bdar.IdNegocio, idSim, "SIM",0,0);

                                    #region Bitacora del Sim
                                    if (simretiro == null)
                                    {
                                        BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                        {
                                            IdStatusUnidadIni = null,
                                            IdStatusUnidadFin = 15,
                                            IdUnidad = idSim,
                                            IdTipoResponsable = 2,
                                            IdResponsable = ID_TECNICO,
                                            IdUsuarioAlta = ID_TECNICO,
                                            FecAlta = DateTime.Now,
                                            Comentario = "SIM DADO DE ALTA AL NO EXISTIR EN BD_UNIDADES PERO SI EN UNIVERSO DE SIMS"
                                        };
                                        _context.BdBitacoraUnidad.Add(bitacoraSim);
                                        await _context.SaveChangesAsync();
                                    }
                                    else
                                    {
                                        BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                        {
                                            IdStatusUnidadIni = idstatusanteriorSim,
                                            IdStatusUnidadFin = 15,
                                            IdUnidad = idSim,
                                            IdTipoResponsable = 2,
                                            IdResponsable = ID_TECNICO,
                                            IdUsuarioAlta = ID_TECNICO,
                                            FecAlta = DateTime.Now
                                        };
                                        _context.BdBitacoraUnidad.Add(bitacoraSim);
                                        await _context.SaveChangesAsync();
                                    }
                                    #endregion

                                }
                            }
                            /*else
                            {
                                
                                //SE AGREGA CAMBIO PARA QUE SI NO SE AGREGO SIM PERO YA ESTA INSTALADFO EN EL NEGOCIO SOLO AGREGUE A BITACORA E INSTALACION 
                                 

                                var simnegocio = await _context.BdUnidades.FirstOrDefaultAsync(x => x.IdTipoResponsable == 4 && x.IdResponsable == bdar.IdNegocio);

                                if (simnegocio != null)
                                {
                                    await insertarBdinstalacion(ID_AR, ID_TECNICO, bdar.IdNegocio, simnegocio.IdUnidad, "SIM");

                                    BdBitacoraUnidad bitacoraSimNegocio = new BdBitacoraUnidad()
                                    {
                                        IdStatusUnidadIni = null,
                                        IdStatusUnidadFin = 17,
                                        IdUnidad = simnegocio.IdUnidad,
                                        IdTipoResponsable = 4,
                                        IdResponsable = bdar.IdNegocio,
                                        IdUsuarioAlta = ID_TECNICO,
                                        FecAlta = DateTime.Now,
                                    };
                                    _context.BdBitacoraUnidad.Add(bitacoraSimNegocio);
                                    await _context.SaveChangesAsync();
                                }
                                else
                                {
                                    return "ID SIM no puede estar vacio cuando la conectividad es IS_GPRS";
                                }
                            }*/
                        }
                        #endregion
                        await insertDataTable(request.ToJson(), request.ID_TECNICO, request.ID_AR, "CORRECTO - SUSTITUCIONES");
                        transaction.Commit();

                        var requestHttp = new HttpRequestMessage(HttpMethod.Post, "https://smc.microformas.com.mx/SgsSalesforce/api/SalesForce/SendCierre");
                        requestHttp.Content = new StringContent(JsonConvert.SerializeObject(new { idAr = request.ID_AR, idUsuario = request.ID_TECNICO })
                            , Encoding.UTF8
                            , "application/json");
                        var client = _client.CreateClient();
                        await client.SendAsync(requestHttp);
                        return "OK";
                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        await insertDataTable(ex.ToString(), request.ID_TECNICO, request.ID_AR, "ERROR - SUSTITUCIONES");
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
        public async Task<string> CierreSustitucionSim(SustitucionesSimRequest request)
        {
            if (request != null)
            {
                await insertDataTable(request.ToJson().ToString(), request.ID_TECNICO, request.ID_AR, "CIERRE SUSTITUCION SIM");

                #region Validacion del servicio no se encuentre rechazada o cerrada
                if (!validaAsignacion(request.ID_AR, request.ID_TECNICO))
                {
                    await insertDataTable("El servicio fue reasignado", request.ID_TECNICO, request.ID_AR, "CIERRE SUSTITUCION SIM");
                    return "El servicio fue reasignado a otro tecnico";
                }
                if (validaStatusAr(request.ID_AR))
                {
                    await insertDataTable("El servicio se encuentra  en estatus 6,7,8", request.ID_TECNICO, request.ID_AR, "CIERRE SUSTITUCION SIM");
                    return "La Odt ya esta Cerrada o Rechazada";
                }
                if (!validaFecCierre(request.FECHA_CIERRE))
                {
                    await insertDataTable("La FECHA DE CIERRE no puede ser mayor a la actual", request.ID_TECNICO, request.ID_AR, "CIERRE SUSTITUCION SIM");
                    return "La FECHA DE CIERRE no puede ser mayor a la actual";
                }
                if (!String.IsNullOrEmpty(request.NO_SIM_RETIRO) && !await ValidateSimRetiro(request.NO_SIM_RETIRO))
                {
                    await insertDataTable($"El Sim a Retirar '{request.NO_SIM_RETIRO}' se encuentra en un estatus incorrecto", request.ID_TECNICO, request.ID_AR, "CIERRE SUSTITUCION SIM");
                    return $"El Sim a Retirar '{request.NO_SIM_RETIRO}' se encuentra en un estatus incorrecto";
                }
                if (string.IsNullOrEmpty(request.COMENTARIO))
                {
                    await insertDataTable($"El campo COMENTARIO no puede estar vacio", request.ID_TECNICO, request.ID_AR, "CIERRE SUSTITUCION SIM");
                    return $"El campo COMENTARIO no puede estar vacio";
                }
                else
                {
                    if(request.COMENTARIO.Trim().Length < 20)
                    {
                        await insertDataTable($"El campo COMENTARIO debe contar con un minimo de 20 caracteres", request.ID_TECNICO, request.ID_AR, "CIERRE SUSTITUCION SIM");
                        return $"El campo COMENTARIO debe contar con un minimo de 20 caracteres";
                    }
                }
                #endregion

                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        #region Informacion del servicio
                        int ID_AR = request.ID_AR;
                        int ID_TECNICO = request.ID_TECNICO;
                        var bdar = await _context.BdAr.Where(x => x.IdAr == ID_AR).FirstOrDefaultAsync();
                        int? idstatusini = bdar.IdStatusAr;
                        int idnegocioar = await _context
                            .BdNegocios
                            .Where(x => x.NoAfiliacion == bdar.NoAfiliacion)
                            .Select(x => x.IdNegocio)
                            .FirstOrDefaultAsync();

                        string notificado = request.NOTIFICADO ? "SI" : "NO";
                        string promociones = request.PROMOCIONES ? "SI" : "NO";
                        string descargarApp = request.DESCARGA_APP ? "SI" : "NO";
                        #endregion
                        #region Actualizacion del servicio en BD_AR
                        bdar.Atiende = request.ATIENDE;
                        bdar.IdSolucion = 9;
                        bdar.IsSustitucion = 1;
                        bdar.OtorganteVobo = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboTerceros = request.OTORGANTE_VOBO;
                        bdar.OtorganteVoboCliente = request.OTORGANTE_VOBO;
                        bdar.IntensidadSenial = Convert.ToString(request.ROLLOS);
                        //bdar.DigitoVerificador = request.GETNET.ToString(); //30/04/2020 SE QUITA CAMPO DE DISCOVER QUE SE ALMACENABA EN DIGITO_VERIFICADOR
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
                        bdar.CadenaCierre += "APLICACION:"
                            + " VERSION: "
                            + " CAJA: " + request.CAJA
                            + " ROLLOS INSTALADOS: " + request.ROLLOS
                            + " BATERIA: "
                            + " ELIMINADOR: "
                            + " TAPA: "
                            + " CABLE AC: "
                            + " AMEX: "
                            + " ID AMEX: "
                            + " AFILIACION AMEX: "
                            + " CONCLUSION AMEX: "
                            + " CONCLUSIONES: " + request.COMENTARIO;
                        bdar.IdStatusAr = 6;
                        await _context.SaveChangesAsync();
                        #endregion

                        await UpdateSpecialProjects(bdar.NoAfiliacion.Trim(), bdar.IdServicio.GetValueOrDefault(), bdar.IdFalla.GetValueOrDefault());

                        #region Ingreso de registro en BD_BITACORA_AR
                        await insertBitacoraAr(ID_AR, request.ID_TECNICO, idstatusini, 6, "Cierre Sustitucion Aplicación");
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
                        await _context.SaveChangesAsync();
                        #endregion
                        #region Ingreso o actualizacion de la informacion del sim en BD_UNIDADES y se agrega registro en BD_INSTALACIONES
                        if (!String.IsNullOrEmpty(request.NO_SIM))
                        {
                            var sim = await _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM.Trim()).FirstOrDefaultAsync();
                            if (sim != null)
                            {
                                int idstatussimInstalar = sim.IdStatusUnidad;
                                int idsimInstalar = sim.IdUnidad;
                                var idmodelosim = await GetCarrier(sim.NoSerie.Trim());

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
                                    Tipo = "SIM",
                                    IdConectividad = 0,
                                    IdAplicativo = 0
                                };
                                _context.BdInstalaciones.Add(instalacionesSim);
                                await _context.SaveChangesAsync();

                                sim.IdStatusUnidad = 17;
                                sim.IdTipoResponsable = 4;
                                sim.IdResponsable = idnegocioar;
                                sim.IdSim = bdar.IdProveedor;
                                sim.IdModelo = idmodelosim;
                                await _context.SaveChangesAsync();

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
                                await _context.SaveChangesAsync();
                            }
                        }
                        else
                        {
                            return "ID SIM no puede estar vacio cuando la conectividad es IS_GPRS";
                        }
                        #endregion

                        #region Ingreso o actualizacion de informacion del sim en BD_UNIDADES y se agrega un registro a BD_RETIROS
                        if (!String.IsNullOrEmpty(request.NO_SIM_RETIRO) && request.PEDIR_SIM)
                        {
                            int idSim;
                            int idstatusanteriorSim = 0;
                            var simretiro = await _context.BdUnidades.Where(x => x.NoSerie == request.NO_SIM_RETIRO && x.IdMarca == 10).FirstOrDefaultAsync();

                            if (simretiro == null)
                            {
                                var simretirouniverso = await _context.BdUniversoSims.Where(x => x.Sim == request.NO_SIM_RETIRO).FirstOrDefaultAsync();
                                if (simretirouniverso != null)
                                {
                                    var idmodelosim = await GetCarrier(simretirouniverso.Sim.Trim());
                                    BdUnidades sim = new BdUnidades()
                                    {
                                        IdCliente = 4,
                                        IdProducto = 1,
                                        IdMarca = 10,
                                        IdSim = bdar.IdProveedor,
                                        NoSerie = request.NO_SIM_RETIRO,
                                        IdTipoResponsable = 2,
                                        IdResponsable = request.ID_TECNICO,
                                        IdStatusUnidad = 15,
                                        IdModelo = idmodelosim,
                                        Status = "ACTIVO",
                                        FecAlta = DateTime.Now
                                    };
                                    _context.BdUnidades.Add(sim);
                                    await _context.SaveChangesAsync();
                                    idSim = sim.IdUnidad;
                                }
                                else
                                {
                                    return "El número de sim retirado no existe en el sistema";
                                }
                            }
                            else
                            {
                                var idmodelosim = await GetCarrier(simretiro.NoSerie.Trim());
                                idstatusanteriorSim = simretiro.IdStatusUnidad;
                                simretiro.IdStatusUnidad = 15;
                                simretiro.IdTipoResponsable = 2;
                                simretiro.IdResponsable = request.ID_TECNICO;
                                simretiro.IdSim = bdar.IdProveedor;
                                simretiro.IdModelo = idmodelosim;
                                await _context.SaveChangesAsync();
                                idSim = simretiro.IdUnidad;
                            }
                            #region Bitacora del Sim
                            if (simretiro == null)
                            {
                                BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                {
                                    IdStatusUnidadIni = null,
                                    IdStatusUnidadFin = 15,
                                    IdUnidad = idSim,
                                    IdTipoResponsable = 2,
                                    IdResponsable = ID_TECNICO,
                                    IdUsuarioAlta = ID_TECNICO,
                                    FecAlta = DateTime.Now,
                                    Comentario = "SIM DADO DE ALTA AL NO EXISTIR EN BD_UNIDADES PERO SI EN UNIVERSO DE SIMS"
                                };
                                _context.BdBitacoraUnidad.Add(bitacoraSim);
                                await _context.SaveChangesAsync();
                            }
                            else
                            {
                                BdBitacoraUnidad bitacoraSim = new BdBitacoraUnidad()
                                {
                                    IdStatusUnidadIni = idstatusanteriorSim,
                                    IdStatusUnidadFin = 15,
                                    IdUnidad = idSim,
                                    IdTipoResponsable = 2,
                                    IdResponsable = ID_TECNICO,
                                    IdUsuarioAlta = ID_TECNICO,
                                    FecAlta = DateTime.Now
                                };
                                _context.BdBitacoraUnidad.Add(bitacoraSim);
                                await _context.SaveChangesAsync();
                            }
                            #endregion

                            await insertarBdRetiros(ID_AR, ID_TECNICO, bdar.IdNegocio, idSim, "SIM",0,0);
                        }
                        #endregion
                        transaction.Commit();

                        var requestHttp = new HttpRequestMessage(HttpMethod.Post, "https://smc.microformas.com.mx/SgsSalesforce/api/SalesForce/SendCierre");
                        requestHttp.Content = new StringContent(JsonConvert.SerializeObject(new { idAr = request.ID_AR, idUsuario = request.ID_TECNICO })
                            , Encoding.UTF8
                            , "application/json");
                        var client = _client.CreateClient();
                        await client.SendAsync(requestHttp);
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
        public async Task<int> insertBitacoraAr(int idar, int idusuario, int? idstatusini, int idstatusfin, string msg)
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
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        #endregion
        #region Regresar Rollos a bloqueos
        public async Task<int> RegresarRollos(int idar)
        {
            try
            {
                BdAr ar = await _context.BdAr.Where(x => x.IdAr == idar).FirstOrDefaultAsync();

                BdBloqueos bloqueo = await _context.BdBloqueos.Where(x => x.NoAfiliacion == ar.NoAfiliacion).FirstOrDefaultAsync();
                int total = 0;
                if (ar.Insumos.HasValue)
                {
                    total = ar.Insumos.Value;
                }
                bloqueo.TotalRollos += total;
                //_context.BdBloqueos.Add(bloqueo);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        #endregion
        #region Datos Aplicacion
        public async Task insertDataTable(string datos, int idusuario, int idar, string tipoCierre)
        {
            BdDatosCierresAplicacion cierre = new BdDatosCierresAplicacion()
            {
                Datos = datos,
                TipoCierre = tipoCierre,
                FechaCarga = DateTime.Now,
                IdUsuario = idusuario,
                IdAr = idar
            };
            _context.BdDatosCierresAplicacion.Add(cierre);
            await _context.SaveChangesAsync();
        }
        #endregion
        #region Ingreso de informacion en  BD_INSTALACIONES
        public async Task insertarBdinstalacion(int IDAR, int IDTECNICO, int IDNEGOCIO, int IDUNIDAD, string tipo, int IdConectividad, int IdAplicativo)
        {
            BdInstalaciones instalaciones = new BdInstalaciones()
            {
                IdAr = IDAR,
                IdTecnico = IDTECNICO,
                IdNegocio = IDNEGOCIO,
                IdUnidad = IDUNIDAD,
                IsNueva = 0,
                IdClienteIni = 4,
                IdUsuarioAlta = IDTECNICO,
                FecAlta = DateTime.Now,
                Tipo = tipo,
                IdConectividad = IdConectividad,
                IdAplicativo = IdAplicativo
            };
            _context.BdInstalaciones.Add(instalaciones);
            await _context.SaveChangesAsync();
        }
        #endregion
        #region Ingreso de informacion en BD_RETIROS
        public async Task insertarBdRetiros(int idar, int idtecnico, int idnegocio, int idunidad, string tipo, int idconectividad, int idaplicativo)
        {
            BdRetiros retiros = new BdRetiros()
            {
                IdAr = idar,
                IdTecnico = idtecnico,
                IdNegocio = idnegocio,
                IdUnidad = idunidad,
                IsDaniada = 0,
                IsNueva = 0,
                IdUsuarioAlta = idtecnico,
                FecAlta = DateTime.Now,
                Tipo = tipo,
                IdConectividad = idconectividad,
                IdAplicativo = idaplicativo
            };
            _context.BdRetiros.Add(retiros);
            await _context.SaveChangesAsync();
        }
        #endregion
        public async Task<ODT> GetOdtbyId(int idAr)
        {
            var parametros = new[]{
                new SqlParameter("@p0", System.Data.SqlDbType.Int){Value = idAr}
            };
            var newodt = await _context
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
                "CONVERT(VARCHAR,FEC_CIERRE,103) AS FEC_CIERRE, " +
                "CONVERT(VARCHAR,BD_AR.FEC_ALTA,103) +' '+ CONVERT(VARCHAR,BD_AR.FEC_ALTA,108) AS FEC_ALTA, " +
                "NULL AS LATITUD, " +
                "NULL AS LONGITUD, " +
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
                "AS DESC_STATUS_AR, " +
                "(SELECT COUNT(*) FROM BD_AR_ARCHIVOS_VARIOS WHERE BD_AR_ARCHIVOS_VARIOS.ID_AR = BD_AR.ID_AR) AS ARCHIVOS, " +
                "BD_AR.BITACORA, " +
                "BD_AR.TELEFONO " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_AR = @p0 " +
                "AND BD_AR.FEC_ATENCION IS NOT NULL " +
                "AND BD_AR.STATUS='PROCESADO' ", parametros)
                .FirstOrDefaultAsync();
            return newodt;
        }
        public bool validaAsignacion(int idar, int idtecnico)
        {
            var ar = _context.BdAr.Where(x => x.IdAr == idar && x.IdTecnico == idtecnico).Count();
            return ar > 0 ? true : false;
        }
        public bool validaStatusAr(int idar)
        {
            List<int> idstatusar = new List<int>() { 6, 7, 8, 31 };
            var valArs = _context.BdAr.Where(x => x.IdAr == idar && idstatusar.Contains(x.IdStatusAr)).Count();
            return valArs > 0 ? true : false;
        }
        public bool validaFecCierre(string fechcierre)
        {
            DateTime fechaactual = DateTime.UtcNow.AddSeconds(30);
            DateTime feccierre1 = DateTime.ParseExact(fechcierre, "dd/MM/yyyy HH:mm:ss", null); ;
            DateTime feccierreutc = feccierre1.ToUniversalTime();
            if (feccierreutc > fechaactual)
            {
                return false;
            }
            return true;
        }
        public async Task<int> GetCarrier(string sim)
        {
            string simsix = sim?.Substring(0, 6);
            CCarrier carrier = await _context.CCarrier.FirstOrDefaultAsync(x => x.DigitoVerificador == Convert.ToInt32(simsix));
            if (carrier != null)
            {
                CModelos modelo = await _context.CModelos.FirstOrDefaultAsync(x => x.IdMarca == 10 && x.DescModelo.Equals(carrier.DescCarrier));
                if (modelo != null)
                {
                    return modelo.IdModelo;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }
        public async Task<bool> ValidateInstalledSeries(string serie)
        {
            BdUnidades unidad = await _context.BdUnidades.FirstOrDefaultAsync(x => x.NoSerie == serie.Trim());
            if(unidad.IdStatusUnidad == 17)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> ValidateSimRetiro(string serie)
        {
            var Noserie = await _context.BdUnidades.Where(x => x.IdMarca == 10 && x.NoSerie.Trim() == serie.Trim()).FirstOrDefaultAsync();
            if(Noserie != null)
            {
                if(Noserie.IdStatusUnidad == 15)
                {
                    return false;
                }
            }
            return true;
        }
        public async Task UpdateSpecialProjects(string NoAfiliacion, int IdServicio, int IdFalla)
        {

            List<BdServiciosFallasProyEspeciales> bdServiciosFallasProys = await _context.BdServiciosFallasProyEspeciales.ToListAsync();

            BdServiciosFallasProyEspeciales fallasProyEspeciale = bdServiciosFallasProys
                .Where(x => x.IdServicio == IdServicio && x.IdFalla == IdFalla && x.Status == "ACTIVO")
                .OrderByDescending(x => x.FecAlta)
                .FirstOrDefault();

            if (bdServiciosFallasProys != null)
            {
                List<BdAfiliacionesProyectoEspecial> bdAfiliaciones = await _context.BdAfiliacionesProyectoEspecial.ToListAsync();

                BdAfiliacionesProyectoEspecial bdAfiliacionesProyecto = bdAfiliaciones
                    .Where(x => x.NoAfiliacion.Trim().Equals(NoAfiliacion.Trim()) &&
                            x.Status.Equals("ACTIVO") &&
                            x.IsProcesado.Equals("N") &&
                            x.IdProyectoEspecial == fallasProyEspeciale.IdProyectoEspecial)
                    .FirstOrDefault();

                if (bdAfiliacionesProyecto != null)
                {
                    bdAfiliacionesProyecto.IsProcesado = "S";

                    _context.BdAfiliacionesProyectoEspecial.Update(bdAfiliacionesProyecto);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
