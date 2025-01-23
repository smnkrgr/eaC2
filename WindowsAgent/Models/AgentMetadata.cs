namespace Agent.Models
{
    public class AgentMetadata
    {
        public string Id { get; set; }
        public string Hostname { get; set; }
        public string Username { get; set; }
        public string ProcessName { get; set; }
        public int ProcessId { get; set; }
        public string Integrity { get; set; }
        public string Architecture { get; set; }
    }
}