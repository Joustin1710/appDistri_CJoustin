using app.clientesMendoza.common.DTOS;

namespace app.clientesMendoza.services.Interfaces
{
    public interface IClienteService
    {
        Task<BaseResponse<ClienteDTO>> CrearCliente(ClienteDTO clienteDTO);

        Task<BaseResponse<ClienteDTO>> ObtenerCliente(int id);

        Task<BaseResponse<List<ClienteDTO>>> ObtenerClientes();

        Task<BaseResponse<ClienteDTO>> ActualizarCliente(ClienteDTO clienteDTO);

        Task<BaseResponse<string>> EliminarCliente(int id);

    }
}
