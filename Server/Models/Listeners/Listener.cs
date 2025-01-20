using System.Threading.Tasks;

using Server.Services;

namespace Server.Models
{
    public abstract class Listener
    {
        public abstract string Name { get; }
        protected IAgentService AgentService;

        public void Init(IAgentService agentService)
        {
            AgentService = agentService;
        }
        
        public abstract Task Start();
        public abstract void Stop();
    }
}