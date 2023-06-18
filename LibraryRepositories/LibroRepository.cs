using LibraryContracts;
using LibraryDAL.DataContext;
using LibraryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepositories
{
    public class LibroRepository : GenericRepository<Libro> , ILibroInterface
    {
        public LibroRepository(LibraryContext paramContext) : base(paramContext) { }
    }
}
