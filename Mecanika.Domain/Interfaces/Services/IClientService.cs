using Mecanika.Domain.DTOs.Create.Client;

namespace Mecanika.Domain.Interfaces.Services
{
    public interface IClientService
    {
        void Add(ClientCreateDTO clientCreateDTO);
    }
}
