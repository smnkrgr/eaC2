using System.Collections.Generic;
using System.Linq;

using Server.Models;

namespace Server.Services
{
    public interface IAgentService
    {
        void AddAgent(Agent agent);
        IEnumerable<Agent> GetAgents();
        Agent GetAgent(string id);
        void RemoveAgent(Agent agent);
    }

    public class AgentService : IAgentService
    {
        private readonly List<Agent> _agents = new();
        
        public void AddAgent(Agent agent)
        {
            _agents.Add(agent);
        }

        public IEnumerable<Agent> GetAgents()
        {
            return _agents;
        }

        public Agent GetAgent(string id)
        {
            return GetAgents().FirstOrDefault(a => a.Metadata.Id.Equals(id));
        }

        public void RemoveAgent(Agent agent)
        {
            _agents.Remove(agent);
        }
    }
}