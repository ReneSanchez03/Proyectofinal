using Microsoft.EntityFrameworkCore;
using Proyectofinal.Shared.Modelo;

namespace Proyectofinal.Server.Data
{
    public class EmpresaContexto : DbContext 
    {
        public EmpresaContexto(DbContextOptions<EmpresaContexto> options) : base(options)
        {
            
        }

        public DbSet<Empresa> Empresas { get; set; }
    }
}