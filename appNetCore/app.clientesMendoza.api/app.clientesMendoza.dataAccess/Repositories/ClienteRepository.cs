using app.clientesMendoza.dataAccess.context;
using app.clientesMendoza.entities.models;

namespace app.clientesMendoza.dataAccess.Repositories
{
    public class ClienteRepository : CrudGenericService<Cliente> , IClienteRepository
    {
        public ClienteRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            return await InsertEntity(cliente);
        }

        public async Task DeleteCliente(int id)
        {
            await DeleteEntity(id);
        }

        public async Task<Cliente> GetCLiente(int id)
        {
            return await SelectEntity(id);
        }

        public async Task<List<Cliente>> GetClientes()
        {
            return await SelectEntitiesAll();
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            await UpdateEntity(cliente);
        }
    }
        
      
}
