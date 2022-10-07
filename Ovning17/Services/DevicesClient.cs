using Ovnign17.Shared;

namespace Ovning17.Services
{
    public class DevicesClient : IDevicesClient
    {
        private readonly HttpClient httpClient;
        
        private static Location location = new() { Name = "Vega", Country = "Sweden" };
        private static DeviceType type = new() { Name = "Weather Sensor", Description = "temperature, humidity" };
        private static IEnumerable<Device> devices = new List<Device>()
            {
                new Device()
                {
                    Name = "Maskin A",
                    Location = location,
                    LastUpdated = DateTime.Now.AddDays(Random.Shared.Next(20)).Date,
                    Type = type,
                    IsOnline = Random.Shared.Next(2) == 0 ? true : false
                },
                new Device()
                {
                    Name = "Maskin B",
                    Location = location,
                    LastUpdated = DateTime.Now.AddDays(Random.Shared.Next(20)).Date,
                    Type = type,
                    IsOnline = Random.Shared.Next(2) == 0 ? true : false
                },
                new Device()
                {
                    Name = "Maskin C",
                    Location = location,
                    LastUpdated = DateTime.Now.AddDays(Random.Shared.Next(20)).Date,
                    Type = type,
                    IsOnline = Random.Shared.Next(2) == 0 ? true : false
                },
                new Device()
                {
                    Name = "Maskin D",
                    Location = location,
                    LastUpdated = DateTime.Now.AddDays(Random.Shared.Next(20)).Date,
                    Type = type,
                    IsOnline = Random.Shared.Next(2) == 0 ? true : false
                }
            };

        public DevicesClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            // this.httpClient.BaseAddress
        }

        public async Task<IEnumerable<Device>> GetAsync()
        {
            return devices;
        }
    }
}
