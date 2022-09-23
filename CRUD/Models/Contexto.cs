using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRUD.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
