using LibraryDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDAL.DataContext
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options): base(options)
        {

        }

        public DbSet<Libro> Libros { get; set; } = null!;
        public DbSet<Lector> Lector { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
    }
}
