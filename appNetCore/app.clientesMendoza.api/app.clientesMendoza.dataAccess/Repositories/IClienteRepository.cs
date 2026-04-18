using app.clientesMendoza.entities.models;

namespace app.clientesMendoza.dataAccess.Repositories
{
    public interface IClienteRepository
    {

        Task<Cliente> GetCLiente( int id);

        Task<Cliente> CreateCliente(Cliente cliente);

        Task<List<Cliente>> GetClientes();

        Task UpdateCliente(Cliente cliente);

        Task DeleteCliente(int id);


    }
}
