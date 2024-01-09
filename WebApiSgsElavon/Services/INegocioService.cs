using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSgsElavon.DataTTOSD;
using WebApiSgsElavon.Entities.Requests;

namespace WebApiSgsElavon.Services
{
    public interface INegocioService
    {
        Task<int> UpdateCoordenadas(UpdateCoordenadasRequest request);
    }

    public class NegocioService : INegocioService
    {
        private readonly GetnetContext context;

        public NegocioService(GetnetContext _context)
        {
            context = _context;
        }
        public async Task<int> UpdateCoordenadas(UpdateCoordenadasRequest request)
        {
            try
            {
                var negocios = await context.BdNegocios.Where(x => x.IdNegocio == request.ID_NEGOCIO).FirstOrDefaultAsync();
                negocios.Latitud = request.LATITUD;
                negocios.Longitud = request.LONGITUD;
                await context.SaveChangesAsync();
                var idstatusar = await context.BdArs.Where(x => x.IdAr == request.ID_AR).Select(x => x.IdStatusAr).FirstOrDefaultAsync();
                BdBitacoraNegociosCoordenada coordenadas = new BdBitacoraNegociosCoordenada();
                coordenadas.IdNegocio = request.ID_NEGOCIO;
                coordenadas.IdAr = request.ID_AR;
                coordenadas.Latitud = request.LATITUD;
                coordenadas.Longitud = request.LONGITUD;
                coordenadas.IdUsuarioAlta = request.ID_USUARIO;
                coordenadas.FecAlta = DateTime.Now;
                coordenadas.IdStatusAr = idstatusar;
                await context.BdBitacoraNegociosCoordenadas.AddAsync(coordenadas);
                context.SaveChanges();
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }

        }
    }
}
