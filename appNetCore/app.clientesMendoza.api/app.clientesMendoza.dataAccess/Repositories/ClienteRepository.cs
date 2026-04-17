using app.clientesMendoza.dataAccess.context;
using app.clientesMendoza.entities.models;
using Microsoft.Identity.Client;

namespace app.clientesMendoza.dataAccess.Repositories
{
    public class ClienteRepository : CrudGenericService<Cliente> , IClienteRepository
    {
        public ClienteRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            await InsertEntity(cliente);
        }

        public Task<Cliente> DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetCLiente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetClientes()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> UpdateCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
        
      
}
