using app.clientesMendoza.dataAccess.context;
using app.clientesMendoza.entities.models;

namespace app.clientesMendoza.dataAccess.Repositories
{
    public class DireccionClienteRepository : CrudGenericService<DireccionCliente>, IDireccionClienteService
    {
        public DireccionClienteRepository(AppDbContext context) : base(context)
        {
        }


        public async Task<DireccionCliente> Insertar(DireccionCliente direccionCliente)
        {

            return await InsertEntity(direccionCliente);
        }


        public async Task Eliminar(int id)
        {
            await DeleteEntity(id);
        }


        public async Task<DireccionCliente> SeleccionarUno(int id)
        {
            return await SelectEntity(id);
        }


        public async Task<List<DireccionCliente>> SeleccionarTodos()
        {
            return await SelectEntitiesAll();
        }


        public async Task Actualizar(DireccionCliente cliente)
        {
            await UpdateEntity(cliente);
        }

    }
}
