using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSgsElavon.DataTTOSD;
using WebApiSgsElavon.Entities;
using WebApiSgsElavon.ModelsTest;

namespace WebApiSgsElavon.Services
{
    public interface IUnidadService
    {
        Task<List<UnidadTecnico>> GetUnidadesTecnico(int idusuario);
    }

    public class UnidadService : IUnidadService
    {
        public GetnetContext _context;

        public Task<List<UnidadTecnico>> GetUnidadesTecnico(int idusuario)
        {
            throw new NotImplementedException();
        }

        //public Task<List<UnidadTecnico>> GetUnidadesTecnico(int idusuario)
        //{
        //    List<UnidadTecnico> unidades = _context.BdUnidades.Join(
        //        _context.BdBitacoraUnidad,
        //        cunidad => cunidad.IdUnidad,
        //        bbunidad => bbunidad
        //        )
        //}
    }
}
