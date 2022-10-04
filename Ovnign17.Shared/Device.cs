namespace Ovnign17.Shared
{
    public class Device
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("n");
        public Location? Location { get; set; } = default;
        public DateOnly LastUpdated { get; set; } = default;
        public DeviceType? Type { get; set; } = default;
        public bool IsOnline { get; set; } = false;
    }
}