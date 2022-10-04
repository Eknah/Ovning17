using Ovnign17.Shared;

namespace Ovning17.Services
{
    public interface IDevicesClient
    {
        Task<IEnumerable<Device>> GetAsync();
    }
}
