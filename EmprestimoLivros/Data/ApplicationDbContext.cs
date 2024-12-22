using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opitions) : base(opitions)
        {
        }


        public DbSet<EmprestimosModel> EmprestimosModels { get; set; }




    }
}
