using LibraryContracts;
using LibraryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL
{
    

    public class LibroService : ILibroService
    {
        private readonly ILibroInterface _repoLibro;        

        /// <summary>
        /// Constructor con dependencia requerida(Repositorio) para la inyeccion de dependencia en el IOC
        /// </summary>
        /// <param name="pLibroRepository"></param>
        public LibroService(ILibroInterface pLibroRepository)
        {
            _repoLibro = pLibroRepository;            
        }

        public IEnumerable<Libro> GetLibros()
        {
            return  _repoLibro.GetAllEntity<Libro>().OrderBy(ite=>ite.Nombre);
        }       

        public async Task<bool> InsertarLibro(Libro entity)
        {
           return await _repoLibro.AddEntity<Libro>(entity);
        }


    }
}
