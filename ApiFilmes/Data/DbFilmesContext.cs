using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiFilmes.Models;

namespace ApiFilmes.Data
{
    public class DbFilmesContext : DbContext
    {
        public DbFilmesContext (DbContextOptions<DbFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<ApiFilmes.Models.FilmesGs> FilmesGs { get; set; } = default!;
    }
}
