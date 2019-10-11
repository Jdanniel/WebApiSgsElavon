using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSgsElavon.Entities;
using WebApiSgsElavon.ModelsTest;

namespace WebApiSgsElavon.Services
{
    public interface IOdtService
    {
        totalODT totalODTS(int idusuario);
        Task<IEnumerable<OdtEvent>> getOdts(int idusuario);
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

        public async Task<IEnumerable<OdtEvent>> getOdts(int idusuario)
        {
            List<ODT> odts = (from a in _context.BdAr
                        join b in _context.BdNegocios on a.IdNegocio equals b.IdNegocio
                        where a.IdStatusAr == 3 && a.IdTecnico == idusuario
                        && a.Status == "PROCESADO"
                        orderby a.FecGarantia ascending
                        select new ODT{
                            ID_AR = a.IdAr,
                            ID_NEGOCIO = b.IdNegocio,
                            NO_ODT = a.NoAr,
                            NEGOCIO = b.DescNegocio,
                            NO_AFILIACION = b.NoAfiliacion,
                            ESTADO = b.Estado,
                            COLONIA = b.Colonia,
                            FEC_GARANTIA = Convert.ToDateTime(a.FecGarantia).Day +"/"+ Convert.ToDateTime(a.FecGarantia).Month+"/"+ Convert.ToDateTime(a.FecGarantia).Year+" "+ Convert.ToDateTime(a.FecGarantia).Hour + ":" + Convert.ToDateTime(a.FecGarantia).Minute+ ":" + Convert.ToDateTime(a.FecGarantia).Second,
                            LATITUD = b.Latitud,
                            LONGITUD = b.Longitud,
                            DIA = Convert.ToDateTime(a.FecGarantia).Day,
                            MES = Convert.ToDateTime(a.FecGarantia).Month,
                            AA = Convert.ToDateTime(a.FecGarantia).Year,
                            ID_TIPO_SERVICIO = a.IdTipoServicio
                        }).ToList();

            var odtsFechas = (from a in _context.BdAr
                             join b in _context.BdNegocios on a.IdNegocio equals b.IdNegocio
                             where a.IdStatusAr == 3 && a.IdTecnico == idusuario
                             && a.Status == "PROCESADO"
                             select new { Convert.ToDateTime(a.FecGarantia).Year, Convert.ToDateTime(a.FecGarantia).Month}).ToList();

            var listFechas = odtsFechas.GroupBy(x => new { x.Year, x.Month }).Select(x => x.Key).ToList();
            var listYears = odtsFechas.GroupBy(x => new { x.Year }).Select(x => x.Key).ToList();
            var listMonths = odtsFechas.GroupBy(x => new { x.Month }).Select(x => x.Key).ToList();

            List<OdtEvent> odtsevents = (from a in listYears
                                         select new OdtEvent{ year = a.Year,
                                             odtGroup = (from b in listFechas where b.Year == a.Year
                                                         select new OdtGroup{ month = b.Month,
                                                             odtDetalle = (from c in odts where c.AA == a.Year && c.MES == b.Month select new OdtDetalle { ID_AR = c.ID_AR })
                                                         }).ToList()
                                         }).ToList();

            /*
            for (int x = 0; x < listMonths.Count; x++)
            {
                for(int y = 0; y < odtsEvents.year.)
            }
            */

            var eventos = from a in _context.BdAr select a.IdAr;

            /*
            List < ODT > odt = await _context.Query<ODT>().FromSql("SELECT ID_AR, BD_NEGOCIOS.ID_NEGOCIO, NO_AR AS NO_ODT, " +
                "BD_NEGOCIOS.DESC_NEGOCIO AS NEGOCIO, " +
                "BD_NEGOCIOS.NO_AFILIACION, " +
                "BD_NEGOCIOS.ESTADO, " +
                "BD_NEGOCIOS.COLONIA, " +
                "CONVERT(VARCHAR,FEC_GARANTIA,103) +' '+ CONVERT(VARCHAR,FEC_GARANTIA,108) AS FEC_GARANTIA, " +
                "BD_NEGOCIOS.LATITUD, " +
                "BD_NEGOCIOS.LONGITUD, " +
                "CONVERT(INT,DAY(FEC_GARANTIA)) AS DIA, " +
                "CONVERT(INT,MONTH(FEC_GARANTIA)) AS MES, " +
                "CONVERT(INT,YEAR(FEC_GARANTIA)) AS AA, " +
                "BD_AR.ID_TIPO_SERVICIO, " +
                "ROW_NUMBER() OVER(ORDER BY FEC_GARANTIA ASC) AS NUMBER " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR = 3 AND BD_AR.STATUS='PROCESADO'" +
                " ORDER BY BD_AR.FEC_GARANTIA ASC", idusuario).ToListAsync();

            var totalYears = odt.GroupBy(x => x.AA).Count();
            */
            return null;
        }
    }
}
