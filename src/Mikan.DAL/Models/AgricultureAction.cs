namespace Mikan.DAL.Models
{
    public class AgricultureAction
    {
        public int MachineId { get; set; }
        public Machine Machine { get; set; }

        public int ResourceId { get; set; }
        public Resource Resource { get; set; }
    }
}
