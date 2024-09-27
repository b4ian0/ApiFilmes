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
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmesGs>().HasData(
                new FilmesGs
                {
                    Id = 1,
                    Categoria = "Esporte",
                    Avaliacao = 3,
                    Nome = "Creed III",
                    Classificao = 12,
                    Foto = "https://br.web.img3.acsta.net/c_310_420/pictures/23/02/27/22/17/0078543.jpg",
                    Streaming = "Prime Video",
                    Status = "Ativo"
                },
                new FilmesGs
                {
                    Id = 2,
                    Categoria = "Esporte",
                    Avaliacao = 7,
                    Nome = "Creed II",
                    Classificao = 12,
                    Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRMzHcyqt3k5yEiSiz5nMW6hACS5uZyYcVh2w&s",
                    Streaming = "Prime Video",
                    Status = "Ativo"
                }

            );
        }
    }
}