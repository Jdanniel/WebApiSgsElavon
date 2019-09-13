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
        Task<totalODT> totalODTS(int idusuario);
    }

    public class OdtServices : IOdtService
    {
        private readonly ELAVONTESTContext _context;

        public OdtServices(ELAVONTESTContext context)
        {
            _context = context;
        }

        public async Task<totalODT> totalODTS(int idusuario)
        {
            var total = _context.BdAr.Where(x => x.IdTecnico == idusuario && x.IdStatusAr == 3).GroupBy(x => x.IdTecnico).Select(x => new { nuevas = x.Count() }).FirstOrDefaultAsync();
            throw new NotImplementedException();
        }
    }
}
