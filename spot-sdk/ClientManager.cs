using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharks.Spot.RobotSystems;

namespace Sharks.Spot
{
    public partial class Robot
    {
        public Dictionary<Type, ClientBase> Clients = new ();

        public T EnsureClient<T>() where T : ClientBase<T>
        {
            if (Clients.ContainsKey(typeof (T))) return (T)Clients[typeof (T)];

            Clients[typeof (T)] = (T)Activator.CreateInstance(typeof (T), 
                new object[] { EnsureChannelFor(DirectorySystem.ServiceFromName(typeof(T).ToString()).Authority) }
            );

            return (T)Clients[typeof(T)];
        }
    }
}
