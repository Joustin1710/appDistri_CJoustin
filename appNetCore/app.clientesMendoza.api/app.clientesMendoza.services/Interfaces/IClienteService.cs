using app.clientesMendoza.common.DTOS;

namespace app.clientesMendoza.services.Interfaces
{
    public interface IClienteService
    {
    
        Task<BaseResponse<ClienteDTO>> Insertar(ClienteDTO clienteDTO);

        Task<BaseResponse<ClienteDTO>> SeleccionarUno(int id);

        Task<BaseResponse<List<ClienteDTO>>> SeleccionarTodos();

        Task<BaseResponse<ClienteDTO>> Actualizar(ClienteDTO clienteDTO);

        Task<BaseResponse<string>> Eliminar(int id);
    }
}
