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
        Task<IEnumerable<ODT>> getOdts(int idusuario);
        Task<string> GetNewOdts(int idusuario);
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
                "CONVERT(VARCHAR,FEC_GARANTIA,103) +' '+ CONVERT(VARCHAR,FEC_GARANTIA,108) AS FEC_GARANTIA, " +
                "BD_NEGOCIOS.LATITUD, " +
                "BD_NEGOCIOS.LONGITUD, " +
                "CONVERT(INT,DAY(FEC_GARANTIA)) AS [DAYS], " +
                "CONVERT(INT,MONTH(FEC_GARANTIA)) AS [MONTHS], " +
                "CONVERT(INT,YEAR(FEC_GARANTIA)) AS [YEARS], " +
                "BD_AR.ID_TIPO_SERVICIO, " +
                "ROW_NUMBER() OVER(ORDER BY FEC_GARANTIA ASC) AS NUMBER " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR = 3 AND BD_AR.STATUS='PROCESADO'" +
                " ORDER BY BD_AR.FEC_GARANTIA ASC", idusuario).ToListAsync();

            //var totalYears = odt.GroupBy(x => x.AA).Count();

            return odt;
        }

        public async Task<string> GetNewOdts(int idusuario)
        {
            List<ODT> odts = await _context.Query<ODT>().FromSql("SELECT ID_AR, BD_NEGOCIOS.ID_NEGOCIO, NO_AR AS NO_ODT, " +
                "BD_NEGOCIOS.DESC_NEGOCIO, " +
                "BD_NEGOCIOS.NO_AFILIACION, " +
                "BD_NEGOCIOS.ESTADO, " +
                "BD_NEGOCIOS.COLONIA, " +
                "CONVERT(VARCHAR,FEC_GARANTIA,103) +' '+ CONVERT(VARCHAR,FEC_GARANTIA,108) AS FEC_GARANTIA, " +
                "BD_NEGOCIOS.LATITUD, " +
                "BD_NEGOCIOS.LONGITUD, " +
                "CONVERT(INT,DAY(FEC_GARANTIA)) AS [DAYS], " +
                "CONVERT(INT,MONTH(FEC_GARANTIA)) AS [MONTHS], " +
                "CONVERT(INT,YEAR(FEC_GARANTIA)) AS [YEARS], " +
                "BD_AR.ID_TIPO_SERVICIO, " +
                "ROW_NUMBER() OVER(ORDER BY FEC_GARANTIA ASC) AS NUMBER " +
                "FROM BD_AR INNER JOIN BD_NEGOCIOS " +
                "ON BD_AR.ID_NEGOCIO = BD_NEGOCIOS.ID_NEGOCIO " +
                "WHERE ID_TECNICO = @p0 AND ID_STATUS_AR = 3 AND BD_AR.STATUS='PROCESADO'" +
                " ORDER BY BD_AR.FEC_GARANTIA ASC", idusuario).ToListAsync();

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
    }
}
