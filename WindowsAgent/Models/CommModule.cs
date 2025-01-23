using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Agent.Models
{
    public abstract class CommModule
    {
        public abstract Task Start();
        public abstract void Stop();

        protected AgentMetadata AgentMetadata;

        protected ConcurrentQueue<AgentTask> Inbound = new ConcurrentQueue<AgentTask>();
        protected ConcurrentQueue<AgentTaskResult> Outbound = new ConcurrentQueue<AgentTaskResult>();

        public virtual void Init(AgentMetadata metadata)
        {
            AgentMetadata = metadata;
        }

        public bool RecvData(out IEnumerable<AgentTask> tasks)
        {
            if (Inbound.IsEmpty)
            {
                tasks = null;
                return false;
            }

            var list = new List<AgentTask>();

            while (Inbound.TryDequeue(out var task))
            {
                list.Add(task);
            }

            tasks = list;
            return true;
        }

        public void SendData(AgentTaskResult result)
        {
            Outbound.Enqueue(result);
        }

        protected IEnumerable<AgentTaskResult> GetOutbound()
        {
            var outbound = new List<AgentTaskResult>();

            while (Outbound.TryDequeue(out var taskResult))
            {
                outbound.Add(taskResult);
            }

            return outbound;
        }
    }
}