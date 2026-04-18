using app.clientesMendoza.common.DTOS;

namespace app.clientesMendoza.services.Interfaces
{
    public interface IDireccionClienteService
    {
        Task<BaseResponse<DireccionClienteDTO>> Insertar(DireccionClienteDTO dto);

        Task<BaseResponse<DireccionClienteDTO>> SeleccionarUno(int id);

        Task<BaseResponse<List<DireccionClienteDTO>>> SeleccionarTodos();

        Task<BaseResponse<DireccionClienteDTO>> Actualizar(int id, DireccionClienteDTO dto);
            Task<BaseResponse<string>> Eliminar(int id);

    }
}
