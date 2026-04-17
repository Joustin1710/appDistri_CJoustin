using app.clientesMendoza.entities.models;
using Microsoft.EntityFrameworkCore;

namespace app.clientesMendoza.dataAccess.context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DireccionCliente> DireccionClientes { get; set; }

    }
}
